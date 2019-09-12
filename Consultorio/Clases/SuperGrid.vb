Imports System.ComponentModel

Public Class SuperGrid
    Inherits DataGridView

    Public Property PageSize As Integer
        Get
            Return _pageSize
        End Get
        Set
            _pageSize = Value
        End Set
    End Property

    Public _pageSize As Integer = 10

    Public bs As BindingSource = New BindingSource

    Public tables As BindingList(Of DataTable) = New BindingList(Of DataTable)

    Public Sub SetPagedDataSource(ByVal dataTable As DataTable, ByVal bnav As BindingNavigator)
        Dim dt As DataTable = Nothing
        Dim counter As Integer = 1
        For Each dr As DataRow In dataTable.Rows

            If counter = 1 Then
                dt = dataTable.Clone()
                tables.Add(dt)
            End If

            dt.Rows.Add(dr.ItemArray)

            If PageSize < System.Threading.Interlocked.Increment(counter) Then
                counter = 1
            End If
        Next
        bnav.BindingSource = bs
        bs.DataSource = tables

        AddHandler bs.PositionChanged, AddressOf bs_PositionChanged
        bs_PositionChanged(bs, EventArgs.Empty)
    End Sub

    Private Sub bs_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.DataSource = tables(bs.Position)
    End Sub
End Class
