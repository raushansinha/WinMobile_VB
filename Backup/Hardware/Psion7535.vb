Imports System
Imports PsionTeklogix.Barcode.ScannerServices
Imports PsionTeklogix.Barcode.Scanner
Imports PsionTeklogix.Backlight
Imports PsionTeklogix.Power
Imports PsionTeklogix.WWAN
Imports NWA.Safetrac.Scanner.Utils
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Namespace NWA.Safetrac.Scanner.Hardware

    ''' <summary>
    ''' Represents a Safetrac Scanner based on Psion 7535 model
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Psion7535
        Implements ISafetracScanner

        Private Shared _objPsion7535 As Psion7535
        Friend WithEvents _objPsionScanner As PsionTeklogix.Barcode.Scanner = Nothing
        Friend WithEvents _objScannerDriver As PsionTeklogix.Barcode.ScannerServices.ScannerServicesDriver
        Public Event OnScan(ByVal sender As Object, ByVal e As ScanEventArgs)

        Public Shared Function GetInstance() As Psion7535
            If _objPsion7535 Is Nothing Then
                _objPsion7535 = New Psion7535
            End If
            Return _objPsion7535
        End Function

        'P/Invoke dec for setting the system time... 
        <DllImport("coredll.dll")> _
        Private Shared Function SetLocalTime(ByRef time As SystemTime) As Boolean
        End Function

        Private Sub New()
            Try
                'Me._objScannerDriver = New PsionTeklogix.Barcode.ScannerServices.ScannerServicesDriver
                'Me._objPsionScanner = New PsionTeklogix.Barcode.Scanner(_objScannerDriver)
                'Me._objPsionScanner.Driver = Me._objScannerDriver
                'Me._objScannerDriver.ClickData = "0"
                'Me._objScannerDriver.ClickTime = 0
                'Me._objScannerDriver.CodabarEnabled = False
                'Me._objScannerDriver.Code11Enabled = False
                'Me._objScannerDriver.Code128Enabled = True
                'Me._objScannerDriver.Code39Enabled = True
                'Me._objScannerDriver.Code93Enabled = False
                'Me._objScannerDriver.Discrete2Of5Enabled = False
                'Me._objScannerDriver.DotTime = 1
                'Me._objScannerDriver.EAN13Enabled = True
                'Me._objScannerDriver.EAN8Enabled = False
                'Me._objScannerDriver.I2Of5Enabled = True
                'Me._objScannerDriver.IATA2Of5 = False
                'Me._objScannerDriver.MSIPlesseyEnabled = False
                'Me._objScannerDriver.ScanBeep = True
                'Me._objScannerDriver.ScanIndicator = True
                'Me._objScannerDriver.ScanLog = True
                'Me._objScannerDriver.ScanResult = True
                'Me._objScannerDriver.ScanResultTime = 1
                'Me._objScannerDriver.Security = 1
                'Me._objScannerDriver.ShortCode = True
                'Me._objScannerDriver.UPCAEnabled = True
                'Me._objScannerDriver.UPCEANEnabled = True
                'Me._objScannerDriver.UPCEEnabled = True
                'Me._objScannerDriver.Verify = 1
            Catch loadExp As TypeLoadException
                System.Diagnostics.Debug.WriteLine(loadExp.ToString())
            Catch ex As Exception
                Logger.LogException(ex)
            End Try
        End Sub

        Private Sub PsionScanner_ScanCompleteEvent(ByVal sender As System.Object, ByVal e As PsionTeklogix.Barcode.ScanCompleteEventArgs) Handles _objPsionScanner.ScanCompleteEvent
            RaiseEvent OnScan(Me, New ScanEventArgs(e.Text))
        End Sub
        ''' <summary>
        ''' Implements BatteryLevel Property of SafetracScanner interface
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property BatteryLevel() As Integer Implements ISafetracScanner.BatteryLevel
            Get
                If _objPsionScanner IsNot Nothing Then
                    Return PsionTeklogix.Power.PowerManagement.MainBatteryPercent
                Else
                    Return 0
                End If
            End Get
        End Property
        ''' <summary>
        ''' Returns scanner state
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsScannerEnabled() As Boolean Implements ISafetracScanner.IsScannerEnabled
            Get
                If _objPsionScanner IsNot Nothing Then
                    Return _objPsionScanner.Enabled
                End If
            End Get
        End Property

        ''' <summary>
        ''' Implements SetBackLightTime property of SafetracScanner interface
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BackLightTime() As Double Implements ISafetracScanner.BacklightTime
            Get
                If _objPsionScanner IsNot Nothing Then

                    Return BacklightControl.DisplayBacklightOnTime / 60000
                Else
                    Return 1
                End If
            End Get
            Set(ByVal value As Double)
                If _objPsionScanner IsNot Nothing Then
                    PsionTeklogix.Backlight.BacklightControl.DisplayBacklightOnTime = value * 60000
                End If
            End Set
        End Property

        ''' <summary>
        ''' Implements GetRFSignalLevel method of SafetracScanner interface
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property RFSignalLevel() As Integer Implements ISafetracScanner.RFSignalLevel
            Get
                If _objPsionScanner IsNot Nothing Then
                    Dim objWWanSignalState As New PsionTeklogix.WWAN.WWAN_SIGNAL_STATE
                    Return (objWWanSignalState.Rssi)
                Else
                    Return 0
                End If
            End Get
        End Property
        ''' <summary>
        ''' Implements SetDateTime property of SafetracScanner interface
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public Property DateTime() As Date Implements ISafetracScanner.DateTime
            Get
                Return Date.Now
            End Get
            Set(ByVal value As Date)
                Try
                    Dim systemDate As SystemTime
                    systemDate.Year = value.Year
                    systemDate.Month = value.Month
                    systemDate.DayOfWeek = value.DayOfWeek
                    systemDate.Day = value.Day
                    systemDate.Hour = value.Hour
                    systemDate.Minute = value.Minute
                    systemDate.Second = value.Second
                    systemDate.MilliSeconds = value.Millisecond
                    SetLocalTime(systemDate)
                Catch ex As Exception
                    Throw ex
                End Try
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Enable() Implements ISafetracScanner.Enable
            If _objPsionScanner IsNot Nothing Then
                _objPsionScanner.Enabled = True
            End If
        End Sub
        ''' <summary>
        ''' Implements DisableScanner method of SafetracScanner interface
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Disable() Implements ISafetracScanner.Disable
            If _objPsionScanner IsNot Nothing Then
                _objPsionScanner.Enabled = False
            End If
        End Sub
        ''' <summary>
        ''' Implements PerformColdReboot method of SafetracScanner interface
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ColdReboot() Implements ISafetracScanner.ColdReboot
            If _objPsionScanner IsNot Nothing Then
                PsionTeklogix.Power.PowerManagement.ColdBoot()
            End If
        End Sub
        ''' <summary>
        ''' Implements PerformWarmReboot method of SafetracScanner interface
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub WarmReboot() Implements ISafetracScanner.WarmReboot
            If _objPsionScanner IsNot Nothing Then
                PsionTeklogix.Power.PowerManagement.WarmBoot()
            End If
        End Sub

        Public Sub SetCapsLock() Implements ISafetracScanner.SetCapsLock
            If _objPsionScanner IsNot Nothing Then
                Call PsionTeklogix.Keyboard.Keyboard.keybd_event(Convert.ToByte(Keys.CapsLock), 0, 0, 0) ' Key down
                Call PsionTeklogix.Keyboard.Keyboard.keybd_event(Convert.ToByte(Keys.CapsLock), 0, Convert.ToByte(Keys.Up), 0) ' Key Up
            End If
        End Sub


        Public Sub SetKeyEvent(ByVal keyCode As Keys) Implements ISafetracScanner.SetKeyEvent
            If _objPsionScanner IsNot Nothing Then
                Call PsionTeklogix.Keyboard.Keyboard.keybd_event(Convert.ToByte(keyCode), 0, 0, 0) ' Key down
                Call PsionTeklogix.Keyboard.Keyboard.keybd_event(Convert.ToByte(keyCode), 0, Convert.ToByte(Keys.Up), 0) ' Key Up
            End If
        End Sub

        Public ReadOnly Property Version() As Version Implements ISafetracScanner.Version
            Get
                If _objPsionScanner IsNot Nothing Then
                    Return _objPsionScanner.GetType().Assembly.GetCallingAssembly().GetName().Version
                Else
                    Return New Version(1, 0, 0, 0)
                End If
            End Get
        End Property

    End Class ' END CLASS DEFINITION Psion7535

    Public Class ScanEventArgs
        Inherits System.EventArgs
        Public ScannedValue As String

        Public Sub New(ByVal scannedText As String)
            ScannedValue = scannedText.Trim.ToUpper
        End Sub
    End Class

    <StructLayoutAttribute(LayoutKind.Sequential)> _
    Public Structure SystemTime
        Public Year As Short
        Public Month As Short
        Public DayOfWeek As Short
        Public Day As Short
        Public Hour As Short
        Public Minute As Short
        Public Second As Short
        Public MilliSeconds As Short
    End Structure

End Namespace ' Hardware