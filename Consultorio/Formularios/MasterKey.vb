Public Class MasterKey
    Public Property OverLay As BlurForm
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If txtClave.Text = "galita2013" Then
            Me.Close()
        Else
            MessageBox.Show("La clave ingresada es incorrecta", "ERROR")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Visible = True
    End Sub

    Private Sub MasterKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        If txtClave.Text = "galita2013" Then
            Me.Visible = False
            NewUser.ShowDialog()
        Else
            '            If e.CloseReason = CloseReason.UserClosing Then
            '            If MessageBox.Show("El programa se cerrará", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            '           Application.ExitThread()
            '          Else
            '         e.Cancel = True
            '    End If
            '           End If

        End If
    End Sub

    Private Sub MasterKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class