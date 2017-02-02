Public Class GPA

    'Init variables
    Dim grade1, grade2, grade3, grade4, totalGrades, cr1, cr2, cr3, cr4, totalHours, gpa As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Calculate first grade
        If class1Grade.Text.ToUpper = "A" Then
            grade1 = 4
        ElseIf class1Grade.Text.ToUpper = "B" Then
            grade1 = 3
        ElseIf class1Grade.Text.ToUpper = "C" Then
            grade1 = 2
        ElseIf class1Grade.Text.ToUpper = "D" Then
            grade1 = 1
        ElseIf class1Grade.Text.ToUpper = "F" Then
            grade1 = 0
        End If

        'Calculate second grade
        If class2Grade.Text.ToUpper = "A" Then
            grade2 = 4
        ElseIf class2Grade.Text.ToUpper = "B" Then
            grade2 = 3
        ElseIf class2Grade.Text.ToUpper = "C" Then
            grade2 = 2
        ElseIf class2Grade.Text.ToUpper = "D" Then
            grade2 = 1
        ElseIf class2Grade.Text.ToUpper = "F" Then
            grade2 = 0
        End If

        'Calculate third grade
        If class3Grade.Text.ToUpper = "A" Then
            grade3 = 4
        ElseIf class3Grade.Text.ToUpper = "B" Then
            grade3 = 3
        ElseIf class3Grade.Text.ToUpper = "C" Then
            grade3 = 2
        ElseIf class3Grade.Text.ToUpper = "D" Then
            grade3 = 1
        ElseIf class3Grade.Text.ToUpper = "F" Then
            grade3 = 0
        End If

        'Calculate fourth grade
        If class4Grade.Text.ToUpper = "A" Then
            grade4 = 4
        ElseIf class4Grade.Text.ToUpper = "B" Then
            grade4 = 3
        ElseIf class4Grade.Text.ToUpper = "C" Then
            grade4 = 2
        ElseIf class4Grade.Text.ToUpper = "D" Then
            grade4 = 1
        ElseIf class4Grade.Text.ToUpper = "F" Then
            grade4 = 0
        End If

        'Calculate GPA
        totalGrades = grade1 + grade2 + grade3 + grade4
        totalHours = cr1 + cr2 + cr3 + cr4
        gpa = (totalGrades * totalHours) / totalHours
        gpa.ToString()
        'Print GPA
        txtGPA.Text = gpa
    End Sub
End Class
