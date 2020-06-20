<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryInformation
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
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRank = New System.Windows.Forms.ComboBox()
        Me.ckCheckall = New System.Windows.Forms.CheckBox()
        Me.rankid = New System.Windows.Forms.TextBox()
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(157, 88)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(181, 30)
        Me.cmdset.TabIndex = 2
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.Location = New System.Drawing.Point(158, 36)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(301, 22)
        Me.txtCategory.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(34, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Category Description"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(339, 88)
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
        'categoryid
        '
        Me.categoryid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.categoryid.ForeColor = System.Drawing.Color.Black
        Me.categoryid.Location = New System.Drawing.Point(13, 96)
        Me.categoryid.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Size = New System.Drawing.Size(34, 22)
        Me.categoryid.TabIndex = 383
        Me.categoryid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.categoryid.Visible = False
        '
        'txtOrder
        '
        Me.txtOrder.DecimalPlaces = 2
        Me.txtOrder.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOrder.Hexadecimal = True
        Me.txtOrder.Location = New System.Drawing.Point(158, 62)
        Me.txtOrder.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(104, 22)
        Me.txtOrder.TabIndex = 387
        Me.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOrder.ThousandsSeparator = True
        Me.txtOrder.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(115, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Order"
        '
        'txtRank
        '
        Me.txtRank.DropDownHeight = 130
        Me.txtRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRank.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRank.ForeColor = System.Drawing.Color.Black
        Me.txtRank.FormattingEnabled = True
        Me.txtRank.IntegralHeight = False
        Me.txtRank.ItemHeight = 13
        Me.txtRank.Location = New System.Drawing.Point(157, 11)
        Me.txtRank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRank.MaxDropDownItems = 7
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(303, 21)
        Me.txtRank.TabIndex = 389
        '
        'ckCheckall
        '
        Me.ckCheckall.AutoSize = True
        Me.ckCheckall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckCheckall.Location = New System.Drawing.Point(67, 13)
        Me.ckCheckall.Name = "ckCheckall"
        Me.ckCheckall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckCheckall.Size = New System.Drawing.Size(86, 19)
        Me.ckCheckall.TabIndex = 391
        Me.ckCheckall.Text = "Select Rank"
        Me.ckCheckall.UseVisualStyleBackColor = True
        '
        'rankid
        '
        Me.rankid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rankid.ForeColor = System.Drawing.Color.Black
        Me.rankid.Location = New System.Drawing.Point(55, 96)
        Me.rankid.Margin = New System.Windows.Forms.Padding(4)
        Me.rankid.Name = "rankid"
        Me.rankid.ReadOnly = True
        Me.rankid.Size = New System.Drawing.Size(34, 22)
        Me.rankid.TabIndex = 392
        Me.rankid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rankid.Visible = False
        '
        'frmCategoryInformation
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(471, 127)
        Me.Controls.Add(Me.rankid)
        Me.Controls.Add(Me.ckCheckall)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmCategoryInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criteria Category"
        Me.TopMost = True
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRank As System.Windows.Forms.ComboBox
    Friend WithEvents ckCheckall As System.Windows.Forms.CheckBox
    Friend WithEvents rankid As System.Windows.Forms.TextBox
End Class
