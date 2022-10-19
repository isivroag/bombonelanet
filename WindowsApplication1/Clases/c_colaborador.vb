Public Class c_colaborador
    Private _id_col As Integer
    Private _nom_col As String
    Private _dir_col As String
    Private _tel_col As String
    Private _cel_col As String
    Private _correo_col As String
    Private _id_puesto As Integer
    Private _alta_col As Date
    Private _estado_col As Boolean

    Public Property Id_col As Integer
        Get
            Return _id_col
        End Get
        Set(value As Integer)
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

    Public Property Dir_col As String
        Get
            Return _dir_col
        End Get
        Set(value As String)
            _dir_col = value
        End Set
    End Property

    Public Property Tel_col As String
        Get
            Return _tel_col
        End Get
        Set(value As String)
            _tel_col = value
        End Set
    End Property

    Public Property Cel_col As String
        Get
            Return _cel_col
        End Get
        Set(value As String)
            _cel_col = value
        End Set
    End Property

    Public Property Correo_col As String
        Get
            Return _correo_col
        End Get
        Set(value As String)
            _correo_col = value
        End Set
    End Property

    Public Property Id_puesto As Integer
        Get
            Return _id_puesto
        End Get
        Set(value As Integer)
            _id_puesto = value
        End Set
    End Property

    Public Property Alta_col As Date
        Get
            Return _alta_col
        End Get
        Set(value As Date)
            _alta_col = value
        End Set
    End Property

    Public Property Estado_col As Boolean
        Get
            Return _estado_col
        End Get
        Set(value As Boolean)
            _estado_col = value
        End Set
    End Property
End Class
