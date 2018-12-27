Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmUnloadFreight

        Private Sub txtAWB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAWB.GotFocus
            MyBase.SetFocus(txtAWB)
        End Sub

        Private Sub txtAWB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAWB.KeyDown
            Dim retCode As ReturnCodes

            'clear the footer if it is already showing an error
            If e.KeyCode = Keys.Enter Then
                MyBase.UpdateUserActionTime()
                If MyBase.IsErrorEnabled Then
                    MyBase.ClearError()
                    Exit Sub
                Else
                    'if enter key is pressed
                    Dim strAWB As String = txtAWB.Text.Trim
                    Dim nwaFlight As NWAFlight = Nothing
                    Try

                        'validating AWB number - UI validation
                        If strAWB = String.Empty Then
                            MyBase.SetError(DisplayMessages.NotLoaded)
                            SetFocus(txtAWB)
                            Exit Sub
                        ElseIf Validate.IsAWBValid(strAWB) = AWBReturnCodes.AWBValid Then
                            txtAWB.Text = strAWB
                            MyBase.HideFooter()
                            strAWB = txtAWB.Text.Trim.ToUpper
                        Else
                            MyBase.SetError(DisplayMessages.InvalidAWB)
                            SetFocus(txtAWB)
                            Exit Sub
                        End If

                        MyBase.ShowControl(fraWait) 'Display message-Retreiving data please wait

                        'check if freight is valid
                        If Common.IsAWBValid(strAWB) = False Then
                            MyBase.SetFooter(DisplayMessages.UnknownAWB)
                            SetFocus(txtAWB)
                            MyBase.HideControl(fraWait) 'Hide message - Retreiving data please wait
                            Exit Sub
                        End If


                        'get associated flight details
                        nwaFlight = Common.GetFlightForFreight(strAWB)
                        If nwaFlight.Number Is Nothing Then
                            MyBase.HideControl(fraWait) 'Hide message - Retreiving data please wait
                            MyBase.SetFooter(DisplayMessages.UnknownAWB)
                            Exit Sub
                        End If

                        'check if freight is Loaded
                        retCode = MyBase.FlightsCollection.Flights(nwaFlight.Number, nwaFlight.DepartureDate).IsFreightLoaded(strAWB)
                        MyBase.HideControl(fraWait) 'Hide message - Retreiving data please wait
                        Select Case retCode
                            Case ReturnCodes.NotOk
                                MyBase.SetFooter(DisplayMessages.NotLoaded)
                                SetFocus(txtAWB)
                                Exit Sub
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError(DisplayMessages.DatabaseError)
                                SetFocus(txtAWB)
                                Exit Sub
                            Case ReturnCodes.Unknown
                                MyBase.SetError(DisplayMessages.UnknownError)
                                SetFocus(txtAWB)
                                Exit Sub
                        End Select

                    Catch ex As Exception
                        Logger.LogException(ex)
                    End Try

                    'unload freight
                    Try
                        retCode = MyBase.FlightsCollection.Flights(nwaFlight.Number, nwaFlight.DepartureDate).UnloadFreight(strAWB)
                        MyBase.HideControl(fraWait) 'Hide message - Retreiving data please wait
                        Select Case retCode
                            Case ReturnCodes.FlightClosed
                                MyBase.SetError(DisplayMessages.FlightClosed)
                            Case ReturnCodes.FlightDeparted
                                MyBase.SetError(DisplayMessages.FlightDeparted)
                            Case ReturnCodes.Ok
                                MyBase.SetFooter(DisplayMessages.FreightUnloaded)
                            Case ReturnCodes.FreightNotLoaded
                                MyBase.SetFooter(DisplayMessages.NotLoaded)
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError(DisplayMessages.DatabaseError)
                            Case ReturnCodes.Unknown
                        End Select
                    Catch safetracExp As SafetracException
                        MyBase.HideControl(fraWait) 'Hide message - Retreiving data please wait
                        Select Case safetracExp.ErrorCode
                            Case ReturnCodes.DatabaseError
                                MyBase.SetError(DisplayMessages.DatabaseError)
                            Case ReturnCodes.Unknown
                                MyBase.SetError(DisplayMessages.UnknownError)
                        End Select
                    Catch ex As Exception
                        Logger.LogException(ex)
                    End Try
                    SetFocus(txtAWB)
                End If
            End If
        End Sub
        Private Sub frmUnloadFreight_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            MyBase.Reader.Disable()
        End Sub
        Private Sub frmUnloadFreight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
            MyBase.SetFocus(txtAWB)
        End Sub

        Private Sub frmUnloadFreight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            'hide footer , when there is no error
            If e.KeyCode = Keys.Enter Then
                If Not MyBase.IsErrorEnabled Then
                    MyBase.HideFooter()
                End If
            End If
            
            If e.KeyCode = Keys.Escape Then
                MyBase.GoToMainMenu()
            End If

        End Sub

        Private Sub frmUnloadFreight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("UNLOAD FREIGHT")
            MyBase.Reader.Enable()
        End Sub
    End Class
End Namespace