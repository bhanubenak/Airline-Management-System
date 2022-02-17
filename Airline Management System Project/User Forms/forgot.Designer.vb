<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.confirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.re_pass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.otp_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.user_text = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(77, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(343, 75)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Forgot Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(59, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 23)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Username"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(63, 227)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(178, 2)
        Me.Panel6.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(33, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Password"
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.SystemColors.Control
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Enabled = False
        Me.pass.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pass.Location = New System.Drawing.Point(37, 444)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(178, 21)
        Me.pass.TabIndex = 159
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(37, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 2)
        Me.Panel3.TabIndex = 160
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.Peru
        Me.confirm.Enabled = False
        Me.confirm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.confirm.FlatAppearance.BorderSize = 0
        Me.confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirm.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.confirm.ForeColor = System.Drawing.Color.Black
        Me.confirm.Location = New System.Drawing.Point(63, 532)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(150, 46)
        Me.confirm.TabIndex = 164
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(318, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 23)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Re-type Password"
        '
        're_pass
        '
        Me.re_pass.BackColor = System.Drawing.SystemColors.Control
        Me.re_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.re_pass.Enabled = False
        Me.re_pass.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.re_pass.Location = New System.Drawing.Point(322, 444)
        Me.re_pass.Name = "re_pass"
        Me.re_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.re_pass.Size = New System.Drawing.Size(178, 21)
        Me.re_pass.TabIndex = 166
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(322, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 2)
        Me.Panel1.TabIndex = 167
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Peru
        Me.clear.Enabled = False
        Me.clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.clear.FlatAppearance.BorderSize = 0
        Me.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.clear.ForeColor = System.Drawing.Color.Black
        Me.clear.Location = New System.Drawing.Point(306, 532)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(142, 46)
        Me.clear.TabIndex = 168
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(299, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 44)
        Me.Button2.TabIndex = 169
        Me.Button2.Text = "Send OTP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Peru
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(303, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 46)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "Confirm OTP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(46, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Send OTP"
        '
        'otp_TextBox
        '
        Me.otp_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.otp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.otp_TextBox.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otp_TextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.otp_TextBox.Location = New System.Drawing.Point(50, 308)
        Me.otp_TextBox.Name = "otp_TextBox"
        Me.otp_TextBox.Size = New System.Drawing.Size(178, 21)
        Me.otp_TextBox.TabIndex = 171
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(50, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 2)
        Me.Panel2.TabIndex = 172
        '
        'user_text
        '
        Me.user_text.BackColor = System.Drawing.SystemColors.Control
        Me.user_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user_text.Font = New System.Drawing.Font("Maiandra GD", 12.75!)
        Me.user_text.Location = New System.Drawing.Point(63, 206)
        Me.user_text.Name = "user_text"
        Me.user_text.Size = New System.Drawing.Size(178, 21)
        Me.user_text.TabIndex = 174
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(90, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Enter OTP in:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.99!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(170, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 19)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "time_display"
        Me.Label5.Visible = False
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(426, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 177
        Me.Label6.Visible = False
        '
        'forgot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 646)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.user_text)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.otp_TextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.re_pass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "forgot"
        Me.Text = "Forgot_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents confirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents re_pass As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents clear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents otp_TextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents user_text As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
