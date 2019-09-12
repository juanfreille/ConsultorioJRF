Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Principal.Visible = False
        If ProgressBar1.Value = 100 Then
            Principal.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
        If ProgressBar1.Value = 10 Then
            BASEDEDATOS.Visible = True
        End If
        If ProgressBar1.Value = 40 Then
            tablas.Visible = True
        End If
        If ProgressBar1.Value = 70 Then
            interfaz.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
