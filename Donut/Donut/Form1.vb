Public Class Form1
    'Luke Frazier
    '10/6/2014
    'Donut

    Public strSel As String = Nothing
    Public decTotal As Decimal = 0

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        Static decGLAZED As Decimal = 0.5
        Static decCHOCOLATE As Decimal = 0.65
        Static decBLUEBERRY As Decimal = 0.75
        Static decLEMON As Decimal = 0.6
        Dim srtQuantity As Short = Nothing
        Try
            srtQuantity = txtQuantity.Text
        Catch InvalidCastException As System.Exception
        Finally
            lblOutput.Text = "Please choose a doughnut type."
        End Try

        Select Case strSel
            Case "Glazed"
                lblOutput.Text = "You Chose the Glazed doughnut." & vbCrLf & "They are $" & decGLAZED & " each."
                decTotal = decGLAZED * srtQuantity
            Case "Chocolate"
                lblOutput.Text = "You Chose the Chocolate doughnut." & vbCrLf & "They are $" & decCHOCOLATE & " each."
                decTotal = decCHOCOLATE * srtQuantity
            Case "Blueberry"
                lblOutput.Text = "You Chose the Blueberry doughnut." & vbCrLf & "They are $" & decBLUEBERRY & " each."
                decTotal = decBLUEBERRY * srtQuantity
            Case "Lemon"
                lblOutput.Text = "You Chose the Lemon doughnut." & vbCrLf & "They are $" & decLEMON & " each."
                decTotal = decLEMON * srtQuantity
            Case Nothing
                'wut 2 hek??
        End Select
        lblTotal.Text = "Your total cost is $" & decTotal

    End Sub

    Private Sub radGlazed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGlazed.CheckedChanged
        strSel = "Glazed"
    End Sub

    Private Sub radChocolate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChocolate.CheckedChanged
        strSel = "Chocolate"
    End Sub

    Private Sub radBlueberry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlueberry.CheckedChanged
        strSel = "Blueberry"
    End Sub

    Private Sub radLemon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLemon.CheckedChanged
        strSel = "Lemon"
    End Sub

End Class
