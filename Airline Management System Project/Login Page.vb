Imports System.Data.SqlClient

Public Class Login_Page

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'This button will checks if user details are authenticated or not

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Passowrd As String
        Dim Passowrd2 As String
        Dim userName As String

        Try
            con.ConnectionString = "Data Source=(localdb)\ProjectsV13;Initial Catalog=ars;Integrated Security=True;"
            con.Open()

            cmd.CommandText = " SELECT username, password FROM ars_register WHERE (username = '" + txtUsername.Text + "' ) AND (password = '" + txtPassword.Text + "') "
            cmd.Connection = con
            'change the data fields names and table according to your database

            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    'Do something here
                    Passowrd = lrd("password").ToString()
                    userName = lrd("username").ToString()

                    Passowrd2 = txtPassword.Text()

                    If Passowrd = Passowrd2 And userName = txtUsername.Text Then

                        MessageBox.Show("Logged in successfully as " & userName, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        home.Show()
                        Me.Hide()

                        'Clear all fields
                        txtPassword.Text = ""
                        txtUsername.Text = ""

                    End If

                End While

            Else
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Clear all fields
                txtPassword.Text = ""
                txtUsername.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." + ex.Message, "exception err")
            txtPassword.Text = ""
            txtUsername.Text = ""

        Finally
            txtPassword.Text = ""
            txtUsername.Text = ""
            con.Close() 'Whether there is error or not. Close the connection.

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'login page values will re-setting to empty.
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'This button will close the login panel instead it will show register panel.
        register_Panel.Show()
        login_Panel.Visible = False
        'me.Close()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnmaximize_Click(sender As Object, e As EventArgs) Handles btnmaximize.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

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

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim conn As New SqlConnection("Data Source=(localdb)\ProjectsV13; Initial Catalog=ars; Integrated Security=True;")
        conn.Open()
        Dim cmd As New SqlCommand("Insert into ars_register values(@username,@nickname,@email_id,@password,@confirm_password)", conn)

        cmd.Parameters.AddWithValue("@username", txt_user_name.Text)
        cmd.Parameters.AddWithValue("@nickname", txt_nick_name.Text)
        cmd.Parameters.AddWithValue("@email_id", txt_email.Text)
        cmd.Parameters.AddWithValue("@password", txt_password.Text)
        cmd.Parameters.AddWithValue("@confirm_password", txt_confirm_password.Text)

        If cmd.ExecuteNonQuery() Then
            MsgBox("Your Account created!", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Your Account Not created!", MsgBoxStyle.RetryCancel)
        End If


    End Sub

    Private Sub login_Panel_Paint(sender As Object, e As PaintEventArgs) Handles login_Panel.Paint
        'initially register panel will not visible,since this we are in login panel
        register_Panel.Visible = False
    End Sub
End Class





