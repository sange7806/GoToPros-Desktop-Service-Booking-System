<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSignout = New System.Windows.Forms.Button()
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cmbServiceProvider = New System.Windows.Forms.ComboBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.grpBookService = New System.Windows.Forms.GroupBox()
        Me.btnViewBookings = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookService.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.TabIndex = 5
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
        Me.LinkLabel7.TabIndex = 26
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "The Standard in Home Maintenance"
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyProfile.ForeColor = System.Drawing.Color.Blue
        Me.btnMyProfile.Location = New System.Drawing.Point(705, 37)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(95, 34)
        Me.btnMyProfile.TabIndex = 27
        Me.btnMyProfile.Text = "My Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(761, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'btnSignout
        '
        Me.btnSignout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignout.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSignout.Location = New System.Drawing.Point(705, 404)
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(83, 34)
        Me.btnSignout.TabIndex = 29
        Me.btnSignout.Text = "Sign out"
        Me.btnSignout.UseVisualStyleBackColor = False
        '
        'cmbServices
        '
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.Location = New System.Drawing.Point(252, 33)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(169, 21)
        Me.cmbServices.TabIndex = 30
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 34)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 20)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Choose Service"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 70)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(181, 20)
        Me.LinkLabel2.TabIndex = 32
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Choose Service Provider"
        '
        'cmbServiceProvider
        '
        Me.cmbServiceProvider.FormattingEnabled = True
        Me.cmbServiceProvider.Location = New System.Drawing.Point(252, 70)
        Me.cmbServiceProvider.Name = "cmbServiceProvider"
        Me.cmbServiceProvider.Size = New System.Drawing.Size(169, 21)
        Me.cmbServiceProvider.TabIndex = 33
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(6, 99)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(103, 20)
        Me.LinkLabel3.TabIndex = 34
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Explain Issue"
        '
        'txtIssue
        '
        Me.txtIssue.Location = New System.Drawing.Point(252, 101)
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(169, 20)
        Me.txtIssue.TabIndex = 35
        '
        'btnBook
        '
        Me.btnBook.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.Blue
        Me.btnBook.Location = New System.Drawing.Point(310, 133)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(111, 29)
        Me.btnBook.TabIndex = 36
        Me.btnBook.Text = "Book Service"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'grpBookService
        '
        Me.grpBookService.Controls.Add(Me.LinkLabel1)
        Me.grpBookService.Controls.Add(Me.txtIssue)
        Me.grpBookService.Controls.Add(Me.btnBook)
        Me.grpBookService.Controls.Add(Me.cmbServiceProvider)
        Me.grpBookService.Controls.Add(Me.LinkLabel2)
        Me.grpBookService.Controls.Add(Me.cmbServices)
        Me.grpBookService.Controls.Add(Me.LinkLabel3)
        Me.grpBookService.Location = New System.Drawing.Point(56, 128)
        Me.grpBookService.Name = "grpBookService"
        Me.grpBookService.Size = New System.Drawing.Size(437, 168)
        Me.grpBookService.TabIndex = 37
        Me.grpBookService.TabStop = False
        Me.grpBookService.Text = "Book A Service"
        '
        'btnViewBookings
        '
        Me.btnViewBookings.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBookings.ForeColor = System.Drawing.Color.Blue
        Me.btnViewBookings.Location = New System.Drawing.Point(349, 314)
        Me.btnViewBookings.Name = "btnViewBookings"
        Me.btnViewBookings.Size = New System.Drawing.Size(144, 29)
        Me.btnViewBookings.TabIndex = 38
        Me.btnViewBookings.Text = "View Bookings"
        Me.btnViewBookings.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GoToPros2025.My.Resources.Resources.WhatsApp_Image_2025_09_24_at_11_24_11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewBookings)
        Me.Controls.Add(Me.grpBookService)
        Me.Controls.Add(Me.btnSignout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnMyProfile)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBookService.ResumeLayout(False)
        Me.grpBookService.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents btnMyProfile As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSignout As Button
    Friend WithEvents cmbServices As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents cmbServiceProvider As ComboBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents txtIssue As TextBox
    Friend WithEvents btnBook As Button
    Friend WithEvents grpBookService As GroupBox
    Friend WithEvents btnViewBookings As Button
End Class
