Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLoadBagToContainer
        Dim _bagtag As String
        Dim _intCounter As Integer = 0
        Private _intWeight As Integer

        Public Property Weight() As Integer
            Get
                Return _intWeight
            End Get
            Set(ByVal value As Integer)
                _intWeight = value
            End Set
        End Property

        Private Sub frmLoadBagToContainer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                UIController.NextForm = New frmContainerInquiry
                UIController.NextForm.ShowDialog()
            End If
        End Sub

        Private Sub frmLoadBagToULDCart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.UpdateUserActionTime()
            Me.SetBaseFormHeader()
            lblCurrentULD.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.ContainerName
            lblCurrentULDFlt.Text = MyBase.FlightsCollection.CurrentFlight.FlightNum

            'Pending to be changed to container dest
            lblCurrentULDDest.Text = MyBase.FlightsCollection.CurrentFlight.Destination
            lblCurrentULDFltDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            lblCurrentULDType.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Type
            txtBagtag.Focus()
            fraAlwaysExp.Visible = False
            MyBase.Reader.Enable()
        End Sub

        Private Sub cmdSetMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetMode.Click
            If MyBase.IsErrorEnabled Then
                MyBase.ClearFooter()
                Exit Sub
            End If

            If MyBase.IsFooterEnabled Then
                MyBase.ClearFooter()
                Exit Sub
            End If

            Dim objfrmSetScanMode As New dlgScanMode
            MyBase.UpdateUserActionTime()
            objfrmSetScanMode.ShowDialog()
            Me.SetBaseFormHeader()
            txtBagtag.Focus()
        End Sub
        Public Sub SetBaseFormHeader()
            Select Case CacheManager.BagScanMode
                Case ScanModes.Damaged
                    MyBase.SetHeader("Damaged", "to ULD/Cart")
                    'Pending Footer Status.
                Case ScanModes.Heavy
                    MyBase.SetHeader("Heavy", "to ULD/Cart")
                    'Pending Footer Status.
                Case ScanModes.Normal
                    MyBase.SetHeader("Normal", "to ULD/Cart")
                    'Pending Footer Status.
                Case ScanModes.Planeside
                    MyBase.SetHeader("Planeside", "to ULD/Cart")
                    'Pending Footer Status.
                Case ScanModes.Manual
                    MyBase.SetHeader("Heavy", "to ULD/Cart")
                    'Pending Footer Status.
                Case Else
                    MyBase.SetHeader("Heavy", "to ULD/Cart")
            End Select

        End Sub

        Private Sub txtBagtag_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBagtag.GotFocus
            MyBase.Reader.Enable()
            MyBase.SetFocus(txtBagtag)
        End Sub

        Private Sub frmLoadBagToULDCart_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
            MyBase.Reader.Disable()
        End Sub

        Private Sub cmdSetMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSetMode.KeyDown
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
            End If
        End Sub


        Private Sub txtBagtag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBagtag.KeyDown
            Dim strBagTagNum As String
            Dim intWeight As Integer
            Dim strLog As String = String.Empty

            strBagTagNum = Trim(txtBagtag.Text)

            If e.KeyCode = Keys.Enter Then
                Try
                    If MyBase.IsErrorEnabled Then
                        MyBase.ClearFooter()
                        If fraAlwaysExp.Visible = True Then
                            fraAlwaysExp.Visible = False
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    If MyBase.IsFooterEnabled Then
                        MyBase.ClearFooter()
                        If fraAlwaysExp.Visible = True Then
                            fraAlwaysExp.Visible = False
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    strBagTagNum = txtBagtag.Text.Trim
                    txtBagtag.Refresh()
                    If strBagTagNum = String.Empty Then
                        MyBase.SetError("INVALID BAGTAG")
                        MyBase.Reader.Enable()
                        MyBase.SetFocus(txtBagtag)
                        Exit Sub
                    End If

                    If Validate.IsBagtagValid(strBagTagNum) <> BagTagReturnCodes.BagtagValid Then
                        Logger.LogMessage("InvalidBagTagFormat", LogType.Trace, "frmLoadBagToContainer.txtBagtag_KeyDown")
                        MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                        MyBase.Reader.Enable()
                        MyBase.SetFocus(txtBagtag)
                        Exit Sub
                    End If

                    Select Case CacheManager.BagScanMode
                        Case ScanModes.Animal, ScanModes.Damaged, ScanModes.Manual
                            Dim objdlgWeight As New dlgWeight()
                            objdlgWeight.ShowDialog()
                            intWeight = objdlgWeight.Weight
                    End Select
                    Logger.LogMessage("BagScanMode=" & CacheManager.BagScanMode, LogType.Trace, "frmLoadBagToContainer.txtBagtag_KeyDown")

                    Dim retCode As ReturnCodes
                    Select Case CacheManager.BagScanMode
                        Case ScanModes.Normal
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadNormalBag(strBagTagNum)
                        Case ScanModes.SingleHeavy, ScanModes.Heavy
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadHeavyBag(strBagTagNum)
                        Case ScanModes.Planeside
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadPlaneSideBag(strBagTagNum)
                        Case ScanModes.Manual
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadManualBag(strBagTagNum, intWeight.ToString)
                        Case ScanModes.Damaged
                            retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadDamagedBag(strBagTagNum, intWeight.ToString)
                    End Select

                    Select Case retCode
                        Case ReturnCodes.Ok
                            Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LastScannedBags.Count
                            strLog = String.Format("After counting LastScannedBags count = {0} , BagScanMode= {1}", intCount, CacheManager.BagScanMode)
                            Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")
                            Select Case CacheManager.BagScanMode
                                Case ScanModes.SingleHeavy, ScanModes.Heavy
                                    MyBase.SetFooter(DisplayMessages.OKtoLoadHeavy & " " & intCount.ToString & "*")
                                Case ScanModes.Planeside
                                    MyBase.SetFooter(DisplayMessages.OKtoLoadPlanesideBag & " " & intCount.ToString & "*")
                                Case Else
                                    MyBase.SetFooter(DisplayMessages.OKtoLoad & " " & intCount.ToString & "*")
                            End Select

                            'set back to normal scan mode if current scan mode is single heavy
                            If (CacheManager.BagScanMode = ScanModes.SingleHeavy) Then
                                CacheManager.BagScanMode = ScanModes.Normal
                                Me.SetBaseFormHeader()
                            End If

                        Case ReturnCodes.FlightClosed
                            MyBase.SetError(DisplayMessages.FlightClosed)
                        Case ReturnCodes.FlightDeparted
                            MyBase.SetError(DisplayMessages.FlightDeparted)
                        Case ReturnCodes.BagtagOnNoLoad
                            MyBase.SetError("NO LOAD AUTH")
                            MyBase.SetFocus(txtBagtag)
                        Case ReturnCodes.ContainerClosed
                            MyBase.SetError("ULD IS CLOSED")
                            MyBase.SetFocus(txtBagtag)
                            'Case ReturnCodes.LoadError
                            '    MyBase.SetError("LOAD ERROR")
                            '    MyBase.SetFocus(txtBagtag)
                        Case ReturnCodes.PassengerNotCheckedIn
                            MyBase.SetError(DisplayMessages.PassengerNotCheckedIn)
                        Case ReturnCodes.PassengerOnStandBy
                            MyBase.SetError(DisplayMessages.PassengerOnStandby)
                        Case ReturnCodes.BagtagAlreadyLoaded
                            MyBase.SetError(DisplayMessages.AlreadyRegistered)
                        Case ReturnCodes.BagtagDuplicatesFound
                            MyBase.SetError(DisplayMessages.DuplicateBagTag)
                        Case ReturnCodes.BagtagUnknown
                            MyBase.SetError(DisplayMessages.UnknownBag)
                        Case ReturnCodes.Relabel
                            MyBase.SetFooter("LOAD OK, RELABEL")
                            MyBase.SetFocus(txtBagtag)
                            'Case ReturnCodes.OverrideFail
                            '    MyBase.SetError("EXPEDITE ERROR")
                            '    MyBase.SetFocus(txtBagtag)
                            'Case ReturnCodes.TrackingError
                            '    MyBase.SetError("TRACKING ERROR")
                            '    MyBase.SetFocus(txtBagtag)
                            'Case ReturnCodes.OKLoadViolation
                            '    MyBase.SetError("LOAD VIOLATION")
                            'Case ReturnCodes.NoLoad
                            '    MyBase.SetError("NO LOAD AUTH")
                            '    MyBase.SetFocus(txtBagtag)
                            'Case ReturnCodes.SecurityError
                            '    MyBase.SetError("NO SECURITY")
                            '    MyBase.SetFocus(txtBagtag)
                        Case ReturnCodes.BagtagInvalidForFlight, ReturnCodes.Overrulable, ReturnCodes.MaxBagsExceeded, ReturnCodes.BagtagUnknown
                            Dim confirmExpedite As DialogResult
                            confirmExpedite = dlgConfirmExpedite.ShowDialog()
                            If confirmExpedite = DialogResult.OK Then
                                'UIController.NextForm = New frmExpediteReason
                                Dim objfrmExpediteReason As New frmExpediteReason
                                'UIController.NextForm.ShowDialog()
                                objfrmExpediteReason.ShowDialog()
                                If CacheManager.ExpediteCode <> NoExpedite Then
                                    lblExpCode.Text = CacheManager.ExpediteCode
                                    fraAlwaysExp.Visible = True
                                    strLog = String.Format("Before LoadExpediteBag BagTagNum = {0} , Expedite code = {1} ,BagtagInvalidForFlight = {2}", strBagTagNum, _
                                       CacheManager.ExpediteCode, ReturnCodes.BagtagInvalidForFlight)
                                    Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")

                                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadExpediteBag(strBagTagNum, _
                                       CacheManager.ExpediteCode, ReturnCodes.BagtagInvalidForFlight)

                                    strLog = String.Format("After LoadExpediteBag ReturnCode = {0}", retCode.ToString())
                                    Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")

                                    Select Case retCode
                                        Case ReturnCodes.Ok
                                            Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LastScannedBags.Count
                                            strLog = String.Format("After counting LastScannedBags count = {0} , BagScanMode= {1}", intCount, CacheManager.BagScanMode)
                                            Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")
                                            Select Case CacheManager.BagScanMode
                                                Case ScanModes.SingleHeavy, ScanModes.Heavy
                                                    MyBase.SetFooter(DisplayMessages.OKtoLoadHeavy & " " & intCount.ToString & "*")
                                                Case ScanModes.Planeside
                                                    MyBase.SetFooter(DisplayMessages.OKtoLoadPlanesideBag & " " & intCount.ToString & "*")
                                                Case Else
                                                    MyBase.SetFooter(DisplayMessages.OKtoLoad & " " & intCount.ToString & "*")
                                            End Select
                                        Case ReturnCodes.FlightClosed
                                            MyBase.SetError(DisplayMessages.FlightClosed)
                                        Case ReturnCodes.FlightDeparted
                                            MyBase.SetError(DisplayMessages.FlightDeparted)
                                        Case ReturnCodes.DatabaseError
                                            MyBase.SetError(DisplayMessages.DatabaseError)
                                        Case ReturnCodes.NotOk
                                        Case ReturnCodes.Unknown
                                        Case Else
                                            MyBase.SetError(DisplayMessages.UnknownError)
                                    End Select
                                Else
                                    txtBagtag.Enabled = True
                                    MyBase.SetError("NO LOAD AUTH")
                                    MyBase.SetFocus(txtBagtag)
                                End If
                            ElseIf confirmExpedite = DialogResult.Cancel Then
                                txtBagtag.Enabled = True
                                MyBase.SetError("NO LOAD AUTH")
                                MyBase.SetFocus(txtBagtag)
                            End If
                        Case ReturnCodes.BagtagOnAlert
                            txtBagtag.Enabled = False
                            'MyBase.SetError("BAGTAG ON ALERT")
                            'show the frame
                            Dim result As DialogResult
                            result = dlgBagOnAlert.ShowDialog
                            If result = Windows.Forms.DialogResult.OK Then
                                ' Override alert, load the bag

                                strLog = String.Format("Before LoadBagOnAlert BagTagNum = {0}", strBagTagNum)
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")

                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LoadBagOnAlert(strBagTagNum)

                                strLog = String.Format("After LoadBagOnAlert ReturnCode = {0}", retCode.ToString())
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToContainer.txtBagtag_KeyDown")
                                Logger.LogMessage("BagScanMode=" & CacheManager.BagScanMode, LogType.Trace, "frmLoadBagToContainer.txtBagtag_KeyDown")
                                Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.LastScannedBags.Count
                                Select Case CacheManager.BagScanMode
                                    Case ScanModes.SingleHeavy, ScanModes.Heavy
                                        MyBase.SetFooter(DisplayMessages.OKtoLoadHeavy & " " & intCount.ToString & "*")
                                    Case ScanModes.Planeside
                                        MyBase.SetFooter(DisplayMessages.OKtoLoadPlanesideBag & " " & intCount.ToString & "*")
                                    Case Else
                                        MyBase.SetFooter(DisplayMessages.OKtoLoad & " " & intCount.ToString & "*")
                                End Select
                                txtBagtag.Enabled = True
                                MyBase.SetFocus(txtBagtag)
                                MyBase.Reader.Enable()
                            ElseIf result = Windows.Forms.DialogResult.Cancel Then
                                ' Cancel alert, go back to input
                                MyBase.SetError("LOAD CANCELLED")
                                txtBagtag.Enabled = True
                                MyBase.SetFocus(txtBagtag)
                                MyBase.Reader.Enable()
                            End If
                        Case ReturnCodes.DatabaseError
                            MyBase.SetError(DisplayMessages.DatabaseError)
                            MyBase.SetFocus(txtBagtag)
                        Case ReturnCodes.NotOk
                        Case ReturnCodes.Unknown
                        Case Else
                            MyBase.SetError(DisplayMessages.UnknownError)
                            MyBase.SetFocus(txtBagtag)
                    End Select
                    MyBase.SetFocus(txtBagtag)
                Catch ex As Exception
                    Logger.LogException(ex)
                End Try
            End If
        End Sub

    End Class
End Namespace
