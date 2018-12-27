Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgWeight
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
            Me.fraManualWgt = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtManualWgt = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblFooter = New System.Windows.Forms.Label
            Me.fraManualWgt.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraManualWgt
            '
            Me.fraManualWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraManualWgt.Controls.Add(Me.txtManualWgt)
            Me.fraManualWgt.Location = New System.Drawing.Point(3, 14)
            Me.fraManualWgt.Name = "fraManualWgt"
            Me.fraManualWgt.Size = New System.Drawing.Size(234, 60)
            '
            'txtManualWgt
            '
            Me.txtManualWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtManualWgt.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtManualWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtManualWgt.Location = New System.Drawing.Point(26, 20)
            Me.txtManualWgt.Name = "txtManualWgt"
            Me.txtManualWgt.Size = New System.Drawing.Size(177, 32)
            Me.txtManualWgt.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
            Me.Label1.Location = New System.Drawing.Point(18, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(190, 29)
            Me.Label1.Text = "Enter Weight (in lbs)"
            '
            'lblFooter
            '
            Me.lblFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFooter.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFooter.Location = New System.Drawing.Point(2, 78)
            Me.lblFooter.Name = "lblFooter"
            Me.lblFooter.Size = New System.Drawing.Size(240, 26)
            Me.lblFooter.Text = "Footer"
            Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgWeight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 107)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblFooter)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.fraManualWgt)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 200)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgWeight"
            Me.Text = "dlgWeight"
            Me.fraManualWgt.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraManualWgt As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtManualWgt As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents lblFooter As System.Windows.Forms.Label
    End Class
End Namespace

