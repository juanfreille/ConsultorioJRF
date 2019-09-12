Public Class ErrorForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ErrorForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub ErrorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '        SendKeys.Send("%")
        '       Me.Refresh()
        '      SendKeys.Send("%")
    End Sub

    Private Sub ErrorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TransparencyKey = Color.FromArgb(255, 220, 33, 55)
    End Sub
End Class