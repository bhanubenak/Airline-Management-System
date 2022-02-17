Imports System.Data.SqlClient

Public Class feedback_form
    'Connection String
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=ARS;Integrated Security=True;")

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Close()
        home_user.Show()
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

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("Select the type of query to preceed!!")
        Else
            RichTextBox2.Enabled = True
            RichTextBox2.BackColor = Color.White
        End If
    End Sub

    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        username_display.Text = Login_Page.txtUsername.Text

        feeback_form.Enabled = False
        RichTextBox2.Enabled = False
        'GENERATING feedback number FOR PASSENGER
        Dim RememberSet As New HashSet(Of Long)
        Dim RandomNumber As Long
        While RememberSet.Count < 5
            Dim RandomClass As New Random()
            RandomNumber = RandomClass.Next(0, 999999)
            If RememberSet.Add(RandomNumber) Then
                RandomNumber += RandomNumber
            End If
        End While

        query_no.Text = RandomNumber.ToString()

    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        If RichTextBox1.Text = Nothing Then
            MsgBox("Describe the problem to Get Solution for your query", MsgBoxStyle.Information)
        Else
            username_display.Text = Login_Page.txtUsername.Text.ToString()
            Dim user As String = username_display.Text.ToString()
            Dim q_no As String = query_no.Text.ToString()

        End If
        'Try
        conn.Open()
        Dim cmd As New SqlCommand("INSERT 
                                                                            INTO
                                                                                       [dbo].[ars_query]
                                                                                                                             ([query_num]
                                                                                                                               ,[q_type]
                                                                                                                               ,[query]
                                                                                                                               ,[username])
                                                                    VALUES( '" + query_no.Text + "' ,
                                                                                   '" + ComboBox1.SelectedItem.ToString() + "',
                                                                                   '" + RichTextBox2.Text + "',
                                                                                  '" + username_display.Text + "')
                                                                                  ", conn)

        If cmd.ExecuteNonQuery() Then
            MsgBox("Your Query Submitted" & Environment.NewLine & " Our Team Will Get You very soon", MsgBoxStyle.Information)
            Login_Page.Show()
            'home_user.Show()
            Me.Hide()
        End If
        'Catch ex As Exception
        'MsgBox("Error in uploading the query", ex.Message)
        'Finally
        'conn.Close()
        'End Try
        conn.Close()
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
End Class