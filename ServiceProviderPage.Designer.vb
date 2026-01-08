<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceProviderPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnSignout = New System.Windows.Forms.Button()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.cmbBookingStatusList = New System.Windows.Forms.ComboBox()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBookings
        '
        Me.dgvBookings.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Location = New System.Drawing.Point(16, 152)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.Size = New System.Drawing.Size(384, 198)
        Me.dgvBookings.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "GoToPros"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel7.Location = New System.Drawing.Point(12, 37)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(297, 20)
        Me.LinkLabel7.TabIndex = 29
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "The Standard in Home Maintenance"
        '
        'btnAccept
        '
        Me.btnAccept.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.Blue
        Me.btnAccept.Location = New System.Drawing.Point(224, 371)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(87, 34)
        Me.btnAccept.TabIndex = 30
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReject.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.SystemColors.Window
        Me.btnReject.Location = New System.Drawing.Point(317, 371)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(83, 34)
        Me.btnReject.TabIndex = 43
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnSignout
        '
        Me.btnSignout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignout.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSignout.Location = New System.Drawing.Point(705, 404)
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(83, 34)
        Me.btnSignout.TabIndex = 44
        Me.btnSignout.Text = "Sign out"
        Me.btnSignout.UseVisualStyleBackColor = False
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(14, 129)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(166, 20)
        Me.LinkLabel4.TabIndex = 45
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Select booking status "
        '
        'cmbBookingStatusList
        '
        Me.cmbBookingStatusList.FormattingEnabled = True
        Me.cmbBookingStatusList.Location = New System.Drawing.Point(208, 129)
        Me.cmbBookingStatusList.Name = "cmbBookingStatusList"
        Me.cmbBookingStatusList.Size = New System.Drawing.Size(192, 21)
        Me.cmbBookingStatusList.TabIndex = 46
        '
        'ServiceProviderPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GoToPros2025.My.Resources.Resources.WhatsApp_Image_2025_09_24_at_11_24_11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbBookingStatusList)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.btnSignout)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBookings)
        Me.Name = "ServiceProviderPage"
        Me.Text = "ServiceProviderPage"
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnSignout As Button
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents cmbBookingStatusList As ComboBox
End Class
