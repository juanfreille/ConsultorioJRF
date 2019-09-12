Imports System.Configuration

Module Module1
    Public DATOUNICOABUSCAR As String
    Public VERTURNITOS As Boolean
    Public AGREGARTURNITOS As Boolean
    Public ayuda As String
    Public SKIN As String
    Public ELIMINAR As Boolean
    Public ESFERIADO As Boolean
    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer
    Public HABILITARFERIADO As Boolean
    Public SEGURIDAD As Boolean

    Public Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = (r.Top + (r.Height - frm.Height) \ 2)
        frm.Location = New Point(x, y)
    End Sub

End Module

