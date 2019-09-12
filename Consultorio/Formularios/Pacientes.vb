Imports Consultorio

Public Class Pacientes
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim T_PACIENTES As New DataTable
    Dim objPACIENTES As New Paciente
    Public Property OverLay As BlurForm

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_PACIENTES = objPACIENTES.Obtener()
        cmbObra.SelectedIndex = 0
        If DATOUNICOABUSCAR IsNot Nothing Then
            txt_nro_doc.Text = DATOUNICOABUSCAR
            cmd_buscar.PerformClick()
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
    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If txt_nro_doc.Text = "" Then
            With WarningForm
                .Label2.Text = "Para buscar, primero debe ingresar un DNI"
            End With
            WarningForm.ShowDialog(Me)

        Else
            If txt_nro_doc.Text <> "" Then
                Dim Paciente(12) As String
                Paciente = objPACIENTES.Buscar(txt_nro_doc.Text)
                If Paciente Is Nothing Then
                    With ErrorForm
                        .Label2.Text = "La ficha de ese paciente no existe"
                        .BackColor = Color.White
                    End With
                    ErrorForm.ShowDialog(Me)
                Else
                    txt_ape.Text = Paciente(0)
                    txt_nom.Text = Paciente(1)
                    txt_edad.Text = Paciente(2)
                    txt_calle.Text = Paciente(3)
                    txt_nro_calle.Text = Paciente(4)
                    txt_telefono.Text = Paciente(5)
                    txt_celular.Text = Paciente(6)
                    txt_doc.Text = Paciente(7)
                    cmbObra.Text = Paciente(8)
                    txt_afiliado.Text = Paciente(9)
                    txt_codigo.Text = Paciente(10)
                    If Paciente(11) IsNot Nothing And Paciente(11) Is "1/1/1753" Then
                        DateTimePicker2.Value = Paciente(11)
                    Else
                        DateTimePicker2.Value = Today
                    End If
                    txt_barrio.Text = Paciente(12)
                    bGuardar.Enabled = True
                    bModificar.Enabled = True
                    bEliminar.Enabled = True
                    grp_datos_personales.Enabled = True
                    grp_domicilio.Enabled = True
                    grp_obra.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Convertidor()
        txt_ape.Text = StrConv(txt_ape.Text, vbProperCase)
        txt_nom.Text = StrConv(txt_nom.Text, vbProperCase)
        txt_calle.Text = StrConv(txt_calle.Text, vbProperCase)
        txt_barrio.Text = StrConv(txt_barrio.Text, vbProperCase)
    End Sub
    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Dim OK As Boolean
        Convertidor()
        If CheckBox1.Checked = True Then
            OK = objPACIENTES.Grabar(txt_ape.Text, txt_nom.Text, Val(txt_edad.Text), txt_calle.Text, Val(txt_nro_calle.Text), Val(txt_telefono.Text), Val(txt_doc.Text), cmbObra.SelectedItem, Val(txt_afiliado.Text), Val(txt_codigo.Text), Val(txt_celular.Text), DateTimePicker2.Value.ToShortDateString, txt_barrio.Text)
        Else
            OK = objPACIENTES.Grabar(txt_ape.Text, txt_nom.Text, Val(txt_edad.Text), txt_calle.Text, Val(txt_nro_calle.Text), Val(txt_telefono.Text), Val(txt_doc.Text), cmbObra.SelectedItem, Val(txt_afiliado.Text), Val(txt_codigo.Text), Val(txt_celular.Text), "1/1/1753", txt_barrio.Text)
        End If
        If OK = True Then
            '            MessageBox.Show("El paciente ha sido cargado con exito en el fichero", "MENSAJE")
            With Exito
                .Label2.Text = "La ficha se ha cargado con exito"
            End With
            Exito.ShowDialog(Me)
            txt_nro_doc.Clear()
            txt_ape.Clear()
            txt_nom.Clear()
            txt_doc.Clear()
            txt_depto.Clear()
            txt_calle.Clear()
            txt_celular.Clear()
            txt_codigo.Clear()
            txt_edad.Clear()
            txt_nro_calle.Clear()
            txt_piso.Clear()
            txt_telefono.Clear()
            txt_afiliado.Clear()
            txt_barrio.Clear()
            cmbObra.SelectedIndex = 0
            txt_nro_doc.Focus()
        Else
            With ErrorForm
                .Label2.Text = "La ficha ya existe, no se puede cargar"
            End With
            ErrorForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If CheckBox1.Checked = True Then
            If DateTimePicker2.Value <> "1/1/1753" Then
                Dim Años = DateTime.Now.Year - DateTimePicker2.Value.Year
                If (DateTimePicker2.Value.AddYears(Años) > DateTime.Now) Then
                    Años = (Años - 1)
                End If
                txt_edad.Text = Años
            End If
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        ELIMINAR = False
        Advertencia.ShowDialog()

        If ELIMINAR = True Then
            objPACIENTES.Eliminar(txt_doc.Text)
            txt_nro_doc.Clear()
            txt_ape.Clear()
            txt_nom.Clear()
            txt_doc.Clear()
            txt_depto.Clear()
            txt_calle.Clear()
            txt_celular.Clear()
            txt_codigo.Clear()
            txt_edad.Clear()
            txt_nro_calle.Clear()
            txt_piso.Clear()
            txt_telefono.Clear()
            txt_afiliado.Clear()
            txt_barrio.Clear()
            cmbObra.SelectedIndex = 0
            txt_nro_doc.Focus()
        Else
        End If
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Convertidor()
        objPACIENTES.Modificar(txt_ape.Text, txt_nom.Text, Val(txt_edad.Text), txt_calle.Text, Val(txt_nro_calle.Text), Val(txt_telefono.Text), Val(txt_doc.Text), cmbObra.SelectedItem, Val(txt_afiliado.Text), Val(txt_codigo.Text), Val(txt_celular.Text), DateTimePicker2.Value.ToShortDateString, txt_barrio.Text)
        With Exito
            .Label2.Text = "La ficha se ha modificado con exito"
        End With
        Exito.ShowDialog(Me)
        txt_nro_doc.Clear()
        txt_ape.Clear()
        txt_nom.Clear()
        txt_doc.Clear()
        txt_depto.Clear()
        txt_calle.Clear()
        txt_celular.Clear()
        txt_codigo.Clear()
        txt_edad.Clear()
        txt_nro_calle.Clear()
        txt_piso.Clear()
        txt_telefono.Clear()
        txt_afiliado.Clear()
        txt_barrio.Clear()
        cmbObra.SelectedIndex = 0
        txt_nro_doc.Focus()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bNuevaFicha_Click(sender As Object, e As EventArgs) Handles bNuevaFicha.Click
        grp_datos_personales.Enabled = True
        grp_domicilio.Enabled = True
        grp_obra.Enabled = True
        bGuardar.Enabled = True
        bModificar.Enabled = True
        bEliminar.Enabled = True
    End Sub
    Private Sub Pacientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        DATOUNICOABUSCAR = Nothing
    End Sub

    Private Sub Pacientes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_nro_doc.Focus()
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class