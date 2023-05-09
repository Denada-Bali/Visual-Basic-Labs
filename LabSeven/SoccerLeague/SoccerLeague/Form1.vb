Public Structure Teams
    Dim name As String
    Dim wins As Integer
End Structure

Public Class Form1
    Const numTeams = 6
    Dim teamArr(numTeams - 1) As Teams
    Dim data(,) As Integer = {
        {-1, 1, 1, 0, 0, 1},
        {0, -1, 1, 1, 0, 0},
        {0, 0, -1, 0, 1, 1},
        {1, 0, 1, -1, 1, 1},
        {1, 1, 0, 0, -1, 1},
        {0, 1, 0, 0, 0, -1}
    }

    Private Sub AssignNames()
        teamArr(0).name = "Jazz"
        teamArr(1).name = "Jets"
        teamArr(2).name = "Owls"
        teamArr(3).name = "Rams"
        teamArr(4).name = "Cubs"
        teamArr(5).name = "Zips"
    End Sub

    Private Sub CalculateWins()
        For r = 0 To numTeams - 1
            For c = 0 To numTeams - 1
                If data(r, c) = 1 Then
                    teamArr(r).wins += 1
                End If
            Next
        Next

        Dim query = From team In teamArr
                    Let Name As String = team.name
                    Let Wins As Integer = team.wins
                    Order By Wins Descending
                    Select Name, Wins

        dgvOutput.DataSource = query.ToList
        dgvOutput.Columns(0).HeaderText = "Team"
        dgvOutput.Columns(1).HeaderText = "Wins"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateWins()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i = 0 To numTeams - 1
            teamArr(i).wins = 0
        Next
        dgvOutput.DataSource = Nothing
        dgvOutput.Rows.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignNames()
        CalculateWins()
    End Sub
End Class



