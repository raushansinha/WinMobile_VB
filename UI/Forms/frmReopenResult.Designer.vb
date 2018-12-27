
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmReopenResult
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
            Me.grbPage4 = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblStatusReopen = New System.Windows.Forms.Label
            Me.lblStatusReopenDesc = New System.Windows.Forms.Label
            Me.lblReopenFlightRslt = New System.Windows.Forms.Label
            Me.cmdDone = New System.Windows.Forms.Button
            Me.cmdPrev = New System.Windows.Forms.Button
            Me.grbPage4.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbPage4
            '
            Me.grbPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.grbPage4.Controls.Add(Me.lblStatusReopen)
            Me.grbPage4.Controls.Add(Me.lblStatusReopenDesc)
            Me.grbPage4.Controls.Add(Me.lblReopenFlightRslt)
            Me.grbPage4.Location = New System.Drawing.Point(0, 56)
            Me.grbPage4.Name = "grbPage4"
            Me.grbPage4.Size = New System.Drawing.Size(233, 195)
            '
            'lblStatusReopen
            '
            Me.lblStatusReopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStatusReopen.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblStatusReopen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStatusReopen.Location = New System.Drawing.Point(16, 25)
            Me.lblStatusReopen.Name = "lblStatusReopen"
            Me.lblStatusReopen.Size = New System.Drawing.Size(201, 48)
            Me.lblStatusReopen.Text = "Flight opened successfully."
            Me.lblStatusReopen.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblStatusReopenDesc
            '
            Me.lblStatusReopenDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStatusReopenDesc.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblStatusReopenDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStatusReopenDesc.Location = New System.Drawing.Point(10, 73)
            Me.lblStatusReopenDesc.Name = "lblStatusReopenDesc"
            Me.lblStatusReopenDesc.Size = New System.Drawing.Size(207, 115)
            Me.lblStatusReopenDesc.Text = "CLC has finalized this load. Items can be added, but contact CLC if items need re" & _
                "moval."
            Me.lblStatusReopenDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblReopenFlightRslt
            '
            Me.lblReopenFlightRslt.BackColor = System.Drawing.Color.Black
            Me.lblReopenFlightRslt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblReopenFlightRslt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblReopenFlightRslt.Location = New System.Drawing.Point(0, 0)
            Me.lblReopenFlightRslt.Name = "lblReopenFlightRslt"
            Me.lblReopenFlightRslt.Size = New System.Drawing.Size(233, 25)
            Me.lblReopenFlightRslt.Text = "Reopen Flight Results"
            Me.lblReopenFlightRslt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdDone
            '
            Me.cmdDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdDone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdDone.Location = New System.Drawing.Point(120, 255)
            Me.cmdDone.Name = "cmdDone"
            Me.cmdDone.Size = New System.Drawing.Size(113, 41)
            Me.cmdDone.TabIndex = 6
            Me.cmdDone.Text = "(Ent) Done >"
            '
            'cmdPrev
            '
            Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPrev.Enabled = False
            Me.cmdPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.cmdPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPrev.Location = New System.Drawing.Point(0, 255)
            Me.cmdPrev.Name = "cmdPrev"
            Me.cmdPrev.Size = New System.Drawing.Size(113, 41)
            Me.cmdPrev.TabIndex = 7
            Me.cmdPrev.Text = "< Prev"
            '
            'frmReopenResult
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.grbPage4)
            Me.Controls.Add(Me.cmdDone)
            Me.Controls.Add(Me.cmdPrev)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmReopenResult"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.grbPage4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbPage4 As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblStatusReopen As System.Windows.Forms.Label
        Friend WithEvents lblStatusReopenDesc As System.Windows.Forms.Label
        Friend WithEvents lblReopenFlightRslt As System.Windows.Forms.Label
        Friend WithEvents cmdDone As System.Windows.Forms.Button
        Friend WithEvents cmdPrev As System.Windows.Forms.Button
    End Class
End Namespace