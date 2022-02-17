Imports System.Data.SqlClient

Public Class Cancel_flight_user
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True")


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

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub reservation_Click(sender As Object, e As EventArgs) Handles reservation.Click
        reservation.Show()
        Me.Hide()
    End Sub

    Private Sub abt_dev_Click(sender As Object, e As EventArgs) Handles abt_dev.Click
        About_Us.Show()
        Me.Hide()
    End Sub

    Private Sub can_ticket_Click(sender As Object, e As EventArgs) Handles can_ticket.Click
        home_user.Show()
        Me.Hide()
    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        home_user.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_flight_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_now_label.Text = Date.Now.ToString("dd-MM-yyyy")
        time_now_label.Text = TimeOfDay
    End Sub

    Private Sub check_btn_cancel_Click_1(sender As Object, e As EventArgs) Handles check_btn_cancel.Click
        'CHECKING PNR TEXTBOX IS EMPTY OR NOT
        If pnr_btn_cancel.Text = Nothing Then
            MsgBox("Enter Your PNR Number", MsgBoxStyle.Exclamation)
        Else


            conn.Open()

            Try
                Dim check_pnr As String = pnr_btn_cancel.Text

                Dim cmd As New SqlCommand("Select 
                                                                                     fli_name, 
                                                                                     total_amt,
                                                                                     date_reserve,
                                                                                     source_reserve,
                                                                                     destin_reserve,
                                                                                     pay_type,
                                                                                     user_id
                                                                      FROM  
                                                                                     ars_reserve
                                                                      WHERE 
                                                                                     pnr_no= '" + pnr_btn_cancel.Text + "'", conn)

                Using dr As SqlDataReader = cmd.ExecuteReader
                    If dr.Read Then
                        fli_name_cancel.Text = dr.GetValue(0)
                        fli_price_cancel.Text = dr.GetValue(1)
                        fli_date_cancel.Text = dr.GetValue(2)
                        source_cancel.Text = dr.GetValue(3)
                        desti_cancel.Text = dr.GetValue(4)
                        pay_type_cancel.Text = dr.GetValue(5)
                        user_id_cancel.Text = dr.GetValue(6)
                    End If
                End Using
                conn.Close()
            Catch ex As Exception
                MsgBox("Error while checking the value in the database" & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub cancel_btn_Click_1(sender As Object, e As EventArgs) Handles cancel_btn.Click
        If pnr_btn_cancel.Text = Nothing Then
            MsgBox("Please Enter your PNR number !!", MsgBoxStyle.Exclamation)
            pnr_btn_cancel.Focus()

        ElseIf pnr_btn_cancel.Text.Length > 7 Then
            MsgBox("Plz Enter Your Valid PNR number", MsgBoxStyle.RetryCancel)
            pnr_btn_cancel.Focus()

        ElseIf pnr_btn_cancel.Text.Length = 6 Then
            Try
                conn.Open()
                Dim cmd1 As New SqlCommand("SELECT 
                                                                                                pnr_no
                                                                              FROM 
                                                                                                ars_reserve 
                                                                              WHERE 
                                                                                                pnr_no='" + pnr_btn_cancel.Text + "'", conn)

                Dim pnr As String
                Dim pnr_text As String

                Dim lrd As SqlDataReader = cmd1.ExecuteReader()
                If lrd.HasRows Then
                    While lrd.Read()

                        pnr = lrd("pnr_no").ToString()
                        pnr_text = pnr_btn_cancel.Text
                        If pnr = pnr_text Then
                            MsgBox("Your PNR is Valid!" & MsgBoxStyle.OkOnly)
                        End If
                    End While

                Else
                    MsgBox("Entered PNR IS NoT Valid" + Environment.NewLine + "Rety AGain!" & MsgBoxStyle.RetryCancel)
                    pnr_btn_cancel.Text = Nothing
                    pnr_btn_cancel.Focus()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Error while connecting to the database! or checking process" & ex.Message)
                conn.Close()
                pnr_btn_cancel.Text = Nothing
                pnr_btn_cancel.Focus()
            Finally
                conn.Close()
            End Try
        End If


        Try
            'deleting the booked Ticket
            conn.Open()
            Dim cmd As New SqlCommand("DELETE 
                                                                                        FROM 
                                                                                                      ars_reserve 
                                                                                        WHERE 
                                                                                                       pnr_no='" + pnr_btn_cancel.Text + "' ", conn)
            If cmd.ExecuteNonQuery() Then
                Dim dt1 As String = fli_date_cancel.Text

                Dim oDate As Date = Convert.ToDateTime(dt1)
                'MessageBox.Show("converted text: " & oDate)

                Dim dt2 As String = Date.Now.ToString("dd-MM-yyyy")
                '  MsgBox("present date: " & dt2)


                Dim date_cal As Integer = DateDiff(DateInterval.Day, CDate(dt2), CDate(oDate))
                'MsgBox("date cal: " & date_cal)

                Dim Actual_price As Integer = fli_price_cancel.Text
                Dim refund As Integer = Actual_price
                Dim price As Integer

                If date_cal = 0 Then
                    refund = Val(Actual_price * (35 / 100))
                    price = Actual_price - refund

                End If

                If date_cal >= 1 Then
                    If date_cal <= 5 Then
                        refund = Val(Actual_price * (30 / 100))
                        price = Actual_price - refund

                    End If
                End If

                If date_cal >= 6 Then
                    If date_cal <= 9 Then
                        refund = Val(Actual_price * (25 / 100))
                        price = Actual_price - refund

                    End If
                End If

                If (date_cal >= 10) Then
                    If (date_cal <= 15) Then
                        refund = Val(Actual_price * (20 / 100))
                        price = Actual_price - refund

                    End If
                End If

                If (date_cal >= 16) Then
                    If (date_cal <= 25) Then
                        refund = Val(Actual_price * (15 / 100))
                        price = Actual_price - refund

                    End If
                End If

                If (date_cal >= 26) Then
                    If (date_cal <= 30) Then
                        refund = Val(Actual_price * (10 / 100))
                        price = Actual_price - refund
                    End If
                End If

                If (date_cal > 30) Then
                    refund = Val(Actual_price * (5 / 100))
                    price = Actual_price - refund
                End If
                cancel_refund_text.Text = price
                MsgBox("Your flight Cancelled Sucessfully" & Environment.NewLine & "Your refund amount: " & price)
                refund_user.Show()
                home_user.history()
                Me.Hide()
            End If

            fli_name_cancel.Text = ""
            fli_price_cancel.Text = ""
            fli_date_cancel.Text = ""
            source_cancel.Text = ""
            desti_cancel.Text = ""
            pay_type_cancel.Text = ""
            user_id_cancel.Text = ""
            pnr_btn_cancel.Text = ""

            conn.Close()

        Catch ex As Exception
            MsgBox("Error while canceliing the ticket" & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear_cancel_btn_Click_1(sender As Object, e As EventArgs) Handles clear_cancel_btn.Click
        fli_name_cancel.Text = ""
        fli_price_cancel.Text = ""
        fli_date_cancel.Text = ""
        source_cancel.Text = ""
        desti_cancel.Text = ""
        pay_type_cancel.Text = ""
        user_id_cancel.Text = ""
        pnr_btn_cancel.Text = ""
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        fli_name_cancel.Text = ""
        fli_price_cancel.Text = ""
        fli_date_cancel.Text = ""
        source_cancel.Text = ""
        desti_cancel.Text = ""
        pay_type_cancel.Text = ""
        user_id_cancel.Text = ""
        pnr_btn_cancel.Text = ""

        home_user.Show()
        Me.Hide()
    End Sub

    Private Sub feeback_btn_Click(sender As Object, e As EventArgs) Handles feeback_btn.Click
        feedback_form.Show()
        Me.Hide()
    End Sub
End Class