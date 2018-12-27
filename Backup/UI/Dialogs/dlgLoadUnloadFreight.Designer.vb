
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgLoadUnloadFreight
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
            Me.fraFrt = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdUnloadFrt = New System.Windows.Forms.Button
            Me.cmdLoadFrt = New System.Windows.Forms.Button
            Me.Label4 = New System.Windows.Forms.Label
            Me.fraFrt.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraFrt
            '
            Me.fraFrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraFrt.Controls.Add(Me.cmdUnloadFrt)
            Me.fraFrt.Controls.Add(Me.cmdLoadFrt)
            Me.fraFrt.Controls.Add(Me.Label4)
            Me.fraFrt.Location = New System.Drawing.Point(4, 2)
            Me.fraFrt.Name = "fraFrt"
            Me.fraFrt.Size = New System.Drawing.Size(233, 87)
            '
            'cmdUnloadFrt
            '
            Me.cmdUnloadFrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdUnloadFrt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdUnloadFrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdUnloadFrt.Location = New System.Drawing.Point(120, 36)
            Me.cmdUnloadFrt.Name = "cmdUnloadFrt"
            Me.cmdUnloadFrt.Size = New System.Drawing.Size(105, 41)
            Me.cmdUnloadFrt.TabIndex = 0
            Me.cmdUnloadFrt.Text = "[3] Unload"
            '
            'cmdLoadFrt
            '
            Me.cmdLoadFrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdLoadFrt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdLoadFrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdLoadFrt.Location = New System.Drawing.Point(8, 36)
            Me.cmdLoadFrt.Name = "cmdLoadFrt"
            Me.cmdLoadFrt.Size = New System.Drawing.Size(97, 41)
            Me.cmdLoadFrt.TabIndex = 1
            Me.cmdLoadFrt.Text = "[1] Load"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(0, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(233, 25)
            Me.Label4.Text = "Load/Unload Freight?"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgLoadUnloadFreight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 90)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraFrt)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 120)
            Me.MinimizeBox = False
            Me.Name = "dlgLoadUnloadFreight"
            Me.fraFrt.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraFrt As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdUnloadFrt As System.Windows.Forms.Button
        Friend WithEvents cmdLoadFrt As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace