Public Class FormatWindows
    Public Shared Sub FormatWindow(form As Form)
        'form.MaximumSize = New Size(900, 500)
        'form.Size = New Size(600, 400)
        form.StartPosition = FormStartPosition.CenterScreen
        'form.Location = New Point(400, 200)
        form.BackColor = Color.Black
        form.ForeColor = Color.Green
        form.Font = New Font("Ariel", 12, FontStyle.Bold)
    End Sub
End Class
