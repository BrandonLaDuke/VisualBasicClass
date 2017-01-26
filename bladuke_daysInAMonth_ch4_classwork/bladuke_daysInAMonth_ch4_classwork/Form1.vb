Public Class Form1
    Private Sub btnDays_Click(sender As Object, e As EventArgs) Handles btnDays.Click
        Dim daysInMonth As String
        Select Case lstMonths.Text
            Case "September", "April", "June", "November"
                daysInMonth = "30"
            Case "February"
                daysInMonth = "28 or 29"
            Case Else
                daysInMonth = "31"
        End Select
        txtNumDays.Text = daysInMonth
    End Sub
End Class
