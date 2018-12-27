
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmContainerSummary
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
            Me.fraContainerSummary = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblBags = New System.Windows.Forms.Label
            Me.lblMailWgt = New System.Windows.Forms.Label
            Me.lblFrtWgt = New System.Windows.Forms.Label
            Me.lblULDCS = New System.Windows.Forms.Label
            Me.lblSheetOrULD2 = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblFlightTitle = New System.Windows.Forms.Label
            Me.lblDateTitle = New System.Windows.Forms.Label
            Me.lblEDT = New System.Windows.Forms.Label
            Me.lblEDTTitle = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.lblType = New System.Windows.Forms.Label
            Me.lblDestTitle = New System.Windows.Forms.Label
            Me.lblTypeTitle = New System.Windows.Forms.Label
            Me.lblPos = New System.Windows.Forms.Label
            Me.lblPosTitle = New System.Windows.Forms.Label
            Me.lblBagsTitle = New System.Windows.Forms.Label
            Me.lblMailWgtTitle = New System.Windows.Forms.Label
            Me.lblFrtWgtTitle = New System.Windows.Forms.Label
            Me.fraContainerStatus = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblContainerStatus = New System.Windows.Forms.Label
            Me.lblSheetOrULD1 = New System.Windows.Forms.Label
            Me.txtULDSheet = New System.Windows.Forms.TextBox
            Me.btnCloseReopen = New System.Windows.Forms.Button
            Me.lblInformation = New System.Windows.Forms.Label
            Me.btnLookup = New System.Windows.Forms.Button
            Me.fraContainerSummary.SuspendLayout()
            Me.fraContainerStatus.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraContainerSummary
            '
            Me.fraContainerSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraContainerSummary.Controls.Add(Me.lblBags)
            Me.fraContainerSummary.Controls.Add(Me.lblMailWgt)
            Me.fraContainerSummary.Controls.Add(Me.lblFrtWgt)
            Me.fraContainerSummary.Controls.Add(Me.lblULDCS)
            Me.fraContainerSummary.Controls.Add(Me.lblSheetOrULD2)
            Me.fraContainerSummary.Controls.Add(Me.lblDate)
            Me.fraContainerSummary.Controls.Add(Me.lblFlight)
            Me.fraContainerSummary.Controls.Add(Me.lblFlightTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblDateTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblEDT)
            Me.fraContainerSummary.Controls.Add(Me.lblEDTTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblDest)
            Me.fraContainerSummary.Controls.Add(Me.lblType)
            Me.fraContainerSummary.Controls.Add(Me.lblDestTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblTypeTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblPos)
            Me.fraContainerSummary.Controls.Add(Me.lblPosTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblBagsTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblMailWgtTitle)
            Me.fraContainerSummary.Controls.Add(Me.lblFrtWgtTitle)
            Me.fraContainerSummary.Location = New System.Drawing.Point(3, 101)
            Me.fraContainerSummary.Name = "fraContainerSummary"
            Me.fraContainerSummary.Size = New System.Drawing.Size(233, 143)
            Me.fraContainerSummary.Visible = False
            '
            'lblBags
            '
            Me.lblBags.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBags.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBags.Location = New System.Drawing.Point(8, 122)
            Me.lblBags.Name = "lblBags"
            Me.lblBags.Size = New System.Drawing.Size(73, 17)
            Me.lblBags.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMailWgt
            '
            Me.lblMailWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMailWgt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMailWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMailWgt.Location = New System.Drawing.Point(80, 122)
            Me.lblMailWgt.Name = "lblMailWgt"
            Me.lblMailWgt.Size = New System.Drawing.Size(71, 17)
            Me.lblMailWgt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrtWgt
            '
            Me.lblFrtWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFrtWgt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFrtWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFrtWgt.Location = New System.Drawing.Point(151, 122)
            Me.lblFrtWgt.Name = "lblFrtWgt"
            Me.lblFrtWgt.Size = New System.Drawing.Size(73, 17)
            Me.lblFrtWgt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULDCS
            '
            Me.lblULDCS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULDCS.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblULDCS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULDCS.Location = New System.Drawing.Point(62, 9)
            Me.lblULDCS.Name = "lblULDCS"
            Me.lblULDCS.Size = New System.Drawing.Size(145, 19)
            Me.lblULDCS.Text = "AKJ232323"
            '
            'lblSheetOrULD2
            '
            Me.lblSheetOrULD2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSheetOrULD2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblSheetOrULD2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSheetOrULD2.Location = New System.Drawing.Point(5, 8)
            Me.lblSheetOrULD2.Name = "lblSheetOrULD2"
            Me.lblSheetOrULD2.Size = New System.Drawing.Size(54, 21)
            Me.lblSheetOrULD2.Text = "Sheet"
            Me.lblSheetOrULD2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(88, 45)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(69, 17)
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(8, 45)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(81, 17)
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightTitle
            '
            Me.lblFlightTitle.BackColor = System.Drawing.Color.Black
            Me.lblFlightTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlightTitle.ForeColor = System.Drawing.Color.White
            Me.lblFlightTitle.Location = New System.Drawing.Point(8, 29)
            Me.lblFlightTitle.Name = "lblFlightTitle"
            Me.lblFlightTitle.Size = New System.Drawing.Size(81, 19)
            Me.lblFlightTitle.Text = "Flight"
            Me.lblFlightTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDateTitle
            '
            Me.lblDateTitle.BackColor = System.Drawing.Color.Black
            Me.lblDateTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDateTitle.ForeColor = System.Drawing.Color.White
            Me.lblDateTitle.Location = New System.Drawing.Point(88, 29)
            Me.lblDateTitle.Name = "lblDateTitle"
            Me.lblDateTitle.Size = New System.Drawing.Size(65, 19)
            Me.lblDateTitle.Text = "Date"
            Me.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblEDT
            '
            Me.lblEDT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEDT.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblEDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblEDT.Location = New System.Drawing.Point(157, 45)
            Me.lblEDT.Name = "lblEDT"
            Me.lblEDT.Size = New System.Drawing.Size(68, 16)
            Me.lblEDT.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblEDTTitle
            '
            Me.lblEDTTitle.BackColor = System.Drawing.Color.Black
            Me.lblEDTTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblEDTTitle.ForeColor = System.Drawing.Color.White
            Me.lblEDTTitle.Location = New System.Drawing.Point(152, 29)
            Me.lblEDTTitle.Name = "lblEDTTitle"
            Me.lblEDTTitle.Size = New System.Drawing.Size(73, 19)
            Me.lblEDTTitle.Text = "Est Dept"
            Me.lblEDTTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(8, 84)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(73, 17)
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblType
            '
            Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblType.Location = New System.Drawing.Point(152, 84)
            Me.lblType.Name = "lblType"
            Me.lblType.Size = New System.Drawing.Size(73, 17)
            Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDestTitle
            '
            Me.lblDestTitle.BackColor = System.Drawing.Color.Black
            Me.lblDestTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDestTitle.ForeColor = System.Drawing.Color.White
            Me.lblDestTitle.Location = New System.Drawing.Point(8, 66)
            Me.lblDestTitle.Name = "lblDestTitle"
            Me.lblDestTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblDestTitle.Text = "Dest"
            Me.lblDestTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTypeTitle
            '
            Me.lblTypeTitle.BackColor = System.Drawing.Color.Black
            Me.lblTypeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTypeTitle.ForeColor = System.Drawing.Color.White
            Me.lblTypeTitle.Location = New System.Drawing.Point(152, 66)
            Me.lblTypeTitle.Name = "lblTypeTitle"
            Me.lblTypeTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblTypeTitle.Text = "Type"
            Me.lblTypeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPos
            '
            Me.lblPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPos.Location = New System.Drawing.Point(88, 84)
            Me.lblPos.Name = "lblPos"
            Me.lblPos.Size = New System.Drawing.Size(57, 17)
            Me.lblPos.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPosTitle
            '
            Me.lblPosTitle.BackColor = System.Drawing.Color.Black
            Me.lblPosTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPosTitle.ForeColor = System.Drawing.Color.White
            Me.lblPosTitle.Location = New System.Drawing.Point(80, 66)
            Me.lblPosTitle.Name = "lblPosTitle"
            Me.lblPosTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblPosTitle.Text = "Position"
            Me.lblPosTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBagsTitle
            '
            Me.lblBagsTitle.BackColor = System.Drawing.Color.Black
            Me.lblBagsTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblBagsTitle.ForeColor = System.Drawing.Color.White
            Me.lblBagsTitle.Location = New System.Drawing.Point(8, 106)
            Me.lblBagsTitle.Name = "lblBagsTitle"
            Me.lblBagsTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblBagsTitle.Text = "Bags"
            Me.lblBagsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMailWgtTitle
            '
            Me.lblMailWgtTitle.BackColor = System.Drawing.Color.Black
            Me.lblMailWgtTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblMailWgtTitle.ForeColor = System.Drawing.Color.White
            Me.lblMailWgtTitle.Location = New System.Drawing.Point(80, 106)
            Me.lblMailWgtTitle.Name = "lblMailWgtTitle"
            Me.lblMailWgtTitle.Size = New System.Drawing.Size(75, 17)
            Me.lblMailWgtTitle.Text = "Mail #"
            Me.lblMailWgtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrtWgtTitle
            '
            Me.lblFrtWgtTitle.BackColor = System.Drawing.Color.Black
            Me.lblFrtWgtTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFrtWgtTitle.ForeColor = System.Drawing.Color.White
            Me.lblFrtWgtTitle.Location = New System.Drawing.Point(155, 106)
            Me.lblFrtWgtTitle.Name = "lblFrtWgtTitle"
            Me.lblFrtWgtTitle.Size = New System.Drawing.Size(73, 17)
            Me.lblFrtWgtTitle.Text = "Frt #"
            Me.lblFrtWgtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraContainerStatus
            '
            Me.fraContainerStatus.Controls.Add(Me.lblContainerStatus)
            Me.fraContainerStatus.Location = New System.Drawing.Point(136, 87)
            Me.fraContainerStatus.Name = "fraContainerStatus"
            Me.fraContainerStatus.Size = New System.Drawing.Size(97, 25)
            '
            'lblContainerStatus
            '
            Me.lblContainerStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblContainerStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblContainerStatus.Location = New System.Drawing.Point(3, 1)
            Me.lblContainerStatus.Name = "lblContainerStatus"
            Me.lblContainerStatus.Size = New System.Drawing.Size(87, 19)
            Me.lblContainerStatus.Text = "CLOSED"
            Me.lblContainerStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSheetOrULD1
            '
            Me.lblSheetOrULD1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblSheetOrULD1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSheetOrULD1.Location = New System.Drawing.Point(0, 54)
            Me.lblSheetOrULD1.Name = "lblSheetOrULD1"
            Me.lblSheetOrULD1.Size = New System.Drawing.Size(65, 23)
            Me.lblSheetOrULD1.Text = "ULD/CS"
            Me.lblSheetOrULD1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtULDSheet
            '
            Me.txtULDSheet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtULDSheet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtULDSheet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtULDSheet.Location = New System.Drawing.Point(75, 51)
            Me.txtULDSheet.MaxLength = 13
            Me.txtULDSheet.Name = "txtULDSheet"
            Me.txtULDSheet.Size = New System.Drawing.Size(161, 26)
            Me.txtULDSheet.TabIndex = 0
            '
            'btnCloseReopen
            '
            Me.btnCloseReopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnCloseReopen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.btnCloseReopen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnCloseReopen.Location = New System.Drawing.Point(3, 243)
            Me.btnCloseReopen.Name = "btnCloseReopen"
            Me.btnCloseReopen.Size = New System.Drawing.Size(233, 30)
            Me.btnCloseReopen.TabIndex = 3
            Me.btnCloseReopen.Text = "[C/R] Close / Reopen"
            Me.btnCloseReopen.Visible = False
            '
            'lblInformation
            '
            Me.lblInformation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInformation.Location = New System.Drawing.Point(6, 93)
            Me.lblInformation.Name = "lblInformation"
            Me.lblInformation.Size = New System.Drawing.Size(108, 17)
            Me.lblInformation.Text = "Information"
            Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnLookup
            '
            Me.btnLookup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnLookup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnLookup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnLookup.Location = New System.Drawing.Point(52, 243)
            Me.btnLookup.Name = "btnLookup"
            Me.btnLookup.Size = New System.Drawing.Size(129, 33)
            Me.btnLookup.TabIndex = 1
            Me.btnLookup.Text = "[ENT] Lookup"
            '
            'frmContainerSummary
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblInformation)
            Me.Controls.Add(Me.btnLookup)
            Me.Controls.Add(Me.fraContainerStatus)
            Me.Controls.Add(Me.btnCloseReopen)
            Me.Controls.Add(Me.lblSheetOrULD1)
            Me.Controls.Add(Me.txtULDSheet)
            Me.Controls.Add(Me.fraContainerSummary)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmContainerSummary"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraContainerSummary.ResumeLayout(False)
            Me.fraContainerStatus.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraContainerSummary As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblBags As System.Windows.Forms.Label
        Friend WithEvents lblMailWgt As System.Windows.Forms.Label
        Friend WithEvents lblFrtWgt As System.Windows.Forms.Label
        Friend WithEvents lblULDCS As System.Windows.Forms.Label
        Friend WithEvents lblContainerStatus As System.Windows.Forms.Label
        Friend WithEvents lblSheetOrULD2 As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblFlightTitle As System.Windows.Forms.Label
        Friend WithEvents lblDateTitle As System.Windows.Forms.Label
        Friend WithEvents lblEDT As System.Windows.Forms.Label
        Friend WithEvents lblEDTTitle As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents lblType As System.Windows.Forms.Label
        Friend WithEvents lblDestTitle As System.Windows.Forms.Label
        Friend WithEvents lblTypeTitle As System.Windows.Forms.Label
        Friend WithEvents lblPos As System.Windows.Forms.Label
        Friend WithEvents lblPosTitle As System.Windows.Forms.Label
        Friend WithEvents lblBagsTitle As System.Windows.Forms.Label
        Friend WithEvents lblMailWgtTitle As System.Windows.Forms.Label
        Friend WithEvents lblFrtWgtTitle As System.Windows.Forms.Label
        Friend WithEvents lblSheetOrULD1 As System.Windows.Forms.Label
        Friend WithEvents txtULDSheet As System.Windows.Forms.TextBox
        Friend WithEvents btnCloseReopen As System.Windows.Forms.Button
        Friend WithEvents lblInformation As System.Windows.Forms.Label
        Friend WithEvents fraContainerStatus As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnLookup As System.Windows.Forms.Button
    End Class
End Namespace
