Public Class Income
    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatWindows.FormatWindow(FindForm)
        Me.Visible = False
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        'MainMenu.Show()
    End Sub
End Class