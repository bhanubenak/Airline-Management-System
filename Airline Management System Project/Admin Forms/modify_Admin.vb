Imports System.Data.SqlClient

Public Class modify_Admin

    Public userName As String

    Private ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True")

    Private Sub modify_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_display()
    End Sub

    Private Sub btn_flight_info_Click(sender As Object, e As EventArgs) Handles btn_flight_info.Click
        add_flight_admin.Show()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        home_admin.Show()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
    End Sub

    Private Sub add_button_Click(sender As Object, e As EventArgs) Handles add_button.Click
        If TextBox1.Text = Nothing Then
            Panel4.BackColor = Color.Red
            MsgBox("Enter Admin Id")
        ElseIf TextBox2.Text = Nothing Then
            Panel5.BackColor = Color.Red
            MsgBox("Enter Username")
        ElseIf TextBox3.Text = Nothing Then
            Panel6.BackColor = Color.Red
            MsgBox("Enter Email")
        ElseIf TextBox4.Text = Nothing Then
            Panel6.BackColor = Color.Red
            MsgBox("Enter Password")

            userexits()
        End If

        Try
            conn.Open()
            Dim command As New SqlCommand("INSERT 
                                                                                       INTO 
                                                                          ars_admin
                                                                                      VALUES('" + TextBox1.Text + "',
                                                                                                    '" + TextBox2.Text + "',
                                                                                                    '" + TextBox3.Text + "',
                                                                                                    '" + TextBox4.Text + "',
                                                                                                    '" + TextBox5.Text + "')", conn)

            If command.ExecuteNonQuery() Then
                MsgBox("Account Created Successfully", MsgBoxStyle.Information, "Success")
            Else
                MsgBox("Account not created Successfully")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." + ex.Message, "exception err")
        Finally
            conn.Close()
            data_display()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Enter Admin id")
            TextBox1.Focus()
        ElseIf TextBox2.Text = Nothing Then
            MsgBox("Enter username")
            TextBox2.Focus()
        ElseIf TextBox3.Text = Nothing Then
            MsgBox("Enter E-mail id")
            TextBox3.Focus()
        ElseIf TextBox4.Text = Nothing Then
            MsgBox("Enter Password")
            TextBox5.Focus()
        ElseIf TextBox5.Text = Nothing Then
            MsgBox("Enter Code")
            TextBox5.Focus()
        Else
            conn.Open()

            Dim cmd As New SqlCommand("update ars_admin SET
                         username=              '" + TextBox2.Text + "',
                          email_id=                 '" + TextBox3.Text + "',
                          password=           '" + TextBox4.Text + "',
                           code=       '" + TextBox5.Text + "'
            where 
                           admin_id=   '" + TextBox1.Text + "'   ", conn)

            Try
                If cmd.ExecuteNonQuery Then
                    MsgBox("Updated Successfully", MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Not Updated.", MsgBoxStyle.RetryCancel)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                data_display()
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conn.Open()

        If vbYes = MsgBox("Are you sure to Remove  the admin with flight id: " & TextBox1.Text, MsgBoxStyle.YesNo, "Warning") Then

            Dim cmd As New SqlCommand("delete from ars_admin where admin_id='" + TextBox1.Text + "'", conn)

            Try
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Removed Admin id: " & TextBox1.Text, MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Not Removed Admin id: " & TextBox1.Text & "record", MsgBoxStyle.OkOnly)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                data_display()
            End Try
        End If
    End Sub

    Private Sub userexits()
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
                                                                                ars_admin
                                                        WHERE 
                                                                               (username = '" _
                                                                                                      + TextBox2.Text _
                                                                + "' ) AND (password = '" _
                                                                                                        + TextBox4.Text _
                   + "') "
            cmd1.Connection = conn

            Dim lrd As SqlDataReader = cmd1.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()

                    Passowrd = lrd("password").ToString()
                    userName = lrd("username").ToString()

                    Passowrd2 = TextBox4.Text

                    If Passowrd = Passowrd2 And userName = TextBox2.Text Then
                        MsgBox("Username and Password already Exits." & Environment.NewLine & "Warning", MsgBoxStyle.Exclamation)
                    End If
                End While
            Else
                MsgBox("Your Account Created Successfully" & MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." + Environment.NewLine + "Error " + Environment.NewLine + ex.Message, ex.Source)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub data_display()
        Dim command As New SqlCommand("select * from ars_admin ", conn)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        admin_data.DataSource = dt
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Close()
    End Sub
End Class