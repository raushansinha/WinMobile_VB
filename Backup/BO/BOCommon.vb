Imports System.Xml
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.WebReferences

Namespace NWA.Safetrac.Scanner.BO
    Public Module Common

        Public Function GetFlightForBagTag(ByVal bagTagNum As String) As NWAFlight
            Try
                Return FlightOperations.GetFlightForBagTag(bagTagNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetFlightForContainerName(ByVal containterName As String) As NWAFlight
            Try
                Return FlightOperations.GetFlightNumForContainerName(containterName)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckBagsToUnload(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ReturnCodes
            'pending 
            Return ReturnCodes.Ok
        End Function
        Public Function GetDDSGLineItems(ByVal flightNum As String, ByVal flightDate As NWADateTime) As DataSet

        End Function

        Public Function GetFlightForContainerNum(ByVal containterNum As String) As NWAFlight
            Try
                Return FlightOperations.GetFlightNumForContainerNum(containterNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetPiecesForFreight(ByVal awbNum As String) As String
            Try
                Return FlightOperations.GetPcsForFreight(awbNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetWeightForFreight(ByVal awbNum As String) As String
            Try
                Return FlightOperations.GetIndWeightForFreight(awbNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetFlightStatus(ByVal flightNum As String) As String
            Try
                Return FlightOperations.GetFltStatus(flightNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetBagsToUnload(ByVal flightNum As String, ByVal flightDate As NWADateTime) As ScannerServiceResponse

            Dim response As ScannerServiceResponse = Nothing

            Try

                Dim objScanner As Scanner = Scanner.GetInstance

                Dim objServices As ScannerServices = ScannerServices.GetInstance

                response = objServices.GetBagsToUnload(Validate.GetAirlineCode(flightNum), _
                    Validate.ToFourDigitFltNum(flightNum), flightDate, objScanner.Station)
            Catch ex As Exception

            End Try

            Return response

        End Function

        Public Function GetContainerSummary(ByVal container As String, ByVal IsContainerNum As Boolean) As DataSet
            'make webservice call for container inquiry


            Return Nothing
        End Function

        Public Function GetBinBulkSummary(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                    ByVal binBulkNum As String) As DataSet
            'If not able to retrive binbulk information from database perform webservice call

            'populate binbulk object

            'throw appropriate exception if not able to retrive information from either of the sources
            'implement exception handling in the calling method to identify exception and
            'display appropriate error message to the user

            Return Nothing
        End Function

        Public Function RetrieveContainerInfo(ByVal flightNum As String, ByVal departureDate As String, _
                    ByVal containerNum As String) As Dictionary(Of String, String)
            Dim diTemp As New Dictionary(Of String, String)

            'First try to retrieve container information from the database

            'If not able to retrive container information from database then perform webservice call

            'populate dictionary object with the necessary params

            'throw appropriate exception if not able to retrive information from either of the sources
            'implement exception handling in the calling method to identify exception and
            'display appropriate error message to the user
            Return diTemp
        End Function

        Public Function MergeContainers(ByVal fromFlightNum As String, ByVal fromFlightDate As NWADateTime, _
        ByVal fromBinBulkNo As String, ByVal toFlightNum As String, ByVal toFlightDate As NWADateTime, _
        ByVal toBinBulkNo As String, ByVal commodityType As String, ByVal pieceCount As String) As ReturnCodes
            'piece count might be ALL
            'check for commodity type

            Return BO.MergeContainers(fromFlightNum, fromFlightDate, fromBinBulkNo, toFlightNum, toFlightDate, toBinBulkNo, commodityType, pieceCount)

            Return ReturnCodes.NotOk
        End Function

        'Public Function SetBagtagAlert(ByVal bagTagNum As Integer) As ReturnCodes

        'End Function
        'Public Function RemoveBagAlert(ByVal bagTagNum As Integer) As ReturnCodes

        'End Function

        Public Function IsDuplicateBagtag(ByVal bagTagNum As String) As Boolean
            Dim iCountDupBags As New Integer
            Return FlightOperations.IsDuplicateBagtag(bagTagNum)
        End Function
        Public Function IsBagtagValid(ByVal bagTagNum As String) As Boolean
            If FlightOperations.IsBagTagValid(bagTagNum) = ReturnCodes.Ok Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function IsMailValid(ByVal mailNum As String) As Boolean
            If FlightOperations.IsMailValid(mailNum) Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function IsAWBValid(ByVal awbNum As String) As Boolean
            If FlightOperations.IsFreightValid(awbNum) = ReturnCodes.Ok Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function GetDuplicateBagtags(ByVal bagTagNum As String) As DataSet
            Return FlightOperations.GetDuplicateBagtags(bagTagNum)
        End Function

        Public Function IsBagAlreadyLoaded(ByVal flightNum As String, ByVal departureDate As NWADateTime, _
                        ByVal bagTagNum As String) As Boolean
            If FlightOperations.IsBagAlreadyLoaded(flightNum, departureDate, bagTagNum) = ReturnCodes.Ok Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function IsDestinationValid(ByVal destination As String) As Boolean
            'pending
            Return True
        End Function

        Public Function GetFlightForFreight(ByVal freightNum As String) As NWAFlight
            Try
                Return FlightOperations.GetFlightNumForFreight(freightNum)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetHubInformationforNum(ByVal containterNum As String) As HubFlight
            Try
                'pending - uncomment this code
                'Return FlightOperations.GetHubInfoForNum(containterNum)
            Catch ex As Exception
                'Throw ex
            End Try
        End Function

        Public Function GetHubInformationforName(ByVal containterNum As String) As HubFlight
            Try
                'pending - uncomment this code
                'Return FlightOperations.GetHubInfoForName(containterNum)
            Catch ex As Exception
                'Throw ex
            End Try
        End Function

    End Module
End Namespace