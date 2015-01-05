Public Class Form1
    'Luke Frazier
    '12/8/2014
    'Rates

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim arrRates() As Double = {2.3, 2.2, 2.0, 2.1, 2.4}
        Array.Sort(arrRates)
        lblRate.Text = "The lowest rate is " & (arrRates(0) / 100).ToString("#.##%")
    End Sub
End Class
