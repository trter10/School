Public Class Form1
    'Luke Frazier
    'Cell Phone
    '10/22/2014

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            Dim intMinutes As Integer = Convert.ToInt32(txtMinutes.Text)
            Select Case intMinutes
                Case 0 To 200
                    output(0)
                Case 201 To 300
                    output(0.17)
                Case 301 To 500
                    output(0.15)
                Case Is > 500
                    output(0.12)
            End Select
        Catch ex As Exception
            MessageBox.Show("""" & txtMinutes.Text & """ is invalid.")
        End Try
        
    End Sub

    Function output(ByVal intMinCost As Decimal)
        Const decREGFEE As Decimal = 9.95
        Dim intMinutes As Integer = Convert.ToInt32(txtMinutes.Text)
        Dim decMinutesCost, decTaxes, decTotal As Decimal
        lblOne.Text = "Regular fee: " & Format(decREGFEE, "$##.00")
        decMinutesCost = intMinCost * intMinutes
        decTaxes = 0.07 * (decMinutesCost + decREGFEE)
        decTotal = decREGFEE + decMinutesCost + decTaxes
        lblTwo.Text = "Minutes cost: " & Format(decMinutesCost, "$##.00")
        lblThree.Text = "Taxes: " & Format(decTaxes, "$##.00")
        lblFour.Text = "Total Charge: " & Format(decTotal, "$##.00")
    End Function

End Class
