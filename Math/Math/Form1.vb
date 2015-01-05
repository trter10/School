Public Class Form1
    'Luke Frazier
    'Math
    '12/11/2014

    Dim uriWellMet As Uri = New Uri("http://www.youtube.com/embed/rmAGrk1eEh0?autoplay=1&loop=1")
    Dim uriDummy As Uri = Nothing
    Dim blnPlaying As Boolean = False
    Dim dblNum As Double
    Dim strInput As String
    Dim Math As System.Math

    Private Sub WellMetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WellMetToolStripMenuItem.Click
        If blnPlaying Then
            Me.webWellMet.Url = uriDummy
            blnPlaying = False
        Else
            Me.webWellMet.Url = uriWellMet
            blnPlaying = True
        End If
    End Sub

    Private Sub btnAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbs.Click
        Try
            strInput = txtInput.Text
            dblNum = Convert.ToDouble(strInput)

            lblOutput.Text = "The absolute value is " & Math.Abs(dblNum)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values you dummy", "Error")
        End Try
    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        Try
            strInput = txtInput.Text
            dblNum = Convert.ToDouble(strInput)

            lblOutput.Text = "The square root is " & Math.Sqrt(dblNum)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values you dummy", "Error")
        End Try
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        Try
            strInput = txtInput.Text
            dblNum = Convert.ToDouble(strInput)
            If (Math.Sign(dblNum)) > 0 Then
                lblOutput.Text = "The number is positive."
            ElseIf (Math.Sign(dblNum)) < 0 Then
                lblOutput.Text = "The number is negative."
            Else
                lblOutput.Text = "The number is zero."
            End If
        Catch ex As Exception
            MessageBox.Show("Enter numeric values you dummy", "Error")
        End Try
    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        Dim intPlaces As Integer
        Try
            strInput = txtInput.Text
            dblNum = Convert.ToDouble(strInput)

            intPlaces = Convert.ToDouble(InputBox("Enter places", "Places"))
            lblOutput.Text = dblNum & " rounded to " &
                intPlaces & " places is " &
                Math.Round(dblNum, intPlaces)

        Catch ex As Exception
            MessageBox.Show("Enter numeric values you dummy", "Error")
        End Try
    End Sub
End Class