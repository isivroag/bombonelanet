Public Class c_tipo
    Private _id_tipo As Int64
    Private _nom_tipo As String
    Private _estado_tipo As Boolean

    Public Property Id_tipo As Long
        Get
            Return _id_tipo
        End Get
        Set(value As Long)
            _id_tipo = value
        End Set
    End Property

    Public Property Nom_tipo As String
        Get
            Return _nom_tipo
        End Get
        Set(value As String)
            _nom_tipo = value
        End Set
    End Property

    Public Property Estado_tipo As Boolean
        Get
            Return _estado_tipo
        End Get
        Set(value As Boolean)
            _estado_tipo = value
        End Set
    End Property
End Class
