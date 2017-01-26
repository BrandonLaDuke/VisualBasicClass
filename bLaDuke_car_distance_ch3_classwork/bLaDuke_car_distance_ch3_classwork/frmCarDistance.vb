Public Class frmCarDistance
    Private Sub frmCarDistance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim speed As Double
        Dim timeElapsed As Double
        Dim distance As Double
        lstResults.Items.Clear()
        speed = 50
        timeElapsed = 14
        distance = speed * timeElapsed
        lstResults.Items.Add(distance)
        distance = 410
        timeElapsed = distance / speed
        lstResults.Items.Add(timeElapsed)


    End Sub
End Class
