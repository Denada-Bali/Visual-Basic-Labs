Public Class Exercise44Form

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox2.Text = TextBox1.Text + TextBox2.Text
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox1.Text = TextBox2.Text + TextBox1.Text
        TextBox2.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oForm As New Exercise43Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub
End Class