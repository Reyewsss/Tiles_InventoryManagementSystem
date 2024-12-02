Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class RoundedTextBox
    Inherits TextBox

    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                               ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
                                               ByVal nHeightRect As Integer, ByVal nWidthRect As Integer) As IntPtr
    End Function

    Private _borderColor As Color = Color.Black ' Default border color
    Private _borderThickness As Integer = 2     ' Default border thickness

    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate() ' Redraw control
        End Set
    End Property

    Public Property BorderThickness As Integer
        Get
            Return _borderThickness
        End Get
        Set(value As Integer)
            _borderThickness = value
            Me.Invalidate() ' Redraw control
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.SetRoundedRegion()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.SetRoundedRegion()
    End Sub

    Private Sub SetRoundedRegion()
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 20, 20))
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a border rectangle
        Dim borderRect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        Using pen As New Pen(_borderColor, _borderThickness)
            pen.Alignment = Drawing2D.PenAlignment.Inset
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.DrawPath(pen, GetRoundedRectanglePath(borderRect, 20)) ' Adjust radius as needed
        End Using
    End Sub

    Private Function GetRoundedRectanglePath(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class
