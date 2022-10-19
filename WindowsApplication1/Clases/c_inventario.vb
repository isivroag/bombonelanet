Public Class c_inventario
    Private _id_inv As Int64
    Private _id_almacen As Int64
    Private _id_prod As Int64
    Private _cant_prod As Double
    Private _nom_unidad As String

    Public Property Id_inv As Long
        Get
            Return _id_inv
        End Get
        Set(value As Long)
            _id_inv = value
        End Set
    End Property

    Public Property Id_almacen As Long
        Get
            Return _id_almacen
        End Get
        Set(value As Long)
            _id_almacen = value
        End Set
    End Property

    Public Property Id_prod As Long
        Get
            Return _id_prod
        End Get
        Set(value As Long)
            _id_prod = value
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

    Public Property Nom_unidad As String
        Get
            Return _nom_unidad
        End Get
        Set(value As String)
            _nom_unidad = value
        End Set
    End Property
End Class
