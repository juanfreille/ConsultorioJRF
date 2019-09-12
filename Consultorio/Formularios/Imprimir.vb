Public Class Imprimir

    Public Structure AUXILIAR
        Dim DNI As String
        Dim FECHAS As Date
        Dim OBSERVACIONES As String
        Dim ANTECEDETNES As String
        Dim DIAGNOTICO As String
    End Structure

    Dim T_PACIENTES As New DataTable
    Dim objPACIENTES As New Paciente
    Dim T_CONSULTAS As New DataTable
    Dim objCONSULTAS As New Consultas
    Dim POS As Integer = 0
    Dim POS2 As Integer = 0
    Private mPageNumber As Integer = 1
    Private mPageNumber2 As Integer = 1
    Dim VECTOR As AUXILIAR()
    Dim Paciente(12) As String
    Public Property OverLay As BlurForm

    Private Sub Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_PACIENTES = objPACIENTES.Obtener()
        T_CONSULTAS = objCONSULTAS.Obtener()
        Dim I As Integer = 0

        For Each FILA As DataRow In T_CONSULTAS.Rows
            ReDim Preserve VECTOR(I)
            VECTOR(I).DNI = FILA("Dni")
            VECTOR(I).FECHAS = FILA("Fecha")
            VECTOR(I).OBSERVACIONES = FILA("Observaciones")
            VECTOR(I).ANTECEDETNES = FILA("Antecedentes")
            VECTOR(I).DIAGNOTICO = FILA("Diagnostico")
            I = I + 1
        Next
        VECTOR = VECTOR.OrderBy(Function(c) c.FECHAS).ToArray
        If DATOUNICOABUSCAR IsNot Nothing Then
            txt_nro_doc.Text = DATOUNICOABUSCAR
            bBuscar.PerformClick()
        End If

        Select Case SKIN
            Case "NORMAL"
                Panel1.BackColor = Color.SlateGray
                Label4.ForeColor = Color.Black
                GroupBox1.ForeColor = Color.Black
                bBuscar.BackColor = SystemColors.Control
            Case "OSCURO"
                Panel1.BackColor = Color.FromArgb(47, 79, 79)
                Label4.ForeColor = Color.White
                GroupBox1.ForeColor = Color.White
                bBuscar.BackColor = Color.FromArgb(47, 79, 79)
            Case "GREEN"
                Panel1.BackColor = Color.FromArgb(131, 174, 164)
                Label4.ForeColor = Color.Black
                GroupBox1.ForeColor = Color.Black
                bBuscar.BackColor = SystemColors.Control
            Case "MARRON"
                Panel1.BackColor = Color.FromArgb(65, 59, 59)
                Label4.ForeColor = Color.Black
                GroupBox1.ForeColor = Color.Black
                bBuscar.BackColor = SystemColors.Control
        End Select

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If txt_nro_doc.Text = "" Then
            MessageBox.Show("Debe buscar el DNI del paciente primero", "ERROR")
        Else
            If txt_nro_doc.Text <> "" Then
                Paciente = objPACIENTES.Buscar(txt_nro_doc.Text)
                If Paciente Is Nothing Then
                    MessageBox.Show("La ficha pertenciente al dni de ese paciente no existe", "ERROR")
                Else
                    PrintPreviewControl1.Document = PreparePrintDocument()
                    PrintPreviewControl1.Enabled = True
                    PrintPreviewControl1.StartPage = 1
                    PrintPreviewControl1.InvalidatePreview()
                    AddHandler PREVISUALIZACION.PrintPage, AddressOf PREVISUALIZACION_PrintPage
                End If
            End If
        End If
    End Sub

    Private Function PreparePrintDocument() As Printing.PrintDocument
        Dim PREVISUALIZACION As New Printing.PrintDocument
        AddHandler PREVISUALIZACION.PrintPage, AddressOf PREVISUALIZACION_PrintPage
        Return PREVISUALIZACION
    End Function

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        If txt_nro_doc.Text = "" Then
            MessageBox.Show("Debe buscar el DNI del paciente primero", "ERROR")
        Else
            DirectCast(PPD, Form).WindowState = FormWindowState.Maximized
            PPD.Tag = 9999
            PPD.ShowDialog(Me)
        End If
        mPageNumber = 1
        POS = 0
    End Sub
    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        DOCUMENTO.PrinterSettings.PrinterName = "Microsoft Print To PDF"
        DOCUMENTO.PrinterSettings.PrintFileName = Paciente(0) & ", " & Paciente(1)
        DOCUMENTO.Print()
        mPageNumber2 = 1
        POS2 = 0
    End Sub
    Private Sub DOCUMENTO_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles DOCUMENTO.PrintPage
        Dim F1 As New Font("Arial", 18, FontStyle.Bold)
        Dim F2 As New Font("Arial", 11)
        Dim F3 As New Font("Arial", 11, FontStyle.Bold)
        Dim F4 As New Font("Arial", 12, FontStyle.Bold)
        Dim X As Integer = e.MarginBounds.Left
        Dim X2 As Integer
        Dim Y As Integer = e.MarginBounds.Top
        Dim blackPen As New Pen(Color.Black, 3)
        Dim blackPen2 As New Pen(Color.Black, 1)
        Dim RECTAMAÑO As Integer = e.MarginBounds.Right - e.MarginBounds.Left
        Dim rect As New Rectangle(e.MarginBounds.Left, Y, RECTAMAÑO, 70)
        Dim texto As String
        Dim newImage As Image = My.Resources.LogoOjo


        texto = "CONSULTORIO JORGE RAUL FRANCHELLO"

        e.Graphics.DrawRectangle(blackPen, rect)
        e.Graphics.DrawString(texto, F1, Brushes.Black, X + 90, Y + 20)
        e.Graphics.DrawImage(newImage, X + 5, Y + 2, 70, 70)
        Y = Y + 100
        X2 = X
        If mPageNumber = 1 Then
            e.Graphics.DrawString("Paciente: ", F3, Brushes.Black, X, Y)
            X = X + 85
            e.Graphics.DrawString(Paciente(0) & ", " & Paciente(1), F2, Brushes.Black, X, Y)
            X = X + 180
            e.Graphics.DrawString("Edad: ", F3, Brushes.Black, X, Y)
            X = X + 45
            e.Graphics.DrawString(Paciente(2), F2, Brushes.Black, X, Y)
            X = X + 17
            e.Graphics.DrawString(" años", F2, Brushes.Black, X, Y)
            X = X + 150
            e.Graphics.DrawString("Obra social: ", F3, Brushes.Black, X, Y)
            X = X + 100
            e.Graphics.DrawString(Paciente(8), F2, Brushes.Black, X, Y)

            Y = Y + 50
            e.Graphics.DrawString("Domicilio: ", F3, Brushes.Black, X2, Y)
            X2 = X2 + 85
            e.Graphics.DrawString(Paciente(3) & " " & Paciente(4), F2, Brushes.Black, X2, Y)
            X2 = X2 - 85
            Y = Y + 50
            e.Graphics.DrawString("Teléfono: ", F3, Brushes.Black, X2, Y)
            X2 = X2 + 85
            e.Graphics.DrawString(Paciente(5), F2, Brushes.Black, X2, Y)
            Y = Y + 50
            X2 = X2 - 85
            e.Graphics.DrawString("Dni: ", F3, Brushes.Black, X2, Y)
            X2 = X2 + 85
            e.Graphics.DrawString(Paciente(7), F2, Brushes.Black, X2, Y)
            Y = Y + 50
            X2 = X2 - 85
            If Val(Paciente(9)) <> "0" AndAlso Paciente(9) IsNot Nothing Then
                e.Graphics.DrawString("N° Afiliado: ", F3, Brushes.Black, X2, Y)
                X2 = X2 + 85
                e.Graphics.DrawString(Paciente(9), F2, Brushes.Black, X2, Y)
                Y = Y + 50
                X2 = X2 - 85
                e.Graphics.DrawString("Código: ", F3, Brushes.Black, X2, Y)
                X2 = X2 + 85
                e.Graphics.DrawString(Paciente(10), F2, Brushes.Black, X2, Y)
                X2 = X2 - 85
            End If
            Y = Y + 50
        End If
        Dim banderita As Integer = 0
        Do While POS < UBound(VECTOR) + 1
            If txt_nro_doc.Text = "" Then
            Else
                If txt_nro_doc.Text <> "" And txt_nro_doc.Text = VECTOR(POS).DNI Then
                    If banderita = 0 Then
                        Dim rect3 As New Rectangle(X2, Y - 2, e.MarginBounds.Right - e.MarginBounds.Left, 30)
                        If mPageNumber = 1 Then
                            e.Graphics.DrawRectangle(blackPen, rect3)
                            Dim StringSize As New SizeF
                            StringSize = e.Graphics.MeasureString("CONSULTAS", F4)
                            e.Graphics.DrawString("CONSULTAS", F4, Brushes.Black, (DOCUMENTO.DefaultPageSettings.PaperSize.Width / 2) - StringSize.Width / 2, Y + 3)
                            banderita = banderita + 1
                            Y = Y + 50
                        End If
                    End If
                    e.Graphics.DrawString("Fecha: " & VECTOR(POS).FECHAS, F3, Brushes.Black, X2, Y)
                    Dim rect2 As New Rectangle(X2, Y + 20, e.MarginBounds.Right - e.MarginBounds.Left, 1)
                    e.Graphics.DrawRectangle(blackPen2, rect2)
                    Y = Y + 30
                    e.Graphics.DrawString("Observaciones: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    Dim rectangulo As New System.Drawing.RectangleF(X2, Y, RECTAMAÑO, 85)
                    e.Graphics.DrawString(VECTOR(POS).OBSERVACIONES, F2, Brushes.Black, rectangulo)

                    Y = Y + 50
                    e.Graphics.DrawString("Antecedentes: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    e.Graphics.DrawString(VECTOR(POS).ANTECEDETNES, F2, Brushes.Black, X2, Y)
                    Y = Y + 50
                    e.Graphics.DrawString("Diagnóstico: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    e.Graphics.DrawString(VECTOR(POS).DIAGNOTICO, F2, Brushes.Black, X2, Y)
                    Y = Y + 50
                    If Y > e.MarginBounds.Bottom Then
                        Exit Do
                    End If
                End If
                POS = POS + 1
            End If
        Loop
        If POS < UBound(VECTOR) + 1 Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
        Using f As New Font("Arial", 10)
            e.Graphics.DrawString(mPageNumber.ToString(), F4, Brushes.Black, 0, 0)
        End Using
        mPageNumber += 1

    End Sub

    Private Sub PREVISUALIZACION_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PREVISUALIZACION.PrintPage
        Dim F1 As New Font("Arial", 18, FontStyle.Bold)
        Dim F2 As New Font("Arial", 11)
        Dim F3 As New Font("Arial", 11, FontStyle.Bold)
        Dim F4 As New Font("Arial", 12, FontStyle.Bold)
        Dim X As Integer = e.MarginBounds.Left
        Dim X2 As Integer
        Dim Y As Integer = e.MarginBounds.Top
        Dim blackPen As New Pen(Color.Black, 3)
        Dim blackPen2 As New Pen(Color.Black, 1)
        Dim RECTAMAÑO As Integer = e.MarginBounds.Right - e.MarginBounds.Left
        Dim rect As New Rectangle(e.MarginBounds.Left, Y, RECTAMAÑO, 70)
        Dim texto As String
        Dim newImage As Image = My.Resources.LogoOjo


        texto = "CONSULTORIO JORGE RAUL FRANCHELLO"

        e.Graphics.DrawRectangle(blackPen, rect)
        e.Graphics.DrawString(texto, F1, Brushes.Black, X + 90, Y + 20)
        e.Graphics.DrawImage(newImage, X + 5, Y + 2, 70, 70)
        Y = Y + 100
        X2 = X
        e.Graphics.DrawString("Paciente: ", F3, Brushes.Black, X, Y)
        X = X + 85
        e.Graphics.DrawString(Paciente(0) & ", " & Paciente(1), F2, Brushes.Black, X, Y)
        X = X + 180
        e.Graphics.DrawString("Edad: ", F3, Brushes.Black, X, Y)
        X = X + 45
        e.Graphics.DrawString(Paciente(2), F2, Brushes.Black, X, Y)
        X = X + 17
        e.Graphics.DrawString(" años", F2, Brushes.Black, X, Y)
        X = X + 150
        e.Graphics.DrawString("Obra social: ", F3, Brushes.Black, X, Y)
        X = X + 100
        e.Graphics.DrawString(Paciente(8), F2, Brushes.Black, X, Y)

        Y = Y + 50
        e.Graphics.DrawString("Domicilio: ", F3, Brushes.Black, X2, Y)
        X2 = X2 + 85
        e.Graphics.DrawString(Paciente(3) & " " & Paciente(4), F2, Brushes.Black, X2, Y)
        X2 = X2 - 85
        Y = Y + 50
        e.Graphics.DrawString("Teléfono: ", F3, Brushes.Black, X2, Y)
        X2 = X2 + 85
        e.Graphics.DrawString(Paciente(5), F2, Brushes.Black, X2, Y)
        Y = Y + 50
        X2 = X2 - 85
        e.Graphics.DrawString("Dni: ", F3, Brushes.Black, X2, Y)
        X2 = X2 + 85
        e.Graphics.DrawString(Paciente(7), F2, Brushes.Black, X2, Y)
        Y = Y + 50
        X2 = X2 - 85
        If Val(Paciente(9)) <> "0" AndAlso Paciente(9) IsNot Nothing Then
            e.Graphics.DrawString("N° Afiliado: ", F3, Brushes.Black, X2, Y)
            X2 = X2 + 85
            e.Graphics.DrawString(Paciente(9), F2, Brushes.Black, X2, Y)
            Y = Y + 50
            X2 = X2 - 85
            e.Graphics.DrawString("Código: ", F3, Brushes.Black, X2, Y)
            X2 = X2 + 85
            e.Graphics.DrawString(Paciente(10), F2, Brushes.Black, X2, Y)
            X2 = X2 - 85
        End If
        Y = Y + 50
        Dim banderita As Integer = 0
        Do While POS2 < UBound(VECTOR) + 1
            If txt_nro_doc.Text = "" Then
            Else
                If txt_nro_doc.Text <> "" And txt_nro_doc.Text = VECTOR(POS2).DNI Then
                    If banderita = 0 Then
                        Dim rect3 As New Rectangle(X2, Y - 2, e.MarginBounds.Right - e.MarginBounds.Left, 30)
                        e.Graphics.DrawRectangle(blackPen, rect3)
                        Dim StringSize As New SizeF
                        StringSize = e.Graphics.MeasureString("CONSULTAS", F4)
                        e.Graphics.DrawString("CONSULTAS", F4, Brushes.Black, (DOCUMENTO.DefaultPageSettings.PaperSize.Width / 2) - StringSize.Width / 2, Y + 3)
                        banderita = banderita + 1
                        Y = Y + 50
                    End If
                    e.Graphics.DrawString("Fecha: " & VECTOR(POS2).FECHAS, F3, Brushes.Black, X2, Y)
                    Dim rect2 As New Rectangle(X2, Y + 20, e.MarginBounds.Right - e.MarginBounds.Left, 1)
                    e.Graphics.DrawRectangle(blackPen2, rect2)
                    Y = Y + 30
                    e.Graphics.DrawString("Observaciones: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    Dim rectangulo As New System.Drawing.RectangleF(X2, Y, RECTAMAÑO, 85)
                    e.Graphics.DrawString(VECTOR(POS2).OBSERVACIONES, F2, Brushes.Black, rectangulo)

                    Y = Y + 50
                    e.Graphics.DrawString("Antecedentes: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    e.Graphics.DrawString(VECTOR(POS2).ANTECEDETNES, F2, Brushes.Black, X2, Y)
                    Y = Y + 50
                    e.Graphics.DrawString("Diagnóstico: ", F3, Brushes.Black, X2, Y)
                    Y = Y + 25
                    e.Graphics.DrawString(VECTOR(POS2).DIAGNOTICO, F2, Brushes.Black, X2, Y)
                    Y = Y + 50
                    If Y > e.MarginBounds.Bottom Then
                        Exit Do
                    End If
                End If
                POS2 = POS2 + 1
            End If
        Loop
        Using f As New Font("Arial", 10)
            e.Graphics.DrawString(mPageNumber.ToString(), F4, Brushes.Black, 0, 0)
        End Using
        mPageNumber2 += 1
    End Sub

    Private Sub Imprimir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        DATOUNICOABUSCAR = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub
End Class