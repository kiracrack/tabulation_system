Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmJudgingControl
#Region "Call Data Reload Function"


#End Region
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Category", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("id", -2, HorizontalAlignment.Left)
        ListView1.Columns(1).Width = 0
        If countqry("tblactivatedcontestant", "eventid='" & GlobalEventID & "' and rankid<>'DEFAULT'") = 0 Then
            txtRank.Items.Add("DEFAULT")
            rankid.Text = "DEFAULT"
            txtRank.SelectedIndex = 0
            txtRank.Enabled = False
        Else
            LoadToComboBox("select rankid,rankDescription from tblrankingcategory where rankid in (select distinct(rankid) from tblactivatedcontestant where eventid='" & GlobalEventID & "') and eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
            txtRank.Items.Add("DEFAULT")
            txtRank.Enabled = True
            Dim rank As String = ""
            If countqry("tblrankingcategory", "eventid='" & GlobalEventID & "' and activated=1") <> 0 Then
                com.CommandText = "select * from tblrankingcategory where eventid='" & GlobalEventID & "' and activated=1" : rst = com.ExecuteReader()
                While rst.Read
                    rankid.Text = rst("rankid").ToString
                    rank = rst("rankDescription").ToString
                End While
                rst.Close()
            End If
            txtRank.Text = rank
        End If
        LoadAllCategory()
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()

    End Sub

    Public Sub LoadAllCategory()
        ListView1.Items.Clear()
        com.CommandText = "select * from tblcriteriacategory where eventid='" & GlobalEventID & "' and " & If(txtRank.Text = "DEFAULT", "rankid='DEFAULT'", "rankid='" & rankid.Text & "'") & "" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("categoryDescription").ToString, 0)
            item1.SubItems.Add(rst("categoryid").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()

        com.CommandText = "select * from tblcriteriacategory where eventid='" & GlobalEventID & "' and activated=1" : rst = com.ExecuteReader
        While rst.Read
            For Each itm As ListViewItem In ListView1.Items
                If itm.SubItems(1).Text = rst("categoryid").ToString Then
                    itm.Checked = True
                End If
            Next
        End While
        rst.Close()
    End Sub

    Private Sub txtRank_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedValueChanged
        If txtRank.Text <> "DEFAULT" Then
            rankid.Text = DirectCast(txtRank.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            rankid.Text = "DEFAULT"
        End If
        LoadAllCategory()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        'If txtBatch.Text = "" Then
        '    MsgBox("Please select group batch", MsgBoxStyle.Exclamation)
        '    txtBatch.Focus()
        '    Exit Sub
        'Else
        If ListView1.CheckedItems.Count = 0 Then
            MsgBox("Please check category atleast one to activate", MsgBoxStyle.Exclamation)
            ListView1.Focus()
            Exit Sub
        ElseIf ListView1.CheckedItems.Count > 1 Then
            MsgBox("Please check only one category", MsgBoxStyle.Exclamation)
            ListView1.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to activate this option? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If txtRank.Text = "DEFAULT" Then
                com.CommandText = "update tblrankingcategory set activated=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
                If countqry("tblactivatedcontestant", "eventid='" & GlobalEventID & "' and rankid='DEFAULT'") = 0 Then
                    com.CommandText = "insert into tblactivatedcontestant (eventid,rankid,contestantid,batchcode) select '" & GlobalEventID & "','DEFAULT',contestantid,batchcode from tblcontestant  where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
                End If
            Else
                If rankid.Text <> "DEFAULT" Then
                    com.CommandText = "update tblrankingcategory set activated=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblrankingcategory set activated=1 where eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'" : com.ExecuteNonQuery()
                    'If countqry("tblactivatedcontestant", "eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "' and batchcode='" & batchcode.Text & "'") = 0 Then
                    '    com.CommandText = "insert into tblactivatedcontestant (eventid,rankid,contestantid,batchcode) select '" & GlobalEventID & "','" & rankid.Text & "',contestantid,batchcode from tblcontestant  where eventid='" & GlobalEventID & "'  and batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
                    'End If
                Else
                    If countqry("tblactivatedcontestant", "eventid='" & GlobalEventID & "' and rankid='" & rankid.Text & "'") = 0 Then
                        com.CommandText = "insert into tblactivatedcontestant (eventid,rankid,contestantid,batchcode) select '" & GlobalEventID & "','" & rankid.Text & "',contestantid,batchcode from tblcontestant  where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
                    End If
                End If
            End If

            '#ACTIVATE BATCH
            com.CommandText = "update tblbatch set activated=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblbatch set activated=1 where eventid='" & GlobalEventID & "' and batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()

            '#ACTIVATE CATEGORY
            com.CommandText = "update tblcriteriacategory set activated=0, lastcategory=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
            For Each itm As ListViewItem In ListView1.Items
                If itm.Checked Then
                    com.CommandText = "update tblcriteriacategory set activated=1, lastcategory=" & ckLastCategory.CheckState & "  where categoryid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
                End If
            Next
            LoadActivatedInfo()
            MessageBox.Show("Judging successfully activated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to reset judging? " & Environment.NewLine, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If frmScoreMonitoring.Visible = True Then
                frmScoreMonitoring.Close()
            End If
            com.CommandText = "update tblrankingcategory set activated=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tbljudges set status=6 where eventid='" & GlobalEventID & "' and status <> 0" : com.ExecuteNonQuery()
            com.CommandText = "update tblcriteriacategory set activated=0 where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblscores where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()
            com.CommandText = "delete from tblactivatedcontestant where eventid='" & GlobalEventID & "'" : com.ExecuteNonQuery()

            GlobalRankCode = ""
            GlobalRankDescription = ""
            MessageBox.Show("Judging option successfully reset!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub ckDefault_CheckedChanged(sender As Object, e As EventArgs)
        'If ckDefault.Checked = True Then
        '    txtRank.SelectedIndex = -1
        '    txtRank.Enabled = False
        'Else
        '    txtRank.Enabled = True
        'End If
    End Sub

    Private Sub txtRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedIndexChanged

    End Sub

   
End Class