Public Class Form1
    Dim rm(,) As Double = {{0, 2054, 802, 738},
    {2054, 0, 2786, 2706},
    {802, 2786, 0, 100},
    {738, 2706, 100, 0}}

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim row, col As Integer
        row = CInt(mtbOrig.Text)
        col = CInt(mtbDest.Text)
        If (row >= 1 And row <= 4) And (col >= 1 And col <= 4) Then
            txtMiles.Text = CStr(rm(row - 1, col - 1))
        Else
            MessageBox.Show("Origin and Destination must be numbers from 1 to 4", "Error")
        End If
    End Sub
End Class
