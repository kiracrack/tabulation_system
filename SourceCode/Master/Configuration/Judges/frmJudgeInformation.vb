Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmJudgeInformation
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
            judgeid.Text = getGlobalTrnid("J" & globaluserid)
            txtJudgeNumber.Value = Val(countqry("tbljudges", "eventid = '" & GlobalEventID & "'")) + 1
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tbljudges set eventid='" & GlobalEventID & "', JudgeName='" & rchar(txtJudgeName.Text) & "', judgeNumber='" & rchar(txtJudgeNumber.Text) & "',username='" & txtUsername.Text & "',password='" & txtPassword.Text & "' where judgeid='" & judgeid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tbljudges set eventid='" & GlobalEventID & "', judgeid='" & judgeid.Text & "', JudgeName='" & rchar(txtJudgeName.Text) & "', judgeNumber='" & rchar(txtJudgeNumber.Text) & "', username='" & txtUsername.Text & "',password='" & txtPassword.Text & "'" : com.ExecuteNonQuery()
        End If
        judgeid.Text = getGlobalTrnid("J" & globaluserid)
        txtJudgeNumber.Value = Val(countqry("tbljudges", "eventid = '" & GlobalEventID & "'")) + 1
        txtJudgeName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        frmJudgeEntries.LoadEntries()
        MessageBox.Show("Judge Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub ShowInfo()
        If judgeid.Text = "" Then Exit Sub
        com.CommandText = "select * from tbljudges where judgeid='" & judgeid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtJudgeName.Text = rst("JudgeName").ToString
            txtJudgeNumber.Text = rst("judgeNumber").ToString
            txtUsername.Text = rst("username").ToString
            txtPassword.Text = rst("password").ToString
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class