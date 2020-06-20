Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmDataDownloader
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        For i = 0 To ls.CheckedItems.Count - 1
            If ls.CheckedItems(i).ToString = "User Accounts" Then
                SynchuserAccounts()
            End If
            If ls.CheckedItems(i).ToString = "Request Type" Then
                SynchRequestType()
            End If
            If ls.CheckedItems(i).ToString = "Stockout Type" Then
                SynchStockoutType()
            End If

            If ls.CheckedItems(i).ToString = "Billing and Payments" Then
                SynchBillingAndPayments()
            End If
            If ls.CheckedItems(i).ToString = "Consumable Inventory" Then
                SynchConsumableInventory()
            End If

            If ls.CheckedItems(i).ToString = "CFFE Inventory" Then
                SynchCFFEInventory()
            End If
            If ls.CheckedItems(i).ToString = "Particular Request" Then
                SynchRequestParticular()
            End If

            If ls.CheckedItems(i).ToString = "Online Request" Then
                SynchRequestOnline()
            End If

            If ls.CheckedItems(i).ToString = "Received Request" Then
                SynchRequestReceived()
            End If

            If ls.CheckedItems(i).ToString = "For Approval Request" Then
                SynchRequestforApproval()
            End If

            If ls.CheckedItems(i).ToString = "Approved Request" Then
                SynchRequestApproved()
            End If
            If ls.CheckedItems(i).ToString = "Disapproved Request" Then
                SynchRequestDisapproved()
            End If

            If ls.CheckedItems(i).ToString = "Incomming Request" Then
                SynchIncomingTransferRequest()
            End If

            If ls.CheckedItems(i).ToString = "Received Particular" Then
                SynchParticularReceived()
            End If

            If ls.CheckedItems(i).ToString = "Requested Particular" Then
                SynchParticularRequested()
            End If

            If ls.CheckedItems(i).ToString = "Particular Item List" Then
                SynchGlobalProducts()
            End If

            If ls.CheckedItems(i).ToString = "Item Vendor/Supplier List" Then
                SynchGlobalitemvendors()
            End If

            If ls.CheckedItems(i).ToString = "Stockout Item and Summary" Then
                SynchStockouts()
            End If
            If ls.CheckedItems(i).ToString = "Notifications" Then
                SynchNotifications()
            End If
        Next
        If System.IO.File.Exists(Application.StartupPath & "\" & file_download) = True Then
            System.IO.File.Delete(Application.StartupPath & "\" & file_download)
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_download, True)
        detailsFile.WriteLine(EncryptTripleDES(Now.ToString("MMMM dd, yyyy hh:mm:ss tt")))
        detailsFile.Close()
        loadStatus()
        MessageBox.Show("Engine successfully updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ck_Landscape_CheckedChanged(sender As Object, e As EventArgs) Handles ckCheckall.CheckedChanged
        If ckCheckall.Checked = True Then
            For i = 0 To ls.Items.Count - 1
                ls.SetItemCheckState(i, CheckState.Checked)
            Next
        Else
            For i = 0 To ls.Items.Count - 1
                ls.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If

    End Sub

    Private Sub frmDataDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStatus()
    End Sub
    Public Sub loadStatus()
        If System.IO.File.Exists(file_download) = True Then
            System.IO.File.Delete(file_download)
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(file_download, True)
        detailsFile.WriteLine(EncryptTripleDES(Now.ToString("MMMM dd, yyyy hh:mm:ss tt")))
        detailsFile.Close()

        Dim sr As StreamReader = File.OpenText(file_download)
        Dim br As String = sr.ReadLine() : sr.Close()
        lblStatus.Text = "Last download update " & DecryptTripleDES(br)
    End Sub
End Class