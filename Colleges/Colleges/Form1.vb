Public Class Form1
    'Luke Frazier
    '11/12/2014
    'Colleges

    'These arrays hold values for NCSU, UNCC, and U of M Ann Arbor, respectively.
    Dim arrPrices As Array = {1331, 875, 1713}
    Dim arrColors As Array = {Color.Red, Color.Green, ColorTranslator.FromHtml("#00274C")}

    'Select first item on each box on load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCollege.SelectedIndex = 0
        cboHours.SelectedIndex = 0
        BackColor = arrColors(0)
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        MessageBox.Show("Price is $" & arrPrices(lstCollege.SelectedIndex) * cboHours.SelectedItem, "Done")
    End Sub

    'Change the BackColor to the selected School's color
    Private Sub lstCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCollege.SelectedIndexChanged
        BackColor = arrColors(lstCollege.SelectedIndex)
    End Sub
End Class
