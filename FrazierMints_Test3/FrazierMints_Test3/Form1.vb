
'Luke Frazier
'Computer Programming I Honors
'9/24/2014

Public Class Form1

    Private Sub radPeppermint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPeppermint.CheckedChanged
        lblChoice.Text = "I like Peppermint."
    End Sub

    Private Sub radWintergreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWintergreen.CheckedChanged
        lblChoice.Text = "I like Wintergreen."
    End Sub

    Private Sub radCinnamon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCinnamon.CheckedChanged
        lblChoice.Text = "I like Cinnamon."
    End Sub

    Private Sub btnChoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoices.Click
        lblChoice.Text = "Choice, Choices, Choices"
    End Sub
End Class
