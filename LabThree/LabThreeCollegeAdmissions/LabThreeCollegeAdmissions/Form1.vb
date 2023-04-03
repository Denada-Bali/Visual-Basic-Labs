Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gpa As Double = CDbl(TextBox1.Text)
        Dim gpaPoints As Integer = CInt(gpa * 20)
        Dim SATp As Integer = 0
        Dim qualityP As Integer = 0
        Dim difficultyP As Integer = 0
        Dim otherP As Integer = 0 ' variable to hold total score of items in lower half of form
        Dim geographyP As Integer = 0
        Dim alumniP As Integer = 0
        Dim essayP As Integer = 0
        Dim leadershipP As Integer = 0
        Dim miscllP As Integer = 0
        Dim totalScore As Integer = 0
        TextBox2.Text = gpaPoints.ToString

        If (RadioButton1.Checked = True) Then
            SATp = 0
        ElseIf (RadioButton2.Checked = True) Then
            SATp = 6
        ElseIf (RadioButton3.Checked = True) Then
            SATp = 10
        ElseIf (RadioButton4.Checked = True) Then
            SATp = 11
        ElseIf (RadioButton5.Checked = True) Then
            SATp = 12
        End If

        ' High school quality
        If (RadioButton6.Checked = True) Then
            qualityP = 0
        ElseIf (RadioButton7.Checked = True) Then
            qualityP = 2
        ElseIf (RadioButton8.Checked = True) Then
            qualityP = 4
        ElseIf (RadioButton9.Checked = True) Then
            qualityP = 6
        ElseIf (RadioButton10.Checked = True) Then
            qualityP = 8
        ElseIf (RadioButton11.Checked = True) Then
            qualityP = 10
        End If

        ' Difficulty of curriculum
        If (RadioButton12.Checked = True) Then
            difficultyP = -4
        ElseIf (RadioButton13.Checked = True) Then
            difficultyP = -2
        ElseIf (RadioButton14.Checked = True) Then
            difficultyP = 0
        ElseIf (RadioButton15.Checked = True) Then
            difficultyP = 2
        ElseIf (RadioButton16.Checked = True) Then
            difficultyP = 4
        ElseIf (RadioButton17.Checked = True) Then
            difficultyP = 6
        ElseIf (RadioButton18.Checked = True) Then
            difficultyP = 8
        End If

        ' Geography points
        If (CheckBox1.Checked = True) Then
            geographyP = 10
        Else
            geographyP = 0
        End If

        ' Alumni points
        If (CheckBox4.Checked = True) Then
            alumniP += 4
        End If
        If (CheckBox5.Checked = True) Then
            alumniP += 1
        End If

        ' Essay points
        If (RadioButton19.Checked = True) Then
            essayP = 1
        ElseIf (RadioButton20.Checked = True) Then
            essayP = 2
        ElseIf (RadioButton21.Checked = True) Then
            essayP = 3
        End If

        ' Leadership points
        If (CheckBox6.Checked = True) Then
            leadershipP += 1
        End If
        If (CheckBox7.Checked = True) Then
            leadershipP += 2
        End If
        If (CheckBox8.Checked = True) Then
            leadershipP += 5
        End If

        ' Miscellaneous points
        If (RadioButton22.Checked = True) Then
            miscllP = 20
        ElseIf (RadioButton23.Checked = True) Then
            miscllP = 5
        ElseIf (RadioButton24.Checked = True) Then
            miscllP = 20
        ElseIf (RadioButton25.Checked = True) Then
            miscllP = 20
        End If

        ' The total score and admissions decision
        otherP = geographyP + alumniP + essayP + leadershipP + miscllP
        If (otherP > 40) Then
            otherP = 40
        End If
        totalScore = gpaPoints + SATp + qualityP + difficultyP + otherP
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Total Score: " & totalScore)
        ListBox1.Items.Add(" ")
        If (totalScore >= 100) Then
            ListBox1.Items.Add("Admitted")
        Else
            ListBox1.Items.Add("Rejected")
        End If
    End Sub
End Class
