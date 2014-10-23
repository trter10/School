Public Class Form1

    'Luke Frazier
    'Nested If Formative Assessment
    '10/22/2014

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Dim intGuess, intMagicNumber As Integer

        intMagicNumber = 5
        intGuess = txtGuess.Text

        If intMagicNumber = intGuess Then
            lblResponse.Text = "u rite!"
        Else
            If intGuess > intMagicNumber Then
                lblResponse.Text = "u 2 high!"
            Else
                lblResponse.Text = "u 2 low!"
            End If
        End If
    End Sub
End Class
