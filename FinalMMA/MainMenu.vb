Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub ExpensesButton_Click(sender As Object, e As EventArgs) Handles ExpensesButton.Click
        Me.Visible = False
    End Sub

    Private Sub IncomeButton_Click(sender As Object, e As EventArgs) Handles IncomeButton.Click
        Me.Visible = False
    End Sub
End Class