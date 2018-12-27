Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadMail
        Inherits frmSafetracBase

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        Private mainMenu1 As System.Windows.Forms.MainMenu

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.fraMain = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblFinalTitle = New System.Windows.Forms.Label
            Me.lblPiecesTitle = New System.Windows.Forms.Label
            Me.lblWeightTitle = New System.Windows.Forms.Label
            Me.lblScan = New System.Windows.Forms.Label
            Me.txtPieces = New System.Windows.Forms.TextBox
            Me.txtWeight = New System.Windows.Forms.TextBox
            Me.txtFNL = New System.Windows.Forms.TextBox
            Me.txtMailBarcode = New System.Windows.Forms.TextBox
            Me.lblBarcodeTitle = New System.Windows.Forms.Label
            Me.fraEnteredParms = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblTypeTitle = New System.Windows.Forms.Label
            Me.lblDateTitle = New System.Windows.Forms.Label
            Me.lblDestTitle = New System.Windows.Forms.Label
            Me.lblBinBulkTitle = New System.Windows.Forms.Label
            Me.lblFlghtTitle = New System.Windows.Forms.Label
            Me.lblType = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblBinBulk = New System.Windows.Forms.Label
            Me.lblCurrFlight = New System.Windows.Forms.Label
            Me.fraMain.SuspendLayout()
            Me.fraEnteredParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraMain
            '
            Me.fraMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraMain.Controls.Add(Me.lblFinalTitle)
            Me.fraMain.Controls.Add(Me.lblPiecesTitle)
            Me.fraMain.Controls.Add(Me.lblWeightTitle)
            Me.fraMain.Controls.Add(Me.lblScan)
            Me.fraMain.Controls.Add(Me.txtPieces)
            Me.fraMain.Controls.Add(Me.txtWeight)
            Me.fraMain.Controls.Add(Me.txtFNL)
            Me.fraMain.Controls.Add(Me.txtMailBarcode)
            Me.fraMain.Controls.Add(Me.lblBarcodeTitle)
            Me.fraMain.Location = New System.Drawing.Point(4, 40)
            Me.fraMain.Name = "fraMain"
            Me.fraMain.Size = New System.Drawing.Size(233, 129)
            '
            'lblFinalTitle
            '
            Me.lblFinalTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFinalTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFinalTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFinalTitle.Location = New System.Drawing.Point(160, 80)
            Me.lblFinalTitle.Name = "lblFinalTitle"
            Me.lblFinalTitle.Size = New System.Drawing.Size(65, 17)
            Me.lblFinalTitle.Text = "FNL"
            Me.lblFinalTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPiecesTitle
            '
            Me.lblPiecesTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPiecesTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPiecesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPiecesTitle.Location = New System.Drawing.Point(8, 79)
            Me.lblPiecesTitle.Name = "lblPiecesTitle"
            Me.lblPiecesTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblPiecesTitle.Text = "Pieces"
            Me.lblPiecesTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblWeightTitle
            '
            Me.lblWeightTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWeightTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblWeightTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWeightTitle.Location = New System.Drawing.Point(71, 79)
            Me.lblWeightTitle.Name = "lblWeightTitle"
            Me.lblWeightTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblWeightTitle.Text = "Weight"
            Me.lblWeightTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblScan
            '
            Me.lblScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScan.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblScan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScan.Location = New System.Drawing.Point(0, 1)
            Me.lblScan.Name = "lblScan"
            Me.lblScan.Size = New System.Drawing.Size(233, 25)
            Me.lblScan.Text = "Scan/Key Mail"
            Me.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtPieces
            '
            Me.txtPieces.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtPieces.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtPieces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtPieces.Location = New System.Drawing.Point(8, 96)
            Me.txtPieces.MaxLength = 3
            Me.txtPieces.Name = "txtPieces"
            Me.txtPieces.Size = New System.Drawing.Size(57, 26)
            Me.txtPieces.TabIndex = 1
            Me.txtPieces.Text = "1"
            '
            'txtWeight
            '
            Me.txtWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtWeight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtWeight.Location = New System.Drawing.Point(71, 96)
            Me.txtWeight.MaxLength = 4
            Me.txtWeight.Name = "txtWeight"
            Me.txtWeight.Size = New System.Drawing.Size(81, 26)
            Me.txtWeight.TabIndex = 2
            '
            'txtFNL
            '
            Me.txtFNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFNL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFNL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFNL.Location = New System.Drawing.Point(160, 96)
            Me.txtFNL.MaxLength = 3
            Me.txtFNL.Name = "txtFNL"
            Me.txtFNL.Size = New System.Drawing.Size(65, 26)
            Me.txtFNL.TabIndex = 3
            '
            'txtMailBarcode
            '
            Me.txtMailBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtMailBarcode.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtMailBarcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtMailBarcode.Location = New System.Drawing.Point(8, 44)
            Me.txtMailBarcode.Name = "txtMailBarcode"
            Me.txtMailBarcode.Size = New System.Drawing.Size(217, 32)
            Me.txtMailBarcode.TabIndex = 0
            '
            'lblBarcodeTitle
            '
            Me.lblBarcodeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBarcodeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblBarcodeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBarcodeTitle.Location = New System.Drawing.Point(8, 31)
            Me.lblBarcodeTitle.Name = "lblBarcodeTitle"
            Me.lblBarcodeTitle.Size = New System.Drawing.Size(217, 19)
            Me.lblBarcodeTitle.Text = "Barcode"
            Me.lblBarcodeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraEnteredParms
            '
            Me.fraEnteredParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraEnteredParms.Controls.Add(Me.lblTypeTitle)
            Me.fraEnteredParms.Controls.Add(Me.lblDateTitle)
            Me.fraEnteredParms.Controls.Add(Me.lblDestTitle)
            Me.fraEnteredParms.Controls.Add(Me.lblBinBulkTitle)
            Me.fraEnteredParms.Controls.Add(Me.lblFlghtTitle)
            Me.fraEnteredParms.Controls.Add(Me.lblType)
            Me.fraEnteredParms.Controls.Add(Me.lblDate)
            Me.fraEnteredParms.Controls.Add(Me.lblDest)
            Me.fraEnteredParms.Controls.Add(Me.lblFlight)
            Me.fraEnteredParms.Controls.Add(Me.lblBinBulk)
            Me.fraEnteredParms.Controls.Add(Me.lblCurrFlight)
            Me.fraEnteredParms.Location = New System.Drawing.Point(5, 170)
            Me.fraEnteredParms.Name = "fraEnteredParms"
            Me.fraEnteredParms.Size = New System.Drawing.Size(233, 108)
            '
            'lblTypeTitle
            '
            Me.lblTypeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTypeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTypeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTypeTitle.Location = New System.Drawing.Point(8, 64)
            Me.lblTypeTitle.Name = "lblTypeTitle"
            Me.lblTypeTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblTypeTitle.Text = "Type"
            Me.lblTypeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDateTitle
            '
            Me.lblDateTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDateTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDateTitle.Location = New System.Drawing.Point(80, 64)
            Me.lblDateTitle.Name = "lblDateTitle"
            Me.lblDateTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblDateTitle.Text = "Date"
            Me.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDestTitle
            '
            Me.lblDestTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDestTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDestTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDestTitle.Location = New System.Drawing.Point(160, 64)
            Me.lblDestTitle.Name = "lblDestTitle"
            Me.lblDestTitle.Size = New System.Drawing.Size(65, 17)
            Me.lblDestTitle.Text = "Dest"
            Me.lblDestTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBinBulkTitle
            '
            Me.lblBinBulkTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulkTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulkTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulkTitle.Location = New System.Drawing.Point(8, 24)
            Me.lblBinBulkTitle.Name = "lblBinBulkTitle"
            Me.lblBinBulkTitle.Size = New System.Drawing.Size(121, 17)
            Me.lblBinBulkTitle.Text = "Bin"
            Me.lblBinBulkTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlghtTitle
            '
            Me.lblFlghtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlghtTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlghtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlghtTitle.Location = New System.Drawing.Point(144, 24)
            Me.lblFlghtTitle.Name = "lblFlghtTitle"
            Me.lblFlghtTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblFlghtTitle.Text = "Flight"
            Me.lblFlghtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblType
            '
            Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblType.Location = New System.Drawing.Point(8, 81)
            Me.lblType.Name = "lblType"
            Me.lblType.Size = New System.Drawing.Size(73, 17)
            Me.lblType.Text = "MAIL"
            Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(80, 81)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(81, 17)
            Me.lblDate.Text = "53"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(160, 81)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(65, 17)
            Me.lblDest.Text = "NRT"
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(143, 40)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(81, 17)
            Me.lblFlight.Text = "NW8888"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBinBulk
            '
            Me.lblBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulk.Location = New System.Drawing.Point(6, 41)
            Me.lblBinBulk.Name = "lblBinBulk"
            Me.lblBinBulk.Size = New System.Drawing.Size(121, 17)
            Me.lblBinBulk.Text = "53"
            Me.lblBinBulk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrFlight
            '
            Me.lblCurrFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrFlight.Location = New System.Drawing.Point(0, 0)
            Me.lblCurrFlight.Name = "lblCurrFlight"
            Me.lblCurrFlight.Size = New System.Drawing.Size(233, 25)
            Me.lblCurrFlight.Text = "-- Current Flight/Info --"
            Me.lblCurrFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmLoadMail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 294)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraMain)
            Me.Controls.Add(Me.fraEnteredParms)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLoadMail"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraMain.ResumeLayout(False)
            Me.fraEnteredParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraMain As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblFinalTitle As System.Windows.Forms.Label
        Friend WithEvents lblPiecesTitle As System.Windows.Forms.Label
        Friend WithEvents lblWeightTitle As System.Windows.Forms.Label
        Friend WithEvents lblScan As System.Windows.Forms.Label
        Friend WithEvents txtPieces As System.Windows.Forms.TextBox
        Friend WithEvents txtWeight As System.Windows.Forms.TextBox
        Friend WithEvents txtFNL As System.Windows.Forms.TextBox
        Friend WithEvents txtMailBarcode As System.Windows.Forms.TextBox
        Friend WithEvents lblBarcodeTitle As System.Windows.Forms.Label
        Friend WithEvents fraEnteredParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblTypeTitle As System.Windows.Forms.Label
        Friend WithEvents lblDateTitle As System.Windows.Forms.Label
        Friend WithEvents lblDestTitle As System.Windows.Forms.Label
        Friend WithEvents lblBinBulkTitle As System.Windows.Forms.Label
        Friend WithEvents lblFlghtTitle As System.Windows.Forms.Label
        Friend WithEvents lblType As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblBinBulk As System.Windows.Forms.Label
        Friend WithEvents lblCurrFlight As System.Windows.Forms.Label
    End Class
End Namespace

