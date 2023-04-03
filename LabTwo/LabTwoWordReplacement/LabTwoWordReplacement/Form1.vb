Public Class Form1
    Dim sentence As String
    Dim wordToReplace As String
    Dim wordReplacement As String
    Dim finalSentence As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentence = TextBox1.Text

        wordReplacement = TextBox3.Text

        wordToReplace = TextBox2.Text

        finalSentence = Replace(sentence, wordToReplace, wordReplacement)

        TextBox4.Text = finalSentence
    End Sub
End Class
