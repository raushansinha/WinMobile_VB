
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmContainerInquiryTwo
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
            Me.lblEnterULD = New System.Windows.Forms.Label
            Me.txtULDSheet = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'lblEnterULD
            '
            Me.lblEnterULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblEnterULD.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblEnterULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblEnterULD.Location = New System.Drawing.Point(0, 56)
            Me.lblEnterULD.Name = "lblEnterULD"
            Me.lblEnterULD.Size = New System.Drawing.Size(233, 24)
            Me.lblEnterULD.Text = "Enter Sheet/ULD"
            Me.lblEnterULD.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtULDSheet
            '
            Me.txtULDSheet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtULDSheet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtULDSheet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtULDSheet.Location = New System.Drawing.Point(40, 80)
            Me.txtULDSheet.MaxLength = 10
            Me.txtULDSheet.Name = "txtULDSheet"
            Me.txtULDSheet.Size = New System.Drawing.Size(153, 26)
            Me.txtULDSheet.TabIndex = 0
            '
            'frmContainerInquiryTwo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblEnterULD)
            Me.Controls.Add(Me.txtULDSheet)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmContainerInquiryTwo"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblEnterULD As System.Windows.Forms.Label
        Friend WithEvents txtULDSheet As System.Windows.Forms.TextBox
    End Class
End Namespace
