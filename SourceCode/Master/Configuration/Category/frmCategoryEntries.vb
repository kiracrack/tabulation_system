Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmCategoryEntries

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
        LoadXgrid("select categoryid,ifnull((select rankDescription from tblrankingcategory where rankid = tblcriteriacategory.rankid),'Default') as 'Rank Category', categoryDescription as 'Category Description',ifnull((select sum(criteriaScore) from tblcriteriaforjudging where categoryid = tblcriteriacategory.categoryid ),0) as 'Total " & GlobalSymbolInUse & "', categoryorder as 'Order' from tblcriteriacategory where eventid = '" & GlobalEventID & "' order by categoryorder asc", "tblcriteriaforjudging", Em, GridView1)
        GridView1.Columns("categoryid").Visible = False
        XGridColumnAlignment(GridView1, {"Total " & GlobalSymbolInUse & "", "Order"}, DevExpress.Utils.HorzAlignment.Center)
        'XgridColAlign("Total " & GlobalSymbolInUse & "", GridView1, DevExpress.Utils.HorzAlignment.Center)
        'XgridColAlign("Total " & GlobalSymbolInUse & "", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Rank Category").Group()
        GridView1.ExpandAllGroups()
        GridView1.BestFitColumns()
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
        frmCategoryInformation.Show(Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmCategoryInformation.categoryid.Text = GridView1.GetFocusedRowCellValue("categoryid").ToString
        frmCategoryInformation.mode.Text = "edit"
        frmCategoryInformation.Show(Me)
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmCriteriaForJudging.categoryid.Text = GridView1.GetFocusedRowCellValue("categoryid").ToString
        frmCriteriaForJudging.txtCategoryName.Text = GridView1.GetFocusedRowCellValue("Category Description").ToString
        frmCriteriaForJudging.Show(Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        LoadEntries()
    End Sub

    Private Sub ViewJudgesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewJudgesToolStripMenuItem.Click
        frmViewJudgesOnCategory.categoryid.Text = GridView1.GetFocusedRowCellValue("categoryid").ToString
        frmViewJudgesOnCategory.Show(Me)
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblcriteriacategory where categoryid='" & GridView1.GetFocusedRowCellValue("categoryid").ToString & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Category successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub
End Class