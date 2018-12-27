Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadFreightToBinBulk
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
            Me.fraResult = New OpenNETCF.Windows.Forms.GroupBox
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.fraInitCargo = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label22 = New System.Windows.Forms.Label
            Me.Label21 = New System.Windows.Forms.Label
            Me.lblStat = New System.Windows.Forms.Label
            Me.lblDte = New System.Windows.Forms.Label
            Me.lblFlght = New System.Windows.Forms.Label
            Me.lblWght = New System.Windows.Forms.Label
            Me.lblCount = New System.Windows.Forms.Label
            Me.lblAWBInfo = New System.Windows.Forms.Label
            Me.lblRecvPcs = New System.Windows.Forms.Label
            Me.lblRecvWgt = New System.Windows.Forms.Label
            Me.lblRecvStatus = New System.Windows.Forms.Label
            Me.lblRecvDate = New System.Windows.Forms.Label
            Me.lblRecvFlight = New System.Windows.Forms.Label
            Me.fraScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblDat = New System.Windows.Forms.Label
            Me.lblFlt = New System.Windows.Forms.Label
            Me.lblBnBlk = New System.Windows.Forms.Label
            Me.txtAWB = New System.Windows.Forms.TextBox
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblBinBulk = New System.Windows.Forms.Label
            Me.lblScanning = New System.Windows.Forms.Label
            Me.lblScanAWB = New System.Windows.Forms.Label
            Me.fraResult.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.fraInitCargo.SuspendLayout()
            Me.fraScan.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraResult
            '
            Me.fraResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraResult.Controls.Add(Me.fraWait)
            Me.fraResult.Controls.Add(Me.fraInitCargo)
            Me.fraResult.Controls.Add(Me.lblStat)
            Me.fraResult.Controls.Add(Me.lblDte)
            Me.fraResult.Controls.Add(Me.lblFlght)
            Me.fraResult.Controls.Add(Me.lblWght)
            Me.fraResult.Controls.Add(Me.lblCount)
            Me.fraResult.Controls.Add(Me.lblAWBInfo)
            Me.fraResult.Controls.Add(Me.lblRecvPcs)
            Me.fraResult.Controls.Add(Me.lblRecvWgt)
            Me.fraResult.Controls.Add(Me.lblRecvStatus)
            Me.fraResult.Controls.Add(Me.lblRecvDate)
            Me.fraResult.Controls.Add(Me.lblRecvFlight)
            Me.fraResult.Location = New System.Drawing.Point(4, 172)
            Me.fraResult.Name = "fraResult"
            Me.fraResult.Size = New System.Drawing.Size(233, 105)
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.Label18)
            Me.fraWait.Controls.Add(Me.Label17)
            Me.fraWait.Location = New System.Drawing.Point(0, 150)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 97)
            Me.fraWait.Visible = False
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(0, 0)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(233, 25)
            Me.Label18.Text = "Retrieving Data"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(32, 48)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(169, 25)
            Me.Label17.Text = "Please Wait..."
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraInitCargo
            '
            Me.fraInitCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInitCargo.Controls.Add(Me.Label22)
            Me.fraInitCargo.Controls.Add(Me.Label21)
            Me.fraInitCargo.Location = New System.Drawing.Point(0, 8)
            Me.fraInitCargo.Name = "fraInitCargo"
            Me.fraInitCargo.Size = New System.Drawing.Size(233, 97)
            Me.fraInitCargo.Visible = False
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(32, 48)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(169, 25)
            Me.Label22.Text = "Please Wait..."
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(0, 0)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(233, 25)
            Me.Label21.Text = "Initiating Cargo"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblStat
            '
            Me.lblStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStat.Location = New System.Drawing.Point(152, 61)
            Me.lblStat.Name = "lblStat"
            Me.lblStat.Size = New System.Drawing.Size(81, 17)
            Me.lblStat.Text = "Status"
            Me.lblStat.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDte
            '
            Me.lblDte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDte.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDte.Location = New System.Drawing.Point(80, 61)
            Me.lblDte.Name = "lblDte"
            Me.lblDte.Size = New System.Drawing.Size(73, 17)
            Me.lblDte.Text = "Date"
            Me.lblDte.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlght
            '
            Me.lblFlght.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlght.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlght.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlght.Location = New System.Drawing.Point(0, 61)
            Me.lblFlght.Name = "lblFlght"
            Me.lblFlght.Size = New System.Drawing.Size(81, 17)
            Me.lblFlght.Text = "Flight"
            Me.lblFlght.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblWght
            '
            Me.lblWght.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWght.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblWght.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWght.Location = New System.Drawing.Point(120, 24)
            Me.lblWght.Name = "lblWght"
            Me.lblWght.Size = New System.Drawing.Size(105, 17)
            Me.lblWght.Text = "Piece Weight"
            Me.lblWght.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCount
            '
            Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCount.Location = New System.Drawing.Point(8, 24)
            Me.lblCount.Name = "lblCount"
            Me.lblCount.Size = New System.Drawing.Size(89, 17)
            Me.lblCount.Text = "Piece Count"
            Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblAWBInfo
            '
            Me.lblAWBInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAWBInfo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblAWBInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAWBInfo.Location = New System.Drawing.Point(0, -1)
            Me.lblAWBInfo.Name = "lblAWBInfo"
            Me.lblAWBInfo.Size = New System.Drawing.Size(233, 25)
            Me.lblAWBInfo.Text = "AWB Information"
            Me.lblAWBInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRecvPcs
            '
            Me.lblRecvPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRecvPcs.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblRecvPcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRecvPcs.Location = New System.Drawing.Point(16, 40)
            Me.lblRecvPcs.Name = "lblRecvPcs"
            Me.lblRecvPcs.Size = New System.Drawing.Size(73, 18)
            Me.lblRecvPcs.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRecvWgt
            '
            Me.lblRecvWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRecvWgt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblRecvWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRecvWgt.Location = New System.Drawing.Point(128, 40)
            Me.lblRecvWgt.Name = "lblRecvWgt"
            Me.lblRecvWgt.Size = New System.Drawing.Size(89, 18)
            Me.lblRecvWgt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRecvStatus
            '
            Me.lblRecvStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRecvStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblRecvStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRecvStatus.Location = New System.Drawing.Point(168, 81)
            Me.lblRecvStatus.Name = "lblRecvStatus"
            Me.lblRecvStatus.Size = New System.Drawing.Size(49, 22)
            Me.lblRecvStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRecvDate
            '
            Me.lblRecvDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRecvDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblRecvDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRecvDate.Location = New System.Drawing.Point(80, 81)
            Me.lblRecvDate.Name = "lblRecvDate"
            Me.lblRecvDate.Size = New System.Drawing.Size(73, 22)
            Me.lblRecvDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRecvFlight
            '
            Me.lblRecvFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRecvFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblRecvFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRecvFlight.Location = New System.Drawing.Point(8, 81)
            Me.lblRecvFlight.Name = "lblRecvFlight"
            Me.lblRecvFlight.Size = New System.Drawing.Size(65, 23)
            Me.lblRecvFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraScan
            '
            Me.fraScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScan.Controls.Add(Me.lblDat)
            Me.fraScan.Controls.Add(Me.lblFlt)
            Me.fraScan.Controls.Add(Me.lblBnBlk)
            Me.fraScan.Controls.Add(Me.txtAWB)
            Me.fraScan.Controls.Add(Me.lblFlight)
            Me.fraScan.Controls.Add(Me.lblDate)
            Me.fraScan.Controls.Add(Me.lblBinBulk)
            Me.fraScan.Controls.Add(Me.lblScanning)
            Me.fraScan.Controls.Add(Me.lblScanAWB)
            Me.fraScan.Location = New System.Drawing.Point(4, 43)
            Me.fraScan.Name = "fraScan"
            Me.fraScan.Size = New System.Drawing.Size(233, 127)
            '
            'lblDat
            '
            Me.lblDat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDat.Location = New System.Drawing.Point(160, 86)
            Me.lblDat.Name = "lblDat"
            Me.lblDat.Size = New System.Drawing.Size(73, 17)
            Me.lblDat.Text = "Date"
            Me.lblDat.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlt
            '
            Me.lblFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlt.Location = New System.Drawing.Point(80, 86)
            Me.lblFlt.Name = "lblFlt"
            Me.lblFlt.Size = New System.Drawing.Size(81, 17)
            Me.lblFlt.Text = "Flight"
            Me.lblFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBnBlk
            '
            Me.lblBnBlk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBnBlk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblBnBlk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBnBlk.Location = New System.Drawing.Point(0, 86)
            Me.lblBnBlk.Name = "lblBnBlk"
            Me.lblBnBlk.Size = New System.Drawing.Size(81, 17)
            Me.lblBnBlk.Text = "Bin/Bulk"
            Me.lblBnBlk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtAWB
            '
            Me.txtAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtAWB.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtAWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtAWB.Location = New System.Drawing.Point(8, 27)
            Me.txtAWB.MaxLength = 16
            Me.txtAWB.Name = "txtAWB"
            Me.txtAWB.Size = New System.Drawing.Size(217, 32)
            Me.txtAWB.TabIndex = 3
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(80, 107)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(81, 17)
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(160, 107)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(65, 17)
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBinBulk
            '
            Me.lblBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulk.Location = New System.Drawing.Point(8, 107)
            Me.lblBinBulk.Name = "lblBinBulk"
            Me.lblBinBulk.Size = New System.Drawing.Size(65, 17)
            Me.lblBinBulk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblScanning
            '
            Me.lblScanning.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScanning.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblScanning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScanning.Location = New System.Drawing.Point(0, 61)
            Me.lblScanning.Name = "lblScanning"
            Me.lblScanning.Size = New System.Drawing.Size(233, 25)
            Me.lblScanning.Text = "Scanning Into"
            Me.lblScanning.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblScanAWB
            '
            Me.lblScanAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScanAWB.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblScanAWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScanAWB.Location = New System.Drawing.Point(0, 0)
            Me.lblScanAWB.Name = "lblScanAWB"
            Me.lblScanAWB.Size = New System.Drawing.Size(233, 25)
            Me.lblScanAWB.Text = "Scan Air Waybill (AWB)"
            Me.lblScanAWB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmLoadFreightToBinBulk
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraResult)
            Me.Controls.Add(Me.fraScan)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.MinimizeBox = False
            Me.Name = "frmLoadFreightToBinBulk"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraResult.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.fraInitCargo.ResumeLayout(False)
            Me.fraScan.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraResult As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblStat As System.Windows.Forms.Label
        Friend WithEvents lblDte As System.Windows.Forms.Label
        Friend WithEvents lblFlght As System.Windows.Forms.Label
        Friend WithEvents lblWght As System.Windows.Forms.Label
        Friend WithEvents lblCount As System.Windows.Forms.Label
        Friend WithEvents lblAWBInfo As System.Windows.Forms.Label
        Friend WithEvents lblRecvPcs As System.Windows.Forms.Label
        Friend WithEvents lblRecvWgt As System.Windows.Forms.Label
        Friend WithEvents lblRecvStatus As System.Windows.Forms.Label
        Friend WithEvents lblRecvDate As System.Windows.Forms.Label
        Friend WithEvents lblRecvFlight As System.Windows.Forms.Label
        Friend WithEvents fraScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblDat As System.Windows.Forms.Label
        Friend WithEvents lblFlt As System.Windows.Forms.Label
        Friend WithEvents lblBnBlk As System.Windows.Forms.Label
        Friend WithEvents txtAWB As System.Windows.Forms.TextBox
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblBinBulk As System.Windows.Forms.Label
        Friend WithEvents lblScanning As System.Windows.Forms.Label
        Friend WithEvents lblScanAWB As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents fraInitCargo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
    End Class
End Namespace
