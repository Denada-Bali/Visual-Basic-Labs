Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim km As Double
    Dim m As Double
    Dim cm As Double
    Dim totalInches As Double
    Dim totalMetres As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        totalInches = CDbl(TextBox4.Text) + CDbl(TextBox3.Text) * 12 + CDbl(TextBox2.Text) * 36 + CDbl(TextBox1.Text) * 63360

        totalMetres = totalInches / 39.37

        km = CInt(totalMetres / 1000)

        m = CInt((TextBox3.Text * 12 + TextBox2.Text * 36) / 39.37)

        cm = Math.Round(CDbl(TextBox4.Text / 39.37), 1)

        TextBox5.Text = "The metirc length in kilometers is " + CStr(km) + " the number of meters is " + CStr(m) + " the number of centimeters  is " + CStr(cm)

    End Sub
End Class
