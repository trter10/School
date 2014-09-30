Public Class Form1
    Private Sub radHam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHam.CheckedChanged
        lblMainChoice.Text = "u chose ham smich"
    End Sub

    Private Sub radTurkey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTurkey.CheckedChanged
        lblMainChoice.Text = "u chos turk samch"
    End Sub

    Private Sub chkMayo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMayo.CheckedChanged
        lblChoice1.Text = "u shur'd liek mayonais"
    End Sub

    Private Sub chkMustard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMustard.CheckedChanged
        lblChoice2.Text = "u'd liek mustrd"
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        lblChoice3.Text = "yew'd liek chis"
    End Sub
End Class
