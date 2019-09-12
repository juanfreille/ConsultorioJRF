Imports System.Windows.Forms.DataVisualization.Charting
Imports Consultorio

Public Class Estadisticas
    Dim T_PACIENTES As New DataTable
    Dim TABLA_ORDENADA As New DataTable
    Dim objPACIENTES As New Paciente
    Dim seleccionados As Integer = 0
    Public Property OverLay As BlurForm

    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_PACIENTES = objPACIENTES.Obtener()
        Acomodar()
        Width = Principal.Width * 0.8
        Height = Principal.Height * 0.8
        CenterForm(Me, MdiParent)
        Top = Top + 20
        ComboBox1.SelectedIndex = 0
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
    Sub Acomodar()
        TABLA_ORDENADA.Clear()
        Dim dra() As DataRow = T_PACIENTES.Select("", "Apellido asc")
        If (dra.Length > 0) Then
            TABLA_ORDENADA = dra.CopyToDataTable
        End If
    End Sub
    Private Sub bGraficar_Click(sender As Object, e As EventArgs) Handles bGraficar.Click
        CHA.ResetAutoValues()

        If ComboBox1.SelectedIndex = 0 Then
            'ACA VA POR NUMEROS
            For Each fila As ListViewItem In LV.CheckedItems
                seleccionados = seleccionados + 1
            Next
            If seleccionados = 0 Then
                With InfoForm
                    .Label2.Text = "Seleccione al menos una categoría."
                End With
                InfoForm.ShowDialog()
            Else
                Dim CONTADOR_PARTICULAR, CONTADOR_AFJP, CONTADOR_APROSS, CONTADOR_LAVORIS, CONTADOR_SVDYR, CONTADOR_PROFE, CONTADOR_ARGNUEVA As Long

                For Each FILA As DataRow In TABLA_ORDENADA.Rows
                    Select Case FILA(TABLA_ORDENADA.Columns("ObraSocial"))
                        Case "PARTICULAR"
                            CONTADOR_PARTICULAR = CONTADOR_PARTICULAR + 1
                        Case "AFJP"
                            CONTADOR_AFJP = CONTADOR_AFJP + 1
                        Case "APROSS"
                            CONTADOR_APROSS = CONTADOR_APROSS + 1
                        Case "LAVORIS"
                            CONTADOR_LAVORIS = CONTADOR_LAVORIS + 1
                        Case "SVDYR"
                            CONTADOR_SVDYR = CONTADOR_SVDYR + 1
                        Case "PROFE"
                            CONTADOR_PROFE = CONTADOR_PROFE + 1
                        Case "ARG NUEVA"
                            CONTADOR_ARGNUEVA = CONTADOR_ARGNUEVA + 1
                    End Select
                Next

                Dim TOTAL As Long = CONTADOR_PARTICULAR + CONTADOR_AFJP + CONTADOR_APROSS + CONTADOR_LAVORIS + CONTADOR_SVDYR + CONTADOR_PROFE + CONTADOR_ARGNUEVA

                Dim PARTICULAR, AFJP, APROSS, LAVORIS, SVDYR, PROFE, ARGNUEVA As Series
                CHA.Series.Clear()

                For Each fila As ListViewItem In LV.CheckedItems
                    If fila.Text = "PARTICULAR" Then
                        PARTICULAR = CHA.Series.Add("PARTICULAR")
                        CHA.Series("PARTICULAR").Points.AddXY(0.9, CONTADOR_PARTICULAR)
                    End If

                    If fila.Text = "AFJP" Then
                        AFJP = CHA.Series.Add("AFJP")
                        CHA.Series("AFJP").Points.AddXY(1.0, CONTADOR_AFJP)
                    End If

                    If fila.Text = "APROSS" Then
                        APROSS = CHA.Series.Add("APROSS")
                        CHA.Series("APROSS").Points.AddXY(1.1, CONTADOR_APROSS)
                    End If

                    If fila.Text = "LAVORIS" Then
                        LAVORIS = CHA.Series.Add("LAVORIS")
                        CHA.Series("LAVORIS").Points.AddXY(1.2, CONTADOR_LAVORIS)
                    End If

                    If fila.Text = "SVDYR" Then
                        SVDYR = CHA.Series.Add("SVDYR")
                        CHA.Series("SVDYR").Points.AddXY(1.3, CONTADOR_SVDYR)
                    End If

                    If fila.Text = "PROFE" Then
                        PROFE = CHA.Series.Add("PROFE")
                        CHA.Series("PROFE").Points.AddXY(1.4, CONTADOR_PROFE)
                    End If

                    If fila.Text = "ARGNUEVA" Then
                        ARGNUEVA = CHA.Series.Add("ARGNUEVA")
                        CHA.Series("ARGNUEVA").Points.AddXY(1.5, CONTADOR_ARGNUEVA)
                    End If
                Next
                Dim I As Integer = 0
                For Each SERIE As Series In CHA.Series
                    SERIE.IsValueShownAsLabel = True
                    SERIE("LabelStyle") = "bottom"
                    SERIE.LabelForeColor = Color.White
                    SERIE.LabelFormat = "{0}"
                    CHA.Series(I)("PointWidth") = "1.5"
                    I = I + 1
                Next

                If CHA.Series.Count = 1 Then
                    CHA.Series(0)("PointWidth") = "0.5"
                End If
                If CHA.Series.Count = 2 Then
                    CHA.Series(0)("PointWidth") = "1"
                    CHA.Series(1)("PointWidth") = "1"
                End If
                CHA.Titles.Clear()
                Dim TITULO As Title
                TITULO = CHA.Titles.Add("PACIENTES POR OBRA SOCIAL (CANTIDAD)")
                TITULO.Font = New Font("TAHOMA", 12, FontStyle.Bold)

                Dim TITULO2 As Title
                TITULO2 = CHA.Titles.Add("TOTAL DE PACIENTES: " & TOTAL)

                seleccionados = 0
            End If
        Else

            'ACA VA POR PORCENTAJE
            For Each fila As ListViewItem In LV.CheckedItems
                seleccionados = seleccionados + 1
            Next
            If seleccionados = 0 Then
                With InfoForm
                    .Label2.Text = "Seleccione al menos una categoría."
                End With
                InfoForm.ShowDialog()
            Else
                Dim CONTADOR_PARTICULAR, CONTADOR_AFJP, CONTADOR_APROSS, CONTADOR_LAVORIS, CONTADOR_SVDYR, CONTADOR_PROFE, CONTADOR_ARGNUEVA As Long

                For Each FILA As DataRow In TABLA_ORDENADA.Rows
                    Select Case FILA(TABLA_ORDENADA.Columns("ObraSocial"))
                        Case "PARTICULAR"
                            CONTADOR_PARTICULAR = CONTADOR_PARTICULAR + 1
                        Case "AFJP"
                            CONTADOR_AFJP = CONTADOR_AFJP + 1
                        Case "APROSS"
                            CONTADOR_APROSS = CONTADOR_APROSS + 1
                        Case "LAVORIS"
                            CONTADOR_LAVORIS = CONTADOR_LAVORIS + 1
                        Case "SVDYR"
                            CONTADOR_SVDYR = CONTADOR_SVDYR + 1
                        Case "PROFE"
                            CONTADOR_PROFE = CONTADOR_PROFE + 1
                        Case "ARG NUEVA"
                            CONTADOR_ARGNUEVA = CONTADOR_ARGNUEVA + 1
                    End Select
                Next

                Dim TOTAL As Long = CONTADOR_PARTICULAR + CONTADOR_AFJP + CONTADOR_APROSS + CONTADOR_LAVORIS + CONTADOR_SVDYR + CONTADOR_PROFE + CONTADOR_ARGNUEVA

                Dim PARTICULAR, AFJP, APROSS, LAVORIS, SVDYR, PROFE, ARGNUEVA As Series
                CHA.Series.Clear()

                For Each fila As ListViewItem In LV.CheckedItems
                    If fila.Text = "PARTICULAR" Then
                        PARTICULAR = CHA.Series.Add("PARTICULAR")
                        CHA.Series("PARTICULAR").Points.AddXY(0.9, CONTADOR_PARTICULAR * 100 / TOTAL)
                    End If

                    If fila.Text = "AFJP" Then
                        AFJP = CHA.Series.Add("AFJP")
                        CHA.Series("AFJP").Points.AddXY(1.0, CONTADOR_AFJP * 100 / TOTAL)
                    End If

                    If fila.Text = "APROSS" Then
                        APROSS = CHA.Series.Add("APROSS")
                        CHA.Series("APROSS").Points.AddXY(1.1, CONTADOR_APROSS * 100 / TOTAL)
                    End If

                    If fila.Text = "LAVORIS" Then
                        LAVORIS = CHA.Series.Add("LAVORIS")
                        CHA.Series("LAVORIS").Points.AddXY(1.2, CONTADOR_LAVORIS * 100 / TOTAL)
                    End If

                    If fila.Text = "SVDYR" Then
                        SVDYR = CHA.Series.Add("SVDYR")
                        CHA.Series("SVDYR").Points.AddXY(1.3, CONTADOR_SVDYR * 100 / TOTAL)
                    End If

                    If fila.Text = "PROFE" Then
                        PROFE = CHA.Series.Add("PROFE")
                        CHA.Series("PROFE").Points.AddXY(1.4, CONTADOR_PROFE)
                    End If

                    If fila.Text = "ARGNUEVA" Then
                        ARGNUEVA = CHA.Series.Add("ARGNUEVA")
                        CHA.Series("ARGNUEVA").Points.AddXY(1.5, CONTADOR_ARGNUEVA)
                    End If
                Next
                Dim I As Integer = 0
                For Each SERIE As Series In CHA.Series
                    SERIE.IsValueShownAsLabel = True
                    SERIE("LabelStyle") = "bottom"
                    SERIE.LabelForeColor = Color.White
                    SERIE.LabelFormat = "{0.0}%"
                    CHA.Series(I)("PointWidth") = "1.5"
                    I = I + 1
                Next

                If CHA.Series.Count = 1 Then
                    CHA.Series(0)("PointWidth") = "0.5"
                End If
                If CHA.Series.Count = 2 Then
                    CHA.Series(0)("PointWidth") = "1"
                    CHA.Series(1)("PointWidth") = "1"
                End If
                CHA.Titles.Clear()
                Dim TITULO As Title
                TITULO = CHA.Titles.Add("PACIENTES POR OBRA SOCIAL (PORCENTAJE)")
                TITULO.Font = New Font("TAHOMA", 12, FontStyle.Bold)
                Dim TITULO2 As Title
                TITULO2 = CHA.Titles.Add("TOTAL DE PACIENTES: " & TOTAL)
                seleccionados = 0
            End If
        End If
    End Sub

    Private Sub Estadisticas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.OverLay IsNot Nothing Then
            Me.OverLay.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class