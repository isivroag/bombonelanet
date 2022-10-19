Public Class c_historia
    Private _id_clie As Int64
    Private _id_his As Int64
    Private _fecha_his As Date
    Private _atendio_his As String
    Private _emb_his As String
    Private _lact_his As String
    Private _dep_his As String
    Private _metdep_his As String
    Private _bron_his As String
    Private _metbron_his As String
    Private _queloides_his As Boolean
    Private _hormonas_his As Boolean
    Private _cutaneas_his As Boolean
    Private _descuetaneas_his As String
    Private _vello_his As Boolean
    Private _desvello As String
    Private _epilepsia_his As Boolean
    Private _tatuajes_his As Boolean
    Private _zonatatu_his As String
    Private _sangre_his As Boolean
    Private _dessangre_his As String
    Private _herpes_his As Boolean
    Private _zovirax_his As String
    Private _alergias_his As Boolean
    Private _desalergias_his As String
    Private _dispositivo_his As Boolean
    Private _desdispositivo_his As String
    Private _medicacion_his As String

    Public Property Id_clie As Long
        Get
            Return _id_clie
        End Get
        Set(value As Long)
            _id_clie = value
        End Set
    End Property

    Public Property Id_his As Long
        Get
            Return _id_his
        End Get
        Set(value As Long)
            _id_his = value
        End Set
    End Property

    Public Property Fecha_his As Date
        Get
            Return _fecha_his
        End Get
        Set(value As Date)
            _fecha_his = value
        End Set
    End Property

    Public Property Atendio_his As String
        Get
            Return _atendio_his
        End Get
        Set(value As String)
            _atendio_his = value
        End Set
    End Property

    Public Property Emb_his As String
        Get
            Return _emb_his
        End Get
        Set(value As String)
            _emb_his = value
        End Set
    End Property

    Public Property Lact_his As String
        Get
            Return _lact_his
        End Get
        Set(value As String)
            _lact_his = value
        End Set
    End Property

    Public Property Dep_his As String
        Get
            Return _dep_his
        End Get
        Set(value As String)
            _dep_his = value
        End Set
    End Property

    Public Property Metdep_his As String
        Get
            Return _metdep_his
        End Get
        Set(value As String)
            _metdep_his = value
        End Set
    End Property

    Public Property Bron_his As String
        Get
            Return _bron_his
        End Get
        Set(value As String)
            _bron_his = value
        End Set
    End Property

    Public Property Metbron_his As String
        Get
            Return _metbron_his
        End Get
        Set(value As String)
            _metbron_his = value
        End Set
    End Property

    Public Property Queloides_his As Boolean
        Get
            Return _queloides_his
        End Get
        Set(value As Boolean)
            _queloides_his = value
        End Set
    End Property

    Public Property Hormonas_his As Boolean
        Get
            Return _hormonas_his
        End Get
        Set(value As Boolean)
            _hormonas_his = value
        End Set
    End Property

    Public Property Cutaneas_his As Boolean
        Get
            Return _cutaneas_his
        End Get
        Set(value As Boolean)
            _cutaneas_his = value
        End Set
    End Property

    Public Property Descuetaneas_his As String
        Get
            Return _descuetaneas_his
        End Get
        Set(value As String)
            _descuetaneas_his = value
        End Set
    End Property

    Public Property Vello_his As Boolean
        Get
            Return _vello_his
        End Get
        Set(value As Boolean)
            _vello_his = value
        End Set
    End Property

    Public Property Desvello As String
        Get
            Return _desvello
        End Get
        Set(value As String)
            _desvello = value
        End Set
    End Property

    Public Property Epilepsia_his As Boolean
        Get
            Return _epilepsia_his
        End Get
        Set(value As Boolean)
            _epilepsia_his = value
        End Set
    End Property

    Public Property Tatuajes_his As Boolean
        Get
            Return _tatuajes_his
        End Get
        Set(value As Boolean)
            _tatuajes_his = value
        End Set
    End Property

    Public Property Zonatatu_his As String
        Get
            Return _zonatatu_his
        End Get
        Set(value As String)
            _zonatatu_his = value
        End Set
    End Property

    Public Property Sangre_his As Boolean
        Get
            Return _sangre_his
        End Get
        Set(value As Boolean)
            _sangre_his = value
        End Set
    End Property

    Public Property Dessangre_his As String
        Get
            Return _dessangre_his
        End Get
        Set(value As String)
            _dessangre_his = value
        End Set
    End Property

    Public Property Herpes_his As Boolean
        Get
            Return _herpes_his
        End Get
        Set(value As Boolean)
            _herpes_his = value
        End Set
    End Property

    Public Property Zovirax_his As String
        Get
            Return _zovirax_his
        End Get
        Set(value As String)
            _zovirax_his = value
        End Set
    End Property

    Public Property Alergias_his As Boolean
        Get
            Return _alergias_his
        End Get
        Set(value As Boolean)
            _alergias_his = value
        End Set
    End Property

    Public Property Desalergias_his As String
        Get
            Return _desalergias_his
        End Get
        Set(value As String)
            _desalergias_his = value
        End Set
    End Property

    Public Property Dispositivo_his As Boolean
        Get
            Return _dispositivo_his
        End Get
        Set(value As Boolean)
            _dispositivo_his = value
        End Set
    End Property

    Public Property Desdispositivo_his As String
        Get
            Return _desdispositivo_his
        End Get
        Set(value As String)
            _desdispositivo_his = value
        End Set
    End Property

    Public Property Medicacion_his As String
        Get
            Return _medicacion_his
        End Get
        Set(value As String)
            _medicacion_his = value
        End Set
    End Property
End Class
