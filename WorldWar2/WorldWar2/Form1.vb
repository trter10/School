Public Class Form1
    'Luke Frazier
    'World War 2 Facts
    '11/13/2014

    Private Sub AddFactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFactToolStripMenuItem.Click
        Dim strAdd As String
        For i As Integer = 1 To 5
            strAdd = InputBox("Enter a fact", "Facts")
            lstFacts.Items.Add(strAdd)
        Next
    End Sub


    Private Sub RemoveFactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFactToolStripMenuItem.Click
        lstFacts.Items.Remove(lstFacts.SelectedItem)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem.Click
        lstFacts.Items.Clear()
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class
