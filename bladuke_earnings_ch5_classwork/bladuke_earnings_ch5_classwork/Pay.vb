Public Class Pay
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hourlyWage, hoursWorked As Decimal
        hourlyWage = CDec(txtWage.Text)
        hoursWorked = CDec(txtHours.Text)
        txtEarnings.Text = (PayF(hourlyWage, hoursWorked)).ToString("C")
    End Sub

    Function PayF(wage As Decimal, hrs As Decimal) As Decimal
        Dim amount As Decimal
        Select Case hrs
            Case Is <= 40
                amount = wage * hrs
            Case Is > 40
                amount = (wage * 40) + ((1.5D) * wage * (hrs - 40))
        End Select
        Return amount
    End Function
End Class
