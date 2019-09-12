Public Class LabelEx
    Inherits Label

    Private _OutlineColor As Color = Color.Black

    Public Sub New()
        MyBase.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Public Property OutlineColor() As Color
        Get
            Return _OutlineColor
        End Get
        Set(ByVal value As Color)
            _OutlineColor = value
            Me.Refresh()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        With e.Graphics
            .FillRectangle(New SolidBrush(Me.BackColor), New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height))
            .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Using pth As New Drawing2D.GraphicsPath
                Using sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    pth.AddString(Me.Text, Me.Font.FontFamily, Me.Font.Style, ((.DpiY * Me.Font.Size) / 72), New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height), sf)
                End Using
                .FillPath(New SolidBrush(Me.ForeColor), pth)
                If Not Me.OutlineColor = Color.Transparent Then .DrawPath(New Pen(Me.OutlineColor), pth)
            End Using
        End With
    End Sub
End Class
