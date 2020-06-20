<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContestantInformation
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
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtContestantId = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRepresentativeOf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtContestantNumber = New System.Windows.Forms.TextBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(130, 146)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(174, 30)
        Me.cmdset.TabIndex = 9
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtContestantId
        '
        Me.txtContestantId.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContestantId.ForeColor = System.Drawing.Color.Black
        Me.txtContestantId.Location = New System.Drawing.Point(131, 13)
        Me.txtContestantId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContestantId.Name = "txtContestantId"
        Me.txtContestantId.ReadOnly = True
        Me.txtContestantId.Size = New System.Drawing.Size(260, 22)
        Me.txtContestantId.TabIndex = 271
        Me.txtContestantId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFullname.ForeColor = System.Drawing.Color.Black
        Me.txtFullname.Location = New System.Drawing.Point(199, 40)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(192, 22)
        Me.txtFullname.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(46, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Contestant ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(34, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "No. && Fullname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(27, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "Representative of"
        '
        'txtRepresentativeOf
        '
        Me.txtRepresentativeOf.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRepresentativeOf.ForeColor = System.Drawing.Color.Black
        Me.txtRepresentativeOf.Location = New System.Drawing.Point(131, 67)
        Me.txtRepresentativeOf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRepresentativeOf.Name = "txtRepresentativeOf"
        Me.txtRepresentativeOf.Size = New System.Drawing.Size(260, 22)
        Me.txtRepresentativeOf.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(62, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 374
        Me.Label2.Text = "Birth Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(76, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(131, 120)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(260, 22)
        Me.txtAddress.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(306, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CustomFormat = "yyyy-MM-dd"
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirthdate.Location = New System.Drawing.Point(131, 94)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(173, 22)
        Me.txtBirthdate.TabIndex = 3
        Me.txtBirthdate.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(13, 317)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(52, 22)
        Me.mode.TabIndex = 381
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'txtContestantNumber
        '
        Me.txtContestantNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContestantNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContestantNumber.Location = New System.Drawing.Point(131, 40)
        Me.txtContestantNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContestantNumber.Name = "txtContestantNumber"
        Me.txtContestantNumber.Size = New System.Drawing.Size(65, 22)
        Me.txtContestantNumber.TabIndex = 394
        Me.txtContestantNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(13, 223)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Size = New System.Drawing.Size(83, 22)
        Me.batchcode.TabIndex = 395
        Me.batchcode.Visible = False
        '
        'frmContestantInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(406, 181)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.txtContestantNumber)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRepresentativeOf)
        Me.Controls.Add(Me.txtContestantId)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmContestantInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contestant Information"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtContestantId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRepresentativeOf As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtContestantNumber As System.Windows.Forms.TextBox
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
End Class
