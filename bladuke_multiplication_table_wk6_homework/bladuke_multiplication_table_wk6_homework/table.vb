Public Class table
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim row, entry As String
        lstTable.Items.Clear()
        For j As Integer = 1 To 3
            row = ""
            For K As Integer = 1 To 3
                entry = j & " X " & K & " = " & (j * K)
                row &= entry & "     "
            Next
            lstTable.Items.Add(row)
        Next
    End Sub
End Class
