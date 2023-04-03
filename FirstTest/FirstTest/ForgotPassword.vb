Imports Microsoft.VisualBasic.Logging

Public Class ForgotPassword
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New Form1()

        Me.Hide()
        oForm.ShowDialog()
    End Sub
End Class