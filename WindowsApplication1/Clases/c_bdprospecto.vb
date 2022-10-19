Public Class c_bdprospecto
    Private _id As Int64
    Private _nombre As String
    Private _calle As String
    Private _num As String
    Private _col As String
    Private _mun As String
    Private _edo As String
    Private _cdp As String
    Private _tel As String
    Private _cel As String
    Private _correo As String
    Private _fecha As String
    Private _genero As String
    Private _fototipo As String
    Private _conocio As String

    Public Property Id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _calle
        End Get
        Set(value As String)
            _calle = value
        End Set
    End Property

    Public Property Num As String
        Get
            Return _num
        End Get
        Set(value As String)
            _num = value
        End Set
    End Property

    Public Property Col As String
        Get
            Return _col
        End Get
        Set(value As String)
            _col = value
        End Set
    End Property

    Public Property Mun As String
        Get
            Return _mun
        End Get
        Set(value As String)
            _mun = value
        End Set
    End Property

    Public Property Edo As String
        Get
            Return _edo
        End Get
        Set(value As String)
            _edo = value
        End Set
    End Property

    Public Property Cdp As String
        Get
            Return _cdp
        End Get
        Set(value As String)
            _cdp = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property

    Public Property Cel As String
        Get
            Return _cel
        End Get
        Set(value As String)
            _cel = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property

    Public Property Fototipo As String
        Get
            Return _fototipo
        End Get
        Set(value As String)
            _fototipo = value
        End Set
    End Property

    Public Property Conocio As String
        Get
            Return _conocio
        End Get
        Set(value As String)
            _conocio = value
        End Set
    End Property
End Class
