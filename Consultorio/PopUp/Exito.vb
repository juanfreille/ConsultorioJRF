Public Class Exito
    Public Property OverLay As BlurForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Exito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub Exito_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    End Sub

    Private Sub Exito_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TransparencyKey = Color.FromArgb(255, 220, 33, 55)
    End Sub
End Class