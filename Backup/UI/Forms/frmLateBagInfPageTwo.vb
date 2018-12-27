Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmLateBagInfPageTwo
        Public Const MAX_BAGS = 9
        Public Const MAX_PLANESIDEBAGS = 99
        Public Const KEYUP_CUR_UP = 38
        Public Const KEYUP_CUR_DOWN = 40

        Private _strFlightNum As String
        Private _dtFlightDate As NWADateTime
        Private _strCommdType As String
        Private _strWeight As String
        Private _strComments As String

        Public Sub New(ByVal flightNum As String, ByVal flightDate As NWADateTime, ByVal commdType As String, ByVal weight As String, _
        ByVal comment As String)
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            _strFlightNum = flightNum
            _dtFlightDate = flightDate
            _strCommdType = commdType
            _strWeight = weight
            _strComments = comment
        End Sub

        Private Sub frmLateBagInfPage2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'lblSingleHeader.Text = Headers.LateBagInfPage2
            MyBase.SetHeader("Add Late Bags")
            'Pending - Display commoditity types into comobobox 
            Dim binBulks As List(Of String) = MyBase.FlightsCollection.CurrentFlight.GetListOfBinBulksforAddLateBag()
            cmbPos.DataSource = binBulks
        End Sub
        Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
            If IsNumeric(txtBags.Text) Then
                txtBags.Text = CInt(txtBags.Text) + 1
            Else
                txtBags.Text = 1
            End If

            If _strCommdType = "PB" Then
                If CInt(txtBags.Text) > MAX_PLANESIDEBAGS Then
                    txtBags.Text = 1
                End If
            Else
                If CInt(txtBags.Text) > MAX_BAGS Then
                    txtBags.Text = 1
                End If
            End If
        End Sub
        Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
            If IsNumeric(txtBags.Text) Then
                txtBags.Text = CInt(txtBags.Text) - 1
            Else
                txtBags.Text = MAX_BAGS
            End If

            If CInt(txtBags.Text) <= 1 Then
                txtBags.Text = 1
            End If
        End Sub
        Private Sub txtBags_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBags.KeyDown
            If (e.KeyCode = KEYUP_CUR_UP) Then
                btnUp_Click(Me, Nothing)

            ElseIf (e.KeyCode = KEYUP_CUR_DOWN) Then
                btnDown_Click(Me, Nothing)
            End If
        End Sub
        Private Sub txtFnl_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFnl.GotFocus
            MyBase.SetFocus(txtFnl)
        End Sub
        Private Sub cmdBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack3.Click
            UIController.NextForm = New frmLateBagInfPageOne(_strFlightNum, _dtFlightDate)
            UIController.NextForm.ShowDialog()
        End Sub
        Private Sub btnAddBags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBags.Click
            Dim strLog As String = String.Empty
            Dim retCodes As ReturnCodes
            If Not (IsNumeric(txtBags.Text)) Then
                MyBase.SetError("INVALID QTY")
                txtBags.Focus()
                Logger.LogMessage("INVALID QTY", LogType.Trace, "frmLateBagInfPageTwo.btnAddBags_Click")
                Exit Sub
            End If

            If Trim(txtDest.Text) = "" Then
                MyBase.SetError("INVALID DEST")
                txtDest.Focus()
                Logger.LogMessage("INVALID DEST", LogType.Trace, "frmLateBagInfPageTwo.btnAddBags_Click")
                Exit Sub
            End If

            ' Check all inputs
            If Len(Trim(_strWeight)) > 0 Then
                If Not IsNumeric(_strWeight) Then
                    MyBase.SetError("INVALID WEIGHT")
                    Logger.LogMessage("INVALID WEIGHT", LogType.Trace, "frmLateBagInfPageTwo.btnAddBags_Click")
                    Exit Sub
                End If
            End If

            Try
                strLog = String.Format("Before AddLateBag FlightNum={0}, Date={1} , position={2} , quantity={3} , weight={4} , Destination={5} , FinalDest{6} , Comments={7} ", _
                _strFlightNum, _dtFlightDate, cmbPos.SelectedItem, txtBags.Text, _strWeight, Trim(txtDest.Text), Trim(txtFnl.Text), _strComments)
                Logger.LogMessage(strLog, LogType.Information, "frmLateBagInfPageTwo.btnAddBags_Click")

                'Pending  with parameters 
                'Pass the parameters into AddLateBag method
                'retCodes = MyBase.FlightsCollection.Current.AddLateBag(_strFlightNum, _strFlightDate, cmbPos.SelectedItem, _
                'txtBags.Text, _strWeight, Trim(txtDest.Text), Trim(txtFnl.Text), _strComments)
                If MyBase.FlightsCollection.IsFlightValid(_strFlightNum, _dtFlightDate) Then
                    If MyBase.FlightsCollection.CurrentFlight.IsBinBulkValid(cmbPos.SelectedItem) Then
                        retCodes = MyBase.FlightsCollection.CurrentFlight.CurrentBinBulk.AddLateBag(Trim(txtBags.Text), _
                                    _strWeight, _strCommdType, Trim(txtFnl.Text))
                    Else
                        MyBase.SetFooter("INVALID BINBULK")
                    End If
                Else
                    MyBase.SetFooter("INVALID FLIGHT")
                End If

               

                strLog = String.Format("After AddLateBag ReturnCode = {0}", retCodes.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmLateBagInfPageTwo.btnAddBags_Click")

                Select Case retCodes
                    Case ReturnCodes.Ok
                        If retCodes = ReturnCodes.Ok Then
                            If UIController.CurrentFunction = SafetracFunction.AddLateBag Then
                                UIController.NextForm = New frmViewLineItems()
                                MyBase.SetError("ITEMS ADDED")
                            End If
                        End If

                    Case ReturnCodes.NotOk
                        MyBase.SetError("NO DATA FOUND")

                    Case Else
                        'logError 
                        'LogError("Return code from WS_AddLineFDSG = " & iRet)
                End Select
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

    End Class
End Namespace
