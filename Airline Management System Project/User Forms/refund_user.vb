Imports System.Drawing.Printing
Public Class refund_user

    Private Sub print_cancle_ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPrint.BackColor = Color.WhiteSmoke
        txtPrint.Text = "                                                 INDIAN AIRWAYS                                "
        txtPrint.Text &= Chr(13) & "                                                    "
        txtPrint.Text &= Chr(13) & "                                                     "
        txtPrint.Text &= Chr(13) & "                                                    Ticket Refund Receipt"
        txtPrint.Text &= Chr(13) & "      ----------------------------------------------------------------------------------------------------------------"
        txtPrint.Text &= Chr(13) & "                                                                                   Issued On: " & DateTime.Now
        txtPrint.Text &= Chr(13) & "             NOT TRANSFERABLE" & Chr(13) & Chr(13)
        txtPrint.Text &= Chr(13) & Chr(13) & "   PNR No. : " & Cancel_flight_user.pnr_btn_cancel.Text
        '  txtPrint.Text &= Chr(13) & Chr(13) & "   First. : " & Cancel_flight_user.pnr_btn_cancel.Text

        txtPrint.Text &= Chr(13) & Chr(13) & "   Flight Name: " & Cancel_flight_user.fli_name_cancel.Text
        txtPrint.Text &= Chr(13) & Chr(13) & "   Travel Date : " & Cancel_flight_user.fli_date_cancel.Text
        txtPrint.Text &= Chr(13) & Chr(13) & "   Source Location : " & Cancel_flight_user.source_cancel.Text
        txtPrint.Text &= Chr(13) & Chr(13) & "   Destination Location : " & Cancel_flight_user.desti_cancel.Text
        txtPrint.Text &= Chr(13) & Chr(13) & "   Fare Amount :" & Cancel_flight_user.fli_price_cancel.Text & "                                             Refund Amount : " & Cancel_flight_user.cancel_refund_text.Text

        txtPrint.Text &= Chr(13) & "---------------------------------------------------HAVE A GOOD DAY----------------------------------------------------"
    End Sub


    Private Sub prndocPrintTicket_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prndocPrintTicket.PrintPage
        e.Graphics.DrawString(txtPrint.Text, New Font("Century Schoolbook", 10, FontStyle.Bold), Brushes.Red, 150, 125)
    End Sub

    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click
        prndlgPrintTicket.Document = prndocPrintTicket
        Dim result As DialogResult = prndlgPrintTicket.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            prndocPrintTicket.Print()
        End If
    End Sub

    Private Sub close_print_btn_Click(sender As Object, e As EventArgs) Handles close_print_btn.Click
        Cancel_flight_user.Show()
        Me.Hide()
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
End Class