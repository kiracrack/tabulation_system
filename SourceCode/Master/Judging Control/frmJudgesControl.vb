Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmJudgesControl
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEntries()
    End Sub

    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select distinct(tbljudges.judgeid) as 'judgeid',judgeNumber as 'No.',JudgeName as 'Judges Name' from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudges.eventid='" & GlobalEventID & "' order by judgeNumber asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"judgeid"})
        GridColumnAlignment(Em, {"No."}, DataGridViewContentAlignment.MiddleCenter)
        Em.Columns("No.").Width = 40
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click
        For i = 0 To Em.SelectedRows.Count - 1
            com.CommandText = "update tbljudges set status=2 where judgeid='" & Em.Item("judgeid", Em.SelectedRows(i).Index).Value & "'" : com.ExecuteNonQuery()
        Next
        LoadEntries()
        MessageBox.Show("Judges Successfully Activated", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ReadyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadyToolStripMenuItem.Click
        For i = 0 To Em.SelectedRows.Count - 1
            com.CommandText = "update tbljudges set status=6 where judgeid='" & Em.Item("judgeid", Em.SelectedRows(i).Index).Value & "'" : com.ExecuteNonQuery()
        Next
        LoadEntries()
        MessageBox.Show("Judges Successfully Logout", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub StanbyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StanbyToolStripMenuItem.Click
        For i = 0 To Em.SelectedRows.Count - 1
            com.CommandText = "update tbljudges set status=0 where judgeid='" & Em.Item("judgeid", Em.SelectedRows(i).Index).Value & "'" : com.ExecuteNonQuery()
        Next
        LoadEntries()
        MessageBox.Show("Judges Successfully Locked", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

  
End Class