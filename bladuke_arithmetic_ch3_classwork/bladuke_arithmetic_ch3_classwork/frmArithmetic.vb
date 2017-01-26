Public Class frmArithmetic
    Private Sub frmArithmetic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCompute_Click() Handles btnCompute.Click
        lstResults.Items.Clear()
        lstResults.Items.Add(3 + 2)
        lstResults.Items.Add(3 - 2)
        lstResults.Items.Add(3 * 2)
        lstResults.Items.Add(3 / 2)
        lstResults.Items.Add(3 ^ 2)
        lstResults.Items.Add(3 * (3 + 4))
    End Sub
End Class
