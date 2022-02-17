Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class forgot

    Private targetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(1)

    Private ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13; Initial Catalog=ARS; Integrated Security=True;")

    Public otp As Integer
    Public emailid As String


    Private Sub forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user_text.Focus()

        'otp valid for 15 minutes
        Timer1.Interval = 100
        targetDT = DateTime.Now.Add(CountDownFrom)

        user_text.Enabled = True
        user_text.Visible = True

        clear.BackColor = Color.Gray
        confirm.BackColor = Color.Gray
        'clear.BackColor = Color.Gray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If user_text.Text = Nothing Then
            MsgBox("Enter Your Username!!", MsgBoxStyle.Critical)
            user_text.Focus()
        Else
            Try

                Dim cmd1 As New SqlCommand("select email from ars_register where username = '" + user_text.Text + "'", conn)
                conn.Open()
                Using dr As SqlDataReader = cmd1.ExecuteReader()
                    If dr.Read Then
                        emailid = dr.GetValue(0).ToString()
                    End If
                    Label2.Enabled = True
                    Label2.Visible = True

                    Button1.Enabled = True
                    Button1.Visible = True
                End Using

                send_otp()

            Catch ex As Exception
                MsgBox("USERNAME INVALID")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        If pass.Text = Nothing Then
            MsgBox("Enter Your New Password", MsgBoxStyle.Information)

        ElseIf re_pass.Text = Nothing Then
            MsgBox("Enter new password again!", MsgBoxStyle.Information)

        ElseIf Not pass.Text = re_pass.Text Then
            MsgBox("Entered password and re-type password is not same", MsgBoxStyle.Critical)

        Else
            If (pass.Text = re_pass.Text) Then
                newpass()
                Login_Page.Show()
                Hide()
            End If

        End If
    End Sub

    Private Sub newpass()
        Try
            conn.Open()

            Dim cmd As New SqlCommand("update ars_register set 
                                                                                   password= '" + pass.Text + "', 
                                                                                   con_password='" + re_pass.Text + "' 
                                                                          where  username= '" + user_text.Text + "'  ", conn)

            If cmd.ExecuteNonQuery() Then
                MsgBox("password Updates successfully", MsgBoxStyle.Information)
            Else
                MsgBox("password updation is not completed!!")
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub send_otp()
        'GENERATING feedback number FOR PASSENGER
        Dim RememberSet As New HashSet(Of Long)
        Dim RandomNumber As Long
        While RememberSet.Count < 7
            Dim RandomClass As New Random()
            RandomNumber = RandomClass.Next(0, 999999)
            If RememberSet.Add(RandomNumber) Then
                RandomNumber += RandomNumber
            End If
        End While

        otp = RandomNumber

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("enter mail id", "enter password")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"
        e_mail = New MailMessage()
        e_mail.From = New MailAddress("Enter mail-id")
        e_mail.To.Add(emailid) ' ------------------------mail id getting-------------------
        e_mail.Subject = "Your Forget Password OTP"
        e_mail.IsBodyHtml = False
        e_mail.Body = "Hi," & user_text.Text & Environment.NewLine & "Your Forgot Password OTP: " & otp
        Smtp_Server.Send(e_mail)
        MsgBox("Mail Sent")
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (otp_TextBox.Text = Nothing) Then
            If Not (otp_TextBox.Text = otp) Then
                MsgBox("Enter Valid OTP!", MsgBoxStyle.RetryCancel)
            Else
                MsgBox("OTP is Valid!")

                confirm.Enabled = True
                clear.Enabled = True

                Label1.Enabled = True
                Label3.Enabled = True

                Panel1.Enabled = True
                Panel3.Enabled = True

                pass.Enabled = True
                re_pass.Enabled = True

                'Stop the timer.
                Timer1.Stop()
            End If

        Else
            MsgBox("Enter OTP!!", MsgBoxStyle.RetryCancel)

        End If
    End Sub

    Private Sub max_btn_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub min_btn_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Otp_valid()
    End Sub

    Public Sub Otp_valid()
        Dim ts As TimeSpan = targetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            Label5.Text = ts.ToString("mm\:ss")
        Else
            Label5.Text = "00:00"
            Timer1.Stop()
            MsgBox("Time out" & Environment.NewLine & "Click Forgot Password again in Login Page", MsgBoxStyle.Critical)
            Login_Page.Show()
        End If
    End Sub
End Class
