Imports MySql.Data.MySqlClient

Public Class SQLconnection

    Dim connectionString As New String("datasource=localhost;port=3306;username=root;password=;database=madb")
    Dim connection As New MySqlConnection(connectionString)

    Public ReadOnly Property GetConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' Create a function to open connection
    Public Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Create a function to close connection
    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
