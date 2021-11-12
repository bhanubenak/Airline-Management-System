Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intx As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim inty As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intx
        Me.Height = inty - 40
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click

    End Sub
End Class
