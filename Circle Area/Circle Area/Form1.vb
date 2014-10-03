Public Class Form1

    'Luke Frazier
    'Circle Area
    '10/1/2014

    Const dblPI As Double = 3.141592654

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Calculate radius
        Dim dblRadius As Double = txtRadius.Text
        'Change text to calculation
        lblArea.Text = dblRadius ^ 2 * dblPI
    End Sub

    Private Sub txtRadius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRadius.TextChanged
        lblArea.Text = ""
    End Sub
End Class
