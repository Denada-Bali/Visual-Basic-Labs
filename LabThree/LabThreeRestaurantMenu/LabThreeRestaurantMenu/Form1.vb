Public Class Form1

    Dim totalCost As Double = 0
    Dim burgerCost As Double = 0
    Dim friesCost As Double = 0
    Dim drinkCost As Double = 0

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            GroupBox1.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Label1.Visible = True
            TextBox1.Visible = True
        Else
            GroupBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            TextBox1.Visible = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            GroupBox2.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Label1.Visible = True
            TextBox1.Visible = True
        Else
            GroupBox2.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked Then
            GroupBox3.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Label1.Visible = True
            TextBox1.Visible = True
        Else
            GroupBox3.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalCost = 0
        If CheckBox1.Checked = True Then
            If RadioButton1.Checked = True Then
                burgerCost = 4.19
            ElseIf (RadioButton2.Checked = True) Or (RadioButton3.Checked = True) Then
                burgerCost = 4.79
            ElseIf (RadioButton4.Checked = True) Then
                burgerCost = 5.39
            End If
            totalCost = totalCost + burgerCost
        End If

        If CheckBox2.Checked = True Then
            If RadioButton5.Checked = True Then
                friesCost = 2.39
            ElseIf (RadioButton6.Checked = True) Then
                friesCost = 3.09
            ElseIf (RadioButton7.Checked = True) Then
                friesCost = 4.99
            End If
            totalCost = totalCost + friesCost
        End If

        If CheckBox3.Checked = True Then
            If RadioButton8.Checked = True Then
                drinkCost = 1.69
            ElseIf RadioButton9.Checked = True Then
                drinkCost = 1.49
            End If
            totalCost = totalCost + drinkCost
        End If

        TextBox1.Text = CStr(totalCost.ToString("C"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False

        RadioButton8.Checked = False
        RadioButton9.Checked = False

    End Sub


End Class
