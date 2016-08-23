Public Class ClsClientes
    Private _dni As String
    Private _nombre As String
    Private _apellido As String
    Private _sexo As String
    Public Sub New()
        _dni = ""
        _nombre = ""
        _apellido = ""
        _sexo = ""
    End Sub
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property
End Class
