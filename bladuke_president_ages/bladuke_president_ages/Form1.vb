Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim n As Integer = lstAges.Items.Count
        Dim sum As Double = 0
        For i As Integer = 0 To (n - 1)
            sum += CDbl(lstAges.Items(i))
        Next
        txtAvgAge.Text = (sum / n).ToString("N")
    End Sub
End Class
