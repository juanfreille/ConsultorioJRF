Public Class Consulta
    Dim T_PACIENTES As New DataTable
    Dim objPACIENTES As New Paciente
    Dim objCONSULTAS As New Consultas
    Public Property OverLay As BlurForm

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_PACIENTES = objPACIENTES.Obtener()
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
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        If txt_nro_doc.Text = "" Then
            With WarningForm
                .BackColor = Color.White
                .Label2.Text = "Debe ingresar un DNI primero"
            End With
            WarningForm.ShowDialog(Me)
        Else
            If txt_nro_doc.Text <> "" Then
                Dim Paciente(12) As String
                Paciente = objPACIENTES.Buscar(txt_nro_doc.Text)
                If Paciente Is Nothing Then
                    With WarningForm
                        .BackColor = Color.White
                        .Label2.Text = "El N° ingresado no existe en el fichero"
                    End With
                    WarningForm.ShowDialog(Me)
                Else
                    txt_ape.Text = Paciente(0)
                    txt_nom.Text = Paciente(1)
                    txt_doc.Text = Paciente(7)

                End If
            End If
        End If
    End Sub
    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        Dim OK As Boolean = objCONSULTAS.Grabar(txt_nro_doc.Text, DateTimePicker2.Value.ToShortDateString, txt_observaciones.Text, TextBox1.Text, TextBox2.Text)
        If OK = True Then
            Dim timeIncubation_End_Time As Date
            timeIncubation_End_Time = Now.AddSeconds(5)
            Me.Enabled = False
            Exito.Show()

            Do While Exito.Visible And timeIncubation_End_Time > Now
                Application.DoEvents()
                Threading.Thread.Sleep(100)
            Loop
            Exito.Close()
            Me.Enabled = True
        Else
            Dim timeIncubation_End_Time As Date
            timeIncubation_End_Time = Now.AddSeconds(5)
            Me.Enabled = False
            ErrorForm.Show()

            Do While ErrorForm.Visible And timeIncubation_End_Time > Now
                Application.DoEvents()
                Threading.Thread.Sleep(100)
            Loop
            ErrorForm.Close()
            Me.Enabled = True
        End If
    End Sub
    Private Sub Consulta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
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

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        drag = False
    End Sub
End Class