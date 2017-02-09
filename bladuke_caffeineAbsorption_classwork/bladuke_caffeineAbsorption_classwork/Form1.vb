Public Class Form1
    Const CAFFEINE_PER_CUP As Double = 130
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Double = CAFFEINE_PER_CUP
        Dim hrs As Integer
        Do Until amount <= CAFFEINE_PER_CUP / 2
            amount = 0.87 * amount
            hrs += 1
        Loop
        txt65.Text = hrs & " hours"
        amount = CAFFEINE_PER_CUP
        For i As Integer = 1 To 24
            amount = 0.87 * amount
        Next
        txtOne24.Text = amount.ToString("N") & " mg."
        amount = CAFFEINE_PER_CUP
        For i As Integer = 1 To 24
            amount = 0.87 * amount + CAFFEINE_PER_CUP
        Next
        txtMany24.Text = amount.ToString("N") & " mg."
    End Sub
End Class
