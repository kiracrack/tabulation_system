Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Module library
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
    Public proFileImg As Boolean

    '----------------email variables ----------------
    Public SendTo(1) As String
    Public FileAttach(2) As String
    Public strSubject As String
    Public strMessage As String

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function
    Public Function Rowcount(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "SELECT count(*) as cnt from " & tbl : rst = com.ExecuteReader()
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
        rst = com.ExecuteReader
        While rst.Read
            cnt = Val(rst("cnt").ToString)
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function RemoveEmptyColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() <> String.Empty Then
                        visibility = True
                        Exit For
                    End If
                Next
                grdView.Columns(clm.Index).Visible = visibility
            End If
        Next
        Return grdView
    End Function
    Public Function CenterDashColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() = "-" Then
                        grdView.Columns(clm.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        grdView.Columns(clm.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Exit For
                    End If
                Next
            End If
        Next
        Return grdView
    End Function
    Public Function UpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal picbox As System.Windows.Forms.PictureBox)
        arrImage = Nothing
        Try
            If Not picbox.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            sql = "Update " & tbl & " set " & fld & " = @file where " & qry

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function ShowImage(ByVal fld As String, ByVal picbox As System.Windows.Forms.PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img
                proFileImg = True
            Else
                picbox.Image = Global.JudgingSystem.My.Resources.Resources.blankimg
                proFileImg = False
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function


    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function
    Public Function XGridColumnAlignment(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal column As Array, ByVal algn As DevExpress.Utils.HorzAlignment) As GridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            xgrid.Columns(valueArr).AppearanceCell.TextOptions.HAlignment = algn
            xgrid.Columns(valueArr).AppearanceHeader.TextOptions.HAlignment = algn
        Next
        Return xgrid
    End Function
    Public Function GridCurrencyColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n3"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Sub GridColumnChoosed(ByVal grdView As DataGridView, ByVal file_dir As String)
        If System.IO.File.Exists(Application.StartupPath & "\" & file_dir) = True Then
            Dim sr As StreamReader = File.OpenText(Application.StartupPath & "\" & file_dir)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0
                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        grdView.Columns(cnt).Visible = True
                    Else
                        grdView.Columns(cnt).Visible = False
                    End If
                    cnt = cnt + 1
                Next
                sr.Close()
            Catch errMS As Exception
                MessageBox.Show("Message: Invalid column choosed format! Please update your column" & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sr.Close()
            End Try
        End If
        '   RemoveEmptyColumns(grdView)
    End Sub
    Public Function LoadToComboBox(ByVal query As String, ByVal field As String, ByVal id As String, ByVal cb As Windows.Forms.ComboBox)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            cb.Items.Add(New ComboBoxItem(rst(field), rst(id)))
        End While
        rst.Close()
        Return 0
    End Function
    Public Function CC(ByVal m As String)
        Return Val(m.Replace(",", ""))
    End Function
    Public Function CheckSelectedRow(ByVal value As String) As Boolean
        Try
            If value = "" Then
                MessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckSelectedRow = False
            Else
                CheckSelectedRow = True
            End If
        Catch errMS As Exception
            MessageBox.Show("There is no item selected! make sure, the selection is on the list", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CheckSelectedRow = False
        End Try
    End Function

    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal addwhere As String, ByVal tbl As String)
        Dim def As String = ""
        Try
            If countrecord(tbl) = 0 Then
                def = ""
            Else
                com.CommandText = "select " & fqry & " from " & tbl & " " & addwhere : rst = com.ExecuteReader
                While rst.Read
                    def = rst(field).ToString
                End While
                rst.Close()
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return def
    End Function
    Public Function LoadXgrid(ByVal qry As String, ByVal tbl As String, ByVal Em As DevExpress.XtraGrid.GridControl, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            Dim dst = New DataSet : dst.Clear()
            xgrid.ClearGrouping()
            Em.DataSource = Nothing
            msda = New MySqlDataAdapter(qry, conn)
            msda.SelectCommand.CommandTimeout = 600000
            msda.Fill(dst, tbl)
            Em.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Em.ForceInitialize()
            xgrid.BestFitColumns()

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message: " & errMYSQL.Message & vbCrLf _
                             & "Details: " & errMYSQL.StackTrace & Environment.NewLine _
                             & "Error Code: " & errMYSQL.ErrorCode, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColCurrency(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try

            xgrid.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
            xgrid.Columns(i).DisplayFormat.FormatString = "n"

        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function XgridColAlign(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal algn As DevExpress.Utils.HorzAlignment)
        Try
            xgrid.Columns(i).AppearanceCell.TextOptions.HAlignment = algn
            xgrid.Columns(i).AppearanceHeader.TextOptions.HAlignment = algn
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function getSequenceno(ByVal code As String, ByVal table As String, ByVal query As String, ByVal character As String, ByVal length As Integer, ByVal startnumber As Integer)
        getSequenceno = ""
        If countqry(table, query) > 0 Then
            com.CommandText = "select right(" & code & "," & length & ") as cnt from " & table & " where " & query & " order by " & code & " desc limit 1 " : rst = com.ExecuteReader()
            While rst.Read
                getSequenceno = character & Val(rst("cnt")) + 1
            End While
            rst.Close()
        Else
            getSequenceno = character & startnumber
        End If
        Return getSequenceno
    End Function
End Module
