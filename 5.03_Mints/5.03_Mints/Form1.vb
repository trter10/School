Public Class Form1

    'Luke Frazier
    'Mints
    '10/14/2014

    Const srtServingSize As Short = 3
    Public intMints As Integer

    Public Sub centerElementX(ByVal element)
        Dim strCurrentX As String = element.Location.X
        Dim strCurrentY As String = element.Location.Y

        Dim strNewX As String = Convert.ToInt32(Me.Width / 2) - Convert.ToInt32(strCurrentX / 2) - 7

        element.Location = New Point(strNewX & "," & strCurrentY)
    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        lblServings.Text = Nothing
        lblRemainder.Text = Nothing
        Try
            Me.intMints = txtNumber.Text
        Catch ex As Exception
            Me.intMints = Nothing
        End Try
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intServings As Integer
        Dim intRemainder As Integer
        Try
            intServings = intMints \ srtServingSize
            intRemainder = intMints Mod srtServingSize
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
        lblServings.Text = intServings & " Servings per bag"
        lblRemainder.Text = intRemainder & " Mints left over"

        'centerElementX(lblServings)
        'centerElementX(lblRemainder)
    End Sub
End Class
