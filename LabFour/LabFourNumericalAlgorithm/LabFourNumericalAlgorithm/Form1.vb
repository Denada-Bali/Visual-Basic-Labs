Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputNumber, reversedNumber, difference, reversedDifference As Integer
        inputNumber = CInt(TextBox1.Text)

        If verifyIfIsValidNumber(inputNumber) Then
            reversedNumber = reverseTheDigitsOfTheNumber(inputNumber)
            difference = inputNumber - reversedNumber
            reversedDifference = reverseTheDigitsOfTheNumber(difference)
            TextBox2.Text = CStr(difference + reversedDifference)
        End If
    End Sub


    Private Function reverseTheDigitsOfTheNumber(num As Integer) As Integer
        Dim first, second, third As Integer

        first = num \ 100
        second = (num Mod 100) \ 10
        third = (num Mod 10)

        Return (third * 100 + second * 10 + first)
    End Function

    Private Function verifyIfIsValidNumber(num As Integer) As Boolean
        Dim first, second, third As Integer
        num = CInt(TextBox1.Text)

        If num >= 100 And num <= 999 Then
            first = num \ 100
            second = (num Mod 100) \ 10
            third = (num Mod 10)

            If (first > second And second > third) Then
                Return True
            End If
        End If

        MessageBox.Show("The number must have three digits and the digits should be in descending order.")
        Return False
    End Function
End Class
