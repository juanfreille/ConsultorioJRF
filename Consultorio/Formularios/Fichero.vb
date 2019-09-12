Imports System.ComponentModel
Imports Consultorio

Public Class Fichero
    Dim T_PACIENTES As New DataTable
    Dim TABLA_ORDENADA As New DataTable
    Dim objPACIENTES As New Paciente
    Dim buleano As Boolean = True
    Dim aux As New SuperGrid
    Public Property OverLay As BlurForm

    Private Sub Fichero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buleano = True
        T_PACIENTES = objPACIENTES.Obtener()
        '        Width = Principal.Width * 0.9
        '       Height = Principal.Height * 0.8
        'CenterForm(Me, MdiParent)
        '        Top = Top - 30
        Me.Dock = DockStyle.Fill
        Acomodar()
        SuperGrid1.PageSize = 20
        SuperGrid1.SetPagedDataSource(TABLA_ORDENADA, BindingNavigator1)
        SuperGrid1.Columns(0).Visible = False
        SuperGrid1.Columns(12).Visible = False
        With SuperGrid1
            .RowHeadersVisible = False
            .Columns(1).HeaderCell.Value = "Apellido"
            .Columns(2).HeaderCell.Value = "Nombre"
            .Columns(3).HeaderCell.Value = "Edad"
            .Columns(4).HeaderCell.Value = "Calle"
            .Columns(5).HeaderCell.Value = "N° (Calle)"
            .Columns(6).HeaderCell.Value = "Teléfono"
            .Columns(7).HeaderCell.Value = "Dni"
            .Columns(8).HeaderCell.Value = "Obra Social"
            .Columns(9).HeaderCell.Value = "Afiliado"
            .Columns(10).HeaderCell.Value = "Código"
            .Columns(11).HeaderCell.Value = "Celular"
            .Columns(13).HeaderCell.Value = "Barrio/Localidad"
        End With

        SuperGrid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        SuperGrid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '        SuperGrid1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        SuperGrid1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        SuperGrid1.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.SuperGrid1.SuspendLayout()

        'Make the grid wide enough to fit all columns, allowing for the border width.
        Me.SuperGrid1.Width = ParentForm.Width
        Me.SuperGrid1.Left = (ParentForm.Width - Me.SuperGrid1.Width) \ 2
        Me.SuperGrid1.ResumeLayout()
        Select Case SKIN
            Case "NORMAL"
                Panel1.BackColor = Color.SlateGray
                Panel3.BackColor = Color.SlateGray
                Panel4.BackColor = Color.SlateGray
            Case "OSCURO"
                Panel1.BackColor = Color.FromArgb(47, 79, 79)
                Panel3.BackColor = Color.FromArgb(47, 79, 79)
                Panel4.BackColor = Color.FromArgb(47, 79, 79)
            Case "GREEN"
                Panel1.BackColor = Color.FromArgb(131, 174, 164)
                Panel3.BackColor = Color.FromArgb(131, 174, 164)
                Panel4.BackColor = Color.FromArgb(131, 174, 164)
            Case "MARRON"
                Panel1.BackColor = Color.FromArgb(65, 59, 59)
                Panel3.BackColor = Color.FromArgb(65, 59, 59)
                Panel4.BackColor = Color.FromArgb(65, 59, 59)
        End Select
    End Sub

    Sub Acomodar()
        TABLA_ORDENADA.Clear()
        Dim dra() As DataRow = T_PACIENTES.Select("", "Apellido asc")
        If (dra.Length > 0) Then
            TABLA_ORDENADA = dra.CopyToDataTable
        End If
        For Each fila As DataRow In TABLA_ORDENADA.Rows
            If fila("Telefono") = "0" Or fila("Telefono") = Nothing Then
                fila("Telefono") = "N/S"
            End If
            If fila("Celular") = "0" Or fila("Celular") = Nothing Then
                fila("Celular") = "N/S"
            End If
            If fila("Codigo") = "0" Or fila("Codigo") = Nothing Then
                fila("Codigo") = "No tiene"
            End If
            If fila("Afiliado") = "0" Or fila("Afiliado") = Nothing Then
                fila("Afiliado") = "No tiene"
            End If
        Next
    End Sub

    Private Sub Convertidor()
        TextBox1.Text = StrConv(TextBox1.Text, vbProperCase)
    End Sub

    Private Sub bDNI_Click(sender As Object, e As EventArgs) Handles bDNI.Click
        Dim temp As Integer = 0
        Dim contador As Integer = 0
        Dim tabla1 As DataTable = SuperGrid1.tables.First
        Dim paginas As Integer = 1
        Dim j As Integer = 0
        Dim pagina_inicial As Integer
        Convertidor()

        pagina_inicial = BindingNavigatorPositionItem.Text

        If TextBox1.Text = "" Then
            With ErrorForm
                .Label2.Text = "Debe ingresar un DNI"
                .BackColor = Color.White
            End With
            ErrorForm.ShowDialog(Me)
        Else
            For Each tabla As DataTable In SuperGrid1.tables
                Dim tablita As New DataTable
                tablita = tabla
                contador = 0
                For Each fila As DataRow In tablita.Rows
                    If fila(tablita.Columns("dni")) = TextBox1.Text Then
                        temp = 1
                        SuperGrid1.ClearSelection()
                        BindingNavigatorPositionItem.Text = Val(paginas)
                        While pagina_inicial < paginas
                            BindingNavigatorMoveNextItem.PerformClick()
                            pagina_inicial = pagina_inicial + 1
                        End While
                        While pagina_inicial > paginas
                            BindingNavigatorMovePreviousItem.PerformClick()
                            pagina_inicial = pagina_inicial - 1
                        End While
                        SuperGrid1.CurrentCell = SuperGrid1.Rows(contador).Cells(1)
                        SuperGrid1.Rows(contador).Selected = True
                        Dim timeIncubation_End_Time As Date
                        timeIncubation_End_Time = Now.AddSeconds(5)
                        Me.Enabled = False
                        With Exito
                            .Label2.Text = "Paciente encontrado!"
                            .BackColor = Color.White
                        End With
                        Exito.Show()

                        Do While Exito.Visible And timeIncubation_End_Time > Now
                            Application.DoEvents()
                            Threading.Thread.Sleep(100)
                        Loop
                        Exito.Close()
                        Me.Enabled = True
                        Exit For
                    End If
                    contador = contador + 1
                Next
                If temp = 1 Then
                    Exit For
                End If
                paginas = paginas + 1
            Next
            If temp = 0 Then
                Dim timeIncubation_End_Time As Date
                timeIncubation_End_Time = Now.AddSeconds(5)
                Me.Enabled = False
                With ErrorForm
                    .Label2.Text = "El paciente no se ha encontrado"
                    .BackColor = Color.White
                End With
                ErrorForm.Show()

                Do While ErrorForm.Visible And timeIncubation_End_Time > Now
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                Loop
                ErrorForm.Close()
                Me.Enabled = True
            End If
        End If
    End Sub

    Private Sub bApellido_Click(sender As Object, e As EventArgs) Handles bApellido.Click
        Dim temp As Integer = 0
        Dim contador As Integer = 0
        Dim tabla1 As DataTable = SuperGrid1.tables.First
        Dim paginas As Integer = 1
        Dim j As Integer = 0
        Dim pagina_inicial As Integer
        Convertidor()

        pagina_inicial = BindingNavigatorPositionItem.Text

        If TextBox1.Text = "" Then
            With ErrorForm
                .Label2.Text = "Debe ingresar un DNI"
                .BackColor = Color.White
            End With
            ErrorForm.ShowDialog(Me)
        Else
            For Each tabla As DataTable In SuperGrid1.tables
                Dim tablita As New DataTable
                tablita = tabla
                contador = 0
                For Each fila As DataRow In tablita.Rows
                    If fila(tablita.Columns("apellido")) = TextBox1.Text Then
                        temp = 1
                        SuperGrid1.ClearSelection()
                        BindingNavigatorPositionItem.Text = Val(paginas)
                        While pagina_inicial < paginas
                            BindingNavigatorMoveNextItem.PerformClick()
                            pagina_inicial = pagina_inicial + 1
                        End While
                        While pagina_inicial > paginas
                            BindingNavigatorMovePreviousItem.PerformClick()
                            pagina_inicial = pagina_inicial - 1
                        End While
                        SuperGrid1.CurrentCell = SuperGrid1.Rows(contador).Cells(1)
                        SuperGrid1.Rows(contador).Selected = True
                        Dim timeIncubation_End_Time As Date
                        timeIncubation_End_Time = Now.AddSeconds(5)
                        Me.Enabled = False
                        With Exito
                            .Label2.Text = "Paciente encontrado!"
                            .BackColor = Color.White
                        End With
                        Exito.Show()

                        Do While Exito.Visible And timeIncubation_End_Time > Now
                            Application.DoEvents()
                            Threading.Thread.Sleep(100)
                        Loop
                        Exito.Close()
                        Me.Enabled = True
                        Exit For
                    End If
                    contador = contador + 1
                Next
                If temp = 1 Then
                    Exit For
                End If
                paginas = paginas + 1
            Next
            If temp = 0 Then
                Dim timeIncubation_End_Time As Date
                timeIncubation_End_Time = Now.AddSeconds(5)
                Me.Enabled = False
                With ErrorForm
                    .Label2.Text = "El paciente no se ha encontrado"
                    .BackColor = Color.White
                End With
                ErrorForm.Show()

                Do While ErrorForm.Visible And timeIncubation_End_Time > Now
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                Loop
                ErrorForm.Close()
                Me.Enabled = True
            Else

            End If
        End If
    End Sub

    Private Sub SuperGrid1_DoubleClick(sender As Object, e As System.EventArgs) Handles SuperGrid1.DoubleClick
        DATOUNICOABUSCAR = SuperGrid1.CurrentRow.Cells(7).Value
        Dim form As New Historia
        form.MdiParent = Principal
        form.Show()
    End Sub

    Private Sub EditarFicha_Click(sender As Object, e As EventArgs) Handles EditarFicha.Click
        DATOUNICOABUSCAR = SuperGrid1.CurrentRow.Cells(7).Value
        Dim form As New Pacientes
        form.MdiParent = Principal
        form.Show()
    End Sub

    Private Sub VerHistoria_Click(sender As Object, e As EventArgs) Handles VerHistoria.Click
        DATOUNICOABUSCAR = SuperGrid1.CurrentRow.Cells(7).Value
        Dim form As New Historia
        '        form.MdiParent = Principal
        form.ShowDialog()
    End Sub

    Private Sub ImprimirFicha_Click(sender As Object, e As EventArgs) Handles ImprimirFicha.Click
        DATOUNICOABUSCAR = SuperGrid1.CurrentRow.Cells(7).Value
        Dim form As New Imprimir
        form.MdiParent = Principal
        form.Show()
    End Sub

    Private Sub SuperGrid1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SuperGrid1.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            SuperGrid1.CurrentCell = SuperGrid1(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buleano = False
        Me.Close()
    End Sub

    Private Sub Fichero_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If buleano = False Then
            Dim form As New Fichero
            form.MdiParent = Principal
            form.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class