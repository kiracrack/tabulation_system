Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmViewJudgesOnCategory

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
        msda = New MySqlDataAdapter("select judgeNumber as 'No.', JudgeName as 'Fullname' from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudgecategory.eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' order by judgeNumber asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridColumnAlignment(Em, {"No."}, DataGridViewContentAlignment.MiddleCenter)
        Em.Columns("No.").Width = 40
    End Sub
    
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub
    Private Sub MyDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)

    End Sub
End Class