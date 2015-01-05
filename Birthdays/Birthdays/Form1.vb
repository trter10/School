Public Class Form1
    'Luke Frazier
    '8/12/2014
    'Birthdays

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim arrNames() As String = {"Aaron Winslow", "Gabe Newell", "Angie Helms", "Zachy Shirl"}
        Dim arrDates() As String = {"2/24/1997", "11/3/1962", "5/20/1974", "12/14/1996"}
        Dim i As Integer
        Do
            lstDates.Items.Add(arrNames(i) & " " & arrDates(i))
            i += 1
        Loop While i < 4
    End Sub
End Class
