Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmContestantInformation
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
            txtBirthdate.Value = Now
            txtContestantId.Text = getGlobalTrnid("CS" & globaluserid)
            txtContestantNumber.text = Val(countqry("tblcontestant", "eventid = '" & GlobalEventID & "'")) + 1
        End If

    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblcontestant set contestantNumber='" & txtContestantNumber.Text & "', contestantName='" & rchar(txtFullname.Text) & "',representativePlace='" & rchar(txtRepresentativeOf.Text) & "', birthDate='" & txtBirthdate.Text & "', address='" & rchar(txtAddress.Text) & "', batchcode='" & batchcode.Text & "' where contestantid='" & txtContestantId.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcontestant set eventid='" & GlobalEventID & "',contestantid='" & txtContestantId.Text & "', contestantNumber='" & txtContestantNumber.Text & "', contestantName='" & rchar(txtFullname.Text) & "',representativePlace='" & rchar(txtRepresentativeOf.Text) & "', birthDate='" & txtBirthdate.Text & "', address='" & rchar(txtAddress.Text) & "', batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
        End If
        txtContestantId.Text = getGlobalTrnid("CS" & globaluserid)
        frmContestant.LoadEntries()
        txtContestantNumber.text = Val(countqry("tblcontestant", "eventid = '" & GlobalEventID & "'")) + 1
        txtFullname.Text = ""
        txtRepresentativeOf.Text = ""
        txtBirthdate.Value = Now
        txtAddress.Text = ""
        MessageBox.Show("Contestant Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtDateEvent_ValueChanged(sender As Object, e As EventArgs) Handles txtBirthdate.ValueChanged
        If mode.Text <> "edit" Then
            txtContestantId.Text = getGlobalTrnid("CS" & globaluserid)
        End If
    End Sub
    Public Sub ShowInfo()
        If txtContestantId.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcontestant where contestantid='" & txtContestantId.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtContestantNumber.text = rst("contestantNumber").ToString
            txtFullname.Text = rst("contestantName").ToString
            txtRepresentativeOf.Text = rst("representativePlace").ToString
            txtBirthdate.Value = rst("birthDate").ToString
            txtAddress.Text = rst("address").ToString
            batchcode.Text = rst("batchcode").ToString
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
 
   
End Class