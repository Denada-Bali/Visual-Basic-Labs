Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As SQLconnection = New SQLconnection()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim username As String, Password As String
        'username = TextBox1.Text
        'Password = TextBox2.Text
        'If username = "test" And Password = "1234" Then

        '    MsgBox("Logged In")

        'Else
        '    MsgBox("Try Again")
        'End If

        Dim cmd As New MySqlCommand("select 'username', 'password' from  madb.user where 'id' = @username AND 'password' = @password;", conn.GetConnection)
        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text
        conn.openConnection()

        Dim SQLAdapter As New MySqlDataAdapter(cmd)

        Dim SQLdataTable As New DataTable()

        SQLAdapter.Fill(SQLdataTable)

        If SQLdataTable.Rows.Count Then

            MessageBox.Show("Invalid Username Or Password")

        Else
            MessageBox.Show("Logged in")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim oForm As New ForgotPassword()

        Me.Hide()
        oForm.ShowDialog()

    End Sub
End Class
