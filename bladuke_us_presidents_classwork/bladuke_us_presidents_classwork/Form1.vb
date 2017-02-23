Public Class Form1
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim agesAtInaug() As String = IO.File.ReadAllLines("AgeAtInaug.txt")
        Dim query = From line In agesAtInaug
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select line
        IO.File.WriteAllLines("Sorted.txt", query)
    End Sub
End Class