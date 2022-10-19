Public Class c_marca
    Private _id_marca As Int64
    Private _nom_marca As String
    Private _estado_marca As Boolean

    Public Property Id_marca As Long
        Get
            Return _id_marca
        End Get
        Set(value As Long)
            _id_marca = value
        End Set
    End Property

    Public Property Nom_marca As String
        Get
            Return _nom_marca
        End Get
        Set(value As String)
            _nom_marca = value
        End Set
    End Property

    Public Property Estado_marca As Boolean
        Get
            Return _estado_marca
        End Get
        Set(value As Boolean)
            _estado_marca = value
        End Set
    End Property
End Class
