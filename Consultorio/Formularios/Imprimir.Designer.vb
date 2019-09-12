<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimir))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.DOCUMENTO = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PREVISUALIZACION = New System.Drawing.Printing.PrintDocument()
        Me.PPD = New Consultorio.PrintPreviewDialogSelectPrinter()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel3 = New Consultorio.MyPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 89)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "9999"
        Me.GroupBox1.Text = "Buscar Ficha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nro Documento*"
        '
        'bBuscar
        '
        Me.bBuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.0!)
        Me.bBuscar.Location = New System.Drawing.Point(323, 31)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(260, 31)
        Me.bBuscar.TabIndex = 13
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Location = New System.Drawing.Point(143, 32)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(157, 28)
        Me.txt_nro_doc.TabIndex = 11
        '
        'DOCUMENTO
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PrintPreviewControl1)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1004, 529)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(11, 55)
        Me.PrintPreviewControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(987, 467)
        Me.PrintPreviewControl1.TabIndex = 2
        Me.PrintPreviewControl1.UseAntiAlias = True
        Me.PrintPreviewControl1.Zoom = 0.57090909090909092R
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripButton, Me.GuardarToolStripButton, Me.AyudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(998, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(92, 25)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(121, 25)
        Me.GuardarToolStripButton.Text = "&Guardar (pdf)"
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'PREVISUALIZACION
        '
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Document = Me.DOCUMENTO
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PrintPreviewDialogSelectPrinter1"
        Me.PPD.Visible = False
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.GroupBox2)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel1.Location = New System.Drawing.Point(0, 76)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(1004, 529)
        Me.MyPanel1.TabIndex = 55
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.GroupBox1)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(1004, 76)
        Me.MyPanel2.TabIndex = 56
        '
        'MyPanel3
        '
        Me.MyPanel3.BorderColor = System.Drawing.Color.Black
        Me.MyPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel3.BorderWidth = 2
        Me.MyPanel3.Controls.Add(Me.MyPanel1)
        Me.MyPanel3.Controls.Add(Me.MyPanel2)
        Me.MyPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel3.Location = New System.Drawing.Point(0, 33)
        Me.MyPanel3.Name = "MyPanel3"
        Me.MyPanel3.Size = New System.Drawing.Size(1006, 607)
        Me.MyPanel3.TabIndex = 57
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
        Me.Panel1.Size = New System.Drawing.Size(1006, 34)
        Me.Panel1.TabIndex = 58
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
        Me.Button1.Location = New System.Drawing.Point(969, 0)
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
        Me.Label1.Location = New System.Drawing.Point(40, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Imprimir / Guardar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel2.PerformLayout()
        Me.MyPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents DOCUMENTO As Printing.PrintDocument
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PREVISUALIZACION As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialogSelectPrinter
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents MyPanel3 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
