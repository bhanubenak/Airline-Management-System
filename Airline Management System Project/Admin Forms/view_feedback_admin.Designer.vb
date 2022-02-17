<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_feedback_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_feedback_admin))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.max_btn = New System.Windows.Forms.Button()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.feedback_grid = New System.Windows.Forms.DataGridView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_flight_info = New System.Windows.Forms.Button()
        Me.View_custo_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.feedback_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Controls.Add(Me.max_btn)
        Me.Panel1.Controls.Add(Me.min_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 44)
        Me.Panel1.TabIndex = 193
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Location = New System.Drawing.Point(1289, 3)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(36, 36)
        Me.close_btn.TabIndex = 184
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'max_btn
        '
        Me.max_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.max_btn.BackgroundImage = CType(resources.GetObject("max_btn.BackgroundImage"), System.Drawing.Image)
        Me.max_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.max_btn.Location = New System.Drawing.Point(1247, 3)
        Me.max_btn.Name = "max_btn"
        Me.max_btn.Size = New System.Drawing.Size(36, 36)
        Me.max_btn.TabIndex = 185
        Me.max_btn.UseVisualStyleBackColor = False
        '
        'min_btn
        '
        Me.min_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.min_btn.BackgroundImage = CType(resources.GetObject("min_btn.BackgroundImage"), System.Drawing.Image)
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Location = New System.Drawing.Point(1205, 3)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(36, 36)
        Me.min_btn.TabIndex = 186
        Me.min_btn.UseVisualStyleBackColor = False
        '
        'feedback_grid
        '
        Me.feedback_grid.AllowUserToAddRows = False
        Me.feedback_grid.AllowUserToDeleteRows = False
        Me.feedback_grid.BackgroundColor = System.Drawing.Color.LightGray
        Me.feedback_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.feedback_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.feedback_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.feedback_grid.Location = New System.Drawing.Point(188, 180)
        Me.feedback_grid.Name = "feedback_grid"
        Me.feedback_grid.ReadOnly = True
        Me.feedback_grid.Size = New System.Drawing.Size(1111, 363)
        Me.feedback_grid.TabIndex = 194
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(456, 73)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(421, 72)
        Me.RichTextBox1.TabIndex = 195
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "View Customer Feeback"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btn_flight_info)
        Me.Panel2.Controls.Add(Me.View_custo_btn)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 511)
        Me.Panel2.TabIndex = 197
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(185, 160)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 190
        Me.PictureBox6.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 50)
        Me.Button1.TabIndex = 189
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
        Me.Button2.Location = New System.Drawing.Point(0, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 43)
        Me.Button2.TabIndex = 186
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.btn_flight_info.Location = New System.Drawing.Point(0, 257)
        Me.btn_flight_info.Name = "btn_flight_info"
        Me.btn_flight_info.Size = New System.Drawing.Size(185, 45)
        Me.btn_flight_info.TabIndex = 185
        Me.btn_flight_info.Text = "Create / Modify Flights"
        Me.btn_flight_info.UseVisualStyleBackColor = False
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
        Me.View_custo_btn.Location = New System.Drawing.Point(0, 308)
        Me.View_custo_btn.Name = "View_custo_btn"
        Me.View_custo_btn.Size = New System.Drawing.Size(185, 45)
        Me.View_custo_btn.TabIndex = 187
        Me.View_custo_btn.Text = "View Users Details"
        Me.View_custo_btn.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(0, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 43)
        Me.Button3.TabIndex = 188
        Me.Button3.Text = "Logout"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'view_feedback_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1331, 555)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.feedback_grid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_feedback_admin"
        Me.Text = "view_feedback_admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.feedback_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_btn As Button
    Friend WithEvents max_btn As Button
    Friend WithEvents min_btn As Button
    Friend WithEvents feedback_grid As DataGridView
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_flight_info As Button
    Friend WithEvents View_custo_btn As Button
    Friend WithEvents Button3 As Button
End Class
