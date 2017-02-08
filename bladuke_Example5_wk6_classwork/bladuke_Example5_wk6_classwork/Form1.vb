Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim balance As Decimal, numYears As Integer = 0
        balance = CDec(txtAmount.Text)
        Do While balance < 1000000
            balance += 0.06 * balance
            numYears += 1
        Loop
        txtWhen.Text = "In " & numYears & " years you will have a million dollars."
    End Sub
End Class
