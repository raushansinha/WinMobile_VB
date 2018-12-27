
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmVerifyClockMessage
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
            Me.grbLDSuccess = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdLDDone = New System.Windows.Forms.Button
            Me.lblLDSuccessful = New System.Windows.Forms.Label
            Me.lblFlightClosedOk = New System.Windows.Forms.Label
            Me.grbLDSuccess.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbLDSuccess
            '
            Me.grbLDSuccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbLDSuccess.Controls.Add(Me.cmdLDDone)
            Me.grbLDSuccess.Controls.Add(Me.lblLDSuccessful)
            Me.grbLDSuccess.Controls.Add(Me.lblFlightClosedOk)
            Me.grbLDSuccess.Location = New System.Drawing.Point(0, 56)
            Me.grbLDSuccess.Name = "grbLDSuccess"
            Me.grbLDSuccess.Size = New System.Drawing.Size(233, 209)
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
            'lblFlightClosedOk
            '
            Me.lblFlightClosedOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightClosedOk.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold)
            Me.lblFlightClosedOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightClosedOk.Location = New System.Drawing.Point(32, 32)
            Me.lblFlightClosedOk.Name = "lblFlightClosedOk"
            Me.lblFlightClosedOk.Size = New System.Drawing.Size(161, 105)
            Me.lblFlightClosedOk.Text = "Flight Closed Out OK"
            Me.lblFlightClosedOk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmVerifyClockMessage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbLDSuccess)
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmVerifyClockMessage"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbLDSuccess.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbLDSuccess As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdLDDone As System.Windows.Forms.Button
        Friend WithEvents lblLDSuccessful As System.Windows.Forms.Label
        Friend WithEvents lblFlightClosedOk As System.Windows.Forms.Label
    End Class
End Namespace
