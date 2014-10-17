Public Class Form1
    'Define global vars
    Public intTimes As Integer
    Dim uriAmeno As Uri = New Uri("http://www.youtube.com/embed/RkZkekS8NQU?autoplay=1&loop=1")
    Dim uriDummy As Uri = New Uri("http://1.1.1.1")
    Dim bmpChangedImage As Bitmap = CType(Proyecto_tres.My.Resources.Resources.doge, Bitmap)
    Public blnCrazy As Boolean = False

    Private Sub picDoge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDoge.Click
        'Remove label if it's visible
        If lblClick.Visible Then
            lblClick.Visible = False
        End If

        'Increment intTimes
        intTimes += 1

        'Get random integer within the size of the form
        Dim converter As System.ComponentModel.TypeConverter = _
        System.ComponentModel.TypeDescriptor.GetConverter(GetType(Point))
        Dim point1 As Point = _
            CType(converter.ConvertFromString(CInt(Math.Ceiling(Rnd() * (Me.Width - 122))) & " , " & CInt(Math.Ceiling(Rnd() * (Me.Height - 190)))), Point)

        'Move and rotate(?) the image
        picDoge.Location = point1
        txtLog.Text = txtLog.Text & intTimes & ": " & point1.ToString & vbCrLf
        txtLog.Select(txtLog.TextLength, 0)
        txtLog.ScrollToCaret()
        If blnCrazy Then
            bmpChangedImage.RotateFlip(RotateFlipType.Rotate180FlipX)
            If CInt(System.DateTime.Now.Millisecond) Mod 2 = 0 Then
                bmpChangedImage.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If
            picDoge.Image = bmpChangedImage
        End If

        'Change label
        lblTimes.Text = "Times doged: " & intTimes
        Me.Refresh()
    End Sub

    Private Sub chkMusic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMusic.CheckedChanged
        If chkMusic.Checked Then
            'Turn on music
            webAmeno.Url = uriAmeno
            webAmeno.Refresh()
        Else
            'Turn off music
            webAmeno.Url = uriDummy
            webAmeno.Refresh()
        End If
    End Sub

    Private Sub chkCrazy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCrazy.CheckedChanged
        If chkCrazy.Checked Then
            Me.blnCrazy = True
        Else
            Me.blnCrazy = False
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
        'Go insane
        For memes As Integer = 1 To 1337
            picDoge_Click(Me, e)
        Next
    End Sub

    Private Sub NoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        For memes As Integer = 1 To 1337
            MessageBox.Show(memes)
        Next
    End Sub
End Class
