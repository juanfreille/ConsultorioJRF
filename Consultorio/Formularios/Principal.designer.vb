<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplorarFicheroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltimasConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriaClínicaDePacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OscuroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EigteenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersiónAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.NuevoEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoTurno = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTurnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agenda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Estadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 34)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = "9999"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(726, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(763, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Label1.Size = New System.Drawing.Size(300, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultorio Jorge Raúl Franchello"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 32)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.TurnosToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.MedicamentosToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SeguridadToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(88, 28)
        Me.MenúToolStripMenuItem.Text = "Archivo"
        Me.MenúToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(284, 30)
        Me.ToolStripMenuItem1.Text = "Exportar Base de Datos"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.SeguridadToolStripMenuItem.Enabled = False
        Me.SeguridadToolStripMenuItem.Image = CType(resources.GetObject("SeguridadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Activar", "Desactivar"})
        Me.ToolStripComboBox1.MaxDropDownItems = 2
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTurnoToolStripMenuItem, Me.VerTurnosToolStripMenuItem, Me.AgendaToolStripMenuItem})
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.TurnosToolStripMenuItem.Text = "Turnos"
        '
        'NuevoTurnoToolStripMenuItem
        '
        Me.NuevoTurnoToolStripMenuItem.Image = CType(resources.GetObject("NuevoTurnoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoTurnoToolStripMenuItem.Name = "NuevoTurnoToolStripMenuItem"
        Me.NuevoTurnoToolStripMenuItem.Size = New System.Drawing.Size(200, 30)
        Me.NuevoTurnoToolStripMenuItem.Text = "Nuevo Turno"
        '
        'VerTurnosToolStripMenuItem
        '
        Me.VerTurnosToolStripMenuItem.Image = CType(resources.GetObject("VerTurnosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerTurnosToolStripMenuItem.Name = "VerTurnosToolStripMenuItem"
        Me.VerTurnosToolStripMenuItem.Size = New System.Drawing.Size(200, 30)
        Me.VerTurnosToolStripMenuItem.Text = "Ver Turnos"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Image = CType(resources.GetObject("AgendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(200, 30)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoPacienteToolStripMenuItem, Me.ExplorarFicheroToolStripMenuItem, Me.UltimasConsultasToolStripMenuItem, Me.DatosDeConsultaToolStripMenuItem, Me.HistoriaClínicaDePacienteToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(103, 28)
        Me.BuscarToolStripMenuItem.Text = "Pacientes"
        '
        'NuevoPacienteToolStripMenuItem
        '
        Me.NuevoPacienteToolStripMenuItem.Image = CType(resources.GetObject("NuevoPacienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoPacienteToolStripMenuItem.Name = "NuevoPacienteToolStripMenuItem"
        Me.NuevoPacienteToolStripMenuItem.Size = New System.Drawing.Size(295, 30)
        Me.NuevoPacienteToolStripMenuItem.Text = "Crear/Editar Paciente"
        '
        'ExplorarFicheroToolStripMenuItem
        '
        Me.ExplorarFicheroToolStripMenuItem.Image = CType(resources.GetObject("ExplorarFicheroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExplorarFicheroToolStripMenuItem.Name = "ExplorarFicheroToolStripMenuItem"
        Me.ExplorarFicheroToolStripMenuItem.Size = New System.Drawing.Size(295, 30)
        Me.ExplorarFicheroToolStripMenuItem.Text = "Explorar Fichero"
        '
        'UltimasConsultasToolStripMenuItem
        '
        Me.UltimasConsultasToolStripMenuItem.Image = CType(resources.GetObject("UltimasConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UltimasConsultasToolStripMenuItem.Name = "UltimasConsultasToolStripMenuItem"
        Me.UltimasConsultasToolStripMenuItem.Size = New System.Drawing.Size(295, 30)
        Me.UltimasConsultasToolStripMenuItem.Text = "Imprimir/Guardar Fichas"
        '
        'DatosDeConsultaToolStripMenuItem
        '
        Me.DatosDeConsultaToolStripMenuItem.Image = CType(resources.GetObject("DatosDeConsultaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DatosDeConsultaToolStripMenuItem.Name = "DatosDeConsultaToolStripMenuItem"
        Me.DatosDeConsultaToolStripMenuItem.Size = New System.Drawing.Size(295, 30)
        Me.DatosDeConsultaToolStripMenuItem.Text = "Datos de Consulta"
        '
        'HistoriaClínicaDePacienteToolStripMenuItem
        '
        Me.HistoriaClínicaDePacienteToolStripMenuItem.Image = CType(resources.GetObject("HistoriaClínicaDePacienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoriaClínicaDePacienteToolStripMenuItem.Name = "HistoriaClínicaDePacienteToolStripMenuItem"
        Me.HistoriaClínicaDePacienteToolStripMenuItem.Size = New System.Drawing.Size(295, 30)
        Me.HistoriaClínicaDePacienteToolStripMenuItem.Text = "Historia Clínica"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GráficosToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(120, 28)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'GráficosToolStripMenuItem
        '
        Me.GráficosToolStripMenuItem.Image = CType(resources.GetObject("GráficosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GráficosToolStripMenuItem.Name = "GráficosToolStripMenuItem"
        Me.GráficosToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
        Me.GráficosToolStripMenuItem.Text = "Gráficos"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.OscuroToolStripMenuItem, Me.EigteenToolStripMenuItem, Me.Page1ToolStripMenuItem})
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(76, 28)
        Me.MedicamentosToolStripMenuItem.Text = "Temas"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Image = CType(resources.GetObject("NormalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(153, 30)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'OscuroToolStripMenuItem
        '
        Me.OscuroToolStripMenuItem.Image = CType(resources.GetObject("OscuroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OscuroToolStripMenuItem.Name = "OscuroToolStripMenuItem"
        Me.OscuroToolStripMenuItem.Size = New System.Drawing.Size(153, 30)
        Me.OscuroToolStripMenuItem.Text = "Oscuro"
        '
        'EigteenToolStripMenuItem
        '
        Me.EigteenToolStripMenuItem.Image = CType(resources.GetObject("EigteenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EigteenToolStripMenuItem.Name = "EigteenToolStripMenuItem"
        Me.EigteenToolStripMenuItem.Size = New System.Drawing.Size(153, 30)
        Me.EigteenToolStripMenuItem.Text = "Marrón"
        '
        'Page1ToolStripMenuItem
        '
        Me.Page1ToolStripMenuItem.Image = CType(resources.GetObject("Page1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Page1ToolStripMenuItem.Name = "Page1ToolStripMenuItem"
        Me.Page1ToolStripMenuItem.Size = New System.Drawing.Size(153, 30)
        Me.Page1ToolStripMenuItem.Text = "Verde"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.VersiónAppToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(107, 28)
        Me.AyudaToolStripMenuItem.Text = "Acerca de"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Enabled = False
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(216, 30)
        Me.AcercaDeToolStripMenuItem.Text = "Ayuda"
        '
        'VersiónAppToolStripMenuItem
        '
        Me.VersiónAppToolStripMenuItem.Image = CType(resources.GetObject("VersiónAppToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VersiónAppToolStripMenuItem.Name = "VersiónAppToolStripMenuItem"
        Me.VersiónAppToolStripMenuItem.Size = New System.Drawing.Size(216, 30)
        Me.VersiónAppToolStripMenuItem.Text = "Versión App"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 66)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 88)
        Me.Panel3.TabIndex = 2
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEditar, Me.Buscar, Me.NuevoTurno, Me.VerTurnos, Me.Consulta, Me.Agenda, Me.Estadisticas, Me.Imprimir, Me.SalirTS})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(798, 86)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'NuevoEditar
        '
        Me.NuevoEditar.AutoSize = False
        Me.NuevoEditar.Image = CType(resources.GetObject("NuevoEditar.Image"), System.Drawing.Image)
        Me.NuevoEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoEditar.Name = "NuevoEditar"
        Me.NuevoEditar.Size = New System.Drawing.Size(110, 72)
        Me.NuevoEditar.Text = "Nuevo / Editar"
        Me.NuevoEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Buscar
        '
        Me.Buscar.AutoSize = False
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(110, 72)
        Me.Buscar.Text = "Buscar"
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NuevoTurno
        '
        Me.NuevoTurno.AutoSize = False
        Me.NuevoTurno.Image = CType(resources.GetObject("NuevoTurno.Image"), System.Drawing.Image)
        Me.NuevoTurno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoTurno.Name = "NuevoTurno"
        Me.NuevoTurno.Size = New System.Drawing.Size(110, 72)
        Me.NuevoTurno.Text = "Nuevo Turno"
        Me.NuevoTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'VerTurnos
        '
        Me.VerTurnos.AutoSize = False
        Me.VerTurnos.Image = CType(resources.GetObject("VerTurnos.Image"), System.Drawing.Image)
        Me.VerTurnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VerTurnos.Name = "VerTurnos"
        Me.VerTurnos.Size = New System.Drawing.Size(110, 72)
        Me.VerTurnos.Text = "Ver Turnos"
        Me.VerTurnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Consulta
        '
        Me.Consulta.AutoSize = False
        Me.Consulta.Image = CType(resources.GetObject("Consulta.Image"), System.Drawing.Image)
        Me.Consulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(110, 72)
        Me.Consulta.Text = "Nueva Consulta"
        Me.Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Agenda
        '
        Me.Agenda.AutoSize = False
        Me.Agenda.Image = CType(resources.GetObject("Agenda.Image"), System.Drawing.Image)
        Me.Agenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Size = New System.Drawing.Size(110, 72)
        Me.Agenda.Text = "Agenda"
        Me.Agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Estadisticas
        '
        Me.Estadisticas.AutoSize = False
        Me.Estadisticas.Image = CType(resources.GetObject("Estadisticas.Image"), System.Drawing.Image)
        Me.Estadisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Estadisticas.Name = "Estadisticas"
        Me.Estadisticas.Size = New System.Drawing.Size(110, 72)
        Me.Estadisticas.Text = "Estadísticas"
        Me.Estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Imprimir
        '
        Me.Imprimir.AutoSize = False
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(110, 72)
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirTS
        '
        Me.SalirTS.AutoSize = False
        Me.SalirTS.Image = CType(resources.GetObject("SalirTS.Image"), System.Drawing.Image)
        Me.SalirTS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirTS.Name = "SalirTS"
        Me.SalirTS.Size = New System.Drawing.Size(110, 72)
        Me.SalirTS.Text = "Salir"
        Me.SalirTS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "addmale.png")
        Me.ImageList2.Images.SetKeyName(1, "bus.png")
        Me.ImageList2.Images.SetKeyName(2, "cab_history_archive_archives_7219.png")
        Me.ImageList2.Images.SetKeyName(3, "calendar_22668.png")
        Me.ImageList2.Images.SetKeyName(4, "diagram-11_24506.png")
        Me.ImageList2.Images.SetKeyName(5, "printer_680.png")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "mdb"
        Me.SaveFileDialog1.FileName = "Consultorio"
        Me.SaveFileDialog1.Filter = "Base de Datos de Access|*.mdb|Todos los archivos|*.*"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.ResSysMenuClose = ""
        Me.SkinEngine1.ResSysMenuMax = ""
        Me.SkinEngine1.ResSysMenuMin = ""
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = Nothing
        Me.SkinEngine1.SkinScrollBar = False
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExplorarFicheroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UltimasConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriaClínicaDePacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OscuroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents EstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GráficosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersiónAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents NuevoEditar As ToolStripMenuItem
    Friend WithEvents SalirTS As ToolStripMenuItem
    Friend WithEvents Buscar As ToolStripMenuItem
    Friend WithEvents Consulta As ToolStripMenuItem
    Friend WithEvents Agenda As ToolStripMenuItem
    Friend WithEvents Estadisticas As ToolStripMenuItem
    Friend WithEvents Imprimir As ToolStripMenuItem
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents NuevoTurno As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents VerTurnos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents EigteenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page1ToolStripMenuItem As ToolStripMenuItem
End Class
