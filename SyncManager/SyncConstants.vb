#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : SyncConstants.Vb
'Description      : In SyncConstants we are Declaring the Constant values.
'Author           : 
'Created Date     : 
'Copyright Desc   : 
'******************************************************************
' Copyright (C) 2007 NORTHWEST AIRLINES COPYRIGHT - All Rights Reserved. 
' 
' This file embodies  materials and concepts which are confidential 
' and proprietary to NORTHWEST AIRLINES COPYRIGHT, and is made available solely pursuant 
' to the terms of a written agreement with NORTHWEST AIRLINES COPYRIGHT. 
'****************************************************************** 

'Reviewed By       :
'Reviewed Date     :
'The following section would repeat for each bug / feature that needs to be fixed during post implementation / product maintenance
#Region "MODIFICATION HISTORY"
'Feature / Bug No  :  
'Modified By       :  
'Modified Date     :
'Modified Desc     : 
'Reviewed By       :  
'Reviewed Date     :
#End Region

#End Region

Imports System.Xml
Namespace NWA.Safetrac.Scanner.SyncManager
    Public Class SyncConstants
        ''' <summary>
        ''' Indicates type of operation being performed by SyncManager
        ''' </summary>
        ''' <remarks></remarks>
        Enum OperationType
            ''' <summary>
            ''' Indicates SyncManager is in sleep mode
            ''' </summary>
            ''' <remarks></remarks>
            NoOperation = 0
            ''' <summary>
            ''' Indicates SyncManager is performing Upload
            ''' </summary>
            ''' <remarks></remarks>
            Upload = 1
            ''' <summary>
            ''' Indicates SyncManager is performing Download
            ''' </summary>
            ''' <remarks></remarks>
            Download = 2
        End Enum
        Enum SyncStatus
            ''' <summary>
            ''' Mail is for commodity mail type and for the T_Mail table
            ''' </summary>
            ''' <remarks></remarks>
            Started = 0
            ''' <summary>
            ''' Freight indicates commodity Freight type and for the T_Freight table
            ''' </summary>
            ''' <remarks></remarks>
            StoppedAndStarted = 1
            ''' <summary>
            ''' Flight for the T_Flight_Info table
            ''' </summary>
            ''' <remarks></remarks>
            Running = 2
            ''' <summary>
            ''' Flight for the T_Flight_Info table
            ''' </summary>
            ''' <remarks></remarks>
            Suspended = 3
            ''' <summary>
            ''' Flight for the T_Flight_Info table
            ''' </summary>
            ''' <remarks></remarks>
            Stopped = 4
            ''' <summary>
            ''' Flight for the T_Flight_Info table
            ''' </summary>
            ''' <remarks></remarks>
            Invalid = 4
            ' This is an indicative list, shall change based on further development activities
        End Enum
        ''' <summary>
        ''' Scheduler thread sleep interval
        ''' </summary>
        ''' <remarks></remarks>
        Public Const SCHEDULER_SLEEP_INTVAL As Integer = 5000
        ''' <summary>
        ''' XML schema root element
        ''' </summary>
        ''' <remarks></remarks>
        Public Const XML_SCHEMA_ROOT As String = "SafetracSOAPBody"
        ''' <summary>
        ''' XML download request schema root
        ''' </summary>
        ''' <remarks></remarks>
        Public Const XML_DOWNLOAD_REQ_SCHEMA = "DownloadReq"
        ''' <summary>
        ''' Data Source
        ''' </summary>
        ''' <remarks></remarks>
        Public Const DATA_SOURCE = "Data Source="
        ''' <summary>
        ''' Date Formate
        ''' </summary>
        ''' <remarks></remarks>
        Public Const DATE_FORMAT = "yyyy-MM-dd HH:mm:ss"
    End Class
End Namespace
