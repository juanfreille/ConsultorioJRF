Public Class FeriadoPop
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bSi.Click
        HABILITARFERIADO = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bNo.Click
        HABILITARFERIADO = False
        Close()
    End Sub

    Private Sub FeriadoPop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.FromArgb(255, 220, 33, 55)
    End Sub

    Private Sub FeriadoPop_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SendKeys.Send("%")
        Me.Refresh()
        SendKeys.Send("%")
    End Sub
End Class