Public Class Form1

    'Luke Frazier
    'Grades
    '10/22/2014


    Private Sub txtGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrade.TextChanged
        'Try
        'Select Case Convert.ToInt32(txtGrade.Text)
        '    Case Is < 70
        'lblFinalLetter.Text = "F"
        '    Case 70 To 76
        'lblFinalLetter.Text = "D"
        '    Case 77 To 84
        'lblFinalLetter.Text = "C"
        '    Case 85 To 92
        'lblFinalLetter.Text = "B"
        '    Case Is >= 93
        'lblFinalLetter.Text = "A"
        '    'End Select
        'Catch ex As Exception
        '    lblFinalLetter.Text = ""
        'End Try
        Try
            Dim intGrade As Integer = Convert.ToInt32(txtGrade.Text)

            If intGrade >= 93 Then
                lblFinalLetter.Text = "A"
            ElseIf intGrade >= 85 Then
                lblFinalLetter.Text = "B"
            ElseIf intGrade >= 77 Then
                lblFinalLetter.Text = "C"
            ElseIf intGrade >= 70 Then
                lblFinalLetter.Text = "D"
            Else
                lblFinalLetter.Text = "F"
            End If
        Catch ex As Exception
            lblFinalLetter.Text = ""
        End Try



    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
