Public Class home_user
    Private Sub btnclose_home_user_Click(sender As Object, e As EventArgs) Handles btnclose_home_user.Click
        Close()
    End Sub

    Private Sub btnmaximize_home_user_Click(sender As Object, e As EventArgs) Handles btnmaximize_home_user.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnminimize_home_user_Click(sender As Object, e As EventArgs) Handles btnminimize_home_user.Click
        WindowState = FormWindowState.Minimized
    End Sub


End Class