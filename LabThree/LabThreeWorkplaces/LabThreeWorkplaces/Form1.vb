Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If person_lb.SelectedIndex = workplace_lb.SelectedIndex Then

        '    result_tb.Text = "Yes"
        'Else
        '    result_tb.Text = "No"

        'End If


        If person_lb.SelectedIndex = -1 Or workplace_lb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a person and a workplace before clicking the button.")
        Else
            If (person_lb.SelectedItem.ToString() = "Bruce Wayne" And workplace_lb.SelectedItem.ToString() = "Wayne Enterprises") Or
               (person_lb.SelectedItem.ToString() = "Clarck Kent" And workplace_lb.SelectedItem.ToString() = "Daily Planet") Or
               (person_lb.SelectedItem.ToString() = "Peter Parker" And workplace_lb.SelectedItem.ToString() = "Daily Bugle") Or
               (person_lb.SelectedItem.ToString() = "Rick Blaine" And workplace_lb.SelectedItem.ToString() = "Rick's American Cafe") Or
               (person_lb.SelectedItem.ToString() = "Willie Wonka" And workplace_lb.SelectedItem.ToString() = "Chocolate Factory") Then
                result_tb.Text = "Yes"
            Else
                result_tb.Text = "No"
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        person_lb.Sorted = True
        workplace_lb.Sorted = True
    End Sub
End Class
