Public Class c_cabina
    Private _id_cabina As Integer
    Private _nom_cabina As String
    Private _estado_cabina As Boolean
    Private _color_cabina As String

    Public Property Id_cabina As Integer
        Get
            Return _id_cabina
        End Get
        Set(value As Integer)
            _id_cabina = value
        End Set
    End Property

    Public Property Nom_cabina As String
        Get
            Return _nom_cabina
        End Get
        Set(value As String)
            _nom_cabina = value
        End Set
    End Property

    Public Property Estado_cabina As Boolean
        Get
            Return _estado_cabina
        End Get
        Set(value As Boolean)
            _estado_cabina = value
        End Set
    End Property

    Public Property Color_cabina As String
        Get
            Return _color_cabina
        End Get
        Set(value As String)
            _color_cabina = value
        End Set

    End Property
End Class
