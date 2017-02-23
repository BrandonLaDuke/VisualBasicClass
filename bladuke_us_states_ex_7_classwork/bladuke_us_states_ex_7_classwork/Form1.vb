Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim states() As String = IO.File.ReadAllLines("USStates.txt")
        Dim query = From line In states
                    Let data = line.Split(","c)
                    Let name = data(0)
                    Let popDensity = CDbl(data(3)) / CDbl(data(2))
                    Let formattedDensity = popDensity.ToString("N")
                    Where popDensity < 9.5
                    Order By popDensity Ascending
                    Select name, formattedDensity
        dgvOutput.DataSource = query.ToList
        dgvOutput.CurrentCell = Nothing
        dgvOutput.Columns("name").HeaderText = "State"
        dgvOutput.Columns("formattedDensity").HeaderText = "Population Density"
    End Sub
End Class
