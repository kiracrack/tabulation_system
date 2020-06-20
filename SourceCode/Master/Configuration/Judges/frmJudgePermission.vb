Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmJudgePermission
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub LoadEntries()
        listView1.View = View.Details
        listView1.LabelEdit = True
        listView1.AllowColumnReorder = True
        listView1.CheckBoxes = True
        listView1.FullRowSelect = True
        listView1.GridLines = True
        ListView1.Columns.Add("Category", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("id", -2, HorizontalAlignment.Left)

        com.CommandText = "select * from tblcriteriacategory where eventid='" & GlobalEventID & "'" : rst = com.ExecuteReader
        While rst.Read
            Dim item1 As New ListViewItem(rst("categoryDescription").ToString, 0)
            item1.Checked = False
            item1.SubItems.Add(rst("categoryid").ToString)
            ListView1.Items.AddRange(New ListViewItem() {item1})
        End While
        rst.Close()
        Me.Controls.Add(ListView1)
        ListView1.Columns(1).Width = 0

        com.CommandText = "select * from tbljudgecategory where eventid='" & GlobalEventID & "' and judgeid='" & judgeid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            For Each itm As ListViewItem In ListView1.Items
                If itm.SubItems(1).Text = rst("categoryid").ToString Then
                    itm.Checked = True
                End If
            Next
        End While
        rst.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckCheckall.CheckedChanged
        If ckCheckall.Checked = True Then
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = True
            Next
        Else
            For Each itm As ListViewItem In ListView1.Items
                itm.Checked = False
            Next
        End If
    End Sub

    Private Sub frmJudgePermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEntries()
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        com.CommandText = "delete from tbljudgecategory where eventid='" & GlobalEventID & "' and judgeid='" & judgeid.Text & "'" : com.ExecuteNonQuery()
        For Each itm As ListViewItem In ListView1.Items
            If itm.Checked Then
                com.CommandText = "insert into tbljudgecategory set eventid='" & GlobalEventID & "', judgeid='" & judgeid.Text & "', categoryid='" & itm.SubItems(1).Text & "'" : com.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("Judge permission successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class