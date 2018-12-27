Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmBagtagInquiry
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
            Me.lblBagFltItin = New System.Windows.Forms.Label
            Me.lblBagFltTime = New System.Windows.Forms.Label
            Me.lblBagFltGate = New System.Windows.Forms.Label
            Me.lblName = New System.Windows.Forms.Label
            Me.lblPAXName = New System.Windows.Forms.Label
            Me.lblPAXStatus = New System.Windows.Forms.Label
            Me.fraBagtag = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblScan = New System.Windows.Forms.Label
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.lblOnwFltId = New System.Windows.Forms.Label
            Me.lblOnwFltCity1 = New System.Windows.Forms.Label
            Me.lblOnwFltCity2 = New System.Windows.Forms.Label
            Me.lblPAX = New System.Windows.Forms.Label
            Me.lblFLINFO = New System.Windows.Forms.Label
            Me.lblBagFltDate = New System.Windows.Forms.Label
            Me.lblLocation = New System.Windows.Forms.Label
            Me.lblInwFltCity1 = New System.Windows.Forms.Label
            Me.lblSeqNum = New System.Windows.Forms.Label
            Me.lblSE = New System.Windows.Forms.Label
            Me.lblInwFltCity2 = New System.Windows.Forms.Label
            Me.lblInwFltId = New System.Windows.Forms.Label
            Me.lblON = New System.Windows.Forms.Label
            Me.lblIN = New System.Windows.Forms.Label
            Me.MainMenu2 = New System.Windows.Forms.MainMenu
            Me.lblBagFltId = New System.Windows.Forms.Label
            Me.fraSummary = New OpenNETCF.Windows.Forms.GroupBox
            Me.fraBagtag.SuspendLayout()
            Me.fraSummary.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblBagFltItin
            '
            Me.lblBagFltItin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagFltItin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBagFltItin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagFltItin.Location = New System.Drawing.Point(120, 43)
            Me.lblBagFltItin.Name = "lblBagFltItin"
            Me.lblBagFltItin.Size = New System.Drawing.Size(105, 25)
            Me.lblBagFltItin.Text = "MSPDTW"
            Me.lblBagFltItin.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBagFltTime
            '
            Me.lblBagFltTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagFltTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBagFltTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagFltTime.Location = New System.Drawing.Point(88, 64)
            Me.lblBagFltTime.Name = "lblBagFltTime"
            Me.lblBagFltTime.Size = New System.Drawing.Size(49, 17)
            Me.lblBagFltTime.Text = "8888"
            '
            'lblBagFltGate
            '
            Me.lblBagFltGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagFltGate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBagFltGate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagFltGate.Location = New System.Drawing.Point(168, 64)
            Me.lblBagFltGate.Name = "lblBagFltGate"
            Me.lblBagFltGate.Size = New System.Drawing.Size(49, 17)
            Me.lblBagFltGate.Text = "G88"
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblName.Location = New System.Drawing.Point(3, 154)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(49, 17)
            Me.lblName.Text = "Name"
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPAXName
            '
            Me.lblPAXName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPAXName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblPAXName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPAXName.Location = New System.Drawing.Point(51, 154)
            Me.lblPAXName.Name = "lblPAXName"
            Me.lblPAXName.Size = New System.Drawing.Size(89, 17)
            Me.lblPAXName.Text = "JOHNSON"
            '
            'lblPAXStatus
            '
            Me.lblPAXStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPAXStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPAXStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPAXStatus.Location = New System.Drawing.Point(152, 154)
            Me.lblPAXStatus.Name = "lblPAXStatus"
            Me.lblPAXStatus.Size = New System.Drawing.Size(73, 17)
            Me.lblPAXStatus.Text = "STANDBY"
            Me.lblPAXStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraBagtag
            '
            Me.fraBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraBagtag.Controls.Add(Me.lblScan)
            Me.fraBagtag.Controls.Add(Me.txtBagtag)
            Me.fraBagtag.Location = New System.Drawing.Point(4, 46)
            Me.fraBagtag.Name = "fraBagtag"
            Me.fraBagtag.Size = New System.Drawing.Size(233, 60)
            '
            'lblScan
            '
            Me.lblScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblScan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScan.Location = New System.Drawing.Point(0, 1)
            Me.lblScan.Name = "lblScan"
            Me.lblScan.Size = New System.Drawing.Size(233, 24)
            Me.lblScan.Text = "Scan/Enter Bagtag"
            Me.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 24)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 1
            '
            'lblOnwFltId
            '
            Me.lblOnwFltId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblOnwFltId.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblOnwFltId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblOnwFltId.Location = New System.Drawing.Point(48, 112)
            Me.lblOnwFltId.Name = "lblOnwFltId"
            Me.lblOnwFltId.Size = New System.Drawing.Size(81, 17)
            Me.lblOnwFltId.Text = "NW1543"
            '
            'lblOnwFltCity1
            '
            Me.lblOnwFltCity1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblOnwFltCity1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblOnwFltCity1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblOnwFltCity1.Location = New System.Drawing.Point(128, 111)
            Me.lblOnwFltCity1.Name = "lblOnwFltCity1"
            Me.lblOnwFltCity1.Size = New System.Drawing.Size(49, 25)
            Me.lblOnwFltCity1.Text = "DTW"
            Me.lblOnwFltCity1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblOnwFltCity2
            '
            Me.lblOnwFltCity2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblOnwFltCity2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblOnwFltCity2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblOnwFltCity2.Location = New System.Drawing.Point(184, 111)
            Me.lblOnwFltCity2.Name = "lblOnwFltCity2"
            Me.lblOnwFltCity2.Size = New System.Drawing.Size(41, 25)
            Me.lblOnwFltCity2.Text = "SRQ"
            Me.lblOnwFltCity2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPAX
            '
            Me.lblPAX.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPAX.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblPAX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPAX.Location = New System.Drawing.Point(0, 136)
            Me.lblPAX.Name = "lblPAX"
            Me.lblPAX.Size = New System.Drawing.Size(233, 17)
            Me.lblPAX.Text = "PAX Info"
            Me.lblPAX.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFLINFO
            '
            Me.lblFLINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFLINFO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFLINFO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFLINFO.Location = New System.Drawing.Point(0, -2)
            Me.lblFLINFO.Name = "lblFLINFO"
            Me.lblFLINFO.Size = New System.Drawing.Size(233, 17)
            Me.lblFLINFO.Text = "FLIGHT Info"
            Me.lblFLINFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBagFltDate
            '
            Me.lblBagFltDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagFltDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBagFltDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagFltDate.Location = New System.Drawing.Point(8, 64)
            Me.lblBagFltDate.Name = "lblBagFltDate"
            Me.lblBagFltDate.Size = New System.Drawing.Size(65, 17)
            Me.lblBagFltDate.Text = "01FEB"
            '
            'lblLocation
            '
            Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLocation.Location = New System.Drawing.Point(8, 16)
            Me.lblLocation.Name = "lblLocation"
            Me.lblLocation.Size = New System.Drawing.Size(129, 27)
            Me.lblLocation.Text = "BIN 1"
            '
            'lblInwFltCity1
            '
            Me.lblInwFltCity1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblInwFltCity1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblInwFltCity1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInwFltCity1.Location = New System.Drawing.Point(128, 88)
            Me.lblInwFltCity1.Name = "lblInwFltCity1"
            Me.lblInwFltCity1.Size = New System.Drawing.Size(49, 25)
            Me.lblInwFltCity1.Text = "TUS"
            Me.lblInwFltCity1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblSeqNum
            '
            Me.lblSeqNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSeqNum.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblSeqNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSeqNum.Location = New System.Drawing.Point(184, 16)
            Me.lblSeqNum.Name = "lblSeqNum"
            Me.lblSeqNum.Size = New System.Drawing.Size(41, 25)
            Me.lblSeqNum.Text = "31"
            Me.lblSeqNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSE
            '
            Me.lblSE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSE.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSE.Location = New System.Drawing.Point(144, 16)
            Me.lblSE.Name = "lblSE"
            Me.lblSE.Size = New System.Drawing.Size(41, 25)
            Me.lblSE.Text = "SEQ"
            Me.lblSE.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblInwFltCity2
            '
            Me.lblInwFltCity2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblInwFltCity2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblInwFltCity2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInwFltCity2.Location = New System.Drawing.Point(184, 88)
            Me.lblInwFltCity2.Name = "lblInwFltCity2"
            Me.lblInwFltCity2.Size = New System.Drawing.Size(41, 25)
            Me.lblInwFltCity2.Text = "MSP"
            Me.lblInwFltCity2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblInwFltId
            '
            Me.lblInwFltId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblInwFltId.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblInwFltId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblInwFltId.Location = New System.Drawing.Point(48, 88)
            Me.lblInwFltId.Name = "lblInwFltId"
            Me.lblInwFltId.Size = New System.Drawing.Size(81, 17)
            Me.lblInwFltId.Text = "NW1543"
            '
            'lblON
            '
            Me.lblON.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblON.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblON.Location = New System.Drawing.Point(8, 114)
            Me.lblON.Name = "lblON"
            Me.lblON.Size = New System.Drawing.Size(33, 17)
            Me.lblON.Text = "ONW"
            Me.lblON.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblIN
            '
            Me.lblIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblIN.Location = New System.Drawing.Point(8, 90)
            Me.lblIN.Name = "lblIN"
            Me.lblIN.Size = New System.Drawing.Size(33, 17)
            Me.lblIN.Text = "INW"
            Me.lblIN.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBagFltId
            '
            Me.lblBagFltId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagFltId.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBagFltId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagFltId.Location = New System.Drawing.Point(8, 43)
            Me.lblBagFltId.Name = "lblBagFltId"
            Me.lblBagFltId.Size = New System.Drawing.Size(81, 17)
            Me.lblBagFltId.Text = "NW1543"
            '
            'fraSummary
            '
            Me.fraSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraSummary.Controls.Add(Me.lblSE)
            Me.fraSummary.Controls.Add(Me.lblSeqNum)
            Me.fraSummary.Controls.Add(Me.lblLocation)
            Me.fraSummary.Controls.Add(Me.lblInwFltCity1)
            Me.fraSummary.Controls.Add(Me.lblInwFltCity2)
            Me.fraSummary.Controls.Add(Me.lblInwFltId)
            Me.fraSummary.Controls.Add(Me.lblON)
            Me.fraSummary.Controls.Add(Me.lblIN)
            Me.fraSummary.Controls.Add(Me.lblBagFltId)
            Me.fraSummary.Controls.Add(Me.lblBagFltDate)
            Me.fraSummary.Controls.Add(Me.lblBagFltItin)
            Me.fraSummary.Controls.Add(Me.lblBagFltTime)
            Me.fraSummary.Controls.Add(Me.lblBagFltGate)
            Me.fraSummary.Controls.Add(Me.lblName)
            Me.fraSummary.Controls.Add(Me.lblPAXName)
            Me.fraSummary.Controls.Add(Me.lblPAXStatus)
            Me.fraSummary.Controls.Add(Me.lblOnwFltId)
            Me.fraSummary.Controls.Add(Me.lblOnwFltCity1)
            Me.fraSummary.Controls.Add(Me.lblOnwFltCity2)
            Me.fraSummary.Controls.Add(Me.lblPAX)
            Me.fraSummary.Controls.Add(Me.lblFLINFO)
            Me.fraSummary.Enabled = False
            Me.fraSummary.Location = New System.Drawing.Point(4, 104)
            Me.fraSummary.Name = "fraSummary"
            Me.fraSummary.Size = New System.Drawing.Size(233, 172)
            Me.fraSummary.Visible = False
            '
            'frmBagtagInquiry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraSummary)
            Me.Controls.Add(Me.fraBagtag)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.MinimizeBox = False
            Me.Name = "frmBagtagInquiry"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraBagtag.ResumeLayout(False)
            Me.fraSummary.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblBagFltItin As System.Windows.Forms.Label
        Friend WithEvents lblBagFltTime As System.Windows.Forms.Label
        Friend WithEvents lblBagFltGate As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents lblPAXName As System.Windows.Forms.Label
        Friend WithEvents lblPAXStatus As System.Windows.Forms.Label
        Friend WithEvents fraBagtag As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblScan As System.Windows.Forms.Label
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents lblOnwFltId As System.Windows.Forms.Label
        Friend WithEvents lblOnwFltCity1 As System.Windows.Forms.Label
        Friend WithEvents lblOnwFltCity2 As System.Windows.Forms.Label
        Friend WithEvents lblPAX As System.Windows.Forms.Label
        Friend WithEvents lblFLINFO As System.Windows.Forms.Label
        Friend WithEvents lblBagFltDate As System.Windows.Forms.Label
        Friend WithEvents lblLocation As System.Windows.Forms.Label
        Friend WithEvents lblInwFltCity1 As System.Windows.Forms.Label
        Friend WithEvents lblSeqNum As System.Windows.Forms.Label
        Friend WithEvents lblSE As System.Windows.Forms.Label
        Friend WithEvents lblInwFltCity2 As System.Windows.Forms.Label
        Friend WithEvents lblInwFltId As System.Windows.Forms.Label
        Friend WithEvents lblON As System.Windows.Forms.Label
        Friend WithEvents lblIN As System.Windows.Forms.Label
        Private WithEvents MainMenu2 As System.Windows.Forms.MainMenu
        Friend WithEvents lblBagFltId As System.Windows.Forms.Label
        Friend WithEvents fraSummary As OpenNETCF.Windows.Forms.GroupBox
    End Class
End Namespace