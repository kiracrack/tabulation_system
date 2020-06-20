Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmEventInformation
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
            txtDateEvent.Value = Now
            txtEventID.Text = getEventId("E" & globaluserid, txtDateEvent.Text)
        End If
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If mode.Text = "edit" Then
            com.CommandText = "update tblevent set eventName='" & rchar(txtEventName.Text) & "', eventCategory='" & rchar(txtEventCategory.Text) & "',eventTitle='" & rchar(txtEventTitle.Text) & "', eventDate='" & txtDateEvent.Text & "', organizer='" & rchar(txtEventOrganizer.Text) & "', contestanttype='" & rchar(txtContestantType.Text) & "', scoretype='" & txtScoretype.Text & "', computation='" & txtComputation.Text & "', symbol='" & txtSymbolInUse.Text & "',enablededuction=" & ckEnableDeduction.CheckState & ", enableaveragetotal = " & ckEnableAverageTotal.CheckState & " where eventid='" & txtEventID.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblevent set eventid='" & txtEventID.Text & "', eventName='" & rchar(txtEventName.Text) & "', eventCategory='" & rchar(txtEventCategory.Text) & "',eventTitle='" & rchar(txtEventTitle.Text) & "', eventDate='" & txtDateEvent.Text & "', organizer='" & rchar(txtEventOrganizer.Text) & "', contestanttype='" & rchar(txtContestantType.Text) & "', scoretype='" & txtScoretype.Text & "', computation='" & txtComputation.Text & "', symbol='" & txtSymbolInUse.Text & "',enablededuction=" & ckEnableDeduction.CheckState & ", enableaveragetotal = " & ckEnableAverageTotal.CheckState & "" : com.ExecuteNonQuery()
        End If
        LoadEventInfo()
        frmEventEntries.LoadEntries()
        MessageBox.Show("Event Successfully Saved", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtDateEvent_ValueChanged(sender As Object, e As EventArgs) Handles txtDateEvent.ValueChanged
        If mode.Text <> "edit" Then
            txtEventID.Text = getEventId("E" & globaluserid, txtDateEvent.Text)
        End If
    End Sub
    Public Sub ShowInfo()
        If txtEventID.Text = "" Then Exit Sub
        com.CommandText = "select * from tblevent where eventid='" & txtEventID.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtEventName.Text = rst("eventName").ToString
            txtEventCategory.Text = rst("eventCategory").ToString
            txtEventTitle.Text = rst("eventTitle").ToString
            txtDateEvent.Value = rst("eventDate").ToString
            txtEventOrganizer.Text = rst("organizer").ToString
            txtContestantType.Text = rst("contestanttype").ToString
            txtScoretype.Text = rst("scoretype").ToString
            txtComputation.Text = rst("computation").ToString
            txtSymbolInUse.Text = rst("symbol").ToString
            ckEnableDeduction.Checked = rst("enablededuction")
            ckEnableAverageTotal.Checked = rst("enableaveragetotal")
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class