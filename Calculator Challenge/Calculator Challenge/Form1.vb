Public Class Form1
    'Luke Frazier
    'Calculator Challenge
    '10/13/2014

    Private Sub radPow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPow.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text ^ txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radMultiply_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMultiply.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text * txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radDivide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDivide.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text / txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radIntDivide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radIntDivide.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text \ txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radMod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMod.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text Mod txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAdd.CheckedChanged
        Try
            lblFinalResult.Text = Convert.ToInt32(txtFirst.Text + txtSecond.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub radSubtract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSubtract.CheckedChanged
        Try
            lblFinalResult.Text = txtFirst.Text - txtSecond.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a whole number", "Error")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
