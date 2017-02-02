Public Class Form1
    Dim gpaScore As Double
    Dim totalGpa As Double
    Dim satScore, hsqScore, difScore, geoScore, aluScore, essayScore, lAndSScore, misScore, sum As Integer

    Private Sub txtGPA_Leave(sender As Object, e As EventArgs) Handles txtGPA.Leave
        weirdBox.Text = "[" & Str(20 * CDbl(txtGPA.Text)) & "]"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If sat1.Checked Then
            satScore = 0
        ElseIf sat2.Checked Then
            satScore = 6
        ElseIf sat3.Checked Then
            satScore = 10
        ElseIf sat4.Checked Then
            satScore = 11
        ElseIf sat5.Checked Then
            satScore = 12
        End If

        If hS1.Checked Then
            hsqScore = 0
        ElseIf hS2.Checked Then
            hsqScore = 2
        ElseIf hS3.Checked Then
            hsqScore = 4
        ElseIf hS4.Checked Then
            hsqScore = 6
        ElseIf hS5.Checked Then
            hsqScore = 8
        ElseIf hS6.Checked Then
            hsqScore = 10
        End If

        If dif1.Checked Then
            difScore = -4
        ElseIf dif2.Checked Then
            difScore = -2
        ElseIf dif3.Checked Then
            difScore = 0
        ElseIf dif4.Checked Then
            difScore = 2
        ElseIf dif5.Checked Then
            difScore = 4
        ElseIf dif6.Checked Then
            difScore = 6
        ElseIf dif7.Checked Then
            difScore = 8
        End If

        If dif1.Checked Then
            difScore = -4
        ElseIf dif2.Checked Then
            difScore = -2
        ElseIf dif3.Checked Then
            difScore = 0
        ElseIf dif4.Checked Then
            difScore = 2
        ElseIf dif5.Checked Then
            difScore = 4
        ElseIf dif6.Checked Then
            difScore = 6
        ElseIf dif7.Checked Then
            difScore = 8
        End If

        If geo1.Checked Then
            geoScore = 10
        End If

        If alu1.Checked Then
            aluScore = 4
        ElseIf alu2.Checked Then
            aluScore = 1
        End If

        If essay1.Checked Then
            essayScore = 1
        ElseIf essay2.Checked Then
            essayScore = 2
        ElseIf essay3.Checked Then
            essayScore = 3
        End If

        If lAndS1.Checked Then
            lAndSScore = 1
        ElseIf lAndS2.Checked Then
            lAndSScore = 2
        ElseIf lAndS3.Checked Then
            lAndSScore = 5
        End If

        If mis1.Checked Then
            misScore = 20
        ElseIf mis2.Checked Then
            misScore = 5
        ElseIf mis3.Checked Then
            misScore = 20
        ElseIf mis4.Checked Then
            misScore = 20
        End If

        sum = satScore + hsqScore + difScore + geoScore + aluScore + essayScore + lAndSScore + misScore
        gpaScore = (CDbl(txtGPA.Text) * 20) + sum


        If gpaScore > 100 Then
            TotalScore.Items.Add("Total Score: " & gpaScore)
            TotalScore.Items.Add("Admitted")
        Else
            TotalScore.Items.Add("Total Score: " & gpaScore)
            TotalScore.Items.Add("Not Admitted")
        End If

    End Sub

End Class
