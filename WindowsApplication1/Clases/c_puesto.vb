Public Class c_puesto
    Private _id_puesto As Integer
    Private _nom_puesto As String
    Private _estado_puesto As Boolean

    Public Property Id_puesto As Integer
        Get
            Return _id_puesto
        End Get
        Set(value As Integer)
            _id_puesto = value
        End Set
    End Property

    Public Property Nom_puesto As String
        Get
            Return _nom_puesto
        End Get
        Set(value As String)
            _nom_puesto = value
        End Set
    End Property

    Public Property Estado_puesto As Boolean
        Get
            Return _estado_puesto
        End Get
        Set(value As Boolean)
            _estado_puesto = value
        End Set
    End Property
End Class
