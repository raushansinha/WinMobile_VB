Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmExpedite
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
            Me.fraExpediteYN = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblYorN = New System.Windows.Forms.Label
            Me.lblHeader = New System.Windows.Forms.Label
            Me.txtHidden = New System.Windows.Forms.TextBox
            Me.fraExpediteYN.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraExpediteYN
            '
            Me.fraExpediteYN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraExpediteYN.Controls.Add(Me.lblYorN)
            Me.fraExpediteYN.Controls.Add(Me.lblHeader)
            Me.fraExpediteYN.Controls.Add(Me.txtHidden)
            Me.fraExpediteYN.Location = New System.Drawing.Point(1, 1)
            Me.fraExpediteYN.Name = "fraExpediteYN"
            Me.fraExpediteYN.Size = New System.Drawing.Size(237, 102)
            '
            'lblYorN
            '
            Me.lblYorN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblYorN.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblYorN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblYorN.Location = New System.Drawing.Point(40, 48)
            Me.lblYorN.Name = "lblYorN"
            Me.lblYorN.Size = New System.Drawing.Size(145, 22)
            Me.lblYorN.Text = "Press Y or N..."
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.Black
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.White
            Me.lblHeader.Location = New System.Drawing.Point(3, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 25)
            Me.lblHeader.Text = "EXPEDITE THIS AWB?"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtHidden
            '
            Me.txtHidden.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHidden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.txtHidden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHidden.Location = New System.Drawing.Point(80, 48)
            Me.txtHidden.Name = "txtHidden"
            Me.txtHidden.Size = New System.Drawing.Size(81, 20)
            Me.txtHidden.TabIndex = 2
            Me.txtHidden.Text = "Text1"
            '
            'dlgConfirmExpedite
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 110)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraExpediteYN)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 150)
            Me.MinimizeBox = False
            Me.Name = "dlgConfirmExpedite"
            Me.fraExpediteYN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraExpediteYN As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblYorN As System.Windows.Forms.Label
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents txtHidden As System.Windows.Forms.TextBox
    End Class
End Namespace