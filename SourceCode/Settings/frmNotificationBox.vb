Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmNotificationBox
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewLocalparticulars()
    End Sub

    Public Sub ViewLocalparticulars()
        Dim view As New DataView
        If System.IO.File.Exists(file_notifications) = True Then
            dst = New DataSet : dst.Clear() : MyDataGridView.DataSource = Nothing : dst.ReadXml(file_notifications)
            MyDataGridView.DataSource = dst
            If dst.Tables.Count <> 0 Then
                MyDataGridView.DataMember = "tblnotifylist"
            End If
        Else
            SynchNotifications()
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        SynchNotifications()
        ViewLocalparticulars()
    End Sub
End Class