Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmManualScoringInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToComboBox("select * from tbljudges inner join tbljudgecategory on tbljudges.judgeid = tbljudgecategory.judgeid where tbljudges.eventid='" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' order by judgeNumber asc", "JudgeName", "judgeid", txtJudge)
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
        loadContestant()
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()
        loadContestant()
    End Sub

    Public Sub loadContestant()
        If ckAll.Checked = True Then
            LoadToComboBox("select *, concat(contestantNumber, ' - ', contestantName) as contender from tblactivatedcontestant inner join tblcontestant on tblactivatedcontestant.contestantid = tblcontestant.contestantid  where tblactivatedcontestant.eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' order by contestantNumber asc", "contender", "contestantid", txtCandidate)
        Else
            LoadToComboBox("select *,concat(contestantNumber, ' - ', contestantName) as contender from tblactivatedcontestant inner join tblcontestant on tblactivatedcontestant.contestantid = tblcontestant.contestantid  where tblactivatedcontestant.eventid='" & GlobalEventID & "' and rankid='" & GlobalRankCode & "' and tblcontestant.batchcode='" & batchcode.Text & "' order by contestantNumber asc", "contender", "contestantid", txtCandidate)
        End If

    End Sub

    Public Sub LoadEntries()
        If countqry("tblscores", "judgeid='" & judgeid.Text & "' and contestantid='" & candidateid.Text & "' and categoryid='" & categoryid.Text & "'") = 0 Then
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select criteriaid, criteriaName  as 'Criteria',criteriaScore as '" & GlobalSymbolInUse & "',  '0' as Score from tblcriteriaforjudging where eventid = '" & GlobalEventID & "' and categoryid='" & categoryid.Text & "' order by sortOrder asc", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
        Else
            Em.DataSource = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select tblcriteriaforjudging.criteriaid, criteriaName as 'Criteria',criteriaScore as '" & GlobalSymbolInUse & "', cast(Score as char(10)) AS 'Score'  from tblcriteriaforjudging inner join tblscores on tblcriteriaforjudging.criteriaid = tblscores.criteriaid and tblcriteriaforjudging.categoryid = tblscores.categoryid where tblcriteriaforjudging.eventid = '" & GlobalEventID & "' and tblcriteriaforjudging.categoryid='" & categoryid.Text & "' and tblscores.judgeid = '" & judgeid.Text & "' and tblscores.contestantid ='" & candidateid.Text & "' order by sortOrder asc", conn)
            msda.Fill(dst, 0)
            Em.DataSource = dst.Tables(0)
        End If
        GridHideColumn(Em, {"criteriaid"})
        Em.Columns(GlobalSymbolInUse).Width = 90
        Em.Columns("Score").Width = 90
        Em.Columns("Criteria").ReadOnly = True
        Em.Columns(GlobalSymbolInUse).ReadOnly = True
        GridColumnAlignment(Em, {"Score", GlobalSymbolInUse}, DataGridViewContentAlignment.MiddleCenter)

        If Em.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To Em.RowCount - 1
                totalsum = totalsum + Em.Rows(i).Cells("Score").Value()
            Next
            txtTotal.Text = FormatNumber(totalsum, 2)
        End If
    End Sub
    Private Sub txtCandidate_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCandidate.SelectedValueChanged
        If txtCandidate.Text <> "" Then
            candidateid.Text = DirectCast(txtCandidate.SelectedItem, ComboBoxItem).HiddenValue()
            com.CommandText = "select * from tblcontestant where contestantid='" & candidateid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                candidateno.Text = rst("contestantNumber").ToString
            End While
            rst.Close()
        Else
            candidateid.Text = ""
        End If
        LoadEntries()
    End Sub
    Private Sub Em_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Em.CellFormatting
        On Error Resume Next
        Dim intValue As Integer
        If Val(Em.Item(GlobalSymbolInUse, e.RowIndex).Value) < Val(Em.Item("Score", e.RowIndex).Value) Or Em.Item("Score", e.RowIndex).Value.ToString = "" Or Val(Em.Item("Score", e.RowIndex).Value) = 0 Then
            Em.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            Em.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        Else
            Em.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            Em.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
        If Em.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To Em.RowCount - 1
                totalsum = totalsum + Em.Rows(i).Cells("Score").Value()
            Next
            txtTotal.Text = FormatNumber(totalsum, 2)
        End If
    End Sub

    Private Sub txtJudge_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtJudge.SelectedValueChanged
        If txtJudge.Text <> "" Then
            judgeid.Text = DirectCast(txtJudge.SelectedItem, ComboBoxItem).HiddenValue()
            com.CommandText = "select * from tbljudges where judgeid='" & judgeid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtJudgeNumber.Text = rst("judgeNumber").ToString
            End While
            rst.Close()
            If candidateid.Text <> "" Then
                LoadEntries()
            End If
        Else
            judgeid.Text = ""
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        On Error Resume Next
        Dim errorFound As Boolean = False
        For i = 0 To Em.RowCount - 1
            If Val(Em.Item(GlobalSymbolInUse, i).Value) < Val(Em.Item("Score", i).Value) Or Em.Item("Score", i).Value.ToString = "" Or Val(Em.Item("Score", i).Value) = 0 Then
                MessageBox.Show("Your score on " & Em.Item("Criteria", i).Value.ToString & " is Invalid!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorFound = True
            End If
        Next
        If errorFound = True Then
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to submit your score? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblscores where judgeid='" & judgeid.Text & "' and contestantid='" & candidateid.Text & "' and categoryid='" & categoryid.Text & "'" : com.ExecuteNonQuery()
            For i = 0 To Em.RowCount - 1
                com.CommandText = "insert into tblscores set eventid='" & GlobalEventID & "', rankid='" & rankcode.Text & "', categoryid='" & categoryid.Text & "', judgeid='" & judgeid.Text & "', contestantid='" & candidateid.Text & "',criteriaid='" & Em.Item("criteriaid", i).Value() & "', score='" & Em.Item("Score", i).Value() & "'" : com.ExecuteNonQuery()
            Next
            frmManualScoring.LoadEntries()
            MessageBox.Show("Score successfully saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCandidate.Focus()
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If Val(CC(txtTotal.Text)) = 0 Then
            txtTotal.BackColor = Color.Red
            txtTotal.ForeColor = Color.White
        Else
            txtTotal.BackColor = Color.Gold
            txtTotal.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtJudge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtJudge.SelectedIndexChanged

    End Sub

    Private Sub ckAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckAll.CheckedChanged
        If ckAll.Checked = True Then
            txtBatch.Enabled = False
        Else
            txtBatch.Enabled = True
        End If
        loadContestant()
    End Sub

    Private Sub txtCandidate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCandidate.SelectedIndexChanged

    End Sub
End Class