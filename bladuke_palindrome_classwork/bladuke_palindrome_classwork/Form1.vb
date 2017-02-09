Public Class Form1
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim phrase As String
        phrase = txtPhrase.Text
        If IsPalindrome(phrase) Then
            txtResult.Text = "YES"
        Else
            txtResult.Text = "NO"
        End If
    End Sub
    Function IsPalindrome(phrase As String) As Boolean
        Dim strippedPhrase As String = "", letter As String = ""
        Dim revStrippedPhrase As String = ""
        phrase = phrase.ToUpper
        For i As Integer = 0 To phrase.Length - 1
            letter = phrase.Substring(i, 1)
            If ((letter <> "") And (letter <> "?")) And ((letter <> Chr(34)) And (letter <> "'") And (letter <> ",") And (letter <> "!") And (letter <> ";") And (letter <> ":") And (letter <> ".")) Then
                strippedPhrase &= letter
            End If
        Next
        For i As Integer = strippedPhrase.Length - 1 To 0 Step -1
            letter = strippedPhrase.Substring(i, 1)
            revStrippedPhrase &= letter
        Next
        If revStrippedPhrase = strippedPhrase Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
