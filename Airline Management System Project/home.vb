Public Class home
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaximize_Click(sender As Object, e As EventArgs) Handles btnmaximize.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class