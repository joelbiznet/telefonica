Public Class ClsTelefonos
    Private _cod_telf As String
    Private _marca As String
    Private _modelo As String
    Private _precio As Double
    Public Sub New()
        _cod_telf = ""
        _marca = ""
        _modelo = ""
        _precio = 0
    End Sub
    Public Property cod_telf() As String
        Get
            Return _cod_telf
        End Get
        Set(value As String)
            _cod_telf = value
        End Set
    End Property
    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property
    Public Property modelo() As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property
End Class
