Public Class c_producto

    Private _id_prod As Int64
    Private _clave_prod As String
    Private _nom_prod As String
    Private _precio_prod As Double
    Private _cant_prod As Double
    Private _min_prod As Double
    Private _unidad_prod As String
    Private _estado_prod As Boolean
    Private _vendible_prod As Boolean
    Private _costo_prod As Double
    Private _nom_marca As String

    Public Property Id_prod As Long
        Get
            Return _id_prod
        End Get
        Set(value As Long)
            _id_prod = value
        End Set
    End Property

    Public Property Clave_prod As String
        Get
            Return _clave_prod
        End Get
        Set(value As String)
            _clave_prod = value
        End Set
    End Property

    Public Property Nom_prod As String
        Get
            Return _nom_prod
        End Get
        Set(value As String)
            _nom_prod = value
        End Set
    End Property

    Public Property Precio_prod As Double
        Get
            Return _precio_prod
        End Get
        Set(value As Double)
            _precio_prod = value
        End Set
    End Property

    Public Property Cant_prod As Double
        Get
            Return _cant_prod
        End Get
        Set(value As Double)
            _cant_prod = value
        End Set
    End Property

    Public Property Min_prod As Double
        Get
            Return _min_prod
        End Get
        Set(value As Double)
            _min_prod = value
        End Set
    End Property

    Public Property Unidad_prod As String
        Get
            Return _unidad_prod
        End Get
        Set(value As String)
            _unidad_prod = value
        End Set
    End Property

    Public Property Estado_prod As Boolean
        Get
            Return _estado_prod
        End Get
        Set(value As Boolean)
            _estado_prod = value
        End Set
    End Property

    Public Property Vendible_prod As Boolean
        Get
            Return _vendible_prod
        End Get
        Set(value As Boolean)
            _vendible_prod = value
        End Set
    End Property

    Public Property Costo_prod As Double
        Get
            Return _costo_prod
        End Get
        Set(value As Double)
            _costo_prod = value
        End Set
    End Property

    Public Property Nom_marca As String
        Get
            Return _nom_marca
        End Get
        Set(value As String)
            _nom_marca = value
        End Set
    End Property
End Class
