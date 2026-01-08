<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfilePage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCellno = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.btnSignout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(34, 18)
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
        Me.LinkLabel7.Location = New System.Drawing.Point(35, 57)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(297, 20)
        Me.LinkLabel7.TabIndex = 28
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "The Standard in Home Maintenance"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(188, 114)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(86, 20)
        Me.LinkLabel2.TabIndex = 29
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "First Name"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(188, 157)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(110, 20)
        Me.LinkLabel3.TabIndex = 30
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Second Name"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(188, 200)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 20)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Username"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(188, 238)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(68, 20)
        Me.LinkLabel4.TabIndex = 32
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Address"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(188, 282)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(59, 20)
        Me.LinkLabel5.TabIndex = 33
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Cell No"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Location = New System.Drawing.Point(188, 325)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel6.TabIndex = 34
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(343, 325)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(145, 20)
        Me.txtPassword.TabIndex = 35
        '
        'txtCellno
        '
        Me.txtCellno.Location = New System.Drawing.Point(343, 282)
        Me.txtCellno.Name = "txtCellno"
        Me.txtCellno.Size = New System.Drawing.Size(145, 20)
        Me.txtCellno.TabIndex = 36
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(343, 238)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(145, 20)
        Me.txtAddress.TabIndex = 37
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(343, 200)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(145, 20)
        Me.txtUsername.TabIndex = 38
        '
        'txtSName
        '
        Me.txtSName.BackColor = System.Drawing.Color.White
        Me.txtSName.Location = New System.Drawing.Point(343, 157)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(145, 20)
        Me.txtSName.TabIndex = 39
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFName.Location = New System.Drawing.Point(343, 114)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(145, 20)
        Me.txtFName.TabIndex = 40
        '
        'btnSignout
        '
        Me.btnSignout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignout.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSignout.Location = New System.Drawing.Point(705, 404)
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(83, 34)
        Me.btnSignout.TabIndex = 41
        Me.btnSignout.Text = "Sign out"
        Me.btnSignout.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBack.Location = New System.Drawing.Point(616, 404)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 34)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Blue
        Me.btnEdit.Location = New System.Drawing.Point(401, 351)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 34)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'MyProfilePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GoToPros2025.My.Resources.Resources.WhatsApp_Image_2025_09_24_at_11_24_11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSignout)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCellno)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LinkLabel6)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MyProfilePage"
        Me.Text = "MyProfilePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtCellno As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents btnSignout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEdit As Button
End Class
