Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmBinBulkInquiryForSummary

        '' Private _strFlightDate As String
        ''  Private _strBinBulkNum As String
        '' Private _strFlightNum As String
        ''Private _diReturn As Dictionary(Of String, String)
        '' Private _strBinBulkHdr As String

        'Private Sub frmBinBulkInquiry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Try
        '        ' TASK: Called when this function's form is ACTIVATEd;
        '        '       Get current session values to fill in

        '        ' Set Flight
        '        txtFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
        '        ' Set Flight Date
        '        txtDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
        '        ' Set Bin Bulk
        '        'Pending - Change to current BinBulk - Amareswari
        '        txtBinBulk.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'End Sub


        'Private Sub btnLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookup.Click
        '    Try
        '        If MyBase.IsErrorEnabled Then
        '            MyBase.ClearError()
        '            Exit Sub
        '        End If

        '        ' validate flight length
        '        If txtFlight.Text = "" Then
        '            MyBase.SetError("INVALID FLIGHT")
        '            MyBase.SetFocus(Me.txtFlight)
        '            Exit Sub
        '        End If

        '        ' validate date length
        '        If txtDate.Text = "" Then
        '            MyBase.SetError("INVALID DATE")
        '            MyBase.SetFocus(Me.txtDate)
        '            Exit Sub
        '        End If

        '        Dim strFlightNum As String
        '        Dim strBagtag As String
        '        Dim strBinBulkNum As String
        '        Dim strBinBulkHeader As String

        '        ' Validate bin/bulk syntax if not "ALL"
        '        strBinBulkNum = txtBinBulk.Text.Trim
        '        If (strBinBulkNum <> "ALL") And _
        '           (strBinBulkNum <> String.Empty) Then
        '            Dim iRet As BinBulkReturnCodes
        '            iRet = Validate.IsBinBulkValid(strBinBulkNum)
        '            If iRet <> BinBulkReturnCodes.BinValid And iRet <> BinBulkReturnCodes.BulkValid Then
        '                MyBase.SetError("INVALID BIN BULK")
        '                MyBase.SetFocus(Me.txtBinBulk)
        '                Exit Sub
        '            End If
        '        End If

        '        ' Validate flight syntax
        '        strFlightNum = txtFlight.Text.Trim
        '        If Validate.IsNWAFlightValid(strFlightNum) Then
        '            txtFlight.Text = strFlightNum
        '        Else
        '            MyBase.SetError("Invalid Flt FMT")
        '            MyBase.SetFocus(Me.txtFlight)
        '            Exit Sub
        '        End If

        '        ' Validate date syntax
        '        Dim dtDeparture As NWADateTime

        '        Try
        '            dtDeparture = New NWADateTime(txtDate.Text.Trim)
        '            txtDate.Text = dtDeparture.NWAFormat
        '        Catch safetracExp As SafetracException
        '            MyBase.SetError(DisplayMessages.InvalidDateFormat)
        '            MyBase.SetFocus(Me.txtDate)
        '            Exit Sub
        '        Catch exp As Exception
        '            Logger.LogException(exp)
        '            MyBase.SetError(DisplayMessages.InvalidDateFormat)
        '            MyBase.SetFocus(Me.txtDate)
        '            Exit Sub
        '        End Try


        '        'if  flight is configured
        '        If MyBase.FlightsCollection.IsFlightValid(strFlightNum, dtDeparture) Then
        '            Dim retCode As BinBulkReturnCodes
        '            retCode = MyBase.FlightsCollection.Flights(strFlightNum, dtDeparture).IsBinBulkValid(strBinBulkNum)
        '            If retCode = BinBulkReturnCodes.BinValid Or retCode = BinBulkReturnCodes.BulkValid Then
        '                'Checking availability as BIN/BULK 
        '                If retCode = BinBulkReturnCodes.BinValid Then
        '                    strBinBulkHeader = "BIN"
        '                Else
        '                    strBinBulkHeader = "BULK"
        '                End If
        '                FetchData()
        '            Else
        '                'Invalid Bin Bulk condition
        '                MyBase.SetError("INVALID BIN BULK")
        '                MyBase.SetFocus(Me.txtBinBulk)
        '            End If
        '        Else
        '            'Non configured Flight
        '            Try
        '                Dim diReturn As Dictionary(Of String, String)
        '                diReturn = Common.GetBinBulkSummary(strFlightNum, dtDeparture, strBinBulkNum)
        '                If diReturn Is Nothing Then
        '                    MyBase.SetError("FLIGHT NOT CONFIGURED")
        '                    Exit Sub
        '                Else
        '                    UIController.NextForm = New frmBinBulkSummary(diReturn, strBinBulkHeader)
        '                    UIController.NextForm.ShowDialog()
        '                End If
        '            Catch expSafetrac As SafetracException
        '                Select Case expSafetrac.ErrorCode
        '                    Case ReturnCodes.UnknownFlightDept
        '                        MyBase.SetError("Unknown Flight Departure")
        '                    Case ReturnCodes.DatabaseError
        '                        MyBase.SetError("DATABASE ERROR")
        '                    Case ReturnCodes.NotConfiguredFlight
        '                        MyBase.SetError("FLIGHT NOT CONFIGURED")
        '                End Select
        '            Catch ex As Exception

        '            End Try
        '        End If
        '    Catch ex As Exception
        '    End Try
        'End Sub
        'Private Sub btnLookup_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnLookup.KeyPress
        '    If e.KeyChar = (Chr(Keys.Enter)) Then
        '        If MyBase.IsErrorEnabled Then
        '            MyBase.ClearError()
        '            Exit Sub
        '        Else
        '            Me.btnLookup_Click(Me, Nothing)
        '        End If
        '    End If
        'End Sub
        'Private Sub txtBinBulk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBinBulk.GotFocus
        '    MyBase.SetFocus(Me.txtBinBulk)
        'End Sub

        'Private Sub txtBinBulk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBinBulk.KeyDown

        'End Sub
        'Private Sub txtBinBulk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBinBulk.KeyPress

        '    If MyBase.IsErrorEnabled Then
        '        If e.KeyChar = (Chr(Keys.Enter)) Then
        '            MyBase.ClearError()
        '        End If
        '        Exit Sub
        '    Else
        '        Select Case e.KeyChar
        '            Case (Chr(Keys.Enter))
        '                ' Check for empy bin bulk
        '                If Trim(txtBinBulk.Text) = "" Then
        '                    txtBinBulk.Text = "ALL"
        '                End If
        '                Me.btnLookup_Click(Me, Nothing)
        '            Case (Chr(Keys.L))
        '                ' Code for "ALL" hotkey ("L")
        '                txtBinBulk.Text = "ALL"
        '                MyBase.SetFocus(txtFlight)
        '            Case Else
        '                FormatKeysForBinBulk(txtBinBulk, AscW(e.KeyChar))
        '        End Select
        '    End If
        'End Sub
        'Private Sub txtBinBulk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBinBulk.LostFocus
        '    ' If BLANK, default to "ALL"
        '    If Trim(txtBinBulk.Text) = "" Then
        '        txtBinBulk.Text = "ALL"
        '    End If
        'End Sub
        'Private Sub txtFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.GotFocus
        '    MyBase.SetFocus(txtFlight)
        'End Sub
        'Private Sub txtFlight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlight.KeyPress
        '    If MyBase.IsErrorEnabled = True Then
        '        If e.KeyChar = (Chr(Keys.Enter)) Then
        '            ' Clear any errors previously displayed
        '            MyBase.ClearError()
        '        End If
        '        Exit Sub
        '    Else
        '        If e.KeyChar = (Chr(Keys.Enter)) Then
        '            btnLookup_Click(Me, Nothing)
        '        End If
        '    End If
        '    MyBase.FormatKeysForFlight(txtFlight, AscW(e.KeyChar))
        'End Sub
        'Private Sub txtFlight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFlight.LostFocus
        '    Dim strFlightNum As String = txtFlight.Text.Trim
        '    If Validate.IsNWAFlightValid(strFlightNum) Then
        '        txtFlight.Text = strFlightNum
        '    End If
        'End Sub
        'Private Sub txtDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDate.KeyPress
        '    If MyBase.IsErrorEnabled = True Then
        '        If e.KeyChar = (Chr(Keys.Enter)) Then
        '            MyBase.ClearError()
        '        End If
        '        Exit Sub
        '    Else
        '        If e.KeyChar = (Chr(Keys.Enter)) Then
        '            btnLookup_Click(Me, Nothing)
        '        End If
        '    End If
        '    FormatKeysForDate(txtDate, AscW(e.KeyChar))
        'End Sub
        'Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        '    txtDate.Text = Validate.ToFiveDigitDate(txtDate.Text)
        'End Sub
        'Private Sub frmBinBulkInquiry2_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        '    MyBase.Reader.Disable()
        'End Sub
        'Private Sub frmBinBulkInquiry2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '    If e.KeyCode = Keys.Escape Then
        '        'Check if we need to go to Main menu
        '    End If
        'End Sub

        'Private Sub btnLookup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnLookup.KeyDown
        '    btnLookup_Click(Me, Nothing)
        'End Sub

        'Private Sub FetchData()

        'End Sub

        'Private Sub fraParms_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraParms.GotFocus

        'End Sub

        'Private Sub txtFlight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlight.TextChanged

        'End Sub

        Private Sub frmBinBulkInquiryForSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace