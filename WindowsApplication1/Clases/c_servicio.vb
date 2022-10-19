Public Class c_servicio
    Private _id_serv As Int64
    Private _nom_serv As String
    Private _desc_serv As String
    Private _id_tipo As Int64
    Private _precio_serv As Double
    Private _duracion As Double
    Private _estado_serv As Boolean

    Public Property Id_serv As Long
        Get
            Return _id_serv
        End Get
        Set(value As Long)
            _id_serv = value
        End Set
    End Property

    Public Property Nom_serv As String
        Get
            Return _nom_serv
        End Get
        Set(value As String)
            _nom_serv = value
        End Set
    End Property

    Public Property Desc_serv As String
        Get
            Return _desc_serv
        End Get
        Set(value As String)
            _desc_serv = value
        End Set
    End Property

    Public Property Id_tipo As Long
        Get
            Return _id_tipo
        End Get
        Set(value As Long)
            _id_tipo = value
        End Set
    End Property

    Public Property Precio_serv As Double
        Get
            Return _precio_serv
        End Get
        Set(value As Double)
            _precio_serv = value
        End Set
    End Property

    Public Property Estado_serv As Boolean
        Get
            Return _estado_serv
        End Get
        Set(value As Boolean)
            _estado_serv = value
        End Set
    End Property

    Public Property Duracion As Double
        Get
            Return _duracion
        End Get
        Set(value As Double)
            _duracion = value
        End Set
    End Property
End Class
