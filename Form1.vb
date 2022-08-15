Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblWhatLanguage.Click

    End Sub

    Private Sub BtnGreet_Click(sender As Object, e As EventArgs) Handles BtnGreet.Click
        Dim stLanguage As String
        stLanguage = TxtLanguage.Text

        If stLanguage = "IsiZulu" Then
            MsgBox("Sawubona!")
        ElseIf stLanguage = "English" Then
            MsgBox("Hello!")
        ElseIf stLanguage = "Afrikaans" Then
            MsgBox("Hoe gaan it!")
        ElseIf stLanguage = "IsiXhosa" Then
            MsgBox("Molo!")
        ElseIf stLanguage = "TshiVenda" Then
            MsgBox("Ndaa!")
        ElseIf stLanguage = "XiTsonga" Then
            MsgBox("Avuxeni!")
        ElseIf stLanguage = "SePedi" Then
            MsgBox("Dumela!(Gotsong)")
        ElseIf stLanguage = "SeSotho" Then
            MsgBox("Dumela!")
        ElseIf stLanguage = "SeTswana" Then
            MsgBox("Dumela!")
        ElseIf stLanguage = "IsiNdebele" Then
            MsgBox("Lotjhani!")
        ElseIf stLanguage = "siSwati" Then
            MsgBox("Sawubona!")
        End If


    End Sub
End Class
