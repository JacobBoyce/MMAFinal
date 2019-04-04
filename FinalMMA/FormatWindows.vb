Public Class FormatWindows
    Public Shared Sub FormatWindow(form As Form)
        form.MaximumSize = New Size(2000, 2000)
        form.Size = New Size(1300, 800)
        form.StartPosition = FormStartPosition.Manual
        form.Location = New Point(300, 100)
    End Sub
End Class
