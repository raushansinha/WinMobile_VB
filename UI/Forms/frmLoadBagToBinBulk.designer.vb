Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLoadBagToBinBulk
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
            Me.fraScanTo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblLocation = New System.Windows.Forms.Label
            Me.lblCurrentHold = New System.Windows.Forms.Label
            Me.lblCurrentFlt = New System.Windows.Forms.Label
            Me.lblCurrentFltDate = New System.Windows.Forms.Label
            Me.fraScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtBagtag = New System.Windows.Forms.TextBox
            Me.lblScanBagtag = New System.Windows.Forms.Label
            Me.btnSetMode = New System.Windows.Forms.Button
            Me.fraAlwaysExp = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblExpCode = New System.Windows.Forms.Label
            Me.lblExpTitle = New System.Windows.Forms.Label
            Me.lblAlwaysExpCode = New System.Windows.Forms.Label
            Me.fraScanTo.SuspendLayout()
            Me.fraScan.SuspendLayout()
            Me.fraAlwaysExp.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraScanTo
            '
            Me.fraScanTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScanTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.fraScanTo.Controls.Add(Me.lblDate)
            Me.fraScanTo.Controls.Add(Me.lblFlight)
            Me.fraScanTo.Controls.Add(Me.lblLocation)
            Me.fraScanTo.Controls.Add(Me.lblCurrentHold)
            Me.fraScanTo.Controls.Add(Me.lblCurrentFlt)
            Me.fraScanTo.Controls.Add(Me.lblCurrentFltDate)
            Me.fraScanTo.Location = New System.Drawing.Point(4, 120)
            Me.fraScanTo.Name = "fraScanTo"
            Me.fraScanTo.Size = New System.Drawing.Size(161, 121)
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(32, 79)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(89, 17)
            Me.lblDate.Text = "Date"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(38, 38)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblFlight.Text = "Flight"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblLocation
            '
            Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLocation.Location = New System.Drawing.Point(32, -1)
            Me.lblLocation.Name = "lblLocation"
            Me.lblLocation.Size = New System.Drawing.Size(89, 17)
            Me.lblLocation.Text = "Location"
            Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentHold
            '
            Me.lblCurrentHold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentHold.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentHold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentHold.Location = New System.Drawing.Point(32, 16)
            Me.lblCurrentHold.Name = "lblCurrentHold"
            Me.lblCurrentHold.Size = New System.Drawing.Size(89, 22)
            Me.lblCurrentHold.Text = "BULK 54"
            Me.lblCurrentHold.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentFlt
            '
            Me.lblCurrentFlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentFlt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentFlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentFlt.Location = New System.Drawing.Point(32, 56)
            Me.lblCurrentFlt.Name = "lblCurrentFlt"
            Me.lblCurrentFlt.Size = New System.Drawing.Size(89, 25)
            Me.lblCurrentFlt.Text = "NW1543"
            Me.lblCurrentFlt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCurrentFltDate
            '
            Me.lblCurrentFltDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCurrentFltDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCurrentFltDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCurrentFltDate.Location = New System.Drawing.Point(32, 96)
            Me.lblCurrentFltDate.Name = "lblCurrentFltDate"
            Me.lblCurrentFltDate.Size = New System.Drawing.Size(89, 20)
            Me.lblCurrentFltDate.Text = "20FEB"
            Me.lblCurrentFltDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraScan
            '
            Me.fraScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScan.Controls.Add(Me.txtBagtag)
            Me.fraScan.Controls.Add(Me.lblScanBagtag)
            Me.fraScan.Location = New System.Drawing.Point(4, 48)
            Me.fraScan.Name = "fraScan"
            Me.fraScan.Size = New System.Drawing.Size(233, 65)
            '
            'txtBagtag
            '
            Me.txtBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtBagtag.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtBagtag.Location = New System.Drawing.Point(32, 27)
            Me.txtBagtag.MaxLength = 10
            Me.txtBagtag.Name = "txtBagtag"
            Me.txtBagtag.Size = New System.Drawing.Size(169, 32)
            Me.txtBagtag.TabIndex = 0
            '
            'lblScanBagtag
            '
            Me.lblScanBagtag.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScanBagtag.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblScanBagtag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScanBagtag.Location = New System.Drawing.Point(0, 0)
            Me.lblScanBagtag.Name = "lblScanBagtag"
            Me.lblScanBagtag.Size = New System.Drawing.Size(233, 24)
            Me.lblScanBagtag.Text = "Scan/Enter Bagtag"
            Me.lblScanBagtag.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnSetMode
            '
            Me.btnSetMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSetMode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.btnSetMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSetMode.Location = New System.Drawing.Point(169, 187)
            Me.btnSetMode.Name = "btnSetMode"
            Me.btnSetMode.Size = New System.Drawing.Size(68, 54)
            Me.btnSetMode.TabIndex = 1
            Me.btnSetMode.Text = "SET SCAN "
            '
            'fraAlwaysExp
            '
            Me.fraAlwaysExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraAlwaysExp.Controls.Add(Me.lblExpCode)
            Me.fraAlwaysExp.Controls.Add(Me.lblExpTitle)
            Me.fraAlwaysExp.Controls.Add(Me.lblAlwaysExpCode)
            Me.fraAlwaysExp.Location = New System.Drawing.Point(167, 120)
            Me.fraAlwaysExp.Name = "fraAlwaysExp"
            Me.fraAlwaysExp.Size = New System.Drawing.Size(70, 40)
            '
            'lblExpCode
            '
            Me.lblExpCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblExpCode.Location = New System.Drawing.Point(16, 16)
            Me.lblExpCode.Name = "lblExpCode"
            Me.lblExpCode.Size = New System.Drawing.Size(36, 22)
            Me.lblExpCode.Text = "Label1"
            Me.lblExpCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblExpTitle
            '
            Me.lblExpTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblExpTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblExpTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblExpTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblExpTitle.Name = "lblExpTitle"
            Me.lblExpTitle.Size = New System.Drawing.Size(73, 16)
            Me.lblExpTitle.Text = "EXP Code"
            Me.lblExpTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblAlwaysExpCode
            '
            Me.lblAlwaysExpCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblAlwaysExpCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblAlwaysExpCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAlwaysExpCode.Location = New System.Drawing.Point(-232, 120)
            Me.lblAlwaysExpCode.Name = "lblAlwaysExpCode"
            Me.lblAlwaysExpCode.Size = New System.Drawing.Size(57, 22)
            Me.lblAlwaysExpCode.Text = "G"
            Me.lblAlwaysExpCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmLoadBagToBinBulk
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraScanTo)
            Me.Controls.Add(Me.fraScan)
            Me.Controls.Add(Me.btnSetMode)
            Me.Controls.Add(Me.fraAlwaysExp)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLoadBagToBinBulk"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraScanTo.ResumeLayout(False)
            Me.fraScan.ResumeLayout(False)
            Me.fraAlwaysExp.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraScanTo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblLocation As System.Windows.Forms.Label
        Friend WithEvents lblCurrentHold As System.Windows.Forms.Label
        Friend WithEvents lblCurrentFlt As System.Windows.Forms.Label
        Friend WithEvents lblCurrentFltDate As System.Windows.Forms.Label
        Friend WithEvents fraScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtBagtag As System.Windows.Forms.TextBox
        Friend WithEvents lblScanBagtag As System.Windows.Forms.Label
        Friend WithEvents btnSetMode As System.Windows.Forms.Button
        Friend WithEvents fraAlwaysExp As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblAlwaysExpCode As System.Windows.Forms.Label
        Friend WithEvents lblExpTitle As System.Windows.Forms.Label
        Friend WithEvents lblExpCode As System.Windows.Forms.Label
    End Class
End Namespace
