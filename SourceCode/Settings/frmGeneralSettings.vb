Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmGeneralSettings
  
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtGlobalOrgname.Text = qrysingledata("companyname", "companyname", "tblcompanysettings")
        LoadOffices()
        LoadEmailSettings()

        If System.IO.File.Exists(Application.StartupPath & "\" & FILE_NAME) = False Then
            compCompanyExist = False
        Else
            compCompanyExist = True
            Dim strSetup As String = ""
            Dim sr As StreamReader = File.OpenText(file_name)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {"|"c})
                If cnt = 0 Then
                    officeid.Text = word
                ElseIf cnt = 1 Then
                    officerid.Text = word
                ElseIf cnt = 2 Then
                    txtoffice.Text = word
                ElseIf cnt = 3 Then
                    txtemailaddress.Text = word
                ElseIf cnt = 4 Then
                    txtofficerinchange.Text = word
                ElseIf cnt = 5 Then
                    txtPosition.Text = word
                ElseIf cnt = 7 Then
                    ckEnableEmailNotification.Checked = word
                End If
                cnt = cnt + 1
            Next
            If LCase(globalusername) = "admin" Then
                txtoffice.Enabled = True
            Else
                txtoffice.Enabled = False
            End If
        End If

    End Sub
    Public Sub LoadEmailSettings()
        com.CommandText = "select * from tblgeneralsettings"
        rst = com.ExecuteReader
        While rst.Read
            ckEnableEmailNotification.Checked = rst("enableemailnotification")
            txtSmtpHost.Text = rst("smtphost").ToString
            txtServerEmail.Text = rst("serveremailaddress").ToString
            txtServerPassword.Text = DecryptTripleDES(rst("serverpassword").ToString)
        End While
        rst.Close()
    End Sub
    Public Sub LoadOffices()
        com.CommandText = "select officeid,officename from tblcompoffice order by officename asc" : rst = com.ExecuteReader()
        txtoffice.Items.Clear()
        While rst.Read()
            txtoffice.Items.Add(New ComboBoxItem(rst("officename"), rst("officeid")))
        End While
        rst.Close()
    End Sub
    Private Sub txtArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoffice.SelectedIndexChanged
        If txtoffice.Text <> "" Then
            officeid.Text = DirectCast(txtoffice.SelectedItem, ComboBoxItem).HiddenValue()
            ShowOfficeinfo()
        Else
            officeid.Text = ""
        End If
    End Sub
    Public Sub ShowOfficeinfo()
        com.CommandText = "select *,(select fullname from tblaccounts where accountid = tblcompoffice.officerid) as 'incharge', " _
                            + " (select designation from tblaccounts where accountid = tblcompoffice.officerid) as 'position' from tblcompoffice where officeid='" & officeid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            officerid.Text = rst("officerid").ToString
            txtoffice.Text = rst("officename").ToString
            txtemailaddress.Text = rst("officeemail").ToString
            txtofficerinchange.Text = rst("incharge").ToString
            txtPosition.Text = rst("position").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtoffice.Text = "" Then
            MessageBox.Show("Please select office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtoffice.Focus()
            Exit Sub
        ElseIf txtemailaddress.Text = "" Then
            MessageBox.Show("Please contact procurement officer to set your office email!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtemailaddress.Focus()
            Exit Sub
        ElseIf txtofficerinchange.Text = "" Then
            MessageBox.Show("Please contact procurement officer to set your officer incharge!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtofficerinchange.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please contact procurement officer to set your officer incharge position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        End If
        If ckEnableEmailNotification.Checked = True Then
            If txtSmtpHost.Text = "" Then
                MessageBox.Show("Please enter SMTP host", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSmtpHost.Focus()
                Exit Sub
            ElseIf txtServerEmail.Text = "" Then
                MessageBox.Show("Please enter server email address", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtServerEmail.Focus()
                Exit Sub
            ElseIf txtServerPassword.Text = "" Then
                MessageBox.Show("Please enter server password", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtServerPassword.Focus()
                Exit Sub
            End If
        End If
        If System.IO.File.Exists(file_name) = True Then
            System.IO.File.Delete(file_name)
        End If

        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_name, True)
        detailsFile.WriteLine(EncryptTripleDES(officeid.Text & "|" & officerid.Text & "|" & txtoffice.Text & "|" & txtemailaddress.Text & "|" & txtofficerinchange.Text & "|" & txtPosition.Text & "|" & txtGlobalOrgname.Text & "|" & ckEnableEmailNotification.CheckState & "|" & txtSmtpHost.Text & "|" & txtServerEmail.Text & "|" & txtServerPassword.Text))
        detailsFile.Close()
        MessageBox.Show("Settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class