
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgWait
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
            Me.fraStatus = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblWait = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.fraStatus.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraStatus
            '
            Me.fraStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraStatus.Controls.Add(Me.lblWait)
            Me.fraStatus.Controls.Add(Me.lblTitle)
            Me.fraStatus.Location = New System.Drawing.Point(0, 2)
            Me.fraStatus.Name = "fraStatus"
            Me.fraStatus.Size = New System.Drawing.Size(233, 129)
            '
            'lblWait
            '
            Me.lblWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWait.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblWait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWait.Location = New System.Drawing.Point(8, 88)
            Me.lblWait.Name = "lblWait"
            Me.lblWait.Size = New System.Drawing.Size(217, 33)
            Me.lblWait.Text = "Please Wait..."
            Me.lblWait.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(8, 16)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(217, 65)
            Me.lblTitle.Text = "Starting up."
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmWait
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 133)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraStatus)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmWait"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraStatus.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraStatus As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblWait As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class
End Namespace
