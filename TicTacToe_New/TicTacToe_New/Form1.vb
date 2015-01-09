Public Class Form1
    'Luke Frazier
    'A long time
    'Tic Tac Toe
    Dim intComputerWins As Integer
    Dim intXWins As Integer
    Dim intOWins As Integer
    Dim blnCurrentPlayer = True 'True = X, False = O - No need to waste the memory for a string
    Dim blnComputerOpponent As Boolean = True 'Note that computer is always the O player
    Dim arrAvailButtons(8) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set starting values
        cboOpponent.SelectedIndex = 0
        OnBoardStateChange()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        'Convert btn names to numbers and select case
        Select Case Convert.ToInt32(sender.Name.substring(3))
            Case 1
                btn1.Enabled = False
                btn1.Text = If(blnCurrentPlayer, "X", "O")
            Case 2
                btn2.Enabled = False
                btn2.Text = If(blnCurrentPlayer, "X", "O")
            Case 3
                btn3.Enabled = False
                btn3.Text = If(blnCurrentPlayer, "X", "O")
            Case 4
                btn4.Enabled = False
                btn4.Text = If(blnCurrentPlayer, "X", "O")
            Case 5
                btn5.Enabled = False
                btn5.Text = If(blnCurrentPlayer, "X", "O")
            Case 6
                btn6.Enabled = False
                btn6.Text = If(blnCurrentPlayer, "X", "O")
            Case 7
                btn7.Enabled = False
                btn7.Text = If(blnCurrentPlayer, "X", "O")
            Case 8
                btn8.Enabled = False
                btn8.Text = If(blnCurrentPlayer, "X", "O")
            Case 9
                btn9.Enabled = False
                btn9.Text = If(blnCurrentPlayer, "X", "O")
        End Select
        blnCurrentPlayer = If(blnCurrentPlayer, False, True)
        CheckWinner()
        PCMove()
    End Sub

    Public Sub PCMove()
        'Fix this garbage
        Dim rand As New System.Random
        Dim intRand As Integer = rand.Next(arrAvailButtons.Length)
        Select Case arrAvailButtons(intRand)
            Case 1
                btn1.Enabled = False
                btn1.Text = If(blnCurrentPlayer, "X", "O")
            Case 2
                btn2.Enabled = False
                btn2.Text = If(blnCurrentPlayer, "X", "O")
            Case 3
                btn3.Enabled = False
                btn3.Text = If(blnCurrentPlayer, "X", "O")
            Case 4
                btn4.Enabled = False
                btn4.Text = If(blnCurrentPlayer, "X", "O")
            Case 5
                btn5.Enabled = False
                btn5.Text = If(blnCurrentPlayer, "X", "O")
            Case 6
                btn6.Enabled = False
                btn6.Text = If(blnCurrentPlayer, "X", "O")
            Case 7
                btn7.Enabled = False
                btn7.Text = If(blnCurrentPlayer, "X", "O")
            Case 8
                btn8.Enabled = False
                btn8.Text = If(blnCurrentPlayer, "X", "O")
            Case 9
                btn9.Enabled = False
                btn9.Text = If(blnCurrentPlayer, "X", "O")
        End Select
        OnBoardStateChange()
    End Sub

    Public Sub OnBoardStateChange()
        Dim intCounter As Integer = -1
        For Each ctrl As Control In Panel1.Controls
            If ctrl.Enabled Then
                intCounter += 1
                ReDim Preserve arrAvailButtons(intCounter)
                arrAvailButtons(intCounter) = Convert.ToInt32(ctrl.Name.Substring(3))
            End If
        Next
    End Sub

    Private Sub cboOpponent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOpponent.SelectedIndexChanged
        ClearBoard()
        blnComputerOpponent = If(cboOpponent.SelectedIndex = 0, True, False)
    End Sub

    Public Sub ClearBoard() Handles btnClear.Click
        For Each ctrl As Control In Panel1.Controls
            ctrl.Text = Nothing
            'ctrl.Enabled = True
        Next
    End Sub

    Public Sub CheckWinner()
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" _
        Or btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" _
        Or btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" _
        Or btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" _
        Or btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" _
        Or btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" _
        Or btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" _
        Or btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            ThrowWin(False)
        ElseIf btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" _
        Or btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" _
        Or btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" _
        Or btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" _
        Or btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" _
        Or btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" _
        Or btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" _
        Or btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            ThrowWin(True)
        End If
    End Sub

    Public Sub ThrowWin(ByVal blnPlayer As Boolean)
        If blnPlayer Then
            intXWins += 1
            MessageBox.Show("X wins!", "Winner!")
        Else
            If blnComputerOpponent Then
                intComputerWins += 1
                MessageBox.Show("Computer wins!", "Winner!")
            Else
                intOWins += 1
                MessageBox.Show("O wins!", "Winner!")
            End If
        End If
    End Sub
End Class
