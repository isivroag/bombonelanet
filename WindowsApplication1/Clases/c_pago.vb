Public Class c_pago
    Private _folio_pago As Int64
    Private _folio_cxc As Int64
    Private _folio_fis As Int64
    Private _fecha_pago As DateTime
    Private _importe_pago As Double
    Private _id_metodo As String
    Private _nom_metodo As String
    Private _dinero_pago As Double
    Private _cambio_pago As Double
    Private _id_col As Int64
    Private _nom_col As String
    Private _tipo_pago As Boolean
    Private _saldoini_cxc As Double
    Private _saldofin_cxc As Double
    Private _letra_pago As String
    Private _estado_pago As Boolean

    Public Property Folio_pago As Long
        Get
            Return _folio_pago
        End Get
        Set(value As Long)
            _folio_pago = value
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

    Public Property Folio_fis As Long
        Get
            Return _folio_fis
        End Get
        Set(value As Long)
            _folio_fis = value
        End Set
    End Property

    Public Property Fecha_pago As Date
        Get
            Return _fecha_pago
        End Get
        Set(value As Date)
            _fecha_pago = value
        End Set
    End Property

    Public Property Importe_pago As Double
        Get
            Return _importe_pago
        End Get
        Set(value As Double)
            _importe_pago = value
        End Set
    End Property

    Public Property Id_metodo As String
        Get
            Return _id_metodo
        End Get
        Set(value As String)
            _id_metodo = value
        End Set
    End Property

    Public Property Nom_metodo As String
        Get
            Return _nom_metodo
        End Get
        Set(value As String)
            _nom_metodo = value
        End Set
    End Property

    Public Property Dinero_pago As Double
        Get
            Return _dinero_pago
        End Get
        Set(value As Double)
            _dinero_pago = value
        End Set
    End Property

    Public Property Cambio_pago As Double
        Get
            Return _cambio_pago
        End Get
        Set(value As Double)
            _cambio_pago = value
        End Set
    End Property

    Public Property Id_col As Long
        Get
            Return _id_col
        End Get
        Set(value As Long)
            _id_col = value
        End Set
    End Property

    Public Property Nom_col As String
        Get
            Return _nom_col
        End Get
        Set(value As String)
            _nom_col = value
        End Set
    End Property

    Public Property Estado_pago As Boolean
        Get
            Return _estado_pago
        End Get
        Set(value As Boolean)
            _estado_pago = value
        End Set
    End Property

    Public Property Tipo_pago As Boolean
        Get
            Return _tipo_pago
        End Get
        Set(value As Boolean)
            _tipo_pago = value
        End Set
    End Property

    Public Property Saldoini_cxc As Double
        Get
            Return _saldoini_cxc
        End Get
        Set(value As Double)
            _saldoini_cxc = value
        End Set
    End Property

    Public Property Saldofin_cxc As Double
        Get
            Return _saldofin_cxc
        End Get
        Set(value As Double)
            _saldofin_cxc = value
        End Set
    End Property

    Public Property Letra_pago As String
        Get
            Return _letra_pago
        End Get
        Set(value As String)
            _letra_pago = value
        End Set
    End Property
End Class
