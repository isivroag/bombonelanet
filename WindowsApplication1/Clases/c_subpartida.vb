Public Class c_subpartida
    Private _id_subpartida As Int64
    Private _id_partida As Int64
    Private _nom_subpartida As String
    Private _estado_subpartida As Boolean

    Public Property Id_subpartida As Long
        Get
            Return _id_subpartida
        End Get
        Set(value As Long)
            _id_subpartida = value
        End Set
    End Property

    Public Property Id_partida As Long
        Get
            Return _id_partida
        End Get
        Set(value As Long)
            _id_partida = value
        End Set
    End Property

    Public Property Nom_subpartida As String
        Get
            Return _nom_subpartida
        End Get
        Set(value As String)
            _nom_subpartida = value
        End Set
    End Property

    Public Property Estado_subpartida As Boolean
        Get
            Return _estado_subpartida
        End Get
        Set(value As Boolean)
            _estado_subpartida = value
        End Set
    End Property
End Class
