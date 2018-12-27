
Imports OpenNETCF.Windows.Forms

Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmSelectReason
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
            Me.fraReason = New OpenNETCF.Windows.Forms.GroupBox
            Me.btnSelectReason = New System.Windows.Forms.Button
            Me.Label22 = New System.Windows.Forms.Label
            Me.lbReasons = New System.Windows.Forms.ListBox
            Me.fraReason.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraReason
            '
            Me.fraReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraReason.Controls.Add(Me.btnSelectReason)
            Me.fraReason.Controls.Add(Me.Label22)
            Me.fraReason.Controls.Add(Me.lbReasons)
            Me.fraReason.Location = New System.Drawing.Point(3, 3)
            Me.fraReason.Name = "fraReason"
            Me.fraReason.Size = New System.Drawing.Size(230, 284)
            '
            'btnSelectReason
            '
            Me.btnSelectReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSelectReason.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.btnSelectReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnSelectReason.Location = New System.Drawing.Point(45, 222)
            Me.btnSelectReason.Name = "btnSelectReason"
            Me.btnSelectReason.Size = New System.Drawing.Size(137, 41)
            Me.btnSelectReason.TabIndex = 0
            Me.btnSelectReason.Text = "OK"
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label22.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(0, 0)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(233, 25)
            Me.Label22.Text = "Select Reason"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbReasons
            '
            Me.lbReasons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbReasons.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.lbReasons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbReasons.Location = New System.Drawing.Point(8, 32)
            Me.lbReasons.Name = "lbReasons"
            Me.lbReasons.Size = New System.Drawing.Size(217, 184)
            Me.lbReasons.TabIndex = 2
            '
            'frmSelectReason
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraReason)
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmSelectReason"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraReason.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraReason As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnSelectReason As System.Windows.Forms.Button
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents lbReasons As System.Windows.Forms.ListBox



    End Class
End Namespace