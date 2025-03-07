Public MustInherit Class Usuario

#Region "Declaracion de variables"
    Private _nombre As String
    Private _id As Integer
#End Region


#Region "Constructor de la clase"
    Public Sub New(nombre As String, id As Integer)
        _nombre = nombre
        _id = id
    End Sub
#End Region


#Region "Propiedades de la clase"
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
#End Region


#Region "Metodo abstracto que deberan implementar las clases hijas"
    Public MustOverride Sub MostrarInformacion()
#End Region

End Class
