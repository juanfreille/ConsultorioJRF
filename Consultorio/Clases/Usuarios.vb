Imports System.Data.OleDb
Public Class Usuarios
    Public CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Public ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Public TABLA As New DataTable


    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Usuarios"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("Usuario")
        TABLA.PrimaryKey = VEC

    End Sub
    Public Function Grabar(NOMBRE As String, CONTRASEÑA As String) As Boolean
        Dim OK As Boolean = False

        Dim FILA As DataRow = TABLA.Rows.Find(NOMBRE)
        If FILA Is Nothing Then
            FILA = TABLA.NewRow
            FILA("Usuario") = NOMBRE
            FILA("Contraseña") = CONTRASEÑA
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

    Public Sub Eliminar(NOMBRE As String)
        Dim FILA As DataRow = TABLA.Rows.Find(NOMBRE)
        If Not FILA Is Nothing Then
            FILA.Delete()
            Actualizar()
        End If
    End Sub

End Class
