Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.IO

Module ConectionSetup
    Public provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public li As String = Environment.NewLine
    Public Em As DataGridView
    Public GlobalOrganizationName As String = "Katipunan Bank Inc."

    Public GlobalEnableEmailNotification As Boolean
    Public GlobalSmtpHost As String
    Public GlobalServerMail As String
    Public GlobalServerPassword As String
    Public FileProperties As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public fversion As String = FileProperties.FileVersion.ToString.Remove(FileProperties.FileVersion.ToString.Length - 2, 2)
    Public dversion As Date = Date.ParseExact(fversion, "yy.M.d", provider)
    Public GlobalApplicationName As String = "Coffeecup Client"
    Public Globalcopyright As String = "Copyright © " & Now.ToString("yyyy") & " Coffeecup Judging and Tabulation System by Winter s. Bugahod"
    Public GlobalContactDeveloper As String = "Email: winterbugahod@yahoo.com - http://facebook.com/kiracrack"
    Public Globallogo As Image

    Public formclose As Boolean
    Public conn As New MySqlConnection
    Public msda As MySqlDataAdapter
    Public dst As New DataSet
    Public com As New MySqlCommand
    Public rst As MySqlDataReader
    Public file_downloaded As String = Application.StartupPath.ToString & "\UpdateVersion\"
    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"
    Public file_name As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".setup"
    Public file_users As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".users"
    Public file_requesttype As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".rtype"
    Public file_stockouttype As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stype"

    Public file_inventory_payments As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".payments.xml"
    Public file_inventory_consumables As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".consumables.xml"
    Public file_inventory_bffe As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".bffe.xml"

    Public file_request_particular As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_particular.xml"
    Public file_request_online As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_online.xml"
    Public file_request_received As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_received.xml"
    Public file_request_pending As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_pending.xml"
    Public file_request_approved As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_approved.xml"
    Public file_request_cancelled As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_cancelled.xml"
    Public file_request_incoming_transfer As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_incoming.xml"

    Public file_particular_received As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_received.xml"
    Public file_particular_requested As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_requested.xml"

    Public file_global_items As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_item.xml"
    Public file_global_itemvendors As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_itemvendors.xml"
    Public file_global_vendors As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".vendors.xml"

    Public file_stockouts_current As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_current.xml"
    Public file_stockouts_items As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_items.xml"
    Public file_stockouts_summary As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_summary.xml"

    Public file_download As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".download"
    Public file_notifications As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".notifications.xml"

    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String

    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader
    Public ConnectedServer As Boolean = False

    Public clientserver As String
    Public clientport As String
    Public clientuser As String
    Public clientpass As String
    Public clientdatabase As String

    Public Sub ConnectVerify()
        conn.Close()
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlserver = word
            ElseIf cnt = 1 Then
                sqlport = word
            ElseIf cnt = 2 Then
                sqluser = word
            ElseIf cnt = 3 Then
                sqlpass = word
            ElseIf cnt = 4 Then
                sqldatabase = word
            End If
            cnt = cnt + 1
        Next

        conn = New MySql.Data.MySqlClient.MySqlConnection
        conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
        conn.Open()
        com.Connection = conn
        com.CommandTimeout = 6000000
    End Sub

    Public Function OpenClientServer() As Boolean
        Try
            connclient = New MySql.Data.MySqlClient.MySqlConnection
            connclient.ConnectionString = "server=" & clientserver & "; Port=" & clientport & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=10; allow user variables=true"
            connclient.Open()
            comclient.Connection = connclient
            comclient.CommandTimeout = 0
            OpenClientServer = True

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        End Try
    End Function

    Public Class ComboBoxItem
        Private displayValue As String
        Private m_hiddenValue As String

        Public Sub New(ByVal d As String, ByVal h As String)
            displayValue = d
            m_hiddenValue = h
        End Sub

        Public ReadOnly Property HiddenValue() As String
            Get
                Return m_hiddenValue
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return displayValue
        End Function
    End Class

    Public Function getGlobalTrnid(ByVal init As String)
        Dim finalstr As String = Now.ToString("yyyyMMddhh-mmss")

        finalstr = init & "-" & finalstr
        Return finalstr
    End Function
    Public Function getEventId(ByVal init As String, ByVal dateEvent As String)
        Dim strs As String = ""
        Dim finalstr As String = ""

        com.CommandText = "select date_format(current_timestamp,'%i%s') as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
        End While
        rst.Close()
        finalstr = init & "-" & dateEvent.Replace("-", "") & "-" & strs
        Return finalstr
    End Function

     
    Public Function SendEmailMessage(ByVal strFrom As String, ByVal strTo() _
     As String, ByVal strSubject _
     As String, ByVal strMessage _
     As String, ByVal fileList() As String) As Boolean
        Dim Host As String = GlobalSmtpHost
        Dim Port As Int16 = 587
        Dim SSL As Boolean = False
        'This procedure takes string array parameters for multiple recipients and files
        Try
            For Each item As String In strTo
                If item <> "" Then
                    'For each to address create a mail message
                    Dim MailMsg As New MailMessage(strFrom.Trim(), item, strSubject.Trim(), strMessage.Trim() & vbCrLf)
                    MailMsg.BodyEncoding = Encoding.Default
                    MailMsg.IsBodyHtml = True

                    'attach each file attachment
                    For Each strfile As String In fileList
                        If Not strfile = "" Then
                            Dim MsgAttach As New Attachment(strfile)
                            MailMsg.Attachments.Add(MsgAttach)
                        End If
                    Next

                    'Smtpclient to send the mail message
                    Dim sc As New SmtpClient(Host, Port)
                    Dim netCred As New NetworkCredential(GlobalServerMail, GlobalServerPassword)
                    sc.EnableSsl = SSL
                    sc.Timeout = Int32.MaxValue
                    sc.UseDefaultCredentials = False
                    sc.Credentials = netCred
                    Try
                        sc.Send(MailMsg)
                        Return True
                    Catch ex As Exception
                        MessageBox.Show("Error: {0}" & ex.Message(), GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End Try
                End If

            Next
            'Message Successful
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function DepreciationReduce(ByVal unitcost As Double, ByVal age As Double, ByVal rate As Double) As Double
        DepreciationReduce = unitcost
        For I = 0 To age - 1
            Dim year1depn = DepreciationReduce * (rate / 100)
            DepreciationReduce = DepreciationReduce - year1depn
        Next
        Return DepreciationReduce
    End Function

    Public Function DepreciationStraight(ByVal unitcost As Double, ByVal age As Double, ByVal NumberOfYears As Double) As Double
        Dim value As Double = 0 : Dim bookValue As Double = 0
        If NumberOfYears > 0 Then
            Dim devidedRate = unitcost / NumberOfYears
            DepreciationStraight = 0
            Dim asMonth As Double = age / 12
            For I = 0 To asMonth - 1
                DepreciationStraight = DepreciationStraight + devidedRate
            Next
            value = unitcost - DepreciationStraight
            If value > 0 Then
                bookValue = value
            Else
                bookValue = 1
            End If
        Else
            bookValue = 1
        End If
        Return bookValue
    End Function
End Module
