Imports System.Windows.Forms
Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Private checkupdate As Boolean = True
    Dim bw As BackgroundWorker = New BackgroundWorker
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Shift) + Keys.F12 Then
            If LCase(globalusername) = "admin" Then
                frmGeneralSettings.ShowDialog()
            Else
                MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf keyData = (Keys.Control) + Keys.F12 Then
            If LCase(globalusername) = "admin" Then
                frmSystemUpdate.ShowDialog()
            Else
                MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return ProcessCmdKey
    End Function

#Region "Call Data Reload Function"
    Public Shared reloaddata As New MainForm()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmUserlogoff.ShowDialog()
        If formclose = False Then
            e.Cancel = True
            Exit Sub
        End If
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        userexit()
        frmLogin.Show()
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectVerify()
        If System.IO.File.Exists(Application.StartupPath.ToString & "\logo.png") = True Then
            Globallogo = Image.FromFile(Application.StartupPath.ToString & "\logo.png")
        End If
        txtfullname.Text = globalfullname
        txtPosition.Text = globalposition
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
        mainname.Text = "Judging System " & fversion
        customminform()
        PictureBox1.BackgroundImage = frmLogin.loadimage.Image
        If GlobalActivatedCategory = 0 Then
            cmdIncoming.Enabled = False
            cmdInventory.Enabled = False
            cmdPortal.Enabled = False
            cmdRequestManagement.Enabled = False
        Else
            cmdIncoming.Enabled = True
            cmdInventory.Enabled = True
            cmdPortal.Enabled = True
            cmdRequestManagement.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub customminform()
        Me.Size = New Size(250, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MinimumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInventory.Click
        If GlobalActivatedCategory = 0 Then
            MessageBox.Show("Please activate category to view this Score Monitoring!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmScoreMonitoring.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogoff.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewRequest.Click
        frmJudgingControl.Show()
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles cmdRequestManagement.Click
        If GlobalActivatedCategory = 0 Then
            MessageBox.Show("Please activate category to view Top Selection!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmTopRankingControl.Show()
    End Sub


    Public Sub resizesignature()
        If loadimage.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(loadimage.Image)
        loadimage.Image = Original

        Dim m As Int32 = PictureBox1.Width
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        loadimage.Image = Thumb

        loadimage.Image.Save(Application.StartupPath & "\logo.png")
        If MessageBox.Show("Please close your system to load your new logo! Are you sure you want to quit system?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            End
        End If

    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        ' (max size 163x163 png files)
        If MessageBox.Show("Please use PNG or GIF image file. (Max Resolution 163x163 Pixel size!). Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
                .Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    loadimage.ImageLocation = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try

            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub loadimage_LoadCompleted1(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles loadimage.LoadCompleted
        resizesignature()
    End Sub

    Private Sub mainname_Click(sender As Object, e As EventArgs) Handles mainname.Click
        frmSystemInfo.ShowDialog()
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If frmDataDownloader.Visible = False Then
            frmDataDownloader.ShowDialog()
        Else
            frmDataDownloader.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmGeneralSettings.ShowDialog()
    End Sub

    Private Sub AboutCoffeecupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
        frmContestant.Show()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        If NotifyIcon1.BalloonTipTitle = "New Update Available" Then
            frmSystemInfo.ShowDialog()
        Else
            If frmNotificationBox.Visible = False Then
                frmNotificationBox.ShowDialog()
            Else
                frmNotificationBox.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If frmSystemInfo.Visible = False Then
            frmSystemInfo.ShowDialog()
        Else
            frmSystemInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
    End Sub


    Private Sub settingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles settingsToolStripMenuItem.Click
        If frmNotificationBox.Visible = False Then
            frmNotificationBox.ShowDialog()
        Else
            frmNotificationBox.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub NotificationBoxToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If frmNotificationBox.Visible = False Then
            frmNotificationBox.ShowDialog()
        Else
            frmNotificationBox.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ChangeAccountPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeAccountPasswordToolStripMenuItem.Click
        If frmChangePassword.Visible = False Then
            frmChangePassword.ShowDialog()
        Else
            frmChangePassword.WindowState = FormWindowState.Normal
        End If
    End Sub



    Private Sub RankCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankCategoryToolStripMenuItem.Click
        frmRankEntries.Show()
    End Sub

    Private Sub CriteriaCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriteriaCategoryToolStripMenuItem.Click
        frmCategoryEntries.Show()
    End Sub

    Private Sub TableOfCriteriaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableOfJudgesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableOfJudgesToolStripMenuItem.Click
        frmJudgeEntries.Show()
    End Sub

    Private Sub ConfigurationOfEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationOfEventToolStripMenuItem.Click
        frmEventEntries.Show()
    End Sub

    Private Sub cmdIncoming_Click(sender As Object, e As EventArgs) Handles cmdIncoming.Click
        If GlobalActivatedCategory = 0 Then
            MessageBox.Show("Please activate category to view Manual Entry Form!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmManualScoring.Show()
    End Sub

    Private Sub cmdPortal_Click(sender As Object, e As EventArgs) Handles cmdPortal.Click
        If GlobalActivatedCategory = 0 Then
            MessageBox.Show("Please activate category to view Overall Scores!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmFinalScore.Show()
    End Sub

    Private Sub WinningTitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinningTitleToolStripMenuItem.Click
        frmRankTitle.Show()
    End Sub
 
End Class
