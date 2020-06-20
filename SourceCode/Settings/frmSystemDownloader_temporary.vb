Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports System.Web

Public Class frmSystemDownloader_temporary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Request As System.Net.WebRequest
        Dim Response As System.Net.WebResponse
        Dim FileSize As Integer

        Request = Net.WebRequest.Create("http://katipunanbank.com/404.zip")
        Request.Method = Net.WebRequestMethods.Http.Get

        Response = Request.GetResponse

        FileSize = Response.ContentLength

        btnStartDownload.Text = FileSize
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles btnStartDownload.Click
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri("http://katipunanbank.com/404.zip"), "E:\404.zip")
        btnStartDownload.Text = "Download in Progress"
        btnStartDownload.Enabled = False
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        progressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        txtBytes.Text = "Downloaded " & Format(Val(bytesIn / 1024), "n") & "/" & Format(Val(totalBytes / 1024), "n") & " KB"
        txtPercent.Text = Int32.Parse(Math.Truncate(percentage).ToString()) & "% Downloading"
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        MessageBox.Show("Download Complete")
        btnStartDownload.Text = "Start Download"
        btnStartDownload.Enabled = True
    End Sub

End Class