Public Class Exercise43Form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oForm As New Exercise35Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub

    Private Sub buttons(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        Me.TextBox1.Text += "You just clicked on a button."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New Exercise44Form()

        Me.Hide()
        oForm.ShowDialog()
    End Sub
End Class