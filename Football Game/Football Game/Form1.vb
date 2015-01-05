Public Class Form1
    'Luke Frazier
    '11/25/2014
    'Football Game

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Try
            lblTotal.Text = "The final score is " & addValues({txtQ1.Text,
                                       txtQ2.Text,
                                       txtQ3.Text,
                                       txtQ4.Text})
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number for each quarter.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Function addValues(ByVal arrIntegers As Array) As Integer
        Dim intTotal As Integer

        'Add each number in the array to intTotal
        For Each number As Integer In arrIntegers
            intTotal += number
        Next

        'Return the total
        Return intTotal
    End Function
End Class
