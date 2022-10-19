<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tcol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tcalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tedo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trfc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.thijos = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tinsta = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ttw = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tfb = New System.Windows.Forms.TextBox()
        Me.lhijos = New System.Windows.Forms.Label()
        Me.dtaniv = New System.Windows.Forms.DateTimePicker()
        Me.laniv = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tocupacion = New System.Windows.Forms.TextBox()
        Me.cnivel = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cestado = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cgenero = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tpiel = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tpelo = New System.Windows.Forms.TextBox()
        Me.tojos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tcp = New System.Windows.Forms.MaskedTextBox()
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.tnac = New System.Windows.Forms.DateTimePicker()
        Me.tnumid = New System.Windows.Forms.TextBox()
        Me.ttipoid = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(822, 48)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bguardar
        '
        Me.bguardar.BackColor = System.Drawing.Color.White
        Me.bguardar.Image = Global.Bombonela.My.Resources.Resources.save_26
        Me.bguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(65, 45)
        Me.bguardar.Text = "GUARDAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.BackColor = System.Drawing.Color.White
        Me.bcancelar.Image = Global.Bombonela.My.Resources.Resources.undo_26
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(71, 45)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(472, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CORREO ELECTRONICO"
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(486, 193)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(273, 20)
        Me.temail.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(253, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "TEL FIJO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*TEL MOVIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "COLONIA"
        '
        'tcol
        '
        Me.tcol.Location = New System.Drawing.Point(50, 152)
        Me.tcol.Name = "tcol"
        Me.tcol.Size = New System.Drawing.Size(190, 20)
        Me.tcol.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CALLE"
        '
        'tcalle
        '
        Me.tcalle.Location = New System.Drawing.Point(52, 112)
        Me.tcalle.Name = "tcalle"
        Me.tcalle.Size = New System.Drawing.Size(407, 20)
        Me.tcalle.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(472, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ESTADO"
        '
        'tedo
        '
        Me.tedo.Location = New System.Drawing.Point(486, 152)
        Me.tedo.Name = "tedo"
        Me.tedo.Size = New System.Drawing.Size(273, 20)
        Me.tedo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "MUNICIPIO"
        '
        'tmun
        '
        Me.tmun.Location = New System.Drawing.Point(271, 152)
        Me.tmun.Name = "tmun"
        Me.tmun.Size = New System.Drawing.Size(188, 20)
        Me.tmun.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "*NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(52, 70)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(407, 20)
        Me.tnombre.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RFC"
        '
        'trfc
        '
        Me.trfc.Location = New System.Drawing.Point(337, 27)
        Me.trfc.Name = "trfc"
        Me.trfc.Size = New System.Drawing.Size(122, 20)
        Me.trfc.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLAVE DE CLIENTE"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(52, 25)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.thijos)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.tinsta)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.ttw)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.tfb)
        Me.Panel1.Controls.Add(Me.lhijos)
        Me.Panel1.Controls.Add(Me.dtaniv)
        Me.Panel1.Controls.Add(Me.laniv)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.tocupacion)
        Me.Panel1.Controls.Add(Me.cnivel)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.cestado)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.cgenero)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.tpiel)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.tpelo)
        Me.Panel1.Controls.Add(Me.tojos)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.tcp)
        Me.Panel1.Controls.Add(Me.ttel)
        Me.Panel1.Controls.Add(Me.tcel)
        Me.Panel1.Controls.Add(Me.trfc)
        Me.Panel1.Controls.Add(Me.tnac)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tnumid)
        Me.Panel1.Controls.Add(Me.ttipoid)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.tnum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.temail)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tcol)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tcalle)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tedo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tmun)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid)
        Me.Panel1.Location = New System.Drawing.Point(18, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 357)
        Me.Panel1.TabIndex = 2
        '
        'thijos
        '
        Me.thijos.FormattingEnabled = True
        Me.thijos.Items.AddRange(New Object() {"SI", "NO"})
        Me.thijos.Location = New System.Drawing.Point(410, 312)
        Me.thijos.Name = "thijos"
        Me.thijos.Size = New System.Drawing.Size(49, 21)
        Me.thijos.TabIndex = 53
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(472, 258)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 13)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "INSTAGRAM"
        '
        'tinsta
        '
        Me.tinsta.Location = New System.Drawing.Point(486, 274)
        Me.tinsta.Name = "tinsta"
        Me.tinsta.Size = New System.Drawing.Size(273, 20)
        Me.tinsta.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(264, 258)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 13)
        Me.Label25.TabIndex = 43
        Me.Label25.Text = "TWITTER"
        '
        'ttw
        '
        Me.ttw.Location = New System.Drawing.Point(271, 274)
        Me.ttw.Name = "ttw"
        Me.ttw.Size = New System.Drawing.Size(188, 20)
        Me.ttw.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 258)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "FACEBOOK"
        '
        'tfb
        '
        Me.tfb.Location = New System.Drawing.Point(50, 274)
        Me.tfb.Name = "tfb"
        Me.tfb.Size = New System.Drawing.Size(190, 20)
        Me.tfb.TabIndex = 45
        '
        'lhijos
        '
        Me.lhijos.AutoSize = True
        Me.lhijos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhijos.Location = New System.Drawing.Point(407, 297)
        Me.lhijos.Name = "lhijos"
        Me.lhijos.Size = New System.Drawing.Size(37, 13)
        Me.lhijos.TabIndex = 50
        Me.lhijos.Text = "HIJOS"
        '
        'dtaniv
        '
        Me.dtaniv.CustomFormat = "yyyy-MM-dd"
        Me.dtaniv.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtaniv.Location = New System.Drawing.Point(273, 313)
        Me.dtaniv.Name = "dtaniv"
        Me.dtaniv.Size = New System.Drawing.Size(119, 20)
        Me.dtaniv.TabIndex = 52
        Me.dtaniv.Value = New Date(2019, 2, 13, 0, 0, 0, 0)
        '
        'laniv
        '
        Me.laniv.AutoSize = True
        Me.laniv.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laniv.Location = New System.Drawing.Point(253, 297)
        Me.laniv.Name = "laniv"
        Me.laniv.Size = New System.Drawing.Size(117, 13)
        Me.laniv.TabIndex = 49
        Me.laniv.Text = "FECHA ANIVERSARIO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(253, 217)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "OCUPACION"
        '
        'tocupacion
        '
        Me.tocupacion.Location = New System.Drawing.Point(271, 233)
        Me.tocupacion.Name = "tocupacion"
        Me.tocupacion.Size = New System.Drawing.Size(188, 20)
        Me.tocupacion.TabIndex = 39
        '
        'cnivel
        '
        Me.cnivel.FormattingEnabled = True
        Me.cnivel.Items.AddRange(New Object() {"PRIMARIA", "SECUNDARIA", "PREPARATORIA", "LICENCIATURA", "POSTGRADO", "OTRO"})
        Me.cnivel.Location = New System.Drawing.Point(50, 232)
        Me.cnivel.Name = "cnivel"
        Me.cnivel.Size = New System.Drawing.Size(191, 21)
        Me.cnivel.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 216)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "NIVEL DE ESTUDIOS"
        '
        'cestado
        '
        Me.cestado.FormattingEnabled = True
        Me.cestado.Items.AddRange(New Object() {"SOLTERA(O)", "CASADA(O)", "DIVORCIADA(O)", "VIUDA(O)", "OTRO"})
        Me.cestado.Location = New System.Drawing.Point(54, 313)
        Me.cestado.Name = "cestado"
        Me.cestado.Size = New System.Drawing.Size(187, 21)
        Me.cestado.TabIndex = 51
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 297)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "ESTADO CIVIL"
        '
        'cgenero
        '
        Me.cgenero.FormattingEnabled = True
        Me.cgenero.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cgenero.Location = New System.Drawing.Point(486, 70)
        Me.cgenero.Name = "cgenero"
        Me.cgenero.Size = New System.Drawing.Size(125, 21)
        Me.cgenero.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(472, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "GENERO"
        '
        'tpiel
        '
        Me.tpiel.FormattingEnabled = True
        Me.tpiel.Items.AddRange(New Object() {"TIPO I", "TIPO II", "TIPO III", "TIPO IV", "TIPO V", "TIPO VI"})
        Me.tpiel.Location = New System.Drawing.Point(685, 231)
        Me.tpiel.Name = "tpiel"
        Me.tpiel.Size = New System.Drawing.Size(74, 21)
        Me.tpiel.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(668, 217)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "TIPO DE PIEL"
        '
        'tpelo
        '
        Me.tpelo.Location = New System.Drawing.Point(587, 233)
        Me.tpelo.Name = "tpelo"
        Me.tpelo.Size = New System.Drawing.Size(76, 20)
        Me.tpelo.TabIndex = 41
        '
        'tojos
        '
        Me.tojos.Location = New System.Drawing.Point(486, 233)
        Me.tojos.Name = "tojos"
        Me.tojos.Size = New System.Drawing.Size(76, 20)
        Me.tojos.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(571, 216)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "COL. CABELLO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(472, 217)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "COLOR DE OJOS"
        '
        'tcp
        '
        Me.tcp.Location = New System.Drawing.Point(634, 112)
        Me.tcp.Mask = "99999"
        Me.tcp.Name = "tcp"
        Me.tcp.Size = New System.Drawing.Size(125, 20)
        Me.tcp.TabIndex = 19
        Me.tcp.ValidatingType = GetType(Integer)
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(273, 191)
        Me.ttel.Mask = "(999)0000000"
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(186, 20)
        Me.ttel.TabIndex = 29
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(52, 193)
        Me.tcel.Mask = "(999)0000000"
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(189, 20)
        Me.tcel.TabIndex = 30
        '
        'tnac
        '
        Me.tnac.CustomFormat = "yyyy-MM-dd"
        Me.tnac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tnac.Location = New System.Drawing.Point(634, 71)
        Me.tnac.Name = "tnac"
        Me.tnac.Size = New System.Drawing.Size(125, 20)
        Me.tnac.TabIndex = 13
        Me.tnac.Value = New Date(2019, 2, 13, 0, 0, 0, 0)
        '
        'tnumid
        '
        Me.tnumid.Location = New System.Drawing.Point(634, 30)
        Me.tnumid.Name = "tnumid"
        Me.tnumid.Size = New System.Drawing.Size(125, 20)
        Me.tnumid.TabIndex = 7
        '
        'ttipoid
        '
        Me.ttipoid.Location = New System.Drawing.Point(485, 27)
        Me.ttipoid.Name = "ttipoid"
        Me.ttipoid.Size = New System.Drawing.Size(125, 20)
        Me.ttipoid.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(620, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "NUMERO ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(472, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "TIPO ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(620, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "FECHA NAC."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(472, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "NUMERO"
        '
        'tnum
        '
        Me.tnum.Location = New System.Drawing.Point(486, 112)
        Me.tnum.Name = "tnum"
        Me.tnum.Size = New System.Drawing.Size(124, 20)
        Me.tnum.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VISITANTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(822, 459)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcliente"
        Me.Text = "frmcliente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents Label12 As Label
    Friend WithEvents temail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tcol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tcalle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tedo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tmun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents trfc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tnum As TextBox
    Friend WithEvents tnac As DateTimePicker
    Friend WithEvents tnumid As TextBox
    Friend WithEvents ttipoid As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tcp As MaskedTextBox
    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents tpiel As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tpelo As TextBox
    Friend WithEvents tojos As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lhijos As Label
    Friend WithEvents dtaniv As DateTimePicker
    Friend WithEvents laniv As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tocupacion As TextBox
    Friend WithEvents cnivel As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cestado As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cgenero As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tinsta As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents ttw As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tfb As TextBox
    Friend WithEvents thijos As ComboBox
End Class
