<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneralSettings))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtoffice = New System.Windows.Forms.ComboBox()
        Me.lblcontactperson = New System.Windows.Forms.Label()
        Me.txtemailaddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtofficerinchange = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.officerid = New System.Windows.Forms.TextBox()
        Me.ckEnableEmailNotification = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServerEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSmtpHost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGlobalOrgname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServerPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(177, 246)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(198, 30)
        Me.cmdset.TabIndex = 8
        Me.cmdset.Text = "Save Settings"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtoffice
        '
        Me.txtoffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtoffice.ForeColor = System.Drawing.Color.Black
        Me.txtoffice.FormattingEnabled = True
        Me.txtoffice.ItemHeight = 13
        Me.txtoffice.Location = New System.Drawing.Point(177, 43)
        Me.txtoffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Size = New System.Drawing.Size(198, 21)
        Me.txtoffice.TabIndex = 0
        '
        'lblcontactperson
        '
        Me.lblcontactperson.AutoSize = True
        Me.lblcontactperson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcontactperson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblcontactperson.Location = New System.Drawing.Point(98, 45)
        Me.lblcontactperson.Name = "lblcontactperson"
        Me.lblcontactperson.Size = New System.Drawing.Size(73, 15)
        Me.lblcontactperson.TabIndex = 352
        Me.lblcontactperson.Text = "Select Office"
        '
        'txtemailaddress
        '
        Me.txtemailaddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtemailaddress.ForeColor = System.Drawing.Color.Black
        Me.txtemailaddress.Location = New System.Drawing.Point(177, 68)
        Me.txtemailaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemailaddress.Name = "txtemailaddress"
        Me.txtemailaddress.ReadOnly = True
        Me.txtemailaddress.Size = New System.Drawing.Size(198, 22)
        Me.txtemailaddress.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(90, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 353
        Me.Label13.Text = "Email Address"
        '
        'txtofficerinchange
        '
        Me.txtofficerinchange.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtofficerinchange.ForeColor = System.Drawing.Color.Black
        Me.txtofficerinchange.Location = New System.Drawing.Point(177, 93)
        Me.txtofficerinchange.Margin = New System.Windows.Forms.Padding(4)
        Me.txtofficerinchange.Name = "txtofficerinchange"
        Me.txtofficerinchange.ReadOnly = True
        Me.txtofficerinchange.Size = New System.Drawing.Size(198, 22)
        Me.txtofficerinchange.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(76, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 355
        Me.Label2.Text = "Officer Inchange"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(177, 118)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(198, 22)
        Me.txtPosition.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(121, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Position"
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(13, 152)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(50, 22)
        Me.officeid.TabIndex = 359
        Me.officeid.Visible = False
        '
        'officerid
        '
        Me.officerid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officerid.ForeColor = System.Drawing.Color.Black
        Me.officerid.Location = New System.Drawing.Point(71, 152)
        Me.officerid.Margin = New System.Windows.Forms.Padding(4)
        Me.officerid.Name = "officerid"
        Me.officerid.ReadOnly = True
        Me.officerid.Size = New System.Drawing.Size(50, 22)
        Me.officerid.TabIndex = 360
        Me.officerid.Visible = False
        '
        'ckEnableEmailNotification
        '
        Me.ckEnableEmailNotification.AutoSize = True
        Me.ckEnableEmailNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableEmailNotification.ForeColor = System.Drawing.Color.Black
        Me.ckEnableEmailNotification.Location = New System.Drawing.Point(177, 152)
        Me.ckEnableEmailNotification.Name = "ckEnableEmailNotification"
        Me.ckEnableEmailNotification.Size = New System.Drawing.Size(139, 19)
        Me.ckEnableEmailNotification.TabIndex = 4
        Me.ckEnableEmailNotification.Text = "Enable Email Sending"
        Me.ckEnableEmailNotification.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(114, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Password"
        '
        'txtServerEmail
        '
        Me.txtServerEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtServerEmail.ForeColor = System.Drawing.Color.Black
        Me.txtServerEmail.Location = New System.Drawing.Point(177, 198)
        Me.txtServerEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerEmail.Name = "txtServerEmail"
        Me.txtServerEmail.ReadOnly = True
        Me.txtServerEmail.Size = New System.Drawing.Size(198, 22)
        Me.txtServerEmail.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(55, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 364
        Me.Label5.Text = "Server Email Address"
        '
        'txtSmtpHost
        '
        Me.txtSmtpHost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSmtpHost.ForeColor = System.Drawing.Color.Black
        Me.txtSmtpHost.Location = New System.Drawing.Point(177, 173)
        Me.txtSmtpHost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSmtpHost.Name = "txtSmtpHost"
        Me.txtSmtpHost.ReadOnly = True
        Me.txtSmtpHost.Size = New System.Drawing.Size(198, 22)
        Me.txtSmtpHost.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(105, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 362
        Me.Label6.Text = "SMTP Host"
        '
        'txtGlobalOrgname
        '
        Me.txtGlobalOrgname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGlobalOrgname.ForeColor = System.Drawing.Color.Black
        Me.txtGlobalOrgname.Location = New System.Drawing.Point(177, 17)
        Me.txtGlobalOrgname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGlobalOrgname.Name = "txtGlobalOrgname"
        Me.txtGlobalOrgname.ReadOnly = True
        Me.txtGlobalOrgname.Size = New System.Drawing.Size(198, 22)
        Me.txtGlobalOrgname.TabIndex = 367
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(24, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Global Organization Name"
        '
        'txtServerPassword
        '
        Me.txtServerPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtServerPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtServerPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServerPassword.Location = New System.Drawing.Point(177, 223)
        Me.txtServerPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtServerPassword.ReadOnly = True
        Me.txtServerPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtServerPassword.TabIndex = 369
        '
        'frmGeneralSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(388, 285)
        Me.Controls.Add(Me.txtServerPassword)
        Me.Controls.Add(Me.txtGlobalOrgname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtServerEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSmtpHost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ckEnableEmailNotification)
        Me.Controls.Add(Me.officerid)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtofficerinchange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtemailaddress)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.lblcontactperson)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGeneralSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "General Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtoffice As System.Windows.Forms.ComboBox
    Friend WithEvents lblcontactperson As System.Windows.Forms.Label
    Friend WithEvents txtemailaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtofficerinchange As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents officerid As System.Windows.Forms.TextBox
    Friend WithEvents ckEnableEmailNotification As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServerEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSmtpHost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGlobalOrgname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServerPassword As System.Windows.Forms.TextBox
End Class
