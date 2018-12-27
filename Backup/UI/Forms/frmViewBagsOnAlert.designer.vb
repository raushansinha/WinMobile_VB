Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmViewBagsOnAlert
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
            Me.fraList = New OpenNETCF.Windows.Forms.GroupBox
            Me.lstAlertBags = New System.Windows.Forms.ListBox
            Me.lblStation = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.btnRemove = New System.Windows.Forms.Button
            Me.lblBagAlert = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblWait = New System.Windows.Forms.Label
            Me.lblRetrieving = New System.Windows.Forms.Label
            Me.fraList.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraList
            '
            Me.fraList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraList.Controls.Add(Me.lstAlertBags)
            Me.fraList.Controls.Add(Me.lblStation)
            Me.fraList.Controls.Add(Me.lblDate)
            Me.fraList.Controls.Add(Me.lblFlight)
            Me.fraList.Controls.Add(Me.btnRemove)
            Me.fraList.Controls.Add(Me.lblBagAlert)
            Me.fraList.Controls.Add(Me.fraWait)
            Me.fraList.Location = New System.Drawing.Point(4, 48)
            Me.fraList.Name = "fraList"
            Me.fraList.Size = New System.Drawing.Size(233, 233)
            '
            'lstAlertBags
            '
            Me.lstAlertBags.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lstAlertBags.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular)
            Me.lstAlertBags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lstAlertBags.Location = New System.Drawing.Point(8, 40)
            Me.lstAlertBags.Name = "lstAlertBags"
            Me.lstAlertBags.Size = New System.Drawing.Size(217, 117)
            Me.lstAlertBags.TabIndex = 0
            '
            'lblStation
            '
            Me.lblStation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblStation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblStation.Location = New System.Drawing.Point(184, 24)
            Me.lblStation.Name = "lblStation"
            Me.lblStation.Size = New System.Drawing.Size(41, 17)
            Me.lblStation.Text = "MSP"
            Me.lblStation.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(96, 24)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(41, 17)
            Me.lblDate.Text = "10JAN"
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(8, 24)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(73, 17)
            Me.lblFlight.Text = "NWXXXX"
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRemove.Location = New System.Drawing.Point(28, 175)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(185, 33)
            Me.btnRemove.TabIndex = 0
            Me.btnRemove.Text = "[ENT] Remove Alert"
            '
            'lblBagAlert
            '
            Me.lblBagAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblBagAlert.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblBagAlert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblBagAlert.Location = New System.Drawing.Point(0, 0)
            Me.lblBagAlert.Name = "lblBagAlert"
            Me.lblBagAlert.Size = New System.Drawing.Size(233, 24)
            Me.lblBagAlert.Text = "Bags On Alert"
            Me.lblBagAlert.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.lblRetrieving)
            Me.fraWait.Controls.Add(Me.lblWait)
            Me.fraWait.Location = New System.Drawing.Point(0, 104)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 129)
            Me.fraWait.Visible = False
            '
            'lblWait
            '
            Me.lblWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWait.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblWait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWait.Location = New System.Drawing.Point(8, 88)
            Me.lblWait.Name = "lblWait"
            Me.lblWait.Size = New System.Drawing.Size(217, 33)
            Me.lblWait.Text = "Please Wait..."
            Me.lblWait.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRetrieving
            '
            Me.lblRetrieving.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRetrieving.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular)
            Me.lblRetrieving.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRetrieving.Location = New System.Drawing.Point(8, 16)
            Me.lblRetrieving.Name = "lblRetrieving"
            Me.lblRetrieving.Size = New System.Drawing.Size(217, 65)
            Me.lblRetrieving.Text = "Retrieving Bagtag Alert Data"
            Me.lblRetrieving.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'frmViewBagsOnAlert
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraList)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmViewBagsOnAlert"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraList.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraList As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lstAlertBags As System.Windows.Forms.ListBox
        Friend WithEvents lblStation As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents lblBagAlert As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblRetrieving As System.Windows.Forms.Label
        Friend WithEvents lblWait As System.Windows.Forms.Label
    End Class
End Namespace

