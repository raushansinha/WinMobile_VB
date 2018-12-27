
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmChangeContainerDefinition

        Dim _cntnrNum As String
        Dim _strCheckConChange As String
        Dim _fireCall As Boolean
        Dim _blnIsContainerNum As Boolean

        Private Sub frmChangeContainerDefinition_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
                Exit Sub
            End If

            If e.KeyCode = Keys.Enter Then
                Try
                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearError()
                        Exit Sub
                    End If

                    If MyBase.IsFooterEnabled Then
                        MyBase.ClearFooter()
                        Exit Sub
                    End If

                    Dim strContainer As String = txtContainer.Text.Trim.ToUpper

                    Dim objFlight As New NWAFlight

                    _cntnrNum = strContainer
                    txtContainer.Text = strContainer

                    If Validate.IsContainerNumValid(strContainer) Then
                        txtContainer.Text = strContainer
                        strContainer = strContainer.Substring(0, 5)
                        objFlight = Common.GetFlightForContainerNum(strContainer)
                        If objFlight.Number Is Nothing Then
                            MyBase.SetError(DisplayMessages.UnknownContainer)
                            MyBase.SetFocus(txtContainer)
                            Exit Sub
                        End If
                        _blnIsContainerNum = True
                        Me.IdentifyFlightForContainer(strContainer, _blnIsContainerNum)
                        If _fireCall = True Then
                            ChangeContainerDefinition()
                        End If
                    ElseIf BO.Validate.IsULDNumFormatValid(strContainer) Then
                        'user has entered ULD number
                        txtContainer.Text = strContainer
                        objFlight = Common.GetFlightForContainerName(strContainer)
                        If objFlight.Number Is Nothing Then
                            MyBase.SetError(DisplayMessages.UnknownContainer)
                            MyBase.SetFocus(txtContainer)
                            Exit Sub
                        End If
                        txtContainer.Text = strContainer
                        _blnIsContainerNum = False
                        Me.IdentifyFlightForContainer(strContainer, _blnIsContainerNum)
                        If _fireCall = True Then
                            ChangeContainerDefinition()
                        End If
                    Else
                        Logger.LogMessage("Invalid Format", LogType.Trace, "frmChangeContainerDefinition.frmChangeContainerDefinition_KeyDown")
                        MyBase.SetError(DisplayMessages.InvalidULDFormat)
                        SetFocus(txtContainer)
                    End If
                Catch safetracEx As SafetracException
                    Logger.LogException(safetracEx)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub

        Private Sub frmChangeULDCartDefinition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("ULD Definition")
            MyBase.Reader.Enable()
            cmbContType.Text = "SORT"
            MyBase.HideControl(fraFlightInfo)
            MyBase.HideControl(fraHubContainer)
            MyBase.HideControl(fraChangeDefinition)
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtContainer.Text = e.ScannedValue
        End Sub


        Private Sub IdentifyFlightForContainer(ByVal strContainer As String, ByVal blnIsContainerNum As Boolean)

            Dim objFlight As New NWAFlight
            If strContainer <> _strCheckConChange Then
                _strCheckConChange = strContainer
                _fireCall = False
                Try
                    cmbContType.Text = "SORT"
                    MyBase.SetFocus(txtContainer)
                    If blnIsContainerNum = True Then
                        objFlight = Common.GetFlightForContainerNum(strContainer)
                        If objFlight.Number IsNot Nothing Then
                            If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                                If MyBase.FlightsCollection.CurrentFlight.IsContainerNumValid(strContainer) Then
                                    MyBase.ShowControl(fraFlightInfo)
                                    MyBase.ShowControl(fraChangeDefinition)
                                    lblContainerHeader.Text = "ULD"
                                    txtDest.Text = MyBase.FlightsCollection.CurrentFlight.Destination
                                    lblULDFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                                    Validate.IsNWAFlightValid(lblULDFlight.Text)
                                    lblULDDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                                    If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName = "" Then
                                        MyBase.SetError(DisplayMessages.ULDisnotyetRegistered)
                                        MyBase.SetFocus(txtContainer)
                                        MyBase.HideControl(fraFlightInfo)
                                        MyBase.HideControl(fraChangeDefinition)
                                        Exit Sub
                                    Else
                                        lblContainer.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName
                                    End If
                                Else
                                    Logger.LogMessage("InvalidULDorCartorContainerSheet", LogType.Trace, " frmChangeContainerDefinition.IdentifyFlightForContainer")
                                    MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                    MyBase.SetFocus(txtContainer)
                                    Exit Sub
                                End If
                            Else
                                'unknown container
                                MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                                MyBase.SetFocus(txtContainer)
                                Exit Sub
                            End If
                        Else
                            'unknown container
                            MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                            MyBase.SetFocus(txtContainer)
                            Exit Sub
                        End If
                    Else
                        objFlight = Common.GetFlightForContainerName(strContainer)
                        If objFlight.Number IsNot Nothing Then
                            If MyBase.FlightsCollection.IsFlightValid(objFlight.Number, objFlight.DepartureDate) Then
                                If MyBase.FlightsCollection.CurrentFlight.IsContainerNameValid(strContainer) Then
                                    MyBase.ShowControl(fraFlightInfo)
                                    MyBase.ShowControl(fraChangeDefinition)
                                    lblContainerHeader.Text = "SHEET"
                                    txtDest.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Destination
                                    lblULDFlight.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum
                                    Validate.IsNWAFlightValid(lblULDFlight.Text)
                                    lblULDDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
                                    If MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum = "" Then
                                        MyBase.SetError(DisplayMessages.ULDisnotyetRegistered)
                                        MyBase.SetFocus(txtContainer)
                                        MyBase.HideControl(fraFlightInfo)
                                        MyBase.HideControl(fraChangeDefinition)
                                        Exit Sub
                                    Else
                                        lblContainer.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerNum
                                    End If
                                Else
                                    MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                                    MyBase.SetFocus(txtContainer)
                                    Exit Sub
                                End If
                            Else
                                'unknown container name
                                MyBase.SetError(DisplayMessages.UnknownContainer)
                                MyBase.SetFocus(txtContainer)
                                Exit Sub
                            End If
                        Else
                            'unknown container name
                            MyBase.SetError(DisplayMessages.UnknownContainer)
                            MyBase.SetFocus(txtContainer)
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            Else
                _fireCall = True
            End If
        End Sub

        Private Sub cmbContType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbContType.SelectedIndexChanged
            lblDest.Visible = True
            If cmbContType.Text = "HUB" Then
                If _blnIsContainerNum = True Then
                    Dim objHubInfo As HubFlight = Common.GetHubInformationforNum(txtContainer.Text.Substring(0, 5))
                    txtHubDest.Text = objHubInfo.Destination
                    txtHubFlight.Text = objHubInfo.Number
                    Validate.IsNWAFlightValid(txtHubFlight.Text)
                    txtHubDate.Text = objHubInfo.DepartureDate.NWAFormat
                    MyBase.ShowControl(fraHubContainer)
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                Else
                    Dim objHubInfo As HubFlight = Common.GetHubInformationforName(txtContainer.Text)
                    txtHubDest.Text = objHubInfo.Destination
                    txtHubFlight.Text = objHubInfo.Number
                    Validate.IsNWAFlightValid(txtHubFlight.Text)
                    txtHubDate.Text = objHubInfo.DepartureDate.NWAFormat
                    MyBase.ShowControl(fraHubContainer)
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                End If
            Else
                MyBase.HideControl(fraHubContainer)
                If cmbContType.Text = "SORT" Then
                    txtDest.Visible = False
                    txtDest.Enabled = False
                    lblDest.Visible = False
                    Me.Refresh()
                Else
                    txtDest.Visible = True
                    txtDest.Enabled = True
                    Me.Refresh()
                End If
            End If
        End Sub

        Private Sub ChangeContainerDefinition()

            Dim retCode As ReturnCodes
            Dim conName As String = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName
            Dim conNum As String = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerSheetNum
            Dim conType As String = cmbContType.Text
            Dim conDest As String = String.Empty
            Dim hubCode As String = String.Empty
            Dim hubFlightDest As String = String.Empty
            Dim hubFlightNum As String = "0"
            Dim hubFlightSched As String = String.Empty


            If cmbContType.Text <> "SORT" Then
                If cmbContType.Text = "HUB" Then
                    If txtHubFlight.Text.Length = 0 Then
                        MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                        MyBase.SetFocus(Me.txtHubFlight)
                        Exit Sub
                    End If

                    If txtHubDate.Text.Length = 0 Then
                        MyBase.SetError(DisplayMessages.InvalidDateFormat)
                        Logger.LogMessage("InvalidDateFormat", LogType.Warning, "frmChangeContainerDefinition.ChangeContainerDefinition")
                        MyBase.SetFocus(Me.txtHubDate)
                        Exit Sub
                    End If

                    If txtHubDest.Text.Length > 0 Then
                        If (Not IsAlpha(txtHubDest.Text)) Or txtHubDest.Text.Length <> 3 Then
                            MyBase.SetError(DisplayMessages.InvalidDestination)
                            MyBase.SetError("INVALID CITY CODE")
                            MyBase.SetFocus(txtHubDest)
                            Exit Sub
                        End If
                    End If

                    'Pending - Common.IsDestinationValid(txtHubDest.Text)
                    hubFlightDest = txtHubDest.Text

                    Dim strTemp As String
                    Dim strTemp1 As String

                    strTemp = txtHubFlight.Text.ToUpper.Trim
                    strTemp1 = txtHubFlight.Text

                    If Validate.IsNWAFlightValid(strTemp) Then
                        txtHubFlight.Text = strTemp
                    Else
                        MyBase.SetError(DisplayMessages.InvalidFlightFormat)
                        Logger.LogMessage("Invalid Flight", LogType.Trace, "frmChangeContainerDefinition.ChangeContainerDefinition")
                        MyBase.SetFocus(Me.txtHubFlight)
                        Exit Sub
                    End If
                    hubCode = txtHubFlight.Text.Substring(0, 2)
                    hubFlightNum = txtHubFlight.Text.Substring(2).Trim

                    Dim dtDeparture As NWADateTime

                    Try
                        dtDeparture = New NWADateTime(txtHubDate.Text.Trim)
                        txtHubDate.Text = dtDeparture.NWAFormat
                    Catch safetracExp As SafetracException
                        MyBase.SetError(DisplayMessages.InvalidDateFormat)
                        MyBase.SetFocus(Me.txtHubDate)
                        Exit Sub
                    Catch exp As Exception
                        Logger.LogException(exp)
                        MyBase.SetError(DisplayMessages.InvalidDateFormat)
                        MyBase.SetFocus(Me.txtHubDate)
                        Exit Sub
                    End Try
                    hubFlightSched = txtHubDate.Text
                End If
                ' Check first destination
                If Len(Trim(txtDest.Text)) = 0 Then
                    MyBase.SetError(DisplayMessages.InvalidDestinationFormat)
                    SetFocus(txtDest)
                    Exit Sub
                End If
                conDest = txtDest.Text
            End If

            'Pending just for test
            ''MsgBox("We got Here")
            ''MsgBox(conName & "," & conNum & "," & conType & "," & conDest & "," & hubCode & "," & hubFlightDest _
            ''& "," & hubFlightNum & "," & hubFlightSched)
            ''Exit Sub

            'create Container sheet number and display it
            'WebService Call and databse call - Pending
            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ChangeContainerDef(conDest, conNum, _
                      conName, conType, hubCode, hubFlightDest, hubFlightNum, hubFlightSched)

            Try
                If retCode = ReturnCodes.Ok Then
                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ChangeContainerDefLocal _
                    (conDest, conNum, conName, conType, hubCode, hubFlightDest, hubFlightNum, hubFlightSched)
                    MyBase.SetFooter("SHEET REDEFINED")
                End If

            Catch expSafetrac As SafetracException
                Select Case expSafetrac.ErrorCode
                    Case ReturnCodes.DatabaseError
                        MyBase.SetError(DisplayMessages.DatabaseError)
                    Case 601
                        MyBase.SetError("unknownULD")
                    Case ReturnCodes.ContainerNumInvalid
                        MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                    Case 602
                        MyBase.SetError("UNKNOWN DEPARTURE")
                    Case 603
                        MyBase.SetError(DisplayMessages.InvalidDestinationFormat)
                    Case 604
                        MyBase.SetError(DisplayMessages.InvalidDestination)
                    Case ReturnCodes.FlightDeparted
                        MyBase.SetError(DisplayMessages.FlightDeparted)
                    Case 605
                        MyBase.SetError(DisplayMessages.FlightClosed)
                    Case 606
                        MyBase.SetError(DisplayMessages.CartOnly)
                    Case 607
                        MyBase.SetError(DisplayMessages.CartPositioned)
                    Case 608
                        MyBase.SetError(DisplayMessages.InvalidHubDestination)
                    Case 609
                        MyBase.SetError("CHANGE ERROR")
                    Case 610
                        MyBase.SetError(DisplayMessages.UnknownScan)
                    Case 611
                        MyBase.SetError("BARCODE ERROR")
                End Select
            End Try
        End Sub

        Private Sub txtDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDest.GotFocus
            MyBase.SetFocus(txtDest)
        End Sub

        Private Sub txtDest_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDest.LostFocus
            txtDest.Text = txtDest.Text.Trim.ToUpper
        End Sub

        Private Sub txtHubDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubDate.GotFocus
            SetFocus(txtHubDate)
        End Sub

        Private Sub txtHubDest_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubDest.GotFocus
            SetFocus(txtHubDest)
        End Sub

        Private Sub txtHubFlight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHubFlight.GotFocus
            SetFocus(txtHubFlight)
        End Sub

        Private Sub txtHubFlight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHubFlight.KeyDown
            MyBase.FormatKeysForFlight(txtHubFlight, Asc(e.KeyCode))
        End Sub

        Private Sub txtHubDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHubDate.KeyDown
            MyBase.FormatKeysForDate(txtHubDate, Asc(e.KeyCode))
        End Sub
    End Class
End Namespace
