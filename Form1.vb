' Add these at the top of your code file.
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Public Class LoginPage

    ' IMPORTANT: You must replace the placeholders below with your actual database credentials.
    Private ReadOnly connectionString As String = "server=localhost;user id=root;password=Education$1;database=GoToProsDB;"

    ' Event handler for the Sign In button click
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        ' 1. Get user input and validate
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Hash the user's password for secure comparison
        Dim enteredPasswordHash As String = HashPassword(password)

        ' 3. Connect to the database and get the client_id
        Dim retrievedClientID As Integer = -1 ' Initialize a variable to hold the client_id

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' The query now selects the client_id instead of just a count.
                Dim query As String = "SELECT client_id FROM Clients WHERE username = @username AND password_hash = @password_hash"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password_hash", enteredPasswordHash)

                    ' ExecuteScalar returns the first column of the first row, or null if no match.
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        retrievedClientID = Convert.ToInt32(result)
                    End If
                End Using
            End Using

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Error connecting to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Stop execution if connection fails
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' 4. Check the result and handle login success or failure
        If retrievedClientID <> -1 Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Pass the retrieved client_id to the HomePage
            Dim homePage As New HomePage()
            homePage.ClientID = retrievedClientID
            homePage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' This function is crucial for security. It hashes a plain text password using SHA256.
    Private Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim data As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sBuilder As New StringBuilder()

            For i As Integer = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i

            Return sBuilder.ToString()
        End Using
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Navigation
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        RegisterPage.Show()
    End Sub

    Private Sub btnPro_Click(sender As Object, e As EventArgs) Handles btnPro.Click
        Me.Hide()
        ServiceProviderLoginPage.Show()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide()
        ForgotPasswordPage.Show()
    End Sub

End Class


