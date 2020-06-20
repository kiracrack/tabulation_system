Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI

Public Class frmFinalScore
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEntries()
        If GlobalEnableDeduction = True Then
            Em.ContextMenuStrip = cms_em
        Else
            Em.ContextMenuStrip = Nothing
        End If
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()
        LoadEntries()
    End Sub

    Public Sub LoadEntries()
        GridView1.ClearSorting()
        Dim jCaption As String = "" : Dim jColumn As String = "" : Dim jfilter As String = ""
        com.CommandText = "select * from tblcriteriacategory  where  eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' order by categoryorder asc" : rst = com.ExecuteReader
        While rst.Read
            jCaption = jCaption + "'0' as '" & StrConv(rst("categoryDescription").ToString, vbProperCase) + "',"
            jColumn = jColumn + StrConv(rst("categoryDescription").ToString, vbProperCase) + ":"
            jfilter = jfilter + StrConv(rst("categoryid").ToString, vbProperCase) + ":"
        End While
        rst.Close()
        If jCaption <> "" Then
            jCaption = jCaption.Remove(jCaption.Length - 1, 1)
            jColumn = jColumn.Remove(jColumn.Length - 1, 1)
            jfilter = jfilter.Remove(jfilter.Length - 1, 1)
        End If

        Dim aveCol As String = ""
        If GlobalShowAverage = True Then
            aveCol = " ,'0' as 'Average' "
        End If
        Dim dedCol As String = ""
        If GlobalEnableDeduction = True Then
            dedCol = " ,'0' as 'Deduction', '' as 'Deduction Remarks' "
        End If
        LoadXgrid("select tblcontestant.contestantid, tblcontestant.contestantNumber as 'No.',contestantName as '" & GlobalContestantType & "', " & jCaption & dedCol & ",'0' as Total " & aveCol & ", 0 as 'Rank'  from tblactivatedcontestant inner join tblcontestant on tblactivatedcontestant.contestantid = tblcontestant.contestantid  where tblactivatedcontestant.eventid='" & GlobalEventID & "' and tblactivatedcontestant.rankid='" & GlobalRankCode & "'  " & If(ckAll.Checked = True, "", " and tblcontestant.batchcode='" & batchcode.Text & "' ") & " group by contestantid order by contestantNumber asc", "tblactivatedcontestant", Em, GridView1)
        GridView1.Columns("contestantid").Visible = False
        GridView1.BestFitColumns()
        '#GET SCORE FOR EACH JUDGES
        For i = 0 To GridView1.RowCount - 1
            Dim total As Double = 0
            For Each word In jfilter.Split(New Char() {":"c})
                Dim columnCaption As String = qrysingledata("categoryDescription", "categoryDescription", "where categoryid='" & word & "' and rankid='" & GlobalRankCode & "'", "tblcriteriacategory")
                Dim totalJudgesinCat As Integer = countqry("tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid", "tbljudges.eventid='" & GlobalEventID & "' and categoryid='" & word & "' order by judgeNumber asc")
                com.CommandText = "select ifnull(sum(score/" & totalJudgesinCat & "),0) as 'Total' from tblscores where eventid='" & GlobalEventID & "'  and contestantid='" & GridView1.GetRowCellValue(i, "contestantid").ToString() & "' and categoryid='" & word & "' and rankid='" & GlobalRankCode & "'" : rst = com.ExecuteReader
                While rst.Read
                    GridView1.SetRowCellValue(i, StrConv(columnCaption, vbProperCase), FormatNumber(Val(rst("Total")), 2))

                    Dim a As Double = FormatNumber(Val(rst("Total")), 3)
                    total = total + a
                End While
                rst.Close()
            Next

            '#GET DEDUCTIONS
            If GlobalEnableDeduction = True Then
                GridView1.SetRowCellValue(i, "Deduction", qrysingledata("deduction", "deduction", "tbldeductions where contestantid='" & GridView1.GetRowCellValue(i, "contestantid").ToString() & "'", "tbldeductions"))
                GridView1.SetRowCellValue(i, "Deduction Remarks", qrysingledata("remarks", "remarks", "tbldeductions where contestantid='" & GridView1.GetRowCellValue(i, "contestantid").ToString() & "'", "tbldeductions"))
            End If

            '#GET TOTAL SCORES
            If GlobalEnableDeduction = True Then
                GridView1.SetRowCellValue(i, "Total", FormatNumber(total - Val(GridView1.GetRowCellValue(i, "Deduction").ToString()), 2))
            Else
                GridView1.SetRowCellValue(i, "Total", FormatNumber(total, 2))
            End If
        Next
        '------------------END--------------------
        ''#GET DEDUCTIONS
        'If GlobalEnableDeduction = True Then
        '    For v = 0 To GridView1.RowCount - 1
        '        GridView1.SetRowCellValue(v, "Deduction", qrysingledata("deduction", "deduction", "tbldeductions where contestantid='" & GridView1.GetRowCellValue(v, "contestantid").ToString() & "'", "tbldeductions"))
        '        GridView1.SetRowCellValue(v, "Deduction Remarks", qrysingledata("remarks", "remarks", "tbldeductions where contestantid='" & GridView1.GetRowCellValue(v, "contestantid").ToString() & "'", "tbldeductions"))
        '    Next
        'End If

        ''#GET TOTAL SCORES
        'For v = 0 To GridView1.RowCount - 1
        '    Dim total As Double = 0
        '    For Each word In jColumn.Split(New Char() {":"c})
        '        Dim a As Double = Val(CC(GridView1.GetRowCellValue(v, word).ToString()))
        '        total = total + a
        '    Next
        '    If GlobalEnableDeduction = True Then
        '        GridView1.SetRowCellValue(v, "Total", FormatNumber(total - Val(GridView1.GetRowCellValue(v, "Deduction").ToString()), 2))
        '    Else
        '        GridView1.SetRowCellValue(v, "Total", FormatNumber(total, 2))
        '    End If

        'Next

        GridView1.Columns("Total").SortOrder = DevExpress.Data.ColumnSortOrder.None
        GridView1.Columns("Total").Width = 80
        XgridColCurrency("Total", GridView1)
        XgridColAlign("Total", GridView1, DevExpress.Utils.HorzAlignment.Center)
        '------------------END--------------------

        '#GET TOTAL AVERAGE
        If GlobalShowAverage = True Then
            Dim totaljudge As Integer = countqry("tblcriteriacategory", "eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "'")
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
        Dim getQueryTotal As String = "" : Dim getQueryDed As String = ""
        If GlobalEnableDeduction = True Then
            getQueryDed = "-ifnull((select deduction from tbldeductions where contestantid = tblscores.contestantid),0)"
        End If

        If GlobalComputation = "AVERAGE" Then
            getQueryTotal = "ifnull(sum(score/(select count(*) from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudges.eventid='" & GlobalEventID & "' and categoryid=tblscores.categoryid)),0)" & getQueryDed
        Else
            getQueryTotal = "ifnull(sum(score),0)" & getQueryDed
        End If

        com.CommandText = "select *," & getQueryTotal & "  as total from tblscores where eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "'  " & If(ckAll.Checked = True, "", " and contestantid in (select contestantid from tblcontestant where batchcode='" & batchcode.Text & "')") & " group by contestantid order by " & getQueryTotal & " desc " : rst = com.ExecuteReader
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
        GridView1.BestFitColumns()
        GridView1.Columns("Rank").Width = 80
        XgridColAlign("Rank", GridView1, DevExpress.Utils.HorzAlignment.Center)
        If GlobalEnableDeduction = True Then
            XgridColAlign("Deduction", GridView1, DevExpress.Utils.HorzAlignment.Center)
            GridView1.Columns("Deduction Remarks").ColumnEdit = MemoEdit

        End If

        '------------------END--------------------

        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        For Each word In jColumn.Split(New Char() {":"c})
            GridView1.Columns(word).SortOrder = DevExpress.Data.ColumnSortOrder.None
            'GridView1.Columns(word).Width = 110
            XgridColCurrency(word, GridView1)
            XgridColAlign(word, GridView1, DevExpress.Utils.HorzAlignment.Center)
        Next
        GridView1.Columns("Rank").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        'GridView1.Columns("No.").Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If GridView1.Columns.Count > 10 Then
            Dim report As New rptOverallResultLandscape()
            report.categoryid.Text = ""
            report.txtCategory.Text = "OVERALL RESULT"
            report.txtbatch.Text = txtBatch.Text
            If GlobalRankCode = "DEFAULT" Then
                report.txtdetails.Text = "All " & GlobalContestantType
            Else
                report.txtdetails.Text = GlobalRankDescription
            End If
            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
            report.ShowRibbonPreviewDialog()
        Else
            Dim report As New rptOverallResultPortrait()
            report.categoryid.Text = ""
            report.txtCategory.Text = "OVERALL RESULT"
            report.txtbatch.Text = txtBatch.Text
            If GlobalRankCode = "DEFAULT" Then
                report.txtdetails.Text = "All " & GlobalContestantType
            Else
                report.txtdetails.Text = GlobalRankDescription
            End If
            report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
            report.ShowRibbonPreviewDialog()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmDeduction.contestantid.Text = GridView1.GetFocusedRowCellValue("contestantid").ToString
        frmDeduction.txtContestant.Text = GridView1.GetFocusedRowCellValue(GlobalContestantType).ToString
        frmDeduction.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmTopRankingControl.Show(Me)
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