Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Static intWins, intLosses, intDraws As Integer
        Dim rand As New System.Random
        Dim intComputerThrow As Integer = rand.Next(0, 3)

        If radRock.Checked Then
            Select Case intComputerThrow
                Case 0
                    MessageBox.Show("Draw!")
                    intDraws += 1
                Case 1
                    MessageBox.Show("Computer wins!")
                    intLosses += 1
                Case 2
                    MessageBox.Show("You win!")
                    intWins += 1
            End Select
        ElseIf radPaper.Checked Then
            Select intComputerThrow
                Case 0
                    MessageBox.Show("You win!")
                    intWins += 1
                Case 1
                    MessageBox.Show("Draw!")
                    intDraws += 1
                Case 2
                    MessageBox.Show("Computer wins!")
                    intLosses += 1
            End Select
        ElseIf radScissors.Checked Then
            Select Case intComputerThrow
                Case 0
                    MessageBox.Show("Computer wins!")
                    intLosses += 1
                Case 1
                    MessageBox.Show("You win!")
                    intWins += 1
                Case 2
                    MessageBox.Show("Draw!")
                    intDraws += 1
            End Select
        Else
            Exit Sub
        End If

        lblCounter.Text = "Wins: " & intWins & vbCrLf & "Losses: " & intLosses & vbCrLf & "Draws: " & intDraws

    End Sub
End Class
