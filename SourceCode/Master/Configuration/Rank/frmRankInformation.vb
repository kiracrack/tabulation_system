Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmRankInformation
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
            rankid.Text = getGlobalTrnid("R" & globaluserid)
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblrankingcategory set eventid='" & GlobalEventID & "', rankDescription='" & rchar(txtRankDescription.Text) & "', rankLimit='" & rchar(txtRankLimit.Text) & "' where rankid='" & rankid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblrankingcategory set eventid='" & GlobalEventID & "', rankid='" & rankid.Text & "', rankDescription='" & rchar(txtRankDescription.Text) & "', rankLimit='" & rchar(txtRankLimit.Text) & "'" : com.ExecuteNonQuery()
        End If
        rankid.Text = getGlobalTrnid("R" & globaluserid)
        frmRankEntries.LoadEntries()
        MessageBox.Show("Rank Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    
    Public Sub ShowInfo()
        If rankid.Text = "" Then Exit Sub
        com.CommandText = "select * from tblrankingcategory where rankid='" & rankid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtRankDescription.Text = rst("rankDescription").ToString
            txtRankLimit.Text = rst("rankLimit").ToString
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class