Imports Consultorio

Public Class Historia
    Public Structure AUXILIAR
        Dim DNI As String
        Dim FECHAS As Date
        Dim OBSERVACIONES As String
        Dim ANTECEDETNES As String
        Dim DIAGNOTICO As String
    End Structure

    Dim T_PACIENTES As New DataTable
    Dim T_CONSULTAS As New DataTable
    Dim objPACIENTES As New Paciente
    Dim objCONSULTAS As New Consultas
    Dim POS As Integer = 0
    Dim VECTOR As AUXILIAR()
    Public Property OverLay As BlurForm

    Private Sub Historia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Ordenar()
        If DATOUNICOABUSCAR IsNot Nothing Then
            txt_nro_doc.Text = DATOUNICOABUSCAR
            bBuscar.PerformClick()
        End If
        '        Width = MdiParent.Width * 0.8
        '       Height = MdiParent.Height * 0.8
        '      CenterForm(Me, MdiParent)
        Select Case SKIN
            Case "NORMAL"
                Panel1.BackColor = Color.SlateGray
            Case "OSCURO"
                Panel1.BackColor = Color.FromArgb(47, 79, 79)
            Case "GREEN"
                Panel1.BackColor = Color.FromArgb(131, 174, 164)
            Case "MARRON"
                Panel1.BackColor = Color.FromArgb(65, 59, 59)
        End Select
    End Sub
    Private Sub Ordenar()
        VECTOR = VECTOR.OrderBy(Function(c) c.FECHAS).ToArray
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        DataGridView1.Rows.Clear()
        POS = 0
        Do While POS < UBound(VECTOR) + 1
            If txt_nro_doc.Text = "" Then
            Else
                If txt_nro_doc.Text <> "" And txt_nro_doc.Text = VECTOR(POS).DNI Then
                    Dim Paciente(12) As String
                    Paciente = objPACIENTES.Buscar(txt_nro_doc.Text)
                    Label1.Text = Paciente(0) & ", " & Paciente(1)
                    DataGridView1.Rows.Add(VECTOR(POS).FECHAS.ToShortDateString, VECTOR(POS).OBSERVACIONES, VECTOR(POS).ANTECEDETNES, VECTOR(POS).DIAGNOTICO)
                    Exit Do
                End If
            End If
            POS = POS + 1
        Loop
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        RichTextBox1.Clear()

        RichTextBox1.SelectionColor = Color.Green
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold + FontStyle.Underline)
        RichTextBox1.AppendText("Observaciones")

        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText(DataGridView1.CurrentRow.Cells(1).Value)

        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.SelectionColor = Color.Green
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold + FontStyle.Underline)
        RichTextBox1.AppendText("Antecedentes")

        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText(DataGridView1.CurrentRow.Cells(2).Value)

        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.SelectionColor = Color.Green
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold + FontStyle.Underline)
        RichTextBox1.AppendText("Diagnóstico")

        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
        RichTextBox1.AppendText(DataGridView1.CurrentRow.Cells(3).Value)
    End Sub


    Private Sub Historia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
        DATOUNICOABUSCAR = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        drag = False
    End Sub
End Class