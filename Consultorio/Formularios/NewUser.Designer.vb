<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.bGrabar = New System.Windows.Forms.Button()
        Me.bAtras = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbUsuariosNew = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 17)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Nombre de Usuario"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(12, 39)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(81, 17)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(163, 9)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(164, 22)
        Me.txtNombre.TabIndex = 14
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(163, 38)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(164, 22)
        Me.txtContraseña.TabIndex = 15
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(12, 71)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(144, 17)
        Me.Label55.TabIndex = 16
        Me.Label55.Text = "Confirmar contraseña"
        '
        'txtRepetir
        '
        Me.txtRepetir.Location = New System.Drawing.Point(163, 69)
        Me.txtRepetir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepetir.Size = New System.Drawing.Size(164, 22)
        Me.txtRepetir.TabIndex = 17
        '
        'bGrabar
        '
        Me.bGrabar.Location = New System.Drawing.Point(340, 96)
        Me.bGrabar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGrabar.Name = "bGrabar"
        Me.bGrabar.Size = New System.Drawing.Size(100, 25)
        Me.bGrabar.TabIndex = 18
        Me.bGrabar.Text = "Grabar"
        Me.bGrabar.UseVisualStyleBackColor = True
        '
        'bAtras
        '
        Me.bAtras.Location = New System.Drawing.Point(19, 96)
        Me.bAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bAtras.Name = "bAtras"
        Me.bAtras.Size = New System.Drawing.Size(95, 25)
        Me.bAtras.TabIndex = 19
        Me.bAtras.Text = "Atrás"
        Me.bAtras.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(340, 160)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(100, 28)
        Me.bEliminar.TabIndex = 22
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 167)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Usuario"
        '
        'cmbUsuariosNew
        '
        Me.cmbUsuariosNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuariosNew.FormattingEnabled = True
        Me.cmbUsuariosNew.Location = New System.Drawing.Point(137, 158)
        Me.cmbUsuariosNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUsuariosNew.Name = "cmbUsuariosNew"
        Me.cmbUsuariosNew.Size = New System.Drawing.Size(189, 24)
        Me.cmbUsuariosNew.TabIndex = 23
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 224)
        Me.Controls.Add(Me.cmbUsuariosNew)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bAtras)
        Me.Controls.Add(Me.bGrabar)
        Me.Controls.Add(Me.txtRepetir)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label22)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtRepetir As TextBox
    Friend WithEvents bGrabar As Button
    Friend WithEvents bAtras As Button
    Friend WithEvents bEliminar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbUsuariosNew As ComboBox
End Class
