Public Class Separator
    Private Sub Separator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatWindows.FormatWindow(Me)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Seperate As Double

        Seperate = CType(TextBox1.Text, Double) / 3
        TextBox2.Text = Seperate
        TextBox3.Text = Seperate
        TextBox4.Text = Seperate
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = TextBox2.Text - 1
        TextBox3.Text = TextBox3.Text + 0.5
        TextBox4.Text = TextBox4.Text + 0.5
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = TextBox2.Text + 1
        TextBox3.Text = TextBox3.Text - 0.5
        TextBox4.Text = TextBox4.Text - 0.5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox3.Text = TextBox3.Text + 1
        TextBox2.Text = TextBox2.Text - 0.5
        TextBox4.Text = TextBox4.Text - 0.5
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox3.Text = TextBox3.Text - 1
        TextBox2.Text = TextBox2.Text + 0.5
        TextBox4.Text = TextBox4.Text + 0.5
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox4.Text = TextBox4.Text + 1
        TextBox2.Text = TextBox2.Text - 0.5
        TextBox3.Text = TextBox3.Text - 0.5
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox4.Text = TextBox4.Text - 1
        TextBox2.Text = TextBox2.Text + 0.5
        TextBox3.Text = TextBox3.Text + 0.5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class