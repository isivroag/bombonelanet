Public Class c_wcliente
    Private _id_clie As Int64
    Private _gen_clie As String
    Private _rfc_clie As String
    Private _curp_clie As String
    Private _nom_clie As String
    Private _dir_clie As String

    Private _tel_clie As String
    Private _ws_clie As String
    Private _correo_clie As String
    Private _ocupacion_clie As String
    Private _nac_clie As Date
    Private _niv_clie As String

    Private _ecivil_clie As String
    Private _alta_clie As Date

    Private _estado_clie As Boolean
    Private _medio_clie As String

    Public Property Id_clie As Long
        Get
            Return _id_clie
        End Get
        Set(value As Long)
            _id_clie = value
        End Set
    End Property

    Public Property Gen_clie As String
        Get
            Return _gen_clie
        End Get
        Set(value As String)
            _gen_clie = value
        End Set
    End Property

    Public Property Rfc_clie As String
        Get
            Return _rfc_clie
        End Get
        Set(value As String)
            _rfc_clie = value
        End Set
    End Property

    Public Property Curp_clie As String
        Get
            Return _curp_clie
        End Get
        Set(value As String)
            _curp_clie = value
        End Set
    End Property

    Public Property Nom_clie As String
        Get
            Return _nom_clie
        End Get
        Set(value As String)
            _nom_clie = value
        End Set
    End Property

    Public Property Dir_clie As String
        Get
            Return _dir_clie
        End Get
        Set(value As String)
            _dir_clie = value
        End Set
    End Property

    Public Property Tel_clie As String
        Get
            Return _tel_clie
        End Get
        Set(value As String)
            _tel_clie = value
        End Set
    End Property

    Public Property Ws_clie As String
        Get
            Return _ws_clie
        End Get
        Set(value As String)
            _ws_clie = value
        End Set
    End Property

    Public Property Correo_clie As String
        Get
            Return _correo_clie
        End Get
        Set(value As String)
            _correo_clie = value
        End Set
    End Property

    Public Property Ocupacion_clie As String
        Get
            Return _ocupacion_clie
        End Get
        Set(value As String)
            _ocupacion_clie = value
        End Set
    End Property

    Public Property Nac_clie As Date
        Get
            Return _nac_clie
        End Get
        Set(value As Date)
            _nac_clie = value
        End Set
    End Property

    Public Property Niv_clie As String
        Get
            Return _niv_clie
        End Get
        Set(value As String)
            _niv_clie = value
        End Set
    End Property

    Public Property Ecivil_clie As String
        Get
            Return _ecivil_clie
        End Get
        Set(value As String)
            _ecivil_clie = value
        End Set
    End Property

    Public Property Alta_clie As Date
        Get
            Return _alta_clie
        End Get
        Set(value As Date)
            _alta_clie = value
        End Set
    End Property

    Public Property Estado_clie As Boolean
        Get
            Return _estado_clie
        End Get
        Set(value As Boolean)
            _estado_clie = value
        End Set
    End Property

    Public Property Medio_clie As String
        Get
            Return _medio_clie
        End Get
        Set(value As String)
            _medio_clie = value
        End Set
    End Property
End Class
