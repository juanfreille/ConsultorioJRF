Imports System.Data.OleDb
Public Class Consultas
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Observaciones"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("Dni")
        VEC(1) = TABLA.Columns("Fecha")
        TABLA.PrimaryKey = VEC
    End Sub
    Private Sub Actualizar()
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
    Public Function Buscar(DNI As Long, FECHA As String) As Array
        Dim DATOS(2) As String
        Dim VEC(1) As String
        VEC(0) = DNI
        VEC(1) = FECHA

        Dim FILA As DataRow = TABLA.Rows.Find(VEC)

        If FILA IsNot Nothing Then
            If FILA(TABLA.Columns("Observaciones")) IsNot DBNull.Value Then
                DATOS(0) = FILA(TABLA.Columns("Observaciones"))
            End If
            If FILA(TABLA.Columns("Antecedentes")) IsNot DBNull.Value Then
                DATOS(1) = FILA(TABLA.Columns("Antecedentes"))
            End If
            If FILA(TABLA.Columns("Diagnostico")) IsNot DBNull.Value Then
                DATOS(2) = FILA(TABLA.Columns("Diagnostico"))
            End If
        Else
            DATOS = Nothing
        End If
        Return DATOS
    End Function
    Public Function Obtener()
        Return TABLA
    End Function
    Public Function Grabar(DNI As Long, FECHA As String, OBSERVACIONES As String, ANTECEDENTES As String, DIAGNOSTICO As String) As Boolean
        Dim OK As Boolean = False

        Dim DATOS(2) As String
        Dim VEC(1) As String
        VEC(0) = DNI
        VEC(1) = FECHA

        Dim FILA As DataRow = TABLA.Rows.Find(VEC)

        If FILA Is Nothing Then
            FILA = TABLA.NewRow
            FILA("Dni") = DNI
            FILA("Fecha") = FECHA
            FILA("Observaciones") = OBSERVACIONES
            FILA("Antecedentes") = ANTECEDENTES
            FILA("Diagnostico") = DIAGNOSTICO
            TABLA.Rows.Add(FILA)
            Actualizar()
            OK = True
        End If
        Return OK
    End Function
End Class
