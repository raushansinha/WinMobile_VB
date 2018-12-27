Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmViewHTTInformation
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
            Me.fraHHTInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblFullName = New System.Windows.Forms.Label
            Me.lblIP = New System.Windows.Forms.Label
            Me.lblUser = New System.Windows.Forms.Label
            Me.lblHHT = New System.Windows.Forms.Label
            Me.lblIpAdd = New System.Windows.Forms.Label
            Me.lblUserNo = New System.Windows.Forms.Label
            Me.lblHHTI = New System.Windows.Forms.Label
            Me.fraCityInfo = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblBacklightTime = New System.Windows.Forms.Label
            Me.lblTimeTitle = New System.Windows.Forms.Label
            Me.lblTraining = New System.Windows.Forms.Label
            Me.lblCity = New System.Windows.Forms.Label
            Me.lblTrgModeTitle = New System.Windows.Forms.Label
            Me.lblCityCodeTitle = New System.Windows.Forms.Label
            Me.cmdSetBacklight = New System.Windows.Forms.Button
            Me.lblVersion = New System.Windows.Forms.Label
            Me.lblHHTSftVer = New System.Windows.Forms.Label
            Me.fraHHTInfo.SuspendLayout()
            Me.fraCityInfo.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraHHTInfo
            '
            Me.fraHHTInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraHHTInfo.Controls.Add(Me.lblFullName)
            Me.fraHHTInfo.Controls.Add(Me.lblIP)
            Me.fraHHTInfo.Controls.Add(Me.lblUser)
            Me.fraHHTInfo.Controls.Add(Me.lblHHT)
            Me.fraHHTInfo.Controls.Add(Me.lblIpAdd)
            Me.fraHHTInfo.Controls.Add(Me.lblUserNo)
            Me.fraHHTInfo.Controls.Add(Me.lblHHTI)
            Me.fraHHTInfo.Location = New System.Drawing.Point(0, 56)
            Me.fraHHTInfo.Name = "fraHHTInfo"
            Me.fraHHTInfo.Size = New System.Drawing.Size(234, 91)
            '
            'lblFullName
            '
            Me.lblFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFullName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFullName.Location = New System.Drawing.Point(8, 53)
            Me.lblFullName.Name = "lblFullName"
            Me.lblFullName.Size = New System.Drawing.Size(217, 17)
            Me.lblFullName.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
            Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblIP
            '
            Me.lblIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblIP.Location = New System.Drawing.Point(96, 70)
            Me.lblIP.Name = "lblIP"
            Me.lblIP.Size = New System.Drawing.Size(129, 16)
            Me.lblIP.Text = "555.555.555.555"
            '
            'lblUser
            '
            Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblUser.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblUser.Location = New System.Drawing.Point(103, 28)
            Me.lblUser.Name = "lblUser"
            Me.lblUser.Size = New System.Drawing.Size(89, 25)
            Me.lblUser.Text = "A88888"
            '
            'lblHHT
            '
            Me.lblHHT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHHT.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.lblHHT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHHT.Location = New System.Drawing.Point(96, 5)
            Me.lblHHT.Name = "lblHHT"
            Me.lblHHT.Size = New System.Drawing.Size(97, 23)
            Me.lblHHT.Text = "HHT888"
            '
            'lblIpAdd
            '
            Me.lblIpAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblIpAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblIpAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblIpAdd.Location = New System.Drawing.Point(8, 70)
            Me.lblIpAdd.Name = "lblIpAdd"
            Me.lblIpAdd.Size = New System.Drawing.Size(73, 16)
            Me.lblIpAdd.Text = "IP Addr"
            Me.lblIpAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblUserNo
            '
            Me.lblUserNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblUserNo.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblUserNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblUserNo.Location = New System.Drawing.Point(8, 28)
            Me.lblUserNo.Name = "lblUserNo"
            Me.lblUserNo.Size = New System.Drawing.Size(73, 25)
            Me.lblUserNo.Text = "User"
            Me.lblUserNo.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblHHTI
            '
            Me.lblHHTI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHHTI.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblHHTI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHHTI.Location = New System.Drawing.Point(8, 3)
            Me.lblHHTI.Name = "lblHHTI"
            Me.lblHHTI.Size = New System.Drawing.Size(73, 25)
            Me.lblHHTI.Text = "HHT ID"
            '
            'fraCityInfo
            '
            Me.fraCityInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraCityInfo.Controls.Add(Me.lblBacklightTime)
            Me.fraCityInfo.Controls.Add(Me.lblTimeTitle)
            Me.fraCityInfo.Controls.Add(Me.lblTraining)
            Me.fraCityInfo.Controls.Add(Me.lblCity)
            Me.fraCityInfo.Controls.Add(Me.lblTrgModeTitle)
            Me.fraCityInfo.Controls.Add(Me.lblCityCodeTitle)
            Me.fraCityInfo.Location = New System.Drawing.Point(0, 146)
            Me.fraCityInfo.Name = "fraCityInfo"
            Me.fraCityInfo.Size = New System.Drawing.Size(234, 75)
            '
            'lblBacklightTime
            '
            Me.lblBacklightTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBacklightTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblBacklightTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBacklightTime.Location = New System.Drawing.Point(141, 46)
            Me.lblBacklightTime.Name = "lblBacklightTime"
            Me.lblBacklightTime.Size = New System.Drawing.Size(78, 17)
            Me.lblBacklightTime.Text = "5 minutes"
            '
            'lblTimeTitle
            '
            Me.lblTimeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTimeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTimeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTimeTitle.Location = New System.Drawing.Point(9, 38)
            Me.lblTimeTitle.Name = "lblTimeTitle"
            Me.lblTimeTitle.Size = New System.Drawing.Size(121, 33)
            Me.lblTimeTitle.Text = "Current Backlight Time"
            Me.lblTimeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblTraining
            '
            Me.lblTraining.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTraining.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTraining.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTraining.Location = New System.Drawing.Point(135, 21)
            Me.lblTraining.Name = "lblTraining"
            Me.lblTraining.Size = New System.Drawing.Size(33, 17)
            Me.lblTraining.Text = "YES"
            '
            'lblCity
            '
            Me.lblCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCity.Location = New System.Drawing.Point(135, 4)
            Me.lblCity.Name = "lblCity"
            Me.lblCity.Size = New System.Drawing.Size(41, 17)
            Me.lblCity.Text = "XXX"
            '
            'lblTrgModeTitle
            '
            Me.lblTrgModeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTrgModeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblTrgModeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTrgModeTitle.Location = New System.Drawing.Point(24, 21)
            Me.lblTrgModeTitle.Name = "lblTrgModeTitle"
            Me.lblTrgModeTitle.Size = New System.Drawing.Size(105, 17)
            Me.lblTrgModeTitle.Text = "Training Mode?"
            Me.lblTrgModeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblCityCodeTitle
            '
            Me.lblCityCodeTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCityCodeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblCityCodeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCityCodeTitle.Location = New System.Drawing.Point(48, 4)
            Me.lblCityCodeTitle.Name = "lblCityCodeTitle"
            Me.lblCityCodeTitle.Size = New System.Drawing.Size(81, 17)
            Me.lblCityCodeTitle.Text = "City Code"
            Me.lblCityCodeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmdSetBacklight
            '
            Me.cmdSetBacklight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdSetBacklight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdSetBacklight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdSetBacklight.Location = New System.Drawing.Point(0, 240)
            Me.cmdSetBacklight.Name = "cmdSetBacklight"
            Me.cmdSetBacklight.Size = New System.Drawing.Size(113, 35)
            Me.cmdSetBacklight.TabIndex = 0
            Me.cmdSetBacklight.Text = "[1] Backlight"
            '
            'lblVersion
            '
            Me.lblVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblVersion.Location = New System.Drawing.Point(180, 224)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(54, 17)
            Me.lblVersion.Text = "vX.XX"
            '
            'lblHHTSftVer
            '
            Me.lblHHTSftVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHHTSftVer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblHHTSftVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHHTSftVer.Location = New System.Drawing.Point(48, 221)
            Me.lblHHTSftVer.Name = "lblHHTSftVer"
            Me.lblHHTSftVer.Size = New System.Drawing.Size(105, 20)
            Me.lblHHTSftVer.Text = "HHT Software"
            Me.lblHHTSftVer.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'frmViewHTTInformation
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 320)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraHHTInfo)
            Me.Controls.Add(Me.fraCityInfo)
            Me.Controls.Add(Me.cmdSetBacklight)
            Me.Controls.Add(Me.lblVersion)
            Me.Controls.Add(Me.lblHHTSftVer)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.MinimizeBox = False
            Me.Name = "frmViewHTTInformation"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraHHTInfo.ResumeLayout(False)
            Me.fraCityInfo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraHHTInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblFullName As System.Windows.Forms.Label
        Friend WithEvents lblIP As System.Windows.Forms.Label
        Friend WithEvents lblUser As System.Windows.Forms.Label
        Friend WithEvents lblHHT As System.Windows.Forms.Label
        Friend WithEvents lblIpAdd As System.Windows.Forms.Label
        Friend WithEvents lblUserNo As System.Windows.Forms.Label
        Friend WithEvents lblHHTI As System.Windows.Forms.Label
        Friend WithEvents fraCityInfo As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblBacklightTime As System.Windows.Forms.Label
        Friend WithEvents lblTimeTitle As System.Windows.Forms.Label
        Friend WithEvents lblTraining As System.Windows.Forms.Label
        Friend WithEvents lblCity As System.Windows.Forms.Label
        Friend WithEvents lblTrgModeTitle As System.Windows.Forms.Label
        Friend WithEvents lblCityCodeTitle As System.Windows.Forms.Label
        Friend WithEvents cmdSetBacklight As System.Windows.Forms.Button
        Friend WithEvents lblVersion As System.Windows.Forms.Label
        Friend WithEvents lblHHTSftVer As System.Windows.Forms.Label
    End Class

End Namespace