Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numberOfChair, numberOfSofa, salesTax, TotalPrice, price As Double

        numberOfChair = TextBox4.Text
        numberOfSofa = TextBox5.Text

        price = numberOfChair * 350 + numberOfSofa * 925

        salesTax = price * 0.05

        TotalPrice = price + salesTax

        ListBox1.Items.Clear()
        ListBox1.Items.Add("Invoice Number:  " & invoiceNumber())
        ListBox1.Items.Add(" ")

        ListBox1.Items.Add("Name:  " & FormatName())
        ListBox1.Items.Add("Address:  " & TextBox2.Text)
        ListBox1.Items.Add("City:  " & TextBox3.Text)
        ListBox1.Items.Add(" ")

        ListBox1.Items.Add("Number Of Chairs:  " & numberOfChair)
        ListBox1.Items.Add("Number Of Sofas:  " & numberOfSofa)
        ListBox1.Items.Add(" ")

        ListBox1.Items.Add(vbTab & "Price: " & vbTab & price.ToString("C"))
        ListBox1.Items.Add("      Sales Tax: " & vbTab & salesTax.ToString("C"))
        ListBox1.Items.Add(vbTab & vbTab & "-------------")
        ListBox1.Items.Add("Total Price: " & vbTab & TotalPrice.ToString("C"))

    End Sub

    Private Function invoiceNumber() As String
        Dim nameParts As String() = TextBox1.Text.Trim.Split(","c)

        Dim lastNameInitial As String = nameParts(0).Trim().Substring(0, 1)
        Dim firstNameInitial As String = nameParts(1).Trim().Substring(0, 1)

        Dim zipCode As String = TextBox3.Text.Substring(TextBox3.Text.Length - 4)

        ' Dim zipCode As String = TextBox3.Text.Substring(Math.Max(0, TextBox3.Text.Length - 4))

        Return $"{lastNameInitial}{firstNameInitial}{zipCode}"
    End Function

    Private Function FormatName() As String

        Dim fullName As String = TextBox1.Text.Replace(",", "")
        Dim nameParts As String() = fullName.Split(" "c)

        Dim firstName As String = nameParts(1)
        Dim lastName As String = nameParts(0)

        Dim formattedName As String = firstName & " " & lastName
        Return formattedName
    End Function

End Class
