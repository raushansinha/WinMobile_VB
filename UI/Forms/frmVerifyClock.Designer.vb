
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI



    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmVerifyClock
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
            Me.grbEnterClock = New OpenNETCF.Windows.Forms.GroupBox
            Me.grbClock = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblClock = New System.Windows.Forms.Label
            Me.lblClickToCertify = New System.Windows.Forms.Label
            Me.chkCertify = New System.Windows.Forms.CheckBox
            Me.lblClockNumNeeded = New System.Windows.Forms.Label
            Me.cmdVerify = New System.Windows.Forms.Button
            Me.cmdCancel = New System.Windows.Forms.Button
            Me.lblCertify = New System.Windows.Forms.Label
            Me.grbLDSuccess = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdLDDone = New System.Windows.Forms.Button
            Me.lblLDSuccessful = New System.Windows.Forms.Label
            Me.lblCloseFlightOk = New System.Windows.Forms.Label
            Me.grbEnterClock.SuspendLayout()
            Me.grbClock.SuspendLayout()
            Me.grbLDSuccess.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbEnterClock
            '
            Me.grbEnterClock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbEnterClock.Controls.Add(Me.grbClock)
            Me.grbEnterClock.Controls.Add(Me.lblClickToCertify)
            Me.grbEnterClock.Controls.Add(Me.chkCertify)
            Me.grbEnterClock.Controls.Add(Me.lblClockNumNeeded)
            Me.grbEnterClock.Controls.Add(Me.cmdVerify)
            Me.grbEnterClock.Controls.Add(Me.cmdCancel)
            Me.grbEnterClock.Controls.Add(Me.lblCertify)
            Me.grbEnterClock.Location = New System.Drawing.Point(0, 43)
            Me.grbEnterClock.Name = "grbEnterClock"
            Me.grbEnterClock.Size = New System.Drawing.Size(233, 260)
            '
            'grbClock
            '
            Me.grbClock.Controls.Add(Me.lblClock)
            Me.grbClock.Location = New System.Drawing.Point(43, 125)
            Me.grbClock.Name = "grbClock"
            Me.grbClock.Size = New System.Drawing.Size(145, 33)
            '
            'lblClock
            '
            Me.lblClock.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblClock.Location = New System.Drawing.Point(14, 5)
            Me.lblClock.Name = "lblClock"
            Me.lblClock.Size = New System.Drawing.Size(121, 24)
            Me.lblClock.Text = "N807010"
            Me.lblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblClickToCertify
            '
            Me.lblClickToCertify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblClickToCertify.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.lblClickToCertify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblClickToCertify.Location = New System.Drawing.Point(8, 105)
            Me.lblClickToCertify.Name = "lblClickToCertify"
            Me.lblClickToCertify.Size = New System.Drawing.Size(49, 17)
            '
            'chkCertify
            '
            Me.chkCertify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.chkCertify.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.chkCertify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.chkCertify.Location = New System.Drawing.Point(77, 99)
            Me.chkCertify.Name = "chkCertify"
            Me.chkCertify.Size = New System.Drawing.Size(121, 25)
            Me.chkCertify.TabIndex = 1
            Me.chkCertify.Text = "[Y] Certify"
            '
            'lblClockNumNeeded
            '
            Me.lblClockNumNeeded.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblClockNumNeeded.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.lblClockNumNeeded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblClockNumNeeded.Location = New System.Drawing.Point(0, 0)
            Me.lblClockNumNeeded.Name = "lblClockNumNeeded"
            Me.lblClockNumNeeded.Size = New System.Drawing.Size(233, 25)
            Me.lblClockNumNeeded.Text = "Clock Number Needed"
            Me.lblClockNumNeeded.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdVerify
            '
            Me.cmdVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdVerify.Enabled = False
            Me.cmdVerify.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdVerify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdVerify.Location = New System.Drawing.Point(8, 164)
            Me.cmdVerify.Name = "cmdVerify"
            Me.cmdVerify.Size = New System.Drawing.Size(217, 41)
            Me.cmdVerify.TabIndex = 4
            Me.cmdVerify.Text = "(ENT) Verify && Finish"
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdCancel.Location = New System.Drawing.Point(48, 208)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.Size = New System.Drawing.Size(129, 41)
            Me.cmdCancel.TabIndex = 5
            Me.cmdCancel.Text = "(ESC) Cancel"
            '
            'lblCertify
            '
            Me.lblCertify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCertify.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblCertify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCertify.Location = New System.Drawing.Point(3, 25)
            Me.lblCertify.Name = "lblCertify"
            Me.lblCertify.Size = New System.Drawing.Size(217, 73)
            Me.lblCertify.Text = """To the best of my knowledge and ability ,I certify all load information listed a" & _
                "bove is accurate."
            Me.lblCertify.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'grbLDSuccess
            '
            Me.grbLDSuccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbLDSuccess.Controls.Add(Me.cmdLDDone)
            Me.grbLDSuccess.Controls.Add(Me.lblLDSuccessful)
            Me.grbLDSuccess.Controls.Add(Me.lblCloseFlightOk)
            Me.grbLDSuccess.Location = New System.Drawing.Point(0, 56)
            Me.grbLDSuccess.Name = "grbLDSuccess"
            Me.grbLDSuccess.Size = New System.Drawing.Size(233, 209)
            Me.grbLDSuccess.Visible = False
            '
            'cmdLDDone
            '
            Me.cmdLDDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdLDDone.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular)
            Me.cmdLDDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdLDDone.Location = New System.Drawing.Point(56, 144)
            Me.cmdLDDone.Name = "cmdLDDone"
            Me.cmdLDDone.Size = New System.Drawing.Size(121, 57)
            Me.cmdLDDone.TabIndex = 0
            Me.cmdLDDone.Text = "(ESC) Exit"
            '
            'lblLDSuccessful
            '
            Me.lblLDSuccessful.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLDSuccessful.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblLDSuccessful.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLDSuccessful.Location = New System.Drawing.Point(0, 0)
            Me.lblLDSuccessful.Name = "lblLDSuccessful"
            Me.lblLDSuccessful.Size = New System.Drawing.Size(233, 25)
            Me.lblLDSuccessful.Text = "LD Successful"
            Me.lblLDSuccessful.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCloseFlightOk
            '
            Me.lblCloseFlightOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCloseFlightOk.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold)
            Me.lblCloseFlightOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCloseFlightOk.Location = New System.Drawing.Point(32, 32)
            Me.lblCloseFlightOk.Name = "lblCloseFlightOk"
            Me.lblCloseFlightOk.Size = New System.Drawing.Size(161, 105)
            Me.lblCloseFlightOk.Text = "Flight Closed Out OK"
            Me.lblCloseFlightOk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmVerifyClock
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbEnterClock)
            Me.Controls.Add(Me.grbLDSuccess)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmVerifyClock"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbEnterClock.ResumeLayout(False)
            Me.grbClock.ResumeLayout(False)
            Me.grbLDSuccess.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbEnterClock As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblClickToCertify As System.Windows.Forms.Label
        Friend WithEvents chkCertify As System.Windows.Forms.CheckBox
        Friend WithEvents lblClockNumNeeded As System.Windows.Forms.Label
        Friend WithEvents cmdVerify As System.Windows.Forms.Button
        Friend WithEvents cmdCancel As System.Windows.Forms.Button
        Friend WithEvents grbLDSuccess As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdLDDone As System.Windows.Forms.Button
        Friend WithEvents lblLDSuccessful As System.Windows.Forms.Label
        Friend WithEvents lblCloseFlightOk As System.Windows.Forms.Label
        Friend WithEvents lblCertify As System.Windows.Forms.Label
        Friend WithEvents grbClock As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblClock As System.Windows.Forms.Label
    End Class
End Namespace