Public Class Form1
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim deckOfCards(51) As String
        Dim suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        For i As Integer = 0 To 3
            For j As Integer = 2 To 10
                deckOfCards(i * 13 + j) = j & " of " & suits(i)
            Next
            deckOfCards(i * 13 + 0) = "King of " & suits(i)
            deckOfCards(i * 13 + 1) = "Ace of " & suits(i)
            deckOfCards(i * 13 + 11) = "Jack of " & suits(i)
            deckOfCards(i * 13 + 12) = "Queen of " & suits(i)
        Next
        Dim a(51) As String, k As Integer
        Dim randomNumber As New Random()
        a(0) = deckOfCards(0)
        For i As Integer = 1 To 51
            k = randomNumber.Next(0, i + 1)
            a(i) = a(k)
            a(k) = deckOfCards(i)
        Next
        lstOutput.Items.Clear()
        For i As Integer = 0 To 4
            lstOutput.Items.Add(a(i))
        Next
    End Sub
End Class
