﻿Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection

Public Class frmLogin
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Dim logtry As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Shift) + Keys.F12 Then
            frmConnectionSetup.ShowDialog()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot MainForm Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
          
            If System.IO.File.Exists(file_conn) = False Then
                frmConnectionSetup.ShowDialog()
                Me.Close()
            End If
            ConnectVerify()
            Me.Size = New Size(252, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MaximumSize = New Size(252, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MinimumSize = New Size(252, 753)
            Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
            loadimage.ImageLocation = Application.StartupPath & "\logo.png"
            mainname.Text = "Judging System " & fversion
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdlogin.Enabled = False
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdlogin.Enabled = False
        End Try
    End Sub
     
    Public Sub clearlog()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        If txtusername.Text = "" Then
            MessageBox.Show("Username field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Password field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        cmdlogin.Text = "Checking your account.."
        cmdlogin.Enabled = False
        checklog()
    End Sub
    Public Sub checklog()
        Try
            ConnectVerify()
            conn = New MySqlConnection
            'com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' and ((select count(*) from tblpermissions where percode=tblaccounts.permission) > 0 or username='ADMIN') " : rst = com.ExecuteReader()
            com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "'" : rst = com.ExecuteReader()
            While rst.Read()
                If rst.GetSchemaTable.Rows.Count <> 0 Then
                    globallogin = True
                    globaluserid = rst("accountid").ToString
                Else
                    globallogin = False
                End If
            End While
            rst.Close()
            If globallogin = True Then
                LoadAccountDetails(globaluserid)
                set_login()
            ElseIf globallogin = False Then
                Me.Cursor = Cursors.Default
                cmdlogin.Text = "Confirm Login"
                cmdlogin.Enabled = True
                MessageBox.Show("Invalid given Username and Password..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpassword.Focus()
                txtpassword.Text = ""
                rst.Close()
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub set_login()
        Try
            Me.Cursor = Cursors.WaitCursor
            'UpdateEngine()
            com.CommandText = "insert into tbllogin set userid = '" & globaluserid & "',intime=current_timestamp" : com.ExecuteNonQuery()
            MainForm.Show()
            Me.Hide()
            Me.AcceptButton = Nothing
            txtusername.Text = "Username"
            txtpassword.Text = "password"
            txtusername.Focus()
            cmdlogin.Text = "Confirm Login"
            cmdlogin.Enabled = True
            Me.Cursor = Cursors.Default
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtusername_GotFocus(sender As Object, e As EventArgs) Handles txtusername.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.GotFocus
        Me.AcceptButton = cmdlogin
    End Sub

    Private Sub txtpassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.LostFocus
        If txtpassword.Text = "" Then
            Me.AcceptButton = Nothing
        End If
    End Sub
End Class
