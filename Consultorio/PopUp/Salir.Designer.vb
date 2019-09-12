<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salir))
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MyPanel3 = New Consultorio.MyPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyPanel4 = New Consultorio.MyPanel()
        Me.MyPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.SlateGray
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.PictureBox3)
        Me.MyPanel1.Controls.Add(Me.Button6)
        Me.MyPanel1.Controls.Add(Me.Label1)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel1.Location = New System.Drawing.Point(3, 2)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(520, 34)
        Me.MyPanel1.TabIndex = 4
        Me.MyPanel1.Tag = "9999"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageIndex = 2
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(483, 0)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 34)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrow_down.png")
        Me.ImageList1.Images.SetKeyName(1, "error (2).png")
        Me.ImageList1.Images.SetKeyName(2, "x-mark-32.png")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultorio - SALIR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MyPanel2
        '
        Me.MyPanel2.BackColor = System.Drawing.Color.SlateGray
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.Button8)
        Me.MyPanel2.Controls.Add(Me.Button7)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(3, 36)
        Me.MyPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(520, 179)
        Me.MyPanel2.TabIndex = 5
        '
        'Button8
        '
        Me.Button8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.SlateGray
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(341, 133)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 39)
        Me.Button8.TabIndex = 5
        Me.Button8.Tag = "9999"
        Me.Button8.Text = "&No"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.SlateGray
        Me.Button7.FlatAppearance.BorderSize = 2
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(51, 133)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 39)
        Me.Button7.TabIndex = 4
        Me.Button7.Tag = "9999"
        Me.Button7.Text = "&Si"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'MyPanel3
        '
        Me.MyPanel3.BackColor = System.Drawing.Color.White
        Me.MyPanel3.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel3.BorderWidth = 0
        Me.MyPanel3.Controls.Add(Me.PictureBox1)
        Me.MyPanel3.Controls.Add(Me.Label2)
        Me.MyPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyPanel3.Location = New System.Drawing.Point(3, 36)
        Me.MyPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel3.Name = "MyPanel3"
        Me.MyPanel3.Size = New System.Drawing.Size(520, 126)
        Me.MyPanel3.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(377, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(65, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¿Desea cerrar la aplicación?"
        '
        'MyPanel4
        '
        Me.MyPanel4.BorderColor = System.Drawing.Color.SlateGray
        Me.MyPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel4.BorderWidth = 5
        Me.MyPanel4.Controls.Add(Me.MyPanel3)
        Me.MyPanel4.Controls.Add(Me.MyPanel2)
        Me.MyPanel4.Controls.Add(Me.MyPanel1)
        Me.MyPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel4.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel4.Name = "MyPanel4"
        Me.MyPanel4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MyPanel4.Size = New System.Drawing.Size(528, 219)
        Me.MyPanel4.TabIndex = 7
        '
        'Salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 219)
        Me.Controls.Add(Me.MyPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Salir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salir"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel3.ResumeLayout(False)
        Me.MyPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MyPanel3 As MyPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents MyPanel4 As MyPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
