Imports OpenNETCF.Windows.Forms
Namespace NWA.Safetrac.Scanner.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmCreateMultipleContainers
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
            Me.fraContainerList = New System.Windows.Forms.Panel
            Me.dgContainerList = New System.Windows.Forms.DataGrid
            Me.btnAdd = New System.Windows.Forms.Button
            Me.btnRegister = New System.Windows.Forms.Button
            Me.btnRemove = New System.Windows.Forms.Button
            Me.lblDateHeader = New System.Windows.Forms.Label
            Me.lblFlightHeader = New System.Windows.Forms.Label
            Me.lblFlight = New System.Windows.Forms.Label
            Me.lblDate = New System.Windows.Forms.Label
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.lblWait = New System.Windows.Forms.Label
            Me.fraContainerList.SuspendLayout()
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraContainerList
            '
            Me.fraContainerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraContainerList.Controls.Add(Me.dgContainerList)
            Me.fraContainerList.Controls.Add(Me.btnAdd)
            Me.fraContainerList.Controls.Add(Me.btnRegister)
            Me.fraContainerList.Controls.Add(Me.btnRemove)
            Me.fraContainerList.Controls.Add(Me.lblDateHeader)
            Me.fraContainerList.Controls.Add(Me.lblFlightHeader)
            Me.fraContainerList.Controls.Add(Me.lblFlight)
            Me.fraContainerList.Controls.Add(Me.lblDate)
            Me.fraContainerList.Controls.Add(Me.fraWait)
            Me.fraContainerList.Location = New System.Drawing.Point(2, 36)
            Me.fraContainerList.Name = "fraContainerList"
            Me.fraContainerList.Size = New System.Drawing.Size(237, 228)
            '
            'dgContainerList
            '
            Me.dgContainerList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dgContainerList.Location = New System.Drawing.Point(1, 36)
            Me.dgContainerList.Name = "dgContainerList"
            Me.dgContainerList.Size = New System.Drawing.Size(236, 115)
            Me.dgContainerList.TabIndex = 15
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnAdd.Location = New System.Drawing.Point(0, 157)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(115, 33)
            Me.btnAdd.TabIndex = 2
            Me.btnAdd.Text = "[1] Add"
            '
            'btnRegister
            '
            Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRegister.Enabled = False
            Me.btnRegister.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRegister.Location = New System.Drawing.Point(39, 193)
            Me.btnRegister.Name = "btnRegister"
            Me.btnRegister.Size = New System.Drawing.Size(159, 29)
            Me.btnRegister.TabIndex = 3
            Me.btnRegister.Text = "[7] Register"
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnRemove.Location = New System.Drawing.Point(121, 157)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(113, 33)
            Me.btnRemove.TabIndex = 4
            Me.btnRemove.Text = "[4] Remove"
            '
            'lblDateHeader
            '
            Me.lblDateHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDateHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDateHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDateHeader.Location = New System.Drawing.Point(129, 0)
            Me.lblDateHeader.Name = "lblDateHeader"
            Me.lblDateHeader.Size = New System.Drawing.Size(65, 16)
            Me.lblDateHeader.Text = "Date"
            Me.lblDateHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlightHeader
            '
            Me.lblFlightHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlightHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlightHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlightHeader.Location = New System.Drawing.Point(38, 0)
            Me.lblFlightHeader.Name = "lblFlightHeader"
            Me.lblFlightHeader.Size = New System.Drawing.Size(64, 16)
            Me.lblFlightHeader.Text = "Flight"
            Me.lblFlightHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblFlight
            '
            Me.lblFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblFlight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblFlight.Location = New System.Drawing.Point(38, 16)
            Me.lblFlight.Name = "lblFlight"
            Me.lblFlight.Size = New System.Drawing.Size(64, 17)
            Me.lblFlight.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblDate.Location = New System.Drawing.Point(129, 16)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New System.Drawing.Size(65, 17)
            Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
            'frmCreateMultipleContainers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 300)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraContainerList)
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.Name = "frmCreateMultipleContainers"
            Me.Text = "frm1"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraContainerList.ResumeLayout(False)
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraContainerList As System.Windows.Forms.Panel
        Friend WithEvents dgContainerList As System.Windows.Forms.DataGrid
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents btnRegister As System.Windows.Forms.Button
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents lblDateHeader As System.Windows.Forms.Label
        Friend WithEvents lblFlightHeader As System.Windows.Forms.Label
        Friend WithEvents lblFlight As System.Windows.Forms.Label
        Friend WithEvents lblDate As System.Windows.Forms.Label
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents lblWait As System.Windows.Forms.Label
    End Class
End Namespace