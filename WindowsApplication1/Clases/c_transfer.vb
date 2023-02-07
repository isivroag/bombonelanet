Public Class c_transfer
    Private _folio_transfer As Int64
    Private _origen As Int64
    Private _destino As Int64
    Private _fecha_trans As Date
    Private _obs_trans As String
    Private _importe As Double
    Private _estado_trans As Boolean

    Public Property Folio_transfer As Long
        Get
            Return _folio_transfer
        End Get
        Set(value As Long)
            _folio_transfer = value
        End Set
    End Property

    Public Property Origen As Long
        Get
            Return _origen
        End Get
        Set(value As Long)
            _origen = value
        End Set
    End Property

    Public Property Destino As Long
        Get
            Return _destino
        End Get
        Set(value As Long)
            _destino = value
        End Set
    End Property

    Public Property Fecha_trans As Date
        Get
            Return _fecha_trans
        End Get
        Set(value As Date)
            _fecha_trans = value
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

    Public Property Estado_trans As Boolean
        Get
            Return _estado_trans
        End Get
        Set(value As Boolean)
            _estado_trans = value
        End Set
    End Property

    Public Property Obs_trans As String
        Get
            Return _obs_trans
        End Get
        Set(value As String)
            _obs_trans = value
        End Set
    End Property
End Class
