<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankTitle
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.txtRank = New System.Windows.Forms.NumericUpDown()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteJudgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        CType(Me.txtRank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(155, 56)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(150, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Continue Save"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(86, 29)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(328, 22)
        Me.txtDescription.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(83, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Title Description"
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
        Me.categoryid.Location = New System.Drawing.Point(73, 174)
        Me.categoryid.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Size = New System.Drawing.Size(52, 22)
        Me.categoryid.TabIndex = 382
        Me.categoryid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.categoryid.Visible = False
        '
        'txtRank
        '
        Me.txtRank.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRank.Location = New System.Drawing.Point(19, 29)
        Me.txtRank.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(64, 22)
        Me.txtRank.TabIndex = 1
        Me.txtRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRank.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblScore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblScore.Location = New System.Drawing.Point(16, 11)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(33, 15)
        Me.lblScore.TabIndex = 384
        Me.lblScore.Text = "Rank"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Em
        '
        Me.Em.AllowUserToAddRows = False
        Me.Em.AllowUserToDeleteRows = False
        Me.Em.AllowUserToResizeColumns = False
        Me.Em.AllowUserToResizeRows = False
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Em.Location = New System.Drawing.Point(10, 93)
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
        Me.Em.Size = New System.Drawing.Size(404, 270)
        Me.Em.TabIndex = 387
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.DeleteJudgeToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(153, 98)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.document__pencil
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Selected"
        '
        'DeleteJudgeToolStripMenuItem
        '
        Me.DeleteJudgeToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.notebook__minus
        Me.DeleteJudgeToolStripMenuItem.Name = "DeleteJudgeToolStripMenuItem"
        Me.DeleteJudgeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteJudgeToolStripMenuItem.Text = "Delete Title"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.JudgingSystem.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(152, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(309, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(250, 152)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(55, 22)
        Me.id.TabIndex = 388
        Me.id.Visible = False
        '
        'frmRankTitle
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(426, 370)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmRankTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rank Title"
        Me.TopMost = True
        CType(Me.txtRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents txtRank As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents DeleteJudgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
