Imports MySql.Data.MySqlClient
Imports System.Data ' Required for ConnectionState, DataTable, etc.

Public Class ServiceProviderPage

    ' NOTE: In a real application, the connection string should be secured 
    ' (e.g., stored in a configuration file).
    Private Const CONNECTION_STRING As String = "server=127.0.0.1;port=3306;userid=root;password=Education$1;database=GoToProsDB;sslmode=Preferred;"

    ' Private field to securely store the ID of the logged-in provider.
    Private ReadOnly _providerID As Integer

    ' --- CONSTRUCTOR: REQUIRES providerID PASSED FROM LOGIN ---
    Public Sub New(ByVal providerID As Integer)
        ' This call is required by the designer (WinForms).
        InitializeComponent()

        ' Store the provider ID passed from the login page.
        Me._providerID = providerID
    End Sub
    ' -----------------------------------------------------------

    ' -----------------------------
    ' Form Load (Entry point for data loading)
    ' -----------------------------
    Private Sub ServiceProviderPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize combo box options
        cmbBookingStatusList.Items.Clear()
        cmbBookingStatusList.Items.Add("Pending")
        cmbBookingStatusList.Items.Add("Accepted")
        cmbBookingStatusList.Items.Add("Accepted and Paid")
        cmbBookingStatusList.Items.Add("Rejected")

        ' Select "Pending" by default and call the data loading method
        cmbBookingStatusList.SelectedIndex = 0
        LoadBookings("Pending")
    End Sub

    ' -----------------------------
    ' Load Bookings Method (Fetches data from DB)
    ' -----------------------------
    Private Sub LoadBookings(status As String)
        ' Use Using block to ensure the connection is properly closed and disposed
        Using conn As New MySqlConnection(CONNECTION_STRING)
            Try
                conn.Open()

                Dim query As String =
                "SELECT B.booking_id,
                        CONCAT(C.first_name, ' ', C.last_name) AS ClientName,
                        B.category_id,
                        B.issue_description,
                        B.booking_date,
                        B.status,
                        B.amount
                 FROM bookings B
                 INNER JOIN clients C ON B.client_id = C.client_id
                 WHERE B.provider_id=@providerID AND B.status LIKE @status
                 ORDER BY B.booking_date DESC"

                Using cmd As New MySqlCommand(query, conn)
                    ' This uses the provider ID passed from the LoginPage
                    cmd.Parameters.AddWithValue("@providerID", _providerID)

                    ' Handle "Accepted and Paid" filter using LIKE
                    Dim statusFilter As String = status
                    If status = "Accepted and Paid" Then
                        statusFilter = "%Paid%"
                    End If
                    cmd.Parameters.AddWithValue("@status", statusFilter)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        dgvBookings.DataSource = dt
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading bookings for ID " & _providerID.ToString() & ": " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' -----------------------------
    ' ComboBox Change Event
    ' -----------------------------
    Private Sub cmbBookingsStatusList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookingStatusList.SelectedIndexChanged
        If cmbBookingStatusList.SelectedIndex <> -1 Then
            ' Reloads data whenever the filter changes
            LoadBookings(cmbBookingStatusList.SelectedItem.ToString())
        End If
    End Sub

    ' -----------------------------
    ' Accept Booking
    ' -----------------------------
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If Not CheckSelectionAndStatus("Pending", "accept") Then
            Exit Sub
        End If

        UpdateBookingStatus("Accepted")
    End Sub

    ' -----------------------------
    ' Reject Booking
    ' -----------------------------
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If Not CheckSelectionAndStatus("Pending", "reject") Then
            Exit Sub
        End If

        UpdateBookingStatus("Rejected")
    End Sub

    ' -----------------------------
    ' View Bookings (Reloads current filtered data)
    ' -----------------------------
    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs)
        ' This button explicitly reloads the data based on the status currently selected in the ComboBox.
        If cmbBookingStatusList.SelectedIndex <> -1 Then
            LoadBookings(cmbBookingStatusList.SelectedItem.ToString())
        Else
            MessageBox.Show("Please select a booking status filter.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' -----------------------------
    ' Helper to Check DGV Selection and Status
    ' -----------------------------
    Private Function CheckSelectionAndStatus(requiredStatus As String, action As String) As Boolean
        If dgvBookings.SelectedRows.Count = 0 Then
            MessageBox.Show($"Please select a booking to {action}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Note: Use the column name used in the SQL query (status)
        Dim status As String = dgvBookings.SelectedRows(0).Cells("status").Value.ToString()
        If status <> requiredStatus Then
            MessageBox.Show($"Only {requiredStatus} bookings can be {action}ed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' -----------------------------
    ' Update Status Helper (Refactored with Using block)
    ' -----------------------------
    Private Sub UpdateBookingStatus(newStatus As String)
        If dgvBookings.SelectedRows.Count = 0 Then Return

        Dim bookingID As Integer
        Try
            ' Ensure the column name matches the SQL result set
            bookingID = Convert.ToInt32(dgvBookings.SelectedRows(0).Cells("booking_id").Value)
        Catch ex As Exception
            MessageBox.Show("Invalid booking selection or ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Using conn As New MySqlConnection(CONNECTION_STRING)
            Try
                conn.Open()

                Dim query As String = "UPDATE bookings SET status=@status WHERE booking_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", bookingID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Booking {newStatus} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Booking update failed. Record not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                ' Reload bookings after update
                LoadBookings(cmbBookingStatusList.SelectedItem.ToString())

            Catch ex As Exception
                MessageBox.Show("Error updating booking status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' -----------------------------
    ' Sign Out
    ' -----------------------------
    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        ' Retaining original logic for the user's environment:
        LoginPage.Show()
        Me.Hide()
    End Sub

End Class