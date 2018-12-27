
Imports System.Windows.Forms.Control
Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmViewLineItems
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
            Me.fraItems = New System.Windows.Forms.Panel
            Me.dgLineItems = New System.Windows.Forms.DataGrid
            Me.lblPcs = New System.Windows.Forms.Label
            Me.lblWgt = New System.Windows.Forms.Label
            Me.btnUpdateAWBs = New System.Windows.Forms.Button
            Me.btnLoad = New System.Windows.Forms.Button
            Me.btnRefresh = New System.Windows.Forms.Button
            Me.lblDateHeader = New System.Windows.Forms.Label
            Me.lblFlightHeader = New System.Windows.Forms.Label
            Me.lblPosition = New System.Windows.Forms.Label
            Me.lblCommodity = New System.Windows.Forms.Label
            Me.lblRemarks = New System.Windows.Forms.Label
            Me.lblLastRefHeader = New System.Windows.Forms.Label
            Me.lblULD = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.lblLastRefresh = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.lblWait = New System.Windows.Forms.Label
            Me.tmrLastRefresh = New System.Windows.Forms.Timer
            Me.fraItems.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraItems
            '
            Me.fraItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraItems.Controls.Add(Me.dgLineItems)
            Me.fraItems.Controls.Add(Me.lblPcs)
            Me.fraItems.Controls.Add(Me.lblWgt)
            Me.fraItems.Controls.Add(Me.btnUpdateAWBs)
            Me.fraItems.Controls.Add(Me.btnLoad)
            Me.fraItems.Controls.Add(Me.btnRefresh)
            Me.fraItems.Controls.Add(Me.lblDateHeader)
            Me.fraItems.Controls.Add(Me.lblFlightHeader)
            Me.fraItems.Controls.Add(Me.lblPosition)
            Me.fraItems.Controls.Add(Me.lblCommodity)
            Me.fraItems.Controls.Add(Me.lblRemarks)
            Me.fraItems.Controls.Add(Me.lblLastRefHeader)
            Me.fraItems.Controls.Add(Me.lblULD)
            Me.fraItems.Controls.Add(Me.lblFlight)
            Me.fraItems.Controls.Add(Me.lblDate)
            Me.fraItems.Controls.Add(Me.lblLastRefresh)
            Me.fraItems.Controls.Add(Me.fraWait)
            Me.fraItems.Location = New System.Drawing.Point(0, 47)
            Me.fraItems.Name = "fraItems"
            Me.fraItems.Size = New System.Drawing.Size(237, 228)
            '
            'dgLineItems
            '
            Me.dgLineItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dgLineItems.ColumnHeadersVisible = False
            Me.dgLineItems.Location = New System.Drawing.Point(1, 48)
            Me.dgLineItems.Name = "dgLineItems"
            Me.dgLineItems.RowHeadersVisible = False
            Me.dgLineItems.Size = New System.Drawing.Size(236, 103)
            Me.dgLineItems.TabIndex = 15
            '
            'lblPcs
            '
            Me.lblPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPcs.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblPcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPcs.Location = New System.Drawing.Point(113, 32)
            Me.lblPcs.Name = "lblPcs"
            Me.lblPcs.Size = New System.Drawing.Size(29, 17)
            Me.lblPcs.Text = "Pcs"
            Me.lblPcs.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblWgt
            '
            Me.lblWgt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWgt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblWgt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWgt.Location = New System.Drawing.Point(143, 32)
            Me.lblWgt.Name = "lblWgt"
            Me.lblWgt.Size = New System.Drawing.Size(33, 17)
            Me.lblWgt.Text = "Wgt"
            Me.lblWgt.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnUpdateAWBs
            '
            Me.btnUpdateAWBs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnUpdateAWBs.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnUpdateAWBs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnUpdateAWBs.Location = New System.Drawing.Point(2, 157)
            Me.btnUpdateAWBs.Name = "btnUpdateAWBs"
            Me.btnUpdateAWBs.Size = New System.Drawing.Size(115, 33)
            Me.btnUpdateAWBs.TabIndex = 2
            Me.btnUpdateAWBs.Text = "Update AWBs"
            '
            'btnLoad
            '
            Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnLoad.Enabled = False
            Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnLoad.Location = New System.Drawing.Point(24, 193)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(181, 29)
            Me.btnLoad.TabIndex = 3
            Me.btnLoad.Text = "[ENT] Position Item"
            '
            'btnRefresh
            '
            Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRefresh.Location = New System.Drawing.Point(121, 157)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(113, 33)
            Me.btnRefresh.TabIndex = 4
            Me.btnRefresh.Text = "Refresh Lines"
            '
            'lblDateHeader
            '
            Me.lblDateHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDateHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDateHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDateHeader.Location = New System.Drawing.Point(82, 0)
            Me.lblDateHeader.Name = "lblDateHeader"
            Me.lblDateHeader.Size = New System.Drawing.Size(69, 16)
            Me.lblDateHeader.Text = "Date"
            Me.lblDateHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightHeader
            '
            Me.lblFlightHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlightHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblFlightHeader.Name = "lblFlightHeader"
            Me.lblFlightHeader.Size = New System.Drawing.Size(85, 16)
            Me.lblFlightHeader.Text = "Flight"
            Me.lblFlightHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPosition
            '
            Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblPosition.Location = New System.Drawing.Point(4, 32)
            Me.lblPosition.Name = "lblPosition"
            Me.lblPosition.Size = New System.Drawing.Size(25, 17)
            Me.lblPosition.Text = "Po"
            '
            'lblCommodity
            '
            Me.lblCommodity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblCommodity.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblCommodity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCommodity.Location = New System.Drawing.Point(38, 32)
            Me.lblCommodity.Name = "lblCommodity"
            Me.lblCommodity.Size = New System.Drawing.Size(29, 17)
            Me.lblCommodity.Text = "C"
            Me.lblCommodity.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblRemarks
            '
            Me.lblRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblRemarks.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblRemarks.Location = New System.Drawing.Point(172, 32)
            Me.lblRemarks.Name = "lblRemarks"
            Me.lblRemarks.Size = New System.Drawing.Size(68, 17)
            Me.lblRemarks.Text = "Remarks"
            Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblLastRefHeader
            '
            Me.lblLastRefHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLastRefHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblLastRefHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLastRefHeader.Location = New System.Drawing.Point(150, 0)
            Me.lblLastRefHeader.Name = "lblLastRefHeader"
            Me.lblLastRefHeader.Size = New System.Drawing.Size(87, 16)
            Me.lblLastRefHeader.Text = "Last Refresh"
            Me.lblLastRefHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblULD
            '
            Me.lblULD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblULD.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblULD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblULD.Location = New System.Drawing.Point(73, 32)
            Me.lblULD.Name = "lblULD"
            Me.lblULD.Size = New System.Drawing.Size(35, 17)
            Me.lblULD.Text = "ULD"
            Me.lblULD.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(0, 16)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(85, 17)
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(91, 16)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(54, 17)
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblLastRefresh
            '
            Me.lblLastRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblLastRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblLastRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblLastRefresh.Location = New System.Drawing.Point(150, 16)
            Me.lblLastRefresh.Name = "lblLastRefresh"
            Me.lblLastRefresh.Size = New System.Drawing.Size(84, 17)
            Me.lblLastRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.lblHeader)
            Me.fraWait.Controls.Add(Me.lblWait)
            Me.fraWait.Location = New System.Drawing.Point(0, 52)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 81)
            Me.fraWait.Visible = False
            '
            'lblHeader
            '
            Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblHeader.Location = New System.Drawing.Point(0, 0)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(233, 25)
            Me.lblHeader.Text = "Retrieving Data"
            Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblWait
            '
            Me.lblWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblWait.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
            Me.lblWait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblWait.Location = New System.Drawing.Point(35, 38)
            Me.lblWait.Name = "lblWait"
            Me.lblWait.Size = New System.Drawing.Size(169, 25)
            Me.lblWait.Text = "Please Wait..."
            Me.lblWait.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'tmrLastRefresh
            '
            Me.tmrLastRefresh.Enabled = True
            Me.tmrLastRefresh.Interval = 2000
            '
            'frmViewLineItems
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraItems)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "frmViewLineItems"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraItems.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraItems As System.Windows.Forms.Panel
        'Friend WithEvents gridItems As System.Windows.Forms.Control
        Friend WithEvents lblPcs As System.Windows.Forms.Label
        Friend WithEvents lblWgt As System.Windows.Forms.Label
        Friend WithEvents btnUpdateAWBs As System.Windows.Forms.Button
        Friend WithEvents btnLoad As System.Windows.Forms.Button
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents lblDateHeader As System.Windows.Forms.Label
        Friend WithEvents lblFlightHeader As System.Windows.Forms.Label
        Friend WithEvents lblPosition As System.Windows.Forms.Label
        Friend WithEvents lblCommodity As System.Windows.Forms.Label
        Friend WithEvents lblRemarks As System.Windows.Forms.Label
        Friend WithEvents lblLastRefHeader As System.Windows.Forms.Label
        Friend WithEvents lblULD As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents lblLastRefresh As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents lblWait As System.Windows.Forms.Label
        Private WithEvents tmrLastRefresh As System.Windows.Forms.Timer
        Private WithEvents dgLineItems As System.Windows.Forms.DataGrid
    End Class
End Namespace