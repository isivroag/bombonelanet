Public Class c_gasto
    Private _id_gasto As Integer
    Private _fecha As Date
    Private _facturado As Boolean
    Private _referencia As String
    Private _concepto As String
    Private _monto As Double

    Public Property Id_gasto As Integer
        Get
            Return _id_gasto
        End Get
        Set(value As Integer)
            _id_gasto = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Facturado As Boolean
        Get
            Return _facturado
        End Get
        Set(value As Boolean)
            _facturado = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _referencia
        End Get
        Set(value As String)
            _referencia = value
        End Set
    End Property

    Public Property Concepto As String
        Get
            Return _concepto
        End Get
        Set(value As String)
            _concepto = value
        End Set
    End Property

    Public Property Monto As Double
        Get
            Return _monto
        End Get
        Set(value As Double)
            _monto = value
        End Set
    End Property
End Class
