<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataDownloader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataDownloader))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ls = New System.Windows.Forms.CheckedListBox()
        Me.ckCheckall = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(177, 205)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(198, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Download Data"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 9
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.FormattingEnabled = True
        Me.ls.Items.AddRange(New Object() {"User Accounts", "Request Type", "Stockout Type", "Billing and Payments", "Consumable Inventory", "CFFE Inventory", "Particular Request", "Online Request", "Received Request", "For Approval Request", "Approved Request", "Disapproved Request", "Incomming Request", "Received Particular", "Requested Particular", "Particular Item List", "Item Vendor/Supplier List", "Stockout Item and Summary", "Notifications"})
        Me.ls.Location = New System.Drawing.Point(15, 30)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(360, 169)
        Me.ls.TabIndex = 10
        '
        'ckCheckall
        '
        Me.ckCheckall.AutoSize = True
        Me.ckCheckall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckCheckall.ForeColor = System.Drawing.Color.Black
        Me.ckCheckall.Location = New System.Drawing.Point(18, 202)
        Me.ckCheckall.Name = "ckCheckall"
        Me.ckCheckall.Size = New System.Drawing.Size(72, 19)
        Me.ckCheckall.TabIndex = 291
        Me.ckCheckall.Text = "Select all"
        Me.ckCheckall.UseVisualStyleBackColor = True
        '
        'frmDataDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(388, 242)
        Me.Controls.Add(Me.ckCheckall)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDataDownloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Downloader"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ls As System.Windows.Forms.CheckedListBox
    Friend WithEvents ckCheckall As System.Windows.Forms.CheckBox
End Class
