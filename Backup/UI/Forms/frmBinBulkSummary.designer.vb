Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBinBulkSummary
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
            Me.fraBinBulkInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblEstTitle = New System.Windows.Forms.Label
            Me.lblDateTitle = New System.Windows.Forms.Label
            Me.lblDestTitle = New System.Windows.Forms.Label
            Me.lblGateTitle = New System.Windows.Forms.Label
            Me.lblFinalTitle = New System.Windows.Forms.Label
            Me.lblDest = New System.Windows.Forms.Label
            Me.lblFlightTitle = New System.Windows.Forms.Label
            Me.lblFinal = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblEst = New System.Windows.Forms.Label
            Me.lblGate = New System.Windows.Forms.Label
            Me.lblDst = New System.Windows.Forms.Label
            Me.fraBinBulkData = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblFrt2 = New System.Windows.Forms.Label
            Me.lblFrt3 = New System.Windows.Forms.Label
            Me.lblFrt4 = New System.Windows.Forms.Label
            Me.lblFrt1 = New System.Windows.Forms.Label
            Me.lblMail2 = New System.Windows.Forms.Label
            Me.lblMail3 = New System.Windows.Forms.Label
            Me.lblMail4 = New System.Windows.Forms.Label
            Me.lblMail1 = New System.Windows.Forms.Label
            Me.lblBags2 = New System.Windows.Forms.Label
            Me.lblBags3 = New System.Windows.Forms.Label
            Me.lblBags4 = New System.Windows.Forms.Label
            Me.lblBags1 = New System.Windows.Forms.Label
            Me.lblBgs = New System.Windows.Forms.Label
            Me.lblMal = New System.Windows.Forms.Label
            Me.lblLbs = New System.Windows.Forms.Label
            Me.lblHold1 = New System.Windows.Forms.Label
            Me.lblHold4 = New System.Windows.Forms.Label
            Me.lblHold3 = New System.Windows.Forms.Label
            Me.lblHold2 = New System.Windows.Forms.Label
            Me.lblBinBulkTitle = New System.Windows.Forms.Label
            Me.fraBinBulkInfo.SuspendLayout()
            Me.fraBinBulkData.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraBinBulkInfo
            '
            Me.fraBinBulkInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraBinBulkInfo.Controls.Add(Me.lblEstTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblDateTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblDestTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblGateTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblFinalTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblDest)
            Me.fraBinBulkInfo.Controls.Add(Me.lblFlightTitle)
            Me.fraBinBulkInfo.Controls.Add(Me.lblFinal)
            Me.fraBinBulkInfo.Controls.Add(Me.lblFlight)
            Me.fraBinBulkInfo.Controls.Add(Me.lblDate)
            Me.fraBinBulkInfo.Controls.Add(Me.lblEst)
            Me.fraBinBulkInfo.Controls.Add(Me.lblGate)
            Me.fraBinBulkInfo.Controls.Add(Me.lblDst)
            Me.fraBinBulkInfo.Location = New System.Drawing.Point(4, 56)
            Me.fraBinBulkInfo.Name = "fraBinBulkInfo"
            Me.fraBinBulkInfo.Size = New System.Drawing.Size(233, 81)
            '
            'lblEstTitle
            '
            Me.lblEstTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblEstTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblEstTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEstTitle.Location = New System.Drawing.Point(152, 0)
            Me.lblEstTitle.Name = "lblEstTitle"
            Me.lblEstTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblEstTitle.Text = "Est Dept"
            Me.lblEstTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDateTitle
            '
            Me.lblDateTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDateTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDateTitle.Location = New System.Drawing.Point(88, 0)
            Me.lblDateTitle.Name = "lblDateTitle"
            Me.lblDateTitle.Size = New System.Drawing.Size(65, 17)
            Me.lblDateTitle.Text = "Date"
            Me.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDestTitle
            '
            Me.lblDestTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDestTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDestTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDestTitle.Location = New System.Drawing.Point(16, 40)
            Me.lblDestTitle.Name = "lblDestTitle"
            Me.lblDestTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblDestTitle.Text = "Dest"
            Me.lblDestTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblGateTitle
            '
            Me.lblGateTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblGateTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblGateTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblGateTitle.Location = New System.Drawing.Point(152, 40)
            Me.lblGateTitle.Name = "lblGateTitle"
            Me.lblGateTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblGateTitle.Text = "Gate"
            Me.lblGateTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFinalTitle
            '
            Me.lblFinalTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFinalTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFinalTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFinalTitle.Location = New System.Drawing.Point(88, 40)
            Me.lblFinalTitle.Name = "lblFinalTitle"
            Me.lblFinalTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblFinalTitle.Text = "FNL"
            Me.lblFinalTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDest
            '
            Me.lblDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDest.Location = New System.Drawing.Point(16, 56)
            Me.lblDest.Name = "lblDest"
            Me.lblDest.Size = New System.Drawing.Size(57, 17)
            Me.lblDest.Text = "NRT"
            Me.lblDest.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightTitle
            '
            Me.lblFlightTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlightTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblFlightTitle.Name = "lblFlightTitle"
            Me.lblFlightTitle.Size = New System.Drawing.Size(89, 17)
            Me.lblFlightTitle.Text = "Flight"
            Me.lblFlightTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFinal
            '
            Me.lblFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFinal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFinal.Location = New System.Drawing.Point(88, 56)
            Me.lblFinal.Name = "lblFinal"
            Me.lblFinal.Size = New System.Drawing.Size(57, 17)
            Me.lblFinal.Text = "SIN"
            Me.lblFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(8, 16)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(81, 17)
            Me.lblFlight.Text = "NW8888"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(88, 16)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(65, 17)
            Me.lblDate.Text = "88JUL"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblEst
            '
            Me.lblEst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblEst.Location = New System.Drawing.Point(152, 16)
            Me.lblEst.Name = "lblEst"
            Me.lblEst.Size = New System.Drawing.Size(73, 17)
            Me.lblEst.Text = "1414"
            Me.lblEst.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblGate
            '
            Me.lblGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblGate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblGate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblGate.Location = New System.Drawing.Point(160, 56)
            Me.lblGate.Name = "lblGate"
            Me.lblGate.Size = New System.Drawing.Size(65, 17)
            Me.lblGate.Text = "D88"
            Me.lblGate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDst
            '
            Me.lblDst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDst.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDst.Location = New System.Drawing.Point(0, 40)
            Me.lblDst.Name = "lblDst"
            Me.lblDst.Size = New System.Drawing.Size(161, 17)
            Me.lblDst.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraBinBulkData
            '
            Me.fraBinBulkData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraBinBulkData.Controls.Add(Me.lblFrt2)
            Me.fraBinBulkData.Controls.Add(Me.lblFrt3)
            Me.fraBinBulkData.Controls.Add(Me.lblFrt4)
            Me.fraBinBulkData.Controls.Add(Me.lblFrt1)
            Me.fraBinBulkData.Controls.Add(Me.lblMail2)
            Me.fraBinBulkData.Controls.Add(Me.lblMail3)
            Me.fraBinBulkData.Controls.Add(Me.lblMail4)
            Me.fraBinBulkData.Controls.Add(Me.lblMail1)
            Me.fraBinBulkData.Controls.Add(Me.lblBags2)
            Me.fraBinBulkData.Controls.Add(Me.lblBags3)
            Me.fraBinBulkData.Controls.Add(Me.lblBags4)
            Me.fraBinBulkData.Controls.Add(Me.lblBags1)
            Me.fraBinBulkData.Controls.Add(Me.lblBgs)
            Me.fraBinBulkData.Controls.Add(Me.lblMal)
            Me.fraBinBulkData.Controls.Add(Me.lblLbs)
            Me.fraBinBulkData.Controls.Add(Me.lblHold1)
            Me.fraBinBulkData.Controls.Add(Me.lblHold4)
            Me.fraBinBulkData.Controls.Add(Me.lblHold3)
            Me.fraBinBulkData.Controls.Add(Me.lblHold2)
            Me.fraBinBulkData.Controls.Add(Me.lblBinBulkTitle)
            Me.fraBinBulkData.Location = New System.Drawing.Point(4, 136)
            Me.fraBinBulkData.Name = "fraBinBulkData"
            Me.fraBinBulkData.Size = New System.Drawing.Size(233, 129)
            '
            'lblFrt2
            '
            Me.lblFrt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFrt2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFrt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFrt2.Location = New System.Drawing.Point(176, 53)
            Me.lblFrt2.Name = "lblFrt2"
            Me.lblFrt2.Size = New System.Drawing.Size(49, 17)
            Me.lblFrt2.Text = "888"
            Me.lblFrt2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrt3
            '
            Me.lblFrt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFrt3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFrt3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFrt3.Location = New System.Drawing.Point(176, 80)
            Me.lblFrt3.Name = "lblFrt3"
            Me.lblFrt3.Size = New System.Drawing.Size(49, 17)
            Me.lblFrt3.Text = "888"
            Me.lblFrt3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrt4
            '
            Me.lblFrt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFrt4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFrt4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFrt4.Location = New System.Drawing.Point(176, 107)
            Me.lblFrt4.Name = "lblFrt4"
            Me.lblFrt4.Size = New System.Drawing.Size(49, 17)
            Me.lblFrt4.Text = "888"
            Me.lblFrt4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFrt1
            '
            Me.lblFrt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFrt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFrt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFrt1.Location = New System.Drawing.Point(176, 27)
            Me.lblFrt1.Name = "lblFrt1"
            Me.lblFrt1.Size = New System.Drawing.Size(49, 17)
            Me.lblFrt1.Text = "888"
            Me.lblFrt1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMail2
            '
            Me.lblMail2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMail2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMail2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMail2.Location = New System.Drawing.Point(112, 53)
            Me.lblMail2.Name = "lblMail2"
            Me.lblMail2.Size = New System.Drawing.Size(49, 17)
            Me.lblMail2.Text = "888"
            Me.lblMail2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMail3
            '
            Me.lblMail3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMail3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMail3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMail3.Location = New System.Drawing.Point(112, 80)
            Me.lblMail3.Name = "lblMail3"
            Me.lblMail3.Size = New System.Drawing.Size(49, 17)
            Me.lblMail3.Text = "888"
            Me.lblMail3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMail4
            '
            Me.lblMail4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMail4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMail4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMail4.Location = New System.Drawing.Point(112, 107)
            Me.lblMail4.Name = "lblMail4"
            Me.lblMail4.Size = New System.Drawing.Size(49, 17)
            Me.lblMail4.Text = "888"
            Me.lblMail4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMail1
            '
            Me.lblMail1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMail1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblMail1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMail1.Location = New System.Drawing.Point(112, 27)
            Me.lblMail1.Name = "lblMail1"
            Me.lblMail1.Size = New System.Drawing.Size(49, 17)
            Me.lblMail1.Text = "888"
            Me.lblMail1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBags2
            '
            Me.lblBags2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBags2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBags2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBags2.Location = New System.Drawing.Point(56, 53)
            Me.lblBags2.Name = "lblBags2"
            Me.lblBags2.Size = New System.Drawing.Size(41, 17)
            Me.lblBags2.Text = "888"
            Me.lblBags2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBags3
            '
            Me.lblBags3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBags3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBags3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBags3.Location = New System.Drawing.Point(56, 80)
            Me.lblBags3.Name = "lblBags3"
            Me.lblBags3.Size = New System.Drawing.Size(41, 17)
            Me.lblBags3.Text = "888"
            Me.lblBags3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBags4
            '
            Me.lblBags4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBags4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBags4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBags4.Location = New System.Drawing.Point(56, 107)
            Me.lblBags4.Name = "lblBags4"
            Me.lblBags4.Size = New System.Drawing.Size(41, 17)
            Me.lblBags4.Text = "888"
            Me.lblBags4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBags1
            '
            Me.lblBags1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBags1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBags1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBags1.Location = New System.Drawing.Point(56, 27)
            Me.lblBags1.Name = "lblBags1"
            Me.lblBags1.Size = New System.Drawing.Size(41, 17)
            Me.lblBags1.Text = "888"
            Me.lblBags1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBgs
            '
            Me.lblBgs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBgs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblBgs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBgs.Location = New System.Drawing.Point(48, 8)
            Me.lblBgs.Name = "lblBgs"
            Me.lblBgs.Size = New System.Drawing.Size(57, 17)
            Me.lblBgs.Text = "BAGS"
            Me.lblBgs.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMal
            '
            Me.lblMal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblMal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMal.Location = New System.Drawing.Point(104, 8)
            Me.lblMal.Name = "lblMal"
            Me.lblMal.Size = New System.Drawing.Size(65, 17)
            Me.lblMal.Text = "MAIL Lbs"
            Me.lblMal.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblLbs
            '
            Me.lblLbs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLbs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblLbs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLbs.Location = New System.Drawing.Point(168, 8)
            Me.lblLbs.Name = "lblLbs"
            Me.lblLbs.Size = New System.Drawing.Size(65, 17)
            Me.lblLbs.Text = "FRT Lbs"
            Me.lblLbs.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHold1
            '
            Me.lblHold1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHold1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblHold1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHold1.Location = New System.Drawing.Point(16, 27)
            Me.lblHold1.Name = "lblHold1"
            Me.lblHold1.Size = New System.Drawing.Size(25, 17)
            Me.lblHold1.Text = "51"
            Me.lblHold1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHold4
            '
            Me.lblHold4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHold4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblHold4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHold4.Location = New System.Drawing.Point(16, 107)
            Me.lblHold4.Name = "lblHold4"
            Me.lblHold4.Size = New System.Drawing.Size(25, 17)
            Me.lblHold4.Text = "54"
            Me.lblHold4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHold3
            '
            Me.lblHold3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHold3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblHold3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHold3.Location = New System.Drawing.Point(16, 80)
            Me.lblHold3.Name = "lblHold3"
            Me.lblHold3.Size = New System.Drawing.Size(25, 17)
            Me.lblHold3.Text = "53"
            Me.lblHold3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHold2
            '
            Me.lblHold2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHold2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblHold2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHold2.Location = New System.Drawing.Point(16, 53)
            Me.lblHold2.Name = "lblHold2"
            Me.lblHold2.Size = New System.Drawing.Size(25, 17)
            Me.lblHold2.Text = "52"
            Me.lblHold2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBinBulkTitle
            '
            Me.lblBinBulkTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulkTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulkTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulkTitle.Location = New System.Drawing.Point(0, 8)
            Me.lblBinBulkTitle.Name = "lblBinBulkTitle"
            Me.lblBinBulkTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblBinBulkTitle.Text = "BULK"
            Me.lblBinBulkTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmBinBulkSummary
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraBinBulkInfo)
            Me.Controls.Add(Me.fraBinBulkData)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmBinBulkSummary"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraBinBulkInfo.ResumeLayout(False)
            Me.fraBinBulkData.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraBinBulkInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblEstTitle As System.Windows.Forms.Label
        Friend WithEvents lblDateTitle As System.Windows.Forms.Label
        Friend WithEvents lblDestTitle As System.Windows.Forms.Label
        Friend WithEvents lblGateTitle As System.Windows.Forms.Label
        Friend WithEvents lblFinalTitle As System.Windows.Forms.Label
        Friend WithEvents lblDest As System.Windows.Forms.Label
        Friend WithEvents lblFlightTitle As System.Windows.Forms.Label
        Friend WithEvents lblFinal As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblEst As System.Windows.Forms.Label
        Friend WithEvents lblGate As System.Windows.Forms.Label
        Friend WithEvents lblDst As System.Windows.Forms.Label
        Friend WithEvents fraBinBulkData As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblFrt2 As System.Windows.Forms.Label
        Friend WithEvents lblFrt3 As System.Windows.Forms.Label
        Friend WithEvents lblFrt4 As System.Windows.Forms.Label
        Friend WithEvents lblFrt1 As System.Windows.Forms.Label
        Friend WithEvents lblMail2 As System.Windows.Forms.Label
        Friend WithEvents lblMail3 As System.Windows.Forms.Label
        Friend WithEvents lblMail4 As System.Windows.Forms.Label
        Friend WithEvents lblMail1 As System.Windows.Forms.Label
        Friend WithEvents lblBags2 As System.Windows.Forms.Label
        Friend WithEvents lblBags3 As System.Windows.Forms.Label
        Friend WithEvents lblBags4 As System.Windows.Forms.Label
        Friend WithEvents lblBags1 As System.Windows.Forms.Label
        Friend WithEvents lblBgs As System.Windows.Forms.Label
        Friend WithEvents lblMal As System.Windows.Forms.Label
        Friend WithEvents lblLbs As System.Windows.Forms.Label
        Friend WithEvents lblHold1 As System.Windows.Forms.Label
        Friend WithEvents lblHold4 As System.Windows.Forms.Label
        Friend WithEvents lblHold3 As System.Windows.Forms.Label
        Friend WithEvents lblHold2 As System.Windows.Forms.Label
        Friend WithEvents lblBinBulkTitle As System.Windows.Forms.Label
    End Class
End Namespace

