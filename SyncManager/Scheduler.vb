#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : Scheduler.Vb
'Description      : Scheduler Perform Upload,DownLoad,ForceSync,DataBaseCleanUp
'                   Syncronization of local SQLCE and master databases(Oracle) and Set the last Sync time.
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
Imports System
Imports System.Net
Imports System.Xml
Imports System.Data
Imports System.IO
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.Communication
Imports NWA.Safetrac.Scanner.WebReferences
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.SyncManager

Imports OpenNETCF.Threading
Imports System.Data.SqlServerCe
#End Region
Namespace NWA.Safetrac.Scanner.SyncManager
    ''' <summary>
    ''' To Perform Upload,DownLoad,ForceSync,DataBaseCleanUp......
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Scheduler

        Private _thrdSchedulerThread As Thread2
        Private _objSyncDataAcess As SyncDataAccess
        Private _objNetworkInterface As ConnectionManager
        Private _dsTableRecords As DataSet
        Private _objWebService As SyncServices
        Private _blnSchedulerStatus As Boolean
        Private _blnStopScehduler As Boolean
        Private _objTableParameter As TableStructure
        Private _intDurationToHoldFlightData As Integer
        Private _strSchemaRoot As String
        Private _strDownloadRequestSchemaRoot As String
        Private _strServerIPAddress As String


        ''' <summary>
        ''' Initializes the Scheduler resources
        ''' </summary>
        ''' <param name="objSyncDataAcess"></param>
        ''' <param name="objNetworkInterface"></param>
        ''' <param name="reset"></param>
        ''' <remarks></remarks>
        Public Sub StartScheduler(ByVal objSyncDataAcess As SyncDataAccess, ByVal objNetworkInterface As ConnectionManager, ByVal reset As Boolean)
            Dim blnResult As Boolean = False
            Try
                If Not reset Then
                    'Set scheduler current status to false
                    _blnSchedulerStatus = False
                    'obtain the config parameters from the config file
                    _strSchemaRoot = SyncConstants.XML_SCHEMA_ROOT
                    _strDownloadRequestSchemaRoot = SyncConstants.XML_DOWNLOAD_REQ_SCHEMA
                    _strServerIPAddress = ConfigManager.ServerIPAddress
                    _intDurationToHoldFlightData = ConfigManager.DurationToHoldFlightData
                    'Assign the Data Access object and Connection Manager initialized by the SyncManager class
                    _objSyncDataAcess = objSyncDataAcess
                    _objNetworkInterface = objNetworkInterface
                    'Initialise the Webservice object
                    _objWebService = New SyncServices
                    'Assign device ID and City Code to Webservice header
                    _objWebService.SetDeviceIDAndStationCode(ConfigManager.HHTId, ConfigManager.CityCode)
                End If
                'Initialise the Scheduler thread
                _thrdSchedulerThread = New Thread2(AddressOf InitScheduler)
                'Start the scheduler thread
                blnResult = StartSchedulerThread()
                If Not blnResult Then
                    'Log error message indicating failure to start scheduler
                    'Pending Log fatal error
                End If
                SyncManager.MessageLogging("Scheduler started successfully", LogType.Information, "StartScheduler")
            Catch threadSemaEx As OpenNETCF.Threading.SemaphoreFullException
                SyncManager.ErrorHandling(threadSemaEx)
            Catch threadWaitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                SyncManager.ErrorHandling(threadWaitEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally

            End Try

        End Sub
        ''' <summary>
        ''' Perform ForceSync
        ''' </summary>
        ''' <param name="reSet"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ForceSync(ByVal reSet As Boolean) As SyncConstants.SyncStatus
            Try
                'If thread is unstarted or stopped then restart the thread
                If _thrdSchedulerThread.State = ThreadState.Unstarted Or _thrdSchedulerThread.State = ThreadState.Stopped Then
                    _thrdSchedulerThread.Start()
                    SyncManager.MessageLogging("Attempt for Force Sync, SchedulerThread started", LogType.Information, "ForceSync")
                    Return SyncConstants.SyncStatus.Started
                    'If reSet is true the restart the thread
                ElseIf reSet = True Then
                    'If thread is already running, complete the current operation and stop the thread. Restart the thread again 
                    If _thrdSchedulerThread.State = ThreadState.Running Then
                        _blnSchedulerStatus = False
                        _blnStopScehduler = True
                        _thrdSchedulerThread.Join()
                        StartScheduler(_objSyncDataAcess, _objNetworkInterface, True)
                        'Return current status as started and stopped
                        SyncManager.MessageLogging("Attempt for Force Sync, SchedulerThread re-started forceibilly", LogType.Information, "ForceSync")
                        Return SyncConstants.SyncStatus.StoppedAndStarted
                    End If
                End If
                'Return status as running
                SyncManager.MessageLogging("Attempt for Force Sync, Scheduler already running", LogType.Information, "ForceSync")
                Return SyncConstants.SyncStatus.Running
            Catch threadSemaEx As OpenNETCF.Threading.SemaphoreFullException
                SyncManager.ErrorHandling(threadSemaEx)
            Catch threadWaitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                SyncManager.ErrorHandling(threadWaitEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' To Check is Sync Active
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsSyncActive() As SyncConstants.SyncStatus
            Try
                'Return the syncManager status
                If _blnSchedulerStatus = True Then
                    SyncManager.MessageLogging("Scheduler Status: Started", LogType.Information, "IsSyncActive")
                    Return SyncConstants.SyncStatus.Running
                ElseIf _blnSchedulerStatus = False And _blnStopScehduler = True Then
                    SyncManager.MessageLogging("Scheduler Status: Stopped", LogType.Information, "IsSyncActive")
                    Return SyncConstants.SyncStatus.Stopped
                ElseIf _blnSchedulerStatus = False And _blnStopScehduler = False Then
                    SyncManager.MessageLogging("Scheduler Status: Suspended", LogType.Information, "IsSyncActive")
                    Return SyncConstants.SyncStatus.Suspended
                End If
                Return SyncConstants.SyncStatus.Invalid
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try

        End Function
        ''' <summary>
        ''' Start the scheduler thread for Upload, Download and DB cleanup 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function StartSchedulerThread() As Boolean
            Try
                'Start scheduler thread
                _blnStopScehduler = False
                _blnSchedulerStatus = True
                _thrdSchedulerThread.Start()
                SyncManager.MessageLogging("Scheduler thread invoked", LogType.Information, "StartSchedulerThread")
            Catch semaEx As OpenNETCF.Threading.SemaphoreFullException
                SyncManager.ErrorHandling(semaEx)
            Catch waitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                SyncManager.ErrorHandling(waitEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Perform Data Base CleanUp
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function DatabaseCleanUp() As Boolean

            Dim strTableName As String
            Dim intValue As Integer
            Dim strFlightNo As String
            Dim dtmFlightDeptTime As Date
            Dim strTemp As String = Nothing
            Dim strSqlCEQuery As String
            Dim dsInActiveFlight As DataSet
            Dim lsDeletetableList As List(Of String)

            Try
                'Fetch list of tables for deleting data
                lsDeletetableList = TableStructure.DownloadTables
                SyncManager.MessageLogging("Attempt for database Clean up", LogType.Information, "DatabaseCleanUp")
                _objSyncDataAcess.ClearDataBase(lsDeletetableList)
                Return True
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
                strTableName = Nothing
                intValue = Nothing
                strFlightNo = Nothing
                dtmFlightDeptTime = Nothing
                strTemp = Nothing
                strSqlCEQuery = Nothing
                dsInActiveFlight = Nothing
                lsDeletetableList = Nothing
            End Try
        End Function
        ''' <summary>
        ''' Start the Scheduler
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub InitScheduler()
            Dim blnResultUpload, blnResultDownload, blnResultDBCleanUP As Boolean
            Dim dtmCurrentSyncTime As DateTime
            Try
                Do Until _blnStopScehduler
                    Try
                        'set system time for current sync cycle
                        dtmCurrentSyncTime = DateTime.Now
                        'Invoke Upload all
                        SyncManager.MessageLogging("Invoking data upload", LogType.Trace, "InitScheduler")
                        blnResultUpload = PerformUploadAll()
                        If blnResultUpload Then
                            'Log success update at dtmCurrentSyncTime
                            SyncManager.MessageLogging("Upload successful at: " & dtmCurrentSyncTime.ToString(), LogType.Information, "InitScheduler")
                        End If
                    Catch ex As Exception
                        SyncManager.ErrorHandling(ex)
                    End Try
                    Try
                        'set system time for current sync cycle
                        dtmCurrentSyncTime = DateTime.Now
                        'Invoke Download all
                        SyncManager.MessageLogging("Invoking data download", LogType.Trace, "InitScheduler")
                        blnResultDownload = PerformDownloadAll()
                        If blnResultDownload Then
                            SetLastSyncTime(dtmCurrentSyncTime)
                            'Log success download at dtmCurrentSyncTime
                            SyncManager.MessageLogging("Download successful at: " & dtmCurrentSyncTime.ToString(), LogType.Information, "InitScheduler")
                        End If
                    Catch ex As Exception
                        SyncManager.ErrorHandling(ex)
                    End Try

                    Try
                        'Call Database cleanup
                        If _blnSchedulerStatus = True Then
                            SyncManager.MessageLogging("Invoking data cleanup", LogType.Trace, "InitScheduler")
                            blnResultDBCleanUP = DatabaseCleanUp()
                        End If
                    Catch ex As Exception
                        SyncManager.ErrorHandling(ex)
                    End Try
                    'Sleep for a define interval, in case sync is not shutdown
                    If _blnSchedulerStatus = True Then
                        SyncManager.MessageLogging("Scheduler under sleep mode for interval of: " & SyncConstants.SCHEDULER_SLEEP_INTVAL.ToString(), LogType.Trace, "InitScheduler")
                        Thread2.Sleep(SyncConstants.SCHEDULER_SLEEP_INTVAL)
                    End If
                Loop
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try
        End Sub
        ''' <summary>
        ''' Stops the Scheduler
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function StopScheduler() As Boolean
            Dim blnResult As Boolean = False
            Try
                'Abort thread
                blnResult = StopSchedulerThread()
                'Release all the resources
                _objSyncDataAcess = Nothing
                _objNetworkInterface = Nothing
                _thrdSchedulerThread = Nothing
                _objWebService = Nothing
                If Not blnResult Then
                    'Log error
                End If
                SyncManager.MessageLogging("Scheduler stopped", LogType.Information, "StopScheduler")
            Catch threadSemaEx As OpenNETCF.Threading.SemaphoreFullException
                SyncManager.ErrorHandling(threadSemaEx)
            Catch threadWaitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                SyncManager.ErrorHandling(threadWaitEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally

            End Try
            Return True
        End Function
        ''' <summary>
        ''' Stops the Scheduler thread
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function StopSchedulerThread() As Boolean
            Try
                'set flag to stop scheduler
                _blnSchedulerStatus = False
                _blnStopScehduler = True
                SyncManager.MessageLogging("Scheduler thread waiting for join", LogType.Trace, "StopSchedulerThread")
                _thrdSchedulerThread.Join()
                'Abort the thread
                _thrdSchedulerThread.Abort()
                _blnSchedulerStatus = False
                _blnStopScehduler = False
                SyncManager.MessageLogging("Scheduler thread aborted", LogType.Trace, "StopSchedulerThread")
            Catch threadEx As Threading.ThreadAbortException
                SyncManager.ErrorHandling(threadEx)
            Catch threadSemaEx As OpenNETCF.Threading.SemaphoreFullException
                SyncManager.ErrorHandling(threadSemaEx)
            Catch threadWaitEx As OpenNETCF.Threading.WaitHandleCannotBeOpenedException
                SyncManager.ErrorHandling(threadWaitEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally

            End Try
            Return True

        End Function
        ''' <summary>
        ''' Performs upload for all the related tables
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function PerformUploadAll() As Boolean
            Dim strTableName As String
            Try
                'Assign Service ID as upload for the webservice header
                _objWebService.ServiceID = SyncConstants.OperationType.Upload
                'Loop through all tables related to Upload operation
                SyncManager.MessageLogging("Upload operation in progress", LogType.Trace, "PerformUploadAll")
                For Each strTableName In TableStructure.UploadTables
                    'Continue only if Scheduler status is not set to false else exit the loop
                    If _blnSchedulerStatus = True Then
                        SyncManager.MessageLogging("Upload operation for: " & strTableName, LogType.Trace, "PerformUploadAll")
                        PerformUpload(strTableName)
                    Else
                        SyncManager.MessageLogging("Exit from Upload operation due to shutdown attempt", LogType.Trace, "PerformUploadAll")
                        Exit For
                    End If
                Next
                Return True
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
            End Try
        End Function
        ''' <summary>
        ''' Upload table data using the webservice
        ''' </summary>
        ''' <param name="tableName">Table for which data should be uploaded</param>
        ''' <returns>True if data is uploaded</returns>
        ''' <remarks></remarks>
        Private Function PerformUpload(ByVal tableName As String) As Boolean
            Dim dtmLastSyncTime As New Date
            Dim dtmCurrentSyncTime As New Date
            'Dim strTableRecords As String = Nothing
            Dim intResponseID As Integer
            Dim strResponseLoadStatus As String
            Dim strResponseErrorCode As String
            Dim strResponseErrorMessage As String
            Dim strTableAlias As String

            Try
                'Fetch the table object
                _objTableParameter = TableStructure.TableObject(tableName)
                'Fetch last sync time for the refrence table from SqlCE
                dtmLastSyncTime = _objSyncDataAcess.FetchLastSyncTime(tableName, SyncConstants.OperationType.Upload)
                'Fetch alias name for the table for webservice
                strTableAlias = _objTableParameter.TableAlias
                '_objWebService.RequestLastSyncTime = dtmLastSyncTime
                SyncManager.MessageLogging("Checking if device is in network", LogType.Trace, "PerformUpload")
                If _objNetworkInterface.IsDeviceConnected(_strServerIPAddress) Then
                    'Set current sync operation cycle time to system time
                    dtmCurrentSyncTime = DateTime.Now
                    'Fetch Db records in dataset in XML format
                    SyncManager.MessageLogging("Fetch records for Upload operation", LogType.Trace, "PerformUpload")
                    _objWebService.MessageBody = _objSyncDataAcess.FetchRecords(tableName, dtmLastSyncTime, _strSchemaRoot, strTableAlias, _objTableParameter.SelectCommand)
                Else
                    'Log netowrk error
                    SyncManager.MessageLogging("Network exception while attempting to establish connection", LogType.Warning, "PerformUpload")
                    Return False
                End If

                'Invoke webservice only if their are recirds to be updated
                If _objWebService.MessageBody.Length > 20 Then
                    _objWebService.CommodityType = _objTableParameter.CommodityType()
                    SyncManager.MessageLogging("Attempt to invoke webservice for uploading records of: " & strTableAlias, LogType.Trace, "PerformUpload")
                    intResponseID = _objWebService.InvokeUploadWebservice()
                    If intResponseID <> -1 Then
                        'If success update the last sync time with current sync operation time
                        _objSyncDataAcess.SetSyncTime(tableName, SyncConstants.OperationType.Upload, dtmCurrentSyncTime)
                        'Log message for success                        
                        SyncManager.MessageLogging("Webservice call successful, set upload sync time to: " & dtmCurrentSyncTime.ToString() & " and load status " & _objWebService.LoadStatus.ToString(), LogType.Trace, "PerformUpload")
                    Else
                        'Log error message with webservice error
                        SyncManager.MessageLogging("Exception invoking Webservice call, error code: " & _objWebService.ErrorCode.ToString() & "Error Message: " & _objWebService.ErrorMessage.ToString(), LogType.Warning, "PerformUpload")
                    End If
                Else
                    'Pending, Log message as no record to be uploaded
                    SyncManager.MessageLogging("No records to be updated for: " & strTableAlias, LogType.Trace, "PerformUpload")
                    Return False
                End If
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
                intResponseID = Nothing
                strResponseLoadStatus = Nothing
                strResponseErrorCode = Nothing
                strResponseErrorMessage = Nothing
                strTableAlias = Nothing
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Perform download for all tables
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function PerformDownloadAll() As Boolean
            Dim strTableName As String
            Dim dsActiveFlights As DataSet
            Dim drTemp As DataRow
            Dim blnNewRequest = False
            Try
                SyncManager.MessageLogging("Download operation in progress", LogType.Trace, "PerformDownloadAll")
                'Set Service ID as download in the webservice header
                _objWebService.ServiceID = SyncConstants.OperationType.Download
                'FetchList of Active Flights
                dsActiveFlights = _objSyncDataAcess.FetchActiveFlights()
                'fetch list of tables applicable for download
                For Each strTableName In TableStructure.DownloadTables
                    'Perform untill scheduler is set to true else exit
                    If _blnSchedulerStatus = True Then
                        SyncManager.MessageLogging("Download operation for: " & strTableName, LogType.Trace, "PerformDownloadAll")
                        PerformDownload(strTableName, dsActiveFlights)
                    Else
                        SyncManager.MessageLogging("Exit the Download operation due to shutdown attempt", LogType.Information, "PerformDownloadAll")
                        Exit For
                    End If
                Next
                If dsActiveFlights IsNot Nothing And _blnSchedulerStatus = True Then
                    For Each drTemp In dsActiveFlights.Tables(0).Rows
                        If drTemp("IS_NEW_REQUEST") = "Y" Then
                            drTemp("IS_NEW_REQUEST") = "N"
                            blnNewRequest = True
                        End If
                    Next
                    If blnNewRequest Then
                        SyncManager.MessageLogging("Update new request to false after initial download operation", LogType.Trace, "PerformDownloadAll")
                        _objSyncDataAcess.UpdateNewRequest(dsActiveFlights)
                    End If
                End If
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
                strTableName = Nothing
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Perform download for specific table
        ''' </summary>
        ''' <param name="tableName">Table name</param>
        ''' <returns>True if the download operation sucsseds for that table else false</returns>
        ''' <remarks></remarks>
        Private Function PerformDownload(ByVal tableName As String, ByVal activeFlights As DataSet) As Boolean

            Dim dtmLastDownloadSyncTime As New Date
            Dim dtmCurrentDownloadSyncTime As New Date
            Dim dsServerRecords As DataSet
            Dim memoryStream As MemoryStream
            Dim intResponseID As Int16
            Dim strResponseLoadStatus As String
            Dim strResponseErrorCode As String
            Dim strResponseErrorMessage As String
            Dim strReader As StringReader
            Dim drTemp As DataRow
            Try
                'Fetch table object for the defined table
                _objTableParameter = TableStructure.TableObject(tableName)
                'Fetch last sync time
                dtmLastDownloadSyncTime = _objSyncDataAcess.FetchLastSyncTime(tableName, SyncConstants.OperationType.Download)
                'Update Airline code or Error code table only 24 hours once
                If tableName = DBTables.AirlineCode Or tableName = DBTables.ErrorCode Then
                    Dim timeSpan As TimeSpan
                    timeSpan = DateTime.Now - dtmLastDownloadSyncTime
                    If timeSpan.TotalHours < 24 Then
                        Return True
                    Else
                        SyncManager.MessageLogging("Downloading data for: " & tableName, LogType.Trace, "PerformDownload")
                    End If
                End If

                If tableName <> DBTables.LineItem Then
                    'Generate the download request schema, requesting for multiple flights
                    'Set request schema to webservice body
                    SyncManager.MessageLogging("Fetch Download request schema", LogType.Trace, "PerformDownload")
                    _objWebService.MessageBody = GetDownloadRequestSchema(tableName, _objTableParameter.TableAlias, activeFlights)
                    'Fetch commodity type
                    _objWebService.CommodityType = _objTableParameter.CommodityType
                    'Set system time as current sync operation time
                    dtmCurrentDownloadSyncTime = DateTime.Now
                    'Invoke Webservice here
                    SyncManager.MessageLogging("Invoking Download webservice for: " & tableName, LogType.Trace, "PerformDownload")
                    intResponseID = _objWebService.InvokeDownloadWebservice()
                Else
                    For Each drTemp In activeFlights.Tables(0).Rows
                        intResponseID = _objWebService.InvokeDownloadLineItems(drTemp("OP_AL_CDE"), drTemp("FLT_NUM"), drTemp("FLT_SCHED_DTM").ToString())
                        dsServerRecords = New DataSet("READDDSGLINEITEMS")
                        dsServerRecords.ReadXml(_objWebService.MessageBody)
                    Next

                End If
                'If success
                If intResponseID <> -1 Then
                    SyncManager.MessageLogging("Download webservice successful", LogType.Trace, "PerformDownload")
                    'Assign the records obtained by the webservice response
                    'Create a new data set for storing server records
                    dsServerRecords = New DataSet(_strSchemaRoot)
                    'load dataset with xml schema
                    dsServerRecords.ReadXmlSchema(_objTableParameter.Schema)
                    'Initalise the memory with webservice response
                    strReader = New StringReader(_objWebService.MessageBody)
                    'read webservice response in dataset
                    SyncManager.MessageLogging("Store server records from xml format in cache", LogType.Trace, "PerformDownload")
                    dsServerRecords.ReadXml(strReader)

                    If _objTableParameter.IsScanApplicable Then
                        'If data to be updated considering position fields, i.e. tables related to the position and scan
                        PerformConstraintUpdate(tableName, dsServerRecords, dtmLastDownloadSyncTime)
                        'If success update the last sync time with current sync operation time
                        SyncManager.MessageLogging("Update the last sync time as: " & dtmLastDownloadSyncTime.ToString(), LogType.Trace, "PerformDownload")
                        _objSyncDataAcess.SetSyncTime(tableName, SyncConstants.OperationType.Download, dtmCurrentDownloadSyncTime)
                    Else
                        'Tables which can be updated directly
                        UpdateDBTable(tableName, dsServerRecords, dtmLastDownloadSyncTime, "SELECT * FROM " & tableName)
                        'If success update the last sync time with current sync operation time
                        SyncManager.MessageLogging("Update the last sync time as: " & dtmLastDownloadSyncTime.ToString(), LogType.Trace, "PerformDownload")
                        _objSyncDataAcess.SetSyncTime(tableName, SyncConstants.OperationType.Download, dtmCurrentDownloadSyncTime)
                    End If
                    'If error from webservice
                Else
                    SyncManager.MessageLogging("Exception invoking Webservice call, error code: " & _objWebService.ErrorCode.ToString() & "Error Message: " & _objWebService.ErrorMessage.ToString(), LogType.Warning, "PerformUpload")
                End If
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
                dsServerRecords = Nothing
                memoryStream = Nothing
                intResponseID = Nothing
                strResponseLoadStatus = Nothing
                strResponseErrorCode = Nothing
                strResponseErrorMessage = Nothing
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Set last Sync time
        ''' </summary>
        ''' <param name="currentSyncTime"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function SetLastSyncTime(ByVal currentSyncTime As DateTime) As Boolean
            Try
                'Set last successful syncronization cycle time
                SyncManager.MessageLogging("Set the Last Sync time as: " & currentSyncTime.ToString(), LogType.Trace, "SetLastSyncTime")
                SyncManager.LastSyncTime = currentSyncTime
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try
            Return True
        End Function
        ''' <summary>
        ''' Builds the Schema to request download information to the webservices
        ''' </summary>
        ''' <param name="tableName"></param>
        ''' <param name="tableAlias"></param>
        ''' <param name="activeFlights"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetDownloadRequestSchema(ByVal tableName As String, ByVal tableAlias As String, ByVal activeFlights As DataSet) As String
            Dim strXmlBodyRoot As String
            Dim strXmlDownloadBodyRoot As String
            Dim strSchema As New Text.StringBuilder
            Dim strResposne As String = Nothing
            Dim strRequestSchema As String
            Dim dtmLastSyncTime As DateTime
            Dim dsTempDataSet As DataSet
            Dim drTemp As DataRow
            Dim memoryStream As New MemoryStream()
            Dim xmlTextWriter As New XmlTextWriter(memoryStream, Text.Encoding.UTF8)
            Dim streamReader As New StreamReader(memoryStream)
            Try
                xmlTextWriter.Formatting = Formatting.Indented
                xmlTextWriter.WriteStartElement("", SyncConstants.XML_SCHEMA_ROOT, "")
                xmlTextWriter.WriteStartElement("", SyncConstants.XML_DOWNLOAD_REQ_SCHEMA, "")
                If Not activeFlights Is Nothing Then
                    dsTempDataSet = activeFlights.Copy()
                    dtmLastSyncTime = _objSyncDataAcess.FetchLastSyncTime(tableName, SyncConstants.OperationType.Download)
                    dsTempDataSet.Tables(0).Columns.Remove("OP_AL_CDE")
                    dsTempDataSet.Tables(0).Columns.Add("LASTSYNCTIME")
                    dsTempDataSet.Tables(0).Columns.Add("DEPARTURESTATIONCODE")
                    For Each drTemp In dsTempDataSet.Tables(0).Rows
                        drTemp("LASTSYNCTIME") = dtmLastSyncTime.ToString("yyyy-MM-dd HH:mm:ss")
                        drTemp("DEPARTURESTATIONCODE") = ConfigManager.CityCode
                    Next
                End If
                '''''
                If dsTempDataSet IsNot Nothing Then
                    dsTempDataSet.DataSetName = SyncConstants.XML_DOWNLOAD_REQ_SCHEMA
                    dsTempDataSet.Tables(0).TableName = "Flight"
                    strResposne = dsTempDataSet.GetXml()
                    strResposne = strResposne.Replace("<" & SyncConstants.XML_DOWNLOAD_REQ_SCHEMA & ">", "")
                    strResposne = strResposne.Replace("</" & SyncConstants.XML_DOWNLOAD_REQ_SCHEMA & ">", "")
                End If
                If strResposne IsNot Nothing Then
                    xmlTextWriter.WriteRaw(strResposne)
                Else
                    xmlTextWriter.WriteStartElement("", "Flight", "")
                    xmlTextWriter.WriteEndElement()
                End If
                xmlTextWriter.WriteStartElement("", "FlightCount", "")
                'xmlTextWriter.WriteString(dsTempDataSet.Tables(0).Rows.Count.ToString)
                xmlTextWriter.WriteString("3")
                xmlTextWriter.WriteEndElement()
                xmlTextWriter.WriteEndElement()
                xmlTextWriter.WriteEndElement()
                xmlTextWriter.Flush()
                memoryStream.Position = 0
                strRequestSchema = streamReader.ReadToEnd()
                SyncManager.MessageLogging("Requesting for the XML Schema", LogType.Trace, "GetDownloadRequestSchema")
                Return strRequestSchema
            Catch ex As Exception
                Return Nothing
            Finally
                strXmlBodyRoot = Nothing
                strXmlDownloadBodyRoot = Nothing
                strSchema = Nothing
                strResposne = Nothing
                strRequestSchema = Nothing
                dsTempDataSet = Nothing
                drTemp = Nothing
                memoryStream = Nothing
                xmlTextWriter = Nothing
                streamReader = Nothing
            End Try
        End Function
        ''' <summary>
        ''' Depending on last Sync Time Perform Update
        ''' </summary>
        ''' <param name="tableName"></param>
        ''' <param name="serverRecords"></param>
        ''' <param name="lastSyncTime"></param>
        ''' <param name="sqlquery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function PerformConstraintUpdate(ByVal tableName As String, ByVal serverRecords As DataSet, ByVal lastSyncTime As DateTime)
            Dim objTableStructure As TableStructure
            Dim dsTemp As DataSet
            Dim strTempSqlQuery As String
            Try
                'store records in temp table
                objTableStructure = TableStructure.TableObject(tableName)
                UpdateDBTable("temp" & tableName, serverRecords, lastSyncTime, "SELECT * FROM temp" & tableName)
                SyncManager.MessageLogging("Update records to Temp" & tableName, LogType.Trace, "PerformConstraintUpdate")

                'fetch query for inserting new records
                strTempSqlQuery = objTableStructure.InsertNewRecordBlindUpdate
                'fetch new records from temp table
                dsTemp = _objSyncDataAcess.FetchRecordsDS("temp" & tableName, New DateTime, strTempSqlQuery)
                'Update new records to master table of sqlce
                If dsTemp IsNot Nothing And dsTemp.Tables(0).Rows.Count > 0 Then
                    'insert new records
                    UpdateDBTable(tableName, dsTemp, lastSyncTime, "SELECT * FROM " & tableName)
                    'delete inserted records from temp table
                    strTempSqlQuery = objTableStructure.DeleteNewRecordBlindUpdate
                    _objSyncDataAcess.ExecuteNonQuery(strTempSqlQuery)
                    SyncManager.MessageLogging("Insert new records to table: " & tableName, LogType.Trace, "PerformConstraintUpdate")
                End If
                'fetch query for inserting newer or modified server records without the position fields
                strTempSqlQuery = objTableStructure.InsertOnlyNewerServerRecords
                'fetch newer or modified server records from temp table without the position fields
                dsTemp = _objSyncDataAcess.FetchRecordsDS("temp" & tableName, New DateTime, strTempSqlQuery)
                Try

                    If dsTemp IsNot Nothing And dsTemp.Tables(0).Rows.Count > 0 Then
                        'insert newer server records without updating the position fields
                        _objSyncDataAcess.UpdateDB(tableName, objTableStructure.SelectNonOverridingFields, strTempSqlQuery)
                        'delete newer server records without updating the position fields
                        strTempSqlQuery = objTableStructure.DeleteOnlyNewerServerRecords
                        _objSyncDataAcess.ExecuteNonQuery(strTempSqlQuery)
                        SyncManager.MessageLogging("Update records modified by server to table: " & tableName, LogType.Trace, "PerformConstraintUpdate")
                    End If
                Catch ex As Exception

                End Try
                'fetch query for records that can be skipped
                strTempSqlQuery = objTableStructure.SkipRecords
                'delete records from temp table which can be skipped 
                _objSyncDataAcess.ExecuteNonQuery(strTempSqlQuery)

                '''''Pending - Special Case for the Bag Alert to be added

                'fetch query for remaining records from tempTable
                strTempSqlQuery = objTableStructure.SelectTempRecords
                dsTemp = _objSyncDataAcess.FetchRecordsDS("temp" & tableName, New DateTime, strTempSqlQuery)
                'dsTemp = _objSyncDataAcess.ExecuteStatement(strTempSqlQuery)
                If dsTemp IsNot Nothing And dsTemp.Tables(0).Rows.Count > 0 Then
                    'insert remaning records to sql ce
                    UpdateDBTable(tableName, dsTemp, lastSyncTime, "SELECT * FROM " & tableName)
                    SyncManager.MessageLogging("Insert temp table records to table: " & tableName, LogType.Trace, "PerformConstraintUpdate")
                End If
                'delete records from the temp table
                strTempSqlQuery = objTableStructure.DeleteTempRecords
                _objSyncDataAcess.ExecuteNonQuery(strTempSqlQuery)
                SyncManager.MessageLogging("Delete records from Temp" & tableName, LogType.Trace, "PerformConstraintUpdate")
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            End Try
            objTableStructure = Nothing
            dsTemp = Nothing
            strTempSqlQuery = Nothing
        End Function
        ''' <summary>
        ''' Update DB Table
        ''' </summary>
        ''' <param name="tableName"></param>
        ''' <param name="serverRecords"></param>
        ''' <param name="lastsyncTime"></param>
        ''' <param name="sqlceQuery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function UpdateDBTable(ByVal tableName As String, ByVal serverRecords As DataSet, ByVal lastsyncTime As DateTime, ByVal sqlceQuery As String)
            Dim dsClientRecords As DataSet
            Try
                dsClientRecords = _objSyncDataAcess.FetchRecordsDS(tableName, lastsyncTime, sqlceQuery)
                dsClientRecords.DataSetName = SyncConstants.XML_SCHEMA_ROOT
                dsClientRecords.Tables(0).TableName = _objTableParameter.TableAlias
                dsClientRecords.EnforceConstraints = True
                serverRecords.DataSetName = SyncConstants.XML_SCHEMA_ROOT
                serverRecords.Tables(0).TableName = _objTableParameter.TableAlias
                dsClientRecords.Merge(serverRecords, False, MissingSchemaAction.AddWithKey)
                SyncManager.MessageLogging("Merge records for table " & tableName, LogType.Trace, "UpdateDBTable")
                _objSyncDataAcess.UpdateRecord(tableName, dsClientRecords, sqlceQuery)
                SyncManager.MessageLogging("Update record to table " & tableName, LogType.Trace, "UpdateDBTable")
            Catch sqlCeEx As SqlCeException
                SyncManager.ErrorHandling(sqlCeEx)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
                dsClientRecords = Nothing
            End Try
        End Function
        ''' <summary>
        ''' List of tables to be deleted
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property TablesToBeDeleted() As List(Of String)
            Get
                Dim lsDeleteTable As List(Of String)
                Try
                    lsDeleteTable = TableStructure.DownloadTables
                    Return lsDeleteTable
                Catch ex As Exception
                    SyncManager.ErrorHandling(ex)
                    Return Nothing
                End Try
            End Get
        End Property
    End Class
End Namespace