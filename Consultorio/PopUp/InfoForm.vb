Public Class InfoForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub InfoForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.FromArgb(255, 220, 33, 55)
    End Sub

End Class