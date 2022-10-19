Public Class c_det_cxc
    Private _id_reg As Int64
    Private _folio_cxc As Int64
    Private _id_item As Int64
    Private _id_pqt As Int64
    Private _clave As String
    Private _concepto As String
    Private _cantidad As Double
    Private _precio As Double
    Private _subtotal As Double
    Private _estado_det As Boolean
    Private _tipo_item As String

    Public Property Id_reg As Long
        Get
            Return _id_reg
        End Get
        Set(value As Long)
            _id_reg = value
        End Set
    End Property

    Public Property Folio_cxc As Long
        Get
            Return _folio_cxc
        End Get
        Set(value As Long)
            _folio_cxc = value
        End Set
    End Property

    Public Property Id_item As Long
        Get
            Return _id_item
        End Get
        Set(value As Long)
            _id_item = value
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

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
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

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property

    Public Property Estado_det As Boolean
        Get
            Return _estado_det
        End Get
        Set(value As Boolean)
            _estado_det = value
        End Set
    End Property

    Public Property Tipo_item As String
        Get
            Return _tipo_item
        End Get
        Set(value As String)
            _tipo_item = value
        End Set
    End Property
End Class
