Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Namespace NWA.Safetrac.Scanner.DataAccess

    Public Class DataAccess
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private _TableName As String
        Private _ObjDataSet As DataSet
        Private _ErrorID As Integer
        Private _ErrorCode As String
        Private _ObjLogger As Object
        Private _syncCn As SqlCeConnection
        Private ObjConnectionThread As Threading.Thread

        Public Function InitConnection() As Boolean
            _syncCn = New SqlCeConnection
        End Function

        Public Function CloseConnection() As Boolean

        End Function

        Public Function UpdateRecord(ByVal tableName As String, ByVal dataSet As DataSet) As String
            Return Nothing
        End Function

        Public Function FetchRecords(ByVal tableName As String, ByVal lastSyncTime As Date) As DataSet
            Return Nothing
        End Function

        Public Function FetchInactiveFlights(ByVal timeDuration As Date) As List(Of String)
            Return Nothing
        End Function

        Public Function SetSyncTime(ByVal tableName As String, ByVal operationType As String) As Boolean
            Return Nothing
        End Function

        Public Function ClearDataBase(ByVal flightNo As String, _
               ByVal flightDeptTime As Date) As Boolean

        End Function

        Public Function FetchLastSyncTime(ByVal tableName As String, ByVal operationType As Byte) As Date
            Select Case (operationType)
                Case 0
                    Return (Safetrac.Scanner.DataAccess.SqlCeHelper.ExecuteScalar(_syncCn, CommandType.Text, "select tablename,lastuploadtime from T_Sync_Time"))
                Case 1
                    Return (Safetrac.Scanner.DataAccess.SqlCeHelper.ExecuteScalar(_syncCn, CommandType.Text, "select lastdownloadtime from T_Sync_Time"))
                Case Else
                    Return Nothing
            End Select
            Return Nothing
        End Function

        Private Function InsertRecord(ByVal tableName As String, ByVal dataSet As DataSet) As String
            Return Nothing
        End Function

        Private Function FetchActiveFlights() As List(Of String)
            Return Nothing
        End Function

    End Class ' END CLASS DEFINITION DataAccess

End Namespace ' DataAccess

