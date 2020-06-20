<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriteriaForJudging
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtCriteriaID = New System.Windows.Forms.TextBox()
        Me.txtCriteriaName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.NumericUpDown()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteJudgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        CType(Me.txtScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(124, 117)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(150, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtCriteriaID
        '
        Me.txtCriteriaID.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCriteriaID.ForeColor = System.Drawing.Color.Black
        Me.txtCriteriaID.Location = New System.Drawing.Point(125, 12)
        Me.txtCriteriaID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCriteriaID.Name = "txtCriteriaID"
        Me.txtCriteriaID.ReadOnly = True
        Me.txtCriteriaID.Size = New System.Drawing.Size(257, 22)
        Me.txtCriteriaID.TabIndex = 271
        Me.txtCriteriaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCriteriaName
        '
        Me.txtCriteriaName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriteriaName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCriteriaName.ForeColor = System.Drawing.Color.Black
        Me.txtCriteriaName.Location = New System.Drawing.Point(125, 64)
        Me.txtCriteriaName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCriteriaName.Name = "txtCriteriaName"
        Me.txtCriteriaName.Size = New System.Drawing.Size(257, 22)
        Me.txtCriteriaName.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(61, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Criteria ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(40, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Criteria Name"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(13, 238)
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
        Me.categoryid.Location = New System.Drawing.Point(73, 238)
        Me.categoryid.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Size = New System.Drawing.Size(52, 22)
        Me.categoryid.TabIndex = 382
        Me.categoryid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.categoryid.Visible = False
        '
        'txtScore
        '
        Me.txtScore.DecimalPlaces = 2
        Me.txtScore.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtScore.Location = New System.Drawing.Point(125, 91)
        Me.txtScore.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(104, 22)
        Me.txtScore.TabIndex = 2
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtScore.ThousandsSeparator = True
        Me.txtScore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblScore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblScore.Location = New System.Drawing.Point(10, 94)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(110, 15)
        Me.lblScore.TabIndex = 384
        Me.lblScore.Text = "Score"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOrder
        '
        Me.txtOrder.DecimalPlaces = 2
        Me.txtOrder.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOrder.Hexadecimal = True
        Me.txtOrder.Location = New System.Drawing.Point(278, 91)
        Me.txtOrder.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(104, 22)
        Me.txtOrder.TabIndex = 3
        Me.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOrder.ThousandsSeparator = True
        Me.txtOrder.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(237, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 386
        Me.Label1.Text = "Order"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.DeleteJudgeToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(155, 76)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(151, 6)
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCategoryName.ForeColor = System.Drawing.Color.Black
        Me.txtCategoryName.Location = New System.Drawing.Point(125, 38)
        Me.txtCategoryName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.ReadOnly = True
        Me.txtCategoryName.Size = New System.Drawing.Size(257, 22)
        Me.txtCategoryName.TabIndex = 389
        Me.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(65, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 388
        Me.Label2.Text = "Category"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(278, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.document__pencil
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Selected"
        '
        'DeleteJudgeToolStripMenuItem
        '
        Me.DeleteJudgeToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.notebook__minus
        Me.DeleteJudgeToolStripMenuItem.Name = "DeleteJudgeToolStripMenuItem"
        Me.DeleteJudgeToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteJudgeToolStripMenuItem.Text = "Delete Selected"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.JudgingSystem.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(154, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(388, 12)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(395, 135)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.WordWrap = False
        '
        'Em
        '
        Me.Em.AllowUserToAddRows = False
        Me.Em.AllowUserToDeleteRows = False
        Me.Em.AllowUserToResizeColumns = False
        Me.Em.AllowUserToResizeRows = False
        Me.Em.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Em.BackgroundColor = System.Drawing.Color.White
        Me.Em.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Em.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Em.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Em.ContextMenuStrip = Me.cms_em
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Em.DefaultCellStyle = DataGridViewCellStyle2
        Me.Em.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Em.Location = New System.Drawing.Point(11, 153)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
        Me.Em.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Em.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Em.RowHeadersVisible = False
        Me.Em.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Em.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Em.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Em.Size = New System.Drawing.Size(772, 327)
        Me.Em.TabIndex = 393
        '
        'frmCriteriaForJudging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(792, 488)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCategoryName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtCriteriaID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCriteriaName)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmCriteriaForJudging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criteria for Judging"
        Me.TopMost = True
        CType(Me.txtScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCriteriaName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCriteriaID As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents txtOrder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DeleteJudgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Em As System.Windows.Forms.DataGridView
End Class
