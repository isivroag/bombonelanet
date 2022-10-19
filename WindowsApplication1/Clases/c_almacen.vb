Public Class c_almacen
    Private _id_almacen As Int64
    Private _nom_almacen As String
    Private _estado_almacen As Boolean


    Public Property Id_almacen As Long
        Get
            Return _id_almacen
        End Get
        Set(value As Long)
            _id_almacen = value
        End Set
    End Property

    Public Property Nom_almacen As String
        Get
            Return _nom_almacen
        End Get
        Set(value As String)
            _nom_almacen = value
        End Set
    End Property

    Public Property Estado_almacen As Boolean
        Get
            Return _estado_almacen
        End Get
        Set(value As Boolean)
            _estado_almacen = value
        End Set
    End Property

End Class

