Public Class Form1
    Private Sub computeWL_Click(sender As Object, e As EventArgs) Handles computeWL.Click
        Dim Cyl, Run, Swm As Double
        Cyl = hrCyl.Text
        Run = hrRun.Text
        Swm = hrSwm.Text
        Dim lbs As Double
        lbs = ((200 * Cyl) + (475 * Run) + (275 * Swm)) / 3500
        lbs = Math.Round(lbs, 1)
        resultsTxt.Text = lbs & " pounds were lost."
    End Sub
End Class
