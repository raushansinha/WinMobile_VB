Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmLoadMail
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
            Me.fraConfirmBlank = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.lblBlank = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtHidden = New System.Windows.Forms.TextBox
            Me.fraConfirmBlank.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraConfirmBlank
            '
            Me.fraConfirmBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraConfirmBlank.Controls.Add(Me.Label3)
            Me.fraConfirmBlank.Controls.Add(Me.lblBlank)
            Me.fraConfirmBlank.Controls.Add(Me.Label6)
            Me.fraConfirmBlank.Controls.Add(Me.txtHidden)
            Me.fraConfirmBlank.Location = New System.Drawing.Point(4, 4)
            Me.fraConfirmBlank.Name = "fraConfirmBlank"
            Me.fraConfirmBlank.Size = New System.Drawing.Size(233, 107)
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(233, 25)
            Me.Label3.Text = "Blank ID"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBlank
            '
            Me.lblBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBlank.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lblBlank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBlank.Location = New System.Drawing.Point(32, 32)
            Me.lblBlank.Name = "lblBlank"
            Me.lblBlank.Size = New System.Drawing.Size(161, 49)
            Me.lblBlank.Text = "Load Mail without barcode?"
            Me.lblBlank.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 76)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(185, 26)
            Me.Label6.Text = "[Y] Yes   [N] No"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtHidden
            '
            Me.txtHidden.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHidden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.txtHidden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHidden.Location = New System.Drawing.Point(64, 48)
            Me.txtHidden.Name = "txtHidden"
            Me.txtHidden.Size = New System.Drawing.Size(97, 20)
            Me.txtHidden.TabIndex = 3
            Me.txtHidden.Visible = False
            '
            'dlgConfirmLoadMail
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 115)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraConfirmBlank)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 135)
            Me.MinimizeBox = False
            Me.Name = "dlgConfirmLoadMail"
            Me.fraConfirmBlank.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraConfirmBlank As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblBlank As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtHidden As System.Windows.Forms.TextBox
    End Class
End Namespace
