Public Class Form1
    Dim state, category As String
    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click

        If btnCali.Checked Then
            state = "CALIFORNIA"
        End If
        If btnIndiana.Checked Then
            state = "INDIANA"
        End If
        If btnMississippi.Checked Then
            state = "MISSISSIPPI"
        End If
        If btnNewYork.Checked Then
            state = "NEW YORK"
        End If
        If btnIndiana.Checked Then
            state = "INDIANA"
        End If
        If btnFlower.Checked Then
            category = "FLOWER"
        End If
        If btnNickname.Checked Then
            category = "NICKNAME"
        End If
        If btnMotto.Checked Then
            category = "MOTTO"
        End If

        Select Case state
            Case "CALIFORNIA"
                Select Case category
                    Case "FLOWER"
                        txtInfo.Text = "Golden Poppy"
                    Case "NICKNAME"
                        txtInfo.Text = "Golden State"
                    Case "MOTTO"
                        txtInfo.Text = "Eureka"
                End Select
            Case "INDIANA"
                Select Case category
                    Case "FLOWER"
                        txtInfo.Text = "Peony"
                    Case "NICKNAME"
                        txtInfo.Text = "Hoosier State"
                    Case "MOTTO"
                        txtInfo.Text = "Crossroads of America"
                End Select
            Case "MISSISSIPPI"
                Select Case category
                    Case "FLOWER"
                        txtInfo.Text = "Magnolia"
                    Case "NICKNAME"
                        txtInfo.Text = "Magnolia State"
                    Case "MOTTO"
                        txtInfo.Text = "By valor and arms"
                End Select
            Case "NEW YORK"
                Select Case category
                    Case "FLOWER"
                        txtInfo.Text = "Rose"
                    Case "NICKNAME"
                        txtInfo.Text = "Empire State"
                    Case "MOTTO"
                        txtInfo.Text = "Ever Upward"
                End Select
        End Select
    End Sub
End Class
