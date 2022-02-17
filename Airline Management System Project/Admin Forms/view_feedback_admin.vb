Imports System.Data.SqlClient

Public Class view_feedback_admin
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;  Initial Catalog=ARS; Integrated Security=True;")

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Close()
    End Sub

    Private Sub max_btn_Click(sender As Object, e As EventArgs) Handles max_btn.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub min_btn_Click(sender As Object, e As EventArgs) Handles min_btn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub view_feedback_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load event
        load_feedback()
    End Sub

    Public Sub load_feedback()
        Try
            Dim cmd As New SqlCommand()
            conn.Open()
            Dim da As New SqlDataAdapter()
            Dim dset As New DataTable()
            cmd.CommandText = "SELECT * FROM ars_query"
            cmd.Connection = conn
            da.SelectCommand = cmd
            da.Fill(dset)
            feedback_grid.DataSource = dset

        Catch ex As Exception
            MsgBox(ex)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home_admin.Show()
        Hide()
    End Sub

    Private Sub btn_flight_info_Click(sender As Object, e As EventArgs) Handles btn_flight_info.Click
        add_flight_admin.Show()
        Hide()
    End Sub

    Private Sub View_custo_btn_Click(sender As Object, e As EventArgs) Handles View_custo_btn.Click
        home_admin.Show()
        Me.Hide()
        home_admin.load_date()
        home_admin.load_date_user()
        home_admin.UserData_admin.Visible = True
        home_admin.Button5.Visible = True
        home_admin.Label2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login_Page.Show()
        Hide()
    End Sub
End Class