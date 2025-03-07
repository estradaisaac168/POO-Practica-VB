Public Class Estudiante
    Inherits Usuario

    'Se hereda de una clase con la palabra reservada Inherits


#Region "Declaracion de variables"
    Private _grado As String
#End Region


#Region "Constructor de la clase y llamando al constructor de la clase Padre"
    Public Sub New(nombre As String, id As Integer, grado As String)
        MyBase.New(nombre, id)

        _grado = grado

    End Sub
#End Region



#Region "Implementacion del metodo Mostrar() de la clase Padre"

    'Se sobreescribe un metodo con la palabra reservada Overrides

    Public Overrides Sub MostrarInformacion()
        Console.WriteLine("Estudiante: " & Nombre & "\nID: " & ID & "\nGrado: " & Grado &)
    End Sub
#End Region





#Region "Propiedades de la clase"
    Public Property Grado As String
        Get
            Return _grado
        End Get
        Set(value As String)
            _grado = value
        End Set
    End Property
#End Region


End Class
