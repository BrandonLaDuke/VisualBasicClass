Imports System.IO

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim person As String = txtName.Text
        If person <> "" Then
            If IsInFile(person) Then
                MessageBox.Show(person & " is already in the file.", "Alert")
            Else
                Dim sw As StreamWriter = File.AppendText("Names.txt")
                sw.WriteLine(person)
                sw.Close()
                MessageBox.Show(person & " added to the file.", "Name Added")
                txtName.Clear()
                txtName.Focus()
            End If
        Else
            MessageBox.Show("You must enter a name.", "Information Incomplete")
        End If
    End Sub

    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim person As String = txtName.Text
        If person <> "" Then
            If IsInFile(person) Then
                MessageBox.Show(person & " is in the file.", "Yes")
            Else
                MessageBox.Show(person & " is not in the file.", "No")
            End If
        Else
            MessageBox.Show("You must enter a name.", "Information Incomplete")
        End If
        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim person As String = txtName.Text
        If person <> "" Then
            If IsInFile(person) Then
                Dim sr As StreamReader = File.OpenText("Names.txt")
                Dim sw As StreamWriter = File.CreateText("Temp.txt")
                Dim individual As String
                Do Until sr.EndOfStream
                    individual = sr.ReadLine
                    If individual <> person Then
                        sw.WriteLine(individual)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Names.txt")
                File.Move("Temp.txt", "Names.txt")
                MessageBox.Show(person & " removed from file.", "Name removed")
            Else
                MessageBox.Show(person & " is not in the file.", "Name not found (404)")
            End If
            txtName.Clear()
            txtName.Focus()
        End If
    End Sub

    Function IsInFile(person As String) As Boolean
        If File.Exists("Names.txt") Then
            Dim sr As StreamReader = File.OpenText("Names.txt")
            Dim individual As String
            Do Until sr.EndOfStream
                individual = sr.ReadLine
                If individual = person Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function

End Class
