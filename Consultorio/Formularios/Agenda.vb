Imports Consultorio

Public Class Agenda
    Dim T_TURNOS As New DataTable
    Dim objTURNO As New Turno
    Dim T_FERIADOS As New DataTable
    Dim objFERIADOS As New Feriados
    Private ListFlDays As New List(Of FlowLayoutPanel)
    Private CurrentDate As DateTime = DateTime.Today
    Dim dt2 As DataTable = New DataTable
    Public Property OverLay As BlurForm

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AGREGARTURNITOS = True
        INICIALIZACION()
        ESFERIADO = False
    End Sub

    Private Sub INICIALIZACION()
        CrearPanelDeDias(42)
        T_TURNOS = objTURNO.Obtener()
        T_FERIADOS = objFERIADOS.Obtener()
        DisplayCurrentDate()

        Domingo.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Domingo.Location = New Point(1, 2)

        Lunes.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Lunes.Location = New Point(Domingo.Size.Width, 2)

        Martes.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Martes.Location = New Point(Lunes.Location.X + Domingo.Size.Width, 2)

        Miercoles.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Miercoles.Location = New Point(Martes.Location.X + Domingo.Size.Width, 2)

        Jueves.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Jueves.Location = New Point(Miercoles.Location.X + (Domingo.Size.Width - 2), 2)

        Viernes.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width) / 7), 26)
        Viernes.Location = New Point(Jueves.Location.X + (Domingo.Size.Width - 2), 2)

        Sabado.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width - 5) / 7), 26)
        Sabado.Location = New Point(Viernes.Location.X + (Domingo.Size.Width - 3), 2)

        If AGREGARTURNITOS = True Then
            flDays.Size = New Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Form.ActiveForm.Size.Height - (Panel1.Height * 3) - (Panel3.Height * 2))
        Else
            flDays.Size = New Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Form.ActiveForm.Size.Height - (Panel1.Height * 3) - (Panel3.Height * 2))
        End If
        AGREGARTURNITOS = False
    End Sub
    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim FirstDayOfMonth As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, 1)
        Return FirstDayOfMonth.DayOfWeek '+ 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim FirstDayOfCurrentDate As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, 1)
        Return FirstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalday As Integer = GetTotalDaysOfCurrentDate()
        Mes.Text = CurrentDate.ToString("MMMM, yyyy").ToUpper
        CrearNumerosParaPanel(firstDayAtFlNumber, totalday)
        AgregarTurnosAlPanel(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        CurrentDate = CurrentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub
    Private Sub NextMonth()
        CurrentDate = CurrentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        CurrentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub CrearPanelDeDias(ByVal totaldays As Integer)
        flDays.Controls.Clear()
        ListFlDays.Clear()
        For i As Integer = 1 To totaldays
            Dim fl As New FlowLayoutPanel
            Dim POPUP As New ToolTip
            fl.Name = $"flDay{i}"
            fl.Size = New Size((Screen.PrimaryScreen.WorkingArea.Size.Width - 65) / 7, (flDays.Size.Height / 6.6))
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.WrapContents = False
            fl.FlowDirection = FlowDirection.TopDown

            POPUP.SetToolTip(fl, "Haga click para agendar nuevo turno")

            'para borrar el autoscroll horizontal
            fl.HorizontalScroll.Maximum = 0
            fl.AutoScroll = False
            fl.VerticalScroll.Visible = False
            fl.AutoScroll = True

            AddHandler fl.Click, AddressOf AgregarNuevoTurno
            flDays.Controls.Add(fl)
            ListFlDays.Add(fl)
        Next
    End Sub

    Private Sub AgregarNuevoTurno(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        Dim Actual = New Date(CurrentDate.Year, CurrentDate.Month, day)
        If day <> 0 And Actual.DayOfWeek <> DayOfWeek.Saturday And Actual.DayOfWeek <> DayOfWeek.Sunday Then
            If Actual.Date >= Now.Date Then
                For Each fila As DataRow In T_FERIADOS.Rows
                    If Actual = fila("Fechas") Then
                        ESFERIADO = True
                        Exit For
                    Else
                        ESFERIADO = False
                    End If
                Next
                If ESFERIADO = False Then
                    With Turnos
                        .txtApellido.Text = ""
                        .txtNombre.Text = ""
                        .txt_observaciones.Text = ""
                        .dtpFecha.Value = New Date(CurrentDate.Year, CurrentDate.Month, day)
                        .ShowDialog()
                    End With
                    objTURNO = New Turno
                    T_TURNOS = objTURNO.Obtener()
                    DisplayCurrentDate()
                Else
                    With FeriadoPop
                        .BackColor = Color.White
                    End With
                    FeriadoPop.ShowDialog()
                    If HABILITARFERIADO = True Then
                        With Turnos
                            .txtApellido.Text = ""
                            .txtNombre.Text = ""
                            .txt_observaciones.Text = ""
                            .dtpFecha.Value = New Date(CurrentDate.Year, CurrentDate.Month, day)
                            .ShowDialog()
                        End With
                        objTURNO = New Turno
                        T_TURNOS = objTURNO.Obtener()
                        DisplayCurrentDate()
                        HABILITARFERIADO = False
                    End If
                End If
            Else
                With ErrorForm
                    .Label2.Text = "No puede seleccionar fechas anteriores"
                    .BackColor = Color.White
                End With
                ErrorForm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub AgregarTurnosAlPanel(ByVal startDayAtFlNumber As Integer)
        Dim stardate As DateTime = New Date(CurrentDate.Year, CurrentDate.Month, 1)
        Dim endDate As DateTime = stardate.AddMonths(1).AddDays(-1)
        Dim i As Integer
        Acomodar()

        For Each row As DataRow In dt2.Rows
            Dim appday As DateTime = DateTime.Parse(row("fecha"))
            If appday >= stardate And appday <= endDate Then
                Dim BOTON As New Button
                Dim img As New Bitmap(My.Resources.TurnoCheck)
                Dim img2 As New Bitmap(img, 10, 10)
                BOTON.Image = img2
                BOTON.TextImageRelation = TextImageRelation.ImageBeforeText
                BOTON.ImageAlign = Drawing.ContentAlignment.TopLeft
                i = +1
                BOTON.Name = $"BOTON{"i"}"
                BOTON.Tag = row("fecha")
                BOTON.TextAlign = Drawing.ContentAlignment.TopLeft
                BOTON.Size = New Size((Screen.PrimaryScreen.WorkingArea.Size.Width - 300) / 7, 23)
                BOTON.Font = New Font("Verdana", 7, FontStyle.Bold)
                BOTON.Text = row("hora") + " - " + row("Apellido") + ", " + row("Nombre")
                BOTON.FlatStyle = FlatStyle.Flat
                BOTON.AccessibleDescription = row("hora")
                ListFlDays(appday.Day + (startDayAtFlNumber - 1)).Controls.Add(BOTON)
                AddHandler BOTON.Click, AddressOf EditarTurno
            End If
        Next
    End Sub

    Sub Acomodar()
        Dim dra() As DataRow = T_TURNOS.Select("", "hora asc")
        If (dra.Length > 0) Then
            dt2 = dra.CopyToDataTable
        End If
    End Sub
    Private Sub EditarTurno(ByVal sender As Object, e As EventArgs)
        Dim day As String = CType(sender, Button).Tag
        ayuda = CType(sender, Button).AccessibleDescription
        With VerTurnos
            .cmb_medicos2.SelectedValue = 1000
            .dtpFecha.Value = day
            VERTURNITOS = True
            .SUBRUTINA(ayuda)
            .ShowDialog()
        End With
        VERTURNITOS = False
        objTURNO = New Turno
        T_TURNOS = objTURNO.Obtener()
        DisplayCurrentDate()
    End Sub
    Private Sub CrearNumerosParaPanel(ByVal startDayAtFlNumber As Integer, ByVal totaldaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In ListFlDays
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totaldaysInMonth
            Dim Lbl As New Label
            Dim POPUP As New ToolTip

            Lbl.Name = $"LblDay{i}"
            Lbl.AutoSize = True
            Lbl.TextAlign = Drawing.ContentAlignment.TopLeft
            Lbl.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width - 500) / 7), 23)
            Lbl.Text = i
            Lbl.ForeColor = Color.Brown
            Lbl.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            ListFlDays((i - 1) + startDayAtFlNumber).Tag = i
            ListFlDays((i - 1) + startDayAtFlNumber).Controls.Add(Lbl)
            POPUP.SetToolTip(Lbl, "Haga click para agendar nuevo turno")


            Dim fecha As Date = New Date(CurrentDate.Year, CurrentDate.Month, i)
            If fecha.DayOfWeek = DayOfWeek.Saturday Or fecha.DayOfWeek = DayOfWeek.Sunday Then
                ListFlDays((i - 1) + startDayAtFlNumber).BackColor = SystemColors.AppWorkspace
            Else
                If New Date(CurrentDate.Year, CurrentDate.Month, i) = Date.Today Then
                    ListFlDays((i - 1) + startDayAtFlNumber).BackColor = Color.SlateBlue
                Else
                    ListFlDays((i - 1) + startDayAtFlNumber).BackColor = Color.White
                End If
            End If

            Update()

            For Each FILA As DataRow In T_FERIADOS.Rows
                If New Date(CurrentDate.Year, CurrentDate.Month, i) = FILA("Fechas") Then
                    ListFlDays((i - 1) + startDayAtFlNumber).BackColor = Color.FromArgb(192, 171, 142)
                    Dim boton As New Label
                    boton.Name = $"BOTON{"i"}"
                    boton.TextAlign = Drawing.ContentAlignment.TopLeft
                    boton.Size = New Size(((Screen.PrimaryScreen.WorkingArea.Size.Width - 300) / 7), 69)
                    boton.Font = New Font("Verdana", 7, FontStyle.Bold)
                    boton.Text = "Feriado:" & vbNewLine & FILA("Feriados")
                    boton.FlatStyle = FlatStyle.Flat
                    ListFlDays((i - 1) + startDayAtFlNumber).Controls.Add(boton)
                Else

                End If
            Next
            AddHandler Lbl.Click, AddressOf AgregarNuevoTurno2
        Next
    End Sub

    Private Sub AgregarNuevoTurno2(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, Label).Text
        Dim Actual = New Date(CurrentDate.Year, CurrentDate.Month, day)
        If day <> 0 And Actual.DayOfWeek <> DayOfWeek.Saturday And Actual.DayOfWeek <> DayOfWeek.Sunday Then
            If Actual.Date >= Now.Date Then
                With Turnos
                    .txtApellido.Text = ""
                    .txtNombre.Text = ""
                    .txt_observaciones.Text = ""
                    .dtpFecha.Value = New Date(CurrentDate.Year, CurrentDate.Month, day)
                    .ShowDialog()
                End With
                objTURNO = New Turno
                T_TURNOS = objTURNO.Obtener()
                DisplayCurrentDate()
            End If
        End If
    End Sub

    Private Sub bMesAntes_Click(sender As Object, e As EventArgs) Handles bMesAntes.Click
        PrevMonth()
    End Sub

    Private Sub bMesDespues_Click(sender As Object, e As EventArgs) Handles bMesDespues.Click
        NextMonth()
    End Sub

    Private Sub bHoy_Click(sender As Object, e As EventArgs) Handles bHoy.Click
        Today()
    End Sub

    Private Sub Agenda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
    End Sub
End Class