<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agenda
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mes = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bHoy = New System.Windows.Forms.Button()
        Me.bMesDespues = New System.Windows.Forms.Button()
        Me.bMesAntes = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Domingo = New System.Windows.Forms.Label()
        Me.Sabado = New System.Windows.Forms.Label()
        Me.Viernes = New System.Windows.Forms.Label()
        Me.Jueves = New System.Windows.Forms.Label()
        Me.Miercoles = New System.Windows.Forms.Label()
        Me.Martes = New System.Windows.Forms.Label()
        Me.Lunes = New System.Windows.Forms.Label()
        Me.flDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lblinicial = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.flDays.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Mes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1340, 54)
        Me.Panel1.TabIndex = 0
        '
        'Mes
        '
        Me.Mes.AutoSize = True
        Me.Mes.Font = New System.Drawing.Font("Bahnschrift", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mes.Location = New System.Drawing.Point(21, 5)
        Me.Mes.Margin = New System.Windows.Forms.Padding(0)
        Me.Mes.Name = "Mes"
        Me.Mes.Size = New System.Drawing.Size(235, 52)
        Me.Mes.TabIndex = 2
        Me.Mes.Text = "Enero, 2019"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bHoy)
        Me.Panel2.Controls.Add(Me.bMesDespues)
        Me.Panel2.Controls.Add(Me.bMesAntes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1116, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 54)
        Me.Panel2.TabIndex = 1
        '
        'bHoy
        '
        Me.bHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHoy.Location = New System.Drawing.Point(65, 6)
        Me.bHoy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bHoy.Name = "bHoy"
        Me.bHoy.Size = New System.Drawing.Size(77, 39)
        Me.bHoy.TabIndex = 2
        Me.bHoy.Text = "Hoy"
        Me.bHoy.UseVisualStyleBackColor = True
        '
        'bMesDespues
        '
        Me.bMesDespues.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMesDespues.Location = New System.Drawing.Point(148, 6)
        Me.bMesDespues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bMesDespues.Name = "bMesDespues"
        Me.bMesDespues.Size = New System.Drawing.Size(41, 39)
        Me.bMesDespues.TabIndex = 1
        Me.bMesDespues.Text = ">>"
        Me.bMesDespues.UseVisualStyleBackColor = True
        '
        'bMesAntes
        '
        Me.bMesAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMesAntes.Location = New System.Drawing.Point(15, 6)
        Me.bMesAntes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bMesAntes.Name = "bMesAntes"
        Me.bMesAntes.Size = New System.Drawing.Size(41, 39)
        Me.bMesAntes.TabIndex = 0
        Me.bMesAntes.Text = "<<"
        Me.bMesAntes.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Domingo)
        Me.Panel3.Controls.Add(Me.Sabado)
        Me.Panel3.Controls.Add(Me.Viernes)
        Me.Panel3.Controls.Add(Me.Jueves)
        Me.Panel3.Controls.Add(Me.Miercoles)
        Me.Panel3.Controls.Add(Me.Martes)
        Me.Panel3.Controls.Add(Me.Lunes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1340, 34)
        Me.Panel3.TabIndex = 2
        '
        'Domingo
        '
        Me.Domingo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Domingo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domingo.Location = New System.Drawing.Point(3, 2)
        Me.Domingo.Name = "Domingo"
        Me.Domingo.Size = New System.Drawing.Size(213, 28)
        Me.Domingo.TabIndex = 6
        Me.Domingo.Text = "Domingo"
        Me.Domingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sabado
        '
        Me.Sabado.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Sabado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sabado.Location = New System.Drawing.Point(1331, 2)
        Me.Sabado.Name = "Sabado"
        Me.Sabado.Size = New System.Drawing.Size(213, 28)
        Me.Sabado.TabIndex = 5
        Me.Sabado.Text = "Sábado"
        Me.Sabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Viernes
        '
        Me.Viernes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Viernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Viernes.Location = New System.Drawing.Point(1111, 2)
        Me.Viernes.Name = "Viernes"
        Me.Viernes.Size = New System.Drawing.Size(213, 28)
        Me.Viernes.TabIndex = 4
        Me.Viernes.Text = "Viernes"
        Me.Viernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Jueves
        '
        Me.Jueves.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Jueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jueves.Location = New System.Drawing.Point(889, 2)
        Me.Jueves.Name = "Jueves"
        Me.Jueves.Size = New System.Drawing.Size(213, 28)
        Me.Jueves.TabIndex = 3
        Me.Jueves.Text = "Jueves"
        Me.Jueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Miercoles
        '
        Me.Miercoles.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Miercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Miercoles.Location = New System.Drawing.Point(668, 2)
        Me.Miercoles.Name = "Miercoles"
        Me.Miercoles.Size = New System.Drawing.Size(213, 28)
        Me.Miercoles.TabIndex = 2
        Me.Miercoles.Text = "Miércoles"
        Me.Miercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Martes
        '
        Me.Martes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Martes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Martes.Location = New System.Drawing.Point(445, 2)
        Me.Martes.Name = "Martes"
        Me.Martes.Size = New System.Drawing.Size(213, 28)
        Me.Martes.TabIndex = 1
        Me.Martes.Text = "Martes"
        Me.Martes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lunes
        '
        Me.Lunes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lunes.Location = New System.Drawing.Point(224, 2)
        Me.Lunes.Name = "Lunes"
        Me.Lunes.Size = New System.Drawing.Size(213, 28)
        Me.Lunes.TabIndex = 0
        Me.Lunes.Text = "Lunes"
        Me.Lunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flDays
        '
        Me.flDays.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flDays.BackColor = System.Drawing.Color.White
        Me.flDays.Controls.Add(Me.FlowLayoutPanel2)
        Me.flDays.Location = New System.Drawing.Point(0, 94)
        Me.flDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flDays.Name = "flDays"
        Me.flDays.Size = New System.Drawing.Size(1779, 553)
        Me.flDays.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.BurlyWood
        Me.FlowLayoutPanel2.Controls.Add(Me.Lblinicial)
        Me.FlowLayoutPanel2.Controls.Add(Me.LinkLabel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.LinkLabel2)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 2)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(155, 103)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Lblinicial
        '
        Me.Lblinicial.Location = New System.Drawing.Point(3, 0)
        Me.Lblinicial.Name = "Lblinicial"
        Me.Lblinicial.Size = New System.Drawing.Size(148, 23)
        Me.Lblinicial.TabIndex = 0
        Me.Lblinicial.Text = "1"
        Me.Lblinicial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 23)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(147, 23)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Turno 1"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 46)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(149, 23)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Turno 2"
        '
        'Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 646)
        Me.Controls.Add(Me.flDays)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agenda"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.flDays.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bMesDespues As Button
    Friend WithEvents bMesAntes As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Domingo As Label
    Friend WithEvents Sabado As Label
    Friend WithEvents Viernes As Label
    Friend WithEvents Jueves As Label
    Friend WithEvents Miercoles As Label
    Friend WithEvents Martes As Label
    Friend WithEvents Lunes As Label
    Friend WithEvents flDays As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Lblinicial As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents bHoy As Button
    Friend WithEvents Mes As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
