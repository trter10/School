Public Class Form1
    'Luke Frazier
    'Honors Project 2
    '10/1/2014

    Private Sub radGaben_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGaben.CheckedChanged
        'Play Ameno
        webAmeno.Url = New Uri("http://www.youtube.com/embed/RkZkekS8NQU?autoplay=1&loop=1&start=18")
        'Display godliness
        Me.BackgroundImage = Honors_Project_2.My.Resources.Resources.Gaben
        lblInfo.ForeColor = Color.White
        lblInfo.Text = My.Resources.gabenInfo
    End Sub

    Private Sub radRMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRMS.CheckedChanged
        clearGaben()
        lblInfo.Text = My.Resources.RMSInfo
    End Sub

    Private Sub btnLinus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinus.CheckedChanged
        clearGaben()
        lblInfo.Text = My.Resources.torvaldsInfo
    End Sub

    Private Sub btnBernersLee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBernersLee.CheckedChanged
        clearGaben()
        lblInfo.Text = My.Resources.bernersLeeInfo
    End Sub

    Public Sub clearGaben()
        webAmeno.Url = New Uri("http://1.1.1.1")
        webAmeno.Refresh()
        lblInfo.ForeColor = Color.Black
        Me.BackgroundImage = Nothing
    End Sub

End Class







