
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgMenuViews
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
            Me.fraViews = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.cmdViewAll = New System.Windows.Forms.Button
            Me.cmdViewBag = New System.Windows.Forms.Button
            Me.cmdViewInq = New System.Windows.Forms.Button
            Me.cmdViewULD = New System.Windows.Forms.Button
            Me.fraViews.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraViews
            '
            Me.fraViews.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraViews.Controls.Add(Me.Label2)
            Me.fraViews.Controls.Add(Me.cmdViewAll)
            Me.fraViews.Controls.Add(Me.cmdViewBag)
            Me.fraViews.Controls.Add(Me.cmdViewInq)
            Me.fraViews.Controls.Add(Me.cmdViewULD)
            Me.fraViews.Location = New System.Drawing.Point(3, 3)
            Me.fraViews.Name = "fraViews"
            Me.fraViews.Size = New System.Drawing.Size(233, 134)
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(0, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(233, 25)
            Me.Label2.Text = "Menu Views"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cmdViewAll
            '
            Me.cmdViewAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewAll.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdViewAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewAll.Location = New System.Drawing.Point(8, 40)
            Me.cmdViewAll.Name = "cmdViewAll"
            Me.cmdViewAll.Size = New System.Drawing.Size(97, 41)
            Me.cmdViewAll.TabIndex = 1
            Me.cmdViewAll.Text = "[1] All"
            '
            'cmdViewBag
            '
            Me.cmdViewBag.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewBag.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdViewBag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewBag.Location = New System.Drawing.Point(8, 88)
            Me.cmdViewBag.Name = "cmdViewBag"
            Me.cmdViewBag.Size = New System.Drawing.Size(97, 41)
            Me.cmdViewBag.TabIndex = 2
            Me.cmdViewBag.Text = "[7] Bags"
            '
            'cmdViewInq
            '
            Me.cmdViewInq.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewInq.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdViewInq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewInq.Location = New System.Drawing.Point(120, 40)
            Me.cmdViewInq.Name = "cmdViewInq"
            Me.cmdViewInq.Size = New System.Drawing.Size(105, 41)
            Me.cmdViewInq.TabIndex = 3
            Me.cmdViewInq.Text = "[3] Inquiry"
            '
            'cmdViewULD
            '
            Me.cmdViewULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdViewULD.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.cmdViewULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdViewULD.Location = New System.Drawing.Point(120, 88)
            Me.cmdViewULD.Name = "cmdViewULD"
            Me.cmdViewULD.Size = New System.Drawing.Size(105, 41)
            Me.cmdViewULD.TabIndex = 4
            Me.cmdViewULD.Text = "[9] ULD"
            '
            'dlgMenuViews
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 140)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraViews)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 140)
            Me.MinimizeBox = False
            Me.Name = "dlgMenuViews"
            Me.fraViews.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraViews As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cmdViewAll As System.Windows.Forms.Button
        Friend WithEvents cmdViewBag As System.Windows.Forms.Button
        Friend WithEvents cmdViewInq As System.Windows.Forms.Button
        Friend WithEvents cmdViewULD As System.Windows.Forms.Button
    End Class
End Namespace
