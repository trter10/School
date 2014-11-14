Public Class Form1
    'Luke Frazier
    '11/14/2014
    'Lunch Time

    'Prices for CSalad, GS, HB, CB, CSandwich respectively
    Dim arrFoodPrices As Array = {3.99, 2.99, 2.99, 3.49, 3.99}
    'Prices for S, M, L respectively
    Dim arrDrinkPrices As Array = {0.99, 1.49, 1.99}

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'So it doesn't break
        Try
            'Calculate total cost 
            Dim decTotalCost As Decimal = (arrFoodPrices(lstChoices.SelectedIndex) + arrDrinkPrices(cboSize.SelectedIndex)) * 1.07
            'Display order
            lblOrder.Text = "You ordered a " & lstChoices.SelectedItem &
                " with a " & cboSize.SelectedItem &
                " " & cboDrink.SelectedItem & "." &
                vbCrLf &
                "Your total cost is $" & Format(decTotalCost, "##.00") & "."
        Catch ex As Exception
            MessageBox.Show("Please complete the entire form.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'Clear order if user changes selection, and if it is a salad, display a notification.
    Private Sub lstChoices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChoices.SelectedIndexChanged
        lblOrder.Text = ""
        If lstChoices.SelectedIndex = 0 Or lstChoices.SelectedIndex = 1 Then
            MessageBox.Show("We only use the freshest ingredients in our salads.", "Salads")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub cboDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDrink.SelectedIndexChanged
        lblOrder.Text = ""
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        lblOrder.Text = ""
    End Sub
End Class
