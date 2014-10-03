Public Class Form1
    'Luke Frazier
    'Counting
    '10/2/2014

    Private Sub btnDim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDim.Click
        Dim intCounter As Integer = 1
        intCounter += 1
        lblDisplay.Text = intCounter
    End Sub

    Private Sub btnStatic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatic.Click
        Static intCounter As Integer = 1
        intCounter += 1
        lblDisplay.Text = intCounter
    End Sub
End Class
