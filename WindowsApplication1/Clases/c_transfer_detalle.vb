Public Class c_transfer_detalle
    Private _id_reg As Int64
    Private _folio_transfer As Int64
    Private _id_prod As Int64
    Private _clave_prod As String
    Private _concepto As String
    Private _unidad As String
    Private _cantidad As Double
    Private _costo As Double
    Private _importe As Double
    Private _estado_reg As Boolean

    Public Property Id_reg As Long
        Get
            Return _id_reg
        End Get
        Set(value As Long)
            _id_reg = value
        End Set
    End Property

    Public Property Folio_transfer As Long
        Get
            Return _folio_transfer
        End Get
        Set(value As Long)
            _folio_transfer = value
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

    Public Property Clave_prod As String
        Get
            Return _clave_prod
        End Get
        Set(value As String)
            _clave_prod = value
        End Set
    End Property

    Public Property Concepto As String
        Get
            Return _concepto
        End Get
        Set(value As String)
            _concepto = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Costo As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(value As Double)
            _importe = value
        End Set
    End Property

    Public Property Estado_reg As Boolean
        Get
            Return _estado_reg
        End Get
        Set(value As Boolean)
            _estado_reg = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _unidad
        End Get
        Set(value As String)
            _unidad = value
        End Set
    End Property
End Class
