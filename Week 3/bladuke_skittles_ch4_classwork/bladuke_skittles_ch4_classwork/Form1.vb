Public Class Form1
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Dim message As String
        message = "Skittles is an old form of bowling in which a wooden disk is used to knock down nine pins arranged in a square."
        If txtYN.Text.ToUpper = "N" Then
            MessageBox.Show(message, "Definition")
        End If
        txtOutput.Text = "Life ain't all beer and skittles." & " - Du Maurier (1894)"
    End Sub
End Class
