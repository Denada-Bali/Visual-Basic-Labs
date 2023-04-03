Imports MySql.Data.MySqlClient

Public Class User
    Dim connection As DatabaseConnection = New DatabaseConnection()

    Public Function insertUser(ByVal firstName As String, ByVal lastName As String, ByVal bdate As String, ByVal gender As Integer, ByVal username As String, ByVal password As String, ByVal phonenumber As String, ByVal email As String) As Boolean

        ' Dim SQLcommand As New MySqlCommand("select 'username', 'password' from  vbdatabase.user where 'id' = @username AND 'password' = @password;", connection.GetConnection)

        Dim SQLcommand2 As New MySqlCommand("INSERT INTO signup(userId, first_name, last_name, dateOfBirth, gender, username, password, phone_number, email) VALUES (@first_name, @last_name, @dateOfBirth, @gender, @username, @password, @phone_number, @email)", connection.GetConnection)

        SQLcommand2.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = firstName
        SQLcommand2.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastName
        SQLcommand2.Parameters.Add("@dateOfBirth", MySqlDbType.VarChar).Value = bdate
        SQLcommand2.Parameters.Add("@gender", MySqlDbType.Int32).Value = gender
        SQLcommand2.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
        SQLcommand2.Parameters.Add("@password", MySqlDbType.VarChar).Value = password
        SQLcommand2.Parameters.Add("@phone_number", MySqlDbType.VarChar).Value = phonenumber
        SQLcommand2.Parameters.Add("@email", MySqlDbType.VarChar).Value = email

        connection.OpenConnect()

        Try
            connection.OpenConnect()
            If SQLcommand2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data inserted successfully.")
                Return True
            Else
                MessageBox.Show("Insert operation failed.")
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting user data: " & ex.Message)
            Return False
        Finally
            connection.CloseConnect()
        End Try


    End Function

End Class
