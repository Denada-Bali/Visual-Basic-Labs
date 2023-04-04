Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim presentValue As Double
        Dim ratePerPeriod As Double
        Dim numberOfPayments As Integer
        Dim periodicPayment As Double
        Dim futureValue As Double

        If (ValidateInput() = False) Then
            Exit Sub
        End If

        If RadioButton1.Checked Then
            ratePerPeriod = CDbl(TextBox2.Text)
            numberOfPayments = CDbl(TextBox3.Text)
            periodicPayment = CDbl(TextBox4.Text)
            futureValue = CDbl(TextBox5.Text)
            TextBox1.Text = Financial.PV(ratePerPeriod, numberOfPayments, periodicPayment, -futureValue).ToString("C2")

        ElseIf RadioButton2.Checked Then
            presentValue = CDbl(TextBox1.Text)
            numberOfPayments = CDbl(TextBox3.Text)
            periodicPayment = CDbl(TextBox4.Text)
            futureValue = CDbl(TextBox5.Text)
            TextBox2.Text = (Financial.Rate(numberOfPayments, -periodicPayment, -presentValue, futureValue)).ToString("N5")

        ElseIf RadioButton3.Checked Then
            presentValue = CDbl(TextBox1.Text)
            ratePerPeriod = CDbl(TextBox2.Text)
            periodicPayment = CDbl(TextBox4.Text)
            futureValue = CDbl(TextBox5.Text)
            TextBox3.Text = Financial.NPer(ratePerPeriod, -periodicPayment, -presentValue, futureValue).ToString("N0")

        ElseIf RadioButton4.Checked Then
            presentValue = CDbl(TextBox1.Text)
            ratePerPeriod = CDbl(TextBox2.Text)
            numberOfPayments = CDbl(TextBox3.Text)
            futureValue = CDbl(TextBox5.Text)
            TextBox4.Text = (Financial.Pmt(ratePerPeriod, numberOfPayments, -presentValue, futureValue) * -1).ToString("N2")

        ElseIf RadioButton5.Checked Then
            presentValue = CDbl(TextBox1.Text)
            ratePerPeriod = CDbl(TextBox2.Text)
            numberOfPayments = CDbl(TextBox3.Text)
            periodicPayment = CDbl(TextBox4.Text)
            TextBox5.Text = Financial.FV(ratePerPeriod, numberOfPayments, -periodicPayment, -presentValue).ToString("C2")

        End If
    End Sub

    Private Function ValidateInput() As Boolean

        If RadioButton1.Checked And IsNumeric(TextBox2.Text) _
            And IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) _
            And IsNumeric(TextBox1.Text) Then

            Return True

        ElseIf RadioButton2.Checked And IsNumeric(TextBox1.Text) _
            And IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) _
            And IsNumeric(TextBox1.Text) Then

            Return True

        ElseIf RadioButton3.Checked And IsNumeric(TextBox1.Text) _
            And IsNumeric(TextBox2.Text) And IsNumeric(TextBox4.Text) _
            And IsNumeric(TextBox1.Text) Then

            Return True

        ElseIf RadioButton4.Checked And IsNumeric(TextBox1.Text) _
            And IsNumeric(TextBox2.Text) And IsNumeric(TextBox4.Text) _
            And IsNumeric(TextBox1.Text) Then

            Return True

        ElseIf RadioButton5.Checked And IsNumeric(TextBox1.Text) _
            And IsNumeric(TextBox2.Text) And IsNumeric(TextBox4.Text) _
            And IsNumeric(TextBox3.Text) Then

            Return True

        End If

        MessageBox.Show("Input Data does not meet the requirements!", "Information")
        Return False
    End Function


End Class
