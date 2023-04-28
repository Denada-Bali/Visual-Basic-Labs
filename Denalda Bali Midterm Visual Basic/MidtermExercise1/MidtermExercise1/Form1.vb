Public Class Form1

    Dim rand As New Random
    Dim num1 As Integer
    Dim num2 As Integer
    Dim sum As Integer = 0
    Dim score As Integer = 0


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        num1 = rand.Next(0, 30)
        num2 = rand.Next(0, 30)

        Label1.Text = CStr(num1)
        Label2.Text = CStr(num2)

        sum = num1 + num2

        TextBox1.Text = ""
        TextBox2.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If CInt(TextBox1.Text) = sum Then
            score += 1
            TextBox3.Text = CStr(score)
            TextBox2.Text = "Well done!"
        Else
            TextBox2.Text = "Sorry! Try Again :("
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub
End Class
