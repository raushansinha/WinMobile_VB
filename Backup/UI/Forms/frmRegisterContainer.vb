
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmRegisterContainer


        Sub New(ByVal containerNum As String)
            InitializeComponent()
            lblContainerNum.Text = containerNum
        End Sub
        Sub New()
            InitializeComponent()
        End Sub
        Private Sub frmRegisterULDCart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim flightNum As String
            flightNum = MyBase.FlightsCollection.CurrentFlight.FlightNum
            Validate.IsNWAFlightValid(flightNum)
            lblFlightNum.Text = flightNum

            MyBase.SetHeader("ULD Registration")
            lblFlightDate.Text = MyBase.FlightsCollection.CurrentFlight.DepartureDate.NWAFormat
            'lblContainerDestination.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Destination
            lblContainerType.Text = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Type
            MyBase.SetFocus(txtContainerName)
        End Sub

        Private Sub frmRegisterContainer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                UIController.NextForm = New frmContainerInquiry()
                UIController.NextForm.ShowDialog()
            End If
            If e.KeyCode = Keys.Enter Then
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                End If
                If MyBase.IsFooterEnabled Then
                    MyBase.ClearFooter()
                    Exit Sub
                End If
                btnLookup_Click(Me, Nothing)
            End If
        End Sub

        Private Sub btnLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookup.Click
            
            If MyBase.IsErrorEnabled Then
                MyBase.ClearError()
                Exit Sub
            End If

            Dim strLog As String = String.Empty
            Dim strContainerName As String = String.Empty
            strContainerName = txtContainerName.Text.Trim.ToUpper
            If BO.Validate.IsULDNumFormatValid(txtContainerName.Text) Then
                txtContainerName.Text = strContainerName
                Try
                    If MyBase.IsInNetwork(True) Then
                        Dim retCode As ReturnCodes

                        retCode = MyBase.FlightsCollection.CurrentFlight.CurrentContainer.Register(strContainerName)

                        Select Case retCode
                            Case ReturnCodes.Ok
                                MyBase.SetFooter("ULD REGISTERED OK")
                                btnLookup.Enabled = False
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError("DATABASE ERROR")
                            Case ReturnCodes.ContainerNumInvalid
                                MyBase.SetError(DisplayMessages.InvalidULDFormat)
                            Case ReturnCodes.ContainerNumInvalid
                                MyBase.SetError(DisplayMessages.InvalidUldOrCartOrContainerSheet)
                            Case ReturnCodes.Unknown
                                MyBase.SetError(DisplayMessages.UnknownContainerSheet)
                            Case 204
                                MyBase.SetError("UnknownULD")
                            Case ReturnCodes.ContainerNameAlreadyRegistered
                                MyBase.SetError(DisplayMessages.ULDAlreadyRegistered)
                            Case ReturnCodes.ContainerNumAlreadyRegistered
                                MyBase.SetError(DisplayMessages.ContainerSheetAlreadyRegistered)
                            Case 207
                                MyBase.SetError(DisplayMessages.ULDinUse)
                            Case 208
                                MyBase.SetError(DisplayMessages.ContainerSheetinUse)
                            Case 209
                                MyBase.SetError(DisplayMessages.CartOnly)
                            Case ReturnCodes.FlightDeparted
                                MyBase.SetError(DisplayMessages.FlightDeparted)
                            Case ReturnCodes.FlightClosed
                                MyBase.SetError(DisplayMessages.FlightClosed)
                        End Select
                    End If
                Catch expSafetrac As SafetracException
                    Logger.LogException(expSafetrac)
                Catch ex As Exception
                    Logger.LogException(ex)
                    MyBase.SetFooter(DisplayMessages.UnknownError)
                End Try
            Else
                MyBase.SetError(DisplayMessages.InvalidULDFormat)
                SetFocus(txtContainerName)
            End If
        End Sub

    End Class
End Namespace




