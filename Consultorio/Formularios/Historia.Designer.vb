<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AntecedentesFamiliares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 34)
        Me.Panel1.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageIndex = 2
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(1148, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 34)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Label2.Location = New System.Drawing.Point(40, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Historial de consultas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Black
        Me.MyPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel2.BorderWidth = 2
        Me.MyPanel2.Controls.Add(Me.MyPanel1)
        Me.MyPanel2.Controls.Add(Me.RichTextBox1)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel2.Location = New System.Drawing.Point(0, 34)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(1185, 684)
        Me.MyPanel2.TabIndex = 62
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.GroupBox1)
        Me.MyPanel1.Controls.Add(Me.DataGridView1)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(1183, 327)
        Me.MyPanel1.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1183, 74)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Ficha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nro Doc*"
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(323, 25)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(195, 34)
        Me.bBuscar.TabIndex = 13
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Location = New System.Drawing.Point(97, 27)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(189, 30)
        Me.txt_nro_doc.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaConsulta, Me.Observaciones, Me.AntecedentesFamiliares, Me.Diagnostico})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 77)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1183, 250)
        Me.DataGridView1.TabIndex = 54
        '
        'FechaConsulta
        '
        Me.FechaConsulta.HeaderText = "Fecha"
        Me.FechaConsulta.Name = "FechaConsulta"
        Me.FechaConsulta.ReadOnly = True
        Me.FechaConsulta.Width = 211
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 212
        '
        'AntecedentesFamiliares
        '
        Me.AntecedentesFamiliares.HeaderText = "Antecedentes Familiares"
        Me.AntecedentesFamiliares.Name = "AntecedentesFamiliares"
        Me.AntecedentesFamiliares.ReadOnly = True
        Me.AntecedentesFamiliares.Width = 211
        '
        'Diagnostico
        '
        Me.Diagnostico.HeaderText = "Diagnóstico"
        Me.Diagnostico.Name = "Diagnostico"
        Me.Diagnostico.ReadOnly = True
        Me.Diagnostico.Width = 210
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RichTextBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 337)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(1183, 345)
        Me.RichTextBox1.TabIndex = 60
        Me.RichTextBox1.Text = ""
        '
        'Historia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Historia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "9999"
        Me.Text = "Historia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents FechaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents AntecedentesFamiliares As DataGridViewTextBoxColumn
    Friend WithEvents Diagnostico As DataGridViewTextBoxColumn
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
