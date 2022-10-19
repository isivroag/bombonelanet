Public Class c_paquete_cont
    Private _id_cont As Int64
    Private _id_clie As Int64
    Private _id_serv As Int64
    Private _id_pqt As Int64
    Private _numero_s As Double
    Private _restante_s As Double
    Private _fecha_ini As Date
    Private _fecha_max As Date
    Private _id_col As Int64
    Private _nom_col As String
    Private _precio As Double
    Private _saldo As Double
    Private _pagado As Double
    Private _estado_serv As String
    Private _estado As Boolean

    Public Property Id_cont As Long
        Get
            Return _id_cont
        End Get
        Set(value As Long)
            _id_cont = value
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

    Public Property Id_serv As Long
        Get
            Return _id_serv
        End Get
        Set(value As Long)
            _id_serv = value
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

    Public Property Numero_s As Double
        Get
            Return _numero_s
        End Get
        Set(value As Double)
            _numero_s = value
        End Set
    End Property

    Public Property Restante_s As Double
        Get
            Return _restante_s
        End Get
        Set(value As Double)
            _restante_s = value
        End Set
    End Property

    Public Property Fecha_ini As Date
        Get
            Return _fecha_ini
        End Get
        Set(value As Date)
            _fecha_ini = value
        End Set
    End Property

    Public Property Fecha_max As Date
        Get
            Return _fecha_max
        End Get
        Set(value As Date)
            _fecha_max = value
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

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property

    Public Property Pagado As Double
        Get
            Return _pagado
        End Get
        Set(value As Double)
            _pagado = value
        End Set
    End Property

    Public Property Estado_serv As String
        Get
            Return _estado_serv
        End Get
        Set(value As String)
            _estado_serv = value
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
End Class
