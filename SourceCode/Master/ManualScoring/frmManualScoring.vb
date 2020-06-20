Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmManualScoring
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If countqry("tblactivatedcontestant", "eventid='" & GlobalEventID & "' and rankid<>'DEFAULT'") = 0 Then
            txtRank.Items.Add("DEFAULT")
            rankid.Text = "DEFAULT"
            txtRank.SelectedIndex = 0
            txtRank.Enabled = False
        Else
            LoadToComboBox("select rankid,rankDescription from tblrankingcategory where rankid in (select distinct(rankid) from tblactivatedcontestant where eventid='" & GlobalEventID & "') and eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
            txtRank.Enabled = True
        End If
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
        LoadToComboBox("select * from tblcriteriacategory where eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'", "categoryDescription", "categoryid", txtCategoryType)
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()
        LoadEntries()
    End Sub

    Public Sub LoadEntries()
        GridView1.ClearSorting()
        If txtCategoryType.Text = "" Then Exit Sub

        Dim jCaption As String = "" : Dim jColumn As String = "" : Dim jfilter As String = ""
        com.CommandText = "select * from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudgecategory.eventid='" & GlobalEventID & "' and categoryid='" & categoryid.Text & "'  order by judgenumber asc" : rst = com.ExecuteReader
        While rst.Read
            jCaption = jCaption + "'0' as '" & StrConv(rst("username").ToString, vbProperCase) + "',"
            jColumn = jColumn + StrConv(rst("username").ToString, vbProperCase) + ":"
            jfilter = jfilter + StrConv(rst("judgeid").ToString, vbProperCase) + ":"
        End While
        rst.Close()
        If jCaption <> "" Then
            jCaption = jCaption.Remove(jCaption.Length - 1, 1)
            jColumn = jColumn.Remove(jColumn.Length - 1, 1)
            jfilter = jfilter.Remove(jfilter.Length - 1, 1)
        End If

        Dim aveCol As String = ""
        If GlobalComputation = "AVERAGE" Then
            aveCol = " ,'0' as 'Average' "
        End If
        LoadXgrid("select tblactivatedcontestant.contestantid, tblcontestant.contestantNumber as 'No.',contestantName as '" & GlobalContestantType & "'," & jCaption & ",'0' as Total" & aveCol & ", 0 as 'Rank'  from tblactivatedcontestant inner join tblcontestant on tblactivatedcontestant.contestantid = tblcontestant.contestantid  where tblactivatedcontestant.eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "' " & If(ckAll.Checked = True, "", " and tblcontestant.batchcode='" & batchcode.Text & "' ") & " order by contestantNumber asc", "tblactivatedcontestant", Em, GridView1)
        GridView1.Columns("contestantid").Visible = False
        GridView1.BestFitColumns()
        '#GET SCORE FOR EACH JUDGES
        For i = 0 To GridView1.RowCount - 1
            For Each word In jfilter.Split(New Char() {":"c})
                Dim columnCaption As String = qrysingledata("username", "username", "where judgeid='" & word & "'", "tbljudges")
                com.CommandText = "select *,ifnull(sum(score),0) as 'Total' from tblscores where eventid='" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' and contestantid='" & GridView1.GetRowCellValue(i, "contestantid").ToString() & "' and judgeid='" & word & "' and rankid='" & rankid.Text & "'" : rst = com.ExecuteReader
                While rst.Read
                    GridView1.SetRowCellValue(i, StrConv(columnCaption, vbProperCase), FormatNumber(Val(rst("Total")), 2))
                End While
                rst.Close()
            Next
        Next
        '------------------END--------------------

        '#GET TOTAL SCORES
        For v = 0 To GridView1.RowCount - 1
            Dim total As Double = 0
            For Each word In jColumn.Split(New Char() {":"c})
                total = total + Val(CC(GridView1.GetRowCellValue(v, word).ToString()))
            Next
            GridView1.SetRowCellValue(v, "Total", FormatNumber(total, 2))
        Next

        GridView1.Columns("Total").SortOrder = DevExpress.Data.ColumnSortOrder.None
        GridView1.Columns("Total").Width = 80
        XgridColCurrency("Total", GridView1)
        XgridColAlign("Total", GridView1, DevExpress.Utils.HorzAlignment.Center)
        '------------------END--------------------

        '#GET TOTAL AVERAGE
        If GlobalComputation = "AVERAGE" Then
            Dim totaljudge As Integer = countqry("tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid", "tbljudgecategory.eventid='" & GlobalEventID & "' and categoryid='" & categoryid.Text & "'")
            For v = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(v, "Average", FormatNumber(Val(CC(GridView1.GetRowCellValue(v, "Total").ToString())) / totaljudge, 2))
            Next
            GridView1.Columns("Average").Width = 80
            XgridColCurrency("Average", GridView1)
            XgridColAlign("Average", GridView1, DevExpress.Utils.HorzAlignment.Center)
        End If
        '------------------END--------------------

        '#GET FINAL RANK
        Dim r As Integer = 1
        Dim t As Integer = 0
        Dim temp As Integer = 1
        Dim curtotal As Double = 0
        com.CommandText = "select *,ifnull(sum(score),0) as total from tblscores where eventid='" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' and rankid='" & rankid.Text & "' " & If(ckAll.Checked = True, "", " and contestantid in (select contestantid from tblcontestant where batchcode='" & batchcode.Text & "')") & " group by contestantid order by sum(score) desc " : rst = com.ExecuteReader
        While rst.Read
            If Val(rst("total").ToString) < curtotal Then
                r = r + 1 + t
                t = 0
            Else
                r = r
                If temp <> 1 Then
                    t = t + 1
                End If
                temp = 0
            End If
            curtotal = Val(rst("total").ToString)
            For v = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(v, "contestantid").ToString() = rst("contestantid").ToString Then
                    GridView1.SetRowCellValue(v, "Rank", r)
                End If
            Next
        End While
        rst.Close()

        GridView1.Columns("Rank").Width = 80
        XgridColAlign("Rank", GridView1, DevExpress.Utils.HorzAlignment.Center)
        '------------------END--------------------

        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        For Each word In jColumn.Split(New Char() {":"c})
            GridView1.Columns(word).SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns(word).Width = 80
            XgridColCurrency(word, GridView1)
            XgridColAlign(word, GridView1, DevExpress.Utils.HorzAlignment.Center)
        Next
        GridView1.Columns("Rank").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtCategoryType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCategoryType.SelectedValueChanged
        If txtCategoryType.Text <> "" Then
            categoryid.Text = DirectCast(txtCategoryType.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            categoryid.Text = ""
        End If
        ValidaManualEntry()
        LoadEntries()
    End Sub
    Private Sub ValidaManualEntry()
        If rankid.Text <> "" And categoryid.Text <> "" Then
            cmdManualScore.Enabled = True
        Else
            cmdManualScore.Enabled = False
        End If
    End Sub

    Private Sub cmdManualScore_Click(sender As Object, e As EventArgs) Handles cmdManualScore.Click
        frmManualScoringInfo.rankcode.Text = rankid.Text
        frmManualScoringInfo.categoryid.Text = categoryid.Text
        frmManualScoringInfo.Show(Me)
    End Sub


    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim report As New rptCategoryResult()
        report.categoryid.Text = categoryid.Text
        report.txtCategory.Text = txtCategoryType.Text
        report.txtbatch.Text = txtBatch.Text
        If GlobalRankCode = "DEFAULT" Then
            report.txtdetails.Text = "All " & GlobalContestantType
        Else
            report.txtdetails.Text = GlobalRankDescription
        End If
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        Me.WindowState = FormWindowState.Minimized
        report.ShowRibbonPreviewDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub
    

    Private Sub txtRank_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedValueChanged
        If txtRank.Text <> "DEFAULT" Then
            rankid.Text = DirectCast(txtRank.SelectedItem, ComboBoxItem).HiddenValue()
            LoadToComboBox("select * from tblcriteriacategory where eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'", "categoryDescription", "categoryid", txtCategoryType)
        End If
        ValidaManualEntry()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
 
    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            txtBatch.Enabled = False
        Else
            txtBatch.Enabled = True
        End If
        LoadEntries()
    End Sub
End Class