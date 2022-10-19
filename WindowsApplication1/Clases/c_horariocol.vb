Public Class c_horariocol
    Private _id_reg As Int64
    Private _id_dia As Int64
    Private _id_col As Int64
    Private _dia As String
    Private _entrada As TimeSpan
    Private _salida As TimeSpan

    Public Property Id_reg As Long
        Get
            Return _id_reg
        End Get
        Set(value As Long)
            _id_reg = value
        End Set
    End Property

    Public Property Id_dia As Long
        Get
            Return _id_dia
        End Get
        Set(value As Long)
            _id_dia = value
        End Set
    End Property

    Public Property Id_col As Long
        Get
            Return _id_col
        End Get
        Set(value As Long)
            _id_col = value
        End Set
    End Property

    Public Property Dia As String
        Get
            Return _dia
        End Get
        Set(value As String)
            _dia = value
        End Set
    End Property

    Public Property Entrada As TimeSpan
        Get
            Return _entrada
        End Get
        Set(value As TimeSpan)
            _entrada = value
        End Set
    End Property

    Public Property Salida As TimeSpan
        Get
            Return _salida
        End Get
        Set(value As TimeSpan)
            _salida = value
        End Set
    End Property
End Class
