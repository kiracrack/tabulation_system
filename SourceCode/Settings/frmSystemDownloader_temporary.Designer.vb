<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemDownloader_temporary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemDownloader_temporary))
        Me.txtBytes = New System.Windows.Forms.Label()
        Me.btnStartDownload = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.txtPercent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBytes
        '
        Me.txtBytes.BackColor = System.Drawing.Color.Transparent
        Me.txtBytes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBytes.ForeColor = System.Drawing.Color.Gray
        Me.txtBytes.Location = New System.Drawing.Point(9, 36)
        Me.txtBytes.Name = "txtBytes"
        Me.txtBytes.Size = New System.Drawing.Size(250, 15)
        Me.txtBytes.TabIndex = 334
        Me.txtBytes.Text = "Downloaded 0/0 KB"
        '
        'btnStartDownload
        '
        Me.btnStartDownload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStartDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStartDownload.Location = New System.Drawing.Point(68, 78)
        Me.btnStartDownload.Name = "btnStartDownload"
        Me.btnStartDownload.Size = New System.Drawing.Size(246, 30)
        Me.btnStartDownload.TabIndex = 345
        Me.btnStartDownload.Text = "Start Download"
        Me.btnStartDownload.UseVisualStyleBackColor = True
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 54)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(359, 21)
        Me.progressBar.Step = 1
        Me.progressBar.TabIndex = 346
        '
        'txtPercent
        '
        Me.txtPercent.BackColor = System.Drawing.Color.Transparent
        Me.txtPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPercent.ForeColor = System.Drawing.Color.Gray
        Me.txtPercent.Location = New System.Drawing.Point(241, 36)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(130, 15)
        Me.txtPercent.TabIndex = 347
        Me.txtPercent.Text = "0% Downloading"
        Me.txtPercent.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmSystemDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(381, 114)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.btnStartDownload)
        Me.Controls.Add(Me.txtBytes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSystemDownloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Update"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBytes As System.Windows.Forms.Label
    Friend WithEvents btnStartDownload As System.Windows.Forms.Button
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtPercent As System.Windows.Forms.Label
End Class
