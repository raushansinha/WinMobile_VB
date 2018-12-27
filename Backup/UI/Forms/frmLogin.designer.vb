Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmLogin
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.cmdLogin = New System.Windows.Forms.Button
            Me.lblKeyNum = New System.Windows.Forms.Label
            Me.lblRF = New System.Windows.Forms.Label
            Me.lblAppVersion = New System.Windows.Forms.Label
            Me.cmdQuit = New System.Windows.Forms.Button
            Me.imgWelCome = New System.Windows.Forms.PictureBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.lblUserName = New System.Windows.Forms.Label
            Me.fraLoggedIn = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label16 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblHagent = New System.Windows.Forms.Label
            Me.lblStation = New System.Windows.Forms.Label
            Me.lblKeyAlpha = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.cmbSystem = New System.Windows.Forms.ComboBox
            Me.txtUser = New System.Windows.Forms.TextBox
            Me.fraLoginMain = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtPassword = New System.Windows.Forms.TextBox
            Me.fraWelcome = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label9 = New System.Windows.Forms.Label
            Me.lblName = New System.Windows.Forms.Label
            Me.lblLoginMain = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.batteryLife = New OpenNETCF.Windows.Forms.BatteryLife
            Me.fraLoggedIn.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.fraLoginMain.SuspendLayout()
            Me.fraWelcome.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmdLogin
            '
            Me.cmdLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdLogin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdLogin.Location = New System.Drawing.Point(142, 240)
            Me.cmdLogin.Name = "cmdLogin"
            Me.cmdLogin.Size = New System.Drawing.Size(97, 33)
            Me.cmdLogin.TabIndex = 3
            Me.cmdLogin.Text = "[ENT] Login"
            '
            'lblKeyNum
            '
            Me.lblKeyNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblKeyNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblKeyNum.Location = New System.Drawing.Point(328, 8)
            Me.lblKeyNum.Name = "lblKeyNum"
            Me.lblKeyNum.Size = New System.Drawing.Size(20, 21)
            Me.lblKeyNum.Text = "1"
            Me.lblKeyNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblKeyNum.Visible = False
            '
            'lblRF
            '
            Me.lblRF.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblRF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRF.Location = New System.Drawing.Point(352, 48)
            Me.lblRF.Name = "lblRF"
            Me.lblRF.Size = New System.Drawing.Size(44, 21)
            Me.lblRF.Text = "NA%"
            Me.lblRF.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblRF.Visible = False
            '
            'lblAppVersion
            '
            Me.lblAppVersion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblAppVersion.Location = New System.Drawing.Point(176, 80)
            Me.lblAppVersion.Name = "lblAppVersion"
            Me.lblAppVersion.Size = New System.Drawing.Size(57, 17)
            Me.lblAppVersion.Text = "[Ver]"
            Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmdQuit
            '
            Me.cmdQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdQuit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.cmdQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdQuit.Location = New System.Drawing.Point(4, 224)
            Me.cmdQuit.Name = "cmdQuit"
            Me.cmdQuit.Size = New System.Drawing.Size(81, 17)
            Me.cmdQuit.TabIndex = 10
            Me.cmdQuit.Text = "Quit"
            Me.cmdQuit.Visible = False
            '
            'imgWelCome
            '
            Me.imgWelCome.Image = CType(resources.GetObject("imgWelCome.Image"), System.Drawing.Image)
            Me.imgWelCome.Location = New System.Drawing.Point(0, 0)
            Me.imgWelCome.Name = "imgWelCome"
            Me.imgWelCome.Size = New System.Drawing.Size(240, 78)
            Me.imgWelCome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(201, 25)
            Me.Label6.Text = "Welcome!"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblUserName
            '
            Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblUserName.Location = New System.Drawing.Point(24, 48)
            Me.lblUserName.Name = "lblUserName"
            Me.lblUserName.Size = New System.Drawing.Size(161, 57)
            Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraLoggedIn
            '
            Me.fraLoggedIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraLoggedIn.Controls.Add(Me.lblUserName)
            Me.fraLoggedIn.Controls.Add(Me.Label6)
            Me.fraLoggedIn.Location = New System.Drawing.Point(8, 112)
            Me.fraLoggedIn.Name = "fraLoggedIn"
            Me.fraLoggedIn.Size = New System.Drawing.Size(217, 121)
            Me.fraLoggedIn.Visible = False
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(32, 56)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(169, 25)
            Me.Label16.Text = "Please Wait..."
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Black
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(233, 25)
            Me.Label1.Text = "Attempting Login"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.Label1)
            Me.fraWait.Controls.Add(Me.Label16)
            Me.fraWait.Location = New System.Drawing.Point(4, 112)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 121)
            Me.fraWait.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(24, 28)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 17)
            Me.Label2.Text = "USER"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(24, 54)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(65, 17)
            Me.Label3.Text = "PASSWD"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(8, 112)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(67, 17)
            Me.Label4.Text = "HAGENT:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(111, 112)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(73, 17)
            Me.Label5.Text = "AIRPORT:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblHagent
            '
            Me.lblHagent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHagent.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
            Me.lblHagent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHagent.Location = New System.Drawing.Point(80, 112)
            Me.lblHagent.Name = "lblHagent"
            Me.lblHagent.Size = New System.Drawing.Size(33, 17)
            '
            'lblStation
            '
            Me.lblStation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStation.Location = New System.Drawing.Point(187, 112)
            Me.lblStation.Name = "lblStation"
            Me.lblStation.Size = New System.Drawing.Size(36, 17)
            '
            'lblKeyAlpha
            '
            Me.lblKeyAlpha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblKeyAlpha.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.lblKeyAlpha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblKeyAlpha.Location = New System.Drawing.Point(328, -24)
            Me.lblKeyAlpha.Name = "lblKeyAlpha"
            Me.lblKeyAlpha.Size = New System.Drawing.Size(20, 21)
            Me.lblKeyAlpha.Text = "A"
            Me.lblKeyAlpha.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblKeyAlpha.Visible = False
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(24, 81)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(65, 17)
            Me.Label7.Text = "SYSTEM"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cmbSystem
            '
            Me.cmbSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbSystem.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.cmbSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbSystem.Location = New System.Drawing.Point(96, 81)
            Me.cmbSystem.Name = "cmbSystem"
            Me.cmbSystem.Size = New System.Drawing.Size(97, 24)
            Me.cmbSystem.TabIndex = 2
            '
            'txtUser
            '
            Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtUser.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
            Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtUser.Location = New System.Drawing.Point(96, 26)
            Me.txtUser.Name = "txtUser"
            Me.txtUser.Size = New System.Drawing.Size(81, 23)
            Me.txtUser.TabIndex = 0
            '
            'fraLoginMain
            '
            Me.fraLoginMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraLoginMain.Controls.Add(Me.txtUser)
            Me.fraLoginMain.Controls.Add(Me.cmbSystem)
            Me.fraLoginMain.Controls.Add(Me.Label7)
            Me.fraLoginMain.Controls.Add(Me.lblKeyAlpha)
            Me.fraLoginMain.Controls.Add(Me.lblStation)
            Me.fraLoginMain.Controls.Add(Me.lblHagent)
            Me.fraLoginMain.Controls.Add(Me.txtPassword)
            Me.fraLoginMain.Controls.Add(Me.Label5)
            Me.fraLoginMain.Controls.Add(Me.Label4)
            Me.fraLoginMain.Controls.Add(Me.Label3)
            Me.fraLoginMain.Controls.Add(Me.Label2)
            Me.fraLoginMain.Controls.Add(Me.fraWelcome)
            Me.fraLoginMain.Location = New System.Drawing.Point(3, 104)
            Me.fraLoginMain.Name = "fraLoginMain"
            Me.fraLoginMain.Size = New System.Drawing.Size(236, 137)
            '
            'txtPassword
            '
            Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
            Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtPassword.Location = New System.Drawing.Point(96, 54)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(81, 23)
            Me.txtPassword.TabIndex = 1
            '
            'fraWelcome
            '
            Me.fraWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWelcome.Controls.Add(Me.Label9)
            Me.fraWelcome.Controls.Add(Me.lblName)
            Me.fraWelcome.Location = New System.Drawing.Point(8, 11)
            Me.fraWelcome.Name = "fraWelcome"
            Me.fraWelcome.Size = New System.Drawing.Size(217, 121)
            Me.fraWelcome.Visible = False
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 16)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(201, 25)
            Me.Label9.Text = "Welcome!"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblName.Location = New System.Drawing.Point(24, 48)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(161, 57)
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblLoginMain
            '
            Me.lblLoginMain.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblLoginMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLoginMain.Location = New System.Drawing.Point(7, 95)
            Me.lblLoginMain.Name = "lblLoginMain"
            Me.lblLoginMain.Size = New System.Drawing.Size(130, 20)
            Me.lblLoginMain.Text = "[HHT991] Login"
            Me.lblLoginMain.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(181, 91)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(20, 21)
            Me.Label8.Text = "A"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Label8.Visible = False
            '
            'batteryLife
            '
            Me.batteryLife.BackColor = System.Drawing.Color.White
            Me.batteryLife.Location = New System.Drawing.Point(1, 81)
            Me.batteryLife.Name = "batteryLife"
            Me.batteryLife.Size = New System.Drawing.Size(50, 14)
            Me.batteryLife.TabIndex = 23
            Me.batteryLife.Text = "BatteryLife1"
            '
            'frmLogin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblLoginMain)
            Me.Controls.Add(Me.fraLoginMain)
            Me.Controls.Add(Me.batteryLife)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.fraLoggedIn)
            Me.Controls.Add(Me.cmdLogin)
            Me.Controls.Add(Me.lblKeyNum)
            Me.Controls.Add(Me.lblRF)
            Me.Controls.Add(Me.lblAppVersion)
            Me.Controls.Add(Me.cmdQuit)
            Me.Controls.Add(Me.imgWelCome)
            Me.Controls.Add(Me.fraWait)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmLogin"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraLoggedIn.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.fraLoginMain.ResumeLayout(False)
            Me.fraWelcome.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cmdLogin As System.Windows.Forms.Button
        Friend WithEvents lblKeyNum As System.Windows.Forms.Label
        Friend WithEvents lblRF As System.Windows.Forms.Label
        Friend WithEvents lblAppVersion As System.Windows.Forms.Label
        Friend WithEvents cmdQuit As System.Windows.Forms.Button
        Friend WithEvents imgWelCome As System.Windows.Forms.PictureBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblUserName As System.Windows.Forms.Label
        Friend WithEvents fraLoggedIn As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblHagent As System.Windows.Forms.Label
        Friend WithEvents lblStation As System.Windows.Forms.Label
        Friend WithEvents lblKeyAlpha As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cmbSystem As System.Windows.Forms.ComboBox
        Friend WithEvents txtUser As System.Windows.Forms.TextBox
        Friend WithEvents fraLoginMain As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblLoginMain As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Private WithEvents batteryLife As OpenNETCF.Windows.Forms.BatteryLife
        Friend WithEvents fraWelcome As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label

    End Class
End Namespace
