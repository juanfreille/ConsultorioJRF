Public Class NewUser
    Public Property OverLay As BlurForm

    Dim objUSUARIOS As New Usuarios
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGAR()
        txtNombre.Enabled = True
        txtContraseña.Enabled = True
        txtRepetir.Enabled = True

    End Sub

    Public Sub CARGAR()
        cmbUsuariosNew.Items.Clear()
        For Each FILA As DataRow In objUSUARIOS.TABLA.Rows
            cmbUsuariosNew.Items.Add(FILA(objUSUARIOS.TABLA.Columns("Usuario")))
        Next
        cmbUsuariosNew.SelectedIndex = 0
    End Sub
    Public Sub CARGAR2()
        Login.cmbUsuarios.Items.Clear()
        For Each FILA As DataRow In objUSUARIOS.TABLA.Rows
            Login.cmbUsuarios.Items.Add(FILA(objUSUARIOS.TABLA.Columns("Usuario")))
        Next
        Login.cmbUsuarios.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bGrabar.Click
        Dim OK As Boolean = objUSUARIOS.Grabar(txtNombre.Text, txtContraseña.Text)
        If OK = False Then
            MessageBox.Show("EL USUARIO YA EXISTE ...", "ERROR")
        Else
            txtNombre.Text = ""
            txtContraseña.Text = ""
            txtRepetir.Text = ""
            txtNombre.Focus()
        End If
        CARGAR()
        Login.cmbUsuarios.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bAtras.Click
        Me.Hide()
        CARGAR2()
        Login.Show()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        objUSUARIOS.Eliminar(cmbUsuariosNew.SelectedItem)
        CARGAR()
        Login.cmbUsuarios.Refresh()
    End Sub

    Private Sub NewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        If e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("El programa se cerrará", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Application.ExitThread()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class