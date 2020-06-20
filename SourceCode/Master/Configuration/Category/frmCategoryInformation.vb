Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmCategoryInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function



    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mode.Text = "edit" Then
            ShowInfo()
        Else
            categoryid.Text = getGlobalTrnid("C" & globaluserid)
            txtOrder.Text = Val(countqry("tblcriteriacategory", "eventid = '" & GlobalEventID & "' and rankid='" & rankid.Text & "'")) + 1
            If ckCheckall.Checked = True Then
                LoadToComboBox("select rankid,rankDescription from tblrankingcategory where  eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
                txtRank.Enabled = True
            Else
                txtRank.Items.Clear()
                rankid.Text = "DEFAULT"
                txtRank.Items.Add("DEFAULT")
                txtRank.SelectedIndex = 0
                txtRank.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblcriteriacategory set eventid='" & GlobalEventID & "', rankid='" & rankid.Text & "', categoryDescription='" & rchar(txtCategory.Text) & "',categoryorder='" & txtOrder.Value & "'  where categoryid='" & categoryid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcriteriacategory set eventid='" & GlobalEventID & "',rankid='" & rankid.Text & "', categoryid='" & categoryid.Text & "', categoryDescription='" & rchar(txtCategory.Text) & "',categoryorder='" & txtOrder.Value & "'" : com.ExecuteNonQuery()
        End If
        categoryid.Text = getGlobalTrnid("C" & globaluserid)
        txtCategory.Text = "" : txtCategory.Focus()
        txtOrder.Text = Val(countqry("tblcriteriacategory", "eventid = '" & GlobalEventID & "' and rankid='" & rankid.Text & "'")) + 1
        frmCategoryEntries.LoadEntries()
        MessageBox.Show("Category Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub ShowInfo()
        If categoryid.Text = "" Then Exit Sub
        Dim rank As String = "" : Dim rankinfo As String = ""
        com.CommandText = "select *,(select rankDescription from tblrankingcategory where rankid = tblcriteriacategory.rankid) as 'rank' from tblcriteriacategory where categoryid='" & categoryid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCategory.Text = rst("categoryDescription").ToString
            txtOrder.Value = rst("categoryorder").ToString
            rank = rst("rankid").ToString
            rankinfo = rst("rank").ToString
        End While
        rst.Close()
        If rank = "DEFAULT" Or rank = "" Then
            txtRank.Items.Clear()
            rankid.Text = "DEFAULT"
            txtRank.Items.Add("DEFAULT")
            txtRank.SelectedIndex = 0
            txtRank.Enabled = False
        Else
            LoadToComboBox("select rankid,rankDescription from tblrankingcategory where  eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
            txtRank.Enabled = True
            rankid.Text = rank
            txtRank.Text = rankinfo
        End If
    End Sub
    Private Sub txtRank_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedValueChanged
        If txtRank.Text = "DEFAULT" Then Exit Sub
        If txtRank.Text <> "" Then
            rankid.Text = DirectCast(txtRank.SelectedItem, ComboBoxItem).HiddenValue()
            txtOrder.Text = Val(countqry("tblcriteriacategory", "eventid = '" & GlobalEventID & "' and rankid='" & rankid.Text & "'")) + 1
        Else
            rankid.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ckCheckall_CheckedChanged(sender As Object, e As EventArgs) Handles ckCheckall.CheckedChanged
        If ckCheckall.Checked = True Then
            LoadToComboBox("select rankid,rankDescription from tblrankingcategory where  eventid='" & GlobalEventID & "'", "rankDescription", "rankid", txtRank)
            txtRank.Enabled = True
        Else
            txtRank.Items.Clear()
            rankid.Text = "DEFAULT"
            txtRank.Items.Add("DEFAULT")
            txtRank.SelectedIndex = 0
            txtRank.Enabled = False
        End If
    End Sub

    Private Sub txtRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRank.SelectedIndexChanged

    End Sub
End Class