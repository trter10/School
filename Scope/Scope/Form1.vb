Public Class Form1

    'Luke Frazier
    'Scope
    '10/1/2014

    Dim x As Integer = 10

    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        Dim x As Integer = 5
        lblDisplay.Text = x
    End Sub

    Private Sub btnGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobal.Click
        lblDisplay.Text = x
    End Sub
End Class
