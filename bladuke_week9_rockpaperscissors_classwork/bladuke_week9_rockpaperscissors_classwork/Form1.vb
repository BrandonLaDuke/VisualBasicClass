Public Class Form1
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim choices() As String = {"Rock", "Paper", "Scissors"}
        Dim randomNumber As New Random
        Dim n As Integer
        n = randomNumber.Next(0, 3) ' Randomly select 0, 1, or 2
        txtSelection.Text = choices(n)
    End Sub
End Class
