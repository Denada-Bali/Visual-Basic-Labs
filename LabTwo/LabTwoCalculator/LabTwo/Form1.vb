Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim result As Double
    Dim opr As String
    Dim output As String

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        opr = "+"
        result = num1 + num2
        TextBox3.Text = CStr(num1) + " " + opr + " " + CStr(num2) + " " + "=" + " " + CStr(result)

    End Sub

    Private Sub mul_btn_Click(sender As Object, e As EventArgs) Handles mul_btn.Click
        opr = "x"
        result = num1 * num2
        TextBox3.Text = CStr(num1) + " " + opr + " " + CStr(num2) + " " + "=" + " " + CStr(result)

    End Sub

    Private Sub sub_btn_Click(sender As Object, e As EventArgs) Handles sub_btn.Click
        opr = "-"
        result = num1 - num2
        TextBox3.Text = CStr(num1) + " " + opr + " " + CStr(num2) + " " + "=" + " " + CStr(result)

    End Sub

    Private Sub div_btn_Click(sender As Object, e As EventArgs) Handles div_btn.Click
        opr = "/"
        result = num1 / num2
        TextBox3.Text = CStr(num1) + " " + opr + " " + CStr(num2) + " " + "=" + " " + CStr(result)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        num1 = CDbl(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        num2 = CDbl(TextBox2.Text)
    End Sub
End Class
