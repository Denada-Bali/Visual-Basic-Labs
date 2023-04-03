Public Class Exercise35Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.BackColor = Color.Red
        TextBox1.TextAlign = HorizontalAlignment.Right


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.BackColor = Color.Blue
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ForeColor = Color.White
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ForeColor = Color.Yellow
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New Exercise43Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oForm As New Exercise33Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub
End Class