Public Class Form1
    Private Sub applyColors_Click(sender As Object, e As EventArgs) Handles applyColors.Click
        If bWhite.Checked = True Then
            vSText.BackColor = Color.White
        End If
        If bYellow.Checked = True Then
            vSText.BackColor = Color.Yellow
        End If
        If bRed.Checked = True Then
            vSText.BackColor = Color.Red
        End If
        If bBlue.Checked = True Then
            vSText.BackColor = Color.Blue
        End If
        If fWhite.Checked = True Then
            vSText.ForeColor = Color.White
        End If
        If fYellow.Checked = True Then
            vSText.ForeColor = Color.Yellow
        End If
        If fRed.Checked = True Then
            vSText.ForeColor = Color.Red
        End If
        If fBlue.Checked = True Then
            vSText.ForeColor = Color.Blue
        End If
    End Sub
End Class
