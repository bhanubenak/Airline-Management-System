Imports System.Data.SqlClient
Public Class home_admin
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;  Initial Catalog=ARS; Integrated Security=True;")
    Private Sub btn_flight_info_Click(sender As Object, e As EventArgs) Handles btn_flight_info.Click
        add_flight_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modify_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        add_flight_admin.Show()
        Me.Hide()
    End Sub

    Public Sub load_date()
        Try
            Dim cmd As New SqlCommand()
            conn.Open()
            Dim da As New SqlDataAdapter()
            Dim dset As New DataTable()
            cmd.CommandText = "SELECT * FROM ars_register"
            cmd.Connection = conn
            da.SelectCommand = cmd
            da.Fill(dset)
            UserData_admin.DataSource = dset

        Catch ex As Exception
            MsgBox(ex)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub load_date_user()
        Try
            Dim cmd As New SqlCommand()
            conn.Open()
            Dim da As New SqlDataAdapter()
            Dim dset As New DataTable()
            cmd.CommandText = "SELECT  *  FROM ars_reserve"
            cmd.Connection = conn
            da.SelectCommand = cmd
            da.Fill(dset)
            DataGridView1.DataSource = dset

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub home_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_name_admin.Text = Login_Page.txtUsername.Text

        load_date()
        load_date_user()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Visible = True
        load_date_user()
    End Sub

    Private Sub View_custo_btn_Click(sender As Object, e As EventArgs) Handles View_custo_btn.Click
        load_date()
        load_date_user()
        UserData_admin.Visible = True
        Button5.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub min_btn_Click(sender As Object, e As EventArgs) Handles min_btn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_btn_Click_1(sender As Object, e As EventArgs) Handles close_btn.Click
        Close()
    End Sub

    Private Sub max_btn_Click_1(sender As Object, e As EventArgs) Handles max_btn.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        view_feedback_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        About_Us.Show()
        Me.Hide()
    End Sub
End Class