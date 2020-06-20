<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJudgePermission
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
        Me.txtJudgeName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.judgeid = New System.Windows.Forms.TextBox()
        Me.ckCheckall = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(10, 245)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 2
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtJudgeName
        '
        Me.txtJudgeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJudgeName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtJudgeName.ForeColor = System.Drawing.Color.Black
        Me.txtJudgeName.Location = New System.Drawing.Point(10, 12)
        Me.txtJudgeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJudgeName.Name = "txtJudgeName"
        Me.txtJudgeName.ReadOnly = True
        Me.txtJudgeName.Size = New System.Drawing.Size(304, 22)
        Me.txtJudgeName.TabIndex = 1
        Me.txtJudgeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(194, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'judgeid
        '
        Me.judgeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.judgeid.ForeColor = System.Drawing.Color.Black
        Me.judgeid.Location = New System.Drawing.Point(13, 291)
        Me.judgeid.Margin = New System.Windows.Forms.Padding(4)
        Me.judgeid.Name = "judgeid"
        Me.judgeid.ReadOnly = True
        Me.judgeid.Size = New System.Drawing.Size(80, 22)
        Me.judgeid.TabIndex = 383
        Me.judgeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.judgeid.Visible = False
        '
        'ckCheckall
        '
        Me.ckCheckall.AutoSize = True
        Me.ckCheckall.Location = New System.Drawing.Point(10, 226)
        Me.ckCheckall.Name = "ckCheckall"
        Me.ckCheckall.Size = New System.Drawing.Size(70, 17)
        Me.ckCheckall.TabIndex = 385
        Me.ckCheckall.Text = "Check all"
        Me.ckCheckall.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(10, 41)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(303, 179)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmJudgePermission
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(325, 282)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ckCheckall)
        Me.Controls.Add(Me.judgeid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtJudgeName)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmJudgePermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Judge Information"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtJudgeName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents judgeid As System.Windows.Forms.TextBox
    Friend WithEvents ckCheckall As System.Windows.Forms.CheckBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
