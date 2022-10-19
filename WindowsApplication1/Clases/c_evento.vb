Public Class c_evento
    Private _folio As Int64
    Private _nombre As String
    Private _fecha As DateTime
    Private _fechafinal As DateTime
    Private _id_cabina As Int64
    Private _color As String
    Private _dia As Integer
    Public Sub New()

    End Sub
    Public Sub New(_folio As Long, _nombre As String, _fecha As Date, _fechafinal As Date, _id_cabina As Long, _color As String)
        Me._folio = _folio
        Me._nombre = _nombre
        Me._fecha = _fecha
        Me._fechafinal = _fechafinal
        Me._id_cabina = _id_cabina
        Me._color = _color
        Me._dia = Fecha.DayOfWeek
    End Sub

    Public Property Folio As Long
        Get
            Return _folio
        End Get
        Set(value As Long)
            _folio = value
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

    Public Property Fechafinal As Date
        Get
            Return _fechafinal
        End Get
        Set(value As Date)
            _fechafinal = value
        End Set
    End Property

    Public Property Id_cabina As Long
        Get
            Return _id_cabina
        End Get
        Set(value As Long)
            _id_cabina = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property Dia As Integer
        Get
            Return _dia
        End Get
        Set(value As Integer)
            _dia = value
        End Set
    End Property
End Class
