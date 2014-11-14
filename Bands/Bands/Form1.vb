Public Class Form1
    'Luke Frazier
    '11/13/2014
    'Bands

    Private Sub TheBeatlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheBeatlesToolStripMenuItem.Click
        lblBandInfo.Text = "Paul McCartney - Lead Singer" & vbCrLf & "John Lennon - Rhythm Guitar" & vbCrLf & "George Harrison - Lead Guitar" & vbCrLf & "Ringo Starr - Drums"
        popup("The Beatles")
    End Sub

    Private Sub TheWhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheWhoToolStripMenuItem.Click
        lblBandInfo.Text = "Roger Daltrey - Lead Singer" & vbCrLf & "Pete Townsend - Guitar" & vbCrLf & "John Entwhistle - Bass Guitar" & vbCrLf & "Keith Moon – Drums"
        popup("The Who", "is")
    End Sub

    Private Sub TheDoorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheDoorsToolStripMenuItem.Click
        lblBandInfo.Text = "Jim Morrison - Lead Singer" & vbCrLf & "Robby Kreiger - Guitar" & vbCrLf & "Ray Manzarek - Keyboard" & vbCrLf & "John Densmore - Drums"
        popup("The Doors")
    End Sub

    'Opens about dialog.
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Variably generates a popup for the user based on which band was selected.
    Public Sub popup(ByVal strName As String, Optional ByVal strConjugation As String = "are")
        If MessageBox.Show("Do you like " & strName & "?", strName & " Survey", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show(strName & " " & strConjugation & " awesome.", "Yay!")
        Else
            MessageBox.Show("Maybe you've never heard " & strName & "?", "You suck.")
        End If
    End Sub
End Class

