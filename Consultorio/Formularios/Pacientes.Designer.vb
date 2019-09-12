<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyPanel1_TODO = New Consultorio.MyPanel()
        Me.MyPanel3_MEDIO = New Consultorio.MyPanel()
        Me.MyPanel1_Bottom = New Consultorio.MyPanel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.MyPanel4_Derecha = New Consultorio.MyPanel()
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.txt_piso = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.lbl_piso = New System.Windows.Forms.Label()
        Me.txt_nro_calle = New System.Windows.Forms.TextBox()
        Me.lbl_nro = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.grp_obra = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbObra = New System.Windows.Forms.ComboBox()
        Me.lbl_asterisco = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_afiliado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grp_datos_personales = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_doc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.lbl_nro_doc = New System.Windows.Forms.Label()
        Me.MyPanel1_TOP = New Consultorio.MyPanel()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.bNuevaFicha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel1_TODO.SuspendLayout()
        Me.MyPanel3_MEDIO.SuspendLayout()
        Me.MyPanel1_Bottom.SuspendLayout()
        Me.MyPanel4_Derecha.SuspendLayout()
        Me.grp_domicilio.SuspendLayout()
        Me.grp_obra.SuspendLayout()
        Me.grp_datos_personales.SuspendLayout()
        Me.MyPanel1_TOP.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 34)
        Me.Panel1.TabIndex = 59
        Me.Panel1.Tag = "9999"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
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
        Me.Button1.Location = New System.Drawing.Point(1092, 0)
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
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.15!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pacientes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MyPanel1_TODO
        '
        Me.MyPanel1_TODO.BorderColor = System.Drawing.Color.Black
        Me.MyPanel1_TODO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel1_TODO.BorderWidth = 2
        Me.MyPanel1_TODO.Controls.Add(Me.MyPanel3_MEDIO)
        Me.MyPanel1_TODO.Controls.Add(Me.MyPanel1_TOP)
        Me.MyPanel1_TODO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel1_TODO.Location = New System.Drawing.Point(0, 34)
        Me.MyPanel1_TODO.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1_TODO.Name = "MyPanel1_TODO"
        Me.MyPanel1_TODO.Size = New System.Drawing.Size(1129, 540)
        Me.MyPanel1_TODO.TabIndex = 20
        '
        'MyPanel3_MEDIO
        '
        Me.MyPanel3_MEDIO.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel3_MEDIO.BorderWidth = 0
        Me.MyPanel3_MEDIO.Controls.Add(Me.MyPanel1_Bottom)
        Me.MyPanel3_MEDIO.Controls.Add(Me.MyPanel4_Derecha)
        Me.MyPanel3_MEDIO.Controls.Add(Me.grp_datos_personales)
        Me.MyPanel3_MEDIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel3_MEDIO.Location = New System.Drawing.Point(0, 142)
        Me.MyPanel3_MEDIO.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel3_MEDIO.Name = "MyPanel3_MEDIO"
        Me.MyPanel3_MEDIO.Size = New System.Drawing.Size(1127, 396)
        Me.MyPanel3_MEDIO.TabIndex = 53
        '
        'MyPanel1_Bottom
        '
        Me.MyPanel1_Bottom.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1_Bottom.BorderWidth = 0
        Me.MyPanel1_Bottom.Controls.Add(Me.bEliminar)
        Me.MyPanel1_Bottom.Controls.Add(Me.bGuardar)
        Me.MyPanel1_Bottom.Controls.Add(Me.bModificar)
        Me.MyPanel1_Bottom.Controls.Add(Me.bSalir)
        Me.MyPanel1_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel1_Bottom.Location = New System.Drawing.Point(0, 343)
        Me.MyPanel1_Bottom.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1_Bottom.Name = "MyPanel1_Bottom"
        Me.MyPanel1_Bottom.Size = New System.Drawing.Size(1127, 53)
        Me.MyPanel1_Bottom.TabIndex = 54
        '
        'bEliminar
        '
        Me.bEliminar.AutoSize = True
        Me.bEliminar.Enabled = False
        Me.bEliminar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bEliminar.Location = New System.Drawing.Point(600, 6)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(205, 39)
        Me.bEliminar.TabIndex = 24
        Me.bEliminar.Text = "ELIMINAR"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.AutoSize = True
        Me.bGuardar.Enabled = False
        Me.bGuardar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bGuardar.Location = New System.Drawing.Point(20, 6)
        Me.bGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(205, 39)
        Me.bGuardar.TabIndex = 22
        Me.bGuardar.Text = "GUARDAR"
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.AutoSize = True
        Me.bModificar.Enabled = False
        Me.bModificar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bModificar.Location = New System.Drawing.Point(317, 6)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(205, 39)
        Me.bModificar.TabIndex = 23
        Me.bModificar.Text = "MODIFICAR"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.AutoSize = True
        Me.bSalir.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bSalir.Location = New System.Drawing.Point(896, 6)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(205, 39)
        Me.bSalir.TabIndex = 25
        Me.bSalir.Text = "SALIR"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'MyPanel4_Derecha
        '
        Me.MyPanel4_Derecha.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel4_Derecha.BorderWidth = 0
        Me.MyPanel4_Derecha.Controls.Add(Me.grp_domicilio)
        Me.MyPanel4_Derecha.Controls.Add(Me.grp_obra)
        Me.MyPanel4_Derecha.Location = New System.Drawing.Point(536, 0)
        Me.MyPanel4_Derecha.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel4_Derecha.Name = "MyPanel4_Derecha"
        Me.MyPanel4_Derecha.Size = New System.Drawing.Size(593, 336)
        Me.MyPanel4_Derecha.TabIndex = 19
        '
        'grp_domicilio
        '
        Me.grp_domicilio.Controls.Add(Me.txt_barrio)
        Me.grp_domicilio.Controls.Add(Me.lbl_localidad)
        Me.grp_domicilio.Controls.Add(Me.txt_depto)
        Me.grp_domicilio.Controls.Add(Me.txt_piso)
        Me.grp_domicilio.Controls.Add(Me.lbl_depto)
        Me.grp_domicilio.Controls.Add(Me.lbl_piso)
        Me.grp_domicilio.Controls.Add(Me.txt_nro_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_nro)
        Me.grp_domicilio.Controls.Add(Me.lbl_calle)
        Me.grp_domicilio.Controls.Add(Me.txt_calle)
        Me.grp_domicilio.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_domicilio.Enabled = False
        Me.grp_domicilio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.grp_domicilio.Location = New System.Drawing.Point(0, 0)
        Me.grp_domicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_domicilio.Size = New System.Drawing.Size(593, 156)
        Me.grp_domicilio.TabIndex = 12
        Me.grp_domicilio.TabStop = False
        Me.grp_domicilio.Text = "Domicilio"
        '
        'txt_barrio
        '
        Me.txt_barrio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_barrio.Location = New System.Drawing.Point(156, 114)
        Me.txt_barrio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.Size = New System.Drawing.Size(345, 28)
        Me.txt_barrio.TabIndex = 17
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_localidad.Location = New System.Drawing.Point(7, 118)
        Me.lbl_localidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(113, 23)
        Me.lbl_localidad.TabIndex = 71
        Me.lbl_localidad.Text = "Barrio/Ciudad"
        '
        'txt_depto
        '
        Me.txt_depto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_depto.Location = New System.Drawing.Point(369, 70)
        Me.txt_depto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.Size = New System.Drawing.Size(132, 28)
        Me.txt_depto.TabIndex = 16
        '
        'txt_piso
        '
        Me.txt_piso.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_piso.Location = New System.Drawing.Point(156, 71)
        Me.txt_piso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_piso.Name = "txt_piso"
        Me.txt_piso.Size = New System.Drawing.Size(132, 28)
        Me.txt_piso.TabIndex = 15
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_depto.Location = New System.Drawing.Point(300, 75)
        Me.lbl_depto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(53, 23)
        Me.lbl_depto.TabIndex = 70
        Me.lbl_depto.Text = "Depto"
        '
        'lbl_piso
        '
        Me.lbl_piso.AutoSize = True
        Me.lbl_piso.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_piso.Location = New System.Drawing.Point(7, 75)
        Me.lbl_piso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_piso.Name = "lbl_piso"
        Me.lbl_piso.Size = New System.Drawing.Size(41, 23)
        Me.lbl_piso.TabIndex = 69
        Me.lbl_piso.Text = "Piso"
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_nro_calle.Location = New System.Drawing.Point(369, 31)
        Me.txt_nro_calle.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.Size = New System.Drawing.Size(132, 28)
        Me.txt_nro_calle.TabIndex = 14
        '
        'lbl_nro
        '
        Me.lbl_nro.AutoSize = True
        Me.lbl_nro.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_nro.Location = New System.Drawing.Point(300, 34)
        Me.lbl_nro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro.Name = "lbl_nro"
        Me.lbl_nro.Size = New System.Drawing.Size(47, 23)
        Me.lbl_nro.TabIndex = 68
        Me.lbl_nro.Text = "Nro *"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_calle.Location = New System.Drawing.Point(7, 34)
        Me.lbl_calle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(58, 23)
        Me.lbl_calle.TabIndex = 67
        Me.lbl_calle.Text = "Calle *"
        '
        'txt_calle
        '
        Me.txt_calle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_calle.Location = New System.Drawing.Point(156, 31)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(132, 28)
        Me.txt_calle.TabIndex = 13
        '
        'grp_obra
        '
        Me.grp_obra.Controls.Add(Me.Label9)
        Me.grp_obra.Controls.Add(Me.cmbObra)
        Me.grp_obra.Controls.Add(Me.lbl_asterisco)
        Me.grp_obra.Controls.Add(Me.txt_codigo)
        Me.grp_obra.Controls.Add(Me.Label2)
        Me.grp_obra.Controls.Add(Me.txt_afiliado)
        Me.grp_obra.Controls.Add(Me.Label3)
        Me.grp_obra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grp_obra.Enabled = False
        Me.grp_obra.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.grp_obra.Location = New System.Drawing.Point(0, 162)
        Me.grp_obra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_obra.Name = "grp_obra"
        Me.grp_obra.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grp_obra.Size = New System.Drawing.Size(593, 174)
        Me.grp_obra.TabIndex = 18
        Me.grp_obra.TabStop = False
        Me.grp_obra.Text = "Obra social"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(7, 39)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 23)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Tipo de consulta"
        '
        'cmbObra
        '
        Me.cmbObra.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.cmbObra.FormattingEnabled = True
        Me.cmbObra.Items.AddRange(New Object() {"PARTICULAR", "APROSS", "AFJP", "ARG NUEVA", "SVDYR", "PROFE", "LAVORIS"})
        Me.cmbObra.Location = New System.Drawing.Point(193, 37)
        Me.cmbObra.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbObra.Name = "cmbObra"
        Me.cmbObra.Size = New System.Drawing.Size(175, 29)
        Me.cmbObra.TabIndex = 19
        Me.cmbObra.Tag = "9999"
        '
        'lbl_asterisco
        '
        Me.lbl_asterisco.AutoSize = True
        Me.lbl_asterisco.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.lbl_asterisco.Location = New System.Drawing.Point(385, 142)
        Me.lbl_asterisco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_asterisco.Name = "lbl_asterisco"
        Me.lbl_asterisco.Size = New System.Drawing.Size(153, 21)
        Me.lbl_asterisco.TabIndex = 45
        Me.lbl_asterisco.Text = "* Campos obligatorios"
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_codigo.Location = New System.Drawing.Point(193, 126)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(175, 28)
        Me.txt_codigo.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Afiliado"
        '
        'txt_afiliado
        '
        Me.txt_afiliado.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_afiliado.Location = New System.Drawing.Point(193, 81)
        Me.txt_afiliado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_afiliado.Name = "txt_afiliado"
        Me.txt_afiliado.Size = New System.Drawing.Size(175, 28)
        Me.txt_afiliado.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Codigo de seguridad"
        '
        'grp_datos_personales
        '
        Me.grp_datos_personales.Controls.Add(Me.CheckBox1)
        Me.grp_datos_personales.Controls.Add(Me.Label1)
        Me.grp_datos_personales.Controls.Add(Me.txt_doc)
        Me.grp_datos_personales.Controls.Add(Me.txt_edad)
        Me.grp_datos_personales.Controls.Add(Me.DateTimePicker2)
        Me.grp_datos_personales.Controls.Add(Me.txt_celular)
        Me.grp_datos_personales.Controls.Add(Me.txt_telefono)
        Me.grp_datos_personales.Controls.Add(Me.lbl_celular)
        Me.grp_datos_personales.Controls.Add(Me.lbl_telefono)
        Me.grp_datos_personales.Controls.Add(Me.Label11)
        Me.grp_datos_personales.Controls.Add(Me.lbl_ape)
        Me.grp_datos_personales.Controls.Add(Me.txt_ape)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nom)
        Me.grp_datos_personales.Controls.Add(Me.txt_nom)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nro_doc)
        Me.grp_datos_personales.Enabled = False
        Me.grp_datos_personales.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.grp_datos_personales.Location = New System.Drawing.Point(0, 0)
        Me.grp_datos_personales.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_datos_personales.Size = New System.Drawing.Size(528, 336)
        Me.grp_datos_personales.TabIndex = 3
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(367, 160)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 25)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Habilitar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(20, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Edad"
        '
        'txt_doc
        '
        Me.txt_doc.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_doc.Location = New System.Drawing.Point(201, 114)
        Me.txt_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(97, 28)
        Me.txt_doc.TabIndex = 6
        '
        'txt_edad
        '
        Me.txt_edad.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_edad.Location = New System.Drawing.Point(200, 203)
        Me.txt_edad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(95, 28)
        Me.txt_edad.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(200, 158)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(139, 28)
        Me.DateTimePicker2.TabIndex = 8
        Me.DateTimePicker2.Tag = "9999"
        '
        'txt_celular
        '
        Me.txt_celular.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_celular.Location = New System.Drawing.Point(201, 290)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(265, 28)
        Me.txt_celular.TabIndex = 11
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_telefono.Location = New System.Drawing.Point(200, 246)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(265, 28)
        Me.txt_telefono.TabIndex = 10
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_celular.Location = New System.Drawing.Point(20, 294)
        Me.lbl_celular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(64, 23)
        Me.lbl_celular.TabIndex = 66
        Me.lbl_celular.Text = "Celular"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_telefono.Location = New System.Drawing.Point(20, 247)
        Me.lbl_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(72, 23)
        Me.lbl_telefono.TabIndex = 65
        Me.lbl_telefono.Text = "Teléfono"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(20, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 23)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Fecha de Nac."
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_ape.Location = New System.Drawing.Point(20, 32)
        Me.lbl_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(80, 23)
        Me.lbl_ape.TabIndex = 60
        Me.lbl_ape.Text = "Apellido *"
        '
        'txt_ape
        '
        Me.txt_ape.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_ape.Location = New System.Drawing.Point(200, 28)
        Me.txt_ape.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(265, 28)
        Me.txt_ape.TabIndex = 4
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_nom.Location = New System.Drawing.Point(20, 75)
        Me.lbl_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(79, 23)
        Me.lbl_nom.TabIndex = 61
        Me.lbl_nom.Text = "Nombre *"
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_nom.Location = New System.Drawing.Point(200, 71)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(265, 28)
        Me.txt_nom.TabIndex = 5
        '
        'lbl_nro_doc
        '
        Me.lbl_nro_doc.AutoSize = True
        Me.lbl_nro_doc.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_nro_doc.Location = New System.Drawing.Point(20, 119)
        Me.lbl_nro_doc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro_doc.Name = "lbl_nro_doc"
        Me.lbl_nro_doc.Size = New System.Drawing.Size(74, 23)
        Me.lbl_nro_doc.TabIndex = 62
        Me.lbl_nro_doc.Text = "Nro Doc*"
        '
        'MyPanel1_TOP
        '
        Me.MyPanel1_TOP.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1_TOP.BorderWidth = 0
        Me.MyPanel1_TOP.Controls.Add(Me.MyPanel2)
        Me.MyPanel1_TOP.Controls.Add(Me.GroupBox1)
        Me.MyPanel1_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel1_TOP.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1_TOP.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1_TOP.Name = "MyPanel1_TOP"
        Me.MyPanel1_TOP.Size = New System.Drawing.Size(1127, 142)
        Me.MyPanel1_TOP.TabIndex = 52
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.bNuevaFicha)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(0, 78)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(1127, 64)
        Me.MyPanel2.TabIndex = 52
        '
        'bNuevaFicha
        '
        Me.bNuevaFicha.AutoSize = True
        Me.bNuevaFicha.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bNuevaFicha.Location = New System.Drawing.Point(24, 9)
        Me.bNuevaFicha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bNuevaFicha.Name = "bNuevaFicha"
        Me.bNuevaFicha.Size = New System.Drawing.Size(175, 46)
        Me.bNuevaFicha.TabIndex = 2
        Me.bNuevaFicha.Text = "Nueva Ficha"
        Me.bNuevaFicha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1127, 78)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargar de fichero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nro Doc"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.AutoSize = True
        Me.cmd_buscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cmd_buscar.Location = New System.Drawing.Point(303, 25)
        Me.cmd_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(183, 41)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txt_nro_doc.Location = New System.Drawing.Point(112, 31)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(160, 28)
        Me.txt_nro_doc.TabIndex = 0
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 574)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel1_TODO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pacientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel1_TODO.ResumeLayout(False)
        Me.MyPanel3_MEDIO.ResumeLayout(False)
        Me.MyPanel1_Bottom.ResumeLayout(False)
        Me.MyPanel1_Bottom.PerformLayout()
        Me.MyPanel4_Derecha.ResumeLayout(False)
        Me.grp_domicilio.ResumeLayout(False)
        Me.grp_domicilio.PerformLayout()
        Me.grp_obra.ResumeLayout(False)
        Me.grp_obra.PerformLayout()
        Me.grp_datos_personales.ResumeLayout(False)
        Me.grp_datos_personales.PerformLayout()
        Me.MyPanel1_TOP.ResumeLayout(False)
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbObra As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bGuardar As Button
    Friend WithEvents bModificar As Button
    Friend WithEvents bEliminar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents grp_domicilio As GroupBox
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents txt_depto As TextBox
    Friend WithEvents txt_piso As TextBox
    Friend WithEvents lbl_depto As Label
    Friend WithEvents lbl_piso As Label
    Friend WithEvents txt_nro_calle As TextBox
    Friend WithEvents lbl_nro As Label
    Friend WithEvents lbl_calle As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents grp_datos_personales As GroupBox
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_celular As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_ape As Label
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents lbl_nom As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents lbl_nro_doc As Label
    Friend WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents lbl_asterisco As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_edad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_afiliado As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_doc As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grp_obra As GroupBox
    Friend WithEvents bNuevaFicha As Button
    Friend WithEvents txt_barrio As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MyPanel1_TOP As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents MyPanel3_MEDIO As MyPanel
    Friend WithEvents MyPanel4_Derecha As MyPanel
    Friend WithEvents MyPanel1_Bottom As MyPanel
    Friend WithEvents MyPanel1_TODO As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
