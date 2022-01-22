<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print_ticket))
        Me.close_btn = New System.Windows.Forms.Button()
        Me.max_btn = New System.Windows.Forms.Button()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtprint = New System.Windows.Forms.RichTextBox()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.close_print_btn = New System.Windows.Forms.Button()
        Me.prndocPrintTicket = New System.Drawing.Printing.PrintDocument()
        Me.prndlgPrintTicket = New System.Windows.Forms.PrintDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.close_btn.BackgroundImage = CType(resources.GetObject("close_btn.BackgroundImage"), System.Drawing.Image)
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Location = New System.Drawing.Point(1072, 0)
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
        Me.max_btn.Location = New System.Drawing.Point(1030, 0)
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
        Me.min_btn.Location = New System.Drawing.Point(988, 0)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(36, 36)
        Me.min_btn.TabIndex = 186
        Me.min_btn.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(1117, 44)
        Me.Panel1.TabIndex = 187
        '
        'txtprint
        '
        Me.txtprint.Location = New System.Drawing.Point(94, 145)
        Me.txtprint.Name = "txtprint"
        Me.txtprint.ReadOnly = True
        Me.txtprint.Size = New System.Drawing.Size(753, 616)
        Me.txtprint.TabIndex = 188
        Me.txtprint.Text = ""
        '
        'print_btn
        '
        Me.print_btn.BackColor = System.Drawing.Color.IndianRed
        Me.print_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.print_btn.FlatAppearance.BorderSize = 0
        Me.print_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.print_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print_btn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.print_btn.ForeColor = System.Drawing.Color.Black
        Me.print_btn.Location = New System.Drawing.Point(900, 528)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(135, 38)
        Me.print_btn.TabIndex = 189
        Me.print_btn.Text = "Print"
        Me.print_btn.UseVisualStyleBackColor = False
        '
        'close_print_btn
        '
        Me.close_print_btn.BackColor = System.Drawing.Color.IndianRed
        Me.close_print_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.close_print_btn.FlatAppearance.BorderSize = 0
        Me.close_print_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.close_print_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.close_print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_print_btn.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.close_print_btn.ForeColor = System.Drawing.Color.Black
        Me.close_print_btn.Location = New System.Drawing.Point(900, 589)
        Me.close_print_btn.Name = "close_print_btn"
        Me.close_print_btn.Size = New System.Drawing.Size(135, 38)
        Me.close_print_btn.TabIndex = 190
        Me.close_print_btn.Text = "close"
        Me.close_print_btn.UseVisualStyleBackColor = False
        '
        'prndocPrintTicket
        '
        '
        'prndlgPrintTicket
        '
        Me.prndlgPrintTicket.UseEXDialog = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(339, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(362, 62)
        Me.RichTextBox1.TabIndex = 191
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Print Ticket"
        '
        'print_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1117, 788)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.close_print_btn)
        Me.Controls.Add(Me.print_btn)
        Me.Controls.Add(Me.txtprint)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_ticket"
        Me.Text = "print_ticket"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents close_btn As Button
    Friend WithEvents max_btn As Button
    Friend WithEvents min_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtprint As RichTextBox
    Friend WithEvents print_btn As Button
    Friend WithEvents close_print_btn As Button
    Friend WithEvents prndocPrintTicket As Printing.PrintDocument
    Friend WithEvents prndlgPrintTicket As PrintDialog
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
