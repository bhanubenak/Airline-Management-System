Imports System.Data.SqlClient

Public Class home_user

    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True;")

    'getting username from Username_textbox and displaying in the label
    Public Property username_text As String

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        reservation_user.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Cancel_flight_user.Show()
        Me.Hide()
    End Sub

    Private Sub home_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnr_no.Text = Reserve_page.pnr_no_text.Text

        user_nick()
        history()

        date_now_label.Text = Date.Now.ToString("dd-MM-yyyy")
        time_now_label.Text = TimeOfDay

        'display Nickname  in the HomeScreen
        'username_display_label.Text = Login_Page.txtUsername.Text

        '---------------------------------xxXxx--------------------------------------------

        '==============>Dim User As String = Login_Page.userName
        'username_display_label.Text = User


        '---------------------------------xxXxx--------------------------------------------

    End Sub

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

    Private Sub feeback_form_Click(sender As Object, e As EventArgs) Handles feeback_btn.Click
        feedback_form.Show()
        Me.Hide()
    End Sub

    Private Sub reservation_Click(sender As Object, e As EventArgs) Handles reservation.Click
        reservation_user.Show()
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

    'display user Flight Details
    Public Sub history()
        Try
            Dim cmd As String = "SELECT 
                                                           * 
                                         FROM
                                                            ars_reserve 
                                         WHERE 
                                                            username= '" + Login_Page.txtUsername.Text + "' "
            Dim Adpt As New SqlDataAdapter(cmd, conn)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "ars_reserve")
            history_DataGridView.DataSource = ds.Tables(0)
            'closing the connection
            conn.Close()
        Catch ex As Exception
            MsgBox("Unabe to load the data", ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub user_nick()
        Try
            conn.Open()
            Dim cmd As New SqlCommand("Select 
                                                                                    *
                                                                      FROM  
                                                                                     ars_register
                                                                      WHERE 
                                                                                     username= '" + Login_Page.txtUsername.Text + "'", conn)

            Using dr As SqlDataReader = cmd.ExecuteReader
                If dr.Read Then
                    username_display_label.Text = dr.GetValue(1)
                    '   fli_price_cancel.Text = dr.GetValue(1)
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("Error while checking the value in the database" & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class