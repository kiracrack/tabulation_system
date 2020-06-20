<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualScoring
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
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCategoryType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rankid = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdManualScore = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtRank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        Me.txtBatch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoryid
        '
        Me.categoryid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.categoryid.ForeColor = System.Drawing.Color.Black
        Me.categoryid.Location = New System.Drawing.Point(690, 155)
        Me.categoryid.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Size = New System.Drawing.Size(52, 22)
        Me.categoryid.TabIndex = 382
        Me.categoryid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.categoryid.Visible = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(142, 54)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.document__pencil
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EditChapterToolStripMenuItem.Text = "Edit Selected"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(138, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.JudgingSystem.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(141, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'txtCategoryType
        '
        Me.txtCategoryType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCategoryType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategoryType.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCategoryType.ForeColor = System.Drawing.Color.Black
        Me.txtCategoryType.FormattingEnabled = True
        Me.txtCategoryType.ItemHeight = 19
        Me.txtCategoryType.Location = New System.Drawing.Point(561, 57)
        Me.txtCategoryType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategoryType.Name = "txtCategoryType"
        Me.txtCategoryType.Size = New System.Drawing.Size(257, 27)
        Me.txtCategoryType.TabIndex = 391
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(558, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 390
        Me.Label3.Text = "Category Type"
        '
        'rankid
        '
        Me.rankid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rankid.ForeColor = System.Drawing.Color.Black
        Me.rankid.Location = New System.Drawing.Point(625, 155)
        Me.rankid.Margin = New System.Windows.Forms.Padding(4)
        Me.rankid.Name = "rankid"
        Me.rankid.ReadOnly = True
        Me.rankid.Size = New System.Drawing.Size(57, 22)
        Me.rankid.TabIndex = 400
        Me.rankid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rankid.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.JudgingSystem.My.Resources.Resources.wide_blank21
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.cmdManualScore, Me.ToolStripSeparator2, Me.cmdPrint})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(898, 31)
        Me.ToolStrip3.TabIndex = 399
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.JudgingSystem.My.Resources.Resources.slash
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(103, 24)
        Me.ToolStripButton1.Text = "Close Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdManualScore
        '
        Me.cmdManualScore.Enabled = False
        Me.cmdManualScore.ForeColor = System.Drawing.Color.White
        Me.cmdManualScore.Image = Global.JudgingSystem.My.Resources.Resources.inbox_document_text
        Me.cmdManualScore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdManualScore.Name = "cmdManualScore"
        Me.cmdManualScore.Size = New System.Drawing.Size(126, 24)
        Me.cmdManualScore.Text = "New Manual Score"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.JudgingSystem.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(87, 24)
        Me.cmdPrint.Text = "Print Result"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(11, 91)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(875, 333)
        Me.Em.TabIndex = 401
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'txtRank
        '
        Me.txtRank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRank.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtRank.ForeColor = System.Drawing.Color.Black
        Me.txtRank.FormattingEnabled = True
        Me.txtRank.ItemHeight = 19
        Me.txtRank.Location = New System.Drawing.Point(13, 57)
        Me.txtRank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(257, 27)
        Me.txtRank.TabIndex = 402
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 404
        Me.Label1.Text = "Select Rank Description"
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAll.Location = New System.Drawing.Point(487, 36)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(66, 19)
        Me.ckAll.TabIndex = 414
        Me.ckAll.Text = "View all"
        Me.ckAll.UseVisualStyleBackColor = True
        '
        'txtBatch
        '
        Me.txtBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBatch.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtBatch.ForeColor = System.Drawing.Color.Black
        Me.txtBatch.FormattingEnabled = True
        Me.txtBatch.ItemHeight = 19
        Me.txtBatch.Location = New System.Drawing.Point(274, 57)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(282, 27)
        Me.txtBatch.TabIndex = 413
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(271, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 415
        Me.Label2.Text = "Batch contestant"
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(560, 155)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(57, 22)
        Me.batchcode.TabIndex = 416
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'frmManualScoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(898, 436)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckAll)
        Me.Controls.Add(Me.txtBatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.rankid)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.txtCategoryType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.Em)
        Me.HelpButton = True
        Me.Name = "frmManualScoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Judging System"
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCategoryType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdManualScore As System.Windows.Forms.ToolStripButton
    Friend WithEvents rankid As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtRank As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
End Class
