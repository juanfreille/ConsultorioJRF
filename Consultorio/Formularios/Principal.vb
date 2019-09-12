Public Class Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        '        For Each control As Control In Me.Controls
        '       If (control.GetType() Is GetType(Panel)) Then
        '      Else
        '     Dim client As MdiClient = CType(control, MdiClient)
        '    If Not (client Is Nothing) Then
        '   If OSCURO = True Then
        '  client.BackColor = Color.DimGray
        ' Else
        'client.BackColor = Color.White
        'Exit For
        'End If
        'End If
        'End If
        'Next
        MaximizeWindow()
        '        MenuStrip1.Renderer = New MyRenderer
        If SEGURIDAD = True Then
            Login.ShowDialog()
        End If
        SkinEngine1.Active = False
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
    Private Sub MaximizeWindow()
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Dim rectangle = Screen.FromControl(Me).Bounds
        Me.FormBorderStyle = FormBorderStyle.None
        Size = New Size(rectangle.Width, rectangle.Height)
        Location = New Point(0, 0)
        Dim workingRectangle As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Size = New Size(workingRectangle.Width, workingRectangle.Height)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CerrarPrograma()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip1.Show("Minimizar", Button2, New Point(0, 33), 3000)
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.Show("Salir", Button1, New Point(0, 33), 3000)
    End Sub

    Private Sub ExplorarFicheroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplorarFicheroToolStripMenuItem.Click
        Dim form As New Fichero
        form.MdiParent = Me
        form.Show()
    End Sub
    Private Sub UltimasConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UltimasConsultasToolStripMenuItem.Click
        Dim child1 As New Imprimir
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub NuevoTurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTurnoToolStripMenuItem.Click
        Dim child1 As New Turnos
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
        '        Dim form As New Turnos
        '       Form.MdiParent = Me
        '      Form.Show()
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Dim form As New Agenda
        form.MdiParent = Me
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub NuevoPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPacienteToolStripMenuItem.Click
        Dim child1 As New Pacientes
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub VerTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTurnosToolStripMenuItem.Click
        Dim child1 As New VerTurnos
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub
    Private Sub HistoriaClínicaDePacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriaClínicaDePacienteToolStripMenuItem.Click
        Dim child1 As New Historia
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub DatosDeConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeConsultaToolStripMenuItem.Click
        Dim child1 As New Consulta
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        SkinEngine1.Active = False
        SKIN = "NORMAL"
        Panel1.BackColor = Color.SlateGray
        Me.Refresh()
    End Sub

    Private Sub OscuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OscuroToolStripMenuItem.Click
        SkinEngine1.Active = True
        SkinEngine1.SkinFile = "Skins/WarmColorME.ssk"
        SKIN = "OSCURO"
        Panel1.BackColor = Color.FromArgb(47, 79, 79)
        Me.Refresh()
    End Sub
    Private Sub EigteenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EigteenToolStripMenuItem.Click
        SkinEngine1.Active = True
        SkinEngine1.SkinFile = "Skins/EighteenColor2.ssk"
        SKIN = "MARRON"
        Panel1.BackColor = Color.FromArgb(65, 59, 59)
        Me.Refresh()
    End Sub

    Private Sub Page1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page1ToolStripMenuItem.Click
        SkinEngine1.Active = True
        SkinEngine1.SkinFile = "Skins/PageColor1.ssk"
        SKIN = "GREEN"
        Panel1.BackColor = Color.FromArgb(131, 174, 164)
        Me.Refresh()
    End Sub

    Private Sub CerrarPrograma()
        With Salir
            .ShowDialog()
        End With
        'Dim child1 As New Salir
        'Dim form2 As BlurForm = New BlurForm(Me, child1)
        'child1.OverLay = form2
        'form2.ShowDialog(Me)
    End Sub

    Private Sub GráficosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GráficosToolStripMenuItem.Click
        Dim form As New Estadisticas
        form.MdiParent = Me
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const WS_MINIMIZEBOX As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or WS_MINIMIZEBOX
            Return cp
        End Get
    End Property

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        CerrarPrograma()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoEditar.Click
        Dim child1 As New Pacientes
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim form As New Fichero
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles NuevoTurno.Click
        Dim child1 As New Turnos
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)
        Dim form As New Fichero
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles Consulta.Click
        Dim child1 As New Consulta
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles Agenda.Click
        Dim form As New Agenda
        form.MdiParent = Me
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Estadisticas.Click
        Dim form As New Estadisticas
        form.MdiParent = Me
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim child1 As New Imprimir
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SalirTS.Click
        CerrarPrograma()
    End Sub

    Private Sub SeguridadToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SeguridadToolStripMenuItem.DropDownItemClicked
        If ToolStripComboBox1.SelectedIndex = 0 Then
            SEGURIDAD = True
        Else
            SEGURIDAD = False
        End If

    End Sub

    Private Sub VerTurnos_Click(sender As Object, e As EventArgs) Handles VerTurnos.Click
        Dim child1 As New VerTurnos
        Dim form2 As BlurForm = New BlurForm(Me, child1)
        child1.OverLay = form2
        form2.ShowDialog(Me)
    End Sub

    Private Sub SeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguridadToolStripMenuItem.Click
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.CopyFile("Consultorio.mdb", Nothing)
        End If
    End Sub

    Private Sub VersiónAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiónAppToolStripMenuItem.Click
        Dim form As New Version
        '        form.MdiParent = Me
        '      Form.Show()

        Dim timeIncubation_End_Time As Date
        timeIncubation_End_Time = Now.AddSeconds(2)
        '        Me.Enabled = False
        form.Show()

        Do While form.Visible And timeIncubation_End_Time > Now
            Application.DoEvents()
            Threading.Thread.Sleep(100)
        Loop
        form.Close()
        '        Me.Enabled = True

    End Sub
End Class
