Imports System.IO
Imports Shell32

Module FileExtractor
    Dim detailsFile As StreamWriter = Nothing
    'Public Function ExtractSpecificZipFile(ByVal UpdateFileName As String, ByVal version As String) As Boolean
    '    Dim Download_location As String = Application.StartupPath.ToString & "\UpdateVersion\" & UpdateFileName
    '    Dim Extract_location As String = System.IO.Path.GetTempPath() & "CoffeecupUpdate"
    '    Try
    '        If (System.IO.Directory.Exists(Extract_location)) Then
    '            My.Computer.FileSystem.DeleteDirectory(Extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
    '        End If

    '        Dim fileStreamIn As FileStream = New FileStream(Download_location, FileMode.Open, FileAccess.Read)
    '        Dim fileStreamOut As FileStream
    '        Dim zf As ZipFile = New ZipFile(fileStreamIn)
    '        Dim Size As Integer
    '        Dim buffer(409600) As Byte
    '        Dim Zentry As ZipEntry = zf.GetEntry()
    '        If (Zentry Is Nothing) Then
    '            MessageBox.Show(UpdateFileName & " not found in Archived", _
    '                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            rst.Close()
    '            Return False
    '            Exit Function
    '        End If

    '        Dim fstr As ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
    '        fstr = zf.GetInputStream(Zentry)

    '        If (Not System.IO.Directory.Exists(Extract_location)) Then
    '            System.IO.Directory.CreateDirectory(Extract_location)
    '        End If
    '        fileStreamOut = New FileStream(Extract_location + "\" + Path.GetFileName(rst("originalfilename").ToString), FileMode.Create, FileAccess.Write)

    '        Do
    '            Size = fstr.Read(buffer, 0, buffer.Length)
    '            fileStreamOut.Write(buffer, 0, Size)
    '        Loop While (Size > 0)

    '        fstr.Close()
    '        fileStreamOut.Close()
    '        fileStreamIn.Close()

    '        If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat") = True Then
    '            System.IO.File.Delete(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
    '        End If
    '        Dim xstring As String = ""
    '        detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat", True)
    '        xstring = "@echo off" & Environment.NewLine _
    '                + "color c" & Environment.NewLine _
    '                + "@echo Updating Coffeecup " & version & " in 5 seconds.." & Environment.NewLine _
    '                + "timeout 5" & Environment.NewLine _
    '                + "xcopy /s ""e:\404\*.*"" ""c:\test\"" /b/v/y/r/j" & Environment.NewLine _
    '                + "echo msgbox ""Your system successfully updated! To view update features, please login your account and goto menu > Update Features"" > %tmp%\tmp.vbs" & Environment.NewLine _
    '                + "cscript /nologo %tmp%\tmp.vbs" & Environment.NewLine _
    '                + "del %tmp%\tmp.vbs"
    '        detailsFile.WriteLine(xstring)
    '        detailsFile.Close()

    '        Process.Start(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
    '        End
    '        Return (True)
    '    Catch ex As Exception
    '        MessageBox.Show("Message:" & ex.Message & vbCrLf, _
    '                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        rst.Close()
    '        Return False
    '    End Try

    'End Function

    Public Function ExtractSpecificZipFile(ByVal UpdateFileName As String, ByVal version As String) As Boolean
        Dim Download_location As String = Application.StartupPath.ToString & "\UpdateVersion\" & UpdateFileName
        Dim Extract_location As String = System.IO.Path.GetTempPath() & "\CoffeecupUpdate"
        Try
            'If (System.IO.Directory.Exists(Extract_location)) Then
            '    My.Computer.FileSystem.DeleteDirectory(Extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'End If

            Dim unzip As New ICSharpCode.SharpZipLib.Zip.FastZip
            unzip.ExtractZip(Download_location, Extract_location, Nothing)

 
            If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat") = True Then
                System.IO.File.Delete(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
            End If
            Dim xstring As String = ""
            detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat", True)
            xstring = "@echo off" & Environment.NewLine _
                    + "color c" & Environment.NewLine _
                    + "@echo Updating Coffeecup Client v" & version & " in 5 seconds.." & Environment.NewLine _
                    + "timeout 5" & Environment.NewLine _
                    + "xcopy /s """ & Extract_location & "\*.*"" """ & Application.StartupPath.ToString & "\"" /b/v/y/r/j" & Environment.NewLine _
                    + "echo msgbox ""Your system successfully updated! To view update features, please login your account and goto menu > Update Features"" > %tmp%\tmp.vbs" & Environment.NewLine _
                    + "cscript /nologo %tmp%\tmp.vbs" & Environment.NewLine _
                    + "del %tmp%\tmp.vbs"
            detailsFile.WriteLine(xstring)
            detailsFile.Close()

            Process.Start(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
            End
            Return (True)
        Catch ex As Exception
            MessageBox.Show("Message:" & ex.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
            Return False
        End Try

    End Function
End Module
