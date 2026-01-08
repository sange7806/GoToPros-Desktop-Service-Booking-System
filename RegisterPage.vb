Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data

Public Class RegisterPage

    ' ✅ Connection string
    Private Const CONNECTION_STRING As String = "server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;"

    ' ---------------------------
    ' Register Button Click
    ' ---------------------------
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fName As String = txtFName.Text.Trim()
        Dim sName As String = txtSName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim phone As String = txtCellno.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' ✅ Input Validation
        If String.IsNullOrWhiteSpace(fName) OrElse String.IsNullOrWhiteSpace(sName) OrElse
           String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all required fields (First Name, Last Name, Username, and Password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' 🔎 Check if username already exists
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM Clients WHERE username = @username", conn)
                checkCmd.Parameters.AddWithValue("@username", username)
                Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If userCount > 0 Then
                    MessageBox.Show("This username is already taken. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' 📝 Insert new client record (hash password in SQL)
                Dim insertQuery As String =
                    "INSERT INTO Clients (first_name, last_name, username, phone, address, password_hash, date_registered) " &
                    "VALUES (@fName, @sName, @username, @phone, @address, SHA2(@pwd, 256), NOW())"

                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@fName", fName)
                    insertCmd.Parameters.AddWithValue("@sName", sName)
                    insertCmd.Parameters.AddWithValue("@username", username)
                    insertCmd.Parameters.AddWithValue("@phone", phone)
                    insertCmd.Parameters.AddWithValue("@address", address)
                    insertCmd.Parameters.AddWithValue("@pwd", password)

                    insertCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim loginPage As New LoginPage()
            loginPage.Show()

        Catch ex As Exception
            MessageBox.Show("Error during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Cancel Button Click
    ' -----------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Dim loginPage As New LoginPage()
        loginPage.Show()
    End Sub

End Class

