Public Class Form1
    'Luke Frazier
    '1/9/2015
    'Dice roll 

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tmrTime.Start()
        'Start rolling dice
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrTime.Stop()
        'Stop rolling dice
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        Dim rand As New Random
        'Random Image for picBox 1
        Select Case rand.Next(6)
            Case 0
                Me.picDiceOne.Image = My.Resources._1
            Case 1
                Me.picDiceOne.Image = My.Resources._2
            Case 2
                Me.picDiceOne.Image = My.Resources._3
            Case 3
                Me.picDiceOne.Image = My.Resources._4
            Case 4
                Me.picDiceOne.Image = My.Resources._5
            Case 5
                Me.picDiceOne.Image = My.Resources._6
        End Select

        'Random Image for picBox 2
        Select Case rand.Next(6)
            Case 0
                Me.picDiceTwo.Image = My.Resources._1
            Case 1
                Me.picDiceTwo.Image = My.Resources._2
            Case 2
                Me.picDiceTwo.Image = My.Resources._3
            Case 3
                Me.picDiceTwo.Image = My.Resources._4
            Case 4
                Me.picDiceTwo.Image = My.Resources._5
            Case 5
                Me.picDiceTwo.Image = My.Resources._6
        End Select

        'Random Image for picBox 3
        Select Case rand.Next(6)
            Case 0
                Me.picDiceThree.Image = My.Resources._1
            Case 1
                Me.picDiceThree.Image = My.Resources._2
            Case 2
                Me.picDiceThree.Image = My.Resources._3
            Case 3
                Me.picDiceThree.Image = My.Resources._4
            Case 4
                Me.picDiceThree.Image = My.Resources._5
            Case 5
                Me.picDiceThree.Image = My.Resources._6
        End Select
    End Sub
End Class
