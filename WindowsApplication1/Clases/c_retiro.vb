Public Class c_retiro

    Private _id_retiro As Integer
    Private _fecha As Date
    Private _monto As Double
    Private _montoant As Double
    Private _montodesp As Double
    Private _fechaop As DateTime
    Public Property Id_retiro As Integer
        Get
            Return _id_retiro
        End Get
        Set(value As Integer)
            _id_retiro = value
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

    Public Property Monto As Double
        Get
            Return _monto
        End Get
        Set(value As Double)
            _monto = value
        End Set
    End Property

    Public Property Fechaop As Date
        Get
            Return _fechaop
        End Get
        Set(value As Date)
            _fechaop = value
        End Set
    End Property

    Public Property Montoant As Double
        Get
            Return _montoant
        End Get
        Set(value As Double)
            _montoant = value
        End Set
    End Property

    Public Property Montodesp As Double
        Get
            Return _montodesp
        End Get
        Set(value As Double)
            _montodesp = value
        End Set
    End Property
End Class
