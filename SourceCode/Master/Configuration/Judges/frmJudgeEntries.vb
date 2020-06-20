Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmJudgeEntries

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Control) + Keys.P Then
            GridView1.ShowRibbonPrintPreview()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEntries()
    End Sub
    Public Sub LoadEntries()
        LoadXgrid("select judgeid,judgeNumber as 'No.', JudgeName as 'Fullname', Username, Password from tbljudges where eventid = '" & GlobalEventID & "' order by judgeNumber asc", "tbljudges", Em, GridView1)
        GridView1.Columns("judgeid").Visible = False
        XGridColumnAlignment(GridView1, {"No.", "Username", "Password"}, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("No.").Width = 40
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ToolStripButton1.PerformClick()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmJudgeInformation.Show(Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmJudgeInformation.judgeid.Text = GridView1.GetFocusedRowCellValue("judgeid").ToString
        frmJudgeInformation.mode.Text = "edit"
        frmJudgeInformation.Show(Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmJudgePermission.judgeid.Text = GridView1.GetFocusedRowCellValue("judgeid").ToString
        frmJudgePermission.txtJudgeName.Text = GridView1.GetFocusedRowCellValue("Fullname").ToString
        frmJudgePermission.Show(Me)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        GridView1.ShowRibbonPrintPreview()
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tbljudges where judgeid='" & GridView1.GetFocusedRowCellValue("judgeid").ToString & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Judge successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
End Class