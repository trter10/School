Public Class Form1
    'Luke Frazier
    'Average Grade
    '11/3/2014

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        lblDisplay.Text = ""
        Dim intGrade As Integer = 0
        Dim dblAverage As Double = 0
        Dim intCount As Integer = 0
        Dim intSum As Integer = 0
        Dim blnBroken As Boolean = False
        For intCount = 1 To 5
            Try
                intGrade = InputBox("Enter Grades", "Grade")
            Catch ex As InvalidCastException
                lblDisplay.Text = ""
                MessageBox.Show("Error")
                blnBroken = True
                Exit For
            End Try
            lblDisplay.Text &= "Grade Entered: " & intGrade & vbCrLf
            intSum += intGrade
        Next intCount
        If Not blnBroken Then
            dblAverage = intSum / 5
            lblDisplay.Text &= "Average: " & dblAverage
        End If
    End Sub
End Class
