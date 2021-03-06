#Region "NORTHWEST AIRLINES COPYRIGHT"
'File Name        : SyncDataAccess.Vb
'Description      : Performs all database related operations Such as Inserting new records,
'                   Updating Existing Records,Deleting Records,Open and Close the DB Connection.....
'                   
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
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports NWA.Safetrac.Scanner.DataAccess
Imports NWA.Safetrac.Scanner.Utils
#End Region
Namespace NWA.Safetrac.Scanner.SyncManager

    ''' <summary>
    ''' Performs all database related operations of SyncManager
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SyncDataAccess
        Private _strTableName As String
        Private _dsTableRecords As DataSet
        Private _intErrorID As Integer
        Private _strErrorCode As String
        Private _conSqlCE As SqlCeConnection
        Private _strDBURL As String
        Private _objTableParameter As TableStructure
        ''' <summary>
        ''' Initializes the Database connection
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function InitConnection() As Boolean
            Try
                'Get SQLCE DB path from Config Manager
                _strDBURL = ConfigManager.SqlceURL
                'Connection Command To Open the Database
                _conSqlCE = New SqlCeConnection(SyncConstants.DATA_SOURCE & _strDBURL)
                'Call this method to initialize table parameters
                InitTableParameters()
                SyncManager.MessageLogging("Table parameters inialized based on resource file", LogType.Trace, "InitConnection")
                Return True
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
            End Try
        End Function
        ''' <summary>
        ''' Closes connection between syncmanager and the database
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CloseConnection() As Boolean
            Try
                'Closing the Connection
                SyncManager.MessageLogging("Closing database connection", LogType.Trace, "CloseConnection")
                _conSqlCE.Close()
                'Disposing the Connection object
                _conSqlCE.Dispose()
                Return True
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return False
            Finally
            End Try

        End Function
        ''' <summary>
        ''' Update Records to DB
        ''' </summary>
        ''' <param name="tableName"></param>
        ''' <param name="dataSet"></param>
        ''' <param name="sqlceQuery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateRecord(ByVal tableName As String, ByVal dataSet As DataSet, ByVal sqlceQuery As String) As String

            SqlCeHelper.UpdateTable(SyncConstants.DATA_SOURCE & _strDBURL, tableName, dataSet, sqlceQuery)
            SyncManager.MessageLogging("Records being updated to: " & tableName, LogType.Information, "UpdateRecord")
            Return Nothing
        End Function
        ''' <summary>
        ''' Fetches records from the SqlCE based on the tablename and last sync time
        ''' </summary>
        ''' <param name="tableName">name of the table for which data needs to be fetched</param>
        ''' <param name="lastSyncTime">Time from when the data needs to be pulled from the database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FetchRecords(ByVal tableName As String, ByVal lastSyncTime As Date, ByVal xmlBodyRoot As String, ByVal TableAlias As String, ByVal sqlceQuery As String) As String
            Try
                Dim dtmTemp As New DateTime
                If dtmTemp.Equals(lastSyncTime) Then
                    SyncManager.MessageLogging("Fetching records in xml format", LogType.Trace, "FetchRecords")
                    Return (SqlCeHelper.ExecuteXml(_conSqlCE, CommandType.Text, sqlceQuery, xmlBodyRoot, TableAlias))
                Else
                    SyncManager.MessageLogging("Fetching records in xml format", LogType.Trace, "FetchRecords")
                    Return (SqlCeHelper.ExecuteXml(_conSqlCE, CommandType.Text, sqlceQuery & " where SCANNED_TIME >='" & Format(lastSyncTime, "yyyy-MM-dd HH:mm:ss") & "'", xmlBodyRoot, TableAlias))
                End If
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' Fetches records from the SqlCE based on the tablename and last sync time
        ''' </summary>
        ''' <param name="tableName">name of the table for which data needs to be fetched</param>
        ''' <param name="lastSyncTime">Time from when the data needs to be pulled from the database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FetchRecordsDS(ByVal tableName As String, ByVal lastSyncTime As Date, ByVal sqlceQuery As String) As DataSet
            Dim dtmDateTime As New DateTime
            Dim dsRecords As DataSet
            Try
                If lastSyncTime = dtmDateTime Or tableName = "T_Aircraft_Config" Or tableName = "T_Passenger_Config" Then
                    dsRecords = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, sqlceQuery)
                Else
                    dsRecords = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, sqlceQuery & " where MODIFIED_TIME <='" & Format(lastSyncTime, "yyyy-MM-dd HH:mm:ss") & "'")
                End If
                SyncManager.MessageLogging("Fetching records in dataset", LogType.Trace, "FetchRecordsDS")
                Return dsRecords
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' Updates the SqlCE table with last sync time to the new SyncTime as per the previous 
        ''' sucessful itieration of SyncManager
        ''' </summary>
        ''' <param name="tableName">Table whose last sync time needs to be updated</param>
        ''' <param name="operationType">operation type to indicate Upload or Download</param>
        ''' <param name="CurrentSyncTime">Current sync time that shall be replaced by the last sync time</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SetSyncTime(ByVal tableName As String, ByVal operationType As String, ByVal currentSyncTime As DateTime) As Boolean
            Try
                Select Case (operationType)
                    Case 1
                        SyncManager.MessageLogging("", LogType.Information, "SetSyncTime")
                        Return (SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, "UPDATE T_Sync_Time SET SYNC_UPLOAD_TIME = '" & Format(currentSyncTime, "yyyy-MM-dd HH:mm:ss") & "' WHERE TABLE_NAME ='" & tableName & "'"))
                    Case 2
                        SyncManager.MessageLogging("", LogType.Information, "SetSyncTime")
                        Return (SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, "UPDATE T_Sync_Time SET SYNC_DOWNLOAD_TIME = '" & Format(currentSyncTime, "yyyy-MM-dd HH:mm:ss") & "' WHERE TABLE_NAME ='" & tableName & "'"))
                    Case Else
                        Return False
                        SyncManager.MessageLogging("Setting sync time for: " & tableName, LogType.Information, "SetSyncTime")
                End Select
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try

        End Function
        ''' <summary>
        ''' Clear the DB
        ''' </summary>
        ''' <param name="lsDeletetableList"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ClearDataBase(ByVal lsDeletetableList As List(Of String)) As Boolean
            Dim strTableName As String
            Dim intValue As Integer
            Dim strFlightNo As String
            Dim dtmFlightDeptTime As Date
            Dim strCondition As String = Nothing
            Dim strSqlCEQuery As String = Nothing
            Dim dsInActiveFlight As DataSet
            Try
                dsInActiveFlight = FetchInactiveFlights(ConfigManager.DurationToHoldFlightData)
                'Generate the query for deleting data for multiple flights
                For intValue = 0 To dsInActiveFlight.Tables(0).Rows.Count - 1
                    strFlightNo = dsInActiveFlight.Tables(0).Rows(intValue)(0)
                    dtmFlightDeptTime = dsInActiveFlight.Tables(0).Rows(intValue)(1)
                    If strCondition Is Nothing Then
                        strCondition = "(OP_FLT_NUM ='" + strFlightNo + "' AND FLT_SCHED_DTM ='" + dtmFlightDeptTime + "')"
                    Else
                        strCondition = strCondition + " OR " + "(OP_FLT_NUM ='" + strFlightNo + "' AND FLT_SCHED_DTM ='" + dtmFlightDeptTime + "')"
                    End If
                Next intValue
                For Each strTableName In lsDeletetableList
                    If Not strTableName = "T_Flight_Info" Then
                        strSqlCEQuery = "Delete from '" & strTableName & "' where " & strCondition & ""
                        SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, strSqlCEQuery)
                    End If
                Next
                strSqlCEQuery = "Delete from T_Flight_Info where " & strCondition & ""
                SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, strSqlCEQuery)
                SyncManager.MessageLogging("deleting data for multiple flights completed successfully", LogType.Trace, "ClearDataBase")
                Return True
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            End Try

            Return Nothing
        End Function
        ''' <summary>
        '''  General ExecuteStatement
        ''' </summary>
        ''' <param name="sqlcequery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteDataset(ByVal sqlcequery As String) As DataSet
            Return (SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, sqlcequery))
            Return Nothing
        End Function
        ''' <summary>
        ''' IsSyncUploadCompleted
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsSyncUploadCompleted() As Boolean
            Try
                Dim strTableName As String
                Dim dsTime As DataSet
                Dim dtmLastSync As Date
                Dim strQuery As String = Nothing
                Dim dtmModScan As Date
                Dim lstUploadTablesList As List(Of String)
                'Fetch list of tables for Uploading data
                lstUploadTablesList = TableStructure.UploadTables
                For Each strTableName In lstUploadTablesList
                    dtmLastSync = FetchLastSyncTime(strTableName, SyncConstants.OperationType.Upload)
                    strQuery = "select MAX(MODIFIED_TIME)as MODIFIED_TIME,MAX(SCANNED_TIME) as SCANNED_TIME from  " & strTableName
                    dsTime = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, strQuery)
                    If dsTime IsNot Nothing And dsTime.Tables(0).Rows(0)("MODIFIED_TIME") IsNot DBNull.Value And dsTime.Tables(0).Rows(0)("SCANNED_TIME") IsNot DBNull.Value Then
                        'Comparer.Equals(dsTime.Tables(0).Rows(0)("MODIFIED_TIME"), DBNull.Value)
                        If (dsTime.Tables(0).Rows(0)("MODIFIED_TIME")) > (dsTime.Tables(0).Rows(0)("SCANNED_TIME")) Then
                            dtmModScan = dsTime.Tables(0).Rows(0)("MODIFIED_TIME").ToString()
                        Else
                            dtmModScan = dsTime.Tables(0).Rows(0)("SCANNED_TIME").ToString()
                        End If
                        If dtmModScan > dtmLastSync Then
                            SyncManager.MessageLogging("SyncUpload failed", LogType.Exception, "IsSyncUploadCompleted")
                            Return False
                        End If
                    End If
                Next
                SyncManager.MessageLogging("SyncUpload completed", LogType.Information, "IsSyncUploadCompleted")
                Return True
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''' <summary>
        ''' Is Sync Upload Completed
        ''' </summary>
        ''' <param name="fltNum"></param>
        ''' <param name="fltSchdTime"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsSyncUploadCompleted(ByVal fltNum As String, ByVal fltSchdTime As BO.NWADateTime) As Boolean
            Try
                Dim strTableName As String
                Dim dsTime As DataSet
                Dim dtmLastSync As Date
                Dim strQuery As String = Nothing
                Dim dtmModScan As Date
                Dim lstUploadTablesList As List(Of String)
                'Fetch the Upload Table Names
                lstUploadTablesList = TableStructure.UploadTables

                For Each strTableName In lstUploadTablesList
                    dtmLastSync = FetchLastSyncTime(strTableName, SyncConstants.OperationType.Upload)
                    strQuery = "select MAX(MODIFIED_TIME)as MODIFIED_TIME,MAX(SCANNED_TIME) as SCANNED_TIME from  " & strTableName & " WHERE OP_AL_CDE = '" & fltNum.Substring(0, 2) & "' and OP_FLT_NUM = '" & fltNum.Substring(2) & "' AND FLT_SCHED_DTM ='" & fltSchdTime.SqlDateFormat & "'"
                    dsTime = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, strQuery)
                    If (dsTime.Tables(0).Rows(0)("MODIFIED_TIME")) > (dsTime.Tables(0).Rows(0)("SCANNED_TIME")) Then
                        dtmModScan = dsTime.Tables(0).Rows(0)("MODIFIED_TIME").ToString()
                    Else
                        dtmModScan = dsTime.Tables(0).Rows(0)("SCANNED_TIME").ToString()
                    End If

                    If dtmModScan > dtmLastSync Then
                        SyncManager.MessageLogging("SyncUpload Could not be completed", LogType.Information, "IsSyncUploadCompleted")
                        Return False
                    End If
                Next
                SyncManager.MessageLogging("SyncUpload completed successful", LogType.Information, "IsSyncUploadCompleted")
                Return True

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Gets the last sync time for the specified table
        ''' </summary>
        ''' <param name="tableName">Table whose last sync time needs to be fetched</param>
        ''' <param name="operationType">operation type to indicate Upload or Download</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FetchLastSyncTime(ByVal tableName As String, ByVal operationType As Byte) As Date

            Try
                Select Case (operationType)
                    Case 1
                        SyncManager.MessageLogging("", LogType.Information, "FetchLastSyncTime")
                        Return (SqlCeHelper.ExecuteScalar(_conSqlCE, CommandType.Text, "select SYNC_UPLOAD_TIME from T_Sync_Time where TABLE_NAME='" & tableName & "'"))
                    Case 2
                        SyncManager.MessageLogging("", LogType.Information, "FetchLastSyncTime")
                        Return (SqlCeHelper.ExecuteScalar(_conSqlCE, CommandType.Text, "select SYNC_DOWNLOAD_TIME from T_Sync_Time where TABLE_NAME='" & tableName & "'"))
                    Case Else
                        Return Nothing
                End Select

            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
            Finally
            End Try

        End Function
        ''' <summary>
        ''' Gets the list of active flights
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FetchActiveFlights() As DataSet
            Dim dsTmpDataset As DataSet
            Try
                dsTmpDataset = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, "SELECT OP_AL_CDE, OP_FLT_NUM as FLT_NUM, replace(convert(nvarchar,FLT_SCHED_DTM,23),'/','-') as FLT_SCHED_DTM,IS_NEW_REQUEST FROM T_Flight_Info WHERE PRE_CLOSE = 'N' AND IS_CLOSE = 'N'")
                SyncManager.MessageLogging("Fetching all active flight details", LogType.Information, "FetchActiveFlights")
                Return dsTmpDataset
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        ''' <summary>
        ''' Gets the list of Inactive flights
        ''' </summary>
        ''' <param name="timeDuration"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FetchInactiveFlights(ByVal timeDuration As Integer) As DataSet

            Try
                SyncManager.MessageLogging("fetching inactive flights", LogType.Trace, "FetchInactiveFlights")
                Return (SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, "SELECT OP_FLT_NUM , FLT_SCHED_DTM FROM T_Flight_Info WHERE (PRE_CLOSE = 'Y' AND IS_CLOSE = 'Y') OR (DATEADD(hh," & timeDuration & ",FLT_SCHED_DTM) <= getdate())"))

            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
                Return Nothing
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' Get and initialize the table Parameter from the Resource Manager
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub InitTableParameters()
            Dim interfaceDictionaryEnum As IDictionaryEnumerator
            Dim resourceManager As System.Resources.ResourceManager
            Dim resourceSet As System.Resources.ResourceSet
            Dim strdummy As String
            Dim txtReader As IO.StreamReader
            Try
                resourceManager = DBTables.ResourceManager()
                strdummy = resourceManager.GetString("")
                resourceSet = resourceManager.GetResourceSet(Globalization.CultureInfo.CurrentUICulture, False, False)
                interfaceDictionaryEnum = resourceSet.GetEnumerator()
                While interfaceDictionaryEnum.MoveNext()
                    txtReader = GetSchema(interfaceDictionaryEnum.Key, interfaceDictionaryEnum.Value)
                    _objTableParameter = New TableStructure(interfaceDictionaryEnum.Key, txtReader)
                End While
                SyncManager.MessageLogging("Table parameters initialised successfully", LogType.Information, "InitTableParameters")
            Catch ex As Exception
                MsgBox(ex.ToString())
                SyncManager.ErrorHandling(ex)
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sqlcequery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteNonQuery(ByVal sqlcequery As String) As Integer
            Try
                Return (SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, sqlcequery))
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)

            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="tableName"></param>
        ''' <param name="sqlceMasterQuery"></param>
        ''' <param name="sqlceTempQuery"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateDB(ByVal tableName As String, ByVal sqlceMasterQuery As String, ByVal sqlceTempQuery As String) As Integer
            Try
                Return (SqlCeHelper.UpdateTableConstraint(_conSqlCE, CommandType.Text, sqlceMasterQuery, sqlceTempQuery, tableName))
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)

            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="tableAlias"></param>
        ''' <param name="tableName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetSchema(ByVal tableAlias As String, ByVal tableName As String) As IO.StreamReader
            Dim dataset As DataSet
            Dim txtWriter As IO.StreamWriter
            Dim txtReader As IO.StreamReader
            Dim bufSchema As Char()
            Try
                dataset = SqlCeHelper.ExecuteDataset(_conSqlCE, CommandType.Text, "SELECT TOP FROM " & tableName)
                dataset.DataSetName = SyncConstants.XML_SCHEMA_ROOT
                dataset.Tables(0).TableName = tableAlias
                dataset.EnforceConstraints = True
                dataset.WriteXmlSchema(txtWriter)
                txtWriter.Write(bufSchema)
                txtReader.Read(bufSchema, 0, 1)
                Return txtReader
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' Updates the Is new request to false after the first hit
        ''' </summary>
        ''' <param name="activeFlights"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateNewRequest(ByVal activeFlights As DataSet) As Boolean
            Dim drTemp As DataRow
            Try
                If activeFlights IsNot Nothing Then
                    For Each drTemp In activeFlights.Tables(0).Rows
                        SqlCeHelper.ExecuteNonQuery(_conSqlCE, CommandType.Text, "UPDATE T_FLIGHT_INFO SET IS_NEW_REQUEST = 'N' WHERE OP_FLT_NUM = " & drTemp("FLT_NUM"))
                    Next
                End If
                SyncManager.MessageLogging("Updated is new request to false", LogType.Trace, "UpdateNewRequest")
            Catch sqlCeExp As SqlCeException
                SyncManager.ErrorHandling(sqlCeExp)
                Return Nothing
            Catch ex As Exception
                SyncManager.ErrorHandling(ex)
                Return Nothing
            End Try
        End Function
    End Class

End Namespace

