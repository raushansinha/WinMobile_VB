Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlServerCe
Imports System.Collections
Imports System.Data.Common
Imports System.Reflection
Imports System.Globalization

Namespace NWA.Safetrac.Scanner.DataAccess
    ''' <summary> 
    ''' The SqlHelper class is intended to encapsulate high performance, scalable best practices for 
    ''' common uses of SqlClient 
    ''' </summary> 
    Public NotInheritable Class SqlCeHelper
#Region "private utility methods & constructors"

        ' Since this class provides only static methods, make the default constructor private to prevent 
        ' instances from being created with "new SqlHelper()" 
        Public Sub New()
        End Sub

        ''' <summary> 
        ''' This method is used to attach array of SqlCeParameters to a SqlCeCommand. 
        ''' 
        ''' This method will assign a value of DbNull to any parameter with a direction of 
        ''' InputOutput and a value of null. 
        ''' 
        ''' This behavior will prevent default values from being used, but 
        ''' this will be the less common case than an intended pure output parameter (derived as InputOutput) 
        ''' where the user provided no input value. 
        ''' </summary> 
        ''' <param name="command">The command to which the parameters will be added</param> 
        ''' <param name="commandParameters">An array of SqlCeParameters to be added to command</param> 
        Private Shared Sub AttachParameters(ByVal command As SqlCeCommand, ByVal commandParameters As SqlCeParameter())

            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            If commandParameters IsNot Nothing Then
                For Each p As SqlCeParameter In commandParameters
                    If p IsNot Nothing Then
                        ' Check for derived output value with no value assigned 
                        If (p.Direction = ParameterDirection.InputOutput OrElse p.Direction = ParameterDirection.Input) AndAlso (p.Value Is Nothing) Then
                            p.Value = DBNull.Value
                        End If
                        command.Parameters.Add(p)
                    End If
                Next
            End If
        End Sub


        ''' <summary> 
        ''' This method opens (if necessary) and assigns a connection, transaction, command type and parameters 
        ''' to the provided command 
        ''' </summary> 
        ''' <param name="command">The SqlCeCommand to be prepared</param> 
        ''' <param name="connection">A valid SqlCeConnection, on which to execute this command</param> 
        ''' <param name="transaction">A valid SqlCeTransaction, or 'null'</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlCeParameters to be associated with the command or 'null' if no parameters are required</param> 
        ''' <param name="mustCloseConnection"><c>true</c> if the connection was opened by the method, otherwose is false.</param> 
        Private Shared Sub PrepareCommand(ByVal command As SqlCeCommand, ByVal connection As SqlCeConnection, ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlCeParameter(), _
        ByRef mustCloseConnection As Boolean)
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If

            If commandType = commandType.StoredProcedure Then
                Throw New ArgumentException("Stored Procedures are not supported.")
            End If

            ' If the provided connection is not open, we will open it 
            If connection.State <> ConnectionState.Open Then
                mustCloseConnection = True
                connection.Open()
            Else
                mustCloseConnection = False
            End If

            ' Associate the connection with the command 
            command.Connection = connection

            ' Set the command text (SQL statement) 
            command.CommandText = commandText

            ' If we were provided a transaction, assign it 
            If transaction IsNot Nothing Then
                If transaction.Connection Is Nothing Then
                    Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
                End If
                command.Transaction = transaction
            End If

            ' Set the command type 
            command.CommandType = commandType

            ' Attach the command parameters if they are provided 
            If commandParameters IsNot Nothing Then
                AttachParameters(command, commandParameters)
            End If
            Return
        End Sub

#End Region

#Region "ExecuteNonQuery"

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset and takes no parameters) against the database specified in 
        ''' the connection string 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(connString, CommandType.Text, "Insert into TableTransaction (OrderAmount) Values(500)"); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As Integer
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteNonQuery(connectionString, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset) against the database specified in the connection string 
        ''' using the provided parameters 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(connString, CommandType.Text, "Update TableTransaction set OrderAmount = 500 where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Integer
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If

            ' Create & open a SqlCeConnection, and dispose of it after we are done 
            Using connection As New SqlCeConnection(connectionString)

                ' Call the overload that takes a connection in place of the connection string 
                Return ExecuteNonQuery(connection, commandType, commandText, commandParameters)
            End Using
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(conn, CommandType.Text, "Insert into TableTransaction (OrderAmount) Values(500)"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String) As Integer
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteNonQuery(connection, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(conn, CommandType.Text, "Update TableTransaction set OrderAmount = 500 where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Integer
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Finally, execute the command 
            Dim retval As Integer = cmd.ExecuteNonQuery()

            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()
            If mustCloseConnection Then
                Try
                    connection.Close()
                Catch ex As SqlCeException
                    Throw ex
                Catch ex As Exception
                    Throw ex
                End Try
            End If
            Return retval
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(trans, CommandType.Text, "Insert into TableTransaction (OrderAmount) Values(500)"); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String) As Integer
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteNonQuery(transaction, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns no resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int result = ExecuteNonQuery(trans, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An int representing the number of rows affected by the command</returns> 
        Public Shared Function ExecuteNonQuery(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Integer
            If transaction Is Nothing Then
                Throw New ArgumentNullException("transaction")
            End If
            If transaction IsNot Nothing AndAlso transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Finally, execute the command 
            Dim retval As Integer = cmd.ExecuteNonQuery()

            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()
            Return retval
        End Function

#End Region

#Region "ExecuteDataset"

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the database specified in 
        ''' the connection string. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(connString, CommandType.Text, "Select * from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteDataset(connectionString, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the database specified in the connection string 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(connString, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As DataSet
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If

            ' Create & open a SqlCeConnection, and dispose of it after we are done 
            Using connection As New SqlCeConnection(connectionString)
                ' Call the overload that takes a connection in place of the connection string 
                Return ExecuteDataset(connection, commandType, commandText, commandParameters)
            End Using
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(conn, CommandType.Text, "Select * from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteDataset(connection, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(conn, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As DataSet
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Create the DataAdapter & DataSet 
            Dim da As New SqlCeDataAdapter(cmd)

            Dim ds As New DataSet()
            ds.Locale = CultureInfo.InvariantCulture

            ' Fill the DataSet using default values for DataTable names, etc 
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.AcceptChangesDuringFill = False
            da.AcceptChangesDuringUpdate = False
            da.Fill(ds)
            ds.EnforceConstraints = True
            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()

            If mustCloseConnection Then
                connection.Close()
            End If

            ' Return the dataset 
            Return ds

        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(trans, CommandType.Text, "Select * from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteDataset(transaction, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' DataSet ds = ExecuteDataset(trans, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A dataset containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteDataset(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As DataSet
            If transaction Is Nothing Then
                Throw New ArgumentNullException("transaction")
            End If
            If transaction IsNot Nothing AndAlso transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Create the DataAdapter & DataSet 
            'using( SqlCeDataAdapter da = new SqlCeDataAdapter(cmd) ) 

            Dim da As New SqlCeDataAdapter(cmd)

            Dim ds As New DataSet()
            ds.Locale = CultureInfo.InvariantCulture

            ' Fill the DataSet using default values for DataTable names, etc 
            da.Fill(ds)

            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()

            ' Return the dataset 
            Return ds

        End Function

#End Region

#Region "ExecuteReader"

        ''' <summary> 
        ''' This enum is used to indicate whether the connection was provided by the caller, or created by SqlHelper, so that 
        ''' we can set the appropriate CommandBehavior when calling ExecuteReader() 
        ''' </summary> 
        Private Enum SqlCeConnectionOwnership
            ''' <summary>Connection is owned and managed by SqlHelper</summary> 
            Internal
            ''' <summary>Connection is owned and managed by the caller</summary> 
            External
        End Enum

        ''' <summary> 
        ''' Create and prepare a SqlCeCommand, and call ExecuteReader with the appropriate CommandBehavior. 
        ''' </summary> 
        ''' <remarks> 
        ''' If we created and opened the connection, we want the connection to be closed when the DataReader is closed. 
        ''' 
        ''' If the caller provided the connection, we want to leave it to them to manage. 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection, on which to execute this command</param> 
        ''' <param name="transaction">A valid SqlCeTransaction, or 'null'</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlCeParameters to be associated with the command or 'null' if no parameters are required</param> 
        ''' <param name="connectionOwnership">Indicates whether the connection parameter was provided by the caller, or created by SqlHelper</param> 
        ''' <returns>SqlCeDataReader containing the results of the command</returns> 
        Private Shared Function ExecuteReader(ByVal connection As SqlCeConnection, ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters As SqlCeParameter(), ByVal connectionOwnership As SqlCeConnectionOwnership) As SqlCeDataReader
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            Dim mustCloseConnection As Boolean = False
            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Try
                PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, _
                mustCloseConnection)

                ' Create a reader 
                Dim dataReader As SqlCeDataReader

                ' Call ExecuteReader with the appropriate CommandBehavior 
                If connectionOwnership = SqlCeConnectionOwnership.External Then
                    'MsgBox("In if " + cmd.CommandText)
                    dataReader = cmd.ExecuteReader()
                Else
                    ' MsgBox(cmd.CommandText)
                    dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                End If

                ' Detach the SqlCeParameters from the command object, so they can be used again. 
                ' HACK: There is a problem here, the output parameter values are fletched 
                ' when the reader is closed, so if the parameters are detached from the command 
                ' then the SqlReader can´t set its values. 
                ' When this happen, the parameters can´t be used again in other command. 
                Dim canClear As Boolean = True
                For Each commandParameter As SqlCeParameter In cmd.Parameters
                    If commandParameter.Direction <> ParameterDirection.Input Then
                        canClear = False
                    End If
                Next

                If canClear Then
                    cmd.Parameters.Clear()
                End If
                Return dataReader
            Catch
                If mustCloseConnection Then
                    connection.Close()
                End If
                Throw
            End Try
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the database specified in 
        ''' the connection string. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(connString, CommandType.Text, "Select Orderid from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As SqlCeDataReader
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteReader(connectionString, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the database specified in the connection string 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(connString, CommandType.Text, "Select Orderid from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As SqlCeDataReader
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If
            Dim connection As SqlCeConnection = Nothing
            Try
                connection = New SqlCeConnection(connectionString)

                ' Call the private overload that takes an internally owned connection in place of the connection string 
                Return ExecuteReader(connection, Nothing, commandType, commandText, commandParameters, SqlCeConnectionOwnership.Internal)
            Catch
                ' If we fail to return the SqlDatReader, we need to close the connection ourselves 
                If connection IsNot Nothing Then
                    connection.Close()
                End If
                Throw
            End Try

        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(conn, CommandType.Text, "Select Orderid from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String) As SqlCeDataReader
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteReader(connection, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(conn, CommandType.Text, "Select Orderid from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As SqlCeDataReader
            ' Pass through the call to the private overload using a null transaction value and an externally owned connection 
            Return ExecuteReader(connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, commandParameters, SqlCeConnectionOwnership.External)
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(trans, CommandType.Text, "Select Orderid from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String) As SqlCeDataReader
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteReader(transaction, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeDataReader dr = ExecuteReader(trans, CommandType.Text, "Select Orderid from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>A SqlCeDataReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteReader(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As SqlCeDataReader
            If transaction Is Nothing Then
                Throw New ArgumentNullException("transaction")
            End If
            If transaction IsNot Nothing AndAlso transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            End If

            ' Pass through to private overload, indicating that the connection is owned by the caller 
            Return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, SqlCeConnectionOwnership.External)
        End Function

#End Region

#Region "ExecuteScalar"

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset and takes no parameters) against the database specified in 
        ''' the connection string. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(connString, CommandType.Text, "GetOrderCount"); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As Object
            ' Pass through the call providing null for the set of SqlCeParameters 
            Debug.WriteLine("ExecuteScalar")
            Return ExecuteScalar(connectionString, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset) against the database specified in the connection string 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(connString, CommandType.Text, "Select count(Order) from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Object
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If
            ' Create & open a SqlCeConnection, and dispose of it after we are done 
            'Using connection As New SqlCeConnection(connectionString)
            Dim connection As New SqlCeConnection(connectionString)
            ' Call the overload that takes a connection in place of the connection string 
            Debug.WriteLine("ExecuteScalar(connection, commandType, commandText, commandParameters)")
            Return ExecuteScalar(connection, commandType, commandText, commandParameters)
            '   End Using
            connection.Close()
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(conn, CommandType.Text, "Select count(Order) from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String) As Object
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteScalar(connection, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(conn, CommandType.Text, "Select count(Order) from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Object
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()

            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Execute the command & return the results 
            Debug.WriteLine("cmd.ExecuteScalar()")
            Dim retval As Object = cmd.ExecuteScalar()
            If retval IsNot Nothing Then
            Else
                MsgBox("execute scalar result is null")
            End If
            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()

            If mustCloseConnection Then
                'connection.Close()
            End If

            Return retval
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(trans, CommandType.Text, "Select count(Order) from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String) As Object
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteScalar(transaction, commandType, commandText, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a 1x1 resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' int orderCount = (int)ExecuteScalar(trans, CommandType.Text, "Select count(Order) from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns> 
        Public Shared Function ExecuteScalar(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters As SqlCeParameter()) As Object
            If transaction Is Nothing Then
                Throw New ArgumentNullException("transaction")
            End If
            If transaction IsNot Nothing AndAlso transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            End If

            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Execute the command & return the results 
            Dim retval As Object = cmd.ExecuteScalar()

            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()
            Return retval
        End Function

#End Region

#Region "ExecuteXml"
        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' string r = ExecuteXml(conn, CommandType.Text, "Select * from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command using "FOR XML AUTO"</param> 
        ''' <returns>An string containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteXml(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal xmlBodyRoot As String, ByVal xmlTableRoot As String) As String
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteXml(connection, commandType, commandText, xmlBodyRoot, xmlTableRoot, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' string r = ExecuteXml(conn, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command using "FOR XML AUTO"</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An string containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteXml(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal xmlBodyRoot As String, ByVal xmlTableRoot As String, ByVal ParamArray commandParameters As SqlCeParameter()) As String
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            Dim mustCloseConnection As Boolean = False
            ' Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim retval As String
            Try
                PrepareCommand(cmd, connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, commandParameters, _
                mustCloseConnection)
                ' Create the DataAdapter & DataSet 
                Dim obj_Adapter As New SqlCeDataAdapter(cmd)
                Dim ds As New DataSet(xmlBodyRoot)
                ds.Locale = CultureInfo.InvariantCulture
                ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
                obj_Adapter.Fill(ds, xmlTableRoot)
                ' Detach the SqlCeParameters from the command object, so they can be used again 
                cmd.Parameters.Clear()
                retval = ds.GetXml()
                ds.Clear()
                obj_Adapter.Dispose()
                If mustCloseConnection Then
                    connection.Close()
                End If
                Return retval
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' string r = ExecuteXmlReader(trans, CommandType.Text, "Select * from TableTransaction"); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command using "FOR XML AUTO"</param> 
        ''' <returns>An string containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteXml(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal xmlBodyRoot As String, ByVal xmlTableRoot As String) As String
            ' Pass through the call providing null for the set of SqlCeParameters 
            Return ExecuteXml(transaction, commandType, commandText, xmlBodyRoot, xmlTableRoot, DirectCast(Nothing, SqlCeParameter()))
        End Function

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' XmlReader r = ExecuteXmlReader(trans, CommandType.Text, "Select * from TableTransaction where ProdId=?", new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command using "FOR XML AUTO"</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <returns>An XmlReader containing the resultset generated by the command</returns> 
        Public Shared Function ExecuteXml(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal xmlBodyRoot As String, ByVal xmlTableRoot As String, ByVal ParamArray commandParameters As SqlCeParameter()) As String
            If transaction Is Nothing Then
                Throw New ArgumentNullException("transaction")
            End If
            If transaction IsNot Nothing AndAlso transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction")
            End If

            ' // Create a command and prepare it for execution 
            Dim cmd As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Create the DataAdapter & DataSet 
            Dim obj_Adapter As New SqlCeDataAdapter(cmd)
            Dim ds As New DataSet(xmlBodyRoot)
            ds.Locale = CultureInfo.InvariantCulture
            obj_Adapter.Fill(ds, xmlTableRoot)

            ' Detach the SqlCeParameters from the command object, so they can be used again 
            cmd.Parameters.Clear()
            Dim retval As String = ds.GetXml()
            ds.Clear()
            obj_Adapter.Dispose()
            Return retval
        End Function

#End Region

#Region "FillDataset"
        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the database specified in 
        ''' the connection string. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(connString, CommandType.Text, "Select * from TableTransaction", ds, new string[] {"orders"}); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name)</param> 
        Public Shared Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String())
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If
            If dataSet Is Nothing Then
                Throw New ArgumentNullException("dataSet")
            End If

            ' Create & open a SqlCeConnection, and dispose of it after we are done 
            Using connection As New SqlCeConnection(connectionString)
                ' Call the overload that takes a connection in place of the connection string 
                FillDataset(connection, commandType, commandText, dataSet, tableNames)
            End Using
        End Sub

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the database specified in the connection string 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(connString, CommandType.Text, "Select * from TableTransaction where ProdId=?", ds, new string[] {"orders"}, new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connectionString">A valid connection string for a SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        Public Shared Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String(), ByVal ParamArray commandParameters As SqlCeParameter())
            If connectionString Is Nothing OrElse connectionString.Length = 0 Then
                Throw New ArgumentNullException("connectionString")
            End If
            If dataSet Is Nothing Then
                Throw New ArgumentNullException("dataSet")
            End If
            ' Create & open a SqlCeConnection, and dispose of it after we are done 
            Using connection As New SqlCeConnection(connectionString)
                ' Call the overload that takes a connection in place of the connection string 
                FillDataset(connection, commandType, commandText, dataSet, tableNames, commandParameters)
            End Using
        End Sub

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeConnection. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(conn, CommandType.Text, "Select * from TableTransaction", ds, new string[] {"orders"}); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        Public Shared Sub FillDataset(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String())
            FillDataset(connection, commandType, commandText, dataSet, tableNames, Nothing)
        End Sub

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(conn, CommandType.Text, "Select * from TableTransaction where ProdId=?", ds, new string[] {"orders"}, new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        Public Shared Sub FillDataset(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String(), ByVal ParamArray commandParameters As SqlCeParameter())
            FillDataset(connection, Nothing, commandType, commandText, dataSet, tableNames, _
            commandParameters)
        End Sub

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset and takes no parameters) against the provided SqlCeTransaction. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(trans, CommandType.Text, "Select * from TableTransaction", ds, new string[] {"orders"}); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        Public Shared Sub FillDataset(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String())
            FillDataset(transaction, commandType, commandText, dataSet, tableNames, Nothing)
        End Sub

        ''' <summary> 
        ''' Execute a SqlCeCommand (that returns a resultset) against the specified SqlCeTransaction 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(trans, CommandType.Text, "Select * from TableTransaction where ProdId=?", ds, new string[] {"orders"}, new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        Public Shared Sub FillDataset(ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String(), ByVal ParamArray commandParameters As SqlCeParameter())
            FillDataset(transaction.Connection, transaction, commandType, commandText, dataSet, tableNames, _
            commandParameters)
        End Sub

        ''' <summary> 
        ''' Private helper method that execute a SqlCeCommand (that returns a resultset) against the specified SqlCeTransaction and SqlCeConnection 
        ''' using the provided parameters. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' FillDataset(conn, trans, CommandType.Text, "Select * from TableTransaction where ProdId=?", ds, new string[] {"orders"}, new SqlCeParameter("@prodid", 24)); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection</param> 
        ''' <param name="transaction">A valid SqlCeTransaction</param> 
        ''' <param name="commandType">The CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">The T-SQL command</param> 
        ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param> 
        ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced 
        ''' by a user defined name (probably the actual table name) 
        ''' </param> 
        ''' <param name="commandParameters">An array of SqlParamters used to execute the command</param> 
        Private Shared Sub FillDataset(ByVal connection As SqlCeConnection, ByVal transaction As SqlCeTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames As String(), _
        ByVal ParamArray commandParameters As SqlCeParameter())
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If
            If dataSet Is Nothing Then
                Throw New ArgumentNullException("dataSet")
            End If

            ' Create a command and prepare it for execution 
            Dim command As New SqlCeCommand()
            Dim mustCloseConnection As Boolean = False
            PrepareCommand(command, connection, transaction, commandType, commandText, commandParameters, _
            mustCloseConnection)

            ' Create the DataAdapter & DataSet 
            Dim dataAdapter As New SqlCeDataAdapter(command)

            Try
                ' Add the table mappings specified by the user 
                If tableNames IsNot Nothing AndAlso tableNames.Length > 0 Then
                    Dim tableName As String = "Table"
                    For index As Integer = 0 To tableNames.Length - 1
                        If tableNames(index) Is Nothing OrElse tableNames(index).Length = 0 Then
                            Throw New ArgumentException("The tableNames parameter must contain a list of tables, a value was provided as null or empty string.", "tableNames")
                        End If
                        dataAdapter.TableMappings.Add(tableName, tableNames(index))
                        tableName += (index + 1).ToString()
                    Next
                End If

                ' Fill the DataSet using default values for DataTable names, etc 
                dataAdapter.Fill(dataSet)

                ' Detach the SqlCeParameters from the command object, so they can be used again 
                command.Parameters.Clear()

                If mustCloseConnection Then
                    connection.Close()
                End If
            Finally
                dataAdapter.Dispose()
            End Try

        End Sub

#End Region

#Region "UpdateDataset"
        ''' <summary> 
        ''' Executes the respective command for each inserted, updated, or deleted row in the DataSet. 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' UpdateDataset(conn, insertCommand, deleteCommand, updateCommand, dataSet, "Order"); 
        ''' </remarks> 
        ''' <param name="insertCommand">A valid transact-SQL statement to insert new records into the data source</param> 
        ''' <param name="deleteCommand">A valid transact-SQL statement to delete records from the data source</param> 
        ''' <param name="updateCommand">A valid transact-SQL statement used to update records in the data source</param> 
        ''' <param name="dataSet">The DataSet used to update the data source</param> 
        ''' <param name="tableName">The DataTable used to update the data source.</param> 
        Public Shared Sub UpdateDataset(ByVal insertCommand As SqlCeCommand, ByVal deleteCommand As SqlCeCommand, ByVal updateCommand As SqlCeCommand, ByVal dataSet As DataSet, ByVal tableName As String)
            If insertCommand Is Nothing Then
                Throw New ArgumentNullException("insertCommand")
            End If
            If deleteCommand Is Nothing Then
                Throw New ArgumentNullException("deleteCommand")
            End If
            If updateCommand Is Nothing Then
                Throw New ArgumentNullException("updateCommand")
            End If
            If tableName Is Nothing OrElse tableName.Length = 0 Then
                Throw New ArgumentNullException("tableName")
            End If

            ' Create a SqlDataAdapter, and dispose of it after we are done 
            Dim dataAdapter As New SqlCeDataAdapter()
            Try
                ' Set the data adapter commands 
                dataAdapter.UpdateCommand = updateCommand
                dataAdapter.InsertCommand = insertCommand
                dataAdapter.DeleteCommand = deleteCommand

                ' Update the dataset changes in the data source 
                dataAdapter.Update(dataSet, tableName)

                ' Commit all the changes made to the DataSet 
                dataSet.AcceptChanges()
            Catch E As SqlCeException
                Dim strError As String = E.Message
            Finally
                dataAdapter.Dispose()
            End Try
        End Sub
#End Region

#Region "CreateCommand"

        ''' <summary> 
        ''' Simplify the creation of a Sql command object by allowing 
        ''' a CommandType and Command Text to be provided 
        ''' </summary> 
        ''' <remarks> 
        ''' e.g.: 
        ''' SqlCeCommand command = CreateCommand(conn, CommandType.Text, "Select * from Customers"); 
        ''' </remarks> 
        ''' <param name="connection">A valid SqlCeConnection object</param> 
        ''' <param name="commandType">CommandType (TableDirect, Text)</param> 
        ''' <param name="commandText">CommandText</param> 
        ''' <returns>A valid SqlCeCommand object</returns> 
        Public Shared Function CreateCommand(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String) As SqlCeCommand
            If connection Is Nothing Then
                Throw New ArgumentNullException("connection")
            End If

            If commandType = commandType.StoredProcedure Then
                Throw New ArgumentException("Stored Procedures are not supported.")
            End If

            ' If we receive parameter values, we need to figure out where they go 
            If (commandText Is Nothing) AndAlso (commandText.Length <= 0) Then
                Throw New ArgumentNullException("Command Text")
            End If

            ' Create a SqlCeCommand 
            Dim cmd As New SqlCeCommand(commandText, connection)
            cmd.CommandType = commandType.Text

            Return cmd

        End Function
#End Region

#Region "UpdateDataSet"
        Public Shared Function UpdateTable(ByVal tableName As String, ByVal ds As DataSet) As Integer
            Try
                Dim con As SqlCeConnection, path As String
                Dim adp As SqlCeDataAdapter, retvalue As Integer

                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
                con = New SqlCeConnection("data source=" & path & "\safetrac.sdf")
                con.Open()
                adp = New SqlCeDataAdapter("select * from " & tableName, con)
                AddHandler adp.RowUpdated, New SqlCeRowUpdatedEventHandler(AddressOf OnRowUpdated)

                ds.Tables(0).TableName = tableName

                Dim cb As New SqlCeCommandBuilder(adp)
                adp.InsertCommand = cb.GetInsertCommand()
                adp.UpdateCommand = cb.GetUpdateCommand()
                adp.DeleteCommand = cb.GetDeleteCommand()

                retvalue = adp.Update(ds, tableName)
                'MsgBox("update susccessful")
                ds.AcceptChanges()
                con.Close()
                con.Dispose()
                adp.Dispose()
                Return retvalue

            Catch ex As SqlCeException
                MsgBox(ex.ToString)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Function

        Public Shared Function UpdateTable(ByVal connectionString As String, ByVal tableName As String, ByVal ds As DataSet, ByVal sqlceQuery As String) As Integer
            Try
                Dim adp As SqlCeDataAdapter, retvalue As Integer
                Using con As New SqlCeConnection(connectionString)
                    adp = New SqlCeDataAdapter(sqlceQuery, con)
                    adp.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    AddHandler adp.RowUpdated, New SqlCeRowUpdatedEventHandler(AddressOf OnRowUpdated)

                    'adp.ContinueUpdateOnError = True
                    ds.Tables(0).TableName = tableName
                    ds.DataSetName = "SafetracSOAPBody"
                    Dim cb As New SqlCeCommandBuilder(adp)
                    adp.InsertCommand = cb.GetInsertCommand()
                    adp.UpdateCommand = cb.GetUpdateCommand()
                    adp.DeleteCommand = cb.GetDeleteCommand()
                    retvalue = adp.Update(ds.Tables(0))
                    ds.AcceptChanges()
                End Using
                adp.Dispose()
                Return retvalue
            Catch ex As SqlCeException
                MsgBox(ex.ToString)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Function

        Public Shared Sub OnRowUpdated( _
                    ByVal sender As Object, ByVal args As SqlCeRowUpdatedEventArgs)
            If args.Status = UpdateStatus.ErrorsOccurred Then
                args.Row.RowError = args.Errors.Message
                args.Status = UpdateStatus.SkipCurrentRow
            End If
        End Sub

        Public Shared Function UpdateTableConstraint(ByVal connection As SqlCeConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal sqlceTempQuery As String, ByVal tableName As String) As Integer
            Try
                If connection Is Nothing Then
                    Throw New ArgumentNullException("connection")
                End If
                ' Create a command and prepare it for execution 
                Dim cmd As New SqlCeCommand()
                Dim mustCloseConnection As Boolean = False
                Dim retvalue As Integer
                PrepareCommand(cmd, connection, DirectCast(Nothing, SqlCeTransaction), commandType, commandText, DirectCast(Nothing, SqlCeParameter()), _
                mustCloseConnection)
                '' Create the DataAdapter & DataSet 
                Dim da As New SqlCeDataAdapter(cmd)
                Dim ds As New DataSet()
                'ds.Locale = CultureInfo.InvariantCulture
                '' Fill the DataSet using default values for DataTable names, etc 
                AddHandler da.RowUpdated, New SqlCeRowUpdatedEventHandler(AddressOf OnRowUpdated)
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                Dim cb As New SqlCeCommandBuilder(da)
                da.InsertCommand = cb.GetInsertCommand()
                da.UpdateCommand = cb.GetUpdateCommand()
                da.DeleteCommand = cb.GetDeleteCommand()
                da.Fill(ds, tableName)
                Dim ds1 As DataSet
                ds1 = ExecuteDataset(connection, commandType, sqlceTempQuery)
                ds1.DataSetName = ds.DataSetName
                ds1.Tables(0).TableName = ds.Tables(0).TableName
                ds.Merge(ds1)
                retvalue = da.Update(ds, tableName)
                cmd.Parameters.Clear()
                If mustCloseConnection Then
                    connection.Close()
                End If
                Return retvalue
            Catch ex As SqlCeException
                Throw ex
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace