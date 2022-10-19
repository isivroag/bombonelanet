Public Class c_cxc
    Private _folio_cxc As Int64
    Private _id_clie As Int64
    Private _fecha_cxc As Date
    Private _total_cxc As Double
    Private _saldo_cxc As Double
    Private _estado_cxc As Boolean
    Private _id_col As Int64
    Private _nom_col As String
    Private _concepto_cxc As String
    Private _subtotal_cxc As Double
    Private _descuento_cxc As Double

    Public Property Folio_cxc As Long
        Get
            Return _folio_cxc
        End Get
        Set(value As Long)
            _folio_cxc = value
        End Set
    End Property

    Public Property Id_clie As Long
        Get
            Return _id_clie
        End Get
        Set(value As Long)
            _id_clie = value
        End Set
    End Property

    Public Property Fecha_cxc As Date
        Get
            Return _fecha_cxc
        End Get
        Set(value As Date)
            _fecha_cxc = value
        End Set
    End Property

    Public Property Total_cxc As Double
        Get
            Return _total_cxc
        End Get
        Set(value As Double)
            _total_cxc = value
        End Set
    End Property

    Public Property Saldo_cxc As Double
        Get
            Return _saldo_cxc
        End Get
        Set(value As Double)
            _saldo_cxc = value
        End Set
    End Property

    Public Property Estado_cxc As Boolean
        Get
            Return _estado_cxc
        End Get
        Set(value As Boolean)
            _estado_cxc = value
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

    Public Property Concepto_cxc As String
        Get
            Return _concepto_cxc
        End Get
        Set(value As String)
            _concepto_cxc = value
        End Set
    End Property

    Public Property Subtotal_cxc As Double
        Get
            Return _subtotal_cxc
        End Get
        Set(value As Double)
            _subtotal_cxc = value
        End Set
    End Property

    Public Property Descuento_cxc As Double
        Get
            Return _descuento_cxc
        End Get
        Set(value As Double)
            _descuento_cxc = value
        End Set
    End Property
End Class
