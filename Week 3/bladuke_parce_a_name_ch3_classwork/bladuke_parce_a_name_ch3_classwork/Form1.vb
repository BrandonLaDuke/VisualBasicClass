Public Class Form1
    Private Sub btnAnalize_Click(sender As Object, e As EventArgs) Handles btnAnalize.Click
        Dim fullName, firstName, lastName As String
        Dim m As Integer
        Dim n As Integer
        fullName = txtName.Text 'Determine the full name from the text box.
        n = fullName.IndexOf(" ")
        firstName = fullName.Substring(0, n)
        lastName = fullName.Substring(n + 1)
        m = lastName.Length 'Determine the ammount of leters in the last name.
        lstResults.Items.Clear()
        lstResults.Items.Add("First Name: " & firstName)
        lstResults.Items.Add("Your last name has " & m & " letters.")
    End Sub
End Class
