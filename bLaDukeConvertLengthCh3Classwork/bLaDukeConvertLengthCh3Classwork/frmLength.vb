Public Class frmLength
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim TotalInches As Integer
        Dim feet As Integer
        Dim inches As Integer
        TotalInches = 41
        feet = TotalInches / 12
        inches = TotalInches Mod 12
        lstResults.Items.Add(feet)
        lstResults.Items.Add(inches)
    End Sub
End Class
