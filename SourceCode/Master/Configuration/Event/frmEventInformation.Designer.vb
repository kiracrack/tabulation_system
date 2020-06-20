<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventInformation
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
        Me.txtEventID = New System.Windows.Forms.TextBox()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEventCategory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEventOrganizer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDateEvent = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEventTitle = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtScoretype = New System.Windows.Forms.ComboBox()
        Me.txtContestantType = New System.Windows.Forms.ComboBox()
        Me.txtComputation = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSymbolInUse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckEnableDeduction = New System.Windows.Forms.CheckBox()
        Me.ckEnableAverageTotal = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(94, 324)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 9
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtEventID
        '
        Me.txtEventID.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEventID.ForeColor = System.Drawing.Color.Black
        Me.txtEventID.Location = New System.Drawing.Point(158, 11)
        Me.txtEventID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.ReadOnly = True
        Me.txtEventID.Size = New System.Drawing.Size(301, 22)
        Me.txtEventID.TabIndex = 271
        Me.txtEventID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEventName
        '
        Me.txtEventName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEventName.ForeColor = System.Drawing.Color.Black
        Me.txtEventName.Location = New System.Drawing.Point(158, 37)
        Me.txtEventName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(301, 22)
        Me.txtEventName.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(102, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Event ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(81, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Event Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(65, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "Event Category"
        '
        'txtEventCategory
        '
        Me.txtEventCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEventCategory.ForeColor = System.Drawing.Color.Black
        Me.txtEventCategory.Location = New System.Drawing.Point(158, 63)
        Me.txtEventCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventCategory.Name = "txtEventCategory"
        Me.txtEventCategory.Size = New System.Drawing.Size(301, 22)
        Me.txtEventCategory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(89, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 374
        Me.Label2.Text = "Event Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(62, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Event Organizer"
        '
        'txtEventOrganizer
        '
        Me.txtEventOrganizer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEventOrganizer.ForeColor = System.Drawing.Color.Black
        Me.txtEventOrganizer.Location = New System.Drawing.Point(158, 141)
        Me.txtEventOrganizer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventOrganizer.Name = "txtEventOrganizer"
        Me.txtEventOrganizer.Size = New System.Drawing.Size(301, 22)
        Me.txtEventOrganizer.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(280, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDateEvent
        '
        Me.txtDateEvent.CustomFormat = "yyyy-MM-dd"
        Me.txtDateEvent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateEvent.Location = New System.Drawing.Point(158, 115)
        Me.txtDateEvent.Name = "txtDateEvent"
        Me.txtDateEvent.Size = New System.Drawing.Size(181, 22)
        Me.txtDateEvent.TabIndex = 3
        Me.txtDateEvent.Value = New Date(2011, 12, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(90, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "Event Title"
        '
        'txtEventTitle
        '
        Me.txtEventTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEventTitle.ForeColor = System.Drawing.Color.Black
        Me.txtEventTitle.Location = New System.Drawing.Point(158, 89)
        Me.txtEventTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEventTitle.Name = "txtEventTitle"
        Me.txtEventTitle.Size = New System.Drawing.Size(301, 22)
        Me.txtEventTitle.TabIndex = 2
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(13, 338)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(52, 22)
        Me.mode.TabIndex = 381
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(89, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 15)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "Setting and Configuration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(58, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 384
        Me.Label6.Text = "Contestant Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(87, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 386
        Me.Label7.Text = "Score Type"
        '
        'txtScoretype
        '
        Me.txtScoretype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtScoretype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtScoretype.FormattingEnabled = True
        Me.txtScoretype.Items.AddRange(New Object() {"SINGLE", "DOUBLE"})
        Me.txtScoretype.Location = New System.Drawing.Point(158, 224)
        Me.txtScoretype.Name = "txtScoretype"
        Me.txtScoretype.Size = New System.Drawing.Size(119, 21)
        Me.txtScoretype.TabIndex = 6
        '
        'txtContestantType
        '
        Me.txtContestantType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContestantType.FormattingEnabled = True
        Me.txtContestantType.Items.AddRange(New Object() {"Contestant", "Candidates", "Groups", "Competitors", "Contenders", "Challengers"})
        Me.txtContestantType.Location = New System.Drawing.Point(158, 198)
        Me.txtContestantType.Name = "txtContestantType"
        Me.txtContestantType.Size = New System.Drawing.Size(182, 21)
        Me.txtContestantType.TabIndex = 5
        '
        'txtComputation
        '
        Me.txtComputation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtComputation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtComputation.FormattingEnabled = True
        Me.txtComputation.Items.AddRange(New Object() {"POINTS", "AVERAGE"})
        Me.txtComputation.Location = New System.Drawing.Point(158, 249)
        Me.txtComputation.Name = "txtComputation"
        Me.txtComputation.Size = New System.Drawing.Size(119, 21)
        Me.txtComputation.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(74, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 389
        Me.Label8.Text = "Computation"
        '
        'txtSymbolInUse
        '
        Me.txtSymbolInUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSymbolInUse.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSymbolInUse.FormattingEnabled = True
        Me.txtSymbolInUse.Items.AddRange(New Object() {"PERCENT", "POINTS"})
        Me.txtSymbolInUse.Location = New System.Drawing.Point(158, 274)
        Me.txtSymbolInUse.Name = "txtSymbolInUse"
        Me.txtSymbolInUse.Size = New System.Drawing.Size(119, 21)
        Me.txtSymbolInUse.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(70, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 391
        Me.Label9.Text = "Symbol in Use"
        '
        'ckEnableDeduction
        '
        Me.ckEnableDeduction.AutoSize = True
        Me.ckEnableDeduction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableDeduction.Location = New System.Drawing.Point(155, 300)
        Me.ckEnableDeduction.Name = "ckEnableDeduction"
        Me.ckEnableDeduction.Size = New System.Drawing.Size(124, 19)
        Me.ckEnableDeduction.TabIndex = 392
        Me.ckEnableDeduction.Text = "Enable Deductions"
        Me.ckEnableDeduction.UseVisualStyleBackColor = True
        '
        'ckEnableAverageTotal
        '
        Me.ckEnableAverageTotal.AutoSize = True
        Me.ckEnableAverageTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableAverageTotal.Location = New System.Drawing.Point(281, 251)
        Me.ckEnableAverageTotal.Name = "ckEnableAverageTotal"
        Me.ckEnableAverageTotal.Size = New System.Drawing.Size(101, 19)
        Me.ckEnableAverageTotal.TabIndex = 393
        Me.ckEnableAverageTotal.Text = "Show Average"
        Me.ckEnableAverageTotal.UseVisualStyleBackColor = True
        '
        'frmEventInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(472, 361)
        Me.Controls.Add(Me.ckEnableAverageTotal)
        Me.Controls.Add(Me.ckEnableDeduction)
        Me.Controls.Add(Me.txtSymbolInUse)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtComputation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContestantType)
        Me.Controls.Add(Me.txtScoretype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEventTitle)
        Me.Controls.Add(Me.txtDateEvent)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEventOrganizer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEventCategory)
        Me.Controls.Add(Me.txtEventID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmEventInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Information"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEventID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEventCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEventOrganizer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDateEvent As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEventTitle As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtScoretype As System.Windows.Forms.ComboBox
    Friend WithEvents txtContestantType As System.Windows.Forms.ComboBox
    Friend WithEvents txtComputation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSymbolInUse As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckEnableDeduction As System.Windows.Forms.CheckBox
    Friend WithEvents ckEnableAverageTotal As System.Windows.Forms.CheckBox
End Class
