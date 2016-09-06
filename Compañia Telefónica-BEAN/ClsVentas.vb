Public Class ClsVentas
    Private _dni As String
    Private _cod_telf As String
    Private _cantidad As Integer
    Public Sub New()
        _dni = ""
        _cod_telf = ""
        _cantidad = 0
    End Sub
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property
    Public Property cod_telf() As String
        Get
            Return _cod_telf
        End Get
        Set(value As String)
            _cod_telf = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
End Class
