Public Class Form1
    'Luke Frazier
    'Grades
    '9/30/2014

    Private Sub btnShowGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGrade.Click

        'Assign grades to variables
        Dim dblQ1 As Double = txtQ1Grade.Text
        Dim dblQ2 As Double = txtQ2Grade.Text
        Dim dblFE As Double = txtFEGrade.Text

        'Calculate final grade and assign it to a variable
        Dim dblGrade As Double = (0.4 * dblQ1) + (0.4 * dblQ2) + (0.2 * dblFE)

        'Show final grade
        lblFinalGrade.Text = "Your grade is " & dblGrade
    End Sub

    Private Sub txtQ1Grade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQ1Grade.TextChanged
        lblFinalGrade.Text = ""
    End Sub

    Private Sub txtQ2Grade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQ2Grade.TextChanged
        lblFinalGrade.Text = ""
    End Sub

    Private Sub txtFEGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFEGrade.TextChanged
        lblFinalGrade.Text = ""
    End Sub
End Class
