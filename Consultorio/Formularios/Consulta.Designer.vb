<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MyPanel4 = New Consultorio.MyPanel()
        Me.MyPanel5 = New Consultorio.MyPanel()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.grp_datos_personales = New System.Windows.Forms.GroupBox()
        Me.txt_doc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.lbl_nro_doc = New System.Windows.Forms.Label()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.MyPanel3 = New Consultorio.MyPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.lbl_obsercaciones = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel4.SuspendLayout()
        Me.MyPanel5.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.grp_datos_personales.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MyPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1003, 34)
        Me.Panel1.TabIndex = 63
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
        Me.Button1.Location = New System.Drawing.Point(966, 0)
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
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Consultas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MyPanel4
        '
        Me.MyPanel4.BorderColor = System.Drawing.Color.Black
        Me.MyPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel4.BorderWidth = 2
        Me.MyPanel4.Controls.Add(Me.MyPanel5)
        Me.MyPanel4.Controls.Add(Me.MyPanel3)
        Me.MyPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel4.Location = New System.Drawing.Point(0, 33)
        Me.MyPanel4.Name = "MyPanel4"
        Me.MyPanel4.Size = New System.Drawing.Size(1003, 548)
        Me.MyPanel4.TabIndex = 62
        '
        'MyPanel5
        '
        Me.MyPanel5.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel5.BorderWidth = 0
        Me.MyPanel5.Controls.Add(Me.MyPanel2)
        Me.MyPanel5.Controls.Add(Me.MyPanel1)
        Me.MyPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel5.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel5.Name = "MyPanel5"
        Me.MyPanel5.Size = New System.Drawing.Size(1001, 209)
        Me.MyPanel5.TabIndex = 61
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.grp_datos_personales)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(0, 66)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(1001, 143)
        Me.MyPanel2.TabIndex = 58
        '
        'grp_datos_personales
        '
        Me.grp_datos_personales.Controls.Add(Me.txt_doc)
        Me.grp_datos_personales.Controls.Add(Me.lbl_ape)
        Me.grp_datos_personales.Controls.Add(Me.txt_ape)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nom)
        Me.grp_datos_personales.Controls.Add(Me.txt_nom)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nro_doc)
        Me.grp_datos_personales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_datos_personales.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.grp_datos_personales.Location = New System.Drawing.Point(0, 0)
        Me.grp_datos_personales.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_datos_personales.Size = New System.Drawing.Size(1001, 143)
        Me.grp_datos_personales.TabIndex = 55
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'txt_doc
        '
        Me.txt_doc.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.txt_doc.Location = New System.Drawing.Point(133, 105)
        Me.txt_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(97, 29)
        Me.txt_doc.TabIndex = 50
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_ape.Location = New System.Drawing.Point(17, 27)
        Me.lbl_ape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(80, 23)
        Me.lbl_ape.TabIndex = 0
        Me.lbl_ape.Text = "Apellido *"
        '
        'txt_ape
        '
        Me.txt_ape.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.txt_ape.Location = New System.Drawing.Point(132, 26)
        Me.txt_ape.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(265, 29)
        Me.txt_ape.TabIndex = 0
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_nom.Location = New System.Drawing.Point(17, 65)
        Me.lbl_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(79, 23)
        Me.lbl_nom.TabIndex = 5
        Me.lbl_nom.Text = "Nombre *"
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.txt_nom.Location = New System.Drawing.Point(132, 65)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(265, 29)
        Me.txt_nom.TabIndex = 1
        '
        'lbl_nro_doc
        '
        Me.lbl_nro_doc.AutoSize = True
        Me.lbl_nro_doc.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_nro_doc.Location = New System.Drawing.Point(17, 107)
        Me.lbl_nro_doc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nro_doc.Name = "lbl_nro_doc"
        Me.lbl_nro_doc.Size = New System.Drawing.Size(74, 23)
        Me.lbl_nro_doc.TabIndex = 13
        Me.lbl_nro_doc.Text = "Nro Doc*"
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.GroupBox1)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(1001, 66)
        Me.MyPanel1.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 71)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Ficha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nro Doc*"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.AutoSize = True
        Me.cmdBuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(343, 25)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(207, 34)
        Me.cmdBuscar.TabIndex = 13
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.txt_nro_doc.Location = New System.Drawing.Point(132, 27)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(181, 29)
        Me.txt_nro_doc.TabIndex = 11
        '
        'MyPanel3
        '
        Me.MyPanel3.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel3.BorderWidth = 0
        Me.MyPanel3.Controls.Add(Me.GroupBox2)
        Me.MyPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel3.Location = New System.Drawing.Point(0, 182)
        Me.MyPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel3.Name = "MyPanel3"
        Me.MyPanel3.Size = New System.Drawing.Size(1001, 364)
        Me.MyPanel3.TabIndex = 59
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.bAgregar)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_observaciones)
        Me.GroupBox2.Controls.Add(Me.lbl_obsercaciones)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1001, 364)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Consulta"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(224, 50)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(139, 30)
        Me.DateTimePicker2.TabIndex = 66
        Me.DateTimePicker2.Value = New Date(2019, 7, 3, 20, 0, 39, 0)
        '
        'bAgregar
        '
        Me.bAgregar.AutoSize = True
        Me.bAgregar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bAgregar.Location = New System.Drawing.Point(392, 48)
        Me.bAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(251, 34)
        Me.bAgregar.TabIndex = 65
        Me.bAgregar.Text = "Agregar Datos de Consulta"
        Me.bAgregar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.TextBox2.Location = New System.Drawing.Point(240, 288)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(718, 61)
        Me.TextBox2.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Diagnóstico"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.TextBox1.Location = New System.Drawing.Point(240, 197)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(718, 61)
        Me.TextBox1.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Antecedentes familiares"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_observaciones.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.txt_observaciones.Location = New System.Drawing.Point(240, 110)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(718, 61)
        Me.txt_observaciones.TabIndex = 58
        '
        'lbl_obsercaciones
        '
        Me.lbl_obsercaciones.AutoSize = True
        Me.lbl_obsercaciones.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.lbl_obsercaciones.Location = New System.Drawing.Point(16, 106)
        Me.lbl_obsercaciones.Name = "lbl_obsercaciones"
        Me.lbl_obsercaciones.Size = New System.Drawing.Size(117, 23)
        Me.lbl_obsercaciones.TabIndex = 57
        Me.lbl_obsercaciones.Text = "Observaciones"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(16, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 23)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Fecha de Consulta*"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel4.ResumeLayout(False)
        Me.MyPanel5.ResumeLayout(False)
        Me.MyPanel2.ResumeLayout(False)
        Me.grp_datos_personales.ResumeLayout(False)
        Me.grp_datos_personales.PerformLayout()
        Me.MyPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MyPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents grp_datos_personales As GroupBox
    Friend WithEvents txt_doc As MaskedTextBox
    Friend WithEvents lbl_ape As Label
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents lbl_nom As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents lbl_nro_doc As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents lbl_obsercaciones As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bAgregar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel3 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents MyPanel5 As MyPanel
    Friend WithEvents MyPanel4 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
