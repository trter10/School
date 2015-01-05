Public Class Form1
    'Luke Frazier
    '11/24/2014
    'Piggy Bank
    Dim dblTotal As Double

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        Dim dblAmount As Double

        If Double.TryParse(txtAmount.Text, dblAmount) = False Then
            MessageBox.Show("Please enter a numeric value.")
            Exit Sub
        End If
        Select Case cboType.SelectedIndex
            Case -1
                MessageBox.Show("Please choose a transaction type")
            Case 0
                lstBank.Items.Add("Deposit: " & Format(dblAmount, "$#0.00"))
                dblTotal += dblAmount
            Case 1
                lstBank.Items.Add("Withdrawal: " & Format(dblAmount, "$#0.00"))
                dblTotal -= dblAmount
        End Select
    End Sub

    Private Sub GetBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBalanceToolStripMenuItem.Click
        lstBank.Items.Add("Total: " & Format(dblTotal, "$#0.00"))
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NameUrPuggyBunkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameUrPuggyBunkToolStripMenuItem.Click
        If MessageBox.Show("Do you want to name your piggy bank?",
                           "Name",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strName As String = InputBox("Enter the name", "Name", "Puggy")
            If strName <> "" Then
                lblName.Text = "Your piggy bank's name is " & strName
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub
End Class
