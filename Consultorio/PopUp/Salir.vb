Imports Consultorio

Public Class Salir
    Public Property OverLay As BlurForm

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.ExitThread()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Salir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SendKeys.Send("%")
        Select Case SKIN
            Case "NORMAL"
                MyPanel1.BackColor = Color.SlateGray
                MyPanel2.BackColor = Color.SlateGray
                MyPanel3.BackColor = Color.White
                Button7.BackColor = Color.SlateGray
                Button8.BackColor = Color.SlateGray
            Case "OSCURO"
                MyPanel1.BackColor = Color.FromArgb(47, 79, 79)
                MyPanel2.BackColor = Color.FromArgb(47, 79, 79)
                MyPanel3.BackColor = Color.FromArgb(69, 65, 64)
                Button7.BackColor = Color.FromArgb(47, 79, 79)
                Button8.BackColor = Color.FromArgb(47, 79, 79)
            Case "GREEN"
                MyPanel1.BackColor = Color.FromArgb(131, 174, 164)
                MyPanel2.BackColor = Color.FromArgb(131, 174, 164)
                MyPanel3.BackColor = Color.White
                Button7.BackColor = Color.FromArgb(131, 174, 164)
                Button8.BackColor = Color.FromArgb(131, 174, 164)
            Case "MARRON"
                MyPanel1.BackColor = Color.FromArgb(65, 59, 59)
                MyPanel2.BackColor = Color.FromArgb(65, 59, 59)
                MyPanel3.BackColor = Color.White
                Button7.BackColor = Color.FromArgb(65, 59, 59)
                Button8.BackColor = Color.FromArgb(65, 59, 59)
        End Select

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Salir_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SendKeys.Send("%")
        Me.Refresh()
        SendKeys.Send("%")
    End Sub

    Private Sub Salir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '        Me.OverLay.Close()
    End Sub
End Class