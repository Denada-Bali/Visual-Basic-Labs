Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx.Notice
Imports System.Diagnostics.Eventing.Reader

Public Class RegistrationForm


    Dim connection As DatabaseConnection = New DatabaseConnection()
    Dim user As User = New User()

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkF()
        Dim firstname As String = firstnameTB.Text
        Dim lastname As String = lastnameTB.Text
        Dim bdate As String = dateOfBirth.Text

        Dim gender_value As Boolean
        If femaleRB.Checked = True Then
            gender_value = 1
        End If
        If maleRB.Checked = True Then
            gender_value = 0
        End If

        Dim gender As Integer = gender_value
        Dim username As String = UsernameTBox.Text
        Dim password As String = PasswordTBox.Text
        Dim phonenumber As String = phoneNumberTB.Text
        Dim email As String = emailTB.Text


        If user.insertUser(firstname, lastname, bdate, gender, username, password, phonenumber, email) Then
            MessageBox.Show("Data inserted successfully.")
        Else
            MessageBox.Show("Error inserting user data")
        End If




    End Sub

    Private Sub lastnameTB_KeyDown(sender As Object, e As KeyEventArgs) Handles lastnameTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            UsernameTBox.Text = firstnameTB.Text + lastnameTB.Text
        End If
    End Sub


    Private Sub checkF()

        If firstnameTB.Text = "" Then
            MessageBox.Show("The firstname field is required.")
            Return
        End If

        If lastnameTB.Text = "" Then
            MessageBox.Show("The lastname field is required.")
            Return
        End If

        If femaleRB.Checked = False And maleRB.Checked = False Then

            MessageBox.Show("Gender is required.")
            Return

        End If

        If UsernameTBox.Text = "" Then
            MessageBox.Show("The username field is required.")
            Return
        End If

        If PasswordTBox.Text = "" Then
            MessageBox.Show("The password field is required.")
            Return
        End If

        If phoneNumberTB.Text = "" Then
            MessageBox.Show("The phone number field is required.")
            Return
        End If

        If emailTB.Text = "" Then
            MessageBox.Show("The email field is required.")
            Return
        End If

    End Sub

    Private Sub ShowPasswordCB_CheckedChanged_1(sender As Object, e As EventArgs) Handles ShowPasswordCB.CheckedChanged
        If ShowPasswordCB.Checked = True Then
            PasswordTBox.PasswordChar = ""
        Else
            PasswordTBox.PasswordChar = "*"

        End If
    End Sub
End Class