Public Class Form1
    'Luke Frazier
    '11/20/2014
    'Shakespearean Insults

    'I find it more efficient to either use a Function or to have the lblInsult.Text changed in the showInsult sub, as
    'that requires less variable overhead. However, I will keep it like this for the sake of the assignment.

    Private Sub btnInsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsult.Click
        Dim gen As New Random()
        Randomize()
        Dim intInsultIndex As Integer = gen.Next(0, 5)
        showInsult(intInsultIndex, lblInsult.Text)
    End Sub

    Private Sub showInsult(ByVal intInsultIndex As Integer, ByRef strInsult As String)
        Dim arrInsults As Array = {"I think he be transformed into a beast; for I can nowhere find him like a man.",
                                   "Let's meet as little as we can.",
                                   "I desire that we be better strangers.",
                                   "Boys, apes, braggarts, jacks, milksops!",
                                   "This is the silliest stuff that I ever heard."}
        strInsult = arrInsults(intInsultIndex)
    End Sub
End Class

