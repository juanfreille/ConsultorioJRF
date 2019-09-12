Imports System.Data.OleDb

Public Class Login
    Public Property OverLay As BlurForm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Public Sub New()
        InitializeComponent()
        Me.AcceptButton = cmdIngresar
    End Sub

    Dim objUSUARIOS As New Usuarios

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGAR()
    End Sub

    Public Sub CARGAR()
        cmdIngresar.Enabled = False
        cmbUsuarios.Items.Clear()
        For Each FILA As DataRow In objUSUARIOS.TABLA.Rows
            cmbUsuarios.Items.Add(FILA(objUSUARIOS.TABLA.Columns("Usuario")))
        Next
        cmbUsuarios.SelectedIndex = 0
    End Sub
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim CLAVE = txtContraseña.Text
        Dim UsuarioCorrecto As Boolean

        For Each FILA As DataRow In objUSUARIOS.TABLA.Rows
            If FILA(objUSUARIOS.TABLA.Columns("Contraseña")) = CLAVE And cmbUsuarios.SelectedItem = FILA(objUSUARIOS.TABLA.Columns("Usuario")) Then
                UsuarioCorrecto = True
                Principal.Show()
                Exit For
            Else
                UsuarioCorrecto = False
            End If
        Next
        If UsuarioCorrecto = False Then
            MessageBox.Show("INCORRECTOOOO ...", "ERROR")
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub Validar()
        If txtContraseña.Text = Nothing Or cmbUsuarios.SelectedIndex = -1 Then
            cmdIngresar.Enabled = False
        Else
            cmdIngresar.Enabled = True
        End If
    End Sub
    Private Sub cmdNuevoUser_Click(sender As Object, e As EventArgs) Handles cmdNuevoUser.Click
        If Not (MdiChildren.Count >= 1) Then
            '            MasterKey.MdiParent = Principal
            Me.Visible = False
            MasterKey.ShowDialog()
        End If
    End Sub
    Private Sub cmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedIndexChanged
        Validar()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        Validar()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        '        If e.CloseReason = CloseReason.UserClosing Then
        '       If MessageBox.Show("El programa se cerrará", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
        Application.ExitThread()
        '     Else
        '    e.Cancel = True
        '   End If
        '  End If
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
