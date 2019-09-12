Imports System.Data.OleDb
Public Class Paciente
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Pacientes"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(0) As DataColumn
        VEC(0) = TABLA.Columns("Dni")
        TABLA.PrimaryKey = VEC
    End Sub
    Public Function Grabar(APELLIDO As String, NOMBRE As String, EDAD As Long, DOMICILIO As String, NroCALLE As Long, TELEFONO As String, DNI As Long, SOCIAL As String, AFILIADO As Long, CODIGO As Long, CELULAR As Long, FECHA As String, BARRIO As String) As Boolean
        Dim OK As Boolean = False
        Dim FILA As DataRow = TABLA.Rows.Find(DNI)

        If FILA Is Nothing Then
            FILA = TABLA.NewRow
            FILA("matricula") = "1000"
            FILA("Apellido") = APELLIDO
            FILA("Nombre") = NOMBRE
            FILA("Edad") = EDAD
            FILA("Domicilio") = DOMICILIO
            FILA("Nro_Calle") = NroCALLE
            FILA("Telefono") = TELEFONO
            FILA("Dni") = DNI
            FILA("ObraSocial") = SOCIAL
            FILA("Afiliado") = AFILIADO
            FILA("Codigo") = CODIGO
            FILA("Celular") = CELULAR
            FILA("Nacimiento") = FECHA
            FILA("Barrio") = BARRIO
            TABLA.Rows.Add(FILA)
            Actualizar()
            OK = True
        End If
        Return OK

    End Function

    Private Sub Actualizar()
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
    Public Function Buscar(DNI As Long) As Array
        '   'Creamos un vector con los 3 datos para recorrerlos por la fila de la tabla
        Dim DATOS(12) As String

        Dim FILA As DataRow = TABLA.Rows.Find(DNI)

        'Si la fila se encuentra entonces devuelve la hora del turno, de lo contrario devuelve "nothing" en la hora
        If FILA IsNot Nothing Then
            If FILA(TABLA.Columns("Apellido")) IsNot DBNull.Value Then
                DATOS(0) = FILA(TABLA.Columns("Apellido"))
            End If
            If FILA(TABLA.Columns("Nombre")) IsNot DBNull.Value Then
                DATOS(1) = FILA(TABLA.Columns("Nombre"))
            End If
            If FILA(TABLA.Columns("Edad")) IsNot DBNull.Value Then
                DATOS(2) = FILA(TABLA.Columns("Edad"))
            End If
            If FILA(TABLA.Columns("Domicilio")) IsNot DBNull.Value Then
                DATOS(3) = FILA(TABLA.Columns("Domicilio"))
            End If
            If FILA(TABLA.Columns("Nro_Calle")) IsNot DBNull.Value Then
                DATOS(4) = FILA(TABLA.Columns("Nro_Calle"))
            End If
            If FILA(TABLA.Columns("Telefono")) IsNot DBNull.Value Then
                DATOS(5) = FILA(TABLA.Columns("Telefono"))
            End If
            If FILA(TABLA.Columns("Celular")) IsNot DBNull.Value Then
                DATOS(6) = FILA(TABLA.Columns("Celular"))
            End If
            DATOS(7) = FILA(TABLA.Columns("Dni"))
            If FILA(TABLA.Columns("ObraSocial")) IsNot DBNull.Value Then
                DATOS(8) = FILA(TABLA.Columns("ObraSocial"))
            End If
            If FILA(TABLA.Columns("Afiliado")) IsNot DBNull.Value Then
                DATOS(9) = FILA(TABLA.Columns("Afiliado"))
            End If
            If FILA(TABLA.Columns("Codigo")) IsNot DBNull.Value Then
                DATOS(10) = FILA(TABLA.Columns("Codigo"))
            End If
            If FILA(TABLA.Columns("Nacimiento")) IsNot DBNull.Value Then
                DATOS(11) = FILA(TABLA.Columns("Nacimiento"))
            End If
            If FILA(TABLA.Columns("Barrio")) IsNot DBNull.Value Then
                DATOS(12) = FILA(TABLA.Columns("Barrio"))
            End If
        Else
            DATOS = Nothing
        End If

        Return DATOS

    End Function

    Public Function Nombre(MATRICULA As Long, FECHA As String, HORA As String) As String
            'Creamos un vector con los 3 datos para recorrerlos por la fila de la tabla
            Dim VEC(2) As String
            Dim PACIENTE As String

            VEC(0) = MATRICULA
            VEC(1) = FECHA
            VEC(2) = HORA

            Dim FILA As DataRow = TABLA.Rows.Find(VEC)

            'Si la fila se encuentra entonces devuelve el nombre del paciente, de lo contrario devuelve "nothing" en el paciente
            If FILA IsNot Nothing Then
                PACIENTE = FILA(TABLA.Columns("paciente"))
            Else
                PACIENTE = Nothing
            End If
            Return PACIENTE
        End Function
    Public Function Obtener()
        Return TABLA
    End Function

    Public Sub Eliminar(DNI As Long)

        Dim FILA As DataRow = TABLA.Rows.Find(DNI)
        If Not FILA Is Nothing Then
            FILA.Delete()
            Actualizar()
        End If
    End Sub

    Public Sub Modificar(APELLIDO As String, NOMBRE As String, EDAD As Long, DOMICILIO As String, NroCALLE As Long, TELEFONO As String, DNI As Long, SOCIAL As String, AFILIADO As Long, CODIGO As Long, CELULAR As Long, FECHA As String, BARRIO As String)
        Dim FILA As DataRow = TABLA.Rows.Find(DNI)
        If Not FILA Is Nothing Then
            FILA.BeginEdit()
            FILA("matricula") = "1000"
            FILA("Apellido") = APELLIDO
            FILA("Nombre") = NOMBRE
            FILA("Edad") = EDAD
            FILA("Domicilio") = DOMICILIO
            FILA("Nro_Calle") = NroCALLE
            FILA("Telefono") = TELEFONO
            FILA("Dni") = DNI
            FILA("ObraSocial") = SOCIAL
            FILA("Afiliado") = AFILIADO
            FILA("Codigo") = CODIGO
            FILA("Celular") = CELULAR
            FILA("Nacimiento") = FECHA
            FILA("Barrio") = BARRIO
            FILA.EndEdit()
            Actualizar()
        End If

    End Sub
End Class
