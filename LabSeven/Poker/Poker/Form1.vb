Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim arystrCards(5) As String 'Array to store the rank of each card
    Dim arychkCards(5) As String 'Array to store the suit of each card
    Dim aryintCards(4, 13) As Integer 'Array to store the count of each rank and suit of cards

    Dim handType As String 'Variable to store the type of hand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckHand()
    End Sub

    Private Function CheckHand() As String

        'Get user input for each card
        For i As Integer = 1 To 5
            arystrCards(i) = Me.Controls("txtCard" & i).Text.Trim()
            arychkCards(i) = Me.Controls("txtSuit" & i).Text.Trim()
        Next

        'Loop through the cards and count the number of each rank and suit
        For i As Integer = 1 To 5
            Select Case arystrCards(i)
                Case "Ace"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 0) += 1
                    aryintCards(4, 1) += 1
                Case "2"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 1) += 1
                    aryintCards(4, 2) += 1
                Case "3"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 2) += 1
                    aryintCards(4, 3) += 1
                Case "4"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 3) += 1
                    aryintCards(4, 4) += 1
                Case "5"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 4) += 1
                    aryintCards(4, 5) += 1
                Case "6"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 5) += 1
                    aryintCards(4, 6) += 1
                Case "7"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 6) += 1
                    aryintCards(4, 7) += 1
                Case "8"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 7) += 1
                    aryintCards(4, 8) += 1
                Case "9"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 8) += 1
                    aryintCards(4, 9) += 1
                Case "10"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 9) += 1
                    aryintCards(4, 10) += 1
                Case "Jack"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 10) += 1
                    aryintCards(4, 11) += 1
                Case "Queen"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 12) += 1
                    aryintCards(4, 12) += 1
                Case "King"
                    aryintCards(Array.IndexOf({"C", "D", "H", "S"}, arychkCards(i)), 13) += 1
                    aryintCards(4, 13) += 1
            End Select

        Next


        If IsFlush(aryintCards) And IsStraight(aryintCards) Then 'Straight Flush
            handType = "Straight Flush"
        ElseIf IsFourOfAKind(aryintCards) Then 'Four of a Kind
            handType = "Four of a Kind"
        ElseIf IsFullHouse(aryintCards) Then 'Full House
            handType = "Full House"
        ElseIf IsFlush(aryintCards) Then 'Flush
            handType = "Flush"
        ElseIf IsStraight(aryintCards) Then 'Straight
            handType = "Straight"
        ElseIf IsThreeOfAKind(aryintCards) Then 'Three of a Kind
            handType = "Three of a Kind"
        ElseIf IsTwoPairs(aryintCards) Then 'Two Pairs
            handType = "Two Pairs"
        ElseIf IsOnePair(aryintCards) Then 'One Pair
            handType = "One Pair"
        ElseIf IsNoneOfTheAbove(aryintCards) Then 'None of the above
            handType = "None of the above"
        End If

        txtOutput.Text = "The hand is a " + handType

        Return handType
    End Function

    Function IsFlush(ByVal aryCards As Integer(,)) As Boolean
        'Check if all cards have the same suit
        For i As Integer = 0 To 3
            Dim cnt As Integer = 0
            For j As Integer = 0 To 12
                If aryCards(i, j) = 1 Then
                    cnt += 1
                End If
            Next j
            If cnt = 5 Then
                Return True
            End If
        Next i
        'No flush found
        Return False
    End Function


    Function IsStraight(ByVal aryCards As Integer(,)) As Boolean
        ' Sort the cards by rank
        Dim sortedCards = aryCards.Cast(Of Integer)().OrderBy(Function(x) x).ToArray()
        ' Check for a straight
        If sortedCards(4) = 14 AndAlso sortedCards(0) = 2 AndAlso
       sortedCards(1) = 3 AndAlso sortedCards(2) = 4 AndAlso
       sortedCards(3) = 5 Then
            Return True ' Ace-low straight
        ElseIf sortedCards(4) - sortedCards(0) = 4 AndAlso
           sortedCards.Distinct().Count() = 5 Then
            Return True ' Straight
        Else
            Return False
        End If
    End Function


    Function IsStraightFlush(ByVal aryCards As Integer(,)) As Boolean
        Return IsFlush(aryCards) AndAlso IsStraight(aryCards)
    End Function


    Function IsFourOfAKind(ByVal aryCards As Integer(,)) As Boolean
        Dim i, j, cnt As Integer
        For j = 0 To 12
            cnt = 0
            For i = 0 To 3
                cnt += aryCards(i, j)
            Next
            If cnt = 4 Then
                Return True
            End If
        Next
        Return False
    End Function

    Function IsFullHouse(ByVal aryintCards As Integer(,)) As Boolean
        Dim i, j, cnt As Integer
        Dim bPair, bThreeOfAKind As Boolean
        bPair = False
        bThreeOfAKind = False

        For j = 0 To 12
            cnt = 0
            For i = 0 To 4
                If aryintCards(i, j) <> 0 Then
                    cnt += 1
                End If
            Next
            If cnt = 2 Then
                bPair = True
            ElseIf cnt = 3 Then
                bThreeOfAKind = True
            End If
        Next

        If bPair And bThreeOfAKind Then
            IsFullHouse = True
        Else
            IsFullHouse = False
        End If
    End Function

    Function IsThreeOfAKind(ByVal aryCards As Integer(,)) As Boolean
        Dim i, j, cnt As Integer
        For j = 0 To 12
            cnt = 0
            For i = 0 To 4
                If aryCards(i, j) = 1 Then
                    cnt += 1
                End If
            Next i
            If cnt = 3 Then
                Return True
            End If
        Next j
        Return False
    End Function

    Function IsTwoPairs(ByVal aryCards As Integer(,)) As Boolean
        Dim pairCount As Integer = 0

        For j As Integer = 0 To 12
            Dim count As Integer = 0
            For i As Integer = 0 To 4
                If aryCards(i, j) = 1 Then
                    count += 1
                End If
            Next

            If count = 2 Then
                pairCount += 1
            End If
        Next

        If pairCount = 2 Then
            Return True
        Else
            Return False
        End If
    End Function


    Function IsOnePair(ByVal aryCards As Integer(,)) As Boolean
        Dim i, j, cnt As Integer
        For j = 0 To 12
            cnt = 0
            For i = 0 To 4
                If aryCards(i, j) = 1 Then
                    cnt += 1
                End If
            Next
            If cnt = 2 Then
                Return True
            End If
        Next
        Return False
    End Function

    Function IsNoneOfTheAbove(ByVal aryCards As Integer(,)) As Boolean
        ' Check for all other conditions first
        If IsStraightFlush(aryCards) Or IsFourOfAKind(aryCards) Or IsFullHouse(aryCards) Or IsFlush(aryCards) _
        Or IsStraight(aryCards) Or IsThreeOfAKind(aryCards) Or IsTwoPairs(aryCards) Or IsOnePair(aryCards) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
