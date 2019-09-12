Imports Consultorio

Public Class Turnos
    Dim T_MEDICOS As New DataTable
    Dim objMEDICOS As New Medicos
    Dim objTURNO As New Turno
    Public Property OverLay As BlurForm

    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_MEDICOS = objMEDICOS.Obtener()
        objMEDICOS.VER(cmb_medicos)
        LLENAR_CMB_HORA()
        CALENDARIO_INICIAL()
        '        bReservar.Enabled = False
        Select Case SKIN
            Case "NORMAL"
                Panel1.BackColor = Color.SlateGray
            Case "OSCURO"
                Panel1.BackColor = Color.FromArgb(47, 79, 79)
            Case "GREEN"
                Panel1.BackColor = Color.FromArgb(131, 174, 164)
            Case "MARRON"
                Panel1.BackColor = Color.FromArgb(65, 59, 59)
        End Select
    End Sub

    Sub CALENDARIO_INICIAL()
        'Cuando iniciamos hacemos comprobacion de que el dia actual no sea ni sabado ni domingo, y de darse esta condicion la fecha actual se correrá a lunes.
        dtpFecha.MinDate = Today
        If dtpFecha.Value.DayOfWeek = DayOfWeek.Saturday Or dtpFecha.Value.DayOfWeek = DayOfWeek.Sunday Then
            If dtpFecha.Value.DayOfWeek = DayOfWeek.Saturday Then
                dtpFecha.MinDate = Today.AddDays(2)
            Else
                dtpFecha.MinDate = Today.AddDays(1)
            End If
        End If
    End Sub
    Sub LLENAR_CMB_HORA()
        bReservar.Enabled = True

        Dim INICIO As DateTime
        Dim FINAL As DateTime

        cbHora.Items.Clear()
        For Each FILA As DataRow In T_MEDICOS.Rows

            INICIO = CDate(FILA(T_MEDICOS.Columns("desde")))
            If FILA(T_MEDICOS.Columns("matricula")) = cmb_medicos.SelectedValue Then

                FINAL = CDate(FILA(T_MEDICOS.Columns("hasta")))

                While INICIO < FINAL
                    If objTURNO.Buscar(cmb_medicos.SelectedValue, dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm")) <> INICIO.ToString("HH:mm") Then
                        If INICIO < "13:00" Or INICIO > "13:30" Then
                            If cmb_medicos.SelectedIndex = 0 Then
                                cbHora.Items.Add(INICIO.ToString("HH:mm"))
                            End If
                            If cmb_medicos.SelectedIndex = 1 And dtpFecha.Value.DayOfWeek = DayOfWeek.Monday Then
                                cbHora.Items.Add(INICIO.ToString("HH:mm"))
                            End If
                            If cmb_medicos.SelectedIndex = 2 And dtpFecha.Value.DayOfWeek = DayOfWeek.Wednesday Or dtpFecha.Value.DayOfWeek = DayOfWeek.Friday Then
                                cbHora.Items.Add(INICIO.ToString("HH:mm"))
                            End If
                        End If
                    End If
                    INICIO = INICIO + TimeSpan.FromMinutes(FILA(T_MEDICOS.Columns("duracion")))
                End While
            End If
        Next

        Try
            cbHora.SelectedIndex = 0
        Catch
            cbHora.Items.Add("No Disponible")
            cbHora.SelectedItem = "No Disponible"
            bReservar.Enabled = False
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        LLENAR_CMB_HORA()
    End Sub

    Private Sub cmb_medicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_medicos.SelectedIndexChanged
        LLENAR_CMB_HORA()
    End Sub

    Private Sub bReservar_Click(sender As Object, e As EventArgs) Handles bReservar.Click
        'Si la fecha es distinta de sabado o domingo, mandamos a funcion grabar, de lo contrario mostramos mensaje de que se debe corregir la fecha.
        'Usamos la funcion grabar para enviar los datos del nuevo turno, salta el popup, y luego se recarga el combo, y se limpia el campo del txt.
        If dtpFecha.Value.DayOfWeek <> DayOfWeek.Saturday And dtpFecha.Value.DayOfWeek <> DayOfWeek.Sunday Then
            Dim fecha As String = dtpFecha.Value.ToShortDateString
            Dim OK As Boolean = objTURNO.Grabar((cmb_medicos.SelectedValue), dtpFecha.Value.ToShortDateString, cbHora.SelectedItem, txtApellido.Text, txtNombre.Text, txt_observaciones.Text)
            If OK = True Then
                With Exito
                    .BackColor = Color.White
                    .Label2.Text = "Turno agendado: " & dtpFecha.Value.ToShortDateString & vbLf & "Hora: " & cbHora.SelectedItem
                End With
                Exito.ShowDialog(Me)

                LLENAR_CMB_HORA()
                txtApellido.Clear()
                txtNombre.Clear()
                txt_observaciones.Clear()
                txtApellido.Focus()
            End If
        Else
            MessageBox.Show("Debe corregir la fecha, debe ser un dia de lunes a viernes.", "MENSAJE")
        End If

    End Sub

    Private Sub Turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

End Class