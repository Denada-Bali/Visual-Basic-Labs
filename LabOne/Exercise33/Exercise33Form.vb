Public Class Exercise33Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.TextAlign = HorizontalAlignment.Left



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oForm As New Exercise35Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub
End Class
