Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim prompt, title, fullName, firstName As String
        Dim dateOfBirth As Date
        prompt = "Enter Your full name."
        title = "Name"
        fullName = InputBox(prompt, title)
        firstName = fullName.Substring(0, fullName.IndexOf(" "))
        prompt = "Enter your date of birth."
        title = "Birthday"
        dateOfBirth = CDate(InputBox(prompt, title))
        txtToday.Text = CStr(Today)
        txtOutput.Text = firstName & ", you are " & DateDiff(DateInterval.Day, dateOfBirth, Today).ToString("N0") & " days old."
    End Sub
End Class