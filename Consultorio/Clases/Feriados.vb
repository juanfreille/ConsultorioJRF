Imports System.Data.OleDb
Public Class Feriados
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
        Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
        Dim TABLA As New DataTable

        Public Sub New()
            COMANDO.Connection = CONECTOR
            COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Feriados"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(0) As DataColumn
        VEC(0) = TABLA.Columns("Fechas")
        TABLA.PrimaryKey = VEC
    End Sub
    Private Sub Actualizar()
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
    Public Function Obtener()
        Return TABLA
    End Function

End Class
