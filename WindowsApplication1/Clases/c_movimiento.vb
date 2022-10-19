Public Class c_movimiento
    Private _id_mov As Int64
    Private _id_producto As Int64
    Private _tipo_mov As Integer
    Private _fecha_mov As Date
    Private _ini_mov As Double
    Private _cant_mov As Double
    Private _unidad_mov As String
    Private _fin_mov As Double
    Private _obs_mov As String
    Private _id_almacen As Int64

    Public Property Id_mov As Long
        Get
            Return _id_mov
        End Get
        Set(value As Long)
            _id_mov = value
        End Set
    End Property

    Public Property Id_producto As Long
        Get
            Return _id_producto
        End Get
        Set(value As Long)
            _id_producto = value
        End Set
    End Property

    Public Property Tipo_mov As Integer
        Get
            Return _tipo_mov
        End Get
        Set(value As Integer)
            _tipo_mov = value
        End Set
    End Property

    Public Property Fecha_mov As Date
        Get
            Return _fecha_mov
        End Get
        Set(value As Date)
            _fecha_mov = value
        End Set
    End Property

    Public Property Ini_mov As Double
        Get
            Return _ini_mov
        End Get
        Set(value As Double)
            _ini_mov = value
        End Set
    End Property

    Public Property Cant_mov As Double
        Get
            Return _cant_mov
        End Get
        Set(value As Double)
            _cant_mov = value
        End Set
    End Property

    Public Property Unidad_mov As String
        Get
            Return _unidad_mov
        End Get
        Set(value As String)
            _unidad_mov = value
        End Set
    End Property

    Public Property Fin_mov As Double
        Get
            Return _fin_mov
        End Get
        Set(value As Double)
            _fin_mov = value
        End Set
    End Property

    Public Property Obs_mov As String
        Get
            Return _obs_mov
        End Get
        Set(value As String)
            _obs_mov = value
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
End Class


