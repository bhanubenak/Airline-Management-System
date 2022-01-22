Imports System.Data.SqlClient

Public Class reservation_user
    Private ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13; Initial Catalog=ARS; Integrated Security=True;")


    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        If ComboBox1.SelectedIndex < 0 Then
            Label9.Visible = True
        End If
        If ComboBox2.SelectedIndex < 0 Then
            Label10.Visible = True
        End If

        DataGridView1.Visible = True

        Dim cmd As New SqlCommand("SELECT flight_id,  fli_name, fli_source, fli_desti, fli_start_time, fli_end_time, fli_price FROM ars_flight WHERE fli_source='" + ComboBox1.Text + "' and fli_desti='" + ComboBox2.Text + "'", conn)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub

    Private Sub reservation_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: to display date & time
        date_now_label.Text = Date.Now.ToString("dd-MM-yyyy")
        time_now_label.Text = TimeOfDay

        DateTimePicker1.MinDate = Now
        DateTimePicker1.MaxDate = Date.Now.AddMonths(1)

        DateTimePicker1.Value = Now
        'TODO: This line of code loads data into the 'ARSDataSet10.ars_flight' table. You can move, or remove it, as needed.
        Me.Ars_flightTableAdapter1.Fill(Me.ARSDataSet10.ars_flight)
        'TODO: This line of code loads data into the 'ARSDataSet19.ars_flight' table. You can move, or remove it, as needed.
        Me.Ars_flightTableAdapter.Fill(Me.SourceSelection.ars_flight)

    End Sub

    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            fli_id_str.Text = row.Cells(0).Value.ToString
            fli_name.Text = row.Cells(1).Value.ToString
            start_time.Text = row.Cells(4).Value.ToString
            end_time.Text = row.Cells(5).Value.ToString
            price.Text = row.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Application.Exit()
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

    Private Sub add_passenger_Click(sender As Object, e As EventArgs) Handles add_passenger.Click
        If DateTimePicker1.Value = Now Then
            MsgBox("Select date" + Environment.NewLine + "Today's date will be selected", MsgBoxStyle.Information, MsgBoxStyle.YesNo)
        End If

        If fli_name.Text = Nothing Or start_time.Text = Nothing Or end_time.Text = Nothing Or price.Text = Nothing Then
            MsgBox("Click on fli_id  " & Environment.NewLine & "To Continue ", MsgBoxStyle.Exclamation)
            ComboBox1.Focus()
        Else
            Reserve_page.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        home_user.Show()
        Me.Hide()
    End Sub
    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        home_user.Show()
        Me.Hide()
    End Sub

    Private Sub reservation_Click(sender As Object, e As EventArgs) Handles reservation.Click
        reservation.Show()
        Me.Hide()
    End Sub

    Private Sub can_ticket_Click(sender As Object, e As EventArgs) Handles can_ticket.Click
        Cancel_flight_user.Show()
        Me.Hide()
    End Sub

    Private Sub abt_dev_Click(sender As Object, e As EventArgs) Handles abt_dev.Click
        About_Us.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub feeback_btn_Click(sender As Object, e As EventArgs) Handles feeback_btn.Click
        feedback_form.Show()
        Me.Hide()
    End Sub
End Class