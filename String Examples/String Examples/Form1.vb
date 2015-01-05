Public Class Form1
    'Luke Frazier
    '12/15/2014
    'String Examples

    Dim strA As String
    Dim strB As String

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        strA = txt1.Text
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged
        strB = txt2.Text
    End Sub

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        Select Case String.Compare(strA, strB)
            Case 0
                lblOutput.Text = strA & " is equal to " & strB
            Case Is < 0
                lblOutput.Text = strA & " comes before " & strB
            Case Is > 0
                lblOutput.Text = strA & " comes after " & strB
        End Select
    End Sub

    Private Sub btnConcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcat.Click
        Dim strNew As String = String.Concat(strA, strB)
        lblOutput.Text = strNew
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        If strA.Equals(strB) Then
            lblOutput.Text = "Same"
        Else
            lblOutput.Text = "Different"
        End If
    End Sub

    Private Sub btnIndexOf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndexOf.Click
        Dim intIndex As Integer
        intIndex = strA.IndexOf(strB)
        lblOutput.Text = intIndex
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim strNew As String
        strNew = strA.Insert(5, "s")
        lblOutput.Text = strNew
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim strNew, strNew2 As String
        strNew = strA.Remove(0)
        strNew2 = strB.Remove(0, 1)
        lblOutput.Text = strNew & " " & strNew2
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Dim strNew As String
        strNew = strA.Replace("p", "b")
        lblOutput.Text = strNew
    End Sub

    Private Sub btnToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToLower.Click
        lblOutput.Text = strA.ToLower & " " & strB.ToLower
    End Sub

    Private Sub btnToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToUpper.Click
        lblOutput.Text = strA.ToUpper & " " & strB.ToUpper
    End Sub

    Private Sub btnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrim.Click
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.Trim
        lblOutput.Text = strEx & strNew
    End Sub

    Private Sub btnTrimEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimEnd.Click
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.TrimEnd
        lblOutput.Text = strEx & strNew
    End Sub

    Private Sub btnTrimStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimStart.Click
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.TrimStart
        lblOutput.Text = strEx & strNew
    End Sub
End Class