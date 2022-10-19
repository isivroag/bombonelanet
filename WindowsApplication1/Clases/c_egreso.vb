Public Class c_egreso
    Private _id_egr As Int64
    Private _fecha_egr As Date
    Private _facturado As Boolean
    Private _ref_egr As String
    Private _id_prov As Int64
    Private _id_partida As Int64
    Private _id_subpartida As Int64
    Private _concepto_egr As String
    Private _metodo_egr As String
    Private _total_egr As Double
    Private _estado_egr As Boolean

    Public Property Id_egr As Long
        Get
            Return _id_egr
        End Get
        Set(value As Long)
            _id_egr = value
        End Set
    End Property

    Public Property Fecha_egr As Date
        Get
            Return _fecha_egr
        End Get
        Set(value As Date)
            _fecha_egr = value
        End Set
    End Property

    Public Property Facturado As Boolean
        Get
            Return _facturado
        End Get
        Set(value As Boolean)
            _facturado = value
        End Set
    End Property

    Public Property Ref_egr As String
        Get
            Return _ref_egr
        End Get
        Set(value As String)
            _ref_egr = value
        End Set
    End Property

    Public Property Id_prov As Long
        Get
            Return _id_prov
        End Get
        Set(value As Long)
            _id_prov = value
        End Set
    End Property

    Public Property Id_partida As Long
        Get
            Return _id_partida
        End Get
        Set(value As Long)
            _id_partida = value
        End Set
    End Property

    Public Property Id_subpartida As Long
        Get
            Return _id_subpartida
        End Get
        Set(value As Long)
            _id_subpartida = value
        End Set
    End Property

    Public Property Concepto_egr As String
        Get
            Return _concepto_egr
        End Get
        Set(value As String)
            _concepto_egr = value
        End Set
    End Property

    Public Property Metodo_egr As String
        Get
            Return _metodo_egr
        End Get
        Set(value As String)
            _metodo_egr = value
        End Set
    End Property

    Public Property Total_egr As Double
        Get
            Return _total_egr
        End Get
        Set(value As Double)
            _total_egr = value
        End Set
    End Property

    Public Property Estado_egr As Boolean
        Get
            Return _estado_egr
        End Get
        Set(value As Boolean)
            _estado_egr = value
        End Set
    End Property
End Class
