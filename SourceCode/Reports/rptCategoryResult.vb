Imports System.IO

Public Class rptCategoryResult
    Private Sub rptApprovedPO_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        txtPreparedby.Text = globalfullname
        com.CommandText = "select *,date_format(eventDate, '%M %d, %Y') as 'date' from tblevent where eventid='" & GlobalEventID & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtEventName.Text = rst("eventName").ToString
            txtEvenCategory.Text = rst("eventCategory").ToString
            txtEventTitle.Text = rst("eventTitle").ToString
            txtEventDate.Text = rst("date").ToString
        End While
        rst.Close()
        txtdatePrint.Text = Now.ToString("MMMM dd, yyyy hh:mm tt")
        XrPictureBox1.Image = Globallogo
        txtPreparedby.Text = globalfullname
        '# JUDGES
        Dim jsequence As Integer = 1
        com.CommandText = "select distinct(JudgeName),JudgeName,judgeNumber from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid " _
                          + " inner join tblcriteriacategory on tblcriteriacategory.categoryid = tbljudgecategory.categoryid where tbljudges.eventid='" & GlobalEventID & "' and tbljudgecategory.categoryid like '%" & categoryid.Text & "%' and activated=1 order by judgeNumber asc"
        rst = com.ExecuteReader
        While rst.Read
            If jsequence = 1 Then
                sline1.Visible = True
                txtJudge1.Text = rst("JudgeName").ToString
                txtJudgeTitle1.Text = "Judge#" & rst("judgeNumber").ToString
            ElseIf jsequence = 2 Then
                sline2.Visible = True
                txtJudge2.Text = rst("JudgeName").ToString
                txtJudgeTitle2.Text = "Judge#" & rst("judgeNumber").ToString

            ElseIf jsequence = 3 Then
                sline3.Visible = True
                txtJudge3.Text = rst("JudgeName").ToString
                txtJudgeTitle3.Text = "Judge#" & rst("judgeNumber").ToString

            ElseIf jsequence = 4 Then
                sline4.Visible = True
                txtJudge4.Text = rst("JudgeName").ToString
                txtJudgeTitle4.Text = "Judge#" & rst("judgeNumber").ToString

            ElseIf jsequence = 5 Then
                sline5.Visible = True
                txtJudge5.Text = rst("JudgeName").ToString
                txtJudgeTitle5.Text = "Judge#" & rst("judgeNumber").ToString

            ElseIf jsequence = 6 Then
                sline6.Visible = True
                txtJudge6.Text = rst("JudgeName").ToString
                txtJudgeTitle6.Text = "Judge#" & rst("judgeNumber").ToString
            End If
            jsequence = jsequence + 1
        End While
        rst.Close()

        txtCopyright.Text = Globalcopyright
        txtContact.Text = GlobalContactDeveloper

    End Sub
End Class