Imports System.IO

Public Class Form1

    Dim filePath As String = Path.Combine(Application.StartupPath, "Final.txt")
    Dim temporaryGradesFile() As String = IO.File.ReadAllLines(filePath)
    Dim grades(temporaryGradesFile.Count - 1) As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim counter As Integer = 0
        For Each grade As Integer In temporaryGradesFile
            grades(counter) = grade
            counter += 1
        Next

        Dim gradeQuery = From grade In grades
                         Select grade

        TextBox1.Text = (gradeQuery.Average / 100).ToString("P")

        Dim secondGradeQuery = From grade In grades
                               Where grade > gradeQuery.Average
                               Select grade
        TextBox2.Text = (secondGradeQuery.Count / grades.Count).ToString("P")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
