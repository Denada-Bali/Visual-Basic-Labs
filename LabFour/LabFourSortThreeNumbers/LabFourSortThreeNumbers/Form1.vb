Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber, secondNumber, thirdNumber As Decimal


        firstNumber = CDbl(TextBox1.Text)
        secondNumber = CDbl(TextBox2.Text)
        thirdNumber = CDbl(TextBox3.Text)

        Sort(firstNumber, secondNumber, thirdNumber)

        TextBox4.Text = CStr(firstNumber)
        TextBox5.Text = CStr(secondNumber)
        TextBox6.Text = CStr(thirdNumber)
    End Sub

    Sub Sort(ByRef firstNumber As Decimal, ByRef secondNumber As Decimal, ByRef thirdNumber As Decimal)

        Dim temp As Decimal

        If secondNumber > firstNumber Then
            temp = firstNumber
            firstNumber = secondNumber
            secondNumber = temp
        End If

        If thirdNumber > secondNumber Then
            temp = secondNumber
            secondNumber = thirdNumber
            thirdNumber = temp
        End If

        If secondNumber > firstNumber Then
            temp = firstNumber
            firstNumber = secondNumber
            secondNumber = temp
        End If
    End Sub

End Class
