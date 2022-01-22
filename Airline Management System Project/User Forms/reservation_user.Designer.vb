<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservation_user
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservation_user))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ArsflightBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARSDataSet10 = New Airline_Management_System_Project.ARSDataSet10()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ArsflightBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceSelection = New Airline_Management_System_Project.ARSDataSet19()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ars_flightTableAdapter = New Airline_Management_System_Project.ARSDataSet19TableAdapters.ars_flightTableAdapter()
        Me.Ars_flightTableAdapter1 = New Airline_Management_System_Project.ARSDataSet10TableAdapters.ars_flightTableAdapter()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.max_btn = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.feeback_btn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.home_btn = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.abt_dev = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.can_ticket = New System.Windows.Forms.Button()
        Me.reservation = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.date_now_label = New System.Windows.Forms.Label()
        Me.time_now_label = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fli_id_str = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.add_passenger = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fli_name = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.start_time = New System.Windows.Forms.TextBox()
        Me.end_time = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArsflightBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARSDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArsflightBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.search_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(218, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 721)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Maiandra GD", 23.25!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.Location = New System.Drawing.Point(123, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(526, 98)
        Me.RichTextBox1.TabIndex = 94
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Reservation Page"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(534, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 15)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Select the Destination"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(205, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 15)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Select the Source"
        Me.Label9.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 278)
        Me.DataGridView1.TabIndex = 91
        Me.DataGridView1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ComboBox2.DataSource = Me.ArsflightBindingSource1
        Me.ComboBox2.DisplayMember = "fli_desti"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(404, 240)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(189, 29)
        Me.ComboBox2.TabIndex = 90
        Me.ComboBox2.ValueMember = "fli_desti"
        '
        'ArsflightBindingSource1
        '
        Me.ArsflightBindingSource1.DataMember = "ars_flight"
        Me.ArsflightBindingSource1.DataSource = Me.ARSDataSet10
        '
        'ARSDataSet10
        '
        Me.ARSDataSet10.DataSetName = "ARSDataSet10"
        Me.ARSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ComboBox1.DataSource = Me.ArsflightBindingSource
        Me.ComboBox1.DisplayMember = "fli_source"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 29)
        Me.ComboBox1.TabIndex = 89
        Me.ComboBox1.ValueMember = "fli_source"
        '
        'ArsflightBindingSource
        '
        Me.ArsflightBindingSource.DataMember = "ars_flight"
        Me.ArsflightBindingSource.DataSource = Me.SourceSelection
        '
        'SourceSelection
        '
        Me.SourceSelection.DataSetName = "SourceSelection"
        Me.SourceSelection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.Color.Coral
        Me.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.search_btn.FlatAppearance.BorderSize = 0
        Me.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.search_btn.ForeColor = System.Drawing.Color.Black
        Me.search_btn.Location = New System.Drawing.Point(264, 331)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(230, 49)
        Me.search_btn.TabIndex = 41
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(409, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Destination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(77, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Source"
        '
        'Ars_flightTableAdapter
        '
        Me.Ars_flightTableAdapter.ClearBeforeFill = True
        '
        'Ars_flightTableAdapter1
        '
        Me.Ars_flightTableAdapter1.ClearBeforeFill = True
        '
        'min_btn
        '
        Me.min_btn.BackgroundImage = CType(resources.GetObject("min_btn.BackgroundImage"), System.Drawing.Image)
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Location = New System.Drawing.Point(1250, 3)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(36, 36)
        Me.min_btn.TabIndex = 186
        Me.min_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Location = New System.Drawing.Point(1334, 3)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(36, 36)
        Me.close_btn.TabIndex = 184
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'max_btn
        '
        Me.max_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.max_btn.BackgroundImage = CType(resources.GetObject("max_btn.BackgroundImage"), System.Drawing.Image)
        Me.max_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.max_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.max_btn.Location = New System.Drawing.Point(1292, 3)
        Me.max_btn.Name = "max_btn"
        Me.max_btn.Size = New System.Drawing.Size(36, 36)
        Me.max_btn.TabIndex = 185
        Me.max_btn.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.min_btn)
        Me.Panel7.Controls.Add(Me.max_btn)
        Me.Panel7.Controls.Add(Me.close_btn)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1374, 47)
        Me.Panel7.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.Controls.Add(Me.PictureBox7)
        Me.Panel11.Controls.Add(Me.feeback_btn)
        Me.Panel11.Controls.Add(Me.PictureBox5)
        Me.Panel11.Controls.Add(Me.home_btn)
        Me.Panel11.Controls.Add(Me.logout)
        Me.Panel11.Controls.Add(Me.PictureBox4)
        Me.Panel11.Controls.Add(Me.PictureBox3)
        Me.Panel11.Controls.Add(Me.abt_dev)
        Me.Panel11.Controls.Add(Me.PictureBox2)
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Controls.Add(Me.can_ticket)
        Me.Panel11.Controls.Add(Me.reservation)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 47)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(218, 721)
        Me.Panel11.TabIndex = 187
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1, 461)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(59, 51)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        '
        'feeback_btn
        '
        Me.feeback_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.feeback_btn.FlatAppearance.BorderSize = 0
        Me.feeback_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.feeback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.feeback_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.feeback_btn.ForeColor = System.Drawing.Color.Black
        Me.feeback_btn.Location = New System.Drawing.Point(60, 464)
        Me.feeback_btn.Name = "feeback_btn"
        Me.feeback_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.feeback_btn.Size = New System.Drawing.Size(158, 44)
        Me.feeback_btn.TabIndex = 26
        Me.feeback_btn.Text = "Feedback Form"
        Me.feeback_btn.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 246)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.home_btn.FlatAppearance.BorderSize = 0
        Me.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.home_btn.ForeColor = System.Drawing.Color.Black
        Me.home_btn.Location = New System.Drawing.Point(62, 258)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.home_btn.Size = New System.Drawing.Size(153, 37)
        Me.home_btn.TabIndex = 15
        Me.home_btn.Text = "Home"
        Me.home_btn.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.logout.ForeColor = System.Drawing.Color.Black
        Me.logout.Location = New System.Drawing.Point(61, 611)
        Me.logout.Name = "logout"
        Me.logout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.logout.Size = New System.Drawing.Size(157, 33)
        Me.logout.TabIndex = 10
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 598)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 56)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 529)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'abt_dev
        '
        Me.abt_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.abt_dev.FlatAppearance.BorderSize = 0
        Me.abt_dev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.abt_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abt_dev.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.abt_dev.ForeColor = System.Drawing.Color.Black
        Me.abt_dev.Location = New System.Drawing.Point(60, 536)
        Me.abt_dev.Name = "abt_dev"
        Me.abt_dev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.abt_dev.Size = New System.Drawing.Size(158, 44)
        Me.abt_dev.TabIndex = 9
        Me.abt_dev.Text = "About Developer"
        Me.abt_dev.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 394)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'can_ticket
        '
        Me.can_ticket.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.can_ticket.Enabled = False
        Me.can_ticket.FlatAppearance.BorderSize = 0
        Me.can_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.can_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.can_ticket.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.can_ticket.ForeColor = System.Drawing.Color.Black
        Me.can_ticket.Location = New System.Drawing.Point(61, 402)
        Me.can_ticket.Name = "can_ticket"
        Me.can_ticket.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.can_ticket.Size = New System.Drawing.Size(157, 39)
        Me.can_ticket.TabIndex = 8
        Me.can_ticket.Text = "Cancel Ticket"
        Me.can_ticket.UseVisualStyleBackColor = False
        '
        'reservation
        '
        Me.reservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.reservation.FlatAppearance.BorderSize = 0
        Me.reservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reservation.Font = New System.Drawing.Font("Segoe UI Semibold", 12.68!, System.Drawing.FontStyle.Bold)
        Me.reservation.ForeColor = System.Drawing.Color.Black
        Me.reservation.Location = New System.Drawing.Point(62, 331)
        Me.reservation.Name = "reservation"
        Me.reservation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.reservation.Size = New System.Drawing.Size(156, 37)
        Me.reservation.TabIndex = 7
        Me.reservation.Text = "Reservation"
        Me.reservation.UseVisualStyleBackColor = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel15.Controls.Add(Me.PictureBox6)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(218, 174)
        Me.Panel15.TabIndex = 1
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, -7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(218, 188)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 67
        Me.PictureBox6.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.date_now_label)
        Me.Panel2.Controls.Add(Me.time_now_label)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.fli_id_str)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.add_passenger)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.fli_name)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.price)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.start_time)
        Me.Panel2.Controls.Add(Me.end_time)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(947, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 721)
        Me.Panel2.TabIndex = 188
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(230, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 162
        Me.Label12.Text = "TIme: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(230, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 23)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Date : "
        '
        'date_now_label
        '
        Me.date_now_label.AutoSize = True
        Me.date_now_label.BackColor = System.Drawing.Color.Transparent
        Me.date_now_label.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.date_now_label.ForeColor = System.Drawing.Color.Coral
        Me.date_now_label.Location = New System.Drawing.Point(299, 31)
        Me.date_now_label.Name = "date_now_label"
        Me.date_now_label.Size = New System.Drawing.Size(104, 23)
        Me.date_now_label.TabIndex = 160
        Me.date_now_label.Text = "present day"
        '
        'time_now_label
        '
        Me.time_now_label.AutoSize = True
        Me.time_now_label.BackColor = System.Drawing.Color.Transparent
        Me.time_now_label.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.time_now_label.ForeColor = System.Drawing.Color.Coral
        Me.time_now_label.Location = New System.Drawing.Point(299, 63)
        Me.time_now_label.Name = "time_now_label"
        Me.time_now_label.Size = New System.Drawing.Size(112, 23)
        Me.time_now_label.TabIndex = 159
        Me.time_now_label.Text = "present time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 23)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(13, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Flight-Id"
        '
        'fli_id_str
        '
        Me.fli_id_str.BackColor = System.Drawing.SystemColors.Window
        Me.fli_id_str.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fli_id_str.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fli_id_str.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fli_id_str.Location = New System.Drawing.Point(17, 181)
        Me.fli_id_str.Name = "fli_id_str"
        Me.fli_id_str.ReadOnly = True
        Me.fli_id_str.Size = New System.Drawing.Size(178, 21)
        Me.fli_id_str.TabIndex = 156
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(17, 202)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(178, 2)
        Me.Panel6.TabIndex = 157
        '
        'add_passenger
        '
        Me.add_passenger.BackColor = System.Drawing.Color.Peru
        Me.add_passenger.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.add_passenger.FlatAppearance.BorderSize = 2
        Me.add_passenger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.add_passenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_passenger.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.add_passenger.ForeColor = System.Drawing.Color.Black
        Me.add_passenger.Location = New System.Drawing.Point(11, 518)
        Me.add_passenger.Name = "add_passenger"
        Me.add_passenger.Size = New System.Drawing.Size(185, 48)
        Me.add_passenger.TabIndex = 154
        Me.add_passenger.Text = "Add Passenger"
        Me.add_passenger.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Flight Name"
        '
        'fli_name
        '
        Me.fli_name.BackColor = System.Drawing.SystemColors.Window
        Me.fli_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fli_name.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fli_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fli_name.Location = New System.Drawing.Point(17, 254)
        Me.fli_name.Name = "fli_name"
        Me.fli_name.ReadOnly = True
        Me.fli_name.Size = New System.Drawing.Size(178, 21)
        Me.fli_name.TabIndex = 141
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(17, 275)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 2)
        Me.Panel3.TabIndex = 142
        '
        'price
        '
        Me.price.BackColor = System.Drawing.SystemColors.Window
        Me.price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.price.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.price.Location = New System.Drawing.Point(18, 324)
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Size = New System.Drawing.Size(177, 21)
        Me.price.TabIndex = 143
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(18, 337)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(177, 10)
        Me.Panel4.TabIndex = 144
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(268, 350)
        Me.DateTimePicker1.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 27)
        Me.DateTimePicker1.TabIndex = 145
        Me.DateTimePicker1.Value = New Date(2022, 1, 1, 0, 0, 0, 0)
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Peru
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(253, 518)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 48)
        Me.btnExit.TabIndex = 153
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(264, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Start time"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(18, 487)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(178, 2)
        Me.Panel5.TabIndex = 152
        '
        'start_time
        '
        Me.start_time.BackColor = System.Drawing.Color.White
        Me.start_time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.start_time.Font = New System.Drawing.Font("Maiandra GD", 12.75!)
        Me.start_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.start_time.Location = New System.Drawing.Point(17, 394)
        Me.start_time.Name = "start_time"
        Me.start_time.ReadOnly = True
        Me.start_time.Size = New System.Drawing.Size(178, 21)
        Me.start_time.TabIndex = 148
        '
        'end_time
        '
        Me.end_time.BackColor = System.Drawing.Color.White
        Me.end_time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.end_time.Font = New System.Drawing.Font("Maiandra GD", 12.75!)
        Me.end_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.end_time.Location = New System.Drawing.Point(18, 468)
        Me.end_time.Name = "end_time"
        Me.end_time.ReadOnly = True
        Me.end_time.Size = New System.Drawing.Size(178, 21)
        Me.end_time.TabIndex = 151
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(17, 416)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(178, 2)
        Me.Panel8.TabIndex = 149
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 23)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "End time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(-55, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Price"
        '
        'reservation_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1374, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reservation_user"
        Me.Text = "reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArsflightBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARSDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArsflightBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents search_btn As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SourceSelection As ARSDataSet19
    Friend WithEvents ArsflightBindingSource As BindingSource
    Friend WithEvents Ars_flightTableAdapter As ARSDataSet19TableAdapters.ars_flightTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ARSDataSet10 As ARSDataSet10
    Friend WithEvents ArsflightBindingSource1 As BindingSource
    Friend WithEvents Ars_flightTableAdapter1 As ARSDataSet10TableAdapters.ars_flightTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents min_btn As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents max_btn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents home_btn As Button
    Friend WithEvents logout As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents abt_dev As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents can_ticket As Button
    Friend WithEvents reservation As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents fli_id_str As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents add_passenger As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents fli_name As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents price As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents start_time As TextBox
    Friend WithEvents end_time As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents date_now_label As Label
    Friend WithEvents time_now_label As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents feeback_btn As Button
End Class
