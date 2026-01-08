Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ViewBookingsPage

    Dim conn As New MySqlConnection("server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;sslmode=Preferred;")
    Public ClientID As Integer ' Passed from HomePage

    ' -----------------------------
    ' Load bookings on form load
    ' -----------------------------
    Private Sub ViewBookingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookings()
    End Sub

    Private Sub LoadBookings()
        Try
            conn.Open()
            Dim query As String = "SELECT 
                           B.booking_id, 
                           B.category_id, 
                           SP.name AS Provider, 
                           B.issue_description, 
                           B.booking_date, 
                           B.status, 
                           SP.price AS Price,   -- service provider’s price
                           B.amount AS Amount   -- client’s paid amount (if any)
                       FROM Bookings B
                       INNER JOIN ServiceProviders SP ON B.provider_id = SP.provider_id
                       WHERE B.client_id=@clientID"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@clientID", ClientID)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvBookings.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' Pay Button
    ' -----------------------------
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim status As String = dgvBookings.SelectedRows(0).Cells("Status").Value.ToString()
        If status <> "Accepted" Then
            MessageBox.Show("Only accepted bookings can be paid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim amountText As String = txtPayment.Text.Trim()
        Dim amountPaid As Decimal

        If Not Decimal.TryParse(amountText, amountPaid) OrElse amountPaid <= 0 Then
            MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim bookingID As Integer = Convert.ToInt32(dgvBookings.SelectedRows(0).Cells("booking_id").Value)
            conn.Open()
            Dim query As String = "UPDATE Bookings SET Status='Accepted and Paid', amount=@amount WHERE booking_id=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@amount", amountPaid)
            cmd.Parameters.AddWithValue("@id", bookingID)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPayment.Clear()
            LoadBookings()
        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    ' Sign Out
    ' -----------------------------
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

    End Sub
End Class
