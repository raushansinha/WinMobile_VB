Namespace NWA.Safetrac.Scanner.BO
    Public Structure NWADateTime
        Private _date As Date
        'Private _strDate As String
        Public ReadOnly Property NWAFormat() As String
            Get
                Return _date.ToString("ddMMM").ToUpper
            End Get
        End Property
        Public ReadOnly Property VBFormat() As Date
            Get
                Return _date
            End Get
        End Property
        Public ReadOnly Property SqlDateFormat() As String
            Get
                Return _date.ToString("yyyy-MM-dd")
            End Get
        End Property
        Public ReadOnly Property NWATime() As String
            Get
                Return _date.ToString("HHmm")
            End Get
        End Property

        Public ReadOnly Property WebFormat() As String
            Get
                Return _date.ToString("dd-MMM-yy")
            End Get
        End Property


        Public ReadOnly Property OracleFormat() As String
            Get
                Return _date.ToString("dd-MMM-yyyy")
            End Get
        End Property
        Public ReadOnly Property SqlDateTimeFormat() As String
            Get
                Return _date.ToString("yyyy-MM-dd hh:mm:ss")
            End Get
        End Property
        Public Sub New(ByVal vbDate As Date)
            _date = vbDate
            'pending - modify the formatter
            '_strDate = vbDate.ToString("ddMMM").ToUpper
        End Sub
        Public Sub New(ByVal nwaDate As String)
            If Validate.IsNWADateValid(nwaDate) Then
                If nwaDate.Length = 5 Then

                    'If NWADateTime.IsValid(nwaDate) Then
                    _date = Date.ParseExact(nwaDate, "ddMMM", Nothing)
                    '_strDate = nwaDate
                Else
                    _date = Date.Parse(nwaDate)
                    ' _strDate = _date.ToString("ddMMM").ToUpper
                End If
            Else
                Throw New SafetracException(ReturnCodes.FlightDateInvalid)
            End If
        End Sub
        Public Overrides Function ToString() As String
            Return _date.ToString("ddMMM").ToUpper
        End Function
        Public Overloads Function ToString(ByVal formatter As String) As String
            Return _date.ToString(formatter, Nothing)
        End Function
        Public Shared Function IsValid(ByVal nwaDate As String) As Boolean
            Try
                Dim strTemp As Date = DateTime.ParseExact(nwaDate, "ddMMM", Nothing)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

    End Structure

    Public Structure NWAFlight
        Private _strFlight As String
        Private _dtDate As NWADateTime

        Public Property Number() As String
            Get
                Return _strFlight
            End Get
            Set(ByVal value As String)
                _strFlight = value
            End Set
        End Property

        Public Property DepartureDate() As NWADateTime
            Get
                Return _dtDate
            End Get
            Set(ByVal value As NWADateTime)
                _dtDate = value
            End Set
        End Property


        Public Sub New(ByVal flightNum As String, ByVal strDate As String)
            _strFlight = flightNum
            _dtDate = New NWADateTime(strDate)
        End Sub

        Public Sub New(ByVal flightNum As String, ByVal departureDate As NWADateTime)
            _strFlight = flightNum
            _dtDate = departureDate
        End Sub
    End Structure

    Public Structure HubFlight
        Private _strhubDest As String
        Private _strHubFlight As String
        Private _dtHubDate As NWADateTime

        Public Property Destination() As String
            Get
                Return _strhubDest
            End Get
            Set(ByVal value As String)
                _strhubDest = value
            End Set
        End Property

        Public Property Number() As String
            Get
                Return _strHubFlight
            End Get
            Set(ByVal value As String)
                _strHubFlight = value
            End Set
        End Property

        Public Property DepartureDate() As NWADateTime
            Get
                Return _dtHubDate
            End Get
            Set(ByVal value As NWADateTime)
                _dtHubDate = value
            End Set
        End Property

        Public Sub New(ByVal hubDest As String, ByVal hubFlightNum As String, ByVal hubDepartureDate As NWADateTime)
            _strhubDest = hubDest
            _strHubFlight = hubFlightNum
            _dtHubDate = hubDepartureDate
        End Sub
    End Structure
End Namespace