Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmDeduction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInfo()
    End Sub

    Public Sub LoadInfo()
        com.CommandText = "select * from tbldeductions where contestantid='" & contestantid.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtDeduction.Text = rst("deduction").ToString
            txtRemarks.Text = rst("remarks").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If countqry("tbldeductions", "contestantid='" & contestantid.Text & "'") = 0 Then
            com.CommandText = "insert into tbldeductions set eventid='" & GlobalEventID & "', contestantid='" & contestantid.Text & "', deduction='" & txtDeduction.Text & "', remarks='" & rchar(txtRemarks.Text) & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tbldeductions set deduction='" & txtDeduction.Text & "', remarks='" & rchar(txtRemarks.Text) & "' where contestantid='" & contestantid.Text & "'" : com.ExecuteNonQuery()
        End If
        frmFinalScore.LoadEntries()
        MessageBox.Show("Deduction Successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class