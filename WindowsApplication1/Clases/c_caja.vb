Public Class c_caja
    Private _id_caja As Integer
    Private _fecha As Date
    Private _inicial As Double
    Private _efectivo As Double
    Private _deposito As Double
    Private _transferencia As Double
    Private _tcredito As Double
    Private _tdebito As Double
    Private _amex As Double
    Private _otros As Double
    Private _gastos As Double
    Private _retiros As Double
    Private _final As Double

    Public Property Id_caja As Integer
        Get
            Return _id_caja
        End Get
        Set(value As Integer)
            _id_caja = value
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

    Public Property Inicial As Double
        Get
            Return _inicial
        End Get
        Set(value As Double)
            _inicial = value
        End Set
    End Property

    Public Property Efectivo As Double
        Get
            Return _efectivo
        End Get
        Set(value As Double)
            _efectivo = value
        End Set
    End Property

    Public Property Deposito As Double
        Get
            Return _deposito
        End Get
        Set(value As Double)
            _deposito = value
        End Set
    End Property

    Public Property Transferencia As Double
        Get
            Return _transferencia
        End Get
        Set(value As Double)
            _transferencia = value
        End Set
    End Property

    Public Property Tcredito As Double
        Get
            Return _tcredito
        End Get
        Set(value As Double)
            _tcredito = value
        End Set
    End Property

    Public Property Tdebito As Double
        Get
            Return _tdebito
        End Get
        Set(value As Double)
            _tdebito = value
        End Set
    End Property

    Public Property Amex As Double
        Get
            Return _amex
        End Get
        Set(value As Double)
            _amex = value
        End Set
    End Property

    Public Property Otros As Double
        Get
            Return _otros
        End Get
        Set(value As Double)
            _otros = value
        End Set
    End Property

    Public Property Gastos As Double
        Get
            Return _gastos
        End Get
        Set(value As Double)
            _gastos = value
        End Set
    End Property

    Public Property Retiros As Double
        Get
            Return _retiros
        End Get
        Set(value As Double)
            _retiros = value
        End Set
    End Property

    Public Property Final As Double
        Get
            Return _final
        End Get
        Set(value As Double)
            _final = value
        End Set
    End Property
End Class
