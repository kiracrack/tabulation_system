<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemUpdate))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.txtFeatures = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(105, 192)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(348, 30)
        Me.cmdset.TabIndex = 5
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(22, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Download Url"
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.SystemColors.Window
        Me.txtVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVersion.Location = New System.Drawing.Point(106, 118)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(137, 22)
        Me.txtVersion.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(55, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 364
        Me.Label5.Text = "Version"
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDetails.Location = New System.Drawing.Point(106, 12)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(192, 22)
        Me.txtDetails.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(59, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Details"
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.SystemColors.Window
        Me.txtUrl.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUrl.Location = New System.Drawing.Point(106, 143)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(307, 22)
        Me.txtUrl.TabIndex = 3
        Me.txtUrl.Text = "http://"
        '
        'txtFeatures
        '
        Me.txtFeatures.BackColor = System.Drawing.SystemColors.Window
        Me.txtFeatures.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFeatures.Location = New System.Drawing.Point(106, 37)
        Me.txtFeatures.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFeatures.Multiline = True
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(347, 78)
        Me.txtFeatures.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(50, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Features"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPassword.Location = New System.Drawing.Point(106, 168)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(137, 22)
        Me.txtPassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(44, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(414, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 24)
        Me.Button1.TabIndex = 375
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSystemUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(468, 229)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFeatures)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSystemUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New System Version Updater"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatures As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
