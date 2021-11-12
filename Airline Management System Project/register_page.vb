Imports System.Data.SqlClient
Public Class register_page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ars;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[ars_user_register]
           ([fname]
           ,[lname]
           ,[username]
           ,[pass]
           ,[con_pass]
           ,[dob]
           ,[gender]
           ,[addr]
           ,[mobile]
           ,[email]
           ,[country])
     VALUES
           ('" + txtfname.Text + "','" + txtlname.Text + "','" + txt_username.Text + "','" + txtpass.Text + "','" + txt_con_pass.Text + "',
           '" + txt_dob.Text + "','" + gender_combobox.SelectedItem.ToString + "','" + txt_address.Text + "',
           '" + txt_mobile.Text + "','" + txt_email.Text + "','" + Country_ComboBox.SelectedItem.ToString + "')", conn)

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Your Account Created!!", MsgBoxStyle.Information)

        'clear all details 

        txtfname.Text = ""
        txtlname.Text = ""
        txt_username.Text = ""
        txtpass.Text = ""
        txt_con_pass.Text = ""
        txt_dob.Text = ""
        gender_combobox.SelectedItem = False
        txt_address.Text = ""
        txt_mobile.Text = ""
        txt_email.Text = ""
        Country_ComboBox.SelectedItem = False
    End Sub

    Private Sub register_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        txtfname.Text = ""
        txtlname.Text = ""
        txt_username.Text = ""
        txtpass.Text = ""
        txt_con_pass.Text = ""
        txt_dob.Text = ""
        gender_combobox.SelectedItem = False
        txt_address.Text = ""
        txt_mobile.Text = ""
        txt_email.Text = ""
        Country_ComboBox.SelectedItem = False
    End Sub

    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs) Handles txtfname.TextChanged

    End Sub
End Class