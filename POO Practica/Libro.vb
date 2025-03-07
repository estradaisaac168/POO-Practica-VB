Public Class Libro

#Region "Declaracion de variables"
    Private _titulo As String
    Private _autor As String
    Private _isbn As String
    Private _disponible As Boolean
#End Region


#Region "Constructor de la clase"
    Public Sub New(titulo As String, autor As String, isbn As String)
        _titulo = titulo
        _autor = autor
        _isbn = isbn
        _disponible = True
    End Sub
#End Region


#Region "Propiedades de la clase"
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property


    Public Property Autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            _autor = value
        End Set
    End Property


    Public Property ISBN As String
        Get
            Return _isbn
        End Get
        Set(value As String)
            _isbn = value
        End Set
    End Property



    Public Property Disponoble As Boolean
        Get
            Return _disponible
        End Get
        Set(value As Boolean)
            _disponible = value
        End Set
    End Property

#End Region


#Region "Metodo Prestar"
    Public Sub Prestar()
        If _disponible Then
            _disponible = False
            Console.WriteLine("Libro Prestado: " & _titulo)
        Else
            Console.WriteLine("El libro no eta disponible")
        End If
    End Sub
#End Region


#Region "Metodo devolver"
    Public Sub Devolver()
        _disponible = True
        Console.WriteLine("Libro devuelto: " & _titulo)
    End Sub
#End Region

End Class
