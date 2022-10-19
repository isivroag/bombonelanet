Public Class c_paquete
    Private _id_serv As Int64
    Private _id_pqt As Int64
    Private _clave_pqt As String
    Private _desc_pqt As String
    Private _sesiones_pqt As String
    Private _precio_pqt As Double
    Private _estado_pqt As Boolean

    Public Property Id_serv As Long
        Get
            Return _id_serv
        End Get
        Set(value As Long)
            _id_serv = value
        End Set
    End Property

    Public Property Id_pqt As Long
        Get
            Return _id_pqt
        End Get
        Set(value As Long)
            _id_pqt = value
        End Set
    End Property

    Public Property Clave_pqt As String
        Get
            Return _clave_pqt
        End Get
        Set(value As String)
            _clave_pqt = value
        End Set
    End Property

    Public Property Desc_pqt As String
        Get
            Return _desc_pqt
        End Get
        Set(value As String)
            _desc_pqt = value
        End Set
    End Property

    Public Property Sesiones_pqt As String
        Get
            Return _sesiones_pqt
        End Get
        Set(value As String)
            _sesiones_pqt = value
        End Set
    End Property

    Public Property Precio_pqt As Double
        Get
            Return _precio_pqt
        End Get
        Set(value As Double)
            _precio_pqt = value
        End Set
    End Property

    Public Property Estado_pqt As Boolean
        Get
            Return _estado_pqt
        End Get
        Set(value As Boolean)
            _estado_pqt = value
        End Set
    End Property
End Class
