Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmChangePassword

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select * from tblaccounts where accountid = '" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtName.Text = rst("fullname").ToString
            txtPosition.Text = rst("designation").ToString
        End While
        rst.Close()
    End Sub
   
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter your name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter your position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtCurrentPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter your current password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter you new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please verify your new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text And ckChangePassword.Checked = True Then
            MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "accountid='" & globaluserid & "' and password='" & EncryptTripleDES(UCase(globalusername) + txtCurrentPassword.Text) & "'") = 0 And ckChangePassword.Checked = True Then
            MessageBox.Show("Your current password is invalid! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to confirm? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblaccounts set fullname='" & txtName.Text & "',designation='" & txtPosition.Text & "' " & If(ckChangePassword.Checked = True, " , password='" & EncryptTripleDES(UCase(globalusername) + txtVerifyPassword.Text) & "' ", "") & "where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
            MessageBox.Show("your account successfuly updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        Me.Close()
    End Sub

    Private Sub ckEnableEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles ckChangePassword.CheckedChanged
        If ckChangePassword.Checked = True Then
            txtCurrentPassword.ReadOnly = False
            txtNewPassword.ReadOnly = False
            txtVerifyPassword.ReadOnly = False
            cmdset.Text = "Confirm Password"
        Else
            txtCurrentPassword.ReadOnly = True
            txtNewPassword.ReadOnly = True
            txtVerifyPassword.ReadOnly = True
            cmdset.Text = "Close"
        End If
    End Sub
End Class