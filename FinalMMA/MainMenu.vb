Public Class MainMenu
    Public Function color2uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte
        t = ColorTranslator.ToOle(clr)
        a = BitConverter.GetBytes(t)
        Return BitConverter.ToUInt32(a, 0)
    End Function

    Private Sub button4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar1.SetHighLightDay(CShort(TextBox1.Text), CShort(TextBox2.Text), CShort(TextBox3.Text), color2uint32(ColorDialog1.Color))
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatWindows.FormatWindow(FindForm)
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


End Class