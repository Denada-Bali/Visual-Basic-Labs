Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Public Class Form1

    Dim studentNames(14) As String ' One-dimensional array to store student names
    Dim examGrades(14, 2) As Double ' Two-dimensional array to store exam grades

    Dim count As Integer = 0 ' Counter for number of students added

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Check if the count of students has reached 20
        If count >= 20 Then
            Button1.Enabled = False  ' Then disable the "Add" button
            Return
        End If

        studentNames(count) = nameTextBox.Text  ' this line will add student name to array


        examGrades(count, 0) = CDbl(exam1TextBox.Text)  ' here im adding exam grades to array
        examGrades(count, 1) = CDbl(exam2TextBox.Text)
        examGrades(count, 2) = CDbl(exam3TextBox.Text)


        count += 1  ' Increment student count


        nameTextBox.Clear()
        exam1TextBox.Clear()
        exam2TextBox.Clear()
        exam3TextBox.Clear()

        nameTextBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        reportTextBox.Clear()

        ' Loop through each student
        For i As Integer = 0 To count - 1
            ' Here we are calculating semester average for student
            Dim semesterAverage As Double = (examGrades(i, 0) + examGrades(i, 1) + examGrades(i, 2)) / 3

            reportTextBox.AppendText(studentNames(i) & " - Semester Average: " & semesterAverage.ToString("N2") & vbCrLf)

            Dim exam1Median, exam2Median, exam3Median As Double
            Dim examGradesList As New List(Of Double)

            ' Add exam grades to list for sorting
            examGradesList.Add(examGrades(i, 0))
            examGradesList.Add(examGrades(i, 1))
            examGradesList.Add(examGrades(i, 2))

            examGradesList.Sort()

            ' Calculate median for each exam
            If examGradesList.Count Mod 2 = 0 Then ' Even number of grades
                exam1Median = (examGradesList(examGradesList.Count \ 2 - 1) + examGradesList(examGradesList.Count \ 2)) / 2
                exam2Median = (examGradesList(examGradesList.Count \ 2) + examGradesList(examGradesList.Count \ 2 + 1)) / 2
                exam3Median = (examGradesList(examGradesList.Count \ 2 + 1) + examGradesList(examGradesList.Count \ 2 + 2)) / 2
            Else ' Odd number of grades
                exam1Median = examGradesList(examGradesList.Count \ 2)
                exam2Median = examGradesList(examGradesList.Count \ 2)
                exam3Median = examGradesList(examGradesList.Count \ 2)
            End If

            reportTextBox.AppendText("    Exam 1 Median: " & exam1Median.ToString("N2") & vbCrLf)
            reportTextBox.AppendText("    Exam 2 Median: " & exam2Median.ToString("N2") & vbCrLf)
            reportTextBox.AppendText("    Exam 3 Median: " & exam3Median.ToString("N2") & vbCrLf)

        Next i

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Clear student names and exam grades arrays
        ReDim studentNames(14)  'ReDim is used to re-size an array at run-time.
        ReDim examGrades(14, 2)

        ' Reset count variable and enable "Add" button
        count = 0
        Button1.Enabled = True

        reportTextBox.Clear()
    End Sub
End Class
