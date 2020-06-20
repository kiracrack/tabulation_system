Imports System.IO

Module securityLevel
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public screenHeight As Integer
    Public screenWidth As Integer
    Public screenres As String
    Public globallogin As Boolean
    Public globaluserid As String

    Public globalfullname As String
    Public globalposition As String
    Public globaladdress As String
    Public globalcontact As String
    Public globalusername As String

    Public GlobalEventID As String
    Public GlobalEventName As String
    Public GlobalEventCategory As String
    Public GlobalEventTitle As String
    Public GlobalEventDate As Date
    Public GlobalEventOrganizer As String
    Public GlobalEventActivated As Boolean = False
    Public GlobalContestantType As String
    Public GlobalScoreType As String
    Public GlobalComputation As String
    Public GlobalSymbolInUse As String
    Public GlobalEnableDeduction As Boolean = False
    Public GlobalShowAverage As Boolean = False

    Public GlobalRankCode As String
    Public GlobalRankDescription As String
    Public GlobalActivatedCategory As Integer = 0

    Public globalofficecode As String
    Public globalofficeemail As String
    Public globalofficename As String
    Public globalregby As String
    Public globalpermissioncode As String
    Public globalSpecialpermission As Boolean

    Public compCompanyExist As Boolean
    Public compOfficeid As String
    Public compOfficerid As String
    Public compOfficename As String
    Public compEmailaddress As String
    Public compOfficerIncharge As String
    Public compOfficerPosition As String

    Public Sub check_win()
        screenHeight = My.Computer.Screen.Bounds.Height
        screenWidth = My.Computer.Screen.Bounds.Width
        screenres = "236," + screenHeight
    End Sub

    Public Function LoadAccountDetails(ByVal userid As String)
        com.CommandText = "select * from tblaccounts where accountid='" & userid & "'" : rst = com.ExecuteReader
        While rst.Read
            globalfullname = rst("fullname").ToString
            globalposition = StrConv(rst("designation").ToString, vbProperCase)
            globalusername = rst("username").ToString
            globalpermissioncode = rst("permission").ToString
        End While
        rst.Close()
        LoadEventInfo()
        LoadActivatedInfo()
        Return 0
    End Function

    Public Sub LoadEventInfo()
        com.CommandText = "select * from tblevent where activated=1" : rst = com.ExecuteReader
        While rst.Read
            GlobalEventID = rst("eventid").ToString
            GlobalEventName = rst("eventName").ToString
            GlobalEventCategory = rst("eventCategory").ToString
            GlobalEventTitle = rst("eventTitle").ToString
            GlobalEventDate = rst("eventDate").ToString
            GlobalEventOrganizer = rst("organizer").ToString
            GlobalEventActivated = rst("activated").ToString
            GlobalContestantType = rst("contestanttype").ToString
            GlobalScoreType = rst("scoretype").ToString
            GlobalComputation = rst("computation").ToString
            GlobalSymbolInUse = StrConv(rst("symbol").ToString, VbStrConv.ProperCase)
            GlobalEnableDeduction = rst("enablededuction")
            GlobalShowAverage = rst("enableAverageTotal")
        End While
        rst.Close()
    End Sub
    Public Sub LoadActivatedInfo()
        GlobalRankCode = ""
        com.CommandText = "select * from tblrankingcategory where eventid='" & GlobalEventID & "' and activated=1" : rst = com.ExecuteReader
        While rst.Read
            GlobalRankCode = rst("rankid").ToString
            GlobalRankDescription = rst("rankDescription").ToString
        End While
        rst.Close()

        If GlobalRankCode = "" Then
            GlobalRankCode = "DEFAULT"
        End If
        GlobalActivatedCategory = countqry("tblcriteriacategory", "eventid='" & GlobalEventID & "' and activated=1")
    End Sub
    Public Sub userexit()
        globallogin = False
        globalfullname = ""
        globalposition = ""
        globalusername = ""
        globalofficecode = ""
        globalofficeemail = ""
        globalofficename = ""
        conn.Close()
    End Sub
End Module

