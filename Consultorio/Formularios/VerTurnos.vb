Imports Consultorio

Public Class VerTurnos
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim T_MEDICOS As New DataTable
    Dim objMEDICOS As New Medicos
    Dim objTURNO As New Turno
    Public Property OverLay As BlurForm

    Private Sub VerTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_MEDICOS = objMEDICOS.Obtener()
        objMEDICOS.VER(cmb_medicos2)
        CALENDARIO_INICIAL()
        If VERTURNITOS = True Then
            SUBRUTINA(ayuda)
        End If
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
        If dtpFecha.Value.DayOfWeek = DayOfWeek.Saturday Or dtpFecha.Value.DayOfWeek = DayOfWeek.Sunday Then
            If dtpFecha.Value.DayOfWeek = DayOfWeek.Saturday Then
                dtpFecha.MinDate = Today.AddDays(2)
            Else
                dtpFecha.MinDate = Today.AddDays(1)
            End If
        End If
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim INICIO As DateTime
        Dim FINAL As DateTime

        grid_turnos.Rows.Clear()
        For Each FILA As DataRow In T_MEDICOS.Rows
            INICIO = CDate(FILA(T_MEDICOS.Columns("desde")))
            If FILA(T_MEDICOS.Columns("matricula")) = cmb_medicos2.SelectedValue Then
                FINAL = CDate(FILA(T_MEDICOS.Columns("hasta")))
                While INICIO < FINAL
                    Dim PACIENTE(5) As String
                    PACIENTE = objTURNO.Nombre(cmb_medicos2.SelectedValue, dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"))
                    If objTURNO.Buscar(cmb_medicos2.SelectedValue, dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm")) <> INICIO.ToString("HH:mm") Then
                        If INICIO < "13:00" Or INICIO > "13:30" Then
                            grid_turnos.Rows.Add(dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"))
                        End If
                    Else
                        If INICIO < "13:00" Or INICIO > "13:30" Then
                            grid_turnos.Rows.Add(dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"), PACIENTE(2), PACIENTE(3), PACIENTE(4))
                        End If
                    End If
                    INICIO = INICIO + TimeSpan.FromMinutes(FILA(T_MEDICOS.Columns("duracion")))
                End While
            End If
        Next
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("¿Cancelar turno?" + vbLf + "Se borrará el turno y se cargará la lista nuevamente", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        Else
            objTURNO.Eliminar(cmb_medicos2.SelectedValue, grid_turnos.CurrentRow.Cells(0).Value, grid_turnos.CurrentRow.Cells(1).Value)
            cmd_buscar.PerformClick()
        End If
    End Sub

    Private Sub Turnos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If VERTURNITOS = True Then
            VERTURNITOS = False
        Else
            If Me.OverLay IsNot Nothing Then
                Me.OverLay.Close()
            End If
        End If
    End Sub

    Sub SUBRUTINA(ayuda As String)
        Dim INICIO As DateTime
        Dim FINAL As DateTime

        grid_turnos.Rows.Clear()
        For Each FILA As DataRow In T_MEDICOS.Rows
            INICIO = CDate(FILA(T_MEDICOS.Columns("desde")))
            If FILA(T_MEDICOS.Columns("matricula")) = cmb_medicos2.SelectedValue Then
                FINAL = CDate(FILA(T_MEDICOS.Columns("hasta")))
                While INICIO < FINAL
                    Dim PACIENTE(5) As String
                    PACIENTE = objTURNO.Nombre(cmb_medicos2.SelectedValue, dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"))
                    If objTURNO.Buscar(cmb_medicos2.SelectedValue, dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm")) <> INICIO.ToString("HH:mm") Then
                        If INICIO < "13:00" Or INICIO > "13:30" Then
                            grid_turnos.Rows.Add(dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"))
                        End If
                    Else
                        If INICIO < "13:00" Or INICIO > "13:30" Then
                            grid_turnos.Rows.Add(dtpFecha.Value.ToShortDateString, INICIO.ToString("HH:mm"), PACIENTE(2), PACIENTE(3), PACIENTE(4))
                        End If
                    End If
                    INICIO = INICIO + TimeSpan.FromMinutes(FILA(T_MEDICOS.Columns("duracion")))
                End While
            End If
        Next
        For i As Integer = 0 To grid_turnos.RowCount - 1
            If grid_turnos.Rows(i).Cells(1).Value = ayuda Then
                grid_turnos.ClearSelection()
                grid_turnos.CurrentCell = grid_turnos.Rows(i).Cells(0)
                grid_turnos.Rows(i).Selected = True
                Exit For
            End If
        Next

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

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class