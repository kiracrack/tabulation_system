Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmCriteriaForJudging
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriteriaID.Text = getGlobalTrnid("CR" & globaluserid)
        txtOrder.Text = Val(countqry("tblcriteriaforjudging", "eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "'")) + 1
        lblScore.Text = GlobalSymbolInUse
        LoadEntries()
        Em.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select criteriaid, criteriaName as 'Name of Criteria',Description, criteriaScore as '" & GlobalSymbolInUse & "', sortOrder as 'Order' from tblcriteriaforjudging where eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' order by sortOrder asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"criteriaid"})
        GridColumnAlignment(Em, {GlobalSymbolInUse, "Order"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblcriteriaforjudging set categoryid='" & categoryid.Text & "',criteriaName='" & rchar(txtCriteriaName.Text) & "', criteriaScore='" & txtScore.Text & "', sortOrder='" & txtOrder.Value & "',description='" & txtDescription.Text.Replace("'", "") & "' where criteriaid='" & txtCriteriaID.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcriteriaforjudging set eventid='" & GlobalEventID & "', criteriaid='" & txtCriteriaID.Text & "', categoryid='" & categoryid.Text & "',criteriaName='" & rchar(txtCriteriaName.Text) & "', criteriaScore='" & txtScore.Text & "', sortOrder='" & txtOrder.Value & "',description='" & txtDescription.Text.Replace("'", "") & "'" : com.ExecuteNonQuery()
        End If
        txtCriteriaID.Text = getGlobalTrnid("CR" & globaluserid)
        txtCriteriaName.Text = "" : txtDescription.Text = ""
        txtScore.Value = "0"
        txtOrder.Text = Val(countqry("tblcriteriaforjudging", "eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "'")) + 1
        txtCriteriaName.Focus()
        LoadEntries()
        MessageBox.Show("Criteria Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   
    Public Sub ShowInfo()
        If txtCriteriaID.Text = "" Then Exit Sub
        com.CommandText = "select *,(select categoryDescription from tblcriteriacategory where categoryid = tblcriteriaforjudging.categoryid) as 'Category' from tblcriteriaforjudging where criteriaid='" & txtCriteriaID.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCriteriaName.Text = rst("criteriaName").ToString
            txtDescription.Text = rst("description").ToString
            txtScore.Value = rst("criteriaScore").ToString
            txtOrder.Text = rst("sortOrder").ToString
        End While
        rst.Close()
    End Sub
 

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        txtCriteriaID.Text = Em.Item("criteriaid", Em.CurrentRow.Index).Value()
        mode.Text = "edit"
        ShowInfo()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtCriteriaID.Text = getGlobalTrnid("CR" & globaluserid)
        txtCriteriaName.Text = "" : txtDescription.Text = ""
        txtScore.Value = "0"
        txtOrder.Text = Val(countqry("tblcriteriaforjudging", "eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "'")) + 1
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblcriteriaforjudging where criteriaid='" & Em.Item("criteriaid", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Item successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
End Class