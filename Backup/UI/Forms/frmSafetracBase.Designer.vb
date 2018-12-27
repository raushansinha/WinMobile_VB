
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Hardware

Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Public Class frmSafetracBase
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)

            If _objFlightsCollection IsNot Nothing Then
                _objFlightsCollection = Nothing
            End If

            If _objSafetracScanner IsNot Nothing Then
                _objSafetracScanner = Nothing
            End If

            If _objScanner IsNot Nothing Then
                _objScanner = Nothing
            End If

        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.lblRF = New System.Windows.Forms.Label
            Me.lblTrainingOn = New System.Windows.Forms.Label
            Me.lblKeyAlpha = New System.Windows.Forms.Label
            Me.lblKeyNum = New System.Windows.Forms.Label
            Me.lblFooter = New System.Windows.Forms.Label
            Me.lblSingleHeader = New System.Windows.Forms.Label
            Me.pnlDualHeader = New System.Windows.Forms.Panel
            Me.lblMultiHeader2 = New System.Windows.Forms.Label
            Me.lblMultiHeader1 = New System.Windows.Forms.Label
            Me.pnlStatus = New System.Windows.Forms.Panel
            Me.batteryLife = New OpenNETCF.Windows.Forms.BatteryLife
            Me.pnlSingleHeader = New System.Windows.Forms.Panel
            Me.tmrAutoLogoff = New System.Windows.Forms.Timer
            Me.pnlDualHeader.SuspendLayout()
            Me.pnlStatus.SuspendLayout()
            Me.pnlSingleHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblRF
            '
            Me.lblRF.BackColor = System.Drawing.Color.White
            Me.lblRF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblRF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRF.Location = New System.Drawing.Point(155, 3)
            Me.lblRF.Name = "lblRF"
            Me.lblRF.Size = New System.Drawing.Size(47, 20)
            Me.lblRF.Text = "NA%"
            Me.lblRF.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTrainingOn
            '
            Me.lblTrainingOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTrainingOn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTrainingOn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTrainingOn.Location = New System.Drawing.Point(92, 3)
            Me.lblTrainingOn.Name = "lblTrainingOn"
            Me.lblTrainingOn.Size = New System.Drawing.Size(64, 20)
            Me.lblTrainingOn.Text = "[TRAIN]"
            Me.lblTrainingOn.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblKeyAlpha
            '
            Me.lblKeyAlpha.BackColor = System.Drawing.Color.White
            Me.lblKeyAlpha.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.lblKeyAlpha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblKeyAlpha.Location = New System.Drawing.Point(198, 3)
            Me.lblKeyAlpha.Name = "lblKeyAlpha"
            Me.lblKeyAlpha.Size = New System.Drawing.Size(20, 18)
            Me.lblKeyAlpha.Text = "A"
            Me.lblKeyAlpha.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblKeyAlpha.Visible = False
            '
            'lblKeyNum
            '
            Me.lblKeyNum.BackColor = System.Drawing.Color.White
            Me.lblKeyNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblKeyNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblKeyNum.Location = New System.Drawing.Point(216, 3)
            Me.lblKeyNum.Name = "lblKeyNum"
            Me.lblKeyNum.Size = New System.Drawing.Size(20, 18)
            Me.lblKeyNum.Text = "1"
            Me.lblKeyNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblKeyNum.Visible = False
            '
            'lblFooter
            '
            Me.lblFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFooter.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFooter.Location = New System.Drawing.Point(0, 274)
            Me.lblFooter.Name = "lblFooter"
            Me.lblFooter.Size = New System.Drawing.Size(240, 26)
            Me.lblFooter.Text = "Footer"
            Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSingleHeader
            '
            Me.lblSingleHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSingleHeader.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblSingleHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSingleHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblSingleHeader.Name = "lblSingleHeader"
            Me.lblSingleHeader.Size = New System.Drawing.Size(240, 26)
            Me.lblSingleHeader.Text = "Header"
            Me.lblSingleHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlDualHeader
            '
            Me.pnlDualHeader.Controls.Add(Me.lblMultiHeader2)
            Me.pnlDualHeader.Controls.Add(Me.lblMultiHeader1)
            Me.pnlDualHeader.Location = New System.Drawing.Point(-1, -1)
            Me.pnlDualHeader.Name = "pnlDualHeader"
            Me.pnlDualHeader.Size = New System.Drawing.Size(244, 28)
            Me.pnlDualHeader.Visible = False
            '
            'lblMultiHeader2
            '
            Me.lblMultiHeader2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblMultiHeader2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblMultiHeader2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblMultiHeader2.Location = New System.Drawing.Point(96, 0)
            Me.lblMultiHeader2.Name = "lblMultiHeader2"
            Me.lblMultiHeader2.Size = New System.Drawing.Size(145, 28)
            Me.lblMultiHeader2.Text = "MH 2"
            Me.lblMultiHeader2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblMultiHeader1
            '
            Me.lblMultiHeader1.BackColor = System.Drawing.Color.White
            Me.lblMultiHeader1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblMultiHeader1.ForeColor = System.Drawing.Color.Black
            Me.lblMultiHeader1.Location = New System.Drawing.Point(3, 0)
            Me.lblMultiHeader1.Name = "lblMultiHeader1"
            Me.lblMultiHeader1.Size = New System.Drawing.Size(99, 28)
            Me.lblMultiHeader1.Text = "MH 1"
            Me.lblMultiHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlStatus
            '
            Me.pnlStatus.BackColor = System.Drawing.Color.White
            Me.pnlStatus.Controls.Add(Me.batteryLife)
            Me.pnlStatus.Controls.Add(Me.lblTrainingOn)
            Me.pnlStatus.Controls.Add(Me.lblRF)
            Me.pnlStatus.Controls.Add(Me.lblKeyNum)
            Me.pnlStatus.Controls.Add(Me.lblKeyAlpha)
            Me.pnlStatus.Location = New System.Drawing.Point(1, 23)
            Me.pnlStatus.Name = "pnlStatus"
            Me.pnlStatus.Size = New System.Drawing.Size(239, 22)
            '
            'batteryLife
            '
            Me.batteryLife.BackColor = System.Drawing.Color.White
            Me.batteryLife.Location = New System.Drawing.Point(8, 5)
            Me.batteryLife.Name = "batteryLife"
            Me.batteryLife.Size = New System.Drawing.Size(50, 14)
            Me.batteryLife.TabIndex = 4
            Me.batteryLife.Text = "BatteryLife1"
            '
            'pnlSingleHeader
            '
            Me.pnlSingleHeader.Controls.Add(Me.lblSingleHeader)
            Me.pnlSingleHeader.Location = New System.Drawing.Point(1, 0)
            Me.pnlSingleHeader.Name = "pnlSingleHeader"
            Me.pnlSingleHeader.Size = New System.Drawing.Size(240, 26)
            '
            'tmrAutoLogoff
            '
            Me.tmrAutoLogoff.Interval = 1000
            '
            'frmSafetracBase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlSingleHeader)
            Me.Controls.Add(Me.lblFooter)
            Me.Controls.Add(Me.pnlStatus)
            Me.Controls.Add(Me.pnlDualHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.MinimizeBox = False
            Me.Name = "frmSafetracBase"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.pnlDualHeader.ResumeLayout(False)
            Me.pnlStatus.ResumeLayout(False)
            Me.pnlSingleHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents lblRF As System.Windows.Forms.Label
        Private WithEvents lblTrainingOn As System.Windows.Forms.Label
        Private WithEvents lblKeyAlpha As System.Windows.Forms.Label
        Private WithEvents lblKeyNum As System.Windows.Forms.Label
        Private WithEvents lblFooter As System.Windows.Forms.Label
        Private WithEvents lblSingleHeader As System.Windows.Forms.Label
        Private WithEvents pnlDualHeader As System.Windows.Forms.Panel
        Private WithEvents lblMultiHeader2 As System.Windows.Forms.Label
        Private WithEvents lblMultiHeader1 As System.Windows.Forms.Label
        Private WithEvents pnlStatus As System.Windows.Forms.Panel
        Private WithEvents batteryLife As OpenNETCF.Windows.Forms.BatteryLife
        Private WithEvents pnlSingleHeader As System.Windows.Forms.Panel
        Private WithEvents tmrAutoLogoff As System.Windows.Forms.Timer

        'Private Variables
        Private _objFlightsCollection As FlightsCollection
        Private WithEvents _objSafetracScanner As Psion7535
        Private _objScanner As BO.Scanner

    End Class
End Namespace
