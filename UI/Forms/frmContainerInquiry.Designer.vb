
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmContainerInquiry
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
            Me.lblSheetOrULD1 = New System.Windows.Forms.Label
            Me.txtULDSheet = New System.Windows.Forms.TextBox
            Me.btnLookup = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'lblSheetOrULD1
            '
            Me.lblSheetOrULD1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSheetOrULD1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblSheetOrULD1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSheetOrULD1.Location = New System.Drawing.Point(-4, 55)
            Me.lblSheetOrULD1.Name = "lblSheetOrULD1"
            Me.lblSheetOrULD1.Size = New System.Drawing.Size(75, 27)
            Me.lblSheetOrULD1.Text = "ULD/CS"
            Me.lblSheetOrULD1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtULDSheet
            '
            Me.txtULDSheet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtULDSheet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.txtULDSheet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtULDSheet.Location = New System.Drawing.Point(72, 56)
            Me.txtULDSheet.MaxLength = 13
            Me.txtULDSheet.Name = "txtULDSheet"
            Me.txtULDSheet.Size = New System.Drawing.Size(161, 26)
            Me.txtULDSheet.TabIndex = 0
            '
            'btnLookup
            '
            Me.btnLookup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnLookup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnLookup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnLookup.Location = New System.Drawing.Point(48, 237)
            Me.btnLookup.Name = "btnLookup"
            Me.btnLookup.Size = New System.Drawing.Size(129, 33)
            Me.btnLookup.TabIndex = 1
            Me.btnLookup.Text = "[ENT] Lookup"
            '
            'frmContainerInquiry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblSheetOrULD1)
            Me.Controls.Add(Me.txtULDSheet)
            Me.Controls.Add(Me.btnLookup)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmContainerInquiry"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblSheetOrULD1 As System.Windows.Forms.Label
        Friend WithEvents txtULDSheet As System.Windows.Forms.TextBox
        Friend WithEvents btnLookup As System.Windows.Forms.Button
    End Class

End Namespace