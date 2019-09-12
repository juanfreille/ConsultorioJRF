<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerTurnos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerTurnos))
        Me.cmb_medicos2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.grp_grilla = New System.Windows.Forms.GroupBox()
        Me.grid_turnos = New System.Windows.Forms.DataGridView()
        Me.fecha_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel3 = New Consultorio.MyPanel()
        Me.MyPanel4 = New Consultorio.MyPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grp_grilla.SuspendLayout()
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel3.SuspendLayout()
        Me.MyPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_medicos2
        '
        Me.cmb_medicos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medicos2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cmb_medicos2.FormattingEnabled = True
        Me.cmb_medicos2.Location = New System.Drawing.Point(389, 26)
        Me.cmb_medicos2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_medicos2.Name = "cmb_medicos2"
        Me.cmb_medicos2.Size = New System.Drawing.Size(248, 30)
        Me.cmb_medicos2.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(294, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "MÉDICO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "FECHA"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(95, 26)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(173, 30)
        Me.dtpFecha.TabIndex = 49
        '
        'cmd_buscar
        '
        Me.cmd_buscar.AutoSize = True
        Me.cmd_buscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cmd_buscar.Location = New System.Drawing.Point(783, 20)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(119, 37)
        Me.cmd_buscar.TabIndex = 47
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'grp_grilla
        '
        Me.grp_grilla.Controls.Add(Me.grid_turnos)
        Me.grp_grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_grilla.Location = New System.Drawing.Point(0, 0)
        Me.grp_grilla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_grilla.Name = "grp_grilla"
        Me.grp_grilla.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_grilla.Size = New System.Drawing.Size(918, 431)
        Me.grp_grilla.TabIndex = 46
        Me.grp_grilla.TabStop = False
        Me.grp_grilla.Text = "Turnos"
        '
        'grid_turnos
        '
        Me.grid_turnos.AllowUserToAddRows = False
        Me.grid_turnos.AllowUserToDeleteRows = False
        Me.grid_turnos.AllowUserToResizeColumns = False
        Me.grid_turnos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_turnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_turnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_turno, Me.hora_desde, Me.apellido, Me.nombre, Me.observaciones})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_turnos.DefaultCellStyle = DataGridViewCellStyle4
        Me.grid_turnos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grid_turnos.Location = New System.Drawing.Point(3, 77)
        Me.grid_turnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grid_turnos.MultiSelect = False
        Me.grid_turnos.Name = "grid_turnos"
        Me.grid_turnos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_turnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_turnos.RowTemplate.Height = 24
        Me.grid_turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_turnos.ShowEditingIcon = False
        Me.grid_turnos.Size = New System.Drawing.Size(912, 352)
        Me.grid_turnos.TabIndex = 0
        Me.grid_turnos.Tag = "9999"
        '
        'fecha_turno
        '
        Me.fecha_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha_turno.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha_turno.HeaderText = "Fecha Turno"
        Me.fecha_turno.Name = "fecha_turno"
        Me.fecha_turno.ReadOnly = True
        Me.fecha_turno.Width = 117
        '
        'hora_desde
        '
        Me.hora_desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.hora_desde.DefaultCellStyle = DataGridViewCellStyle3
        Me.hora_desde.HeaderText = "Hora Desde"
        Me.hora_desde.Name = "hora_desde"
        Me.hora_desde.ReadOnly = True
        Me.hora_desde.Width = 113
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Width = 200
        '
        'bEliminar
        '
        Me.bEliminar.AutoSize = True
        Me.bEliminar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bEliminar.Location = New System.Drawing.Point(707, 11)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(193, 36)
        Me.bEliminar.TabIndex = 50
        Me.bEliminar.Text = "Eliminar Turno"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_medicos2)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(918, 71)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar turnos asignados"
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.bEliminar)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel1.Location = New System.Drawing.Point(0, 432)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(918, 62)
        Me.MyPanel1.TabIndex = 54
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.grp_grilla)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(918, 431)
        Me.MyPanel2.TabIndex = 55
        '
        'MyPanel3
        '
        Me.MyPanel3.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel3.BorderWidth = 0
        Me.MyPanel3.Controls.Add(Me.GroupBox1)
        Me.MyPanel3.Controls.Add(Me.MyPanel2)
        Me.MyPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel3.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel3.Name = "MyPanel3"
        Me.MyPanel3.Size = New System.Drawing.Size(918, 431)
        Me.MyPanel3.TabIndex = 56
        '
        'MyPanel4
        '
        Me.MyPanel4.BorderColor = System.Drawing.Color.Black
        Me.MyPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel4.BorderWidth = 2
        Me.MyPanel4.Controls.Add(Me.MyPanel3)
        Me.MyPanel4.Controls.Add(Me.MyPanel1)
        Me.MyPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel4.Location = New System.Drawing.Point(0, 33)
        Me.MyPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel4.Name = "MyPanel4"
        Me.MyPanel4.Size = New System.Drawing.Size(920, 496)
        Me.MyPanel4.TabIndex = 57
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 34)
        Me.Panel1.TabIndex = 58
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
        Me.Button1.Location = New System.Drawing.Point(883, 0)
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.15!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Turnos Asignados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VerTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerTurnos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerTurnos"
        Me.grp_grilla.ResumeLayout(False)
        CType(Me.grid_turnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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

    Friend WithEvents cmb_medicos2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents grp_grilla As GroupBox
    Friend WithEvents bEliminar As Button
    Friend WithEvents grid_turnos As DataGridView
    Friend WithEvents fecha_turno As DataGridViewTextBoxColumn
    Friend WithEvents hora_desde As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents observaciones As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents MyPanel3 As MyPanel
    Friend WithEvents MyPanel4 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
