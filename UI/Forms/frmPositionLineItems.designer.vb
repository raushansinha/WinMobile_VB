Imports OpenNETCF.Windows.Forms.GroupBox
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmPositionLineItems
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
            Me.fraPosition = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblSelComments = New System.Windows.Forms.Label
            Me.btnConfirmLoad = New System.Windows.Forms.Button
            Me.cmbPos = New System.Windows.Forms.ComboBox
            Me.lblWeight = New System.Windows.Forms.Label
            Me.lblType = New System.Windows.Forms.Label
            Me.lblTitle = New System.Windows.Forms.Label
            Me.lblPosition = New System.Windows.Forms.Label
            Me.lblSelWgt = New System.Windows.Forms.Label
            Me.lblSelType = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblWait = New System.Windows.Forms.Label
            Me.lblComments = New System.Windows.Forms.Label
            Me.lblHeader = New System.Windows.Forms.Label
            Me.fraPosition.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraPosition
            '
            Me.fraPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraPosition.Controls.Add(Me.lblSelComments)
            Me.fraPosition.Controls.Add(Me.lblComments)
            Me.fraPosition.Controls.Add(Me.btnConfirmLoad)
            Me.fraPosition.Controls.Add(Me.cmbPos)
            Me.fraPosition.Controls.Add(Me.lblWeight)
            Me.fraPosition.Controls.Add(Me.lblType)
            Me.fraPosition.Controls.Add(Me.lblTitle)
            Me.fraPosition.Controls.Add(Me.lblPosition)
            Me.fraPosition.Controls.Add(Me.lblSelWgt)
            Me.fraPosition.Controls.Add(Me.lblSelType)
            Me.fraPosition.Controls.Add(Me.fraWait)
            Me.fraPosition.Location = New System.Drawing.Point(0, 59)
            Me.fraPosition.Name = "fraPosition"
            Me.fraPosition.Size = New System.Drawing.Size(240, 214)
            '
            'lblSelComments
            '
            Me.lblSelComments.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblSelComments.Location = New System.Drawing.Point(50, 144)
            Me.lblSelComments.Name = "lblSelComments"
            Me.lblSelComments.Size = New System.Drawing.Size(130, 20)
            Me.lblSelComments.Text = "LIVE CHICKS"
            Me.lblSelComments.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnConfirmLoad
            '
            Me.btnConfirmLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnConfirmLoad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnConfirmLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnConfirmLoad.Location = New System.Drawing.Point(50, 167)
            Me.btnConfirmLoad.Name = "btnConfirmLoad"
            Me.btnConfirmLoad.Size = New System.Drawing.Size(130, 30)
            Me.btnConfirmLoad.TabIndex = 0
            Me.btnConfirmLoad.Text = "Load Now"
            '
            'cmbPos
            '
            Me.cmbPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmbPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
            Me.cmbPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmbPos.Location = New System.Drawing.Point(72, 48)
            Me.cmbPos.Name = "cmbPos"
            Me.cmbPos.Size = New System.Drawing.Size(81, 27)
            Me.cmbPos.TabIndex = 1
            '
            'lblWeight
            '
            Me.lblWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWeight.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWeight.Location = New System.Drawing.Point(132, 81)
            Me.lblWeight.Name = "lblWeight"
            Me.lblWeight.Size = New System.Drawing.Size(81, 18)
            Me.lblWeight.Text = "Weight"
            Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblType
            '
            Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblType.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblType.Location = New System.Drawing.Point(24, 81)
            Me.lblType.Name = "lblType"
            Me.lblType.Size = New System.Drawing.Size(81, 18)
            Me.lblType.Text = "Type"
            Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(240, 25)
            Me.lblTitle.Text = "Position Line Item"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPosition
            '
            Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPosition.Location = New System.Drawing.Point(72, 25)
            Me.lblPosition.Name = "lblPosition"
            Me.lblPosition.Size = New System.Drawing.Size(81, 20)
            Me.lblPosition.Text = "Position"
            Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSelWgt
            '
            Me.lblSelWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSelWgt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblSelWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSelWgt.Location = New System.Drawing.Point(132, 99)
            Me.lblSelWgt.Name = "lblSelWgt"
            Me.lblSelWgt.Size = New System.Drawing.Size(81, 17)
            Me.lblSelWgt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblSelType
            '
            Me.lblSelType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblSelType.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblSelType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblSelType.Location = New System.Drawing.Point(24, 99)
            Me.lblSelType.Name = "lblSelType"
            Me.lblSelType.Size = New System.Drawing.Size(81, 17)
            Me.lblSelType.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.lblWait)
            Me.fraWait.Controls.Add(Me.lblHeader)
            Me.fraWait.Location = New System.Drawing.Point(0, 55)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(240, 69)
            '
            'lblWait
            '
            Me.lblWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWait.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblWait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWait.Location = New System.Drawing.Point(24, 39)
            Me.lblWait.Name = "lblWait"
            Me.lblWait.Size = New System.Drawing.Size(189, 25)
            Me.lblWait.Text = "Please Wait..."
            Me.lblWait.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblComments
            '
            Me.lblComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblComments.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblComments.Location = New System.Drawing.Point(0, 119)
            Me.lblComments.Name = "lblComments"
            Me.lblComments.Size = New System.Drawing.Size(240, 25)
            Me.lblComments.Text = "Comments"
            Me.lblComments.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(239, 25)
            Me.lblHeader.Text = "Retrieving Data"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmPositionLineItems
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraPosition)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmPositionLineItems"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraPosition.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraPosition As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents btnConfirmLoad As System.Windows.Forms.Button
        Friend WithEvents cmbPos As System.Windows.Forms.ComboBox
        Friend WithEvents lblComments As System.Windows.Forms.Label
        Friend WithEvents lblWeight As System.Windows.Forms.Label
        Friend WithEvents lblType As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblPosition As System.Windows.Forms.Label
        Friend WithEvents lblSelWgt As System.Windows.Forms.Label
        Friend WithEvents lblSelType As System.Windows.Forms.Label
        Friend WithEvents lblSelComments As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents lblWait As System.Windows.Forms.Label
    End Class

End Namespace