
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmViewBagsToGo
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
            Me.cmdExit = New System.Windows.Forms.Button
            Me.fraDispParms = New OpenNETCF.Windows.Forms.GroupBox
            Me.lbl4 = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblTime = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lbl3 = New System.Windows.Forms.Label
            Me.lblTimeHeader = New System.Windows.Forms.Label
            Me.lbl8 = New System.Windows.Forms.Label
            Me.lblSortMode = New System.Windows.Forms.Label
            Me.lblXferCount = New System.Windows.Forms.Label
            Me.lblStatusHeader = New System.Windows.Forms.Label
            Me.lblXferLocalCount = New System.Windows.Forms.Label
            Me.lblDestHeader = New System.Windows.Forms.Label
            Me.fraResults = New OpenNETCF.Windows.Forms.GroupBox
            Me.tvBagsToGo = New System.Windows.Forms.TreeView
            Me.lbl2 = New System.Windows.Forms.Label
            Me.fraSort = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnSortDest = New System.Windows.Forms.Button
            Me.btnSortXFER = New System.Windows.Forms.Button
            Me.btnSortStatus = New System.Windows.Forms.Button
            Me.fraDispParms.SuspendLayout()
            Me.fraResults.SuspendLayout()
            Me.fraSort.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmdExit
            '
            Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.cmdExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdExit.Location = New System.Drawing.Point(0, 277)
            Me.cmdExit.Name = "cmdExit"
            Me.cmdExit.Size = New System.Drawing.Size(238, 28)
            Me.cmdExit.TabIndex = 5
            Me.cmdExit.Text = "EXIT: TAB, then ESC"
            '
            'fraDispParms
            '
            Me.fraDispParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraDispParms.Controls.Add(Me.lbl4)
            Me.fraDispParms.Controls.Add(Me.lblDate)
            Me.fraDispParms.Controls.Add(Me.lblTime)
            Me.fraDispParms.Controls.Add(Me.lblFlight)
            Me.fraDispParms.Controls.Add(Me.lbl3)
            Me.fraDispParms.Controls.Add(Me.lblTimeHeader)
            Me.fraDispParms.Location = New System.Drawing.Point(0, 56)
            Me.fraDispParms.Name = "fraDispParms"
            Me.fraDispParms.Size = New System.Drawing.Size(238, 36)
            '
            'lbl4
            '
            Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl4.Location = New System.Drawing.Point(96, 0)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(57, 17)
            Me.lbl4.Text = "Date"
            Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(88, 16)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(73, 17)
            Me.lblDate.Text = "88WWW"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTime
            '
            Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTime.Location = New System.Drawing.Point(168, 16)
            Me.lblTime.Name = "lblTime"
            Me.lblTime.Size = New System.Drawing.Size(57, 17)
            Me.lblTime.Text = "E2222"
            Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(8, 16)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblFlight.Text = "NW8888"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl3
            '
            Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl3.Location = New System.Drawing.Point(16, 0)
            Me.lbl3.Name = "lbl3"
            Me.lbl3.Size = New System.Drawing.Size(57, 17)
            Me.lbl3.Text = "Flight"
            Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTimeHeader
            '
            Me.lblTimeHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTimeHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTimeHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTimeHeader.Location = New System.Drawing.Point(168, 0)
            Me.lblTimeHeader.Name = "lblTimeHeader"
            Me.lblTimeHeader.Size = New System.Drawing.Size(57, 17)
            Me.lblTimeHeader.Text = "Time"
            Me.lblTimeHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl8
            '
            Me.lbl8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lbl8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl8.Location = New System.Drawing.Point(0, 0)
            Me.lbl8.Name = "lbl8"
            Me.lbl8.Size = New System.Drawing.Size(137, 17)
            Me.lbl8.Text = "SORTED BY - "
            Me.lbl8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblSortMode
            '
            Me.lblSortMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSortMode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblSortMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSortMode.Location = New System.Drawing.Point(137, -1)
            Me.lblSortMode.Name = "lblSortMode"
            Me.lblSortMode.Size = New System.Drawing.Size(100, 17)
            Me.lblSortMode.Text = "DEST"
            '
            'lblXferCount
            '
            Me.lblXferCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblXferCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblXferCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblXferCount.Location = New System.Drawing.Point(2, 16)
            Me.lblXferCount.Name = "lblXferCount"
            Me.lblXferCount.Size = New System.Drawing.Size(71, 17)
            Me.lblXferCount.Text = "XFER: "
            Me.lblXferCount.Visible = False
            '
            'lblStatusHeader
            '
            Me.lblStatusHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStatusHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblStatusHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStatusHeader.Location = New System.Drawing.Point(72, 16)
            Me.lblStatusHeader.Name = "lblStatusHeader"
            Me.lblStatusHeader.Size = New System.Drawing.Size(89, 17)
            Me.lblStatusHeader.Text = "TG  LCL  IN"
            '
            'lblXferLocalCount
            '
            Me.lblXferLocalCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblXferLocalCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblXferLocalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblXferLocalCount.Location = New System.Drawing.Point(80, 16)
            Me.lblXferLocalCount.Name = "lblXferLocalCount"
            Me.lblXferLocalCount.Size = New System.Drawing.Size(89, 17)
            Me.lblXferLocalCount.Text = "LOCAL: "
            '
            'lblDestHeader
            '
            Me.lblDestHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDestHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDestHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDestHeader.Location = New System.Drawing.Point(67, 17)
            Me.lblDestHeader.Name = "lblDestHeader"
            Me.lblDestHeader.Size = New System.Drawing.Size(153, 16)
            Me.lblDestHeader.Text = "TG  LCL IN  UN"
            '
            'fraResults
            '
            Me.fraResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraResults.Controls.Add(Me.tvBagsToGo)
            Me.fraResults.Controls.Add(Me.lblDestHeader)
            Me.fraResults.Controls.Add(Me.lblXferLocalCount)
            Me.fraResults.Controls.Add(Me.lblStatusHeader)
            Me.fraResults.Controls.Add(Me.lblXferCount)
            Me.fraResults.Controls.Add(Me.lblSortMode)
            Me.fraResults.Controls.Add(Me.lbl8)
            Me.fraResults.Location = New System.Drawing.Point(0, 92)
            Me.fraResults.Name = "fraResults"
            Me.fraResults.Size = New System.Drawing.Size(238, 120)
            '
            'tvBagsToGo
            '
            Me.tvBagsToGo.Location = New System.Drawing.Point(0, 36)
            Me.tvBagsToGo.Name = "tvBagsToGo"
            Me.tvBagsToGo.Size = New System.Drawing.Size(237, 84)
            Me.tvBagsToGo.TabIndex = 7
            '
            'lbl2
            '
            Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl2.Location = New System.Drawing.Point(0, 0)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(238, 17)
            Me.lbl2.Text = "SORT OPTIONS"
            Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraSort
            '
            Me.fraSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraSort.Controls.Add(Me.btnSortDest)
            Me.fraSort.Controls.Add(Me.lbl2)
            Me.fraSort.Controls.Add(Me.btnSortXFER)
            Me.fraSort.Controls.Add(Me.btnSortStatus)
            Me.fraSort.Location = New System.Drawing.Point(0, 215)
            Me.fraSort.Name = "fraSort"
            Me.fraSort.Size = New System.Drawing.Size(238, 61)
            '
            'btnSortDest
            '
            Me.btnSortDest.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSortDest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.btnSortDest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSortDest.Location = New System.Drawing.Point(8, 21)
            Me.btnSortDest.Name = "btnSortDest"
            Me.btnSortDest.Size = New System.Drawing.Size(65, 33)
            Me.btnSortDest.TabIndex = 0
            Me.btnSortDest.Text = "By Dest"
            '
            'btnSortXFER
            '
            Me.btnSortXFER.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSortXFER.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.btnSortXFER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSortXFER.Location = New System.Drawing.Point(85, 21)
            Me.btnSortXFER.Name = "btnSortXFER"
            Me.btnSortXFER.Size = New System.Drawing.Size(65, 33)
            Me.btnSortXFER.TabIndex = 2
            Me.btnSortXFER.Text = "By XFER"
            '
            'btnSortStatus
            '
            Me.btnSortStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSortStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.btnSortStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSortStatus.Location = New System.Drawing.Point(160, 21)
            Me.btnSortStatus.Name = "btnSortStatus"
            Me.btnSortStatus.Size = New System.Drawing.Size(65, 33)
            Me.btnSortStatus.TabIndex = 3
            Me.btnSortStatus.Text = "By Status"
            '
            'frmViewBagsToGo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraDispParms)
            Me.Controls.Add(Me.fraSort)
            Me.Controls.Add(Me.cmdExit)
            Me.Controls.Add(Me.fraResults)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmViewBagsToGo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraDispParms.ResumeLayout(False)
            Me.fraResults.ResumeLayout(False)
            Me.fraSort.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cmdExit As System.Windows.Forms.Button
        Friend WithEvents fraDispParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblTime As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lbl3 As System.Windows.Forms.Label
        Friend WithEvents lblTimeHeader As System.Windows.Forms.Label
        Friend WithEvents lbl8 As System.Windows.Forms.Label
        Friend WithEvents lblSortMode As System.Windows.Forms.Label
        Friend WithEvents lblXferCount As System.Windows.Forms.Label
        Friend WithEvents lblStatusHeader As System.Windows.Forms.Label
        Friend WithEvents lblXferLocalCount As System.Windows.Forms.Label
        Friend WithEvents lblDestHeader As System.Windows.Forms.Label
        Friend WithEvents fraResults As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents fraSort As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnSortDest As System.Windows.Forms.Button
        Friend WithEvents btnSortXFER As System.Windows.Forms.Button
        Friend WithEvents btnSortStatus As System.Windows.Forms.Button
        Friend WithEvents tvBagsToGo As System.Windows.Forms.TreeView
    End Class

End Namespace