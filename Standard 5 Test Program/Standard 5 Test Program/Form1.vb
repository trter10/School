Public Class Form1
    'Luke Frazier
    '11/7/2014
    'Standard 5 test program
    Dim intLow As Integer = 100
    Dim intHigh As Integer = 0
    Dim dblAvg As Double = 0.0

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim intCount As Integer = 0
        Dim strInput As String = ""
        Dim intScore As Integer = 0
        Dim intSum As Integer = 0
        Const intFLAG As Integer = -1
        Do
            strInput = InputBox("Enter scores, enter -1 to stop", "Score")
            intScore = Convert.ToInt32(strInput)
            If intScore <> intFLAG Then
                If intScore < intLow Then
                    intLow = intScore
                End If
                If intScore > intHigh Then
                    intHigh = intScore
                End If
                intSum += intScore
                intCount += 1
            End If
        Loop While intScore <> intFLAG
        dblAvg = intSum / intCount
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblStats.Text = "High Score: " & _
            intHigh & vbCrLf & "Low Score: " & _
            intLow & vbCrLf & "Average Score: " & _
            dblAvg.ToString("#.##")
    End Sub
End Class
