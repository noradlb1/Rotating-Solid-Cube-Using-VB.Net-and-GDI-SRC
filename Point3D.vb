'
' Defines the Point3D class that represents points in 3D space.
' Developed by leonelmachava <leonelmachava@gmail.com>
' http://codentronix.com
'
' Copyright (c) 2011 Leonel Machava
' 
' Permission is hereby granted, free of charge, to any person obtaining a copy of this 
' software and associated documentation files (the "Software"), to deal in the Software 
' without restriction, including without limitation the rights to use, copy, modify, 
' merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
' permit persons to whom the Software is furnished to do so, subject to the following 
' conditions:
' 
' The above copyright notice and this permission notice shall be included in all copies 
' or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
' INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
' PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
' FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
' OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'
Option Explicit On

Public Class Point3D
    Protected m_x As Double, m_y As Double, m_z As Double

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub

    Public Property X() As Double
        Get
            Return m_x
        End Get
        Set(ByVal value As Double)
            m_x = value
        End Set
    End Property

    Public Property Y() As Double
        Get
            Return m_y
        End Get
        Set(ByVal value As Double)
            m_y = value
        End Set
    End Property

    Public Property Z() As Double
        Get
            Return m_z
        End Get
        Set(ByVal value As Double)
            m_z = value
        End Set
    End Property

    Public Function RotateX(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, yn As Double, zn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        yn = Me.Y * cosa - Me.Z * sina
        zn = Me.Y * sina + Me.Z * cosa
        Return New Point3D(Me.X, yn, zn)
    End Function

    Public Function RotateY(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, Xn As Double, Zn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        Zn = Me.Z * cosa - Me.X * sina
        Xn = Me.Z * sina + Me.X * cosa

        Return New Point3D(Xn, Me.Y, Zn)
    End Function

    Public Function RotateZ(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, Xn As Double, Yn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        Xn = Me.X * cosa - Me.Y * sina
        Yn = Me.X * sina + Me.Y * cosa
        Return New Point3D(Xn, Yn, Me.Z)
    End Function

    Public Function Project(ByVal viewWidth, ByVal viewHeight, ByVal fov, ByVal viewDistance)
        Dim factor As Double, Xn As Double, Yn As Double
        factor = fov / (viewDistance + Me.Z)
        Xn = Me.X * factor + viewWidth / 2
        Yn = Me.Y * factor + viewHeight / 2
        Return New Point3D(Xn, Yn, Me.Z)
    End Function
End Class