Public Class Form1
    Private Sub btnRates_Click(sender As Object, e As EventArgs) Handles btnRates.Click
        Dim fmtStr As String = "{0, -10}{1,12}{2,14}"
        lstRentalRates.Items.Clear()
        lstRentalRates.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "1. Rug Cleaner", "$16.00", "$24.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "2. Lawn Mower", "$12.00", "$18.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "3. Paint Sprayer", "$20.00", "$30.00"))
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Dim item As String = itemNum.Text
        Dim time As String = txtDur.Text
        Dim itemSelection As String
        If item = "1" Then
            itemSelection = "Rug Cleaner"
        ElseIf item = "2" Then
            itemSelection = "Lawn Mower"
        ElseIf item = "3" Then
            itemSelection = "Paint Sprayer"
        End If

        Dim price As Double
        Dim timeDuration As String

        If time = "H" And item = "1" Then
            timeDuration = "Half Day Rental"
            price = 16.0
        ElseIf time = "H" And item = "2" Then
            timeDuration = "Half Day Rental"
            price = 12.0
        ElseIf time = "H" And item = "3" Then
            timeDuration = "Half Day Rental"
            price = 20.0
        ElseIf time = "F" And item = "1" Then
            timeDuration = "Full Day Rental"
            price = 24.0
        ElseIf time = "F" And item = "2" Then
            timeDuration = "Full Day Rental"
            price = 18.0
        ElseIf time = "F" And item = "3" Then
            timeDuration = "Full Day Rental"
            price = 30.0
        End If

        Dim total As Double = 30 + price

        lstBill.Items.Clear()
        lstBill.Items.Add("Reciept from Eddie's Equipment Rental")
        lstBill.Items.Add("")
        lstBill.Items.Add(itemSelection & ": $" & price & " (" & timeDuration & ")")
        lstBill.Items.Add("Deposit: $30.00")
        lstBill.Items.Add("")
        lstBill.Items.Add("Total: $" & total)
    End Sub
End Class
