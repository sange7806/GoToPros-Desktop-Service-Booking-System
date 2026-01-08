Imports MySql.Data.MySqlClient

Public Class HomePage

    Dim conn As New MySqlConnection("server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;sslmode=Preferred;")
    Public ClientID As Integer ' Passed from LoginPage

    ' -----------------------------
    ' Load Services on Form Load
    ' -----------------------------
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub

    ' -----------------------------
    ' Fixed service categories (manual mapping)
    ' -----------------------------
    Private Sub LoadServices()
        Try
            Dim dt As New DataTable()
            dt.Columns.Add("category_id", GetType(Integer))
            dt.Columns.Add("category_name", GetType(String))

            ' Add fixed categories
            dt.Rows.Add(1, "Electrical")
            dt.Rows.Add(2, "Painting")
            dt.Rows.Add(3, "Plumbing")
            dt.Rows.Add(4, "Landscaping")

            cmbServices.DataSource = dt
            cmbServices.DisplayMember = "category_name"
            cmbServices.ValueMember = "category_id"
            cmbServices.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Load Service Providers based on selected service
    ' -----------------------------
    Private Sub cmbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServices.SelectedIndexChanged
        If cmbServices.SelectedIndex <> -1 AndAlso TypeOf cmbServices.SelectedValue IsNot DataRowView Then
            Dim categoryID As Integer = Convert.ToInt32(cmbServices.SelectedValue)
            LoadProviders(categoryID)
        End If
    End Sub

    Private Sub LoadProviders(categoryID As Integer)
        Try
            conn.Open()
            Dim query As String = "SELECT provider_id, name FROM ServiceProviders WHERE category_id=@catID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@catID", categoryID)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            cmbServiceProvider.DataSource = dt
            cmbServiceProvider.DisplayMember = "name"
            cmbServiceProvider.ValueMember = "provider_id"
            cmbServiceProvider.SelectedIndex = -1
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading providers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Book Service Button
    ' -----------------------------
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If cmbServices.SelectedIndex = -1 Or cmbServiceProvider.SelectedIndex = -1 Or txtIssue.Text.Trim() = "" Then
            MessageBox.Show("Please select a service, a provider, and enter your issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO Bookings (client_id, provider_id, category_id, issue_description, status) 
                                   VALUES (@clientID, @providerID, @categoryID, @issue, 'Pending')"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@clientID", ClientID)
            cmd.Parameters.AddWithValue("@providerID", cmbServiceProvider.SelectedValue)
            cmd.Parameters.AddWithValue("@categoryID", cmbServices.SelectedValue)
            cmd.Parameters.AddWithValue("@issue", txtIssue.Text.Trim())
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Booking submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear selections
            cmbServices.SelectedIndex = -1
            cmbServiceProvider.DataSource = Nothing
            txtIssue.Clear()

        Catch ex As Exception
            MessageBox.Show("Error booking service: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' View Bookings
    ' -----------------------------
    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click
        Dim viewPage As New ViewBookingsPage()
        viewPage.ClientID = Me.ClientID
        viewPage.Show()
        Me.Hide()
    End Sub

    ' -----------------------------
    ' Sign Out
    ' -----------------------------
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

    ' -----------------------------
    ' My Profile
    ' -----------------------------
    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        Dim profilePage As New MyProfilePage()
        profilePage.ClientID = Me.ClientID
        profilePage.Show()
        Me.Hide()
    End Sub

End Class

