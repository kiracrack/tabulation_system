Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmRankTitle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRank.Value = Val(countqry("tblranktitle", "eventid = '" & GlobalEventID & "'")) + 1
        LoadEntries()
    End Sub

    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, Rank, description as 'Description' from tblranktitle where eventid = '" & GlobalEventID & "' order by rank asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        Em.Columns("Rank").Width = 40
        GridHideColumn(Em, {"id"})
        GridColumnAlignment(Em, {"Rank"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblranktitle set rank='" & txtRank.Text & "',description='" & rchar(txtDescription.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblranktitle set eventid='" & GlobalEventID & "', rank='" & txtRank.Text & "', description='" & rchar(txtDescription.Text) & "'" : com.ExecuteNonQuery()
        End If
        txtDescription.Text = ""
        txtRank.Value = Val(countqry("tblranktitle", "eventid = '" & GlobalEventID & "'")) + 1
        LoadEntries()
        txtDescription.Focus()
        MessageBox.Show("Title Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub ShowInfo()
        com.CommandText = "select * from tblranktitle where eventid='" & GlobalEventID & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("description").ToString
            txtRank.Value = rst("rank").ToString
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        id.Text = Em.Item("id", Em.CurrentRow.Index).Value()
        mode.Text = "edit"
        ShowInfo()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        id.Text = ""
        txtDescription.Text = ""
        txtRank.Value = Val(countqry("tblranktitle", "eventid = '" & GlobalEventID & "'")) + 1
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblranktitle where id='" & Em.Item("id", Em.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Title successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
End Class