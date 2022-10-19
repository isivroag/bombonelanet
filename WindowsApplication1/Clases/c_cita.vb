Public Class c_cita
    Private _folio As Integer
    Private _id_persona As Integer
    Private _tipo_persona As Integer
    Private _nombre As String
    Private _fecha As DateTime
    Private _id_cabina As Integer
    Private _fecha_final As DateTime
    Private _duracion As Double
    Private _id_serv As Integer
    Private _id_col As Integer
    Private _obs As String
    Private _cel As String
    Private _tel As String
    Private _estado As Boolean

    Public Property Folio As Integer
        Get
            Return _folio
        End Get
        Set(value As Integer)
            _folio = value
        End Set
    End Property

    Public Property Id_persona As Integer
        Get
            Return _id_persona
        End Get
        Set(value As Integer)
            _id_persona = value
        End Set
    End Property

    Public Property Tipo_persona As Integer
        Get
            Return _tipo_persona
        End Get
        Set(value As Integer)
            _tipo_persona = value
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

    Public Property Duracion As Double
        Get
            Return _duracion
        End Get
        Set(value As Double)
            _duracion = value
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

    Public Property Cel As String
        Get
            Return _cel
        End Get
        Set(value As String)
            _cel = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property
End Class
