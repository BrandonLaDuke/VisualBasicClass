Public Class Form1
    Structure Nation
        Dim name As String
        Dim continent As String
        Dim population As String
        Dim area As Double
    End Structure

    Dim country As Nation

    Private Sub frmCountry_Load() Handles MyBase.Load
        Dim line As String = "China, Asia, 1355.7, 3696100"
        Dim data() As String = line.Split(","c)
        country.name = data(0)
        country.continent = data(1)
        country.population = CDbl(data(2))
        country.area = CDbl(data(3))
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Display Text in boxes
        txtName.Text = country.name
        txtContinent.Text = country.continent
        txtPop.Text = (1000000 * country.population).ToString("N0")
        txtArea.Text = (country.area).ToString("N0") & " square miles"
        txtDensity.Text = (1000000 * country.population / country.area).ToString("N") & " people per square mile"
    End Sub
End Class
