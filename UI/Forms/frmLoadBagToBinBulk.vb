Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Hardware

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmLoadBagToBinBulk

        Private _strFlightNum As String
        Private _dtDeparture As NWADateTime
        Private _bagtag As String
        Private _intWeight As Integer
        Private _strBinBulkNum As String

        Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal binbulk As String)

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _strFlightNum = flightNum
            _dtDeparture = flightDate
            _strBinBulkNum = binbulk
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            txtBagtag.Text = e.ScannedValue
        End Sub

        Public Property Weight() As Integer
            Get
                Return _intWeight
            End Get
            Set(ByVal value As Integer)
                _intWeight = value
            End Set
        End Property

        Private Sub frmLoadBagToBinBulk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                If UIController.CurrentFunction = SafetracFunction.ExpediteBag Then
                    UIController.NextForm = New frmExpediteReason
                    UIController.NextForm.ShowDialog()
                Else
                    UIController.NextForm = New frmBinBulkInquiry()
                    UIController.NextForm.ShowDialog()
                End If
            End If
        End Sub

        Private Sub frmLoadBag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.UpdateUserActionTime()
            Me.SetBaseFormHeader()
            lblCurrentHold.Text = _strBinBulkNum
            lblCurrentFlt.Text = _strFlightNum
            lblCurrentFltDate.Text = _dtDeparture.NWAFormat
            MyBase.Reader.Enable()
            MyBase.SetFocus(txtBagtag)
            If UIController.CurrentFunction = SafetracFunction.ExpediteBag Then
                lblExpCode.Text = CacheManager.ExpediteCode
                MyBase.ShowControl(fraAlwaysExp)
                btnSetMode.Enabled = False
            Else
                fraAlwaysExp.Visible = False
                fraAlwaysExp.SendToBack()
            End If
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

        Private Sub txtBagtag_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBagtag.GotFocus
            MyBase.SetFocus(txtBagtag)
        End Sub

        Private Sub frmLoadBagToBinBulk_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
            MyBase.Reader.Disable()
        End Sub

        Public Sub SetBaseFormHeader()
            Select Case CacheManager.BagScanMode
                Case ScanModes.Animal
                    MyBase.SetHeader("Animal", "to Bin/Bulk")
                    'Pending Footer Status.
                Case ScanModes.Damaged
                    MyBase.SetHeader("Damaged", "to Bin/Bulk")
                    'Pending Footer Status.
                Case ScanModes.Heavy
                    MyBase.SetHeader("Heavy", "to Bin/Bulk")
                    'Pending Footer Status.
                Case ScanModes.Normal
                    MyBase.SetHeader("Normal", "to Bin/Bulk")
                    'Pending Footer Status.
                Case ScanModes.Planeside
                    MyBase.SetHeader("Planeside", "to Bin/Bulk")
                    'Pending Footer Status.
                Case ScanModes.Manual
                    MyBase.SetHeader("Heavy", "to Bin/Bulk")
                    'Pending Footer Status.
                Case Else
                    MyBase.SetHeader("Heavy", "to Bin/Bulk")
            End Select

        End Sub

        Private Sub cmdSetMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSetMode.KeyDown
            If MyBase.IsErrorEnabled Then
                If e.KeyCode = Keys.Enter Then
                    MyBase.ClearError()
                End If
                Exit Sub
            End If
        End Sub

        Private Sub txtBagtag_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBagtag.KeyDown
            Dim strLog As String = String.Empty
            Dim intWeight As Integer
            Dim strBagTagNum As String = String.Empty
            MyBase.UpdateUserActionTime()
            MyBase.Reader.Disable()

            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If

                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
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
                    Logger.LogMessage("InvalidBagTagFormat", LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
                    MyBase.SetError(DisplayMessages.InvalidBagTagFormat)
                    MyBase.Reader.Enable()
                    MyBase.SetFocus(txtBagtag)
                    Exit Sub
                End If

                If Not FlightsCollection.IsFlightValid(_strFlightNum, _dtDeparture) Then
                    'Invalid Flight
                    Logger.LogMessage("NonConfiguredFlight", LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
                    MyBase.SetError(DisplayMessages.NonConfiguredFlight)
                End If

                If FlightsCollection.CurrentFlight.IsBinBulkValid(_strBinBulkNum) <> ReturnCodes.Ok Then
                    'Invalid BinBulk
                    Logger.LogMessage("Invalid Bin/Bulk", LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
                    MyBase.SetError("Invalid Bin/Bulk")
                End If


                ' Take weight input for animal and damaged.
                Select Case CacheManager.BagScanMode
                    Case ScanModes.Animal, ScanModes.Damaged, ScanModes.Manual
                        Dim objdlgWeight As New dlgWeight()
                        objdlgWeight.ShowDialog()
                        intWeight = objdlgWeight.Weight
                End Select
                Logger.LogMessage("BagScanMode=" & CacheManager.BagScanMode, LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")


                Dim retCode As ReturnCodes
                Try
                    If UIController.CurrentFunction = SafetracFunction.ExpediteBag Then

                        strLog = String.Format("Before checking if BagTagValid BagTagNum = {0}", strBagTagNum)
                        Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                        retCode = MyBase.FlightsCollection.CurrentFlight.IsBagTagValid(strBagTagNum)

                        strLog = String.Format("After checking if BagTagValid ReturnCode = {0}", retCode.ToString())
                        Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")


                        Select Case retCode
                            Case ReturnCodes.Ok
                                'valid bag - proceed with normal load
                                retCode = ReturnCodes.BagtagValid
                            Case ReturnCodes.BagtagInvalidForFlight
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadExpediteBag(strBagTagNum, _
                                        CacheManager.ExpediteCode, ReturnCodes.BagtagInvalidForFlight)
                            Case ReturnCodes.BagtagUnknown
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadExpediteBag(strBagTagNum, _
                                        CacheManager.ExpediteCode, ReturnCodes.BagtagUnknown)
                        End Select

                        Select Case retCode
                            Case ReturnCodes.BagtagValid
                                'valid bag - proceed with normal load
                                'pending - goto normal bag loading
                                strLog = String.Format("Before LoadNormalBag BagTagNum = {0}", strBagTagNum)
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadNormalBag(strBagTagNum)

                                strLog = String.Format("After LoadNormalBag ReturnCode = {0}", retCode.ToString())
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
                                Exit Select
                            Case ReturnCodes.Ok

                                Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LastScannedBags.Count
                                strLog = String.Format("After counting LastScannedBags count = {0} , BagScanMode= {1}", intCount, CacheManager.BagScanMode)
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

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
                            Case ReturnCodes.BagtagAlreadyLoaded
                                MyBase.SetError(DisplayMessages.AlreadyRegistered)
                            Case ReturnCodes.NotOk
                            Case ReturnCodes.Unknown
                            Case Else
                                MyBase.SetError(DisplayMessages.UnknownError)
                        End Select
                    ElseIf UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk Then
                        Logger.LogMessage("BagScanMode=" & CacheManager.BagScanMode, LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                        Select Case CacheManager.BagScanMode
                            Case ScanModes.Normal
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadNormalBag(strBagTagNum)
                            Case ScanModes.SingleHeavy, ScanModes.Heavy
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadHeavyBag(strBagTagNum)
                            Case ScanModes.Planeside
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadPlaneSideBag(strBagTagNum)
                            Case ScanModes.Manual
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadManualBag(strBagTagNum, intWeight.ToString)
                            Case ScanModes.Animal
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadAnimal(strBagTagNum, intWeight.ToString)
                            Case ScanModes.Damaged
                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadDamagedBag(strBagTagNum, intWeight.ToString)
                        End Select
                    End If


                    Select Case retCode
                        Case ReturnCodes.Ok
                            Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LastScannedBags.Count
                            strLog = String.Format("After counting LastScannedBags count = {0} , BagScanMode= {1}", intCount, CacheManager.BagScanMode)
                            Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
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
                        Case ReturnCodes.BagtagInvalidForFlight
                            Dim confirmExpedite As DialogResult
                            confirmExpedite = dlgConfirmExpedite.ShowDialog()
                            If confirmExpedite = DialogResult.OK Then
                                'UIController.NextForm = New frmExpediteReason
                                Dim objfrmExpediteReason As New frmExpediteReason
                                'UIController.NextForm.ShowDialog()
                                objfrmExpediteReason.ShowDialog()
                                If CacheManager.ExpediteCode <> NoExpedite Then

                                    strLog = String.Format("Before LoadExpediteBag BagTagNum = {0} , Expedite code = {1} ,BagtagInvalidForFlight = {2}", strBagTagNum, _
                                       CacheManager.ExpediteCode, ReturnCodes.BagtagInvalidForFlight)
                                    Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                                    retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadExpediteBag(strBagTagNum, _
                                       CacheManager.ExpediteCode, ReturnCodes.BagtagInvalidForFlight)

                                    strLog = String.Format("After LoadExpediteBag ReturnCode = {0}", retCode.ToString())
                                    Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                                    Select Case retCode
                                        Case ReturnCodes.Ok
                                            Dim intCount As Integer = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LastScannedBags.Count
                                            strLog = String.Format("After counting LastScannedBags count = {0} , BagScanMode= {1}", intCount, CacheManager.BagScanMode)
                                            Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
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
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")

                                retCode = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.LoadBagOnAlert(strBagTagNum)

                                strLog = String.Format("After LoadBagOnAlert ReturnCode = {0}", retCode.ToString())
                                Logger.LogMessage(strLog, LogType.Information, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
                                Logger.LogMessage("BagScanMode=" & CacheManager.BagScanMode, LogType.Trace, "frmLoadBagToBinBulk.txtBagtag_KeyDown")
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
