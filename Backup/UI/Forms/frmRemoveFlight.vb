
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Utils

Namespace NWA.Safetrac.Scanner.UI

    Public Class frmRemoveFlight

        Private Sub frmRemoveFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            MyBase.SetHeader("REMOVE FLIGHT")
            InitializeFlightsList()
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            Try

                Dim retCode As ReturnCodes
                ' Dim nwaFlightKey As NWAFlight = MyBase.FlightsCollection.GetFlightNum(cmbFlights.SelectedValue.ToString)
                Dim nwaFlightKey As NWAFlight = MyBase.FlightsCollection.GetFlightNum(cmbFlights.SelectedValue)
                Dim footerMessage As String = String.Empty
                Dim blnIsError As Boolean = True
                Dim strLog As String

                strLog = String.Format("Before RemoveFlight : nwaFlightKey.Number = {0} nwaFlightKey.DepartureDate = {1}", nwaFlightKey.Number, nwaFlightKey.DepartureDate)
                Logger.LogMessage(strLog, LogType.Information, "frmRemoveFlight.btnRemove_Click")

                retCode = MyBase.FlightsCollection.RemoveFlight(nwaFlightKey.Number, nwaFlightKey.DepartureDate)

                strLog = String.Format("After RemoveFlight : ReturnCodes = {0}", retCode.ToString())
                Logger.LogMessage(strLog, LogType.Information, "frmRemoveFlight.btnRemove_Click")

                Select Case retCode
                    Case ReturnCodes.FlightRemoved
                        footerMessage = "FLIGHT REMOVED"
                        blnIsError = False
                    Case ReturnCodes.DatabaseError
                        footerMessage = DisplayMessages.DatabaseError
                    Case ReturnCodes.Unknown
                        footerMessage = DisplayMessages.UnknownError
                    Case ReturnCodes.Ok
                        footerMessage = "FLGHT REMOVED"
                    Case Else
                        footerMessage = DisplayMessages.UnknownError
                End Select

                Logger.LogMessage("UIController.NextForm = New frmFlightMenu(footerMessage, blnIsError)", LogType.Trace, "frmRemoveFlight.btnRemove_Click")
                UIController.CurrentFunction = SafetracFunction.FlightsMenu
                UIController.NextForm = New frmFlightMenu(footerMessage, blnIsError)
                UIController.NextForm.ShowDialog()

            Catch ex As Exception
                Logger.LogException(ex)
            End Try

        End Sub

        Private Sub InitializeFlightsList()
            Try
                Dim liFlights As List(Of String) = MyBase.FlightsCollection.GetConfiguredFlightsList
                If liFlights.Count > 1 Then
                    cmbFlights.DataSource = liFlights
                Else
                    Logger.LogMessage("UIController.NextForm = New frmFlightMenu(NO CONF FLIGHTS, False)", LogType.Trace, "frmRemoveFlight.InitializeFlightsList")
                    UIController.CurrentFunction = BO.SafetracFunction.FlightsMenu
                    UIController.NextForm = New frmFlightMenu("NO CONF FLIGHTS", False)
                    UIController.NextForm.ShowDialog()
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub frmRemoveFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Try
                If e.KeyCode = Keys.Escape Then
                    Logger.LogMessage("UIController.NextForm = New frmFlightMenu()", LogType.Trace, "frmRemoveFlight.frmRemoveFlight_KeyDown")
                    UIController.CurrentFunction = SafetracFunction.FlightsMenu
                    UIController.NextForm = New frmFlightMenu()
                    UIController.NextForm.ShowDialog()
                End If
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub
    End Class
End Namespace
