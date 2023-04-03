Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Google.Protobuf.WellKnownTypes

Public Class Form1


    Dim connection As DatabaseConnection = New DatabaseConnection()

    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click

        Dim username As String
        Dim password As String

        Dim SQLcommand As New MySqlCommand("select 'username', 'password' from  vbdatabase.user where 'id' = @username AND 'password' = @password;", connection.GetConnection)

        SQLcommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox1.Text
        SQLcommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text

        Dim SQLAdapter As New MySqlDataAdapter(SQLcommand)

        Dim SQLdataTable As New DataTable()

        SQLAdapter.Fill(SQLdataTable)

        If SQLdataTable.Rows.Count Then

            MessageBox.Show("Invalid Username Or Password")

        Else
            MessageBox.Show("Logged in")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

        'username = TextBox1.Text
        'password = TextBox2.Text


        'If username = "" Then
        '    MessageBox.Show("Please Enter Username", "Try Again")
        '    TextBox1.Focus()
        '    Exit Sub
        'ElseIf password = "" Then
        '    MessageBox.Show("Please Enter Password", "Try Again")
        '    TextBox2.Focus()
        '    Exit Sub
        'End If


        'If username = "Enad" And password = "1234" Then
        '    MessageBox.Show("Welcome " + username, "Logged In")
        'Else
        '    MessageBox.Show("Incorrect Username or Password", "Try Again")
        '    TextBox1.Clear()
        '    TextBox2.Clear()
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged



        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"

        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        RegistrationForm.Show()
        Me.Hide()

    End Sub
End Class
