Public Class Form1

    'Luke Frazier
    '5.04 Random Number
    '10/23/2014

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim rand As New System.Random
        Dim decFirst As Decimal = rand.NextDouble
        Dim intSecond As Integer = rand.Next
        Dim intThird As Integer = rand.Next(1, 100)
        Dim intFourth As Integer = rand.Next(11, 50)

        lblOutput.Text = decFirst & vbCrLf & intSecond & vbCrLf & intThird & vbCrLf & intFourth
    End Sub
End Class
