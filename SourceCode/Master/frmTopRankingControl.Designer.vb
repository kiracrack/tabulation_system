<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopRankingControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopRankingControl))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabRequest = New System.Windows.Forms.TabPage()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        Me.txtBatch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.txtRank = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rankid = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnlineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabRequest.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdreset
        '
        Me.cmdreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(413, 487)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(152, 30)
        Me.cmdreset.TabIndex = 15
        Me.cmdreset.Text = "Print Winner"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdset
        '
        Me.cmdset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(255, 487)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(152, 30)
        Me.cmdset.TabIndex = 14
        Me.cmdset.Text = "Print Selection"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(73, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(390, 15)
        Me.lbldescription.TabIndex = 334
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(452, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(73, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(0, 19)
        Me.lbltitle.TabIndex = 333
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabRequest)
        Me.TabControl1.Location = New System.Drawing.Point(9, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 426)
        Me.TabControl1.TabIndex = 260
        '
        'tabRequest
        '
        Me.tabRequest.Controls.Add(Me.ckAll)
        Me.tabRequest.Controls.Add(Me.txtBatch)
        Me.tabRequest.Controls.Add(Me.Label3)
        Me.tabRequest.Controls.Add(Me.Em)
        Me.tabRequest.Controls.Add(Me.Em2)
        Me.tabRequest.Controls.Add(Me.Label1)
        Me.tabRequest.Controls.Add(Me.txtDetails)
        Me.tabRequest.Controls.Add(Me.cmdLoad)
        Me.tabRequest.Controls.Add(Me.txtRank)
        Me.tabRequest.Controls.Add(Me.Label2)
        Me.tabRequest.Location = New System.Drawing.Point(4, 22)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(640, 400)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "Control Information"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAll.Location = New System.Drawing.Point(389, 11)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(40, 19)
        Me.ckAll.TabIndex = 409
        Me.ckAll.Text = "All"
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
        Me.txtBatch.Location = New System.Drawing.Point(81, 7)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(303, 27)
        Me.txtBatch.TabIndex = 408
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(41, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 407
        Me.Label3.Text = "Batch"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(7, 79)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(627, 266)
        Me.Em.TabIndex = 402
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
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Em2
        '
        Me.Em2.Location = New System.Drawing.Point(75, 79)
        Me.Em2.MainView = Me.GridView2
        Me.Em2.Name = "Em2"
        Me.Em2.Size = New System.Drawing.Size(469, 126)
        Me.Em2.TabIndex = 406
        Me.Em2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.Em2.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView2.AppearancePrint.GroupRow.Options.UseFont = True
        Me.GridView2.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView2.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView2.AppearancePrint.Row.Options.UseFont = True
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Em2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(5, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 15)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "Please enter details for result printing"
        '
        'txtDetails
        '
        Me.txtDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDetails.Location = New System.Drawing.Point(7, 366)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.Size = New System.Drawing.Size(627, 28)
        Me.txtDetails.TabIndex = 404
        '
        'cmdLoad
        '
        Me.cmdLoad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLoad.Location = New System.Drawing.Point(387, 38)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(121, 28)
        Me.cmdLoad.TabIndex = 403
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'txtRank
        '
        Me.txtRank.DropDownHeight = 130
        Me.txtRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRank.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtRank.ForeColor = System.Drawing.Color.Black
        Me.txtRank.FormattingEnabled = True
        Me.txtRank.IntegralHeight = False
        Me.txtRank.ItemHeight = 19
        Me.txtRank.Location = New System.Drawing.Point(81, 39)
        Me.txtRank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRank.MaxDropDownItems = 7
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(303, 27)
        Me.txtRank.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Select Rank"
        '
        'rankid
        '
        Me.rankid.Enabled = False
        Me.rankid.Location = New System.Drawing.Point(552, 36)
        Me.rankid.Name = "rankid"
        Me.rankid.ReadOnly = True
        Me.rankid.Size = New System.Drawing.Size(57, 20)
        Me.rankid.TabIndex = 378
        Me.rankid.Visible = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.cmdLocalData, Me.ToolStripSeparator4, Me.cmdOnlineData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.application_task
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EditChapterToolStripMenuItem.Text = "Column Chooser"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.JudgingSystem.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'cmdOnlineData
        '
        Me.cmdOnlineData.Image = Global.JudgingSystem.My.Resources.Resources.Network_Drive_Connected__3_
        Me.cmdOnlineData.Name = "cmdOnlineData"
        Me.cmdOnlineData.Size = New System.Drawing.Size(193, 22)
        Me.cmdOnlineData.Tag = "0"
        Me.cmdOnlineData.Text = "Online Current Update"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.JudgingSystem.My.Resources.Resources.conduit_2
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(16, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(51, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdConfirm.BackColor = System.Drawing.Color.Red
        Me.cmdConfirm.Enabled = False
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ForeColor = System.Drawing.Color.White
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(97, 487)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(152, 30)
        Me.cmdConfirm.TabIndex = 380
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtLimit
        '
        Me.txtLimit.Enabled = False
        Me.txtLimit.Location = New System.Drawing.Point(552, 13)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.ReadOnly = True
        Me.txtLimit.Size = New System.Drawing.Size(57, 20)
        Me.txtLimit.TabIndex = 381
        Me.txtLimit.Visible = False
        '
        'batchcode
        '
        Me.batchcode.Enabled = False
        Me.batchcode.Location = New System.Drawing.Point(489, 12)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(57, 20)
        Me.batchcode.TabIndex = 382
        Me.batchcode.Visible = False
        '
        'frmTopRankingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(663, 523)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.rankid)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTopRankingControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.tabRequest.ResumeLayout(False)
        Me.tabRequest.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRequest As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdOnlineData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRank As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rankid As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents Em2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
End Class
