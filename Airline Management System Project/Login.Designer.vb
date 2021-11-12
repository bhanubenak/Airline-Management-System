<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minbtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Maxbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.login = New System.Windows.Forms.Label()
        Me.usrname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minbtn)
        Me.Panel1.Controls.Add(Me.closebtn)
        Me.Panel1.Controls.Add(Me.Maxbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 35)
        Me.Panel1.TabIndex = 0
        '
        'minbtn
        '
        Me.minbtn.BackColor = System.Drawing.Color.Transparent
        Me.minbtn.BackgroundImage = Global.Airline_Management_System_Project.My.Resources.Resources.min
        Me.minbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minbtn.FlatAppearance.BorderSize = 0
        Me.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minbtn.Location = New System.Drawing.Point(586, 5)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(21, 22)
        Me.minbtn.TabIndex = 4
        Me.minbtn.UseVisualStyleBackColor = False
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Transparent
        Me.closebtn.BackgroundImage = Global.Airline_Management_System_Project.My.Resources.Resources.close_button
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.FlatAppearance.BorderSize = 0
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.Location = New System.Drawing.Point(644, 3)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(32, 26)
        Me.closebtn.TabIndex = 2
        Me.closebtn.UseVisualStyleBackColor = False
        '
        'Maxbtn
        '
        Me.Maxbtn.BackColor = System.Drawing.Color.Transparent
        Me.Maxbtn.BackgroundImage = Global.Airline_Management_System_Project.My.Resources.Resources.max
        Me.Maxbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Maxbtn.FlatAppearance.BorderSize = 0
        Me.Maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maxbtn.Location = New System.Drawing.Point(613, 6)
        Me.Maxbtn.Name = "Maxbtn"
        Me.Maxbtn.Size = New System.Drawing.Size(25, 23)
        Me.Maxbtn.TabIndex = 3
        Me.Maxbtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BackgroundImage = Global.Airline_Management_System_Project.My.Resources.Resources.background
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.usrname)
        Me.Panel2.Controls.Add(Me.login)
        Me.Panel2.Location = New System.Drawing.Point(25, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 423)
        Me.Panel2.TabIndex = 1
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.login.Location = New System.Drawing.Point(405, 22)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(66, 26)
        Me.login.TabIndex = 0
        Me.login.Text = "LOGIN"
        '
        'usrname
        '
        Me.usrname.AutoSize = True
        Me.usrname.BackColor = System.Drawing.Color.Transparent
        Me.usrname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrname.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.usrname.Location = New System.Drawing.Point(330, 101)
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(72, 20)
        Me.usrname.TabIndex = 1
        Me.usrname.Text = "Uername"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(330, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(418, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 24)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CausesValidation = False
        Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic Medium", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(418, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 24)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(339, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airline_Management_System_Project.My.Resources.Resources.login_or_register_pic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 476)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents minbtn As Button
    Friend WithEvents Maxbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usrname As Label
    Friend WithEvents login As Label
    Friend WithEvents Button1 As Button
End Class
