<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptOverallResultLandscape
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptOverallResultLandscape))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txtEventName = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtEvenCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtEventTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtEventDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.categoryid = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtCopyright = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtContact = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtpurchasetype = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdetails = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtdatePrint = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sline1 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtJudge1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sline2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtJudge4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sline4 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtJudge3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudge2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sline3 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.txtJudgeTitle6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudgeTitle5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudgeTitle4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudgeTitle3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudgeTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudgeTitle1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudge6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.sline6 = New DevExpress.XtraReports.UI.XRLine()
        Me.sline5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJudge5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTabulator = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPreparedby = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txtbatch = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtEventName, Me.txtEvenCategory, Me.txtEventTitle, Me.txtEventDate, Me.XrPictureBox1})
        Me.TopMargin.HeightF = 176.25!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtEventName
        '
        Me.txtEventName.Font = New System.Drawing.Font("Myriad Pro Cond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.KeepTogether = True
        Me.txtEventName.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.5417!)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEventName.SizeF = New System.Drawing.SizeF(979.9981!, 20.0!)
        Me.txtEventName.StylePriority.UseFont = False
        Me.txtEventName.StylePriority.UseTextAlignment = False
        Me.txtEventName.Text = "DAHUNOG SA DIPOLOG"
        Me.txtEventName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'txtEvenCategory
        '
        Me.txtEvenCategory.Font = New System.Drawing.Font("Myriad Pro Cond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvenCategory.KeepTogether = True
        Me.txtEvenCategory.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 69.50003!)
        Me.txtEvenCategory.Name = "txtEvenCategory"
        Me.txtEvenCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEvenCategory.SizeF = New System.Drawing.SizeF(979.9999!, 31.87501!)
        Me.txtEvenCategory.StylePriority.UseFont = False
        Me.txtEvenCategory.StylePriority.UseTextAlignment = False
        Me.txtEvenCategory.Text = "Miss Teen Tourism Dipolog 2014"
        Me.txtEvenCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtEventTitle
        '
        Me.txtEventTitle.Font = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtEventTitle.KeepTogether = True
        Me.txtEventTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 101.375!)
        Me.txtEventTitle.Name = "txtEventTitle"
        Me.txtEventTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEventTitle.SizeF = New System.Drawing.SizeF(979.9999!, 35.87499!)
        Me.txtEventTitle.StylePriority.UseFont = False
        Me.txtEventTitle.StylePriority.UseTextAlignment = False
        Me.txtEventTitle.Text = "Coronation Night"
        Me.txtEventTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'txtEventDate
        '
        Me.txtEventDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventDate.KeepTogether = True
        Me.txtEventDate.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 137.2501!)
        Me.txtEventDate.Name = "txtEventDate"
        Me.txtEventDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEventDate.SizeF = New System.Drawing.SizeF(980.0!, 21.875!)
        Me.txtEventDate.StylePriority.UseFont = False
        Me.txtEventDate.StylePriority.UseTextAlignment = False
        Me.txtEventDate.Text = "December 13, 2014"
        Me.txtEventDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 20.5417!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(150.0!, 145.7083!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'categoryid
        '
        Me.categoryid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryid.LocationFloat = New DevExpress.Utils.PointFloat(764.5833!, 35.87497!)
        Me.categoryid.Name = "categoryid"
        Me.categoryid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.categoryid.SizeF = New System.Drawing.SizeF(60.7915!, 12.16667!)
        Me.categoryid.StylePriority.UseFont = False
        Me.categoryid.StylePriority.UseTextAlignment = False
        Me.categoryid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.categoryid.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.txtCopyright, Me.txtContact})
        Me.BottomMargin.HeightF = 91.04156!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 0.0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(244.2497!, 81.04155!)
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtCopyright.ForeColor = System.Drawing.Color.Gray
        Me.txtCopyright.LocationFloat = New DevExpress.Utils.PointFloat(271.25!, 4.0!)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCopyright.SizeF = New System.Drawing.SizeF(707.7499!, 15.625!)
        Me.txtCopyright.StylePriority.UseFont = False
        Me.txtCopyright.StylePriority.UseForeColor = False
        Me.txtCopyright.StylePriority.UseTextAlignment = False
        Me.txtCopyright.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Arial Narrow", 7.75!, System.Drawing.FontStyle.Italic)
        Me.txtContact.ForeColor = System.Drawing.Color.Gray
        Me.txtContact.LocationFloat = New DevExpress.Utils.PointFloat(271.25!, 19.62498!)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtContact.SizeF = New System.Drawing.SizeF(707.7499!, 15.625!)
        Me.txtContact.StylePriority.UseFont = False
        Me.txtContact.StylePriority.UseForeColor = False
        Me.txtContact.StylePriority.UseTextAlignment = False
        Me.txtContact.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtpurchasetype, Me.XrLabel2, Me.txtdetails, Me.txtdatePrint, Me.txtCategory, Me.XrLabel9, Me.categoryid, Me.txtbatch})
        Me.ReportHeader.HeightF = 126.8332!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtpurchasetype
        '
        Me.txtpurchasetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtpurchasetype.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 1.0!)
        Me.txtpurchasetype.Name = "txtpurchasetype"
        Me.txtpurchasetype.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtpurchasetype.SizeF = New System.Drawing.SizeF(425.7084!, 22.58333!)
        Me.txtpurchasetype.StylePriority.UseFont = False
        Me.txtpurchasetype.StylePriority.UseTextAlignment = False
        Me.txtpurchasetype.Text = "OFFICIAL RESULT"
        Me.txtpurchasetype.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 54.49998!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "DETAILS:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtdetails
        '
        Me.txtdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetails.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 54.49998!)
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdetails.SizeF = New System.Drawing.SizeF(584.8333!, 15.625!)
        Me.txtdetails.StylePriority.UseFont = False
        Me.txtdetails.StylePriority.UseTextAlignment = False
        Me.txtdetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtdatePrint
        '
        Me.txtdatePrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatePrint.LocationFloat = New DevExpress.Utils.PointFloat(725.4585!, 0.9999911!)
        Me.txtdatePrint.Name = "txtdatePrint"
        Me.txtdatePrint.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtdatePrint.SizeF = New System.Drawing.SizeF(254.5415!, 22.58334!)
        Me.txtdatePrint.StylePriority.UseFont = False
        Me.txtdatePrint.StylePriority.UseTextAlignment = False
        Me.txtdatePrint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.LocationFloat = New DevExpress.Utils.PointFloat(125.0418!, 35.87498!)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCategory.SizeF = New System.Drawing.SizeF(584.8333!, 15.625!)
        Me.txtCategory.StylePriority.UseFont = False
        Me.txtCategory.StylePriority.UseTextAlignment = False
        Me.txtCategory.Text = "SAMPLE TEXT"
        Me.txtCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(4.166794!, 35.87498!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(118.5!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "CATEGORY:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'sline1
        '
        Me.sline1.ForeColor = System.Drawing.Color.Gray
        Me.sline1.LocationFloat = New DevExpress.Utils.PointFloat(47.25011!, 159.6252!)
        Me.sline1.Name = "sline1"
        Me.sline1.SizeF = New System.Drawing.SizeF(225.4165!, 7.291672!)
        Me.sline1.StylePriority.UseForeColor = False
        Me.sline1.Visible = False
        '
        'txtJudge1
        '
        Me.txtJudge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge1.LocationFloat = New DevExpress.Utils.PointFloat(47.25011!, 169.0002!)
        Me.txtJudge1.Name = "txtJudge1"
        Me.txtJudge1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge1.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudge1.StylePriority.UseFont = False
        Me.txtJudge1.StylePriority.UseTextAlignment = False
        Me.txtJudge1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sline2
        '
        Me.sline2.ForeColor = System.Drawing.Color.Gray
        Me.sline2.LocationFloat = New DevExpress.Utils.PointFloat(381.5421!, 160.2033!)
        Me.sline2.Name = "sline2"
        Me.sline2.SizeF = New System.Drawing.SizeF(225.4161!, 7.291672!)
        Me.sline2.StylePriority.UseForeColor = False
        Me.sline2.Visible = False
        '
        'txtJudge4
        '
        Me.txtJudge4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge4.LocationFloat = New DevExpress.Utils.PointFloat(46.12533!, 247.5!)
        Me.txtJudge4.Name = "txtJudge4"
        Me.txtJudge4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge4.SizeF = New System.Drawing.SizeF(225.4169!, 15.62498!)
        Me.txtJudge4.StylePriority.UseFont = False
        Me.txtJudge4.StylePriority.UseTextAlignment = False
        Me.txtJudge4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sline4
        '
        Me.sline4.ForeColor = System.Drawing.Color.Gray
        Me.sline4.LocationFloat = New DevExpress.Utils.PointFloat(46.12533!, 240.2084!)
        Me.sline4.Name = "sline4"
        Me.sline4.SizeF = New System.Drawing.SizeF(225.4168!, 7.291672!)
        Me.sline4.StylePriority.UseForeColor = False
        Me.sline4.Visible = False
        '
        'txtJudge3
        '
        Me.txtJudge3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge3.LocationFloat = New DevExpress.Utils.PointFloat(704.8749!, 169.0002!)
        Me.txtJudge3.Name = "txtJudge3"
        Me.txtJudge3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge3.SizeF = New System.Drawing.SizeF(225.4167!, 15.625!)
        Me.txtJudge3.StylePriority.UseFont = False
        Me.txtJudge3.StylePriority.UseTextAlignment = False
        Me.txtJudge3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudge2
        '
        Me.txtJudge2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge2.LocationFloat = New DevExpress.Utils.PointFloat(381.543!, 169.0!)
        Me.txtJudge2.Name = "txtJudge2"
        Me.txtJudge2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge2.SizeF = New System.Drawing.SizeF(225.4162!, 15.625!)
        Me.txtJudge2.StylePriority.UseFont = False
        Me.txtJudge2.StylePriority.UseTextAlignment = False
        Me.txtJudge2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sline3
        '
        Me.sline3.ForeColor = System.Drawing.Color.Gray
        Me.sline3.LocationFloat = New DevExpress.Utils.PointFloat(704.8701!, 160.2037!)
        Me.sline3.Name = "sline3"
        Me.sline3.SizeF = New System.Drawing.SizeF(225.4165!, 7.291672!)
        Me.sline3.StylePriority.UseForeColor = False
        Me.sline3.Visible = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtJudgeTitle6, Me.txtJudgeTitle5, Me.txtJudgeTitle4, Me.txtJudgeTitle3, Me.txtJudgeTitle2, Me.txtJudgeTitle1, Me.txtJudge6, Me.sline6, Me.sline5, Me.XrLabel5, Me.sline4, Me.sline2, Me.txtJudge4, Me.txtJudge3, Me.sline1, Me.sline3, Me.txtJudge1, Me.txtJudge2, Me.txtJudge5, Me.XrLabel1, Me.txtTabulator, Me.txtPreparedby, Me.XrLabel4, Me.XrLine1, Me.XrLabel3, Me.XrLine2})
        Me.ReportFooter.HeightF = 283.9583!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtJudgeTitle6
        '
        Me.txtJudgeTitle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle6.LocationFloat = New DevExpress.Utils.PointFloat(704.8752!, 264.1202!)
        Me.txtJudgeTitle6.Name = "txtJudgeTitle6"
        Me.txtJudgeTitle6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle6.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle6.StylePriority.UseFont = False
        Me.txtJudgeTitle6.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudgeTitle5
        '
        Me.txtJudgeTitle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle5.LocationFloat = New DevExpress.Utils.PointFloat(381.5416!, 264.12!)
        Me.txtJudgeTitle5.Name = "txtJudgeTitle5"
        Me.txtJudgeTitle5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle5.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle5.StylePriority.UseFont = False
        Me.txtJudgeTitle5.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudgeTitle4
        '
        Me.txtJudgeTitle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle4.LocationFloat = New DevExpress.Utils.PointFloat(46.12533!, 263.125!)
        Me.txtJudgeTitle4.Name = "txtJudgeTitle4"
        Me.txtJudgeTitle4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle4.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle4.StylePriority.UseFont = False
        Me.txtJudgeTitle4.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudgeTitle3
        '
        Me.txtJudgeTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle3.LocationFloat = New DevExpress.Utils.PointFloat(704.87!, 185.6203!)
        Me.txtJudgeTitle3.Name = "txtJudgeTitle3"
        Me.txtJudgeTitle3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle3.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle3.StylePriority.UseFont = False
        Me.txtJudgeTitle3.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudgeTitle2
        '
        Me.txtJudgeTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle2.LocationFloat = New DevExpress.Utils.PointFloat(381.5416!, 184.6251!)
        Me.txtJudgeTitle2.Name = "txtJudgeTitle2"
        Me.txtJudgeTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle2.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle2.StylePriority.UseFont = False
        Me.txtJudgeTitle2.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudgeTitle1
        '
        Me.txtJudgeTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtJudgeTitle1.LocationFloat = New DevExpress.Utils.PointFloat(47.25011!, 184.6251!)
        Me.txtJudgeTitle1.Name = "txtJudgeTitle1"
        Me.txtJudgeTitle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudgeTitle1.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtJudgeTitle1.StylePriority.UseFont = False
        Me.txtJudgeTitle1.StylePriority.UseTextAlignment = False
        Me.txtJudgeTitle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtJudge6
        '
        Me.txtJudge6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge6.LocationFloat = New DevExpress.Utils.PointFloat(704.8749!, 248.4952!)
        Me.txtJudge6.Name = "txtJudge6"
        Me.txtJudge6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge6.SizeF = New System.Drawing.SizeF(225.4169!, 15.62498!)
        Me.txtJudge6.StylePriority.UseFont = False
        Me.txtJudge6.StylePriority.UseTextAlignment = False
        Me.txtJudge6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sline6
        '
        Me.sline6.ForeColor = System.Drawing.Color.Gray
        Me.sline6.LocationFloat = New DevExpress.Utils.PointFloat(704.8752!, 240.6203!)
        Me.sline6.Name = "sline6"
        Me.sline6.SizeF = New System.Drawing.SizeF(225.4168!, 7.291672!)
        Me.sline6.StylePriority.UseForeColor = False
        Me.sline6.Visible = False
        '
        'sline5
        '
        Me.sline5.ForeColor = System.Drawing.Color.Gray
        Me.sline5.LocationFloat = New DevExpress.Utils.PointFloat(381.5431!, 240.6201!)
        Me.sline5.Name = "sline5"
        Me.sline5.SizeF = New System.Drawing.SizeF(225.4168!, 7.291672!)
        Me.sline5.StylePriority.UseForeColor = False
        Me.sline5.Visible = False
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 102.125!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(606.9581!, 19.79167!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Judges Signature:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtJudge5
        '
        Me.txtJudge5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJudge5.LocationFloat = New DevExpress.Utils.PointFloat(381.543!, 248.495!)
        Me.txtJudge5.Name = "txtJudge5"
        Me.txtJudge5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJudge5.SizeF = New System.Drawing.SizeF(225.4169!, 15.62498!)
        Me.txtJudge5.StylePriority.UseFont = False
        Me.txtJudge5.StylePriority.UseTextAlignment = False
        Me.txtJudge5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Red
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(14.25011!, 25.16677!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(663.6667!, 50.8749!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "This result is generated through Coffeecup Judging and Tabulation System.  This r" & _
    "esult not be valid as an official result unless the judges signed thier name bel" & _
    "ow."
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTabulator
        '
        Me.txtTabulator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTabulator.LocationFloat = New DevExpress.Utils.PointFloat(744.5834!, 60.4167!)
        Me.txtTabulator.Name = "txtTabulator"
        Me.txtTabulator.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTabulator.SizeF = New System.Drawing.SizeF(225.4166!, 15.625!)
        Me.txtTabulator.StylePriority.UseFont = False
        Me.txtTabulator.StylePriority.UseTextAlignment = False
        Me.txtTabulator.Text = "TABULATOR"
        Me.txtTabulator.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtPreparedby
        '
        Me.txtPreparedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPreparedby.LocationFloat = New DevExpress.Utils.PointFloat(744.5834!, 44.79182!)
        Me.txtPreparedby.Name = "txtPreparedby"
        Me.txtPreparedby.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPreparedby.SizeF = New System.Drawing.SizeF(225.4166!, 15.62499!)
        Me.txtPreparedby.StylePriority.UseFont = False
        Me.txtPreparedby.StylePriority.UseTextAlignment = False
        Me.txtPreparedby.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(704.8749!, 6.87507!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(75.41669!, 15.625!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Prepared By:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.ForeColor = System.Drawing.Color.Gray
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(744.5834!, 39.50014!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(225.4165!, 7.291672!)
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Red
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 6.874992!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(87.91669!, 15.625!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "NOTE:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 84.00002!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(978.9999!, 5.125!)
        '
        'txtbatch
        '
        Me.txtbatch.Font = New System.Drawing.Font("Calibri", 17.25!, System.Drawing.FontStyle.Bold)
        Me.txtbatch.KeepTogether = True
        Me.txtbatch.LocationFloat = New DevExpress.Utils.PointFloat(113.2917!, 83.25!)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtbatch.SizeF = New System.Drawing.SizeF(729.0019!, 31.87501!)
        Me.txtbatch.StylePriority.UseFont = False
        Me.txtbatch.StylePriority.UseTextAlignment = False
        Me.txtbatch.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptOverallResultLandscape
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(63, 57, 176, 91)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtdetails As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtdatePrint As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sline4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents sline2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtJudge4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudge3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sline1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents sline3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtJudge2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudge1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtpurchasetype As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudge5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sline5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txtJudge6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sline6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTabulator As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtPreparedby As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents categoryid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJudgeTitle1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCopyright As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtContact As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtEventName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtEvenCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtEventTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtEventDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtbatch As DevExpress.XtraReports.UI.XRLabel
End Class
