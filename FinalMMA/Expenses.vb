﻿Public Class Expenses
    Private Sub Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatWindows.FormatWindow(FindForm)
        Me.Visible = False
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        'MainMenu.Show()
        Me.Visible = False
    End Sub
End Class