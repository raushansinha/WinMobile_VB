
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.UI
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Hardware
Imports NWA.Safetrac.Scanner.Communication

Namespace NWA.Safetrac.Scanner.UI
    ''' <summary>
    ''' Base Form for all Safetrac UI Forms
    ''' </summary>
    ''' <remarks></remarks>
    Public Class frmSafetracBase

        Private _timeAutoLogoff As TimeSpan
        Private _timeUpdate As TimeSpan
        Private _blnIsFooterDisplayed As Boolean
        Private _blnErrorDisplayed As Boolean

        'Public Event OnScan(ByVal sender As Object, ByVal e As ScanEventArgs)
        'Private Sub PsionScanner_ScanCompleteEvent(ByVal sender As System.Object, ByVal e As ScanEventArgs) Handles _objSafetracScanner.OnScan
        '    RaiseEvent OnScan(Me, New ScanEventArgs(e.ScannedValue))
        'End Sub

        Public Overridable Sub OnScan(ByVal sender As Object, ByVal e As ScanEventArgs) Handles _objSafetracScanner.OnScan

        End Sub

        Sub New()
            Try
                InitializeComponent()
                Initialize()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Logger.LogException(ex)
            End Try
        End Sub

        ''' <summary>
        ''' Form Load Event
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub frmSafetracBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                'delete the previous form
                If UIController.PreviousForm IsNot Nothing Then
                    UIController.PreviousForm.Close()
                    UIController.PreviousForm = Nothing
                End If

                _objFlightsCollection = BO.FlightsCollection.GetInstance()
                _objScanner = BO.Scanner.GetInstance()
                _objSafetracScanner = Psion7535.GetInstance()
                _objSafetracScanner.Disable()
                CacheManager.UpdateUserActionTime()
                _timeAutoLogoff = ConfigManager.AutoLogoffTime()
                _timeUpdate = New TimeSpan(0, 0, 5)
                tmrAutoLogoff.Interval = _timeUpdate.TotalMilliseconds
                tmrAutoLogoff_Tick(Me, e)
                tmrAutoLogoff.Enabled = True
                lblTrainingOn.Visible = _objScanner.InTrainingMode
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Logger.LogException(ex)
            End Try
        End Sub

        
        Private Sub tmrAutoLogoff_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoLogoff.Tick
            Try
                Dim intRF As Integer

                Try
                    intRF = Reader.RFSignalLevel
                Catch ex As Exception
                    Logger.LogException(ex)
                    intRF = 0
                End Try

                lblRF.Text = intRF.ToString() & "%"

                If intRF < 20 Then
                    lblRF.BackColor = Color.Red
                    lblRF.ForeColor = Color.White
                ElseIf intRF >= 20 And intRF <= 50 Then
                    lblRF.BackColor = Color.Yellow
                    lblRF.ForeColor = Color.Black
                Else
                    lblRF.BackColor = Color.White
                    lblRF.ForeColor = Color.Black
                End If

                Debug.WriteLine(Date.Now.Subtract(CacheManager.LastUserActionTime).TotalMinutes)

                If Date.Now.Subtract(CacheManager.LastUserActionTime).TotalMinutes > _timeAutoLogoff.TotalMinutes Then
                    'Time lapsed since the last user action has been more than 30 minutes - perform autologoff
                    If UIController.CurrentFunction <> SafetracFunction.Login Then
                        If LoginController.PerformAutoLogoff() Then
                            Logger.LogMessage("UIController.CurrentFunction = SafetracFunction.Login", LogType.Trace, "frmSafetracBase.tmrAutoLogoff_Tick")
                            UIController.CurrentFunction = SafetracFunction.Login
                            UIController.NextForm = New frmLogin()
                            UIController.NextForm.ShowDialog()
                        End If
                    End If
                End If

            Catch stackOverflowEx As StackOverflowException
                Debug.WriteLine(stackOverflowEx.ToString())
            Catch objDisposedEx As ObjectDisposedException
                Debug.WriteLine(objDisposedEx.ToString())
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Logger.LogException(ex)
            End Try
        End Sub

        Public Sub GoToMainMenu()
            Logger.LogMessage("UIController.CurrentFunction = SafetracFunction.MainMenu", LogType.Trace, "frmSafetracBase.GoToMainMenu")
            UIController.CurrentFunction = SafetracFunction.MainMenu
            UIController.NextForm = New frmMainMenu()
            UIController.NextForm.ShowDialog()
        End Sub

        Public Sub Initialize()
            HideFooter()
        End Sub
        ''' <summary>
        ''' Boolean flag indicating if the footer is currently displaying an error
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsErrorEnabled()
            Get
                Return _blnErrorDisplayed
            End Get
        End Property

        ''' <summary>
        ''' Boolean flag indicating if the footer is currently displaying an error
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsFooterEnabled()
            Get
                Return _blnIsFooterDisplayed
            End Get
        End Property
        ''' <summary>
        ''' Singleton instance of FlightsCollection
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property FlightsCollection() As FlightsCollection
            Get
                Return _objFlightsCollection
            End Get
            'Set(ByVal value As FlightsCollection)
            '    _objFlightsCollection = value
            'End Set
        End Property
        ''' <summary>
        ''' Singleton instance of SafetracScanner
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Reader() As ISafetracScanner
            Get
                Return _objSafetracScanner
            End Get
            'Set(ByVal value As ISafetracScanner)
            '    _objSafetracScanner = value
            'End Set
        End Property

        Public ReadOnly Property Scanner() As BO.Scanner
            Get
                Return _objScanner
            End Get
            'Set(ByVal value As ISafetracScanner)
            '    _objSafetracScanner = value
            'End Set
        End Property
        ''' <summary>
        ''' Get the current header being displayed
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetSingleHeader() As String
            Return lblSingleHeader.Text
        End Function
        ''' <summary>
        ''' Get the current header being displayed
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDualHeader() As String
            Return lblMultiHeader1.Text & " " & lblMultiHeader2.Text
        End Function
        ''' <summary>
        ''' Set single header at the base form level
        ''' </summary>
        ''' <param name="headerText"></param>
        ''' <remarks></remarks>
        Public Sub SetHeader(ByVal headerText As String)
            pnlDualHeader.Visible = False
            lblSingleHeader.Text = headerText
            lblSingleHeader.Refresh()
            lblSingleHeader.Visible = True
            pnlDualHeader.Visible = False
            pnlDualHeader.SendToBack()
            pnlSingleHeader.BringToFront()
            lblSingleHeader.BringToFront()
            lblSingleHeader.Refresh()
            Me.Refresh()
        End Sub
        ''' <summary>
        ''' Set dual header at the base form level
        ''' </summary>
        ''' <param name="headerPart1"></param>
        ''' <param name="headerPart2"></param>
        ''' <remarks></remarks>
        Public Sub SetHeader(ByVal headerPart1 As String, ByVal headerPart2 As String)
            lblSingleHeader.Visible = False
            lblMultiHeader1.BringToFront()
            lblMultiHeader2.BringToFront()
            lblMultiHeader1.Text = headerPart1
            lblMultiHeader2.Text = headerPart2
            lblMultiHeader1.Refresh()
            lblMultiHeader2.Refresh()
            pnlDualHeader.Visible = True
            pnlDualHeader.BringToFront()
        End Sub
        ''' <summary>
        ''' Set message to the footer
        ''' </summary>
        ''' <param name="footerText"></param>
        ''' <remarks></remarks>
        Public Sub SetFooter(ByVal footerText As String)
            lblFooter.BringToFront()
            lblFooter.Text = footerText
            lblFooter.Visible = True
            _blnErrorDisplayed = False
            _blnIsFooterDisplayed = True
            lblFooter.Refresh()
            Me.Refresh()
        End Sub

        ''' <summary>
        ''' Set error at the footer
        ''' </summary>
        ''' <param name="footerText"></param>
        ''' <remarks></remarks>
        Public Sub SetError(ByVal footerText As String)
            lblFooter.BringToFront()
            lblFooter.Text = footerText
            lblFooter.Visible = True
            _blnErrorDisplayed = True
            _blnIsFooterDisplayed = True
            lblFooter.Refresh()
            'Give a beep sound
            OpenNETCF.Media.SystemSounds.Beep.Play()
        End Sub
        ''' <summary>
        ''' Set focus to the control
        ''' </summary>
        ''' <param name="txtBox"></param>
        ''' <remarks></remarks>
        Public Sub SetFocus(ByRef txtBox As TextBox)
            Try
                txtBox.Focus()
                txtBox.SelectionStart = 0
                txtBox.SelectionLength = txtBox.Text.Length
                'txtBox.Refresh()
            Catch notSupportedEx As NotSupportedException
                System.Diagnostics.Debug.WriteLine(notSupportedEx.ToString)
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub
        ''' <summary>
        ''' Hide footer
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub HideFooter()
            lblFooter.Visible = False
            lblFooter.SendToBack()
            _blnIsFooterDisplayed = False
            Me.Refresh()
        End Sub
        ''' <summary>
        ''' Clear current footer
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ClearFooter()
            lblFooter.BringToFront()
            lblFooter.Text = String.Empty
            lblFooter.Visible = True
            _blnErrorDisplayed = False
            _blnIsFooterDisplayed = False
            'Me.Refresh()
        End Sub
        ''' <summary>
        ''' Clear current error being displayed
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ClearError()
            If IsErrorEnabled Then
                ClearFooter()
                HideFooter()
                _blnErrorDisplayed = False
                _blnIsFooterDisplayed = False
                '_objSafetracScanner.Enable()
            End If
        End Sub

        Public Sub HideStatusPanel()
            pnlStatus.Visible = False
            lblSingleHeader.Visible = False
            lblMultiHeader1.Visible = False
            lblMultiHeader2.Visible = False
            pnlDualHeader.Visible = False
            Me.Refresh()
        End Sub

        Public Sub ShowControl(ByVal objControl As Control)
            objControl.BringToFront()
            objControl.Visible = True
            Me.Refresh()
        End Sub

        Public Sub HideControl(ByVal objControl As Control)
            objControl.SendToBack()
            objControl.Visible = False
            Me.Refresh()
        End Sub

        ''' <summary>
        ''' Update last user action time to cache
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub UpdateUserActionTime()
            CacheManager.UpdateUserActionTime()
        End Sub

        Public ReadOnly Property IsInNetwork(ByVal showPrompt As Boolean) As Boolean
            Get
                If ConnectionManager.IsConnected Then
                    Return True
                Else
                    If showPrompt Then
                        Dim objDlgNoNetwork As New dlgNoNetworkPrompt()
                        objDlgNoNetwork.ShowDialog()
                    End If
                    Return False
                End If
            End Get
        End Property

        'End Function

        'Public Sub ShowNoNetworkPrompt()

        'End Sub


        ''' <summary>
        ''' Format the textbox for bagtag input
        ''' </summary>
        ''' <param name="textBox"></param>
        ''' <param name="keyAscii"></param>
        ''' <remarks></remarks>
        Public Sub FormatKeysForBagtag(ByVal textBox As TextBox, ByVal keyAscii As Integer)

            ' GIVEN: Textbox getting data, latest keypress
            ' TASK: Sets numlock as appropriate for entering a NWA-format bagtag

            If IsAlphaNum(Convert.ToChar(keyAscii)) Then
                Select Case textBox.Text.Length
                    Case 1
                        ' Adding 2nd char, force numlock after this char
                        ' SetNumLock True, txt.Parent

                End Select
            Else
                ' BKSP, etc.
                If keyAscii = Keys.Back Then
                    'If KeyAscii = vbKeyBack Then
                    Select Case textBox.Text.Length
                        Case 0, 1
                            ' ENABLE SCANNER (whole bagtag deleted)
                            Dim scanner As ISafetracScanner
                            scanner = Psion7535.GetInstance
                            scanner.Disable()

                        Case 3
                            ' Force numlock for third character
                            ' SetNumLock True, txt.Parent

                    End Select
                End If

            End If

        End Sub
        ''' <summary>
        ''' Format the textbox for binbulk input
        ''' </summary>
        ''' <param name="textBox"></param>
        ''' <param name="keyAscii"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FormatKeysForBinBulk(ByVal textBox As TextBox, ByVal keyAscii As Integer) As Integer

            ' TASK: Constrain user's input to 1, 2, 3, 4 or 51, 52, 53, 54

            ' Limit to 1-4, 51-54
            If IsNumeric(Convert.ToChar(keyAscii)) Then
                ' Convert data

                Dim intCounter As Integer
                'Pending - Aditya
                intCounter = Convert.ToInt16(Convert.ToChar(keyAscii))

                ' If no chars exist in textbox:
                If textBox.Text.Length = 0 Then
                    If intCounter > 5 Or intCounter = 0 Then
                        ' Nothing in textbox; user can only type "1" or "5"
                        ' e.g. 1 , 2 , 54
                        keyAscii = 0
                    End If

                    ' If 1 char exists in textbox:
                ElseIf textBox.Text.Length = 1 Then
                    If textBox.Text = "1" Then
                        ' Char entered in textbox is "1", disallow any other numbers
                        keyAscii = 0

                    ElseIf textBox.Text = "5" Then
                        ' Only allow 1 - 4
                        If intCounter > 4 Then
                            keyAscii = 0
                        End If

                    End If

                End If

            ElseIf IsAlpha(Convert.ToChar(keyAscii)) Then
                keyAscii = 0

            End If

            FormatKeysForBinBulk = keyAscii

        End Function
        ''' <summary>
        ''' Format the textbox for date input
        ''' </summary>
        ''' <param name="textBox"></param>
        ''' <param name="keyAscii"></param>
        ''' <remarks></remarks>
        Public Sub FormatKeysForDate(ByVal textBox As TextBox, ByVal keyAscii As Integer)

            ' GIVEN: Textbox getting data, latest keypress
            ' TASK: Sets numlock as appropriate for entering a NWA-format date (NNAAA)

            ' Automatically switch between letters/numbers on
            ' printable char keypress (not if backspace, etc)
            If IsAlphaNum(Convert.ToChar(keyAscii)) Then
                Select Case textBox.Text.Length
                    Case 0
                        ' Adding first char, set num lock
                        ' SetNumLock True, txt.Parent

                    Case 1
                        ' Adding 2nd char, set alpha lock after this char
                        ' SetNumLock False, txt.Parent
                        ' SetShiftLock True
                End Select
            Else
                ' BKSP, etc.
                Select Case textBox.Text.Length
                    Case 3, 4, 5
                        ' SetNumLock False, txt.Parent
                        ' SetShiftLock True

                    Case 1, 2
                        ' SetNumLock True, txt.Parent

                End Select
            End If

        End Sub
        ''' <summary>
        ''' Format the textbox for flight number input
        ''' </summary>
        ''' <param name="textBox"></param>
        ''' <param name="keyAscii"></param>
        ''' <remarks></remarks>
        Public Sub FormatKeysForFlight(ByVal textBox As TextBox, ByVal keyAscii As Integer)

            ' GIVEN: Textbox getting data, latest keypress
            ' TASK: Sets numlock as appropriate for entering a flight; also translates
            '           first character to letter if airline code is prepended by user

            ' Automatically switch between letters/numbers on
            ' printable char keypress (not if backspace, etc)
            If IsAlphaNum(Convert.ToChar(keyAscii)) Then
                Select Case textBox.Text.Length
                    Case 1
                        ' Adding 2nd char, set num lock after this char
                        ' Pending - SetNumLock
                        ' SetNumLock True, txt.Parent

                End Select
            Else
                ' BKSP, etc.
                Select Case textBox.Text.Length
                    Case 3, 4, 5, 6
                        ' Pending - SetNumLock
                        ' SetNumLock True, txt.Parent

                    Case 1, 2
                        ' Pending - SetNumLock
                        ' SetNumLock True, txt.Parent
                End Select

            End If
        End Sub
        ''' <summary>
        ''' Format the textbox for ULD number input
        ''' </summary>
        ''' <param name="textBox"></param>
        ''' <param name="keyAscii"></param>
        ''' <remarks></remarks>
        Public Sub FormatKeysForULD(ByVal textBox As TextBox, ByVal keyAscii As Integer)

            ' GIVEN: Textbox getting data, latest keypress
            ' TASK: Sets numlock as appropriate for entering a NWA-format ULD

            ' Automatically switch between letters/numbers on
            ' printable char keypress (not if backspace, etc)

            'If KeyAscii = vbKeyBack Then
            If keyAscii = Keys.Back Then
                Select Case textBox.Text.Length
                    Case 9
                        ' e.g. CAR123456N^W
                        ' SetNumLock False, txt.Parent

                    Case 8
                        ' e.g. CAR123456^
                        ' SetNumLock True, txt.Parent

                    Case 3
                        ' e.g. CAR^123456
                        ' SetNumLock False, txt.Parent

                End Select
            Else
                Select Case textBox.Text.Length
                    Case 2
                        ' SetNumLock True, txt.Parent
                        Dim scanner As ISafetracScanner
                        scanner = Psion7535.GetInstance
                        scanner.Disable()
                    Case 7
                        If Not IsNumeric(textBox.Text) Then
                            ' e.g. CAR12345
                            ' SetNumLock False, txt.Parent
                        End If
                        Dim scanner As ISafetracScanner
                        scanner = Psion7535.GetInstance
                        scanner.Disable()
                End Select
            End If
        End Sub

        '''' <summary>
        '''' Update view of the status panel
        '''' </summary>
        '''' <remarks></remarks>
        'Public Sub UpdateView()
        '    Try
        '        'Logic to fetch the status panel elements and update them with
        '        'current values

        '        Me.Refresh()
        '        'sleep for 5 minutes
        '        Thread.Sleep(300000)
        '        If Date.Now.Subtract(CacheManager.LastUserActionTime) > _timeSpan Then
        '            'Time lapsed since the last user action has been more than 30 minutes
        '            'stop the current thread
        '            Try
        '                _thrdUpdater.Abort()
        '            Catch thrdAbortEx As ThreadAbortException
        '            End Try
        '            'perform autologoff
        '            If LoginController.AutoLogoff() Then

        '                Me.Close()
        '                Dim objfrmLogin As New frmLogin

        '            End If
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString)
        '        Logger.LogException(ex)
        '    End Try
        'End Sub

        '''' <summary>
        '''' Default constructor
        '''' </summary>
        '''' <remarks></remarks>
        'Sub New(ByVal header As String)
        '    Try
        '        InitializeComponent()
        '        Initialize()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString)
        '        Logger.LogException(ex)
        '    End Try
        'End Sub


        Private Sub frmSafetracBase_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            tmrAutoLogoff.Enabled = False
            tmrAutoLogoff.Interval = 0
        End Sub


    End Class
End Namespace