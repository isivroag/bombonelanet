Public Class c_proveedor
    Private _id_prov As Int64
    Private _nom_prov As String
    Private _rfc As String
    Private _correo As String
    Private _direccion As String
    Private _tel As String
    Private _cel As String
    Private _estado_prov As Boolean

    Public Property Id_prov As Long
        Get
            Return _id_prov
        End Get
        Set(value As Long)
            _id_prov = value
        End Set
    End Property

    Public Property Nom_prov As String
        Get
            Return _nom_prov
        End Get
        Set(value As String)
            _nom_prov = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property

    Public Property Cel As String
        Get
            Return _cel
        End Get
        Set(value As String)
            _cel = value
        End Set
    End Property

    Public Property Estado_prov As Boolean
        Get
            Return _estado_prov
        End Get
        Set(value As Boolean)
            _estado_prov = value
        End Set
    End Property
End Class
