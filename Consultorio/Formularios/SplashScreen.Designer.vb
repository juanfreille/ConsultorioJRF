<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MyPanel1 = New Consultorio.MyPanel()
        Me.interfaz = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tablas = New System.Windows.Forms.Label()
        Me.BASEDEDATOS = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.MyPanel2 = New Consultorio.MyPanel()
        Me.MyPanel1.SuspendLayout()
        Me.MyPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 6
        '
        'MyPanel1
        '
        Me.MyPanel1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.MyPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPanel1.BorderWidth = 6
        Me.MyPanel1.Controls.Add(Me.MyPanel2)
        Me.MyPanel1.Controls.Add(Me.ApplicationTitle)
        Me.MyPanel1.Controls.Add(Me.ProgressBar1)
        Me.MyPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MyPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(549, 216)
        Me.MyPanel1.TabIndex = 8
        '
        'interfaz
        '
        Me.interfaz.BackColor = System.Drawing.Color.Transparent
        Me.interfaz.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.interfaz.ForeColor = System.Drawing.Color.White
        Me.interfaz.Location = New System.Drawing.Point(2, 68)
        Me.interfaz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.interfaz.Name = "interfaz"
        Me.interfaz.Size = New System.Drawing.Size(547, 32)
        Me.interfaz.TabIndex = 7
        Me.interfaz.Text = "Cargando INTERFAZ GRÁFICA..."
        Me.interfaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.interfaz.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.SlateGray
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 63)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(388, 39)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 4
        '
        'tablas
        '
        Me.tablas.BackColor = System.Drawing.Color.Transparent
        Me.tablas.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.tablas.ForeColor = System.Drawing.Color.White
        Me.tablas.Location = New System.Drawing.Point(2, 39)
        Me.tablas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tablas.Name = "tablas"
        Me.tablas.Size = New System.Drawing.Size(549, 32)
        Me.tablas.TabIndex = 6
        Me.tablas.Text = "Cargando TABLAS..."
        Me.tablas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tablas.Visible = False
        '
        'BASEDEDATOS
        '
        Me.BASEDEDATOS.BackColor = System.Drawing.Color.Transparent
        Me.BASEDEDATOS.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.BASEDEDATOS.ForeColor = System.Drawing.Color.White
        Me.BASEDEDATOS.Location = New System.Drawing.Point(2, 11)
        Me.BASEDEDATOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BASEDEDATOS.Name = "BASEDEDATOS"
        Me.BASEDEDATOS.Size = New System.Drawing.Size(549, 32)
        Me.BASEDEDATOS.TabIndex = 5
        Me.BASEDEDATOS.Text = "Cargando BASE DE DATOS..."
        Me.BASEDEDATOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BASEDEDATOS.Visible = False
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.White
        Me.ApplicationTitle.Location = New System.Drawing.Point(1, -5)
        Me.ApplicationTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(549, 64)
        Me.ApplicationTitle.TabIndex = 3
        Me.ApplicationTitle.Text = "CARGANDO"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyPanel2
        '
        Me.MyPanel2.BorderColor = System.Drawing.Color.Empty
        Me.MyPanel2.BorderWidth = 0
        Me.MyPanel2.Controls.Add(Me.BASEDEDATOS)
        Me.MyPanel2.Controls.Add(Me.tablas)
        Me.MyPanel2.Controls.Add(Me.interfaz)
        Me.MyPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MyPanel2.Location = New System.Drawing.Point(0, 114)
        Me.MyPanel2.Name = "MyPanel2"
        Me.MyPanel2.Size = New System.Drawing.Size(547, 100)
        Me.MyPanel2.TabIndex = 8
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(549, 216)
        Me.Controls.Add(Me.MyPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MyPanel1.ResumeLayout(False)
        Me.MyPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BASEDEDATOS As Label
    Friend WithEvents tablas As Label
    Friend WithEvents interfaz As Label
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents MyPanel2 As MyPanel
End Class
