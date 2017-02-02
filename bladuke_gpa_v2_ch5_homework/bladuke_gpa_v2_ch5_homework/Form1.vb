Public Class Form1
    Dim total As Double
    Dim numCredits As Integer

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        total += QualityPoints()
        numCredits += CInt(mtbCredits.Text)
        grades.Clear()
        mtbCredits.Clear()
        grades.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtGPA.Text = (total / numCredits).ToString("N1")
    End Sub

    Function QualityPoints() As Integer
        Dim numGrade As Integer
        Dim credits As Integer
        Dim qualPoints As Integer
        Select Case grades.Text
            Case "A"
                numGrade = 4
            Case "B"
                numGrade = 3
            Case "C"
                numGrade = 2
            Case "D"
                numGrade = 1
            Case Else
                numGrade = 0
        End Select
        qualPoints = numGrade * credits
        Return qualPoints
    End Function
End Class
