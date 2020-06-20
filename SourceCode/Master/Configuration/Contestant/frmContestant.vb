Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmContestant
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmEventEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToComboBox("select * from tblbatch where eventid='" & GlobalEventID & "'", "batchname", "batchcode", txtBatch)
    End Sub

    Private Sub txtBatch_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBatch.SelectedValueChanged
        If txtBatch.Text <> "" Then
            batchcode.Text = DirectCast(txtBatch.SelectedItem, ComboBoxItem).HiddenValue()
            LoadEntries()
        End If
    End Sub
    Public Sub LoadEntries()
        Em.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select contestantid, contestantNumber as 'No.', contestantName as 'Contestants',format(PERIOD_DIFF(date_format(current_date,'%Y%m'),date_format(birthDate,'%Y%m'))/12,0) as 'Age', representativePlace as 'Representative of', Address,Batchcode as 'Batch'  from tblcontestant where eventid='" & GlobalEventID & "' and batchcode='" & batchcode.Text & "' order by  contestantNumber asc", conn)
        msda.Fill(dst, 0)
        Em.DataSource = dst.Tables(0)
        GridHideColumn(Em, {"contestantid"})
        GridColumnAlignment(Em, {"No.", "Age"}, DataGridViewContentAlignment.MiddleCenter)
        Em.Columns("No.").Width = 40
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        LoadEntries()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmContestantInformation.txtContestantId.Text = Em.Item("contestantid", Em.CurrentRow.Index).Value()
        frmContestantInformation.mode.Text = "edit"
        frmContestantInformation.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If txtBatch.Text = "" Then
            MsgBox("Please select group batch", MsgBoxStyle.Exclamation)
            txtBatch.Focus()
            Exit Sub
        End If
        frmContestantInformation.batchcode.Text = batchcode.text
        frmContestantInformation.Show(Me)
    End Sub

    Private Sub DeleteJudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJudgeToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue delete this item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tblcontestant where contestantid='" & Em.Item("contestantid", Em.CurrentRow.Index).Value() & "'" : com.ExecuteNonQuery()
            LoadEntries()
            MsgBox("Contestant successfuly deleted", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmGroupBatch.Show(Me)
    End Sub
 
     

End Class