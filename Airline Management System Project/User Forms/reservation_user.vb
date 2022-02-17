Imports System.Data.SqlClient

Public Class reservation_user
    Private ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13; Initial Catalog=ARS; Integrated Security=True;")

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click

        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Select Source to continue", MsgBoxStyle.Exclamation, "Warning")
            Label9.Visible = True
            ComboBox1.Focus()
        ElseIf ComboBox2.SelectedIndex < 0 Then
            Label10.Visible = True
            MsgBox("Select Destination to continue", MsgBoxStyle.Exclamation, "Warning")
            ComboBox2.Focus()

        ElseIf ComboBox1.SelectedItem.ToString() = ComboBox2.SelectedItem.ToString() Then
            MsgBox("Change Source/Destination to continue", MsgBoxStyle.Exclamation, "Warning")
        Else
            MsgBox(ComboBox1.SelectedItem.ToString() = ComboBox2.SelectedItem.ToString())
            DataGridView1.Visible = True

            Dim cmd As New SqlCommand("SELECT 
                                                                        flight_id,  
                                                                        fli_name, 
                                                                        fli_source, 
                                                                        fli_desti, 
                                                                        fli_start_time, 
                                                                        fli_end_time, 
                                                                        fli_price 
                                                           FROM 
                                                                        ars_flight 
                                                           WHERE 
                                                                        fli_source='" + ComboBox1.Text + "' 
                                                            AND
                                                                        fli_desti='" + ComboBox2.Text + "'", conn)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            add_passenger.Enabled = True
            conn.Close()
        End If
    End Sub

    Private Sub reservation_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source_combo()
        desti_combo()

        add_passenger.Enabled = False
        gif_image.Visible = False

        'TODO: to display date & time
        date_now_label.Text = Date.Now.ToString("dd-MM-yyyy")
        time_now_label.Text = TimeOfDay

        DateTimePicker1.MinDate = Now
        DateTimePicker1.MaxDate = Date.Now.AddMonths(1)

        DateTimePicker1.Value = Now

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
        add_passenger.Enabled = True
        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Select Source to continue", MsgBoxStyle.Exclamation, "Warning")
            ComboBox1.Focus()
        End If
        If ComboBox2.SelectedIndex < 0 Then
            MsgBox("Select Destination to continue", MsgBoxStyle.Exclamation, "Warning")
            ComboBox2.Focus()
        End If
        If class_type.SelectedIndex < 0 Then
            MsgBox("Select the class Type", MsgBoxStyle.Critical, "Warning")
        End If

        If fli_name.Text = "" Or start_time.Text = "" Or end_time.Text = "" Or price.Text = "" Then
            MsgBox("CLick on Flight  to continue", MsgBoxStyle.Exclamation, "Warning")
            gif_image.Visible = True
        Else
            Try
                If DateTimePicker1.Value.ToString("dd/MM/yyyy") = date_now_label.Text Then
                    Dim start_time_ As DateTime = DateTime.Parse(start_time.Text.ToString)
                    MsgBox(start_time_.ToString("HH:mm:ss"))
                    Dim start_tim As DateTime = start_time_.ToString("HH:mm:ss")
                    If start_tim > TimeOfDay Then
                        Reserve_page.Show()
                        Me.Hide()
                    Else
                        MsgBox("Change Date/Time to continue", MsgBoxStyle.Critical)
                        DateTimePicker1.Focus()
                    End If
                Else
                    Reserve_page.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
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

    Public Sub source_combo()
        Dim bkNum(50) As String

        Dim i As Integer = 0

        conn.Open()

        Dim cmd As New SqlCommand("select distinct fli_source from ars_flight", conn)
        'execute data reader

        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()
                bkNum(i) = dr(0).ToString()
                i += 1
            End While
        End If

        For index As Integer = 0 To bkNum.GetUpperBound(0)
            If Not (bkNum(index) Is Nothing) Then
                ComboBox1.Items.Add(bkNum(index))
            End If
        Next
        conn.Close()
    End Sub

    Public Sub desti_combo()
        Dim bkNum(50) As String

        Dim i As Integer = 0

        conn.Open()

        Dim cmd As New SqlCommand("Select distinct fli_desti from ars_flight", conn)
        'execute data reader

        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()
                bkNum(i) = dr(0).ToString()
                i += 1

            End While
        End If

        For index As Integer = 0 To bkNum.GetUpperBound(0)
            If Not (bkNum(index) Is Nothing) Then
                ComboBox2.Items.Add(bkNum(index))
            End If
        Next

        conn.Close()
    End Sub
End Class