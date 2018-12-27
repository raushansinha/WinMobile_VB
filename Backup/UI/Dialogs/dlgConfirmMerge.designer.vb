Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgConfirmMerge
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
            Me.fraScanDetected = New OpenNETCF.Windows.Forms.GroupBox
            Me.cmdScannedTo = New System.Windows.Forms.Button
            Me.cmdScannedFrom = New System.Windows.Forms.Button
            Me.lblScanBarcode = New System.Windows.Forms.Label
            Me.lblchoice = New System.Windows.Forms.Label
            Me.lblBarcodeScanned = New System.Windows.Forms.Label
            Me.fraScanDetected.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraScanDetected
            '
            Me.fraScanDetected.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScanDetected.Controls.Add(Me.cmdScannedTo)
            Me.fraScanDetected.Controls.Add(Me.cmdScannedFrom)
            Me.fraScanDetected.Controls.Add(Me.lblScanBarcode)
            Me.fraScanDetected.Controls.Add(Me.lblchoice)
            Me.fraScanDetected.Controls.Add(Me.lblBarcodeScanned)
            Me.fraScanDetected.Location = New System.Drawing.Point(3, 3)
            Me.fraScanDetected.Name = "fraScanDetected"
            Me.fraScanDetected.Size = New System.Drawing.Size(236, 153)
            '
            'cmdScannedTo
            '
            Me.cmdScannedTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdScannedTo.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdScannedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdScannedTo.Location = New System.Drawing.Point(128, 90)
            Me.cmdScannedTo.Name = "cmdScannedTo"
            Me.cmdScannedTo.Size = New System.Drawing.Size(97, 41)
            Me.cmdScannedTo.TabIndex = 0
            Me.cmdScannedTo.Text = "(C) &To"
            '
            'cmdScannedFrom
            '
            Me.cmdScannedFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.cmdScannedFrom.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.cmdScannedFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cmdScannedFrom.Location = New System.Drawing.Point(8, 90)
            Me.cmdScannedFrom.Name = "cmdScannedFrom"
            Me.cmdScannedFrom.Size = New System.Drawing.Size(97, 41)
            Me.cmdScannedFrom.TabIndex = 1
            Me.cmdScannedFrom.Text = "(A) &From"
            '
            'lblScanBarcode
            '
            Me.lblScanBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblScanBarcode.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblScanBarcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblScanBarcode.Location = New System.Drawing.Point(0, 0)
            Me.lblScanBarcode.Name = "lblScanBarcode"
            Me.lblScanBarcode.Size = New System.Drawing.Size(235, 25)
            Me.lblScanBarcode.Text = "Scanned Barcode"
            Me.lblScanBarcode.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblchoice
            '
            Me.lblchoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblchoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblchoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblchoice.Location = New System.Drawing.Point(22, 36)
            Me.lblchoice.Name = "lblchoice"
            Me.lblchoice.Size = New System.Drawing.Size(193, 41)
            Me.lblchoice.Text = "Is this the FROM or TO location?"
            Me.lblchoice.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBarcodeScanned
            '
            Me.lblBarcodeScanned.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBarcodeScanned.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.lblBarcodeScanned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBarcodeScanned.Location = New System.Drawing.Point(8, 24)
            Me.lblBarcodeScanned.Name = "lblBarcodeScanned"
            Me.lblBarcodeScanned.Size = New System.Drawing.Size(217, 25)
            Me.lblBarcodeScanned.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmMergeDailogBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 160)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraScanDetected)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 100)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmMergeDailogBox"
            Me.fraScanDetected.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraScanDetected As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents cmdScannedTo As System.Windows.Forms.Button
        Friend WithEvents cmdScannedFrom As System.Windows.Forms.Button
        Friend WithEvents lblScanBarcode As System.Windows.Forms.Label
        Friend WithEvents lblchoice As System.Windows.Forms.Label
        Friend WithEvents lblBarcodeScanned As System.Windows.Forms.Label
    End Class
End Namespace
