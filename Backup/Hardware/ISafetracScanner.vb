Imports System.Windows.Forms

Namespace NWA.Safetrac.Scanner.Hardware

    ''' <summary>
    ''' Defines the method signatures that need to be implemented by any generic Safetrac Scanner
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ISafetracScanner
        ''' <summary>
        ''' Returns scanner status
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property IsScannerEnabled() As Boolean
        ''' <summary>
        ''' Set back light time for the scanner
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property BacklightTime() As Double
        ''' <summary>
        ''' To return the battery level
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property BatteryLevel() As Integer
        ''' <summary>
        ''' Get the current RF Signal level
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property RFSignalLevel() As Integer
        ''' <summary>
        '''Set scanner Date/Time
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Property DateTime() As Date
        ''' <summary>
        ''' Enable the scanning
        ''' </summary>
        ''' <remarks></remarks>
        Sub Enable()
        ''' <summary>
        ''' Disable the scanning
        ''' </summary>
        ''' <remarks></remarks>
        Sub Disable()
        ''' <summary>
        ''' To perform cold boot of the device
        ''' </summary>
        ''' <remarks></remarks>
        Sub ColdReboot()
        ''' <summary>
        ''' To perform warm boot of the device
        ''' </summary>
        ''' <remarks></remarks>
        Sub WarmReboot()
        ''' <summary>
        ''' Set key event
        ''' </summary>
        ''' <param name="KeCode"></param>
        ''' <remarks></remarks>
        Sub SetKeyEvent(ByVal KeCode As Keys)
        ''' <summary>
        ''' Set Caps Lock
        ''' </summary>
        ''' <remarks></remarks>
        Sub SetCapsLock()

        ReadOnly Property Version() As Version


    End Interface ' END INTERFACE DEFINITION SafetracScanner

End Namespace ' Hardware

