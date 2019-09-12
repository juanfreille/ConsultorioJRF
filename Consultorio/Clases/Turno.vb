Imports System.Data.OleDb
Public Class Turno
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Turnos"
        ADAPTADOR.Fill(TABLA)
        Dim VEC(3) As DataColumn
        VEC(0) = TABLA.Columns("matricula")
        VEC(1) = TABLA.Columns("fecha")
        VEC(2) = TABLA.Columns("hora")
        TABLA.PrimaryKey = VEC
    End Sub
    Public Function Grabar(MATRICULA As Long, FECHA As String, HORA As String, APELLIDO As String, NOMBRE As String, OBSERVACIONES As String) As Boolean
        'Creamos un booleano ok para devolver
        Dim OK As Boolean = False
        'Creamos un vector con 3 datos para busacarlos en la tabla
        Dim VEC(2) As String
        VEC(0) = MATRICULA
        VEC(1) = FECHA
        VEC(2) = HORA

        'Nos posicionamos donde corresponde y agregamos la nueva fila con los datos que le enviamos desde el formulario
        Dim FILA As DataRow = TABLA.Rows.Find(VEC)
        FILA = TABLA.NewRow
        FILA("matricula") = MATRICULA
        FILA("fecha") = FECHA
        FILA("hora") = HORA
        FILA("Apellido") = APELLIDO
        FILA("Nombre") = NOMBRE
        FILA("Observaciones") = OBSERVACIONES
        TABLA.Rows.Add(FILA)
        Actualizar()
        OK = True
        Return OK
    End Function

    Private Sub Actualizar()
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
    Public Function Buscar(MATRICULA As Long, FECHA As String, HORA As String) As String
        'Creamos un vector con los 3 datos para recorrerlos por la fila de la tabla
        Dim VEC(2) As String

        VEC(0) = MATRICULA
        VEC(1) = FECHA
        VEC(2) = HORA

        Dim FILA As DataRow = TABLA.Rows.Find(VEC)

        'Si la fila se encuentra entonces devuelve la hora del turno, de lo contrario devuelve "nothing" en la hora
        If FILA IsNot Nothing Then
            HORA = FILA(TABLA.Columns("hora"))
        Else
            HORA = Nothing
        End If

        Return HORA

    End Function

    Public Function Nombre(MATRICULA As Long, FECHA As String, HORA As String) As Array
        Dim VEC(2) As String
        Dim DATOS(5) As String

        VEC(0) = MATRICULA
        VEC(1) = FECHA
        VEC(2) = HORA

        Dim FILA As DataRow = TABLA.Rows.Find(VEC)

        If FILA IsNot Nothing Then
            DATOS(0) = FILA(TABLA.Columns("fecha"))
            DATOS(1) = FILA(TABLA.Columns("hora"))
            DATOS(2) = FILA(TABLA.Columns("Apellido"))
            DATOS(3) = FILA(TABLA.Columns("Nombre"))
            DATOS(4) = FILA(TABLA.Columns("Observaciones"))
        Else
            DATOS = Nothing
        End If
        Return DATOS
    End Function
    Public Sub Eliminar(MATRICULA As Long, FECHA As String, HORA As String)
        Dim DATOS(2) As String
        'Guardar la posición y valor de la celda
        DATOS(0) = MATRICULA
        DATOS(1) = FECHA
        DATOS(2) = HORA

        Dim FILA As DataRow = TABLA.Rows.Find(DATOS)
        If Not FILA Is Nothing Then
            FILA.Delete()
            Actualizar()
        End If
    End Sub
    Public Function Obtener()
        Return TABLA
    End Function

End Class
