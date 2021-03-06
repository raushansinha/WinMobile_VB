#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : SyncManager.Vb
'Description      : SyncManager Initializes Database connection and the Scheduler ,
'                   Determines if the device is currently connected to network,
'                   Checks device on Cradle,Etc..
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

#Region "NAMESPACES"
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.BO
Imports System.Data.SqlServerCe
#End Region
Namespace NWA.Safetrac.Scanner.SyncManager

    ''' <summary>
    ''' Initializes the Database connection and the scheduler
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SyncManager

        Private Shared _dtmLastSyncTime As DateTime
        Private Shared _bytIsSyncActive As Byte
        Private Shared _blnIsDeviceConnected As Boolean
        Private _dtmCurrentSyncTime As Date
        Private _blnIsCradled As Boolean
        Private _objConectionManager As ConnectionManager
        Private _objDBAccess As SyncDataAccess
        Private _objScheduler As Scheduler
        Private Shared _objSyncManager As SyncManager

        ''' <summary>
        ''' Get the time when SyncManager completed the last successful itieration 
        ''' </summary>
        ''' <value></value>
        ''' <returns>DateTime object</returns>
        ''' <remarks></remarks>
        Public Shared Property LastSyncTime() As DateTime
            Get
                Return _dtmLastSyncTime
            End Get
            Set(ByVal value As DateTime)
                _dtmLastSyncTime = value
            End Set
        End Property
        ''' <summary>
        ''' Determines if the SyncManager scheduler is currently active and if so what operation 
        ''' is being currently performed 
        ''' </summary>
        ''' <value></value>
        ''' <returns>0 for no operation, 1 for Upload and 2 for Downlaod</returns>
        ''' <remarks></remarks>
        Public Shared Property IsSyncActive() As Byte
            Get
                Return _bytIsSyncActive
            End Get
            Set(ByVal value As Byte)
                _bytIsSyncActive = value
            End Set
        End Property
        ''' <summary>
        ''' Initializes the SyncManager
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function InitSyncManager() As Boolean
            Dim blnResult As Boolean = False
            Try
                'Assign the Data Access object and Connection Manager initialized by the SyncManager class
                _objDBAccess = New SyncDataAccess
                _objScheduler = New Scheduler
                _objConectionManager = New ConnectionManager
                'Initiate the Data Base Connection,If it is Connected Returns True Else False.
                blnResult = InitDBConnection()
                If blnResult Then
                    'Initiate the Scheduler 
                    blnResult = InitSyncScheduler(_objDBAccess, _objConectionManager)
                Else
                    SyncManager.MessageLogging("Initiating the scheduler", LogType.Information, "InitSyncManager")
                    Return blnResult
                End If
                SyncManager.MessageLogging("Initiating the scheduler", LogType.Information, "InitSyncManager")
                Return blnResult
            Catch sqlCeEx As SqlCeException
                ErrorHandling(sqlCeEx)
            Catch ex As Exception
                ErrorHandling(ex)
            Finally

            End Try

        End Function
        ''' <summary>
        ''' Returns the singleton instance of the Sync Manager
        ''' </summary>
        ''' <returns>SyncManager instance</returns>
        ''' <remarks>Sync Manager is a singleton class</remarks>
        Public Shared Function GetSyncInstance() As SyncManager
            Try
                If _objSyncManager Is Nothing Then
                    _objSyncManager = New SyncManager
                End If
                SyncManager.MessageLogging("Returning an instance of SyncManager", LogType.Information, "GetSyncInstance")
                Return _objSyncManager
            Catch ex As Exception
                ErrorHandling(ex)
                Return Nothing
            Finally
            End Try
        End Function
        ''' <summary>
        ''' This method invokes the exception handling and the logging
        ''' </summary>
        ''' <param name="ex">Response ID which determines the type of the error</param>
        ''' <returns>returns true if the excpetion was handled else returns false</returns>
        ''' <remarks>Common method across SyncManager to handle excpetions</remarks>
        Public Shared Function ErrorHandling(ByVal ex As Exception) As Boolean
            'logger.LogMessage() 
            Logger.LogException(ex)
            Return Nothing
        End Function
        ''' <summary>
        ''' This method logs messages to the log file
        ''' </summary>
        ''' <param name="message"></param>
        ''' <param name="logType"></param>
        ''' <param name="source"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function MessageLogging(ByVal message As String, ByVal logType As Utils.LogType, ByVal source As String) As Boolean
            Logger.LogMessage(message, logType, source)
            Return Nothing
        End Function
        ''' <summary>
        ''' This method stops the SyncManager and releases all the resources hold by the class
        ''' </summary>
        ''' <returns>Returns true if SyncManager is stopped successfully</returns>
        ''' <remarks></remarks>
        Public Function ShutdownSyncManager() As Boolean
            Try
                _objScheduler.StopScheduler()
                _objDBAccess.CloseConnection()
                SyncManager.MessageLogging("Connection to SyncManager is closed", LogType.Information, "ShutdownSyncManager")
                Return True

            Catch sqlCeEx As SqlCeException
                ErrorHandling(sqlCeEx)
            Catch ex As Exception
                ErrorHandling(ex)
                Return False
            Finally
            End Try
        End Function
        ''' <summary>
        ''' Perform ForceSync
        ''' </summary>
        ''' <param name="reset"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ForceSync(ByVal reset As Boolean) As Boolean
            Dim result As Boolean
            Try
                'Initiate the ForceSync Method
                result = _objScheduler.ForceSync(reset)
                SyncManager.MessageLogging("intiating ForceSync", LogType.Information, "ForceSync")
            Catch threadSemaEx As OpenNETCF.Threading.SemaphoreFullException
                ErrorHandling(threadSemaEx)
            Catch threadWaitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                ErrorHandling(threadWaitEx)
            Catch ex As Exception
                ErrorHandling(ex)
            Finally

            End Try
            Return result
        End Function
        ''' <summary>
        ''' Checks if the Upload is completed
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsUploadSyncCompleted() As Boolean
            Dim result As Boolean
            result = _objDBAccess.IsSyncUploadCompleted()
            SyncManager.MessageLogging("checking if updateSync is completed", LogType.Information, "IsUploadSyncCompleted")
            Return result
        End Function
        ''' <summary>
        ''' Checks if the Upload is completed for a specific flight
        ''' </summary>
        ''' <param name="flightNum"></param>
        ''' <param name="fltSchdTime"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsUploadSyncCompleted(ByVal flightNum As String, ByVal fltSchdTime As NWADateTime) As Boolean
            Dim result As Boolean
            result = _objDBAccess.IsSyncUploadCompleted(flightNum, fltSchdTime)
            SyncManager.MessageLogging("Checking if Sync is updated", LogType.Information, "IsUploadSyncCompleted")
            Return result
        End Function
        Public Function ListOfTablesToBeDeleted() As List(Of String)
            Try
                Return _objScheduler.TablesToBeDeleted
            Catch ex As Exception
                ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' Initializes the Scheduler
        ''' </summary>
        ''' <param name="DBAccess">Database object for connecting to databse</param>
        ''' <param name="NetworkInterface">NetworkInterface object for establishing connection to Network</param>
        ''' <returns>True if the scheduler is initialised succesfully</returns>
        ''' <remarks></remarks>
        Private Function InitSyncScheduler(ByVal dBAccess As SyncDataAccess, ByVal networkInterface As ConnectionManager) As Boolean
            Try
                If dBAccess IsNot Nothing AndAlso networkInterface IsNot Nothing Then
                    _objScheduler.StartScheduler(dBAccess, networkInterface, False)
                    SyncManager.MessageLogging("Scheduler is initialised successfully", LogType.Information, "InitSyncScheduler")
                    Return True
                Else
                    'Log this as error
                    SyncManager.MessageLogging("Scheduler was not initialised", LogType.Information, "InitSyncScheduler")
                    Return False
                End If
            Catch sqlCeEx As SqlCeException
                ErrorHandling(sqlCeEx)
            Catch Ex As Exception
                ErrorHandling(Ex)
            Finally
            End Try
        End Function
        ''' <summary>
        ''' Initializes the Database parameters and the connection
        ''' </summary>
        ''' <returns>True if connection is established sussefully</returns>
        ''' <remarks></remarks>
        Private Function InitDBConnection() As Boolean
            Try
                'Initialize the Connection.
                _objDBAccess.InitConnection()
                SyncManager.MessageLogging("connection is estamblished successfully", LogType.Information, "InitDBConnection")
                Return True
            Catch sqlCeEx As SqlCeException
                ErrorHandling(sqlCeEx)
            Catch Ex As Exception
                ErrorHandling(Ex)
            Finally
            End Try
        End Function

    End Class

End Namespace