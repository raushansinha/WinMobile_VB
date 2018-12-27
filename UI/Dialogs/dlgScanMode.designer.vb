Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgScanMode
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
            Me.fraChooseMode = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdPBM = New System.Windows.Forms.Button
            Me.lblChoose = New System.Windows.Forms.Label
            Me.cmdManualWgt = New System.Windows.Forms.Button
            Me.cmdMultiHeavy = New System.Windows.Forms.Button
            Me.cmdPlaneside = New System.Windows.Forms.Button
            Me.cmdNormal = New System.Windows.Forms.Button
            Me.cmdDamaged = New System.Windows.Forms.Button
            Me.cmdAnimal = New System.Windows.Forms.Button
            Me.fraChooseMode.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraChooseMode
            '
            Me.fraChooseMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraChooseMode.Controls.Add(Me.cmdPBM)
            Me.fraChooseMode.Controls.Add(Me.lblChoose)
            Me.fraChooseMode.Controls.Add(Me.cmdManualWgt)
            Me.fraChooseMode.Controls.Add(Me.cmdMultiHeavy)
            Me.fraChooseMode.Controls.Add(Me.cmdPlaneside)
            Me.fraChooseMode.Controls.Add(Me.cmdNormal)
            Me.fraChooseMode.Controls.Add(Me.cmdDamaged)
            Me.fraChooseMode.Controls.Add(Me.cmdAnimal)
            Me.fraChooseMode.Location = New System.Drawing.Point(3, 7)
            Me.fraChooseMode.Name = "fraChooseMode"
            Me.fraChooseMode.Size = New System.Drawing.Size(233, 202)
            '
            'cmdPBM
            '
            Me.cmdPBM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPBM.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdPBM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPBM.Location = New System.Drawing.Point(8, 159)
            Me.cmdPBM.Name = "cmdPBM"
            Me.cmdPBM.Size = New System.Drawing.Size(217, 37)
            Me.cmdPBM.TabIndex = 6
            Me.cmdPBM.Text = "PBM"
            '
            'lblChoose
            '
            Me.lblChoose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblChoose.Location = New System.Drawing.Point(8, -3)
            Me.lblChoose.Name = "lblChoose"
            Me.lblChoose.Size = New System.Drawing.Size(151, 16)
            Me.lblChoose.Text = "Choose Scanning Mode"
            '
            'cmdManualWgt
            '
            Me.cmdManualWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdManualWgt.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdManualWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdManualWgt.Location = New System.Drawing.Point(7, 65)
            Me.cmdManualWgt.Name = "cmdManualWgt"
            Me.cmdManualWgt.Size = New System.Drawing.Size(102, 39)
            Me.cmdManualWgt.TabIndex = 0
            Me.cmdManualWgt.Text = "[H] Single Heavy"
            '
            'cmdMultiHeavy
            '
            Me.cmdMultiHeavy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdMultiHeavy.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdMultiHeavy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdMultiHeavy.Location = New System.Drawing.Point(123, 65)
            Me.cmdMultiHeavy.Name = "cmdMultiHeavy"
            Me.cmdMultiHeavy.Size = New System.Drawing.Size(102, 39)
            Me.cmdMultiHeavy.TabIndex = 1
            Me.cmdMultiHeavy.Text = "[X] Multi Heavy"
            '
            'cmdPlaneside
            '
            Me.cmdPlaneside.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdPlaneside.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdPlaneside.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdPlaneside.Location = New System.Drawing.Point(123, 16)
            Me.cmdPlaneside.Name = "cmdPlaneside"
            Me.cmdPlaneside.Size = New System.Drawing.Size(102, 40)
            Me.cmdPlaneside.TabIndex = 2
            Me.cmdPlaneside.Text = "[P] Planeside"
            '
            'cmdNormal
            '
            Me.cmdNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdNormal.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdNormal.Location = New System.Drawing.Point(7, 16)
            Me.cmdNormal.Name = "cmdNormal"
            Me.cmdNormal.Size = New System.Drawing.Size(102, 40)
            Me.cmdNormal.TabIndex = 3
            Me.cmdNormal.Text = "[N] Normal"
            '
            'cmdDamaged
            '
            Me.cmdDamaged.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdDamaged.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdDamaged.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdDamaged.Location = New System.Drawing.Point(8, 113)
            Me.cmdDamaged.Name = "cmdDamaged"
            Me.cmdDamaged.Size = New System.Drawing.Size(102, 37)
            Me.cmdDamaged.TabIndex = 4
            Me.cmdDamaged.Text = "[D] Damaged"
            '
            'cmdAnimal
            '
            Me.cmdAnimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.cmdAnimal.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Regular)
            Me.cmdAnimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdAnimal.Location = New System.Drawing.Point(123, 113)
            Me.cmdAnimal.Name = "cmdAnimal"
            Me.cmdAnimal.Size = New System.Drawing.Size(102, 37)
            Me.cmdAnimal.TabIndex = 5
            Me.cmdAnimal.Text = "[A] Animal"
            '
            'dlgScanMode
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(240, 215)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraChooseMode)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 70)
            Me.MinimizeBox = False
            Me.Name = "dlgScanMode"
            Me.fraChooseMode.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraChooseMode As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdManualWgt As System.Windows.Forms.Button
        Friend WithEvents cmdMultiHeavy As System.Windows.Forms.Button
        Friend WithEvents cmdPlaneside As System.Windows.Forms.Button
        Friend WithEvents cmdNormal As System.Windows.Forms.Button
        Friend WithEvents cmdDamaged As System.Windows.Forms.Button
        Friend WithEvents cmdAnimal As System.Windows.Forms.Button
        Friend WithEvents lblChoose As System.Windows.Forms.Label
        Friend WithEvents cmdPBM As System.Windows.Forms.Button
    End Class
End Namespace

