Public Class BlurForm
    Public Property Padre As Form
    Public Property Hijo As Form

    Public Sub New(ByVal parent As Form, ByVal child As Form)
        InitializeComponent()
        Me.Hijo = child
        Me.Padre = parent
        Me.FormBorderStyle = FormBorderStyle.None
        Me.ShowInTaskbar = False
        Me.Width = Padre.Width
        Me.Height = Padre.Height
        Me.Top = Padre.Top
        Me.Left = Padre.Left
        Me.StartPosition = Padre.StartPosition
        Me.Opacity = 0.5
    End Sub

    Private Sub BlurForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Hijo.Show()
        Hijo.TopMost = True
        Hijo.Focus()
        Hijo.BringToFront()
    End Sub


End Class