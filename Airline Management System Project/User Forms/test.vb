Imports System.Data.SqlClient

Public Class test
    ReadOnly conn As New SqlConnection("Data Source=(localdb)\ProjectsV13; initial Catalog=ARS; integrated security=True;")

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim cmdstr As String = "SELECT username, password FROM ars_register WHERE (username = '" _
                              + username.Text _
                              + "' ) AND (password = '" _
                              + passowrd.Text _
                              + "') "
        Dim cmd As New SqlCommand(cmdstr, conn)

        Dim user As String = username.Text
        Dim pass As String = passowrd.Text

        Dim user1, pass1 As String
        conn.Open()
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        If lrd.HasRows Then
            While lrd.Read()

                pass1 = lrd("password").ToString()
                user1 = lrd("username").ToString()

                If pass = pass1 And user = user1 Then

                    MessageBox.Show("account already exit, Create account with new details or goto login deatils " & user, " ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MsgBox("Details not found")

                End If

            End While
            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        Dim combo As String = ComboBox1.SelectedItem.ToString()
        MsgBox(combo)

        Dim c1 As Integer = Val(combo)
        MsgBox(c1)

    End Sub
End Class