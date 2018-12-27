Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgHelpdesk
        Inherits System.Windows.Forms.Form

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
            Me.fraInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdHideReport = New System.Windows.Forms.Button
            Me.lblFunction = New System.Windows.Forms.Label
            Me.lblIP = New System.Windows.Forms.Label
            Me.lblHHT = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.fraInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraInfo
            '
            Me.fraInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraInfo.Controls.Add(Me.cmdHideReport)
            Me.fraInfo.Controls.Add(Me.lblFunction)
            Me.fraInfo.Controls.Add(Me.lblIP)
            Me.fraInfo.Controls.Add(Me.lblHHT)
            Me.fraInfo.Controls.Add(Me.Label12)
            Me.fraInfo.Controls.Add(Me.Label11)
            Me.fraInfo.Controls.Add(Me.Label4)
            Me.fraInfo.Controls.Add(Me.Label10)
            Me.fraInfo.Controls.Add(Me.Label9)
            Me.fraInfo.Controls.Add(Me.Label8)
            Me.fraInfo.Controls.Add(Me.Label7)
            Me.fraInfo.Controls.Add(Me.Label6)
            Me.fraInfo.Controls.Add(Me.Label5)
            Me.fraInfo.Location = New System.Drawing.Point(4, 32)
            Me.fraInfo.Name = "fraInfo"
            Me.fraInfo.Size = New System.Drawing.Size(233, 265)
            '
            'cmdHideReport
            '
            Me.cmdHideReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdHideReport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.cmdHideReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdHideReport.Location = New System.Drawing.Point(0, 232)
            Me.cmdHideReport.Name = "cmdHideReport"
            Me.cmdHideReport.Size = New System.Drawing.Size(233, 33)
            Me.cmdHideReport.TabIndex = 0
            Me.cmdHideReport.Text = "OK"
            '
            'lblFunction
            '
            Me.lblFunction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFunction.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFunction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFunction.Location = New System.Drawing.Point(104, 128)
            Me.lblFunction.Name = "lblFunction"
            Me.lblFunction.Size = New System.Drawing.Size(89, 17)
            Me.lblFunction.Text = "888 - 888"
            '
            'lblIP
            '
            Me.lblIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblIP.Location = New System.Drawing.Point(104, 104)
            Me.lblIP.Name = "lblIP"
            Me.lblIP.Size = New System.Drawing.Size(121, 17)
            Me.lblIP.Text = "888.888.888.888"
            '
            'lblHHT
            '
            Me.lblHHT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHHT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblHHT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHHT.Location = New System.Drawing.Point(104, 80)
            Me.lblHHT.Name = "lblHHT"
            Me.lblHHT.Size = New System.Drawing.Size(65, 17)
            Me.lblHHT.Text = "HHT 888"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(8, 152)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(217, 37)
            Me.Label12.Text = "Please include the error reported before this screen."
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(8, 128)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(81, 17)
            Me.Label11.Text = "FUNCTION:"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(0, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(233, 25)
            Me.Label4.Text = "Helpdesk Info"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(24, 104)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(65, 17)
            Me.Label10.Text = "IP:"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(24, 80)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 17)
            Me.Label9.Text = "HHT ID:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(8, 216)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(105, 17)
            Me.Label8.Text = "612-726-6955"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(120, 216)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(105, 17)
            Me.Label7.Text = "800-328-2283"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 192)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(217, 25)
            Me.Label6.Text = "NWA Help Desk"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(8, 24)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(217, 49)
            Me.Label5.Text = "To report a problem with this scanner, call the helpdesk with the following infor" & _
                "mation:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(3, 4)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(234, 25)
            Me.lblTitle.Text = "ERROR TYPE"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgHelpdesk
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraInfo)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.Name = "dlgHelpdesk"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraInfo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdHideReport As System.Windows.Forms.Button
        Friend WithEvents lblFunction As System.Windows.Forms.Label
        Friend WithEvents lblIP As System.Windows.Forms.Label
        Friend WithEvents lblHHT As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class

End Namespace