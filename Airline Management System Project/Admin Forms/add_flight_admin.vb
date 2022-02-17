Imports System.Data.SqlClient

Public Class add_flight_admin
    Private ReadOnly conn_fli As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True")

    Private Sub loaddataingrid()
        Dim command As New SqlCommand("select * from ars_flight ", conn_fli)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub add_flight_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fli_start_time.ShowUpDown = True
        fli_end_time.ShowUpDown = True

        DateTimePicker1.MinDate = Now.ToString("dd-MM-yyyy")
        DateTimePicker1.MaxDate = Today.AddDays(60)

        loaddataingrid()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        'Clearing all textboxes
        fli_id.Text = ""
        fli_name.Text = ""
        fli_source.Text = ""
        fli_desti.Text = ""
        fli_price.Text = ""
        fli_seats.Text = ""
        fli_start_time.Value = TimeOfDay.ToString("HH:mm")
        fli_end_time.Value = TimeOfDay.ToString("HH:mm")
        loaddataingrid()

    End Sub

    Private Sub btn_flight_info_Click(sender As Object, e As EventArgs) Handles btn_flight_info.Click
        home_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modify_Admin.Show()
        Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        view_feedback_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Hide()
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

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        home_admin.Show()
        Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'clear button
        fli_id.Text = ""
        fli_name.Text = ""
        fli_source.Text = ""
        fli_desti.Text = ""
        fli_price.Text = ""
        fli_seats.Text = ""
    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        If fli_id.Text = Nothing Then
            MsgBox("Enter flight id", MsgBoxStyle.Critical)
            fli_id.Focus()
        ElseIf fli_name.Text = Nothing Then
            MsgBox("Enter flight name", MsgBoxStyle.Critical)
            fli_name.Focus()
        ElseIf fli_source.Text = Nothing Then
            MsgBox("Enter the source", MsgBoxStyle.Critical)
            fli_source.Focus()
        ElseIf fli_desti.Text = Nothing Then
            MsgBox("Enter destination name", MsgBoxStyle.Critical)
            fli_desti.Focus()
        ElseIf fli_price.Text = Nothing Then
            MsgBox("Enter flight price", MsgBoxStyle.Critical)
            fli_price.Focus()
        ElseIf fli_seats.Text = Nothing Then
            MsgBox("Enter the seats", MsgBoxStyle.Critical)
            fli_seats.Focus()
        ElseIf fli_start_time.Value = fli_end_time.Value Then
            MsgBox("Change the start time", MsgBoxStyle.Critical)
            fli_start_time.Focus()

        Else
            conn_fli.Close()
            'Avoiding primary key violation 
            Try
                conn_fli.Open()
                Dim cmd2 As New SqlCommand("Select flight_id,fli_name from ars_flight where flight_id='" + fli_id.Text + "'", conn_fli)

                cmd2.Parameters.AddWithValue("@flight_id", fli_id.Text)

                Dim myreader As SqlDataReader

                myreader = cmd2.ExecuteReader()

                If (myreader.Read()) Then
                    conn_fli.Close()
                    MsgBox("Duplicate Entry!!!", MsgBoxStyle.Critical)
                    conn_fli.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn_fli.Close()
            End Try

            'Closing Connection object, if there are any connections with the database.
            conn_fli.Close()

            Dim start_time As String = fli_start_time.Value.ToString("HH:mm:ss")
            MsgBox(start_time)

            Dim end_time As String = fli_end_time.Value.ToString("HH:mm:ss")
            MsgBox(end_time)

            Dim cmd As New SqlCommand("insert into ars_flight values(
                            '" + fli_id.Text + "',
                            '" + fli_name.Text + "',
                            '" + fli_source.Text + "',
                            '" + fli_desti.Text + "',
                            '" + DateTimePicker1.Value.ToString("dd-MM-yyyy") + "',
                            '" + start_time + "',
                            '" + end_time + "',
                            '" + fli_price.Text + "',
                            '" + fli_seats.Text + "'  )", conn_fli)

            'Opening the connection wiht the database.
            conn_fli.Open()
            Try


                If cmd.ExecuteNonQuery() Then
                    MsgBox("Flight Created Successfully", MsgBoxStyle.OkOnly)
                    loaddataingrid()
                    conn_fli.Close()
                Else
                    MsgBox("Flight Not Created.", MsgBoxStyle.RetryCancel)
                    loaddataingrid()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn_fli.Close()
            End Try

        End If

        loaddataingrid()
        conn_fli.Close()
    End Sub

    Private Sub search_btn_Click_1(sender As Object, e As EventArgs) Handles search_btn.Click
        If fli_id.Text = Nothing Then
            MsgBox("Enter Flight_Id toContinue!!")

        Else
            Dim command As New SqlCommand("select * from ars_flight where flight_id= '" + fli_id.Text + "' ", conn_fli)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            refresh_btn.Visible = True
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click

        If conn_fli.State = ConnectionState.Open Then
            conn_fli.Close()
        End If

        'deleting the records from the database.
        conn_fli.Open()

        If vbYes = MsgBox("Are you sure to Remove  the Flight with flight id: " & fli_id.Text, MsgBoxStyle.YesNo, "Warning") Then

            Dim cmd As New SqlCommand("delete from ars_flight where flight_id='" + fli_id.Text + "'", conn_fli)
            loaddataingrid()
            Try
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Removed Flight id: " & fli_id.Text, MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Not Removed Flight id: " & fli_id.Text & "record", MsgBoxStyle.OkOnly)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn_fli.Close()
            End Try

            loaddataingrid()

            conn_fli.Close()
            refresh_btn.Visible = True
        End If
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        If fli_id.Text = Nothing Then
            MsgBox("Enter flight id", MsgBoxStyle.RetryCancel)
            fli_id.Focus()
        ElseIf fli_name.Text = Nothing Then
            MsgBox("Enter flight name", MsgBoxStyle.Critical)
            fli_name.Focus()
        ElseIf fli_source.Text = Nothing Then
            MsgBox("Enter the source", MsgBoxStyle.Critical)
            fli_source.Focus()
        ElseIf fli_desti.Text = Nothing Then
            MsgBox("Enter destination name", MsgBoxStyle.Critical)
            fli_desti.Focus()
        ElseIf fli_price.Text = Nothing Then
            MsgBox("Enter flight price", MsgBoxStyle.Critical)
            fli_price.Focus()
        ElseIf fli_seats.Text = Nothing Then
            MsgBox("Enter the seats", MsgBoxStyle.Critical)
            fli_seats.Focus()
        ElseIf fli_start_time.Value = fli_end_time.Value Then
            MsgBox("Change the start time", MsgBoxStyle.Critical)
            fli_start_time.Focus()
        End If

        If conn_fli.State = ConnectionState.Open Then
            conn_fli.Close()
        End If

        conn_fli.Open()

        Dim cmd As New SqlCommand("update ars_flight SET
                           fli_name=                '" + fli_name.Text + "',
                           fli_source=              '" + fli_source.Text + "',
                           fli_desti=                 '" + fli_desti.Text + "',
                           date_on_fli=           '" + DateTimePicker1.Value.ToString("dd-MM-yyyy") + "',
                           fli_start_time=       '" + fli_start_time.Value.ToString("HH:mm") + "',
                           fli_end_time=         '" + fli_end_time.Value.ToString("HH: mm") + "',
                           fli_price=               '" + fli_price.Text + "',
                           fli_total_seats=     '" + fli_seats.Text + "' 
            where 
                           flight_id=              '" + fli_id.Text + "'", conn_fli)

        Try
            If cmd.ExecuteNonQuery Then
                MsgBox("Updated Successfully", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Not Updated.", MsgBoxStyle.RetryCancel)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn_fli.Close()
        End Try

        conn_fli.Close()
        loaddataingrid()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        loaddataingrid()
    End Sub

    Private Sub DataGridView1_cellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            fli_id.Text = row.Cells(0).Value.ToString
            fli_name.Text = row.Cells(1).Value.ToString
            fli_source.Text = row.Cells(2).Value.ToString
            fli_desti.Text = row.Cells(3).Value.ToString
            DateTimePicker1.Value = row.Cells(4).Value.ToString
            fli_price.Text = row.Cells(7).Value.ToString
            fli_seats.Text = row.Cells(8).Value.ToString
        End If
    End Sub
End Class