Public Class Form1
    Dim CurrentPlayer As String = "X"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width / 2 - Label1.Width / 2
        Dim btn As Button = Nothing
        For Each ctrl As Control In Me.Panel1.Controls
            If TypeOf ctrl Is Button Then
                btn = DirectCast(ctrl, Button)
                AddHandler btn.Click, AddressOf Me.Button_Click
            End If
        Next
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'log(CType(CType(sender,  _
        'System.Windows.Forms.Button).Name, String).Substring(6, 1) & " clicked")
        'Check player
        CType(sender,  _
        System.Windows.Forms.Button).Text = CurrentPlayer
        Select Case CurrentPlayer
            Case "X"
                CurrentPlayer = "O"
                Label1.Text = "Player: O"
            Case "O"
                CurrentPlayer = "X"
                Label1.Text = "Player: X"
        End Select
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'log("clear pressed")
        Dim btn As Button = Nothing
        For Each ctrl As Control In Me.Panel1.Controls
            ctrl.Text = ""
        Next
        'Me.BackgroundImage = WindowsApplication1.My.Resources.Resources.download
    End Sub

    'Private Sub log(ByVal text)
    '    TextBox1.AppendText(text & vbCrLf)
    '    TextBox1.Select(TextBox1.TextLength, 0)
    '    TextBox1.ScrollToCaret()
    'End Sub
End Class
