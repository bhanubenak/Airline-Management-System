<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home_admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.display_name_admin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UserData_admin = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.View_custo_btn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_flight_info = New System.Windows.Forms.Button()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.max_btn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.UserData_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.display_name_admin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.UserData_admin)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(187, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1163, 697)
        Me.Panel1.TabIndex = 0
        '
        'display_name_admin
        '
        Me.display_name_admin.AutoSize = True
        Me.display_name_admin.BackColor = System.Drawing.Color.Turquoise
        Me.display_name_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.display_name_admin.Font = New System.Drawing.Font("Pristina", 33.0!, System.Drawing.FontStyle.Bold)
        Me.display_name_admin.ForeColor = System.Drawing.SystemColors.Highlight
        Me.display_name_admin.Location = New System.Drawing.Point(637, 17)
        Me.display_name_admin.Margin = New System.Windows.Forms.Padding(0)
        Me.display_name_admin.Name = "display_name_admin"
        Me.display_name_admin.Size = New System.Drawing.Size(0, 58)
        Me.display_name_admin.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1029, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Check for personal Details"
        Me.Label2.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.25!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(969, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 38)
        Me.Button5.TabIndex = 55
        Me.Button5.Text = "Personal Details"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'UserData_admin
        '
        Me.UserData_admin.AllowUserToAddRows = False
        Me.UserData_admin.AllowUserToDeleteRows = False
        Me.UserData_admin.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.UserData_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserData_admin.Location = New System.Drawing.Point(332, 179)
        Me.UserData_admin.Name = "UserData_admin"
        Me.UserData_admin.ReadOnly = True
        Me.UserData_admin.Size = New System.Drawing.Size(572, 244)
        Me.UserData_admin.TabIndex = 54
        Me.UserData_admin.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(218, 466)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(903, 194)
        Me.DataGridView1.TabIndex = 53
        Me.DataGridView1.Visible = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel11.Location = New System.Drawing.Point(549, 60)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(235, 2)
        Me.Panel11.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Pristina", 23.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(503, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 50)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "View Feedback"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 556)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 43)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'View_custo_btn
        '
        Me.View_custo_btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.View_custo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.View_custo_btn.FlatAppearance.BorderSize = 0
        Me.View_custo_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.View_custo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.View_custo_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.View_custo_btn.ForeColor = System.Drawing.Color.White
        Me.View_custo_btn.Location = New System.Drawing.Point(0, 394)
        Me.View_custo_btn.Name = "View_custo_btn"
        Me.View_custo_btn.Size = New System.Drawing.Size(185, 45)
        Me.View_custo_btn.TabIndex = 50
        Me.View_custo_btn.Text = "View Users Details"
        Me.View_custo_btn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 43)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Modify Admin"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_flight_info
        '
        Me.btn_flight_info.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_flight_info.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_flight_info.FlatAppearance.BorderSize = 0
        Me.btn_flight_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_flight_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_flight_info.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_flight_info.ForeColor = System.Drawing.Color.White
        Me.btn_flight_info.Location = New System.Drawing.Point(0, 294)
        Me.btn_flight_info.Name = "btn_flight_info"
        Me.btn_flight_info.Size = New System.Drawing.Size(185, 45)
        Me.btn_flight_info.TabIndex = 44
        Me.btn_flight_info.Text = "Create / Modify Flights"
        Me.btn_flight_info.UseVisualStyleBackColor = False
        '
        'min_btn
        '
        Me.min_btn.BackColor = System.Drawing.Color.Transparent
        Me.min_btn.BackgroundImage = CType(resources.GetObject("min_btn.BackgroundImage"), System.Drawing.Image)
        Me.min_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.min_btn.FlatAppearance.BorderSize = 0
        Me.min_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Location = New System.Drawing.Point(1230, -2)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(36, 36)
        Me.min_btn.TabIndex = 183
        Me.min_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Location = New System.Drawing.Point(1314, -2)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(36, 36)
        Me.close_btn.TabIndex = 181
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'max_btn
        '
        Me.max_btn.BackColor = System.Drawing.Color.Transparent
        Me.max_btn.BackgroundImage = CType(resources.GetObject("max_btn.BackgroundImage"), System.Drawing.Image)
        Me.max_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.max_btn.FlatAppearance.BorderSize = 0
        Me.max_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.max_btn.Location = New System.Drawing.Point(1272, -2)
        Me.max_btn.Name = "max_btn"
        Me.max_btn.Size = New System.Drawing.Size(36, 36)
        Me.max_btn.TabIndex = 182
        Me.max_btn.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 40)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(185, 160)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 184
        Me.PictureBox6.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 501)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 43)
        Me.Button3.TabIndex = 185
        Me.Button3.Text = "About Us"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'home_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.min_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.max_btn)
        Me.Controls.Add(Me.btn_flight_info)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.View_custo_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home_admin"
        Me.Text = "home_admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserData_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btn_flight_info As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents View_custo_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserData_admin As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents min_btn As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents max_btn As Button
    Friend WithEvents display_name_admin As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button3 As Button
End Class
