Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraReports.UI

Public Class frmTopRankingControl
#Region "Call Data Reload Function"


#End Region
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = GlobalContestantType & " Ranking Control System"
        lbltitle.Text = GlobalContestantType & " Ranking Control"
        lbldescription.Text = "You can use this tool to confirm of top selection " & GlobalContestantType
        cmdLoad.Text = "Load " & GlobalContestantType
        LoadToComboBox("select rankid,rankDescription from tblrankingcategory where  eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()

    End Sub

    Private Sub txtRank_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedValueChanged
        If txtRank.Text <> "DEFAULT" Then
            rankid.Text = DirectCast(txtRank.SelectedItem, ComboBoxItem).HiddenValue()
            com.CommandText = "select * from tblrankingcategory where eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'" : rst = com.ExecuteReader()
            While rst.Read
                txtLimit.Text = rst("rankLimit").ToString
            End While
            rst.Close()
            txtDetails.Text = "Displayed " & txtRank.Text & " with no particular order"
            cmdConfirm.Enabled = True
        Else
            cmdConfirm.Enabled = False
            rankid.Text = ""
        End If
    End Sub

#Region "GLOBAL COMPUTATION"

    Public Sub LoadEntries()
        Dim aveCol As String = "" : Dim getValueTotal As String = "" : Dim getQueryDed As String = ""
        If GlobalShowAverage = True Then
            aveCol = " ,'0' as 'Average' "
        End If
        If GlobalEnableDeduction = True Then
            getQueryDed = "-ifnull((select deduction from tbldeductions where contestantid = tblscores.contestantid),0)"
        End If
        If GlobalComputation = "AVERAGE" Then
            getValueTotal = "ifnull(sum(score/(select count(*) from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudges.eventid='" & GlobalEventID & "' and categoryid=tblscores.categoryid)),0)" & getQueryDed
        Else
            getValueTotal = "ifnull(sum(score),0)" & getQueryDed
        End If

        LoadXgrid("select contestantid, (select contestantNumber from tblcontestant where contestantid = tblscores.contestantid) as 'No.', " _
                    + " (select contestantName from tblcontestant where contestantid = tblscores.contestantid) as 'Contestant', " _
                    + " (select representativePlace from tblcontestant where contestantid = tblscores.contestantid) as 'Representative', " _
                    + " " & getValueTotal & " as Total " & aveCol & ", '0' as 'Rank'  from tblscores where eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' " & If(ckAll.Checked = True, "", "and contestantid in (select contestantid from tblcontestant where batchcode='" & batchcode.Text & "' and eventid='" & GlobalEventID & "')") & " group by contestantid order by " & getValueTotal & " desc  limit " & txtLimit.Text & "", "tblscores", Em, GridView1)
        GridView1.Columns("contestantid").Visible = False
        GridView1.BestFitColumns()
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("Total").Width = 80
        XgridColCurrency("Total", GridView1)
        XgridColAlign("Total", GridView1, DevExpress.Utils.HorzAlignment.Center)


        '#GET FINAL RANK
        Dim r As Integer = 1
        Dim t As Integer = 0
        Dim temp As Integer = 1
        Dim curtotal As Double = 0
        com.CommandText = "select *," & getValueTotal & "  as total from tblscores where eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' group by contestantid order by " & getValueTotal & " desc " : rst = com.ExecuteReader
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
        XgridColCurrency("Rank", GridView1)
        XgridColAlign("Rank", GridView1, DevExpress.Utils.HorzAlignment.Center)
        '------------------END--------------------

        '#GET TOTAL AVERAGE
        If GlobalShowAverage = True Then
            Dim totalCategory As Integer = countqry("tblcriteriacategory", "eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "'")
            For v = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(v, "Average", FormatNumber(Val(CC(GridView1.GetRowCellValue(v, "Total").ToString())) / totalCategory, 2))
            Next
            GridView1.Columns("Average").Width = 80
            XgridColCurrency("Average", GridView1)
            XgridColAlign("Average", GridView1, DevExpress.Utils.HorzAlignment.Center)
        End If
        'GridView1.Columns("No.").Visible = False
        '------------------END--------------------
    End Sub

    Public Sub LoadWinner()

        Dim cnttitle As Integer = countqry("tblranktitle", "eventid='" & GlobalEventID & "'")
        Dim aveCol As String = "" : Dim getValueTotal As String = "" : Dim getQueryDed As String = ""
        If GlobalShowAverage = True Then
            aveCol = " ,'0' as 'Average' "
        End If

        If GlobalEnableDeduction = True Then
            getQueryDed = "-ifnull((select deduction from tbldeductions where contestantid = tblscores.contestantid),0)"
        End If
        If GlobalComputation = "AVERAGE" Then
            getValueTotal = "ifnull(sum(score/(select count(*) from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudges.eventid='" & GlobalEventID & "' and categoryid=tblscores.categoryid)),0)" & getQueryDed
        Else
            getValueTotal = "ifnull(sum(score),0)" & getQueryDed
        End If

        LoadXgrid("select contestantid,  (select contestantNumber from tblcontestant where contestantid = tblscores.contestantid) as 'No.', " _
                    + " (select contestantName from tblcontestant where contestantid = tblscores.contestantid) as 'Contestant', " _
                    + " ' ' as 'Title', " _
                    + " " & getValueTotal & " as Total " & aveCol & ", '0' as 'Rank'  from tblscores where eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' " & If(ckAll.Checked = True, "", "and contestantid in (select contestantid from tblcontestant where batchcode='" & batchcode.Text & "' and eventid='" & GlobalEventID & "')") & " group by contestantid order by " & getValueTotal & " desc  limit " & cnttitle & "", "tblscores", Em2, GridView2)
        GridView2.Columns("contestantid").Visible = False
        XgridColAlign("No.", GridView2, DevExpress.Utils.HorzAlignment.Center)

        '#GET FINAL RANK
        Dim r As Integer = 1
        Dim t As Integer = 0
        Dim tem2p As Integer = 1
        Dim curtotal As Double = 0
        com.CommandText = "select *," & getValueTotal & " as total from tblscores where eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "'  " & If(ckAll.Checked = True, "", "and contestantid in (select contestantid from tblcontestant where batchcode='" & batchcode.Text & "' and eventid='" & GlobalEventID & "')") & " group by contestantid order by " & getValueTotal & " desc limit " & cnttitle & " " : rst = com.ExecuteReader
        While rst.Read
            If Val(rst("total").ToString) < curtotal Then
                r = r + 1 + t
                t = 0
            Else
                r = r
                If tem2p <> 1 Then
                    t = t + 1
                End If
                tem2p = 0
            End If
            curtotal = Val(rst("total").ToString)
            For v = 0 To GridView2.RowCount - 1
                If GridView2.GetRowCellValue(v, "contestantid").ToString() = rst("contestantid").ToString Then
                    GridView2.SetRowCellValue(v, "Rank", r)
                End If
            Next
        End While
        rst.Close()
        '------------------END--------------------

        '#GET WINNER TITLE
        For v = 0 To GridView2.RowCount - 1
            com.CommandText = "select * from tblranktitle where eventid='" & GlobalEventID & "' order by rank desc" : rst = com.ExecuteReader
            While rst.Read
                If Val(GridView2.GetRowCellValue(v, "Rank").ToString()) = Val(rst("rank").ToString) Then
                    GridView2.SetRowCellValue(v, "Title", rst("description").ToString)
                End If
            End While
            rst.Close()
        Next
        GridView2.BestFitColumns()
        '------------------END--------------------

        ''#GET TOTAL AVERAGE
        If GlobalShowAverage = True Then
            Dim totalCategory As Integer = countqry("tblcriteriacategory", "eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "'")
            For v = 0 To GridView2.RowCount - 1
                GridView2.SetRowCellValue(v, "Average", FormatNumber(Val(CC(GridView2.GetRowCellValue(v, "Total").ToString())) / totalCategory, 2))
            Next
            GridView2.Columns("Average").Width = 80
            XgridColCurrency("Average", GridView2)
            XgridColAlign("Average", GridView2, DevExpress.Utils.HorzAlignment.Center)
        End If
        '------------------END--------------------
        GridView2.Columns("Total").Width = 80
        XgridColCurrency("Total", GridView2)
        XgridColAlign("Total", GridView2, DevExpress.Utils.HorzAlignment.Center)

        GridView2.Columns("Rank").Width = 80
        XgridColCurrency("Rank", GridView2)
        XgridColAlign("Rank", GridView2, DevExpress.Utils.HorzAlignment.Center)

        GridView2.Columns("Rank").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        'GridView2.Columns("No.").Visible = False
    End Sub

#End Region

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Dim report As New rptCategoryResult()
        report.categoryid.Text = ""
        report.txtCategory.Text = "FINAL RESULT"
        report.txtdetails.Text = "Official Title Holder"
        report.txtbatch.Text = txtBatch.Text
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em2))
        report.ShowRibbonPreviewDialog()

    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        LoadEntries()
        LoadWinner()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        Dim report As New rptCategoryResult()
        report.categoryid.Text = ""
        report.txtCategory.Text = txtRank.Text
        report.txtbatch.Text = txtBatch.Text
        report.txtdetails.Text = txtDetails.Text
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        Me.WindowState = FormWindowState.Minimized
        report.ShowRibbonPreviewDialog()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If MessageBox.Show("Are you sure you want to confirm? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblactivatedcontestant where eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'" : com.ExecuteNonQuery()
            For i = 0 To GridView1.RowCount - 1
                com.CommandText = "insert into tblactivatedcontestant set eventid='" & GlobalEventID & "', rankid='" & rankid.Text & "', contestantid='" & GridView1.GetRowCellValue(i, "contestantid").ToString() & "'" : com.ExecuteNonQuery()
            Next
            MessageBox.Show(txtRank.Text & " successfully confirmed!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
 
    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            txtBatch.Enabled = False
        Else
            txtBatch.Enabled = True
        End If
    End Sub
End Class