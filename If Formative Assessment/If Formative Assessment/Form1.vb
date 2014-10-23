Public Class Form1

    'Luke Frazier
    'If Formative Assessment
    '10/21/2014

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Dim intGuess, intMagicNumber As Integer

        intMagicNumber = 5
        intGuess = txtGuess.Text

        If intMagicNumber = intGuess Then
            lblResponse.Text = "u rite!"
        Else
            lblResponse.Text = "u rong!"
        End If
    End Sub
End Class
