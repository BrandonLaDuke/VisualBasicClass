Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim num1, num2, largestValue As Double
        num1 = CDbl(firstNumber.Text)
        num2 = CDbl(secondNumber.Text)
        If num1 > num2 Then
            largestValue = num1
        Else
            largestValue = num2
        End If
        txtResult.Text = "The Largest value is " & largestValue & "."
    End Sub
End Class
