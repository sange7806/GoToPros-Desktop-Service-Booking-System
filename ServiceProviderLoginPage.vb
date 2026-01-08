Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Public Class ServiceProviderLoginPage

    Private ReadOnly connectionString As String = "server=127.0.0.1;user id=root;password=Education$1;database=GoToProsDB;"

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim enteredPasswordHash As String = HashPassword(password)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Get provider_id instead of just counting
                Dim query As String = "SELECT provider_id FROM serviceproviders WHERE email = @Email AND password_hash = @PasswordHash"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@PasswordHash", enteredPasswordHash)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim providerID As Integer = Convert.ToInt32(result)

                        MessageBox.Show("Service Provider login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()

                        ' Pass providerID into ServiceProviderPage
                        Dim providerPage As New ServiceProviderPage(providerID)
                        providerPage.Show()
                    Else
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Hashing function
    Private Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim data As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sBuilder As New StringBuilder()
            For i As Integer = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next
            Return sBuilder.ToString()
        End Using
    End Function

    ' Back button to Client Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        LoginPage.Show()
    End Sub
End Class
