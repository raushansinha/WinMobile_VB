
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmViewBagsToUnload
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
            Me.lblDateTitle = New System.Windows.Forms.Label
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.tvResults = New System.Windows.Forms.TreeView
            Me.lblHoldULDTitle = New System.Windows.Forms.Label
            Me.btnExit = New System.Windows.Forms.Button
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblFlightTitle = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.fraDispParms = New OpenNETCF.Windows.Forms.GroupBox
            Me.fraDispParms.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblDateTitle
            '
            Me.lblDateTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDateTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDateTitle.Location = New System.Drawing.Point(128, 2)
            Me.lblDateTitle.Name = "lblDateTitle"
            Me.lblDateTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblDateTitle.Text = "Date"
            Me.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'tvResults
            '
            Me.tvResults.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.tvResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.tvResults.Location = New System.Drawing.Point(0, 104)
            Me.tvResults.Name = "tvResults"
            Me.tvResults.Size = New System.Drawing.Size(233, 145)
            Me.tvResults.TabIndex = 0
            '
            'lblHoldULDTitle
            '
            Me.lblHoldULDTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHoldULDTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblHoldULDTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHoldULDTitle.Location = New System.Drawing.Point(0, 88)
            Me.lblHoldULDTitle.Name = "lblHoldULDTitle"
            Me.lblHoldULDTitle.Size = New System.Drawing.Size(189, 17)
            Me.lblHoldULDTitle.Text = "HOLD/ULD - Bagtag/Seq"
            '
            'btnExit
            '
            Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnExit.Location = New System.Drawing.Point(0, 248)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(233, 28)
            Me.btnExit.TabIndex = 9
            Me.btnExit.Text = "EXIT: ESC"
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(40, 18)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblFlight.Text = "NW8888"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightTitle
            '
            Me.lblFlightTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlightTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightTitle.Location = New System.Drawing.Point(48, 2)
            Me.lblFlightTitle.Name = "lblFlightTitle"
            Me.lblFlightTitle.Size = New System.Drawing.Size(57, 17)
            Me.lblFlightTitle.Text = "Flight"
            Me.lblFlightTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(119, 18)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(73, 17)
            Me.lblDate.Text = "XXXXX"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraDispParms
            '
            Me.fraDispParms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraDispParms.Controls.Add(Me.lblDate)
            Me.fraDispParms.Controls.Add(Me.lblFlightTitle)
            Me.fraDispParms.Controls.Add(Me.lblDateTitle)
            Me.fraDispParms.Controls.Add(Me.lblFlight)
            Me.fraDispParms.Location = New System.Drawing.Point(4, 48)
            Me.fraDispParms.Name = "fraDispParms"
            Me.fraDispParms.Size = New System.Drawing.Size(233, 37)
            '
            'frmViewBagsToUnload
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 294)
            Me.ControlBox = False
            Me.Controls.Add(Me.tvResults)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.lblHoldULDTitle)
            Me.Controls.Add(Me.fraDispParms)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmViewBagsToUnload"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraDispParms.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tvResults As System.Windows.Forms.TreeView
        Friend WithEvents lblHoldULDTitle As System.Windows.Forms.Label
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblFlightTitle As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents fraDispParms As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblDateTitle As System.Windows.Forms.Label
    End Class

End Namespace