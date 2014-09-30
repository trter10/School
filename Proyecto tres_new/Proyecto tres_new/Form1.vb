Public Class Form1
    'Define global vars
    Public times As Integer
    Dim Ameno As Uri = New Uri("http://www.youtube.com/embed/RkZkekS8NQU?autoplay=1&loop=1")
    Dim dummyUri As Uri = New Uri("http://1.1.1.1")
    Dim changedImage As Bitmap = CType(Proyecto_tres.My.Resources.Resources.doge, Bitmap)
    Public crazy As Boolean = False

    Private Sub picDoge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDoge.Click
        'Remove label if it's visible
        If lblClick.Visible Then
            lblClick.Visible = False
        End If

        'Increment times
        times += 1

        'Get random integer within the size of the form
        Dim converter As System.ComponentModel.TypeConverter = _
        System.ComponentModel.TypeDescriptor.GetConverter(GetType(Point))
        Dim point1 As Point = _
            CType(converter.ConvertFromString(CInt(Math.Ceiling(Rnd() * (Me.Width - 122))) & " , " & CInt(Math.Ceiling(Rnd() * (Me.Height - 190)))), Point)

        'Move and rotate(?) the image
        picDoge.Location = point1
        txtLog.Text = txtLog.Text & times & ": " & point1.ToString & vbCrLf
        txtLog.Select(txtLog.TextLength, 0)
        txtLog.ScrollToCaret()
        If crazy Then
            changedImage.RotateFlip(RotateFlipType.Rotate180FlipX)
            If CInt(System.DateTime.Now.Millisecond) Mod 2 = 0 Then
                changedImage.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            picDoge.Image = changedImage
        End If

        'Change label
        lblTimes.Text = "Times doged: " & times
        Me.Refresh()
    End Sub

    Private Sub chkMusic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMusic.CheckedChanged
        If chkMusic.Checked Then
            webAmeno.Url = Ameno
            webAmeno.Refresh()
        Else
            webAmeno.Url = dummyUri
            webAmeno.Refresh()
        End If
    End Sub

    Private Sub chkCrazy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCrazy.CheckedChanged
        If chkCrazy.Checked Then
            Me.crazy = True
        Else
            Me.crazy = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub chkLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLog.CheckedChanged
        If chkLog.Checked Then
            txtLog.Visible = True
        Else
            txtLog.Visible = False
        End If
    End Sub

    Private Sub JosesCrustToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JosesCrustToolStripMenuItem.Click
        For yolo As Integer = 1 To 1337
            picDoge_Click(Me, e)
        Next
    End Sub
End Class
