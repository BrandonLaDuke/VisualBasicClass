Public Class Form1
    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim pop As Double = 300000
        For yr As Integer = 2015 To 2019
            lstPopulation.Items.Add(yr & "       " & pop)
            pop.ToString("NO")
            pop += 0.03 * pop
        Next
    End Sub
End Class
