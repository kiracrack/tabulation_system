Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmAdvanceSearch

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class