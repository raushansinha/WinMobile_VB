Namespace NWA.Safetrac.Scanner.UI


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class dlgRetrievingData
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
            Me.fraWait = New OpenNETCF.Windows.Forms.GroupBox
            Me.lblHeader = New System.Windows.Forms.Label
            Me.lblWait = New System.Windows.Forms.Label
            Me.fraWait.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraWait
            '
            Me.fraWait.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.fraWait.Controls.Add(Me.lblHeader)
            Me.fraWait.Controls.Add(Me.lblWait)
            Me.fraWait.Location = New System.Drawing.Point(4, 0)
            Me.fraWait.Name = "fraWait"
            Me.fraWait.Size = New System.Drawing.Size(233, 105)
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
            Me.lblWait.Location = New System.Drawing.Point(32, 48)
            Me.lblWait.Name = "lblWait"
            Me.lblWait.Size = New System.Drawing.Size(169, 25)
            Me.lblWait.Text = "Please Wait..."
            Me.lblWait.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dlgRetrievingData
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(240, 105)
            Me.ControlBox = False
            Me.Controls.Add(Me.fraWait)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(0, 0)
            Me.Menu = Me.mainMenu1
            Me.MinimizeBox = False
            Me.Name = "dlgRetrievingData"
            Me.Text = "Form4"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.fraWait.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents fraWait As OpenNETCF.Windows.Forms.GroupBox
        Friend WithEvents lblHeader As System.Windows.Forms.Label
        Friend WithEvents lblWait As System.Windows.Forms.Label
    End Class
End Namespace