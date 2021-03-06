﻿Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports DevExpress.XtraSplashScreen

Module reports
    Public openform As DevExpress.XtraEditors.XtraForm
    Public Function CheckBeforePrint(ByVal rpt As XtraReport, ByVal form As String)
        reportcount(form)
        com.CommandText = "select * from tblreportsetting where formname='" & form & "'" : rst = com.ExecuteReader
        While rst.Read
            rpt.Landscape = rst("landscape")
            If rst("paperkind").ToString = "Legal" Then
                rpt.PaperKind = PaperKind.Legal
            ElseIf rst("paperkind").ToString = "Short" Then
                rpt.PaperKind = PaperKind.Letter
            ElseIf rst("paperkind").ToString = "Wide For Export" Then
                rpt.PaperKind = PaperKind.A2
            Else
                rpt.PaperKind = PaperKind.Letter
            End If
        End While
        rst.Close()
    End Function
    Public Function CopyGridControl(ByVal grid As GridControl) As WinControlContainer
        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 0)
        winContainer.Size = New Size(100, 100)
        ' Set the grid as a wrapped object.
        winContainer.WinControl = grid
        Return winContainer
    End Function
   
    Public Function reportTitle(ByVal a As String)
        Dim rptitle As String = ""
        com.CommandText = "select * from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            rptitle = rst("title").ToString
        End While
        rst.Close()
        Return rptitle
    End Function
    Public Function reportcustomtext(ByVal a As String)
        Dim rpcustom As String = ""
        com.CommandText = "select * from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            rpcustom = rst("customtext").ToString
        End While
        rst.Close()
        Return rpcustom
    End Function

    Public Function reportcount(ByVal a As String)
        Dim cnt As String = 0
        com.CommandText = "select count(*) as cnt from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        If cnt = 0 Then
            com.CommandText = "insert into tblreportsetting set formname='" & a & "' "
            com.ExecuteNonQuery()
        End If
        Return 0
    End Function
    Public Sub TitleOrient(ByVal txtbox As DevExpress.XtraReports.UI.XRLabel, ByVal orient As String)
        If orient = "True" Then
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Else
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        End If
    End Sub

    Public Function getReportTemplateID()
        Dim strng = ""
        Try
            If CInt(countrecord("tblreporttemplate")) = 0 Then
                strng = "RPT100001"
            Else
                com.CommandText = "select rptid from tblreporttemplate order by right(rptid,6) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("rptid").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "RPT" & Val(sb.ToString) + 1
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return strng.ToString
    End Function
End Module
