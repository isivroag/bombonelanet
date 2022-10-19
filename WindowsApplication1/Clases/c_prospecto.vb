Public Class c_prospecto
    Private _id_pros As Integer
    Private _nom_pros As String
    Private _cel_pros As String
    Private _tel_pros As String
    Private _correo_pros As String
    Private _alta_pros As Date
    Private _estado_pros As Boolean

    Public Property Id_pros As Integer
        Get
            Return _id_pros
        End Get
        Set(value As Integer)
            _id_pros = value
        End Set
    End Property

    Public Property Nom_pros As String
        Get
            Return _nom_pros
        End Get
        Set(value As String)
            _nom_pros = value
        End Set
    End Property

    Public Property Cel_pros As String
        Get
            Return _cel_pros
        End Get
        Set(value As String)
            _cel_pros = value
        End Set
    End Property

    Public Property Tel_pros As String
        Get
            Return _tel_pros
        End Get
        Set(value As String)
            _tel_pros = value
        End Set
    End Property

    Public Property Correo_pros As String
        Get
            Return _correo_pros
        End Get
        Set(value As String)
            _correo_pros = value
        End Set
    End Property

    Public Property Alta_pros As Date
        Get
            Return _alta_pros
        End Get
        Set(value As Date)
            _alta_pros = value
        End Set
    End Property

    Public Property Estado_pros As Boolean
        Get
            Return _estado_pros
        End Get
        Set(value As Boolean)
            _estado_pros = value
        End Set
    End Property
End Class
