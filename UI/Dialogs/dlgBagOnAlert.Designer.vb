Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgBagOnAlert
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
            Me.fraAlert = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label24 = New System.Windows.Forms.Label
            Me.Label23 = New System.Windows.Forms.Label
            Me.Label22 = New System.Windows.Forms.Label
            Me.fraAlert.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraAlert
            '
            Me.fraAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraAlert.Controls.Add(Me.Label24)
            Me.fraAlert.Controls.Add(Me.Label23)
            Me.fraAlert.Controls.Add(Me.Label22)
            Me.fraAlert.Location = New System.Drawing.Point(4, 2)
            Me.fraAlert.Name = "fraAlert"
            Me.fraAlert.Size = New System.Drawing.Size(233, 169)
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label24.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(32, 120)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(161, 25)
            Me.Label24.Text = "[3] Cancel load"
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label23.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(32, 64)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(178, 25)
            Me.Label23.Text = "[1] Load this bag"
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.Black
            Me.Label22.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label22.ForeColor = System.Drawing.Color.White
            Me.Label22.Location = New System.Drawing.Point(8, 22)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(217, 25)
            Me.Label22.Text = "BAGTAG ON ALERT"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgBagOnAlert
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 175)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraAlert)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 130)
            Me.MinimizeBox = False
            Me.Name = "dlgBagOnAlert"
            Me.fraAlert.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraAlert As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
    End Class
End Namespace

