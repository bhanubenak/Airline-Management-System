Imports System.Drawing.Printing
Public Class print_ticket
    Private Sub print_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        print_ticket()
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

    Private Sub prndocPrintTicket_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prndocPrintTicket.PrintPage
        e.Graphics.DrawString(txtprint.Text, New Font("Century Schoolbook", 10, FontStyle.Bold), Brushes.Black, 150, 125)
    End Sub


    Public Sub print_ticket()
        'print code
        txtprint.BackColor = Color.WhiteSmoke
        txtprint.Text = "                                                 INDIAN AIRWAYS                                "
        txtprint.Text &= Chr(13) & "                                                    "
        txtprint.Text &= Chr(13) & "                                                     "
        txtprint.Text &= Chr(13) & "                                                    Passenger Ticket"
        txtprint.Text &= Chr(13) & "      ----------------------------------------------------------------------------------------------------------------"
        txtprint.Text &= Chr(13) & "                                                                                         Issued On: " & DateTime.Now
        txtprint.Text &= Chr(13) & "             NOT TRANSFERABLE" & Chr(13) & Chr(13)
        txtprint.Text &= Chr(13) & Chr(13) & "   PNR No. : " & Reserve_page.pnr_no_text.Text
        txtprint.Text &= Chr(13) & Chr(13) & "  First Name: " & Reserve_page.txtfname.Text & "                                                Last Name: " & Reserve_page.txtfname.Text
        txtprint.Text &= Chr(13) & Chr(13) & "   Airline Name: " & Reserve_page.fli_name.Text
        txtprint.Text &= Chr(13) & Chr(13) & "   Flight No: " & reservation_user.fli_id_str.Text
        txtprint.Text &= Chr(13) & Chr(13) & "   Arrival Time : " & reservation_user.start_time.Text & "                                     Departure Time : " & reservation_user.end_time.Text

        txtprint.Text &= Chr(13) & Chr(13) & "   Travel Date : " & reservation_user.DateTimePicker1.Value
        txtprint.Text &= Chr(13) & Chr(13) & "   Source Location : " & reservation_user.ComboBox1.Text
        txtprint.Text &= Chr(13) & Chr(13) & "   Destination Location : " & reservation_user.ComboBox2.Text
        txtprint.Text &= Chr(13) & "  ------------------------------WISH YOU HAPPY JOURNEY-------------------------------------------------------"
    End Sub

    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click
        prndlgPrintTicket.Document = prndocPrintTicket
        Dim result As DialogResult = prndlgPrintTicket.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            prndocPrintTicket.Print()
        End If

        home_user.Show()
        Me.Hide()
    End Sub
End Class