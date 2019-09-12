Public Class Advertencia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bSi.Click
        ELIMINAR = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bNo.Click
        ELIMINAR = False
        Close()
    End Sub

    Private Sub Advertencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.FromArgb(255, 220, 33, 55)
    End Sub

    Private Sub Advertencia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SendKeys.Send("%")
        Me.Refresh()
        SendKeys.Send("%")
    End Sub
End Class