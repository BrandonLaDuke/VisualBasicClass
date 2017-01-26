Public Class CollegeData
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim fmtStr As String = "{0, -10} {1,12} {2,14} {3,12}"
        lstColleges.Items.Clear()
        lstColleges.Items.Add(String.Format(fmtStr, "College", "Enrollment", "Endowment", "Grad Rate"))
        lstColleges.Items.Add(String.Format(fmtStr, "Harvard", 10093, 32.3, 0.97))
        lstColleges.Items.Add(String.Format(fmtStr, "Yale", 12109, 20.8, 0.98))
    End Sub
End Class
