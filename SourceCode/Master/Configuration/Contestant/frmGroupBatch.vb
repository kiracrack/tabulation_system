Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmGroupBatch
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBatchCode.Text = getSequenceno("batchcode", "tblbatch", "eventid='" & GlobalEventID & "'", "batch", 3, 101)
        LoadEntries()
    End Sub

    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select batchcode, batchname as 'Batch Name'  from tblbatch where eventid = '" & GlobalEventID & "'", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"batchcode"})
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblbatch set batchname='" & rchar(txtBatchName.Text) & "' where batchcode='" & txtBatchCode.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblbatch set eventid='" & GlobalEventID & "',batchcode='" & txtBatchCode.Text & "', batchname='" & rchar(txtBatchName.Text) & "'" : com.ExecuteNonQuery()
        End If
        txtBatchCode.Text = getSequenceno("batchcode", "tblbatch", "eventid='" & GlobalEventID & "'", "batch", 3, 101)
        txtBatchName.Text = ""  
        LoadEntries()
        MessageBox.Show("Batch Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub ShowInfo()
        If txtBatchCode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblbatch where eventid='" & GlobalEventID & "' and batchcode='" & txtBatchCode.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtBatchName.Text = rst("batchname").ToString
        End While
        rst.Close()
    End Sub


    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        txtBatchCode.Text = Em.Item("batchcode", Em.CurrentRow.Index).Value()
        mode.Text = "edit"
        ShowInfo()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtBatchCode.Text = getSequenceno("batchcode", "tblbatch", "eventid='" & GlobalEventID & "'", "batch", 3, 101)
        txtBatchName.Text = "" 
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblbatch where batchcode='" & Em.Item("batchcode", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Batch successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
 
End Class