Imports System.Drawing.Printing

Imports System.Data.SqlClient

Public Class Reserve_page

    'Connection String
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True;")

    'Load Event
    Private Sub Reserve_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Enabled = False
        date_now_label.Text = Date.Now.ToString("dd-MM-yyyy")
        time_now_label.Text = TimeOfDay
        username_display.Text = Login_Page.txtUsername.Text
        fli_name.Text = reservation_user.fli_name.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        reservation_user.Show()
        Me.Hide()
    End Sub

    Private Sub close_btn_Click_1(sender As Object, e As EventArgs) Handles close_btn.Click
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

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        If txtfname.Text = Nothing Then
            fname_label.Visible = True
            txtfname.Focus()

        ElseIf txtlname.Text = Nothing Then
            lname_label.Visible = True
            txtlname.Focus()

        ElseIf dob_control.Value.Date <= dob_control.MinDate Or dob_control.Value.Date >= dob_control.MaxDate Then
            MsgBox("Choose Your Date Of Birth!")
            dob_Label.Visible = True
            dob_control.Focus()

        ElseIf txt_age.Text = Nothing Then
            age_label.Visible = True
            txt_age.Focus()
            System.Text.RegularExpressions.Regex.IsMatch(txt_age.Text, "[ ^ 0-9]")

        ElseIf gender_combobox.SelectedItem = Nothing Then
            gender_label.Visible = True
            gender_combobox.Focus()

        ElseIf txt_address.Text = Nothing Then
            address_Label.Visible = True
            txt_address.Focus()

        ElseIf txt_mobile.Text = Nothing Then
            mobile_label.Visible = True
            txt_mobile.Focus()

        ElseIf Country_Combo_Box.SelectedItem = Nothing Then
            country_Label.Visible = True
            Country_Combo_Box.Focus()

        Else
            MsgBox("Your Seat reserved")
            Panel2.Enabled = True
            Panel6.Visible = True
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        txtfname.Text = ""
        txtlname.Text = ""
        dob_control.Value = dob_control.MinDate
        gender_combobox.SelectedItem = Nothing
        txt_address.Text = ""
        txt_mobile.Text = ""
        txt_age.Text = ""
        Country_Combo_Box.SelectedItem = Nothing

        fname_label.Visible = False
        lname_label.Visible = False
        dob_Label.Visible = False
        age_label.Visible = False
        gender_label.Visible = False
        address_Label.Visible = False
        country_Label.Visible = False
        mobile_label.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reservation_user.Show()
        Me.Hide()
    End Sub

    Private Sub confirm_btn_Click_1(sender As Object, e As EventArgs) Handles confirm_btn.Click
        If (String.IsNullOrEmpty(pay_type_combo_box.Text)) Then
            MsgBox("Select the Payment Type!!!", MsgBoxStyle.Exclamation)
        End If

        If user_id.Text = Nothing Then
            Label14.Visible = True
            MsgBox("enter the " + pay_type_combo_box.SelectedItem.ToString() + " user-id", MsgBoxStyle.RetryCancel)
            pay_type_combo_box.Focus()

        End If

        'GENERATING PNR NUMBER FOR PASSENGER
        Dim RememberSet As New HashSet(Of Long)
        Dim RandomNumber As Long
        While RememberSet.Count < 5
            Dim RandomClass As New Random()
            RandomNumber = RandomClass.Next(0, 999999)
            If RememberSet.Add(RandomNumber) Then
                RandomNumber += RandomNumber
            End If
        End While

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Dim cmd_str As String = "INSERT INTO ars_reserve (
                                                                            pnr_no, 
                                                                            fname,
                                                                           lname,
                                                                           dob, 
                                                                           age, 
                                                                           gen, 
                                                                           address, 
                                                                           mobile, 
                                                                           country, 
                                                                           date_reserve, 
                                                                           fli_name, 
                                                                           source_reserve, 
                                                                           destin_reserve, 
                                                                           total_amt,
                                                                           pay_type, 
                                                                           user_id, 
                                                                           username)
                              VALUES (                                
                                                                           @pnr_no, 
                                                                           @fname, 
                                                                           @lname, 
                                                                           @dob, 
                                                                           @age, 
                                                                           @gen, 
                                                                           @address, 
                                                                           @mobile, 
                                                                           @country, 
                                                                           @date_reserve, 
                                                                           @fli_name, 
                                                                           @source_reserve, 
                                                                           @destin_reserve, 
                                                                           @total_amt, 
                                                                           @pay_type, 
                                                                           @user_id,
                                                                           @username) "

        Using cmd As New SqlCommand()
            With cmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = cmd_str

                Dim pnr As String = RandomNumber
                .Parameters.AddWithValue("@pnr_no", pnr)

                Dim fname_str As String = txtfname.Text
                .Parameters.AddWithValue("@fname", fname_str)

                Dim flname_str As String = txtlname.Text
                .Parameters.AddWithValue("@lname", flname_str)

                'ADDING DATE-OF-BIRTH FROM datetimepicker
                .Parameters.AddWithValue("@dob", dob_control.Value)

                Dim age_str As String = txt_age.Text
                .Parameters.AddWithValue("@age", age_str)

                Dim gen_str As String = gender_combobox.SelectedItem.ToString()
                .Parameters.AddWithValue("@gen", gen_str)

                Dim address_str As String = txt_address.Text
                .Parameters.AddWithValue("@address", address_str)

                Dim mobile_str As String = txt_mobile.Text
                .Parameters.AddWithValue("@mobile", mobile_str)

                Dim country_str As String = Country_Combo_Box.SelectedItem.ToString()
                .Parameters.AddWithValue("@country", country_str)

                Dim date_str As Date = reservation_user.DateTimePicker1.Value

                .Parameters.AddWithValue("@date_reserve", date_str)

                .Parameters.AddWithValue("@fli_name", reservation_user.fli_name.Text)

                Dim source_str As String = reservation_user.ComboBox1.Text
                .Parameters.AddWithValue("@source_reserve", source_str)

                Dim destin_str As String = reservation_user.ComboBox2.Text
                .Parameters.AddWithValue("@destin_reserve", destin_str)

                .Parameters.AddWithValue("@total_amt", reservation_user.price.Text)
                Dim pay_type As String = pay_type_combo_box.SelectedItem.ToString()

                .Parameters.AddWithValue("@pay_type", pay_type)

                .Parameters.AddWithValue("@user_id", user_id.Text)
                .Parameters.AddWithValue("@username", username_display.Text)
            End With

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Ticket Confirmed!!" & Environment.NewLine & "Your PNR: " & RandomNumber)


                pnr_no_text.Visible = True
                pnr_label.Visible = True
                pnr_no_text.Text = RandomNumber

                'REFLECTING THE PNR NUMBER IN THE HOME SCREEN OF THE USER
                home_user.pnr_label.Visible = True
                home_user.pnr_no.Visible = True

                home_user.pnr_no.Text = RandomNumber

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'close the connection finally
                conn.Close()
            End Try
        End Using

        'shows the print ticket after ticket confirmation!
        print_ticket.Show()
        Me.Hide()
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user_id = Nothing
        pay_type_combo_box.SelectedItem = Nothing
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

    '------------------------   checks char  ---------------------------------
    Private Sub txtlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub

    '------------------------   checks char  ---------------------------------
    Private Sub close_btn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles close_btn.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
    End Sub

    '------------------------   checks Numeric  ---------------------------------
    Private Sub txt_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_age.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub
    '------------------------   checks Numeric  ---------------------------------
    Private Sub txt_mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mobile.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub
End Class