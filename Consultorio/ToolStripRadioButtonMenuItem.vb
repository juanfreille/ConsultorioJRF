Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Public Class ToolStripRadioButtonMenuItem
    Inherits ToolStripMenuItem

    Public Sub New()
        MyBase.New()
        Initialize()
    End Sub

    Public Sub New(ByVal text As String)
        MyBase.New(text, Nothing, CType(Nothing, EventHandler))
        Initialize()
    End Sub

    Public Sub New(ByVal image As Image)
        MyBase.New(Nothing, image, CType(Nothing, EventHandler))
        Initialize()
    End Sub

    Public Sub New(ByVal text As String, ByVal image As Image)
        MyBase.New(text, image, CType(Nothing, EventHandler))
        Initialize()
    End Sub

    Public Sub New(ByVal text As String,
        ByVal image As Image, ByVal onClick As EventHandler)
        MyBase.New(text, image, onClick)
        Initialize()
    End Sub

    Public Sub New(ByVal text As String, ByVal image As Image,
        ByVal onClick As EventHandler, ByVal name As String)
        MyBase.New(text, image, onClick, name)
        Initialize()
    End Sub

    Public Sub New(ByVal text As String, ByVal image As Image,
        ByVal ParamArray dropDownItems() As ToolStripItem)
        MyBase.New(text, image, dropDownItems)
        Initialize()
    End Sub

    Public Sub New(ByVal text As String, ByVal image As Image,
        ByVal onClick As EventHandler, ByVal shortcutKeys As Keys)
        MyBase.New(text, image, onClick)
        Initialize()
        Me.ShortcutKeys = shortcutKeys
    End Sub

    ' Called by all constructors to initialize CheckOnClick.
    Private Sub Initialize()
        CheckOnClick = True
    End Sub

    Protected Overrides Sub OnCheckedChanged(ByVal e As EventArgs)

        MyBase.OnCheckedChanged(e)

        ' If this item is no longer in the checked state, do nothing.
        If Not Checked Then Return

        ' Clear the checked state for all siblings. 
        For Each item As ToolStripItem In Parent.Items

            Dim radioItem As ToolStripRadioButtonMenuItem =
                TryCast(item, ToolStripRadioButtonMenuItem)
            If radioItem IsNot Nothing AndAlso
                radioItem IsNot Me AndAlso
                radioItem.Checked Then

                radioItem.Checked = False

                ' Only one item can be selected at a time, 
                ' so there is no need to continue.
                Return

            End If
        Next

    End Sub

    Protected Overrides Sub OnClick(ByVal e As EventArgs)

        ' If the item is already in the checked state, do not call 
        ' the base method, which would toggle the value. 
        If Checked Then Return

        MyBase.OnClick(e)
    End Sub

    ' Let the item paint itself, and then paint the RadioButton
    ' where the check mark is displayed, covering the check mark
    ' if it is present.
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        MyBase.OnPaint(e)

        ' If the client sets the Image property, the selection behavior
        ' remains unchanged, but the RadioButton is not displayed and the
        ' selection is indicated only by the selection rectangle. 
        If Image IsNot Nothing Then Return

        ' Determine the correct state of the RadioButton.
        Dim buttonState As RadioButtonState = RadioButtonState.UncheckedNormal
        If Enabled Then
            If mouseDownState Then
                If Checked Then
                    buttonState = RadioButtonState.CheckedPressed
                Else
                    buttonState = RadioButtonState.UncheckedPressed
                End If
            ElseIf mouseHoverState Then
                If Checked Then
                    buttonState = RadioButtonState.CheckedHot
                Else
                    buttonState = RadioButtonState.UncheckedHot
                End If
            Else
                If Checked Then buttonState = RadioButtonState.CheckedNormal
            End If
        Else
            If Checked Then
                buttonState = RadioButtonState.CheckedDisabled
            Else
                buttonState = RadioButtonState.UncheckedDisabled
            End If
        End If

        ' Calculate the position at which to display the RadioButton.
        Dim offset As Int32 = CInt((ContentRectangle.Height -
            RadioButtonRenderer.GetGlyphSize(
            e.Graphics, buttonState).Height) / 2)
        Dim imageLocation As Point = New Point(
            ContentRectangle.Location.X + 4,
            ContentRectangle.Location.Y + offset)

        ' If the item is selected and the RadioButton paints with partial
        ' transparency, such as when theming is enabled, the check mark
        ' shows through the RadioButton image. In this case, paint a 
        ' non-transparent background first to cover the check mark.
        If Checked AndAlso RadioButtonRenderer _
            .IsBackgroundPartiallyTransparent(buttonState) Then

            Dim glyphSize As Size = RadioButtonRenderer _
                .GetGlyphSize(e.Graphics, buttonState)
            glyphSize.Height -= 1
            glyphSize.Width -= 1
            Dim backgroundRectangle As _
                New Rectangle(imageLocation, glyphSize)
            e.Graphics.FillEllipse(
                SystemBrushes.Control, backgroundRectangle)
        End If

        RadioButtonRenderer.DrawRadioButton(
            e.Graphics, imageLocation, buttonState)

    End Sub

    Private mouseHoverState As Boolean = False

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        mouseHoverState = True

        ' Force the item to repaint with the new RadioButton state.
        Invalidate()

        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        mouseHoverState = False
        MyBase.OnMouseLeave(e)
    End Sub

    Private mouseDownState As Boolean = False

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        mouseDownState = True

        ' Force the item to repaint with the new RadioButton state.
        Invalidate()

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        mouseDownState = False
        MyBase.OnMouseUp(e)
    End Sub

    ' Enable the item only if its parent item is in the checked state 
    ' and its Enabled property has not been explicitly set to false. 
    Public Overrides Property Enabled() As Boolean
        Get
            Dim ownerMenuItem As ToolStripMenuItem =
                TryCast(OwnerItem, ToolStripMenuItem)

            ' Use the base value in design mode to prevent the designer
            ' from setting the base value to the calculated value.
            If Not DesignMode AndAlso
                ownerMenuItem IsNot Nothing AndAlso
                ownerMenuItem.CheckOnClick Then
                Return MyBase.Enabled AndAlso ownerMenuItem.Checked
            Else
                Return MyBase.Enabled
            End If
        End Get

        Set(ByVal value As Boolean)
            MyBase.Enabled = value
        End Set
    End Property

    ' When OwnerItem becomes available, if it is a ToolStripMenuItem 
    ' with a CheckOnClick property value of true, subscribe to its 
    ' CheckedChanged event. 
    Protected Overrides Sub OnOwnerChanged(ByVal e As EventArgs)

        Dim ownerMenuItem As ToolStripMenuItem =
            TryCast(OwnerItem, ToolStripMenuItem)

        If ownerMenuItem IsNot Nothing AndAlso
            ownerMenuItem.CheckOnClick Then
            AddHandler ownerMenuItem.CheckedChanged, New _
                EventHandler(AddressOf OwnerMenuItem_CheckedChanged)
        End If

        MyBase.OnOwnerChanged(e)

    End Sub

    ' When the checked state of the parent item changes, 
    ' repaint the item so that the new Enabled state is displayed. 
    Private Sub OwnerMenuItem_CheckedChanged(
        ByVal sender As Object, ByVal e As EventArgs)
        Invalidate()
    End Sub

End Class

Public Class Form1
    Inherits Form

    Private menuStrip1 As New MenuStrip()
    Private mainToolStripMenuItem As New ToolStripMenuItem()
    Private toolStripMenuItem1 As New ToolStripMenuItem()
    Private toolStripRadioButtonMenuItem1 As New ToolStripRadioButtonMenuItem()
    Private toolStripRadioButtonMenuItem2 As New ToolStripRadioButtonMenuItem()
    Private toolStripRadioButtonMenuItem3 As New ToolStripRadioButtonMenuItem()
    Private toolStripRadioButtonMenuItem4 As New ToolStripRadioButtonMenuItem()
    Private toolStripRadioButtonMenuItem5 As New ToolStripRadioButtonMenuItem()
    Private toolStripRadioButtonMenuItem6 As New ToolStripRadioButtonMenuItem()

    Public Sub New()

        Me.mainToolStripMenuItem.Text = "main"
        toolStripRadioButtonMenuItem1.Text = "option 1"
        toolStripRadioButtonMenuItem2.Text = "option 2"
        toolStripRadioButtonMenuItem3.Text = "option 2-1"
        toolStripRadioButtonMenuItem4.Text = "option 2-2"
        toolStripRadioButtonMenuItem5.Text = "option 3-1"
        toolStripRadioButtonMenuItem6.Text = "option 3-2"
        toolStripMenuItem1.Text = "toggle"
        toolStripMenuItem1.CheckOnClick = True

        mainToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {
            toolStripRadioButtonMenuItem1, toolStripRadioButtonMenuItem2,
            toolStripMenuItem1})
        toolStripRadioButtonMenuItem2.DropDownItems.AddRange(
            New ToolStripItem() {toolStripRadioButtonMenuItem3,
            toolStripRadioButtonMenuItem4})
        toolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {
            toolStripRadioButtonMenuItem5, toolStripRadioButtonMenuItem6})

        menuStrip1.Items.AddRange(New ToolStripItem() {mainToolStripMenuItem})
        Controls.Add(menuStrip1)
        MainMenuStrip = menuStrip1
        Text = "ToolStripRadioButtonMenuItem demo"
    End Sub
End Class

Public Class Program

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

End Class
