Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net

Public Class frmSystemUpdate

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtDetails.Text = "" Then
            MessageBox.Show("Please enter valid details!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        ElseIf txtFeatures.Text = "" Then
            MessageBox.Show("Please enter update features!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFeatures.Focus()
            Exit Sub
        ElseIf txtVersion.Text = "" Then
            MessageBox.Show("Please enter update version!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVersion.Focus()
            Exit Sub
        ElseIf txtUrl.Text = "" Then
            MessageBox.Show("Please enter url!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUrl.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter password!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblsysteminfo set active=0" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblsysteminfo set details='" & rchar(txtDetails.Text) & "', version='" & txtVersion.Text & "', downloadurl='" & rchar(txtUrl.Text) & "', features='" & rchar(txtFeatures.Text) & "', password='" & txtPassword.Text & "', active=1" : com.ExecuteNonQuery()
        MessageBox.Show("New Version successfully Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmSystemUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDetails.Text = "Coffeecup Client v" & fversion
        txtVersion.Text = fversion
    End Sub

 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSystemUploader.ShowDialog(Me)
    End Sub
    
End Class