Public Class c_partida

    Private _id_partida As Int64
    Private _nom_partida As String
    Private _estado_partida As Boolean

    Public Property Id_partida As Long
        Get
            Return _id_partida
        End Get
        Set(value As Long)
            _id_partida = value
        End Set
    End Property

    Public Property Nom_partida As String
        Get
            Return _nom_partida
        End Get
        Set(value As String)
            _nom_partida = value
        End Set
    End Property

    Public Property Estado_partida As Boolean
        Get
            Return _estado_partida
        End Get
        Set(value As Boolean)
            _estado_partida = value
        End Set
    End Property
End Class
