Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = lstStates.Items.Count
        For i As Integer = (n - 1) To (n - 10) Step -1
            lstLastTen.Items.Add(lstStates.Items(i))
        Next
    End Sub
End Class
