Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmEventEntries

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F3) Then
            textsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEntries()
    End Sub
    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select eventid, eventName as 'Event Name',eventCategory as 'Category', eventTitle as 'Title', eventDate as 'Date of Event',organizer as 'Event Organizer',contestanttype as 'Contestant Type', scoretype as 'Score Type', Computation, symbol as 'Symbol in Use',activated from tblevent order by  eventDate asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"eventid", "activated"})
        GridColumnAlignment(Em, {"Date of Event", "Contestant Type", "Score Type", "Computation", "Symbol in Use"}, DataGridViewContentAlignment.MiddleCenter)

        For i = 0 To Em.RowCount - 1
            If Em.Rows(i).Cells("activated").Value = "1" Then
                Em.Rows(i).DefaultCellStyle.BackColor = Color.Green
                Em.Rows(i).DefaultCellStyle.ForeColor = Color.White
                Em.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End If
        Next
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' showInfo()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmEventInformation.Show(Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        frmEventInformation.txtEventID.Text = Em.Item("eventid", Em.CurrentRow.Index).Value()
        frmEventInformation.mode.Text = "edit"
        frmEventInformation.Show(Me)
    End Sub

    Private Sub ActivateEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateEventToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to activate selected event? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblevent set activated=0 " : com.ExecuteNonQuery()
            com.CommandText = "update tblevent set activated=1 where eventid='" & Em.Item("eventid", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            LoadEntries() : LoadEventInfo()
        End If
    End Sub
End Class