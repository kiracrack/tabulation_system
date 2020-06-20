<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.se1 = New System.Windows.Forms.ToolStripSeparator()
        Me.se2 = New System.Windows.Forms.ToolStripSeparator()
        Me.se4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdnewRequest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdIncoming = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdInventory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPortal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRequestManagement = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLogoff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtfullname = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contextLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowsePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.maindescription = New System.Windows.Forms.Label()
        Me.mainname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateLogin = New System.Windows.Forms.Label()
        Me.loadimage = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeAccountPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriteriaCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableOfJudgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinningTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigurationOfEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextLogo.SuspendLayout()
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'se1
        '
        Me.se1.Name = "se1"
        Me.se1.Size = New System.Drawing.Size(196, 6)
        '
        'se2
        '
        Me.se2.Name = "se2"
        Me.se2.Size = New System.Drawing.Size(196, 6)
        '
        'se4
        '
        Me.se4.Name = "se4"
        Me.se4.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdnewRequest, Me.ToolStripSeparator3, Me.cmdIncoming, Me.ToolStripSeparator6, Me.cmdInventory, Me.ToolStripSeparator2, Me.cmdPortal, Me.ToolStripSeparator4, Me.cmdRequestManagement, Me.ToolStripSeparator5, Me.cmdLogoff})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(20, 90, 20, 0)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(237, 709)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'cmdnewRequest
        '
        Me.cmdnewRequest.ForeColor = System.Drawing.Color.White
        Me.cmdnewRequest.Image = Global.JudgingSystem.My.Resources.Resources.conduit_2
        Me.cmdnewRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdnewRequest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdnewRequest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdnewRequest.Name = "cmdnewRequest"
        Me.cmdnewRequest.Size = New System.Drawing.Size(196, 52)
        Me.cmdnewRequest.Text = "Judging Controls"
        Me.cmdnewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'cmdIncoming
        '
        Me.cmdIncoming.ForeColor = System.Drawing.Color.White
        Me.cmdIncoming.Image = Global.JudgingSystem.My.Resources.Resources.kxkb
        Me.cmdIncoming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdIncoming.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdIncoming.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncoming.Name = "cmdIncoming"
        Me.cmdIncoming.Size = New System.Drawing.Size(196, 52)
        Me.cmdIncoming.Text = "Manual Entry"
        Me.cmdIncoming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(196, 6)
        '
        'cmdInventory
        '
        Me.cmdInventory.ForeColor = System.Drawing.Color.White
        Me.cmdInventory.Image = Global.JudgingSystem.My.Resources.Resources.klaptop
        Me.cmdInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInventory.Name = "cmdInventory"
        Me.cmdInventory.Size = New System.Drawing.Size(196, 52)
        Me.cmdInventory.Text = "Scores Monitoring"
        Me.cmdInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'cmdPortal
        '
        Me.cmdPortal.ForeColor = System.Drawing.Color.White
        Me.cmdPortal.Image = Global.JudgingSystem.My.Resources.Resources.preferences_contact_list
        Me.cmdPortal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPortal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPortal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPortal.Name = "cmdPortal"
        Me.cmdPortal.Size = New System.Drawing.Size(196, 52)
        Me.cmdPortal.Text = "Overall Scores"
        Me.cmdPortal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(196, 6)
        '
        'cmdRequestManagement
        '
        Me.cmdRequestManagement.ForeColor = System.Drawing.Color.White
        Me.cmdRequestManagement.Image = Global.JudgingSystem.My.Resources.Resources.osmo1
        Me.cmdRequestManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRequestManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRequestManagement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRequestManagement.Name = "cmdRequestManagement"
        Me.cmdRequestManagement.Size = New System.Drawing.Size(196, 52)
        Me.cmdRequestManagement.Text = "Top Selection"
        Me.cmdRequestManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(196, 6)
        '
        'cmdLogoff
        '
        Me.cmdLogoff.ForeColor = System.Drawing.Color.White
        Me.cmdLogoff.Image = Global.JudgingSystem.My.Resources.Resources.application_exit_5
        Me.cmdLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogoff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLogoff.Name = "cmdLogoff"
        Me.cmdLogoff.Size = New System.Drawing.Size(196, 52)
        Me.cmdLogoff.Text = "Exit System"
        Me.cmdLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtfullname.ForeColor = System.Drawing.Color.White
        Me.txtfullname.Location = New System.Drawing.Point(12, 34)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(222, 19)
        Me.txtfullname.TabIndex = 334
        Me.txtfullname.Text = "WINTER BUGAHOD"
        Me.txtfullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPosition.Location = New System.Drawing.Point(13, 53)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(212, 15)
        Me.txtPosition.TabIndex = 339
        Me.txtPosition.Text = "President"
        Me.txtPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.ContextMenuStrip = Me.contextLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 203)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'contextLogo
        '
        Me.contextLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowsePictureToolStripMenuItem})
        Me.contextLogo.Name = "ContextMenuStrip1"
        Me.contextLogo.Size = New System.Drawing.Size(146, 26)
        '
        'BrowsePictureToolStripMenuItem
        '
        Me.BrowsePictureToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.images_flickr
        Me.BrowsePictureToolStripMenuItem.Name = "BrowsePictureToolStripMenuItem"
        Me.BrowsePictureToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BrowsePictureToolStripMenuItem.Text = "Change Logo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(196, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'maindescription
        '
        Me.maindescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maindescription.BackColor = System.Drawing.Color.Transparent
        Me.maindescription.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.maindescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.maindescription.Location = New System.Drawing.Point(12, 696)
        Me.maindescription.Name = "maindescription"
        Me.maindescription.Size = New System.Drawing.Size(213, 12)
        Me.maindescription.TabIndex = 343
        Me.maindescription.Text = "Developed by Winter Bugahod"
        Me.maindescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainname
        '
        Me.mainname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainname.BackColor = System.Drawing.Color.Transparent
        Me.mainname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mainname.ForeColor = System.Drawing.Color.White
        Me.mainname.Location = New System.Drawing.Point(12, 683)
        Me.mainname.Name = "mainname"
        Me.mainname.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mainname.Size = New System.Drawing.Size(213, 12)
        Me.mainname.TabIndex = 342
        Me.mainname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 12)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "IT-Development"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDateLogin
        '
        Me.txtDateLogin.BackColor = System.Drawing.Color.Transparent
        Me.txtDateLogin.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.txtDateLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDateLogin.Location = New System.Drawing.Point(13, 68)
        Me.txtDateLogin.Name = "txtDateLogin"
        Me.txtDateLogin.Size = New System.Drawing.Size(212, 15)
        Me.txtDateLogin.TabIndex = 345
        Me.txtDateLogin.Text = "July 10, 2013 11:34:32 PM"
        Me.txtDateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'loadimage
        '
        Me.loadimage.BackColor = System.Drawing.Color.Transparent
        Me.loadimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loadimage.Location = New System.Drawing.Point(219, 239)
        Me.loadimage.Name = "loadimage"
        Me.loadimage.Size = New System.Drawing.Size(2, 2)
        Me.loadimage.TabIndex = 349
        Me.loadimage.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(238, 24)
        Me.MenuStrip1.TabIndex = 351
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeAccountPasswordToolStripMenuItem, Me.toolStripSeparator, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ChangeAccountPasswordToolStripMenuItem
        '
        Me.ChangeAccountPasswordToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.kgpg_term
        Me.ChangeAccountPasswordToolStripMenuItem.Name = "ChangeAccountPasswordToolStripMenuItem"
        Me.ChangeAccountPasswordToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ChangeAccountPasswordToolStripMenuItem.Text = "Update Account Info"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RankCategoryToolStripMenuItem, Me.CriteriaCategoryToolStripMenuItem, Me.TableOfJudgesToolStripMenuItem, Me.ConnectionSetupToolStripMenuItem, Me.WinningTitleToolStripMenuItem, Me.ToolStripSeparator7, Me.ConfigurationOfEventToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ToolsToolStripMenuItem.Text = "&Configurations"
        '
        'RankCategoryToolStripMenuItem
        '
        Me.RankCategoryToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.notebooks
        Me.RankCategoryToolStripMenuItem.Name = "RankCategoryToolStripMenuItem"
        Me.RankCategoryToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RankCategoryToolStripMenuItem.Text = "Rank Category"
        '
        'CriteriaCategoryToolStripMenuItem
        '
        Me.CriteriaCategoryToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.clipboard_task
        Me.CriteriaCategoryToolStripMenuItem.Name = "CriteriaCategoryToolStripMenuItem"
        Me.CriteriaCategoryToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CriteriaCategoryToolStripMenuItem.Text = "Criteria for Judging"
        '
        'TableOfJudgesToolStripMenuItem
        '
        Me.TableOfJudgesToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.user_business_gray_boss
        Me.TableOfJudgesToolStripMenuItem.Name = "TableOfJudgesToolStripMenuItem"
        Me.TableOfJudgesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TableOfJudgesToolStripMenuItem.Text = "Table of Judges"
        '
        'ConnectionSetupToolStripMenuItem
        '
        Me.ConnectionSetupToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.users1
        Me.ConnectionSetupToolStripMenuItem.Name = "ConnectionSetupToolStripMenuItem"
        Me.ConnectionSetupToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConnectionSetupToolStripMenuItem.Text = "Table of Contestant"
        '
        'WinningTitleToolStripMenuItem
        '
        Me.WinningTitleToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.trophy
        Me.WinningTitleToolStripMenuItem.Name = "WinningTitleToolStripMenuItem"
        Me.WinningTitleToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.WinningTitleToolStripMenuItem.Text = "Top Winner Title"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(196, 6)
        '
        'ConfigurationOfEventToolStripMenuItem
        '
        Me.ConfigurationOfEventToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources._025
        Me.ConfigurationOfEventToolStripMenuItem.Name = "ConfigurationOfEventToolStripMenuItem"
        Me.ConfigurationOfEventToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConfigurationOfEventToolStripMenuItem.Text = "Event Entries && Settings"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.settingsToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "contextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(188, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.JudgingSystem.My.Resources.Resources.information
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem1.Text = "About..."
        '
        'settingsToolStripMenuItem
        '
        Me.settingsToolStripMenuItem.Image = Global.JudgingSystem.My.Resources.Resources.balloons_box
        Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
        Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.settingsToolStripMenuItem.Text = "View Notification Box"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.JudgingSystem.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(238, 733)
        Me.Controls.Add(Me.loadimage)
        Me.Controls.Add(Me.txtDateLogin)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maindescription)
        Me.Controls.Add(Me.mainname)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tabulation"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextLogo.ResumeLayout(False)
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents se1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtfullname As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdnewRequest As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRequestManagement As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLogoff As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPortal As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents maindescription As System.Windows.Forms.Label
    Friend WithEvents mainname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateLogin As System.Windows.Forms.Label
    Friend WithEvents cmdIncoming As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents contextLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowsePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadimage As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeAccountPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableOfJudgesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RankCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriteriaCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationOfEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WinningTitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
