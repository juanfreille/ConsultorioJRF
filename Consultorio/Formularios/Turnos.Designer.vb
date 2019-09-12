<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turnos))
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.lbl_obsercaciones = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.grp_hora = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbHora = New System.Windows.Forms.ComboBox()
        Me.cmb_medicos = New System.Windows.Forms.ComboBox()
        Me.lbl_doctor = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.bReservar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel3 = New Consultorio.MyPanel()
        Me.MyPanel4 = New Consultorio.MyPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_hora.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel3.SuspendLayout()
        Me.MyPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(161, 155)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(315, 110)
        Me.txt_observaciones.TabIndex = 37
        '
        'lbl_obsercaciones
        '
        Me.lbl_obsercaciones.AutoSize = True
        Me.lbl_obsercaciones.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_obsercaciones.Location = New System.Drawing.Point(20, 155)
        Me.lbl_obsercaciones.Name = "lbl_obsercaciones"
        Me.lbl_obsercaciones.Size = New System.Drawing.Size(117, 23)
        Me.lbl_obsercaciones.TabIndex = 36
        Me.lbl_obsercaciones.Text = "Observaciones"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_fecha.Location = New System.Drawing.Point(13, 49)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(64, 23)
        Me.lbl_fecha.TabIndex = 33
        Me.lbl_fecha.Text = "Fecha *"
        '
        'grp_hora
        '
        Me.grp_hora.Controls.Add(Me.Label5)
        Me.grp_hora.Controls.Add(Me.cbHora)
        Me.grp_hora.Location = New System.Drawing.Point(5, 97)
        Me.grp_hora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_hora.Name = "grp_hora"
        Me.grp_hora.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_hora.Size = New System.Drawing.Size(541, 169)
        Me.grp_hora.TabIndex = 32
        Me.grp_hora.TabStop = False
        Me.grp_hora.Text = "Hora de turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "(Horarios libres del médico y fecha elegidos)"
        '
        'cbHora
        '
        Me.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHora.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cbHora.FormattingEnabled = True
        Me.cbHora.Location = New System.Drawing.Point(7, 34)
        Me.cbHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHora.Name = "cbHora"
        Me.cbHora.Size = New System.Drawing.Size(164, 30)
        Me.cbHora.TabIndex = 22
        Me.cbHora.Tag = "9999"
        '
        'cmb_medicos
        '
        Me.cmb_medicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_medicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medicos.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cmb_medicos.FormattingEnabled = True
        Me.cmb_medicos.Location = New System.Drawing.Point(119, 18)
        Me.cmb_medicos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_medicos.Name = "cmb_medicos"
        Me.cmb_medicos.Size = New System.Drawing.Size(249, 30)
        Me.cmb_medicos.TabIndex = 27
        '
        'lbl_doctor
        '
        Me.lbl_doctor.AutoSize = True
        Me.lbl_doctor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_doctor.Location = New System.Drawing.Point(17, 23)
        Me.lbl_doctor.Name = "lbl_doctor"
        Me.lbl_doctor.Size = New System.Drawing.Size(69, 23)
        Me.lbl_doctor.TabIndex = 25
        Me.lbl_doctor.Text = "Doctor *"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(111, 44)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(163, 28)
        Me.dtpFecha.TabIndex = 38
        Me.dtpFecha.Tag = "9999"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(161, 97)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(252, 28)
        Me.txtNombre.TabIndex = 40
        '
        'bReservar
        '
        Me.bReservar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bReservar.Location = New System.Drawing.Point(869, 7)
        Me.bReservar.Margin = New System.Windows.Forms.Padding(4)
        Me.bReservar.Name = "bReservar"
        Me.bReservar.Size = New System.Drawing.Size(180, 36)
        Me.bReservar.TabIndex = 46
        Me.bReservar.Text = "RESERVAR"
        Me.bReservar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(161, 37)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(252, 28)
        Me.txtApellido.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Apellido *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 23)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Nombre *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_obsercaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(505, 288)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Paciente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_fecha)
        Me.GroupBox2.Controls.Add(Me.grp_hora)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(547, 288)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha y Hora"
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.cmb_medicos)
        Me.MyPanel1.Controls.Add(Me.lbl_doctor)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(1063, 74)
        Me.MyPanel1.TabIndex = 52
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.GroupBox1)
        Me.MyPanel2.Controls.Add(Me.GroupBox2)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(1063, 430)
        Me.MyPanel2.TabIndex = 53
        '
        'MyPanel3
        '
        Me.MyPanel3.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel3.BorderWidth = 0
        Me.MyPanel3.Controls.Add(Me.bReservar)
        Me.MyPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel3.Location = New System.Drawing.Point(0, 372)
        Me.MyPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel3.Name = "MyPanel3"
        Me.MyPanel3.Size = New System.Drawing.Size(1063, 58)
        Me.MyPanel3.TabIndex = 54
        '
        'MyPanel4
        '
        Me.MyPanel4.BorderColor = System.Drawing.Color.Black
        Me.MyPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel4.BorderWidth = 2
        Me.MyPanel4.Controls.Add(Me.MyPanel1)
        Me.MyPanel4.Controls.Add(Me.MyPanel3)
        Me.MyPanel4.Controls.Add(Me.MyPanel2)
        Me.MyPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel4.Location = New System.Drawing.Point(0, 33)
        Me.MyPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel4.Name = "MyPanel4"
        Me.MyPanel4.Size = New System.Drawing.Size(1065, 432)
        Me.MyPanel4.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 34)
        Me.Panel1.TabIndex = 56
        Me.Panel1.Tag = "9999"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageIndex = 2
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(1028, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrow_down.png")
        Me.ImageList1.Images.SetKeyName(1, "error (2).png")
        Me.ImageList1.Images.SetKeyName(2, "x-mark-32.png")
        Me.ImageList1.Images.SetKeyName(3, "minus-7-32.png")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.15!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Turnos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 465)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Turnos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        Me.grp_hora.ResumeLayout(False)
        Me.grp_hora.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel3.ResumeLayout(False)
        Me.MyPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents lbl_obsercaciones As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents grp_hora As GroupBox
    Friend WithEvents cmb_medicos As ComboBox
    Friend WithEvents lbl_doctor As Label
    Friend WithEvents cbHora As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents bReservar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents MyPanel3 As MyPanel
    Friend WithEvents MyPanel4 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
