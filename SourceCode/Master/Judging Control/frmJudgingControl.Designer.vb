<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJudgingControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJudgingControl))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabRequest = New System.Windows.Forms.TabPage()
        Me.txtBatch = New System.Windows.Forms.ComboBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckLastCategory = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtRank = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rankid = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnlineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabRequest.SuspendLayout()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdreset
        '
        Me.cmdreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(384, 469)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(152, 30)
        Me.cmdreset.TabIndex = 15
        Me.cmdreset.Text = "Close"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdset
        '
        Me.cmdset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(225, 469)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(152, 30)
        Me.cmdset.TabIndex = 14
        Me.cmdset.Text = "Activate"
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
        Me.lbldescription.Text = "You can use this tool to control judges and scoring category activation"
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
        Me.lbltitle.Size = New System.Drawing.Size(110, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Judging Control"
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
        Me.TabControl1.Size = New System.Drawing.Size(587, 407)
        Me.TabControl1.TabIndex = 260
        '
        'tabRequest
        '
        Me.tabRequest.Controls.Add(Me.txtBatch)
        Me.tabRequest.Controls.Add(Me.batchcode)
        Me.tabRequest.Controls.Add(Me.Label3)
        Me.tabRequest.Controls.Add(Me.ckLastCategory)
        Me.tabRequest.Controls.Add(Me.Label1)
        Me.tabRequest.Controls.Add(Me.ListView1)
        Me.tabRequest.Controls.Add(Me.txtRank)
        Me.tabRequest.Controls.Add(Me.Label2)
        Me.tabRequest.Location = New System.Drawing.Point(4, 22)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(579, 381)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "Judging Control Information"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'txtBatch
        '
        Me.txtBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBatch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBatch.ForeColor = System.Drawing.Color.Black
        Me.txtBatch.FormattingEnabled = True
        Me.txtBatch.ItemHeight = 15
        Me.txtBatch.Location = New System.Drawing.Point(86, 12)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(303, 23)
        Me.txtBatch.TabIndex = 401
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(21, 198)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(33, 22)
        Me.batchcode.TabIndex = 400
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(46, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 399
        Me.Label3.Text = "Batch"
        '
        'ckLastCategory
        '
        Me.ckLastCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckLastCategory.AutoSize = True
        Me.ckLastCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckLastCategory.Location = New System.Drawing.Point(86, 356)
        Me.ckLastCategory.Name = "ckLastCategory"
        Me.ckLastCategory.Size = New System.Drawing.Size(98, 19)
        Me.ckLastCategory.TabIndex = 392
        Me.ckLastCategory.Text = "Last Category"
        Me.ckLastCategory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(83, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 382
        Me.Label1.Text = "List of Category"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(86, 81)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(418, 271)
        Me.ListView1.TabIndex = 381
        Me.ListView1.UseCompatibleStateImageBehavior = False
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
        Me.txtRank.Location = New System.Drawing.Point(86, 39)
        Me.txtRank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRank.MaxDropDownItems = 7
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(303, 21)
        Me.txtRank.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(50, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Rank"
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
        'categoryid
        '
        Me.categoryid.Enabled = False
        Me.categoryid.Location = New System.Drawing.Point(552, 13)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Size = New System.Drawing.Size(57, 20)
        Me.categoryid.TabIndex = 379
        Me.categoryid.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(67, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 30)
        Me.Button1.TabIndex = 380
        Me.Button1.Text = "Reset All"
        Me.Button1.UseVisualStyleBackColor = False
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
        'frmJudgingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(602, 504)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.rankid)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.Label6)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(618, 543)
        Me.Name = "frmJudgingControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Judging Control"
        Me.TabControl1.ResumeLayout(False)
        Me.tabRequest.ResumeLayout(False)
        Me.tabRequest.PerformLayout()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckLastCategory As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtBatch As System.Windows.Forms.ComboBox
End Class
