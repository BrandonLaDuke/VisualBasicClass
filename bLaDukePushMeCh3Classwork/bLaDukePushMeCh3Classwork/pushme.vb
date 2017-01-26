Public Class pushme
    Dim numTimes As Integer = 100
    Private Sub btnPushme_Click(sender As Object, e As EventArgs) Handles btnPushme.Click
        numTimes -= 1
        TextBox1.Text = "" & numTimes

    End Sub
End Class
