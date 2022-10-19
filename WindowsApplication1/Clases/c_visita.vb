Public Class c_visita
    Private _folio_vis As Int64
    Private _id_clie As Int64
    Private _nombre As String
    Private _fecha As DateTime
    Private _id_cabina As Integer
    Private _fecha_final As DateTime

    Private _id_serv As Integer
    Private _id_col As Integer
    Private _obs As String
    Private _estado As Boolean
    Private _folio_cita As String
    Private _entrada As DateTime
    Private _salida As DateTime

    Public Property Folio_vis As Long
        Get
            Return _folio_vis
        End Get
        Set(value As Long)
            _folio_vis = value
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

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Id_cabina As Integer
        Get
            Return _id_cabina
        End Get
        Set(value As Integer)
            _id_cabina = value
        End Set
    End Property

    Public Property Fecha_final As Date
        Get
            Return _fecha_final
        End Get
        Set(value As Date)
            _fecha_final = value
        End Set
    End Property


    Public Property Id_serv As Integer
        Get
            Return _id_serv
        End Get
        Set(value As Integer)
            _id_serv = value
        End Set
    End Property

    Public Property Id_col As Integer
        Get
            Return _id_col
        End Get
        Set(value As Integer)
            _id_col = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Folio_cita As String
        Get
            Return _folio_cita
        End Get
        Set(value As String)
            _folio_cita = value
        End Set
    End Property

    Public Property Entrada As Date
        Get
            Return _entrada
        End Get
        Set(value As Date)
            _entrada = value
        End Set
    End Property

    Public Property Salida As Date
        Get
            Return _salida
        End Get
        Set(value As Date)
            _salida = value
        End Set
    End Property
End Class
