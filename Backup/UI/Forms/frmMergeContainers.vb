
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmMergeContainers

        Private _blnFromConfirmed As Boolean
        Private _blnToConfirmed As Boolean
        Private _strScannedValue As String

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            If Validate.IsContainerNumValid(e.ScannedValue) Then
                fraFrom.Enabled = True
                fraScanDetected.Visible = True
                _strScannedValue = e.ScannedValue
                fraScanDetected.BringToFront()
            End If
        End Sub
        Private Sub frmMergeContainers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                MyBase.SetHeader("Merge ULD/Cart/Bin")
                cmbCommod.SelectedIndex = 0
                txtPcsAWB.Text = "ALL"
                ResetFromFrame()
                ResetToFrame()
                ' populate the gentral commoditity type. values are BAGS, MAIL, FRT
                'Default value is ALL . At the present, added the values to combobox at design time. 
                ' Set flight
                txtFromFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                txtToFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                ' Set date
                txtFromDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                txtToDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                ShowFromFrame(True)
                ShowToFrame(False)
                'Set Focus
                txtFromULD.Focus()
                ' Hide status
                MyBase.ClearError()
                ' Enable scanner
                MyBase.Reader.Enable()
            Catch exSafetrac As SafetracException
                Select Case exSafetrac.ErrorCode
                    Case ReturnCodes.Exception
                        'MyBase.SetError(exSafetrac.ToString)
                End Select
            End Try
        End Sub
        Private Sub cmbCommod_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCommod.SelectedValueChanged
            If cmbCommod.Text = "FRT" Then
                lblPcsAWB.Text = "AWBs"
            Else
                lblPcsAWB.Text = "Pieces"
            End If

            ' Only allow "ALL" pieces if commod selected is all/mail/frt
            If cmbCommod.Text = "BAGS" Then
                txtPcsAWB.Enabled = True
                txtPcsAWB.Text = String.Empty
                MyBase.SetFocus(txtPcsAWB)
            Else
                txtPcsAWB.Text = "ALL"
                txtPcsAWB.Enabled = False
                MyBase.SetFocus(txtFromULD)
            End If
            MyBase.ShowControl(fraFrom)
            txtFromULD.Text = String.Empty
            txtToULD.Text = String.Empty
            MyBase.HideControl(fraTo)
        End Sub

        'Clear FromFrame field's value
        Public Sub ResetFromFrame()
            lblFromType.Text = String.Empty
            txtFromFlight.Text = String.Empty
            txtFromDate.Text = String.Empty
        End Sub

        'Clear ToFrame field's value
        Public Sub ResetToFrame()
            txtToULD.Text = String.Empty
            lblToType.Text = String.Empty
            txtToFlight.Text = String.Empty
            txtToDate.Text = String.Empty
        End Sub

        Public Sub ShowFromFrame(ByVal bFlag As Boolean)
            fraFrom.Visible = bFlag
            If bFlag Then
                txtFromDate.Text = Validate.VBDateToNWA(MyBase.FlightsCollection.CurrentFlight.DepartureDate.VBFormat)
            End If
        End Sub

        Private Sub txtFromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFromDate.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                txtFromDate_LostFocus(Me, Nothing)
                ' Check inputs
                If Not ValidateForm() Then
                    Exit Sub
                End If

                Dim retBinBulkCode As BinBulkReturnCodes
                retBinBulkCode = Validate.IsBinBulkValid(txtFromULD.Text)

                If retBinBulkCode = BinBulkReturnCodes.BulkValid Or retBinBulkCode = BinBulkReturnCodes.BinValid Then
                    BinBulkEntered(txtFromULD)
                Else
                    ULDEntered(txtFromULD)

                End If
            End If
            MyBase.FormatKeysForDate(txtFromDate, e.KeyValue)
        End Sub

        Private Sub txtFromDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromDate.LostFocus
            txtFromDate.Text = Validate.ToFiveDigitDate(txtFromDate.Text)
        End Sub

        Private Sub txtFromFlight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromFlight.GotFocus
            MyBase.SetFocus(txtFromFlight)
        End Sub
        Private Sub txtFromFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFromFlight.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Dim retBinBulkcode As BinBulkReturnCodes
                txtFromFlight_LostFocus(Me, Nothing)
                ' Check inputs
                If Not ValidateForm() Then
                    Exit Sub
                End If

                retBinBulkcode = Validate.IsBinBulkValid(txtFromULD.Text)

                If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                    BinBulkEntered(txtFromULD)
                Else
                    ULDEntered(txtFromULD)
                End If
            Else
                MyBase.FormatKeysForFlight(txtFromFlight, e.KeyCode)
            End If
        End Sub

        Private Sub txtFromFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromFlight.LostFocus
            Dim strTemp As String = txtFromFlight.Text.Trim
            If Validate.IsNWAFlightValid(strTemp) Then
                txtFromFlight.Text = strTemp
            End If
        End Sub

        Private Sub txtFromULD_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromULD.GotFocus
            MyBase.SetFocus(txtFromULD)
        End Sub

        Private Sub txtFromULD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFromULD.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Dim retBinBulkcode As BinBulkReturnCodes

                ' Check inputs
                txtFromULD_LostFocus(Me, Nothing)
                If Not ValidateForm() Then
                    Exit Sub
                End If

                retBinBulkcode = Validate.IsBinBulkValid(txtFromULD.Text)

                If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                    BinBulkEntered(txtFromULD)
                Else
                    ULDEntered(txtFromULD)
                End If
            Else
                MyBase.FormatKeysForULD(txtFromULD, e.KeyValue)
            End If
        End Sub

        Private Sub txtFromULD_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromULD.LostFocus
            Dim strTemp As String = txtFromULD.Text.Trim
            If IsULDNumFormatValid(strTemp) Then
                txtFromULD.Text = strTemp
            End If
        End Sub

        Private Sub txtPcsAWB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPcsAWB.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub txtToDate_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToDate.GotFocus
            MyBase.SetFocus(txtToDate)
        End Sub

        Private Sub txtToDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToDate.KeyDown
            ' Do not allow keystrokes if error onscreen;
            ' if user presses ENT, then clear error.  

            Try
                If e.KeyCode = Keys.Enter Then
                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearError()
                        Exit Sub
                    End If

                    Dim retBinBulkcode As BinBulkReturnCodes

                    txtToDate_LostFocus(Me, Nothing)
                    ' Check inputs
                    If Not ValidateForm() Then
                        Exit Sub
                    End If
                    retBinBulkcode = Validate.IsBinBulkValid(txtToULD.Text)
                    If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                        BinBulkEntered(txtToULD)
                    Else
                        ULDEntered(txtToULD)
                    End If
                Else
                    FormatKeysForDate(txtToDate, e.KeyCode)
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtToDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToDate.LostFocus
            txtToDate.Text = Validate.ToFiveDigitDate(txtToDate.Text)
        End Sub

        Private Sub txtToFlight_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToFlight.GotFocus
            MyBase.SetFocus(txtToFlight)
        End Sub

        Private Sub txtToFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToFlight.KeyDown

            ' Do not allow keystrokes if error onscreen;
            ' if user presses ENT, then clear error.

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If

                Dim retBinBulkcode As BinBulkReturnCodes

                txtToFlight_LostFocus(Me, Nothing)
                ' Check inputs
                If Not ValidateForm() Then
                    Exit Sub
                End If
                retBinBulkcode = Validate.IsBinBulkValid(txtToULD.Text)
                If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                    BinBulkEntered(txtToULD)
                Else
                    ULDEntered(txtToULD)
                End If
            Else
                MyBase.FormatKeysForFlight(txtFromFlight, e.KeyCode)
            End If
        End Sub

        Private Sub txtToFlight_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToFlight.LostFocus
            Dim strTemp As String = txtToFlight.Text.Trim
            If Validate.IsNWAFlightValid(strTemp) Then
                txtToFlight.Text = strTemp
            End If
        End Sub

        Private Sub txtToULD_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToULD.GotFocus
            MyBase.SetFocus(txtToULD)
        End Sub
        Private Sub txtToULD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtToULD.KeyDown
            ' Do not allow keystrokes if error onscreen;
            ' if user presses ENT, then clear error.

            Try
                If e.KeyCode = Keys.Enter Then
                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearError()
                        Exit Sub
                    End If

                    Dim retBinBulkcode As BinBulkReturnCodes

                    txtFromULD_LostFocus(Me, Nothing)
                    ' Check inputs
                    If Trim(txtFromFlight.Text) = Trim(txtToFlight.Text) Then
                        If Trim(txtFromULD.Text) = Trim(txtToULD.Text) Then
                            MyBase.SetFocus(txtToULD)
                            MyBase.SetFooter("INVALID BINBULK")
                            Exit Sub
                        End If
                    End If
                    If Not ValidateForm() Then
                        Exit Sub
                    End If
                    retBinBulkcode = Validate.IsBinBulkValid(txtToULD.Text)

                    If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                        BinBulkEntered(txtToULD)
                    Else
                        ULDEntered(txtToULD)
                    End If
                Else

                    'MyBase.FormatKeysForULD(txtToULD, e.KeyCode)
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtPcsAWB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPcsAWB.GotFocus
            MyBase.SetFocus(txtPcsAWB)
        End Sub

        Private Sub txtToULD_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToULD.LostFocus
            Dim strTemp As String = txtToULD.Text.Trim
            If Validate.IsULDNumFormatValid(strTemp) Then
                txtToULD.Text = strTemp
            End If
        End Sub
        Public Function ValidateForm() As Boolean

            ' Checks inputs on the form; if entering a bin/bulk, we need to have
            ' a flight number / date in there too.

            Dim retBinBulkcode As BinBulkReturnCodes
            Try
                ' Ensure there is valid data in the "Pieces" field
                If Not IsNumeric(txtPcsAWB.Text.Trim) Then
                    ' Can only be "ALL" here
                    If Trim(txtPcsAWB.Text) <> "ALL" Then
                        MyBase.SetError("PCS NEED # OR 'ALL'")
                        ValidateForm = False
                        MyBase.SetFocus(txtPcsAWB)
                        Exit Function
                    End If
                End If
            Catch ex As Exception

            End Try

            Try
                ' Check FROM data
                retBinBulkcode = Validate.IsBinBulkValid(txtFromULD.Text)
                Select Case retBinBulkcode
                    Case BinBulkReturnCodes.BulkValid, BinBulkReturnCodes.BinValid
                        If Validate.IsNWAFlightValid(Trim(txtFromFlight.Text)) Then
                            'if Valid flight, check date
                            If Validate.IsNWADateValid(Trim(txtFromDate.Text)) Then
                                ValidateForm = True
                            Else
                                MyBase.SetError("INVALID DATE")
                                MyBase.SetFocus(txtFromDate)
                                ValidateForm = False
                                Exit Function
                            End If
                        Else
                            MyBase.SetError("INVALID FLIGHT")
                            MyBase.SetFocus(txtFromFlight)
                            ValidateForm = False
                            Exit Function
                        End If

                    Case Else

                        If Validate.IsContainerNumValid(Trim(txtFromULD.Text)) Or _
                            Validate.IsULDNumFormatValid(Trim(txtFromULD.Text)) Then
                            ValidateForm = True
                        Else
                            MyBase.SetError("INVALID ULD/HOLD")
                            txtFromULD.Focus()
                            MyBase.SetFocus(txtFromULD)
                            ValidateForm = False
                            Exit Function
                        End If

                End Select
            Catch ex As Exception

            End Try

            Try
                ' Check the TO frame, but only if its visible
                If Me.fraTo.Visible And Me.txtToULD.Text <> String.Empty Then
                    retBinBulkcode = Validate.IsBinBulkValid(Trim(txtToULD.Text))

                    Select Case retBinBulkcode
                        Case BinBulkReturnCodes.BulkValid, BinBulkReturnCodes.BinValid
                            If Validate.IsNWAFlightValid(Trim(txtToFlight.Text)) Then
                                ' Valid flight, check date
                                If Validate.IsNWADateValid(Trim(txtToDate.Text)) Then
                                    ValidateForm = True
                                Else
                                    MyBase.SetError("INVALID DATE")
                                    MyBase.SetFocus(txtToDate)
                                    ValidateForm = False
                                    Exit Function
                                End If
                            Else
                                MyBase.SetError("INVALID FLIGHT")
                                MyBase.SetFocus(txtToFlight)
                                ValidateForm = False
                                Exit Function
                            End If

                        Case Else
                            If Validate.IsContainerNumValid(Trim(txtToULD.Text)) Or _
                                Validate.IsULDNumFormatValid(Trim(txtToULD.Text)) Then
                                ValidateForm = True
                            Else
                                MyBase.SetError("INVALID ULD/HOLD")
                                txtToULD.Focus()
                                MyBase.SetFocus(txtToULD)
                                ValidateForm = False
                                Exit Function
                            End If
                    End Select
                End If
            Catch ex As Exception
            End Try
        End Function

        Public Sub ShowToFrame(ByVal bFlag As Boolean)
            fraTo.Visible = bFlag
            If bFlag Then
                txtToDate.Text = txtFromDate.Text
                txtToFlight.Text = txtFromFlight.Text
            End If
        End Sub
        Public Sub BinBulkEntered(ByVal txtBox As TextBox)
            'Pending - confirm if format validations are required
            Dim retBinBulkcode As BinBulkReturnCodes
            Dim strTemp As String
            Dim dtDateFrom As DateTime
            Dim dtDateTo As DateTime
            Dim dtFromDate As NWADateTime
            Dim dtToDate As NWADateTime
            strTemp = txtBox.Text.Trim
            retBinBulkcode = Validate.IsBinBulkValid(strTemp)
            Try
                If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                    txtBox.Text = strTemp
                Else
                    MyBase.SetFocus(txtBox)
                    MyBase.SetError("INVALID BIN/BULK")
                    Exit Sub
                End If

            Catch ex As Exception

            End Try

            Dim dtDeparture As NWADateTime

            Try
                dtDeparture = New NWADateTime(txtFromDate.Text.Trim)
                txtFromDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtFromDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtFromDate)
                Exit Sub
            End Try

            Try
                If Me.fraFrom.Visible And Me.fraTo.Visible And Me.txtFromULD.Text <> String.Empty And Me.txtToULD.Text <> String.Empty Then
                    If MyBase.FlightsCollection.IsFlightValid(txtFromFlight.Text, New NWADateTime(txtFromDate.Text)) Then
                        If MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).IsBinBulkValid(txtFromULD.Text) Then
                            If MyBase.FlightsCollection.IsFlightValid(txtToFlight.Text, New NWADateTime(txtToDate.Text)) Then
                                If MyBase.FlightsCollection.Flights(txtToFlight.Text, dtDeparture).IsBinBulkValid(txtToULD.Text) Then

                                    'get contianer name based numbers
                                    Dim objConfirm As dlgConfirmMergeContainers
                                    objConfirm = New dlgConfirmMergeContainers(txtFromFlight.Text, txtFromDate.Text, _
                                            txtToFlight.Text, txtToDate.Text, txtFromULD.Text, txtToULD.Text)

                                    'Convert string to vbdate format 
                                    dtDateFrom = Convert.ToDateTime(txtFromDate.Text)
                                    dtDateTo = Convert.ToDateTime(txtToDate.Text)
                                    'Convert vbdate into NWA date format
                                    dtFromDate = New NWADateTime(dtDateFrom)
                                    dtToDate = New NWADateTime(dtDateTo)

                                    If objConfirm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                                        'Everything OK, perform Merge
                                        Dim retCode As ReturnCodes

                                        'VERIFY FROM / TO IS BIN / CONT IS VALID
                                        'Pending with MergeContainers in BO 
                                        ' call the MergeContainers method to merge operation
                                        Common.MergeContainers(txtFromFlight.Text, dtFromDate, txtFromULD.Text, txtToFlight.Text, dtToDate, txtToULD.Text, cmbCommod.SelectedValue, txtPcsAWB.Text)
                                        'MyBase.FlightsCollection.Flights(txtFromFlight.Text).MergeContainers()
                                        'common.mergecontainers(fromFlight, fromDate, binbulkNum, toFlight, toDate, tobinbulkNum)

                                        Select Case retCode
                                            Case ReturnCodes.Ok ' Success
                                                MyBase.SetFooter("MERGE SUCCESSFUL")
                                            Case ReturnCodes.NotAuthorized ' Not auth to use this function
                                                MyBase.SetError("NO ACCESS TO FN")
                                            Case ReturnCodes.DatabaseError      ' DB error
                                                MyBase.SetError("DATABASE ERROR")
                                            Case ReturnCodes.FlightDepartureUnknown
                                            Case Else
                                                MyBase.SetError("DATABASE ERROR")
                                        End Select
                                    End If
                                End If
                                'Invalid To Bin
                                MyBase.SetError("INVALID BIN/BULK")
                                MyBase.SetFocus(txtToULD)
                            End If
                            'MyBase.SetError("INVALID FLIGHT")
                            'MyBase.SetFocus(txtToFlight)
                        Else
                            'Invalid From Bin
                            MyBase.SetError("INVALID BIN/BULK")
                            MyBase.SetFocus(txtFromULD)
                        End If
                    Else
                        MyBase.SetError("INVALID FLIGHT")
                        MyBase.SetFocus(txtFromFlight)
                    End If
                Else
                    MyBase.ShowControl(fraTo)
                    MyBase.SetFocus(txtToULD)
                    'MyBase.SetError("INVALID BINBULK")
                End If
            Catch ex As Exception

            End Try

        End Sub
        Public Sub ULDEntered(ByVal txtBox As TextBox)
            'Pending - confirm if format validations are required
            Dim dtDeparture As NWADateTime

            Try
                dtDeparture = New NWADateTime(txtFromDate.Text.Trim)
                txtFromDate.Text = dtDeparture.NWAFormat
            Catch safetracExp As SafetracException
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtFromDate)
                Exit Sub
            Catch exp As Exception
                Logger.LogException(exp)
                MyBase.SetError(DisplayMessages.InvalidDateFormat)
                MyBase.SetFocus(Me.txtFromDate)
                Exit Sub
            End Try

            Dim retBinBulkcode As BinBulkReturnCodes
            Dim strTemp As String
            Try
                strTemp = txtBox.Text.Trim
                retBinBulkcode = Validate.IsBinBulkValid(strTemp)
                If retBinBulkcode = BinBulkReturnCodes.BulkValid Or retBinBulkcode = BinBulkReturnCodes.BinValid Then
                    txtBox.Text = strTemp
                Else
                    MyBase.SetFocus(txtBox)
                    MyBase.SetError("INVALID BIN/BULK")
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            'get container names based on container numbers and vice versa
            Dim fromContName As String = Nothing
            Dim toContName As String = Nothing
            Dim fromContNum As String = Nothing
            Dim toContNum As String = Nothing
            Try
                If MyBase.FlightsCollection.IsFlightValid(txtFromFlight.Text, New NWADateTime(txtFromDate.Text)) Then
                    If MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).IsContainerNumValid(txtFromULD.Text) Then
                        fromContName = MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).GetContainerName(txtFromULD.Text)
                    ElseIf MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).IsContainerNameValid(txtFromULD.Text) Then
                        fromContNum = MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).GetContainerName(txtFromULD.Text)
                    Else
                        MyBase.SetError("INVALID ULD")
                        Exit Sub
                    End If

                    If MyBase.FlightsCollection.IsFlightValid(txtToFlight.Text, New NWADateTime(txtToDate.Text)) Then
                        If MyBase.FlightsCollection.Flights(txtToFlight.Text, dtDeparture).IsContainerNumValid(txtToULD.Text) Then
                            toContName = MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).GetContainerName(txtToULD.Text)
                        ElseIf MyBase.FlightsCollection.Flights(txtToFlight.Text, dtDeparture).IsContainerNameValid(txtToULD.Text) Then
                            'ContainerSheetNum is not available in BO 
                            toContNum = MyBase.FlightsCollection.Flights(txtFromFlight.Text, dtDeparture).GetContainerName(txtToULD.Text)
                        Else
                            MyBase.SetError("INVALID ULD")
                            Exit Sub
                        End If

                        'get contianer name based on numbers
                        Dim objConfirm As dlgConfirmMergeContainers
                        If fromContName <> String.Empty Then
                            If toContName <> String.Empty Then
                                objConfirm = New dlgConfirmMergeContainers(txtFromFlight.Text, txtFromDate.Text, _
                                        txtToFlight.Text, txtToDate.Text, txtFromULD.Text, fromContName, txtToULD.Text, toContName)
                            Else
                                objConfirm = New dlgConfirmMergeContainers(txtFromFlight.Text, txtFromDate.Text, _
                                                                        txtToFlight.Text, txtToDate.Text, fromContNum, txtFromULD.Text, txtToULD.Text, toContName)

                            End If
                        Else
                            If toContName <> "" Then
                                objConfirm = New dlgConfirmMergeContainers(txtFromFlight.Text, txtFromDate.Text, _
                                        txtToFlight.Text, txtToDate.Text, fromContNum, txtFromULD.Text, txtToULD.Text, toContName)
                            Else
                                objConfirm = New dlgConfirmMergeContainers(txtFromFlight.Text, txtFromDate.Text, _
                                                                        txtToFlight.Text, txtToDate.Text, fromContNum, txtFromULD.Text, toContNum, txtToULD.Text)
                            End If
                        End If

                        If objConfirm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                            'Everything OK, perform Merge
                            Dim retCode As ReturnCodes

                            Select Case retCode
                                Case ReturnCodes.Ok ' Success
                                    MyBase.SetFooter("MERGE SUCCESSFUL")
                                Case ReturnCodes.NotAuthorized ' Not auth to use this function
                                    MyBase.SetError("NO ACCESS TO FN")
                                Case ReturnCodes.DatabaseError      ' DB error
                                    MyBase.SetError("DATABASE ERROR")
                                Case ReturnCodes.FlightDepartureUnknown
                                Case Else
                                    MyBase.SetError("DATABASE ERROR")
                            End Select
                        End If
                    Else
                        MyBase.SetError("INVALID FLIGHT")
                        MyBase.SetFocus(txtToFlight)
                    End If
                Else
                    MyBase.SetError("INVALID FLIGHT")
                    MyBase.SetFocus(txtFromFlight)
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cmdScannedFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScannedFrom.Click
            ' txtFromULD.Text = lblBarcodeScanned.Text
            txtFromULD.Text = _strScannedValue
            MyBase.HideControl(fraScanDetected)
            MyBase.ShowControl(fraFrom)
            MyBase.SetFocus(txtToFlight)
        End Sub

        Private Sub cmdScannedTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScannedTo.Click
            'txtToULD.Text = lblBarcodeScanned.Text
            txtToULD.Text = _strScannedValue
            MyBase.HideControl(fraScanDetected)
            MyBase.ShowControl(fraTo)
            MyBase.SetFocus(txtToFlight)
        End Sub
    End Class
End Namespace