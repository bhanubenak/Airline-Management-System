Imports System.Data.SqlClient

Public Class Login_Page

    Public userName As String

    Public Property User_Name As String = userName
    'conn string
    Private ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True")

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        'Re-setting all the textbox values to Empty
        txt_password.Text = ""
        txt_user_name.Text = ""
        txt_confirm_password.Text = ""
        txt_email.Text = ""
        txt_nick_name.Text = ""

        username_Label.Visible = False
        nickname_Label.Visible = False
        email_Label.Visible = False
        password_Label.Visible = False
        confirm_password_Label.Visible = False

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
        Application.Exit()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        'login page values will re-setting to empty.
        txtPassword.Text = Nothing
        txtUsername.Text = Nothing
        code.Text = Nothing
    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        'This button will close the login panel and it will show register panel.
        txtPassword.Text = Nothing
        txt_user_name.Focus()
        register_Panel.Enabled = True
        register_Panel.Visible = True
        login_Panel.Enabled = False
    End Sub

    Private Sub login_panel_show_Click(sender As Object, e As EventArgs) Handles login_panel_show.Click
        login_Panel.Visible = True
        login_Panel.Enabled = True
        register_Panel.Enabled = False
    End Sub

    Private Sub Login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Text = Nothing
        register_Panel.Enabled = False

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Then
            MsgBox("Enter Username")
            txtUsername.Focus()
        ElseIf txtPassword.Text = Nothing Then
            MsgBox("Enter Password, To Continue")
            txtPassword.Focus()
        Else

            Dim getuser As String = txtUsername.Text

            'checking the admin details
            If Not code.Text = Nothing Then
                admin_user_login()
            End If

            Dim cmd1 As New SqlCommand

            Try
                Dim cmd As New SqlCommand()
                Dim da As New SqlDataAdapter()
                Dim dset As New DataSet()
                cmd1.CommandText = " SELECT 
                                                                                username, 
                                                                                password

                                                                FROM 
                                                                                ars_register
                                                        WHERE 
                                                                               (username = '" + txtUsername.Text + "' ) AND (password = '" + txtPassword.Text + "') "
                cmd1.Connection = conn

                da.SelectCommand = cmd1
                da.Fill(dset, "ars_register")

                If (dset.Tables("ars_register").Rows.Count > 0) Then
                    MsgBox("Login successful")
                    home_user.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid details")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, "Error in login deatils")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        If txt_user_name.Text = "" Then
            MessageBox.Show("Enter Username", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            txt_user_name.Focus()

        ElseIf txt_nick_name.Text = "" Then
            MessageBox.Show("Enter Nickname", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            txt_nick_name.Focus()

        ElseIf txt_email.Text = "" Then
            MessageBox.Show("Enter Email", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            email_Label.Visible = True

        ElseIf txt_password.Text = "" Then
            MessageBox.Show("Enter Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            txt_password.Focus()

        ElseIf txt_confirm_password.Text = "" Then
            MessageBox.Show("Enter Confirm Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            txt_confirm_password.Focus()

        ElseIf Not txt_password.Text = txt_confirm_password.Text Then
            MsgBox("password And Confirm Pasword do not match", MsgBoxStyle.Critical, "Warning")

        Else

            userexits()

            Try
                conn.Open()
                Dim command As New SqlCommand("INSERT INTO  ars_register VALUES(          
                                                                                                                '" + txt_user_name.Text + "',
                                                                                                                '" + txt_nick_name.Text + "',
                                                                                                                '" + txt_email.Text + "',
                                                                                                                '" + txt_password.Text + "',
                                                                                                               '" + txt_confirm_password.Text + "')", conn)

                If command.ExecuteNonQuery() Then
                    MsgBox("Your Account Created!", MsgBoxStyle.Information, "Success")

                    'clearing all input textboxes and labels
                    txt_password.Text = ""
                    txt_user_name.Text = ""
                    txt_confirm_password.Text = ""
                    txt_email.Text = ""
                    txt_nick_name.Text = ""

                    'clearing all input labels
                    username_Label.Visible = False
                    nickname_Label.Visible = False
                    email_Label.Visible = False
                    password_Label.Visible = False
                    confirm_password_Label.Visible = False

                    'to navigate to login panel and close register panel
                    login_Panel.Visible = True
                    login_Panel.Enabled = True
                    register_Panel.Visible = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error while connecting to SQL Server." + ex.Message, "exception err")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Public Sub userexits()

        Dim cmd1 As New SqlCommand

        Dim Passowrd As String
        Dim Passowrd2 As String

        Try
            conn.ConnectionString = "Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True;"
            conn.Open()

            cmd1.CommandText = " SELECT 
                                                                                username, 
                                                                                password 
                                                                FROM 
                                                                                ars_register 
                                                        WHERE 
                                                                               (username = '" _
                                                                                                      + txt_user_name.Text _
                                                                + "' ) AND (password = '" _
                                                                                                        + txt_password.Text _
                   + "') "
            cmd1.Connection = conn

            Dim lrd As SqlDataReader = cmd1.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    Passowrd = lrd("password").ToString()
                    userName = lrd("username").ToString()


                    Passowrd2 = txt_password.Text

                    If Passowrd = Passowrd2 And userName = txt_user_name.Text Then

                        MsgBox("Username and Password already Exits." & MessageBoxButtons.OK, MessageBoxIcon.Exclamation, "Warning")
                        txt_user_name.Text = ""
                        txt_password.Text = ""
                        txt_confirm_password.Text = ""
                        txt_nick_name.Text = ""
                        txt_email.Text = ""

                    End If
                End While
            Else
                MsgBox("Your Account Created Successfully " & Environment.NewLine & "", MsgBoxStyle.Information, "Success")
                login_Panel.Show()
                login_Panel.Visible = True
                register_Panel.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." + Environment.NewLine + "Error in login page" + Environment.NewLine + ex.Message)
            txtPassword.Text = Nothing

        Finally
            txtPassword.Text = Nothing

            'Whether there is error or not. Close the connection.
            conn.Close()
        End Try
    End Sub

    Private Sub txt_user_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user_name.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

        End If

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txt_nick_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nick_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

        End If
    End Sub

    'for forgot password below is the code👇
    Public Sub forgotpassword()

        Dim username As String = txtUsername.Text
        Dim code As String = txtPassword.Text

        Dim user1, code1 As String
        Dim cmd1 As New SqlCommand("SELECT username AND code FROM register WHERE  (username= ' " + txtUsername.Text + " ' )     AND  code= '" + txtPassword.Text + "'   ", conn)
        Dim lrd As SqlDataReader = cmd1.ExecuteReader

        If lrd.HasRows Then
            While lrd.Read
                user1 = lrd("username").ToString
                code1 = lrd("code").ToString

                If username = user1 And code = code1 Then
                    MsgBox("Code is correct")
                    'new_password_formshow()
                Else
                    MsgBox("Code is not valid")
                End If
            End While
        End If
    End Sub

    Private Sub forgot_pass_Click(sender As Object, e As EventArgs) Handles forgot_pass.Click
        txtPassword.Text = Nothing
        forgot.Show()
        Me.Hide()
    End Sub

    Private Sub admin_user_login()
        Dim cmd1 As New SqlCommand

        Dim Passowrd As String
        Dim Passowrd2 As String

        Try
            conn.ConnectionString = "Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True;"
            conn.Open()

            cmd1.CommandText = " SELECT 
                                                                                username, 
                                                                                password,
                                                                                code

                                                                FROM 
                                                                                ars_admin
                                                        WHERE 
                                                                               (username = '" + txtUsername.Text + "' ) AND (password = '" + txtPassword.Text + "') AND (code = '" + code.Text + "' ) "
            cmd1.Connection = conn

            Dim lrd As SqlDataReader = cmd1.ExecuteReader()

            Dim code_check As String
            If lrd.HasRows Then
                While lrd.Read()

                    Passowrd = lrd("password").ToString()
                    userName = lrd("username").ToString()
                    code_check = lrd("code").ToString

                    Passowrd2 = txtPassword.Text

                    If Passowrd = Passowrd2 And userName = txtUsername.Text And code_check = code.Text Then
                        MsgBox("Admin Login Sucessfull" & Environment.NewLine & "Information", MsgBoxStyle.Information)

                        txtPassword.Text = Nothing

                        'REDIRECT TO ADMIN PAGE
                        code.Text = Nothing
                        home_admin.load_date()
                        home_admin.load_date_user()
                        home_admin.Show()
                        ' MsgBox("Welcome back " & txtUsername.Text)
                        Me.Hide()

                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error in login deatils")
        Finally
            conn.Close()
        End Try

    End Sub
End Class