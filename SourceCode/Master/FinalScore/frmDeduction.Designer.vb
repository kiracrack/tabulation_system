<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeduction
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
        Me.txtContestant = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.contestantid = New System.Windows.Forms.TextBox()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(12, 207)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 2
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtContestant
        '
        Me.txtContestant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContestant.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContestant.ForeColor = System.Drawing.Color.Black
        Me.txtContestant.Location = New System.Drawing.Point(13, 10)
        Me.txtContestant.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContestant.Name = "txtContestant"
        Me.txtContestant.ReadOnly = True
        Me.txtContestant.Size = New System.Drawing.Size(301, 22)
        Me.txtContestant.TabIndex = 0
        Me.txtContestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(194, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'contestantid
        '
        Me.contestantid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.contestantid.ForeColor = System.Drawing.Color.Black
        Me.contestantid.Location = New System.Drawing.Point(376, 305)
        Me.contestantid.Margin = New System.Windows.Forms.Padding(4)
        Me.contestantid.Name = "contestantid"
        Me.contestantid.ReadOnly = True
        Me.contestantid.Size = New System.Drawing.Size(51, 22)
        Me.contestantid.TabIndex = 383
        Me.contestantid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.contestantid.Visible = False
        '
        'txtDeduction
        '
        Me.txtDeduction.BackColor = System.Drawing.Color.Red
        Me.txtDeduction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeduction.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.txtDeduction.ForeColor = System.Drawing.Color.White
        Me.txtDeduction.Location = New System.Drawing.Point(172, 35)
        Me.txtDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.Size = New System.Drawing.Size(142, 29)
        Me.txtDeduction.TabIndex = 384
        Me.txtDeduction.Text = "0"
        Me.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(44, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 385
        Me.Label10.Text = "Total Deductions"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(13, 84)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(301, 118)
        Me.txtRemarks.TabIndex = 386
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 387
        Me.Label1.Text = "Deduction Remarks"
        '
        'frmDeduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(321, 246)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.contestantid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContestant)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmDeduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtContestant As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents contestantid As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduction As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
