Public Class Form1

    Private Sub radMovieType1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType1.CheckedChanged
        Me.lblMovieTitle.Text = "Guardians of the Galaxy"
    End Sub

    Private Sub radMovieType2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType2.CheckedChanged
        Me.lblMovieTitle.Text = "Austin Powers: The Spy Who Shagged Me"
    End Sub

    Private Sub radMovieType3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType3.CheckedChanged
        Me.lblMovieTitle.Text = "Grave of the Fireflies"
    End Sub

    Private Sub btnQuantity1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity1.Click
        Me.lblTotalCost.Text = 1 * 5
    End Sub

    Private Sub btnQuantity2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity2.Click
        Me.lblTotalCost.Text = 2 * 5
    End Sub

    Private Sub btnQuantity3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity3.Click
        Me.lblTotalCost.Text = 3 * 5
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
