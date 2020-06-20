<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankInformation
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
        Me.txtRankDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.rankid = New System.Windows.Forms.TextBox()
        Me.txtRankLimit = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtRankLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(157, 62)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 2
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtRankDescription
        '
        Me.txtRankDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRankDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRankDescription.ForeColor = System.Drawing.Color.Black
        Me.txtRankDescription.Location = New System.Drawing.Point(158, 11)
        Me.txtRankDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRankDescription.Name = "txtRankDescription"
        Me.txtRankDescription.Size = New System.Drawing.Size(301, 22)
        Me.txtRankDescription.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(57, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Rank Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(73, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "Ranking Limit"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(341, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(13, 174)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(52, 22)
        Me.mode.TabIndex = 381
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'rankid
        '
        Me.rankid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rankid.ForeColor = System.Drawing.Color.Black
        Me.rankid.Location = New System.Drawing.Point(73, 174)
        Me.rankid.Margin = New System.Windows.Forms.Padding(4)
        Me.rankid.Name = "rankid"
        Me.rankid.ReadOnly = True
        Me.rankid.Size = New System.Drawing.Size(174, 22)
        Me.rankid.TabIndex = 383
        Me.rankid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rankid.Visible = False
        '
        'txtRankLimit
        '
        Me.txtRankLimit.DecimalPlaces = 2
        Me.txtRankLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRankLimit.Hexadecimal = True
        Me.txtRankLimit.Location = New System.Drawing.Point(158, 37)
        Me.txtRankLimit.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtRankLimit.Name = "txtRankLimit"
        Me.txtRankLimit.Size = New System.Drawing.Size(104, 22)
        Me.txtRankLimit.TabIndex = 1
        Me.txtRankLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRankLimit.ThousandsSeparator = True
        Me.txtRankLimit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmRankInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(471, 102)
        Me.Controls.Add(Me.txtRankLimit)
        Me.Controls.Add(Me.rankid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRankDescription)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmRankInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ranking Category"
        Me.TopMost = True
        CType(Me.txtRankLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRankDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents rankid As System.Windows.Forms.TextBox
    Friend WithEvents txtRankLimit As System.Windows.Forms.NumericUpDown
End Class
