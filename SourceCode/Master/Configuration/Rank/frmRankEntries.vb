Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmRankEntries

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
      
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEntries()
    End Sub
    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select rankid, rankDescription as 'Rank Description', rankLimit as 'Rank Limit' from tblrankingcategory where eventid = '" & GlobalEventID & "'", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"rankid"})
        GridColumnAlignment(Em, {"Rank Limit"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' showInfo()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmRankInformation.Show(Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmRankInformation.rankid.Text = Em.Item("rankid", Em.CurrentRow.Index).Value()
        frmRankInformation.mode.Text = "edit"
        frmRankInformation.Show(Me)
    End Sub

     
    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblrankingcategory where rankid='" & Em.Item("rankid", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Rank successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
End Class