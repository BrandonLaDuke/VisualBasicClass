Public Class bladukeWeek2Homework

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim result As Integer
        Dim firstNum As Integer
        Dim secondNum As Integer

        result = Val(firstNum) + Val(secondNum)
        resultBox.Text = Val(firstNum) & " + " & Val(secondNum) & " = " & result
    End Sub

    Private Sub subtract_Click(sender As Object, e As EventArgs) Handles subtract.Click
        Dim result As Integer
        Dim firstNum As Integer
        Dim secondNum As Integer

        result = Val(firstNum) - Val(secondNum)
        resultBox.Text = Val(firstNum) & " - " & Val(secondNum) & " = " & result
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        Dim result As Integer
        Dim firstNum As Integer
        Dim secondNum As Integer

        result = Val(firstNum) * Val(secondNum)
        resultBox.Text = Val(firstNum) & " X " & Val(secondNum) & " = " & result
    End Sub
End Class
