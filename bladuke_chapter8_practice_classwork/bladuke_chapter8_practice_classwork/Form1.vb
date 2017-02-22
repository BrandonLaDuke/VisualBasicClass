Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim states() As String = IO.File.ReadAllLines("States.txt")
        Dim query = From line In states
                    Let data = line.Split(","c)
                    Let name = data(0)
                    Let abbr = data(1)
                    Let area = CInt(data(2))
                    Let pop = CInt(data(3))
                    Select name, abbr, area, pop

        dgvStates.DataSource = query.ToList
        dgvStates.CurrentCell = Nothing
        dgvStates.Columns("name").HeaderText = "State"
        dgvStates.Columns("abbr").HeaderText = "State"
        dgvStates.Columns("area").HeaderText = "Land Area"
        dgvStates.Columns("pop").HeaderText = "Population"
    End Sub
End Class
