Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordPage

    Dim conn As New MySqlConnection("server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;sslmode=Preferred;")

    ' -----------------------------
    ' Password Hash Function
    ' -----------------------------
    Private Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' -----------------------------
    ' Submit Button Click
    ' -----------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim newPassword As String = txtNewPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' Validation
        If username = "" Or newPassword = "" Or confirmPassword = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            conn.Open()

            ' Check if username exists in ServiceProviders
            Dim queryProvider As String = "SELECT provider_id FROM ServiceProviders WHERE email=@username"
            Dim cmdProvider As New MySqlCommand(queryProvider, conn)
            cmdProvider.Parameters.AddWithValue("@username", username)
            Dim reader As MySqlDataReader = cmdProvider.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim providerID As Integer = reader("provider_id")
                reader.Close()

                ' Update password
                Dim updateQuery As String = "UPDATE ServiceProviders SET password_hash=@password WHERE provider_id=@id"
                Dim updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@password", HashPassword(newPassword))
                updateCmd.Parameters.AddWithValue("@id", providerID)
                updateCmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginPage.Show()
                Exit Sub
            End If
            reader.Close()

            ' Check if username exists in Clients
            Dim queryClient As String = "SELECT client_id FROM Clients WHERE username=@username"
            Dim cmdClient As New MySqlCommand(queryClient, conn)
            cmdClient.Parameters.AddWithValue("@username", username)
            reader = cmdClient.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim clientID As Integer = reader("client_id")
                reader.Close()

                ' Update password
                Dim updateQuery As String = "UPDATE Clients SET password_hash=@password WHERE client_id=@id"
                Dim updateCmd As New MySqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@password", HashPassword(newPassword))
                updateCmd.Parameters.AddWithValue("@id", clientID)
                updateCmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                LoginPage.Show()
                Exit Sub
            End If
            reader.Close()
            conn.Close()

            ' Username not found
            MessageBox.Show("Username/email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Cancel Button Click
    ' -----------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        LoginPage.Show()
    End Sub

End Class
