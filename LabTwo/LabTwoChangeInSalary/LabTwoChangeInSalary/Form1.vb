Public Class Form1
    Dim salary As Double
    Dim change As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        salary = CDbl(TextBox1.Text)

        For index As Integer = 1 To 3
            change = salary + (salary * 0.15)
        Next

        TextBox2.Text = change.ToString("C")

        TextBox3.Text = FormatPercent((change - salary) / change)

    End Sub
End Class
