Imports System.Drawing.Printing
Public Class PrintPreviewDialogSelectPrinter
    Inherits PrintPreviewDialog

    Dim ShowCounter As Integer = 0

    Private Sub myPrintPreview_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If ShowCounter > 0 Then Exit Sub
        ShowCounter += 1
        'Get the toolstrip from the base control
        Dim ts As ToolStrip = CType(Me.Controls(1), ToolStrip)
        'Get the print button from the toolstrip
        Dim printItem As ToolStripItem = ts.Items("printToolStripButton")

        'Add a new button 
        With printItem

            Dim myPrintItem As ToolStripItem
            myPrintItem = ts.Items.Add(.Text, .Image, New EventHandler(AddressOf MyPrintItemClicked))

            myPrintItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            'Relocate the item to the beginning of the toolstrip
            ts.Items.Insert(0, myPrintItem)
        End With

        'Remove the orginal button
        ts.Items.Remove(printItem)
    End Sub
    Private Sub MyPrintItemClicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim dlgPrint As New PrintDialog
        Try
            With dlgPrint
                .AllowSelection = True
                .ShowNetwork = True
                .Document = Document
            End With
            If dlgPrint.ShowDialog = Windows.Forms.DialogResult.OK Then
                Document.Print()
            End If
        Catch ex As Exception
            MsgBox("Print Error: " & ex.Message)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'PrintPreviewDialogSelectPrinter
        '
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Name = "PrintPreviewDialogSelectPrinter"
        Me.ResumeLayout(False)

    End Sub

    Private Sub PrintPreviewDialogSelectPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
