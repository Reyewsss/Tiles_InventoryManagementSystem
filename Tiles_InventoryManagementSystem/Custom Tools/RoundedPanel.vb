Imports System.Drawing.Drawing2D

Public Class RoundedPanel
    Inherits Panel

    Private _borderColor As Color = Color.Black ' Default border color
    Private _borderThickness As Integer = 2    ' Default border thickness

    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate() ' Redraw the panel
        End Set
    End Property

    Public Property BorderThickness As Integer
        Get
            Return _borderThickness
        End Get
        Set(value As Integer)
            _borderThickness = value
            Me.Invalidate() ' Redraw the panel
        End Set
    End Property

    Public Sub New()
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim graphics = e.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim bounds = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim radius As Integer = 20 ' Set the radius for rounded corners

        Using path = GetRoundedRectanglePath(bounds, radius)
            Me.Region = New Region(path)

            ' Draw border with customizable color and thickness
            Using pen As New Pen(_borderColor, _borderThickness)
                pen.Alignment = PenAlignment.Inset
                graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    Private Function GetRoundedRectanglePath(bounds As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
