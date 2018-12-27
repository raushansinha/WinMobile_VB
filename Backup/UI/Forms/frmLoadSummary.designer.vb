Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadSummary
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
            Me.pnlPage4 = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdViewDetail = New System.Windows.Forms.Button
            Me.lblViewTitle = New System.Windows.Forms.Label
            Me.pnlLoadSumm = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHB = New System.Windows.Forms.Label
            Me.lblPB = New System.Windows.Forms.Label
            Me.lblHB1 = New System.Windows.Forms.Label
            Me.lblPB1 = New System.Windows.Forms.Label
            Me.lblB1 = New System.Windows.Forms.Label
            Me.lblIB1 = New System.Windows.Forms.Label
            Me.lblMB1 = New System.Windows.Forms.Label
            Me.lblVIP1 = New System.Windows.Forms.Label
            Me.lblM1 = New System.Windows.Forms.Label
            Me.lblFOR1 = New System.Windows.Forms.Label
            Me.lblC1 = New System.Windows.Forms.Label
            Me.lblSAM1 = New System.Windows.Forms.Label
            Me.lblF1 = New System.Windows.Forms.Label
            Me.lblQF1 = New System.Windows.Forms.Label
            Me.lblB = New System.Windows.Forms.Label
            Me.lblIB = New System.Windows.Forms.Label
            Me.lblMB = New System.Windows.Forms.Label
            Me.lblM = New System.Windows.Forms.Label
            Me.lblFor = New System.Windows.Forms.Label
            Me.lblF = New System.Windows.Forms.Label
            Me.lblSAM = New System.Windows.Forms.Label
            Me.lblV = New System.Windows.Forms.Label
            Me.lblQF = New System.Windows.Forms.Label
            Me.lblC = New System.Windows.Forms.Label
            Me.lblTHRU1 = New System.Windows.Forms.Label
            Me.lblThru = New System.Windows.Forms.Label
            Me.cmdNext = New System.Windows.Forms.Button
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.pnlPage4.SuspendLayout()
            Me.pnlLoadSumm.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlPage4
            '
            Me.pnlPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlPage4.Controls.Add(Me.cmdViewDetail)
            Me.pnlPage4.Controls.Add(Me.lblViewTitle)
            Me.pnlPage4.Controls.Add(Me.pnlLoadSumm)
            Me.pnlPage4.Location = New System.Drawing.Point(0, 56)
            Me.pnlPage4.Name = "pnlPage4"
            Me.pnlPage4.Size = New System.Drawing.Size(231, 201)
            '
            'cmdViewDetail
            '
            Me.cmdViewDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewDetail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdViewDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewDetail.Location = New System.Drawing.Point(48, 166)
            Me.cmdViewDetail.Name = "cmdViewDetail"
            Me.cmdViewDetail.Size = New System.Drawing.Size(137, 33)
            Me.cmdViewDetail.TabIndex = 0
            Me.cmdViewDetail.Text = "[V] View Detail"
            '
            'lblViewTitle
            '
            Me.lblViewTitle.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblViewTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblViewTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblViewTitle.Name = "lblViewTitle"
            Me.lblViewTitle.Size = New System.Drawing.Size(233, 25)
            Me.lblViewTitle.Text = "LOAD SUMMARY"
            Me.lblViewTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlLoadSumm
            '
            Me.pnlLoadSumm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlLoadSumm.Controls.Add(Me.lblHB)
            Me.pnlLoadSumm.Controls.Add(Me.lblPB)
            Me.pnlLoadSumm.Controls.Add(Me.lblHB1)
            Me.pnlLoadSumm.Controls.Add(Me.lblPB1)
            Me.pnlLoadSumm.Controls.Add(Me.lblB1)
            Me.pnlLoadSumm.Controls.Add(Me.lblIB1)
            Me.pnlLoadSumm.Controls.Add(Me.lblMB1)
            Me.pnlLoadSumm.Controls.Add(Me.lblVIP1)
            Me.pnlLoadSumm.Controls.Add(Me.lblM1)
            Me.pnlLoadSumm.Controls.Add(Me.lblFOR1)
            Me.pnlLoadSumm.Controls.Add(Me.lblC1)
            Me.pnlLoadSumm.Controls.Add(Me.lblSAM1)
            Me.pnlLoadSumm.Controls.Add(Me.lblF1)
            Me.pnlLoadSumm.Controls.Add(Me.lblQF1)
            Me.pnlLoadSumm.Controls.Add(Me.lblB)
            Me.pnlLoadSumm.Controls.Add(Me.lblIB)
            Me.pnlLoadSumm.Controls.Add(Me.lblMB)
            Me.pnlLoadSumm.Controls.Add(Me.lblM)
            Me.pnlLoadSumm.Controls.Add(Me.lblFor)
            Me.pnlLoadSumm.Controls.Add(Me.lblF)
            Me.pnlLoadSumm.Controls.Add(Me.lblSAM)
            Me.pnlLoadSumm.Controls.Add(Me.lblV)
            Me.pnlLoadSumm.Controls.Add(Me.lblQF)
            Me.pnlLoadSumm.Controls.Add(Me.lblC)
            Me.pnlLoadSumm.Controls.Add(Me.lblTHRU1)
            Me.pnlLoadSumm.Controls.Add(Me.lblThru)
            Me.pnlLoadSumm.Location = New System.Drawing.Point(0, 25)
            Me.pnlLoadSumm.Name = "pnlLoadSumm"
            Me.pnlLoadSumm.Size = New System.Drawing.Size(228, 137)
            '
            'lblHB
            '
            Me.lblHB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblHB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHB.Location = New System.Drawing.Point(156, 32)
            Me.lblHB.Name = "lblHB"
            Me.lblHB.Size = New System.Drawing.Size(49, 17)
            Me.lblHB.Text = "000"
            Me.lblHB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPB
            '
            Me.lblPB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPB.Location = New System.Drawing.Point(84, 32)
            Me.lblPB.Name = "lblPB"
            Me.lblPB.Size = New System.Drawing.Size(57, 17)
            Me.lblPB.Text = "000"
            Me.lblPB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHB1
            '
            Me.lblHB1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblHB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblHB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHB1.Location = New System.Drawing.Point(156, 16)
            Me.lblHB1.Name = "lblHB1"
            Me.lblHB1.Size = New System.Drawing.Size(49, 17)
            Me.lblHB1.Text = "HB"
            Me.lblHB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPB1
            '
            Me.lblPB1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblPB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPB1.Location = New System.Drawing.Point(84, 16)
            Me.lblPB1.Name = "lblPB1"
            Me.lblPB1.Size = New System.Drawing.Size(57, 17)
            Me.lblPB1.Text = "PB"
            Me.lblPB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblB1
            '
            Me.lblB1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblB1.Location = New System.Drawing.Point(20, 16)
            Me.lblB1.Name = "lblB1"
            Me.lblB1.Size = New System.Drawing.Size(49, 17)
            Me.lblB1.Text = "B"
            Me.lblB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblIB1
            '
            Me.lblIB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblIB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIB1.Location = New System.Drawing.Point(80, 16)
            Me.lblIB1.Name = "lblIB1"
            Me.lblIB1.Size = New System.Drawing.Size(57, 17)
            Me.lblIB1.Text = "IB"
            Me.lblIB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMB1
            '
            Me.lblMB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMB1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblMB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMB1.Location = New System.Drawing.Point(152, 16)
            Me.lblMB1.Name = "lblMB1"
            Me.lblMB1.Size = New System.Drawing.Size(49, 17)
            Me.lblMB1.Text = "MB"
            Me.lblMB1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblVIP1
            '
            Me.lblVIP1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblVIP1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblVIP1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblVIP1.Location = New System.Drawing.Point(116, 56)
            Me.lblVIP1.Name = "lblVIP1"
            Me.lblVIP1.Size = New System.Drawing.Size(49, 17)
            Me.lblVIP1.Text = "VIP"
            Me.lblVIP1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblM1
            '
            Me.lblM1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblM1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblM1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblM1.Location = New System.Drawing.Point(4, 96)
            Me.lblM1.Name = "lblM1"
            Me.lblM1.Size = New System.Drawing.Size(49, 17)
            Me.lblM1.Text = "M"
            Me.lblM1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFOR1
            '
            Me.lblFOR1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblFOR1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFOR1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFOR1.Location = New System.Drawing.Point(60, 96)
            Me.lblFOR1.Name = "lblFOR1"
            Me.lblFOR1.Size = New System.Drawing.Size(49, 17)
            Me.lblFOR1.Text = "FOR"
            Me.lblFOR1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblC1
            '
            Me.lblC1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblC1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblC1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblC1.Location = New System.Drawing.Point(4, 56)
            Me.lblC1.Name = "lblC1"
            Me.lblC1.Size = New System.Drawing.Size(49, 17)
            Me.lblC1.Text = "C"
            Me.lblC1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSAM1
            '
            Me.lblSAM1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblSAM1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblSAM1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSAM1.Location = New System.Drawing.Point(116, 96)
            Me.lblSAM1.Name = "lblSAM1"
            Me.lblSAM1.Size = New System.Drawing.Size(49, 17)
            Me.lblSAM1.Text = "SAM"
            Me.lblSAM1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblF1
            '
            Me.lblF1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblF1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblF1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblF1.Location = New System.Drawing.Point(172, 56)
            Me.lblF1.Name = "lblF1"
            Me.lblF1.Size = New System.Drawing.Size(49, 17)
            Me.lblF1.Text = "F"
            Me.lblF1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblQF1
            '
            Me.lblQF1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblQF1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblQF1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblQF1.Location = New System.Drawing.Point(60, 56)
            Me.lblQF1.Name = "lblQF1"
            Me.lblQF1.Size = New System.Drawing.Size(49, 17)
            Me.lblQF1.Text = "QF"
            Me.lblQF1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblB
            '
            Me.lblB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblB.Location = New System.Drawing.Point(20, 32)
            Me.lblB.Name = "lblB"
            Me.lblB.Size = New System.Drawing.Size(49, 17)
            Me.lblB.Text = "000"
            Me.lblB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblIB
            '
            Me.lblIB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblIB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblIB.Location = New System.Drawing.Point(80, 32)
            Me.lblIB.Name = "lblIB"
            Me.lblIB.Size = New System.Drawing.Size(57, 17)
            Me.lblIB.Text = "000"
            Me.lblIB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMB
            '
            Me.lblMB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblMB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMB.Location = New System.Drawing.Point(152, 32)
            Me.lblMB.Name = "lblMB"
            Me.lblMB.Size = New System.Drawing.Size(49, 17)
            Me.lblMB.Text = "000"
            Me.lblMB.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblM
            '
            Me.lblM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblM.Location = New System.Drawing.Point(4, 112)
            Me.lblM.Name = "lblM"
            Me.lblM.Size = New System.Drawing.Size(49, 17)
            Me.lblM.Text = "00000"
            Me.lblM.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFor
            '
            Me.lblFor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFor.Location = New System.Drawing.Point(60, 112)
            Me.lblFor.Name = "lblFor"
            Me.lblFor.Size = New System.Drawing.Size(49, 17)
            Me.lblFor.Text = "00000"
            Me.lblFor.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblF
            '
            Me.lblF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblF.Location = New System.Drawing.Point(172, 72)
            Me.lblF.Name = "lblF"
            Me.lblF.Size = New System.Drawing.Size(49, 17)
            Me.lblF.Text = "00000"
            Me.lblF.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSAM
            '
            Me.lblSAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSAM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblSAM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSAM.Location = New System.Drawing.Point(116, 112)
            Me.lblSAM.Name = "lblSAM"
            Me.lblSAM.Size = New System.Drawing.Size(49, 17)
            Me.lblSAM.Text = "00000"
            Me.lblSAM.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblV
            '
            Me.lblV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblV.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblV.Location = New System.Drawing.Point(116, 72)
            Me.lblV.Name = "lblV"
            Me.lblV.Size = New System.Drawing.Size(49, 17)
            Me.lblV.Text = "00000"
            Me.lblV.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblQF
            '
            Me.lblQF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblQF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblQF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblQF.Location = New System.Drawing.Point(60, 72)
            Me.lblQF.Name = "lblQF"
            Me.lblQF.Size = New System.Drawing.Size(49, 17)
            Me.lblQF.Text = "00000"
            Me.lblQF.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblC
            '
            Me.lblC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblC.Location = New System.Drawing.Point(4, 72)
            Me.lblC.Name = "lblC"
            Me.lblC.Size = New System.Drawing.Size(49, 17)
            Me.lblC.Text = "00000"
            Me.lblC.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTHRU1
            '
            Me.lblTHRU1.BackColor = System.Drawing.SystemColors.WindowText
            Me.lblTHRU1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTHRU1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTHRU1.Location = New System.Drawing.Point(172, 96)
            Me.lblTHRU1.Name = "lblTHRU1"
            Me.lblTHRU1.Size = New System.Drawing.Size(49, 17)
            Me.lblTHRU1.Text = "THRU"
            Me.lblTHRU1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblThru
            '
            Me.lblThru.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblThru.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblThru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblThru.Location = New System.Drawing.Point(172, 112)
            Me.lblThru.Name = "lblThru"
            Me.lblThru.Size = New System.Drawing.Size(49, 17)
            Me.lblThru.Text = "00000"
            Me.lblThru.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNext.Location = New System.Drawing.Point(120, 259)
            Me.cmdNext.Name = "cmdNext"
            Me.cmdNext.Size = New System.Drawing.Size(113, 41)
            Me.cmdNext.TabIndex = 1
            Me.cmdNext.Text = "(Ent) Next >"
            '
            'cmdPrev
            '
            Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPrev.Location = New System.Drawing.Point(0, 259)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 2
            Me.cmdPrev.Text = "< Prev"
            '
            'frmLoadSummary
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlPage4)
            Me.Controls.Add(Me.cmdNext)
            Me.Controls.Add(Me.cmdPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLoadSummary"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.pnlPage4.ResumeLayout(False)
            Me.pnlLoadSumm.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPage4 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents pnlLoadSumm As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHB As System.Windows.Forms.Label
        Friend WithEvents lblPB As System.Windows.Forms.Label
        Friend WithEvents lblHB1 As System.Windows.Forms.Label
        Friend WithEvents lblPB1 As System.Windows.Forms.Label
        Friend WithEvents lblB1 As System.Windows.Forms.Label
        Friend WithEvents lblIB1 As System.Windows.Forms.Label
        Friend WithEvents lblMB1 As System.Windows.Forms.Label
        Friend WithEvents lblVIP1 As System.Windows.Forms.Label
        Friend WithEvents lblM1 As System.Windows.Forms.Label
        Friend WithEvents lblFOR1 As System.Windows.Forms.Label
        Friend WithEvents lblC1 As System.Windows.Forms.Label
        Friend WithEvents lblSAM1 As System.Windows.Forms.Label
        Friend WithEvents lblF1 As System.Windows.Forms.Label
        Friend WithEvents lblQF1 As System.Windows.Forms.Label
        Friend WithEvents lblB As System.Windows.Forms.Label
        Friend WithEvents lblIB As System.Windows.Forms.Label
        Friend WithEvents lblMB As System.Windows.Forms.Label
        Friend WithEvents lblM As System.Windows.Forms.Label
        Friend WithEvents lblFor As System.Windows.Forms.Label
        Friend WithEvents lblF As System.Windows.Forms.Label
        Friend WithEvents lblSAM As System.Windows.Forms.Label
        Friend WithEvents lblV As System.Windows.Forms.Label
        Friend WithEvents lblQF As System.Windows.Forms.Label
        Friend WithEvents lblC As System.Windows.Forms.Label
        Friend WithEvents lblTHRU1 As System.Windows.Forms.Label
        Friend WithEvents lblThru As System.Windows.Forms.Label
        Friend WithEvents cmdViewDetail As System.Windows.Forms.Button
        Friend WithEvents lblViewTitle As System.Windows.Forms.Label
        Friend WithEvents cmdNext As System.Windows.Forms.Button
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
    End Class
End Namespace