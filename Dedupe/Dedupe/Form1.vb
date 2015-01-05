Imports System.IO

Public Class Form1

    Dim selectedDir As String
    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        If (FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath)) Then
                selectedDir = FolderBrowserDialog1.SelectedPath
                lblSelected.Text = selectedDir
                btnDedupe.Enabled = True
            Else
                MessageBox.Show("No such directory.", "Error")
            End If
        End If
    End Sub

    Private Sub btnDedupe_Click(sender As System.Object, e As System.EventArgs) Handles btnDedupe.Click
        Dim strFiles() As String = Directory.GetFiles(selectedDir)
        For Each File As String In strFiles
            MessageBox.Show(File)
        Next
    End Sub
End Class
