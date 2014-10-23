Public Class Form1

    'Luke Frazier
    'Ready for School
    '10/16/2014

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click

        If chkHomework.Checked And chkBreakfast.Checked And chkTeeth.Checked Then
            MessageBox.Show("You are ready for school! WOW!")
            Application.Exit()
        Else
            MessageBox.Show("DO MORE THINGS!")
        End If
    End Sub

    Private Sub chkHomework_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomework.CheckedChanged
        If chkHomework.Checked Then
            MessageBox.Show("EGGSCELENT!")
        End If
    End Sub
End Class
