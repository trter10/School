Public Class Form1
    'Luke Frazier
    'Summing
    '10/13/2014

    Private Sub btnAvg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvg.Click
        Try
            Dim intTest1 As Integer = Convert.ToInt32(txtTest1.Text)
            Dim intTest2 As Integer = Convert.ToInt32(txtTest2.Text)
            Dim intTest3 As Integer = Convert.ToInt32(txtTest3.Text)
            Dim intTest4 As Integer = Convert.ToInt32(txtTest4.Text)

            lblAvg.Text = (intTest1 + intTest2 + intTest3 + intTest4) / 4
        Catch ex As Exception
            lblAvg.Text = "NaN"
        End Try
    End Sub
End Class
