Public Class Form1
    'Luke Frazier
    'Pizza2
    '10/1/2014

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        'Assign crust to variable
        Dim strCrust As String = txtCrust.Text

        'Assign toppings to variables
        Dim strTop1 As String = txtTop1.Text
        Dim strTop2 As String = txtTop2.Text

        lblFinalOrder.Text = "You would like a " & strCrust & " pizza with " & strTop1 & " and " & strTop2 & "."

    End Sub

    Private Sub txtCrust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrust.TextChanged
        lblFinalOrder.Text = ""
    End Sub

    Private Sub txtTop1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTop1.TextChanged
        lblFinalOrder.Text = ""
    End Sub

    Private Sub txtTop2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTop2.TextChanged
        lblFinalOrder.Text = ""
    End Sub
End Class
