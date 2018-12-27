Imports OpenNETCF.Windows.Forms.GroupBox
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmMergeContainers
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
            Me.fraFrom = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtFromDate = New System.Windows.Forms.TextBox
            Me.lblFromDt = New System.Windows.Forms.Label
            Me.txtFromFlight = New System.Windows.Forms.TextBox
            Me.lbFromlFlt = New System.Windows.Forms.Label
            Me.txtFromULD = New System.Windows.Forms.TextBox
            Me.lblFromType = New System.Windows.Forms.Label
            Me.lblFromULDBinHeader = New System.Windows.Forms.Label
            Me.fraTo = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtToDate = New System.Windows.Forms.TextBox
            Me.lblToDt = New System.Windows.Forms.Label
            Me.txtToFlight = New System.Windows.Forms.TextBox
            Me.lblToFlt = New System.Windows.Forms.Label
            Me.txtToULD = New System.Windows.Forms.TextBox
            Me.lblToType = New System.Windows.Forms.Label
            Me.lblToUld = New System.Windows.Forms.Label
            Me.lblPcsAWB = New System.Windows.Forms.Label
            Me.cmbCommod = New System.Windows.Forms.ComboBox
            Me.lblCommod = New System.Windows.Forms.Label
            Me.txtPcsAWB = New System.Windows.Forms.TextBox
            Me.fraScanDetected = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdScannedTo = New System.Windows.Forms.Button
            Me.cmdScannedFrom = New System.Windows.Forms.Button
            Me.lblScanBarcode = New System.Windows.Forms.Label
            Me.lblchoice = New System.Windows.Forms.Label
            Me.lblBarcodeScanned = New System.Windows.Forms.Label
            Me.fraFrom.SuspendLayout()
            Me.fraTo.SuspendLayout()
            Me.fraScanDetected.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraFrom
            '
            Me.fraFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraFrom.Controls.Add(Me.txtFromDate)
            Me.fraFrom.Controls.Add(Me.lblFromDt)
            Me.fraFrom.Controls.Add(Me.txtFromFlight)
            Me.fraFrom.Controls.Add(Me.lbFromlFlt)
            Me.fraFrom.Controls.Add(Me.txtFromULD)
            Me.fraFrom.Controls.Add(Me.lblFromType)
            Me.fraFrom.Controls.Add(Me.lblFromULDBinHeader)
            Me.fraFrom.Location = New System.Drawing.Point(0, 93)
            Me.fraFrom.Name = "fraFrom"
            Me.fraFrom.Size = New System.Drawing.Size(237, 88)
            '
            'txtFromDate
            '
            Me.txtFromDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFromDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFromDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFromDate.Location = New System.Drawing.Point(160, 56)
            Me.txtFromDate.MaxLength = 5
            Me.txtFromDate.Name = "txtFromDate"
            Me.txtFromDate.Size = New System.Drawing.Size(74, 26)
            Me.txtFromDate.TabIndex = 4
            '
            'lblFromDt
            '
            Me.lblFromDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromDt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromDt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromDt.Location = New System.Drawing.Point(116, 56)
            Me.lblFromDt.Name = "lblFromDt"
            Me.lblFromDt.Size = New System.Drawing.Size(45, 22)
            Me.lblFromDt.Text = "Dt"
            Me.lblFromDt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtFromFlight
            '
            Me.txtFromFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFromFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFromFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFromFlight.Location = New System.Drawing.Point(36, 56)
            Me.txtFromFlight.MaxLength = 6
            Me.txtFromFlight.Name = "txtFromFlight"
            Me.txtFromFlight.Size = New System.Drawing.Size(74, 26)
            Me.txtFromFlight.TabIndex = 3
            '
            'lbFromlFlt
            '
            Me.lbFromlFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbFromlFlt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lbFromlFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbFromlFlt.Location = New System.Drawing.Point(3, 56)
            Me.lbFromlFlt.Name = "lbFromlFlt"
            Me.lbFromlFlt.Size = New System.Drawing.Size(33, 22)
            Me.lbFromlFlt.Text = "Flt"
            Me.lbFromlFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtFromULD
            '
            Me.txtFromULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtFromULD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtFromULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFromULD.Location = New System.Drawing.Point(4, 27)
            Me.txtFromULD.MaxLength = 10
            Me.txtFromULD.Name = "txtFromULD"
            Me.txtFromULD.Size = New System.Drawing.Size(154, 26)
            Me.txtFromULD.TabIndex = 2
            '
            'lblFromType
            '
            Me.lblFromType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromType.Location = New System.Drawing.Point(160, 31)
            Me.lblFromType.Name = "lblFromType"
            Me.lblFromType.Size = New System.Drawing.Size(65, 25)
            Me.lblFromType.Text = "MIXED"
            Me.lblFromType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFromULDBinHeader
            '
            Me.lblFromULDBinHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFromULDBinHeader.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblFromULDBinHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFromULDBinHeader.Location = New System.Drawing.Point(1, 1)
            Me.lblFromULDBinHeader.Name = "lblFromULDBinHeader"
            Me.lblFromULDBinHeader.Size = New System.Drawing.Size(235, 24)
            Me.lblFromULDBinHeader.Text = "FROM ULD/Bin"
            Me.lblFromULDBinHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraTo
            '
            Me.fraTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraTo.Controls.Add(Me.txtToDate)
            Me.fraTo.Controls.Add(Me.lblToDt)
            Me.fraTo.Controls.Add(Me.txtToFlight)
            Me.fraTo.Controls.Add(Me.lblToFlt)
            Me.fraTo.Controls.Add(Me.txtToULD)
            Me.fraTo.Controls.Add(Me.lblToType)
            Me.fraTo.Controls.Add(Me.lblToUld)
            Me.fraTo.Location = New System.Drawing.Point(0, 184)
            Me.fraTo.Name = "fraTo"
            Me.fraTo.Size = New System.Drawing.Size(237, 90)
            '
            'txtToDate
            '
            Me.txtToDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtToDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtToDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtToDate.Location = New System.Drawing.Point(160, 61)
            Me.txtToDate.MaxLength = 5
            Me.txtToDate.Name = "txtToDate"
            Me.txtToDate.Size = New System.Drawing.Size(74, 26)
            Me.txtToDate.TabIndex = 7
            '
            'lblToDt
            '
            Me.lblToDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToDt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblToDt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToDt.Location = New System.Drawing.Point(121, 66)
            Me.lblToDt.Name = "lblToDt"
            Me.lblToDt.Size = New System.Drawing.Size(33, 21)
            Me.lblToDt.Text = "Dt"
            Me.lblToDt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtToFlight
            '
            Me.txtToFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtToFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtToFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtToFlight.Location = New System.Drawing.Point(35, 60)
            Me.txtToFlight.MaxLength = 6
            Me.txtToFlight.Name = "txtToFlight"
            Me.txtToFlight.Size = New System.Drawing.Size(74, 26)
            Me.txtToFlight.TabIndex = 6
            '
            'lblToFlt
            '
            Me.lblToFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToFlt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblToFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToFlt.Location = New System.Drawing.Point(4, 63)
            Me.lblToFlt.Name = "lblToFlt"
            Me.lblToFlt.Size = New System.Drawing.Size(33, 23)
            Me.lblToFlt.Text = "Flt"
            Me.lblToFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtToULD
            '
            Me.txtToULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtToULD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtToULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtToULD.Location = New System.Drawing.Point(4, 32)
            Me.txtToULD.MaxLength = 10
            Me.txtToULD.Name = "txtToULD"
            Me.txtToULD.Size = New System.Drawing.Size(155, 26)
            Me.txtToULD.TabIndex = 5
            '
            'lblToType
            '
            Me.lblToType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblToType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToType.Location = New System.Drawing.Point(160, 36)
            Me.lblToType.Name = "lblToType"
            Me.lblToType.Size = New System.Drawing.Size(65, 25)
            Me.lblToType.Text = "MIXED"
            Me.lblToType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblToUld
            '
            Me.lblToUld.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblToUld.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblToUld.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblToUld.Location = New System.Drawing.Point(-1, 0)
            Me.lblToUld.Name = "lblToUld"
            Me.lblToUld.Size = New System.Drawing.Size(237, 25)
            Me.lblToUld.Text = "TO ULD/Bin"
            Me.lblToUld.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPcsAWB
            '
            Me.lblPcsAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPcsAWB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblPcsAWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPcsAWB.Location = New System.Drawing.Point(140, 49)
            Me.lblPcsAWB.Name = "lblPcsAWB"
            Me.lblPcsAWB.Size = New System.Drawing.Size(97, 20)
            Me.lblPcsAWB.Text = "Pieces"
            Me.lblPcsAWB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmbCommod
            '
            Me.cmbCommod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbCommod.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.cmbCommod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbCommod.Items.Add("ALL")
            Me.cmbCommod.Items.Add("FRT")
            Me.cmbCommod.Items.Add("MAIL")
            Me.cmbCommod.Items.Add("BAGS")
            Me.cmbCommod.Location = New System.Drawing.Point(0, 68)
            Me.cmbCommod.Name = "cmbCommod"
            Me.cmbCommod.Size = New System.Drawing.Size(96, 27)
            Me.cmbCommod.TabIndex = 0
            '
            'lblCommod
            '
            Me.lblCommod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCommod.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCommod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCommod.Location = New System.Drawing.Point(0, 49)
            Me.lblCommod.Name = "lblCommod"
            Me.lblCommod.Size = New System.Drawing.Size(96, 20)
            Me.lblCommod.Text = "Commod"
            Me.lblCommod.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtPcsAWB
            '
            Me.txtPcsAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtPcsAWB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.txtPcsAWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtPcsAWB.Location = New System.Drawing.Point(140, 69)
            Me.txtPcsAWB.MaxLength = 5
            Me.txtPcsAWB.Multiline = True
            Me.txtPcsAWB.Name = "txtPcsAWB"
            Me.txtPcsAWB.Size = New System.Drawing.Size(97, 22)
            Me.txtPcsAWB.TabIndex = 1
            Me.txtPcsAWB.Text = "ALL"
            '
            'fraScanDetected
            '
            Me.fraScanDetected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScanDetected.Controls.Add(Me.cmdScannedTo)
            Me.fraScanDetected.Controls.Add(Me.cmdScannedFrom)
            Me.fraScanDetected.Controls.Add(Me.lblScanBarcode)
            Me.fraScanDetected.Controls.Add(Me.lblchoice)
            Me.fraScanDetected.Controls.Add(Me.lblBarcodeScanned)
            Me.fraScanDetected.Location = New System.Drawing.Point(0, 94)
            Me.fraScanDetected.Name = "fraScanDetected"
            Me.fraScanDetected.Size = New System.Drawing.Size(237, 153)
            Me.fraScanDetected.Visible = False
            '
            'cmdScannedTo
            '
            Me.cmdScannedTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdScannedTo.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdScannedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdScannedTo.Location = New System.Drawing.Point(128, 90)
            Me.cmdScannedTo.Name = "cmdScannedTo"
            Me.cmdScannedTo.Size = New System.Drawing.Size(97, 41)
            Me.cmdScannedTo.TabIndex = 0
            Me.cmdScannedTo.Text = "(C) &To"
            '
            'cmdScannedFrom
            '
            Me.cmdScannedFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdScannedFrom.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdScannedFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdScannedFrom.Location = New System.Drawing.Point(8, 90)
            Me.cmdScannedFrom.Name = "cmdScannedFrom"
            Me.cmdScannedFrom.Size = New System.Drawing.Size(97, 41)
            Me.cmdScannedFrom.TabIndex = 1
            Me.cmdScannedFrom.Text = "(A) &From"
            '
            'lblScanBarcode
            '
            Me.lblScanBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScanBarcode.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblScanBarcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScanBarcode.Location = New System.Drawing.Point(0, 0)
            Me.lblScanBarcode.Name = "lblScanBarcode"
            Me.lblScanBarcode.Size = New System.Drawing.Size(235, 25)
            Me.lblScanBarcode.Text = "Scanned Barcode"
            Me.lblScanBarcode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblchoice
            '
            Me.lblchoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblchoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblchoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblchoice.Location = New System.Drawing.Point(22, 39)
            Me.lblchoice.Name = "lblchoice"
            Me.lblchoice.Size = New System.Drawing.Size(193, 41)
            Me.lblchoice.Text = "Is this the FROM or TO location?"
            Me.lblchoice.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBarcodeScanned
            '
            Me.lblBarcodeScanned.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBarcodeScanned.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.lblBarcodeScanned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBarcodeScanned.Location = New System.Drawing.Point(8, 24)
            Me.lblBarcodeScanned.Name = "lblBarcodeScanned"
            Me.lblBarcodeScanned.Size = New System.Drawing.Size(217, 25)
            Me.lblBarcodeScanned.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmMergeContainers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraFrom)
            Me.Controls.Add(Me.fraTo)
            Me.Controls.Add(Me.txtPcsAWB)
            Me.Controls.Add(Me.lblPcsAWB)
            Me.Controls.Add(Me.lblCommod)
            Me.Controls.Add(Me.cmbCommod)
            Me.Controls.Add(Me.fraScanDetected)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmMergeContainers"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraFrom.ResumeLayout(False)
            Me.fraTo.ResumeLayout(False)
            Me.fraScanDetected.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraFrom As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtFromDate As System.Windows.Forms.TextBox
        Friend WithEvents lblFromDt As System.Windows.Forms.Label
        Friend WithEvents txtFromFlight As System.Windows.Forms.TextBox
        Friend WithEvents lbFromlFlt As System.Windows.Forms.Label
        Friend WithEvents txtFromULD As System.Windows.Forms.TextBox
        Friend WithEvents lblFromType As System.Windows.Forms.Label
        Friend WithEvents lblFromULDBinHeader As System.Windows.Forms.Label
        Friend WithEvents fraTo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtToDate As System.Windows.Forms.TextBox
        Friend WithEvents lblToDt As System.Windows.Forms.Label
        Friend WithEvents txtToFlight As System.Windows.Forms.TextBox
        Friend WithEvents lblToFlt As System.Windows.Forms.Label
        Friend WithEvents txtToULD As System.Windows.Forms.TextBox
        Friend WithEvents lblToType As System.Windows.Forms.Label
        Friend WithEvents lblToUld As System.Windows.Forms.Label
        Friend WithEvents lblPcsAWB As System.Windows.Forms.Label
        Friend WithEvents cmbCommod As System.Windows.Forms.ComboBox
        Friend WithEvents lblCommod As System.Windows.Forms.Label
        Friend WithEvents txtPcsAWB As System.Windows.Forms.TextBox
        Friend WithEvents fraScanDetected As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdScannedTo As System.Windows.Forms.Button
        Friend WithEvents cmdScannedFrom As System.Windows.Forms.Button
        Friend WithEvents lblScanBarcode As System.Windows.Forms.Label
        Friend WithEvents lblchoice As System.Windows.Forms.Label
        Friend WithEvents lblBarcodeScanned As System.Windows.Forms.Label
    End Class
End Namespace