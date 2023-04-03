Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class DatabaseConnection

    Dim SQLconnection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=vbdatabase; convert zero datetime=True")
    Dim SQLreader As MySqlDataReader


    ' To get connection
    Public ReadOnly Property GetConnection() As MySqlConnection
        Get
            Return SQLconnection
        End Get
    End Property

    ' Create a function to open connection
    Public Sub OpenConnect()
        If SQLconnection.State = ConnectionState.Closed Then
            SQLconnection.Open()
        End If
    End Sub

    ' Create a function to close connection
    Public Sub CloseConnect()
        If SQLconnection.State = ConnectionState.Open Then
            SQLconnection.Close()
        End If
    End Sub

End Class
