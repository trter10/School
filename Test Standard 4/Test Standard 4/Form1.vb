Public Class Form1
    'Luke Frazier
    'Test 4/Pizza Cost
    '10/8/2014
    Const decLABORCOST As Decimal = 0.75
    Const decRENTCOST As Decimal = 1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim srtSize As Short = txtSize.Text

        'For some reason Decimal can't handle (1-3) * .05. Who knows. We'll use Double.
        Dim dblMaterials As Double = 0.05 * srtSize ^ 2

        Dim decTotal As Decimal = decLABORCOST + decRENTCOST + dblMaterials

        lblCost.Text = "The total cost of the pizza is " & decTotal.ToString("$##.00")
    End Sub
End Class
