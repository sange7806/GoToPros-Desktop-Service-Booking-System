Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class MyProfilePage

    Dim conn As New MySqlConnection("server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;sslmode=Preferred;")
    Public ClientID As Integer ' Passed from HomePage or LoginPage

    ' -----------------------------
    ' Load Profile on Form Load
    ' -----------------------------
    Private Sub MyProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

    Private Sub LoadProfile()
        Try
            conn.Open()
            Dim query As String = "SELECT first_name, last_name, username, phone, address FROM Clients WHERE client_id=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", ClientID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtFName.Text = reader("first_name").ToString()
                txtSName.Text = reader("last_name").ToString()
                txtUsername.Text = reader("username").ToString()
                txtAddress.Text = reader("address").ToString()
                txtCellno.Text = reader("phone").ToString()
                txtPassword.Text = "" ' Leave blank for security
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
    ' Edit/Save Button
    ' -----------------------------
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim fName As String = txtFName.Text.Trim()
        Dim sName As String = txtSName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim phone As String = txtCellno.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If fName = "" Or sName = "" Or username = "" Then
            MessageBox.Show("First name, Last name, and Username are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String
            Dim cmd As New MySqlCommand()

            If password <> "" Then
                ' Update with new password
                query = "UPDATE Clients SET first_name=@fname, last_name=@lname, username=@username, address=@address, phone=@phone, password_hash=@password WHERE client_id=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@password", HashPassword(password))
            Else
                ' Update without changing password
                query = "UPDATE Clients SET first_name=@fname, last_name=@lname, username=@username, address=@address, phone=@phone WHERE client_id=@id"
                cmd = New MySqlCommand(query, conn)
            End If

            cmd.Parameters.AddWithValue("@fname", fName)
            cmd.Parameters.AddWithValue("@lname", sName)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@id", ClientID)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Back Button
    ' -----------------------------
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim home As New HomePage()
        home.ClientID = Me.ClientID
        home.Show()
        Me.Hide()
    End Sub

    ' -----------------------------
    ' SignOut Button
    ' -----------------------------
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

End Class
