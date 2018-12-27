
Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUnloadFreight
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
            Me.fraScan = New OpenNETCF.Windows.Forms.GroupBox
            Me.txtAWB = New System.Windows.Forms.TextBox
            Me.lbl1 = New System.Windows.Forms.Label
            Me.fraLocation = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblBinBulk = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.fraScan.SuspendLayout()
            Me.fraLocation.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraScan
            '
            Me.fraScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraScan.Controls.Add(Me.txtAWB)
            Me.fraScan.Controls.Add(Me.lbl1)
            Me.fraScan.Location = New System.Drawing.Point(0, 48)
            Me.fraScan.Name = "fraScan"
            Me.fraScan.Size = New System.Drawing.Size(233, 81)
            '
            'txtAWB
            '
            Me.txtAWB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.txtAWB.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
            Me.txtAWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtAWB.Location = New System.Drawing.Point(8, 40)
            Me.txtAWB.Name = "txtAWB"
            Me.txtAWB.Size = New System.Drawing.Size(217, 32)
            Me.txtAWB.TabIndex = 0
            '
            'lbl1
            '
            Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lbl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lbl1.Location = New System.Drawing.Point(0, 8)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(233, 25)
            Me.lbl1.Text = "Scan Air Waybill (AWB)"
            Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraLocation
            '
            Me.fraLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraLocation.Controls.Add(Me.Label2)
            Me.fraLocation.Controls.Add(Me.Label3)
            Me.fraLocation.Controls.Add(Me.lblFlight)
            Me.fraLocation.Controls.Add(Me.Label11)
            Me.fraLocation.Controls.Add(Me.Label4)
            Me.fraLocation.Controls.Add(Me.lblDate)
            Me.fraLocation.Controls.Add(Me.lblBinBulk)
            Me.fraLocation.Location = New System.Drawing.Point(0, 154)
            Me.fraLocation.Name = "fraLocation"
            Me.fraLocation.Size = New System.Drawing.Size(233, 103)
            Me.fraLocation.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(233, 25)
            Me.Label2.Text = "Old Location"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(80, 24)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 17)
            Me.Label3.Text = "Flight"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(80, 40)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(81, 17)
            Me.lblFlight.Text = "NW0013"
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(0, 24)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(81, 17)
            Me.Label11.Text = "Bin/Bulk"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(160, 24)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 17)
            Me.Label4.Text = "Date"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(160, 40)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(65, 17)
            Me.lblDate.Text = "26JUN"
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblBinBulk
            '
            Me.lblBinBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBinBulk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBinBulk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBinBulk.Location = New System.Drawing.Point(8, 40)
            Me.lblBinBulk.Name = "lblBinBulk"
            Me.lblBinBulk.Size = New System.Drawing.Size(65, 17)
            Me.lblBinBulk.Text = "2"
            Me.lblBinBulk.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.Label17)
            Me.fraWait.Controls.Add(Me.Label18)
            Me.fraWait.Location = New System.Drawing.Point(0, 119)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 103)
            Me.fraWait.Visible = False
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(32, 48)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(169, 25)
            Me.Label17.Text = "Please Wait..."
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(0, 0)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(233, 25)
            Me.Label18.Text = "Retrieving Data"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmUnloadFreight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraWait)
            Me.Controls.Add(Me.fraLocation)
            Me.Controls.Add(Me.fraScan)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmUnloadFreight"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraScan.ResumeLayout(False)
            Me.fraLocation.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraScan As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents txtAWB As System.Windows.Forms.TextBox
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents fraLocation As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblBinBulk As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
    End Class

End Namespace