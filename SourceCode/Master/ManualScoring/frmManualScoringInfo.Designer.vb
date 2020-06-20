<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualScoringInfo
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
        Me.categoryid = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCandidate = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.candidateno = New System.Windows.Forms.TextBox()
        Me.candidateid = New System.Windows.Forms.TextBox()
        Me.rankcode = New System.Windows.Forms.TextBox()
        Me.Em = New System.Windows.Forms.DataGridView()
        Me.txtJudgeNumber = New System.Windows.Forms.TextBox()
        Me.txtJudge = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.judgeid = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckAll = New System.Windows.Forms.CheckBox()
        Me.txtBatch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(12, 401)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(238, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Submit"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'categoryid
        '
        Me.categoryid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.categoryid.ForeColor = System.Drawing.Color.Black
        Me.categoryid.Location = New System.Drawing.Point(238, 496)
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
        'txtCandidate
        '
        Me.txtCandidate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCandidate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCandidate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCandidate.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCandidate.ForeColor = System.Drawing.Color.Black
        Me.txtCandidate.FormattingEnabled = True
        Me.txtCandidate.ItemHeight = 19
        Me.txtCandidate.Location = New System.Drawing.Point(78, 124)
        Me.txtCandidate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCandidate.Name = "txtCandidate"
        Me.txtCandidate.Size = New System.Drawing.Size(340, 27)
        Me.txtCandidate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 395
        Me.Label5.Text = "Select Contestant Name"
        '
        'candidateno
        '
        Me.candidateno.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.candidateno.ForeColor = System.Drawing.Color.Black
        Me.candidateno.Location = New System.Drawing.Point(13, 124)
        Me.candidateno.Margin = New System.Windows.Forms.Padding(4)
        Me.candidateno.Name = "candidateno"
        Me.candidateno.ReadOnly = True
        Me.candidateno.Size = New System.Drawing.Size(62, 27)
        Me.candidateno.TabIndex = 397
        Me.candidateno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'candidateid
        '
        Me.candidateid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.candidateid.ForeColor = System.Drawing.Color.Black
        Me.candidateid.Location = New System.Drawing.Point(298, 496)
        Me.candidateid.Margin = New System.Windows.Forms.Padding(4)
        Me.candidateid.Name = "candidateid"
        Me.candidateid.ReadOnly = True
        Me.candidateid.Size = New System.Drawing.Size(52, 22)
        Me.candidateid.TabIndex = 398
        Me.candidateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.candidateid.Visible = False
        '
        'rankcode
        '
        Me.rankcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rankcode.ForeColor = System.Drawing.Color.Black
        Me.rankcode.Location = New System.Drawing.Point(178, 496)
        Me.rankcode.Margin = New System.Windows.Forms.Padding(4)
        Me.rankcode.Name = "rankcode"
        Me.rankcode.ReadOnly = True
        Me.rankcode.Size = New System.Drawing.Size(52, 22)
        Me.rankcode.TabIndex = 399
        Me.rankcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rankcode.Visible = False
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
        Me.Em.Location = New System.Drawing.Point(14, 157)
        Me.Em.Margin = New System.Windows.Forms.Padding(2)
        Me.Em.MultiSelect = False
        Me.Em.Name = "Em"
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
        Me.Em.Size = New System.Drawing.Size(404, 239)
        Me.Em.TabIndex = 2
        '
        'txtJudgeNumber
        '
        Me.txtJudgeNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtJudgeNumber.ForeColor = System.Drawing.Color.Black
        Me.txtJudgeNumber.Location = New System.Drawing.Point(12, 74)
        Me.txtJudgeNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJudgeNumber.Name = "txtJudgeNumber"
        Me.txtJudgeNumber.ReadOnly = True
        Me.txtJudgeNumber.Size = New System.Drawing.Size(62, 27)
        Me.txtJudgeNumber.TabIndex = 0
        Me.txtJudgeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJudge
        '
        Me.txtJudge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtJudge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtJudge.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtJudge.ForeColor = System.Drawing.Color.Black
        Me.txtJudge.FormattingEnabled = True
        Me.txtJudge.ItemHeight = 19
        Me.txtJudge.Location = New System.Drawing.Point(77, 74)
        Me.txtJudge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJudge.Name = "txtJudge"
        Me.txtJudge.Size = New System.Drawing.Size(340, 27)
        Me.txtJudge.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 401
        Me.Label1.Text = "Select Judge Name"
        '
        'judgeid
        '
        Me.judgeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.judgeid.ForeColor = System.Drawing.Color.Black
        Me.judgeid.Location = New System.Drawing.Point(358, 496)
        Me.judgeid.Margin = New System.Windows.Forms.Padding(4)
        Me.judgeid.Name = "judgeid"
        Me.judgeid.ReadOnly = True
        Me.judgeid.Size = New System.Drawing.Size(52, 22)
        Me.judgeid.TabIndex = 404
        Me.judgeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.judgeid.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(310, 401)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(107, 27)
        Me.txtTotal.TabIndex = 405
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(256, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 25)
        Me.Label2.TabIndex = 406
        Me.Label2.Text = "Total"
        '
        'ckAll
        '
        Me.ckAll.AutoSize = True
        Me.ckAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAll.Location = New System.Drawing.Point(377, 29)
        Me.ckAll.Name = "ckAll"
        Me.ckAll.Size = New System.Drawing.Size(40, 19)
        Me.ckAll.TabIndex = 412
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
        Me.txtBatch.Location = New System.Drawing.Point(12, 24)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(359, 27)
        Me.txtBatch.TabIndex = 411
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 410
        Me.Label3.Text = "Select contestant batch"
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(118, 496)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(52, 22)
        Me.batchcode.TabIndex = 413
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'frmManualScoringInfo
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(430, 451)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.ckAll)
        Me.Controls.Add(Me.txtBatch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.judgeid)
        Me.Controls.Add(Me.txtJudgeNumber)
        Me.Controls.Add(Me.txtJudge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rankcode)
        Me.Controls.Add(Me.candidateid)
        Me.Controls.Add(Me.candidateno)
        Me.Controls.Add(Me.txtCandidate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.categoryid)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.Em)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmManualScoringInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Judging System"
        Me.TopMost = True
        Me.cms_em.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents categoryid As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCandidate As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents candidateno As System.Windows.Forms.TextBox
    Friend WithEvents candidateid As System.Windows.Forms.TextBox
    Friend WithEvents rankcode As System.Windows.Forms.TextBox
    Friend WithEvents Em As System.Windows.Forms.DataGridView
    Friend WithEvents txtJudgeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtJudge As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents judgeid As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
End Class
