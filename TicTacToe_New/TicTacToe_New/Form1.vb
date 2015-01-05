Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set starting values
        cboOpponent.SelectedIndex = 0

        'Set up handling all button clicks in one function
        Dim btn As Button
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is Button Then
                btn = DirectCast(ctrl, Button)
                AddHandler btn.Click, AddressOf Button_Click
            End If
        Next

    End Sub

    Private Sub Button_Click()

    End Sub
End Class
