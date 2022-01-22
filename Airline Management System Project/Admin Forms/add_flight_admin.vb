Imports System.Data.SqlClient
Public Class add_flight_admin
    Private ReadOnly conn_fli As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True")

    Private Sub btnminimize_home_user_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaximize_home_user_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnclose_home_user_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        home_admin.Show()
        Me.Hide()
    End Sub

    Private Sub loaddataingrid()
        Dim command As New SqlCommand("select * from ars_flight ", conn_fli)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'clear button
        fli_id.Text = ""
        fli_name.Text = ""
        fli_source.Text = ""
        fli_desti.Text = ""
        fli_start_time.Text = ""
        fli_end_time.Text = ""
        fli_price.Text = ""
        fli_seats.Text = ""
    End Sub



    Private Sub add_flight_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddataingrid()
        refresh_btn.Visible = False
    End Sub

    Private Sub insert_btn_Click_1(sender As Object, e As EventArgs) Handles insert_btn.Click
        If fli_id.Text = Nothing Then
            MsgBox("Enter flight id", MsgBoxStyle.RetryCancel)
            fli_id.Focus()
        ElseIf fli_name.Text = Nothing Then
            MsgBox("Enter flight name", MsgBoxStyle.RetryCancel)
            fli_name.Focus()
        ElseIf fli_source.Text = Nothing Then
            MsgBox("Enter the source")
            fli_source.Focus()
        ElseIf fli_desti.Text = Nothing Then
            MsgBox("Enter destination name", MsgBoxStyle.RetryCancel)
            fli_desti.Focus()
        ElseIf fli_start_time.Text = Nothing Then
            MsgBox("Enter the start time")
            fli_start_time.Focus()
        ElseIf fli_end_time.Text = Nothing Then
            MsgBox("Enter the end time")
            fli_end_time.Focus()
        ElseIf fli_price.Text = Nothing Then
            MsgBox("Enter flight price", MsgBoxStyle.RetryCancel)
            fli_price.Focus()
        ElseIf fli_seats.Text = Nothing Then
            MsgBox("Enter the seats", MsgBoxStyle.RetryCancel)
            fli_seats.Focus()

        Else

            conn_fli.Close()
            'Avoiding primary key violation 
            conn_fli.Open()
            Dim cmd2 As New SqlCommand("Select fli_id,fli_name from ars_flight where flight_id=@fli_id", conn_fli)

            cmd2.Parameters.AddWithValue("@fli_id", fli_id.Text)

            Dim myreader As SqlDataReader

            myreader = cmd2.ExecuteReader()

            If (myreader.Read()) Then
                conn_fli.Close()
                MsgBox("Duplicate Entry!!!", MsgBoxStyle.Critical)
                conn_fli.Close()

                'clear all fields
                fli_id.Text = ""
                fli_name.Text = ""
                fli_source.Text = ""
                fli_desti.Text = ""
                fli_start_time.Text = ""
                fli_end_time.Text = ""
                fli_price.Text = ""
                fli_seats.Text = ""
            Else
                'Closing Connection object, if there are any connections with the database.
                conn_fli.Close()


                Dim cmd As New SqlCommand("insert into ars_flight values(
                            '" + fli_id.Text + "',
                            '" + fli_name.Text + "',
                            '" + fli_source.Text + "',
                            '" + fli_desti.Text + "',
                            '" + fli_start_time.Text + "',
                            '" + fli_end_time.Text + "',
                            '" + fli_price.Text + "',
                            '" + fli_seats.Text + "'  )", conn_fli)

                'Opening the connection wiht the database.
                conn_fli.Open()

                If cmd.ExecuteNonQuery() Then
                    MsgBox("Flight Created Successfully", MsgBoxStyle.OkOnly)
                    loaddataingrid()
                    conn_fli.Close()
                    'home_admin.Show()
                    'Me.Hide()
                Else
                    MsgBox("Flight Not Created.", MsgBoxStyle.RetryCancel)
                End If

            End If
        End If
        'refresh_btn.Visible = True
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        If fli_id.Text = Nothing Then
            MsgBox("Enter flight id", MsgBoxStyle.RetryCancel)
            fli_id.Focus()
        End If

        If conn_fli.State = ConnectionState.Open Then
            conn_fli.Close()
        End If

        conn_fli.Open()

        Dim cmd As New SqlCommand("update ars_flight set 
                           fli_name= '" + fli_name.Text + "',
                           fli_source= '" + fli_source.Text + "',
                           fli_desti= '" + fli_desti.Text + "',
                           fli_start_time='" + fli_start_time.Text + "',
                           fli_end_time= '" + fli_end_time.Text + "',
                           fli_price= '" + fli_price.Text + "',
                           fli_total_seats='" + fli_seats.Text + "' where fli_id= '" + fli_id.Text + "'", conn_fli)

        If cmd.ExecuteNonQuery() Then
            MsgBox("Updated Successfully", MsgBoxStyle.OkOnly)
            loaddataingrid()
            'home_admin.Show()
            'Me.Hide()
        Else
            MsgBox("Not Updated.", MsgBoxStyle.RetryCancel)
        End If

        conn_fli.Close()
        refresh_btn.Visible = True
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        'navigatng to Admin home page
        home_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'Clearing all textboxes
        fli_id.Text = ""
        fli_name.Text = ""
        fli_source.Text = ""
        fli_desti.Text = ""
        fli_start_time.Text = ""
        fli_end_time.Text = ""
        fli_price.Text = ""
        fli_seats.Text = ""

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click

        If conn_fli.State = ConnectionState.Open Then
            conn_fli.Close()
        End If

        'deleting the records from the database.
        conn_fli.Open()

        MsgBox("Are you sure to delete the record", MsgBoxStyle.YesNo)

        Dim cmd As New SqlCommand("delete from ars_flight where fli_id='" & fli_id.Text & "'", conn_fli)

        If cmd.ExecuteNonQuery() Then
            MsgBox("Deleted record", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Not Deleted record", MsgBoxStyle.OkOnly)
        End If

        '' If MsgBox(fli_id.Text, MsgBoxStyle.YesNo) = DialogResult.Yes Then
        'If cmd.ExecuteNonQuery() Then
        ''MsgBox(fli_id.Text, ": Deleted record", MsgBoxStyle.OkCancel)
        'Else
        'MsgBox(fli_id.Text, ": Not Deleted record", MsgBoxStyle.OkCancel)
        'End If
        'End If

        conn_fli.Close()
        refresh_btn.Visible = True
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Dim command As New SqlCommand("select * from ars_flight where fli_id= '" + fli_id.Text + "' ", conn_fli)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

        'refresh_btn.Visible = True
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        loaddataingrid()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs)
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
End Class