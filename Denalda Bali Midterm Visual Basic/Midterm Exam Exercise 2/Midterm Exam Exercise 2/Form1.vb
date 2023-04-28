Public Class Form1
    Dim computer As Double
    Dim printers As Double
    Dim accessories As Double
    Dim totalCost As Double

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Visible = True
            TextBox2.Visible = False
        Else GroupBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            GroupBox2.Visible = True
            TextBox6.Visible = False
        Else GroupBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            GroupBox3.Visible = True
            TextBox8.Visible = False
        Else GroupBox3.Visible = False
        End If
    End Sub

    Function computerPrice() As Double
        totalCost = 0

        If CheckBox1.Checked = True Then
            If RadioButton1.Checked = True Then
                computer = 4.19
            ElseIf RadioButton2.Checked = True Then
                computer = 4.79
            ElseIf RadioButton3.Checked = True Then
                computer = 5.39
            End If
            totalCost = computer * CInt(TextBox2.Text)
        End If

        Return totalCost
    End Function


    Function computerPriceAndName() As String

        If RadioButton1.Checked = True Then
            computer = 4.19
            Return "  Item and Price :   " & CStr(RadioButton1.Text) & " $" & computer
        ElseIf (RadioButton2.Checked = True) Then
            computer = 4.79
            Return "  Item and Price :   " & CStr(RadioButton2.Text) & " $" & computer
        ElseIf (RadioButton3.Checked = True) Then
            computer = 5.39
            Return "  Item and Price :   " & CStr(RadioButton3.Text) & " $" & computer
        Else
            Return ""
        End If
    End Function

    Function printerPrice() As Double
        totalCost = 0

        If CheckBox2.Checked = True Then
            If RadioButton5.Checked = True Then
                printers = 2.39 * CInt(TextBox6.Text)
            ElseIf (RadioButton6.Checked = True) Then
                printers = 3.09 * CInt(TextBox6.Text)
            ElseIf (RadioButton7.Checked = True) Then
                printers = 4.99 * CInt(TextBox6.Text)
            End If
            totalCost = printers * CInt(TextBox6.Text)
            Return totalCost

        End If
    End Function

    Function printerPriceAndName() As String

        If RadioButton5.Checked = True Then
            printers = 2.39
            Return "  Item and Price :   " & CStr(RadioButton5.Text) & " $" & printers
        ElseIf (RadioButton6.Checked = True) Then
            printers = 3.09
            Return "  Item and Price :   " & CStr(RadioButton6.Text) & " $" & printers
        ElseIf (RadioButton7.Checked = True) Then
            printers = 4.99
            Return "  Item and Price :   " & CStr(RadioButton7.Text) & " $" & printers
        Else
            Return ""
        End If
    End Function

    Function accessoriesPrice() As Double
        totalCost = 0


        If CheckBox3.Checked = True Then
            If RadioButton8.Checked = True Then
                accessories = 1.69
            ElseIf RadioButton9.Checked = True Then
                accessories = 1.49
            ElseIf RadioButton10.Checked = True Then
                accessories = 4.99
            End If
            totalCost = accessories * CInt(TextBox8.Text)
            Return totalCost

        End If

    End Function


    Function accessoriesPriceAndName() As String

        If RadioButton8.Checked = True Then
            accessories = 1.69
            Return "   Item and Price :   " & CStr(RadioButton8.Text) & " $" & accessories
        ElseIf (RadioButton9.Checked = True) Then
            accessories = 1.49
            Return "   Item and Price :   " & CStr(RadioButton9.Text) & " $" & accessories
        ElseIf (RadioButton10.Checked = True) Then
            accessories = 4.99
            Return "   Item and Price :   " & CStr(RadioButton10.Text) & " $" & accessories
        Else
            Return ""
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim totalCost As Decimal = 0

        If CheckBox1.Checked = True Then
            Dim quantityOfComputers As Integer = TextBox2.Text
            TextBox1.Text += "Computers " & vbNewLine & CStr(computerPriceAndName()) & vbNewLine & "  Quantity :   " & quantityOfComputers & vbNewLine & "  Total Cost of Computer :   $" & computerPrice() & vbNewLine
            totalCost += computerPrice() * quantityOfComputers
        End If

        If CheckBox2.Checked = True Then
            Dim quantityOfPrinters As Integer = TextBox6.Text
            TextBox1.Text += "Printers " & vbNewLine & CStr(printerPriceAndName()) & vbNewLine & "  Quantity :   " & quantityOfPrinters & vbNewLine & "  Total Cost of Printer :   $" & printerPrice() & vbNewLine
            totalCost += printerPrice() * quantityOfPrinters
        End If

        If CheckBox3.Checked = True Then
            Dim quantityOfAccessories As Integer = TextBox8.Text
            TextBox1.Text += "Accessories " & vbNewLine & CStr(accessoriesPriceAndName()) & vbNewLine & "  Quantity :   " & quantityOfAccessories & vbNewLine & "  Total Cost of Accessories :   $" & accessoriesPrice() & vbNewLine
            totalCost += accessoriesPrice() * quantityOfAccessories
        End If

        TextBox1.Text &= "Total of All: $" & totalCost

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox8.Clear()

        CheckBox1.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton3.Checked = False

        CheckBox2.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False

        CheckBox3.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged
        Select Case sender.Name
            Case "RadioButton1", "RadioButton2", "RadioButton3"
                TextBox2.Visible = sender.Checked
            Case "RadioButton5", "RadioButton6", "RadioButton7"
                TextBox6.Visible = sender.Checked
            Case "RadioButton8", "RadioButton9", "RadioButton10"
                TextBox8.Visible = sender.Checked
        End Select
    End Sub

End Class
