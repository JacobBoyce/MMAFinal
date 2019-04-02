Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub ExpensesButton_Click(sender As Object, e As EventArgs) Handles ExpensesButton.Click
        Expenses.Show()
        Me.Visible = False
    End Sub

    Private Sub IncomeButton_Click(sender As Object, e As EventArgs) Handles IncomeButton.Click
        Income.Show()
        Me.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class