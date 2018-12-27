Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmCreateNewAWB
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
            Me.fraCreateYN = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblYorN = New System.Windows.Forms.Label
            Me.txtHidden2 = New System.Windows.Forms.TextBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.fraCreateYN.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraCreateYN
            '
            Me.fraCreateYN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraCreateYN.Controls.Add(Me.lblYorN)
            Me.fraCreateYN.Controls.Add(Me.txtHidden2)
            Me.fraCreateYN.Controls.Add(Me.lblHeader)
            Me.fraCreateYN.Location = New System.Drawing.Point(4, 1)
            Me.fraCreateYN.Name = "fraCreateYN"
            Me.fraCreateYN.Size = New System.Drawing.Size(233, 105)
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
            'txtHidden2
            '
            Me.txtHidden2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtHidden2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            Me.txtHidden2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtHidden2.Location = New System.Drawing.Point(80, 48)
            Me.txtHidden2.Name = "txtHidden2"
            Me.txtHidden2.Size = New System.Drawing.Size(81, 20)
            Me.txtHidden2.TabIndex = 1
            Me.txtHidden2.Text = "Text1"
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 25)
            Me.lblHeader.Text = "CREATE NEW AWB?"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgConfirmCreateNewAWB
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 108)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraCreateYN)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 150)
            Me.MinimizeBox = False
            Me.Name = "dlgConfirmCreateNewAWB"
            Me.Text = "Form3"
            Me.fraCreateYN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraCreateYN As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblYorN As System.Windows.Forms.Label
        Friend WithEvents txtHidden2 As System.Windows.Forms.TextBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
    End Class

End Namespace