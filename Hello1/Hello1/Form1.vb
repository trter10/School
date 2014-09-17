Public Class Form1
    'Luke Frazier 9/17/2014'
    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        lblMessage.Text = "Hello"
    End Sub

    Private Sub radEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnglish.CheckedChanged
        lblMessage.Text = "Hello"
    End Sub

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        lblMessage.Text = "Bonjour"
    End Sub

    Private Sub radGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGerman.CheckedChanged
        lblMessage.Text = "Guten Tag"
    End Sub

    Private Sub chkEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnglish.CheckedChanged
        lblMessage.Text = "Goodbye"
    End Sub

    Private Sub chkFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFrench.CheckedChanged
        lblMessage.Text = "Au Revoir"
    End Sub

    Private Sub chkGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGerman.CheckedChanged
        lblMessage.Text = "Auf wiedersehen"
    End Sub
End Class
