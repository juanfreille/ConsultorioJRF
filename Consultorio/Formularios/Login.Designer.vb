<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdNuevoUser = New System.Windows.Forms.Button()
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyPanel2.SuspendLayout()
        Me.MyPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 32)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
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
        Me.Button2.Location = New System.Drawing.Point(385, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(422, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 32)
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
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.15!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Consultorio Jorge Raúl Franchello"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Black
        Me.MyPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel2.BorderWidth = 2
        Me.MyPanel2.Controls.Add(Me.MyPanel1)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(459, 252)
        Me.MyPanel2.TabIndex = 12
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel1.BorderWidth = 0
        Me.MyPanel1.Controls.Add(Me.Label1)
        Me.MyPanel1.Controls.Add(Me.PictureBox2)
        Me.MyPanel1.Controls.Add(Me.cmdIngresar)
        Me.MyPanel1.Controls.Add(Me.PictureBox1)
        Me.MyPanel1.Controls.Add(Me.txtContraseña)
        Me.MyPanel1.Controls.Add(Me.Label3)
        Me.MyPanel1.Controls.Add(Me.Label2)
        Me.MyPanel1.Controls.Add(Me.cmdNuevoUser)
        Me.MyPanel1.Controls.Add(Me.cmbUsuarios)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel1.Location = New System.Drawing.Point(0, 31)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(457, 219)
        Me.MyPanel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(115, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(53, 87)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.cmdIngresar.Location = New System.Drawing.Point(289, 177)
        Me.cmdIngresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(133, 30)
        Me.cmdIngresar.TabIndex = 0
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.txtContraseña.Location = New System.Drawing.Point(211, 97)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(211, 28)
        Me.txtContraseña.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Para crear un nuevo usuario debe ingresar antes la clave maestra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(113, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'cmdNuevoUser
        '
        Me.cmdNuevoUser.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.cmdNuevoUser.Location = New System.Drawing.Point(42, 177)
        Me.cmdNuevoUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdNuevoUser.Name = "cmdNuevoUser"
        Me.cmdNuevoUser.Size = New System.Drawing.Size(152, 30)
        Me.cmdNuevoUser.TabIndex = 6
        Me.cmdNuevoUser.Text = "Editor de Usuarios"
        Me.cmdNuevoUser.UseVisualStyleBackColor = True
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuarios.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!)
        Me.cmbUsuarios.FormattingEnabled = True
        Me.cmbUsuarios.Location = New System.Drawing.Point(211, 45)
        Me.cmbUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(211, 29)
        Me.cmbUsuarios.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 252)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MyPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla de Autentificación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyPanel2.ResumeLayout(False)
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdIngresar As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbUsuarios As ComboBox
    Friend WithEvents cmdNuevoUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents MyPanel2 As MyPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
