Imports MySql.Data.MySqlClient
Imports System.IO

Module DatabaseConnector
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public i As Integer
    Public result As Boolean

    ' Function to establish a database connection
    Public Function dbconn() As Boolean
        Try
            ' Checking if the connection is closed
            If conn.State = ConnectionState.Closed Then
                ' Setting the connection string
                conn.ConnectionString = "server=localhost;username=root;password=;database=db_inventorysystem"

                ' Opening the connection
                conn.Open()

                ' If the connection is successfully opened
                result = True
            End If
        Catch ex As Exception
            ' If any error occurs, set result to False and show error message
            result = False
            MsgBox("Warning : Server Not Connected ! Error: " & ex.Message, vbExclamation)
        End Try
        Return result
    End Function
    ' Function to close the database connection
    Public Sub closeConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error while closing the connection: " & ex.Message, vbCritical)
        End Try
    End Sub
End Module
