<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mncatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNCATPROD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNCATSERV = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMNMARCA = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONFIGURACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMNCABINAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMNALMACENES = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnprospectos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROSPECTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLABORADORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PUESTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnccalendario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrecepcion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mninventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncobranza = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncxc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnreportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncventadet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncventadetpago = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncingresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mncinventarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnctickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnccumple = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnhistorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnabrircaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mngastocaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnretirocaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnreportecaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mntools = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMNPRIINVENT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mngastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.submnproveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.submnpartida = New System.Windows.Forms.ToolStripMenuItem()
        Me.submnegresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tconsulta = New System.Windows.Forms.Timer(Me.components)
        Me.pimpresion = New System.Windows.Forms.Panel()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip.SuspendLayout()
        Me.pimpresion.SuspendLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncatalogos, Me.CONFIGURACIONESToolStripMenuItem, Me.mnprospectos, Me.mnccalendario, Me.mnrecepcion, Me.mnsalida, Me.mnventas, Me.mninventario, Me.mnsalir, Me.mncobranza, Me.mncxc, Me.mnreportes, Me.mnhistorial, Me.ToolStripMenuItem1, Me.mntools, Me.mngastos, Me.ToolStripMenuItem2})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1370, 39)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mncatalogos
        '
        Me.mncatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNCATPROD, Me.MNCATSERV, Me.SUBMNMARCA, Me.TIPOSToolStripMenuItem})
        Me.mncatalogos.Image = Global.Bombonela.My.Resources.Resources.list16
        Me.mncatalogos.Name = "mncatalogos"
        Me.mncatalogos.Size = New System.Drawing.Size(85, 35)
        Me.mncatalogos.Text = "CATALOGOS"
        Me.mncatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MNCATPROD
        '
        Me.MNCATPROD.BackColor = System.Drawing.Color.White
        Me.MNCATPROD.Image = Global.Bombonela.My.Resources.Resources.tube_16
        Me.MNCATPROD.Name = "MNCATPROD"
        Me.MNCATPROD.Size = New System.Drawing.Size(141, 22)
        Me.MNCATPROD.Text = "PRODUCTOS"
        '
        'MNCATSERV
        '
        Me.MNCATSERV.BackColor = System.Drawing.Color.White
        Me.MNCATSERV.Image = Global.Bombonela.My.Resources.Resources.service16
        Me.MNCATSERV.Name = "MNCATSERV"
        Me.MNCATSERV.Size = New System.Drawing.Size(141, 22)
        Me.MNCATSERV.Text = "SERVICIOS"
        '
        'SUBMNMARCA
        '
        Me.SUBMNMARCA.BackColor = System.Drawing.Color.White
        Me.SUBMNMARCA.Image = Global.Bombonela.My.Resources.Resources.brand16
        Me.SUBMNMARCA.Name = "SUBMNMARCA"
        Me.SUBMNMARCA.Size = New System.Drawing.Size(141, 22)
        Me.SUBMNMARCA.Text = "MARCA"
        '
        'TIPOSToolStripMenuItem
        '
        Me.TIPOSToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.TIPOSToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.type16
        Me.TIPOSToolStripMenuItem.Name = "TIPOSToolStripMenuItem"
        Me.TIPOSToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.TIPOSToolStripMenuItem.Text = "TIPOS"
        '
        'CONFIGURACIONESToolStripMenuItem
        '
        Me.CONFIGURACIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUBMNCABINAS, Me.SUBMNALMACENES})
        Me.CONFIGURACIONESToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.home16
        Me.CONFIGURACIONESToolStripMenuItem.Name = "CONFIGURACIONESToolStripMenuItem"
        Me.CONFIGURACIONESToolStripMenuItem.Size = New System.Drawing.Size(114, 35)
        Me.CONFIGURACIONESToolStripMenuItem.Text = "CONFIGURACION"
        Me.CONFIGURACIONESToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SUBMNCABINAS
        '
        Me.SUBMNCABINAS.BackColor = System.Drawing.Color.White
        Me.SUBMNCABINAS.Image = Global.Bombonela.My.Resources.Resources.cab16
        Me.SUBMNCABINAS.Name = "SUBMNCABINAS"
        Me.SUBMNCABINAS.Size = New System.Drawing.Size(142, 22)
        Me.SUBMNCABINAS.Text = "AREAS"
        '
        'SUBMNALMACENES
        '
        Me.SUBMNALMACENES.BackColor = System.Drawing.Color.White
        Me.SUBMNALMACENES.Image = Global.Bombonela.My.Resources.Resources.stock16
        Me.SUBMNALMACENES.Name = "SUBMNALMACENES"
        Me.SUBMNALMACENES.Size = New System.Drawing.Size(142, 22)
        Me.SUBMNALMACENES.Text = "ALMACENES"
        '
        'mnprospectos
        '
        Me.mnprospectos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROSPECTOSToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.COLABORADORESToolStripMenuItem, Me.PUESTOSToolStripMenuItem})
        Me.mnprospectos.Image = Global.Bombonela.My.Resources.Resources.personas16
        Me.mnprospectos.Name = "mnprospectos"
        Me.mnprospectos.Size = New System.Drawing.Size(77, 35)
        Me.mnprospectos.Text = "PERSONAS"
        Me.mnprospectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PROSPECTOSToolStripMenuItem
        '
        Me.PROSPECTOSToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.pros16
        Me.PROSPECTOSToolStripMenuItem.Name = "PROSPECTOSToolStripMenuItem"
        Me.PROSPECTOSToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PROSPECTOSToolStripMenuItem.Text = "PROSPECTOS"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.clie16
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'COLABORADORESToolStripMenuItem
        '
        Me.COLABORADORESToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.personal16
        Me.COLABORADORESToolStripMenuItem.Name = "COLABORADORESToolStripMenuItem"
        Me.COLABORADORESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.COLABORADORESToolStripMenuItem.Text = "COLABORADORES"
        '
        'PUESTOSToolStripMenuItem
        '
        Me.PUESTOSToolStripMenuItem.Image = Global.Bombonela.My.Resources.Resources.puestos16
        Me.PUESTOSToolStripMenuItem.Name = "PUESTOSToolStripMenuItem"
        Me.PUESTOSToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PUESTOSToolStripMenuItem.Text = "PUESTOS"
        '
        'mnccalendario
        '
        Me.mnccalendario.Image = Global.Bombonela.My.Resources.Resources.CALENDAR16
        Me.mnccalendario.Name = "mnccalendario"
        Me.mnccalendario.Size = New System.Drawing.Size(91, 35)
        Me.mnccalendario.Text = "CALENDARIO"
        Me.mnccalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnrecepcion
        '
        Me.mnrecepcion.Image = Global.Bombonela.My.Resources.Resources.ENTRADA16
        Me.mnrecepcion.Name = "mnrecepcion"
        Me.mnrecepcion.Size = New System.Drawing.Size(82, 35)
        Me.mnrecepcion.Text = "RECEPCION"
        Me.mnrecepcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnsalida
        '
        Me.mnsalida.Image = Global.Bombonela.My.Resources.Resources.SALIDA16
        Me.mnsalida.Name = "mnsalida"
        Me.mnsalida.Size = New System.Drawing.Size(58, 35)
        Me.mnsalida.Text = "SALIDA"
        Me.mnsalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnventas
        '
        Me.mnventas.Image = Global.Bombonela.My.Resources.Resources.MONEY16
        Me.mnventas.Name = "mnventas"
        Me.mnventas.Size = New System.Drawing.Size(60, 35)
        Me.mnventas.Text = "VENTAS"
        Me.mnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mninventario
        '
        Me.mninventario.Image = Global.Bombonela.My.Resources.Resources.INVENTARIO16
        Me.mninventario.Name = "mninventario"
        Me.mninventario.Size = New System.Drawing.Size(85, 35)
        Me.mninventario.Text = "INVENTARIO"
        Me.mninventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnsalir
        '
        Me.mnsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnsalir.Image = Global.Bombonela.My.Resources.Resources.exit16
        Me.mnsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnsalir.Name = "mnsalir"
        Me.mnsalir.Size = New System.Drawing.Size(49, 35)
        Me.mnsalir.Text = "SALIR"
        Me.mnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncobranza
        '
        Me.mncobranza.Image = Global.Bombonela.My.Resources.Resources.COBRANZA16
        Me.mncobranza.Name = "mncobranza"
        Me.mncobranza.Size = New System.Drawing.Size(82, 35)
        Me.mncobranza.Text = "COBRANZA"
        Me.mncobranza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncxc
        '
        Me.mncxc.Image = Global.Bombonela.My.Resources.Resources.CREDIT16
        Me.mncxc.Name = "mncxc"
        Me.mncxc.Size = New System.Drawing.Size(42, 35)
        Me.mncxc.Text = "CXC"
        Me.mncxc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mncxc.Visible = False
        '
        'mnreportes
        '
        Me.mnreportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncventadet, Me.mncventadetpago, Me.mncingresos, Me.mncinventarios, Me.mnctickets, Me.mnccumple})
        Me.mnreportes.Image = Global.Bombonela.My.Resources.Resources.RPT16
        Me.mnreportes.Name = "mnreportes"
        Me.mnreportes.Size = New System.Drawing.Size(72, 35)
        Me.mnreportes.Text = "REPORTES"
        Me.mnreportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncventadet
        '
        Me.mncventadet.Image = Global.Bombonela.My.Resources.Resources.list1
        Me.mncventadet.Name = "mncventadet"
        Me.mncventadet.Size = New System.Drawing.Size(155, 22)
        Me.mncventadet.Text = "VTA-DETALLE"
        '
        'mncventadetpago
        '
        Me.mncventadetpago.Image = Global.Bombonela.My.Resources.Resources.list2
        Me.mncventadetpago.Name = "mncventadetpago"
        Me.mncventadetpago.Size = New System.Drawing.Size(155, 22)
        Me.mncventadetpago.Text = "VTA-DET-PAGO"
        '
        'mncingresos
        '
        Me.mncingresos.BackColor = System.Drawing.Color.White
        Me.mncingresos.Image = Global.Bombonela.My.Resources.Resources.REPORT16
        Me.mncingresos.Name = "mncingresos"
        Me.mncingresos.Size = New System.Drawing.Size(155, 22)
        Me.mncingresos.Text = "INGRESOS"
        '
        'mncinventarios
        '
        Me.mncinventarios.Image = Global.Bombonela.My.Resources.Resources.INVENTARIO16
        Me.mncinventarios.Name = "mncinventarios"
        Me.mncinventarios.Size = New System.Drawing.Size(155, 22)
        Me.mncinventarios.Text = "INVENTARIOS"
        '
        'mnctickets
        '
        Me.mnctickets.Image = Global.Bombonela.My.Resources.Resources.bill
        Me.mnctickets.Name = "mnctickets"
        Me.mnctickets.Size = New System.Drawing.Size(155, 22)
        Me.mnctickets.Text = "TICKETS"
        '
        'mnccumple
        '
        Me.mnccumple.Image = Global.Bombonela.My.Resources.Resources.CUMPLE
        Me.mnccumple.Name = "mnccumple"
        Me.mnccumple.Size = New System.Drawing.Size(155, 22)
        Me.mnccumple.Text = "CUMPLEAÑOS"
        '
        'mnhistorial
        '
        Me.mnhistorial.Image = Global.Bombonela.My.Resources.Resources.HISTORIA16
        Me.mnhistorial.Name = "mnhistorial"
        Me.mnhistorial.Size = New System.Drawing.Size(75, 35)
        Me.mnhistorial.Text = "HISTORIAL"
        Me.mnhistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnabrircaja, Me.mngastocaja, Me.mnretirocaja, Me.mnreportecaja})
        Me.ToolStripMenuItem1.Image = Global.Bombonela.My.Resources.Resources.cashbox
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 35)
        Me.ToolStripMenuItem1.Text = "CAJA"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnabrircaja
        '
        Me.mnabrircaja.Image = Global.Bombonela.My.Resources.Resources.OPEN
        Me.mnabrircaja.Name = "mnabrircaja"
        Me.mnabrircaja.Size = New System.Drawing.Size(179, 22)
        Me.mnabrircaja.Text = "APERTURA DE CAJA"
        '
        'mngastocaja
        '
        Me.mngastocaja.BackColor = System.Drawing.Color.White
        Me.mngastocaja.Image = Global.Bombonela.My.Resources.Resources.PAGOS
        Me.mngastocaja.Name = "mngastocaja"
        Me.mngastocaja.Size = New System.Drawing.Size(179, 22)
        Me.mngastocaja.Text = "GASTOS CAJA"
        '
        'mnretirocaja
        '
        Me.mnretirocaja.Image = Global.Bombonela.My.Resources.Resources.bank
        Me.mnretirocaja.Name = "mnretirocaja"
        Me.mnretirocaja.Size = New System.Drawing.Size(179, 22)
        Me.mnretirocaja.Text = "RETIROS DE CAJA"
        '
        'mnreportecaja
        '
        Me.mnreportecaja.Image = Global.Bombonela.My.Resources.Resources.RPTCAJA
        Me.mnreportecaja.Name = "mnreportecaja"
        Me.mnreportecaja.Size = New System.Drawing.Size(179, 22)
        Me.mnreportecaja.Text = "REPORTE DE CAJA"
        '
        'mntools
        '
        Me.mntools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUBMNPRIINVENT})
        Me.mntools.Name = "mntools"
        Me.mntools.Size = New System.Drawing.Size(54, 35)
        Me.mntools.Text = "TOOLS"
        Me.mntools.Visible = False
        '
        'SUBMNPRIINVENT
        '
        Me.SUBMNPRIINVENT.Name = "SUBMNPRIINVENT"
        Me.SUBMNPRIINVENT.Size = New System.Drawing.Size(184, 22)
        Me.SUBMNPRIINVENT.Text = "PRIMER INVENTARIO"
        '
        'mngastos
        '
        Me.mngastos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submnproveedor, Me.submnpartida, Me.submnegresos})
        Me.mngastos.Image = Global.Bombonela.My.Resources.Resources.gastos16
        Me.mngastos.Name = "mngastos"
        Me.mngastos.Size = New System.Drawing.Size(67, 35)
        Me.mngastos.Text = "EGRESOS"
        Me.mngastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'submnproveedor
        '
        Me.submnproveedor.Image = Global.Bombonela.My.Resources.Resources.prov16
        Me.submnproveedor.Name = "submnproveedor"
        Me.submnproveedor.Size = New System.Drawing.Size(152, 22)
        Me.submnproveedor.Text = "PROVEEDORES"
        '
        'submnpartida
        '
        Me.submnpartida.BackColor = System.Drawing.Color.White
        Me.submnpartida.Image = Global.Bombonela.My.Resources.Resources.partida16
        Me.submnpartida.Name = "submnpartida"
        Me.submnpartida.Size = New System.Drawing.Size(152, 22)
        Me.submnpartida.Text = "PARTIDA"
        '
        'submnegresos
        '
        Me.submnegresos.Image = Global.Bombonela.My.Resources.Resources.egresos16
        Me.submnegresos.Name = "submnegresos"
        Me.submnegresos.Size = New System.Drawing.Size(152, 22)
        Me.submnegresos.Text = "EGRESOS"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Bombonela.My.Resources.Resources.WAREHOUSE
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(65, 35)
        Me.ToolStripMenuItem2.Text = "BODEGA"
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tconsulta
        '
        Me.tconsulta.Enabled = True
        Me.tconsulta.Interval = 5000
        '
        'pimpresion
        '
        Me.pimpresion.BackColor = System.Drawing.Color.Transparent
        Me.pimpresion.Controls.Add(Me.grdatos)
        Me.pimpresion.Dock = System.Windows.Forms.DockStyle.Left
        Me.pimpresion.Location = New System.Drawing.Point(0, 39)
        Me.pimpresion.Name = "pimpresion"
        Me.pimpresion.Size = New System.Drawing.Size(207, 648)
        Me.pimpresion.TabIndex = 7
        Me.pimpresion.Visible = False
        '
        'grdatos
        '
        Me.grdatos.AllowUserToAddRows = False
        Me.grdatos.AllowUserToDeleteRows = False
        Me.grdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdatos.BackgroundColor = System.Drawing.Color.White
        Me.grdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.grdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdatos.EnableHeadersVisualStyles = False
        Me.grdatos.GridColor = System.Drawing.Color.White
        Me.grdatos.Location = New System.Drawing.Point(0, 0)
        Me.grdatos.MultiSelect = False
        Me.grdatos.Name = "grdatos"
        Me.grdatos.ReadOnly = True
        Me.grdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdatos.Size = New System.Drawing.Size(204, 648)
        Me.grdatos.TabIndex = 17
        Me.grdatos.VirtualMode = True
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Bombonela.My.Resources.Resources.Bombonelamax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1370, 687)
        Me.Controls.Add(Me.pimpresion)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmprincipal"
        Me.Text = "SISTEMA DE CONTROL DE ACTIVIDADES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.pimpresion.ResumeLayout(False)
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnsalir As ToolStripMenuItem
    Friend WithEvents mnccalendario As ToolStripMenuItem
    Friend WithEvents mnprospectos As ToolStripMenuItem
    Friend WithEvents mnrecepcion As ToolStripMenuItem
    Friend WithEvents mnsalida As ToolStripMenuItem
    Friend WithEvents mninventario As ToolStripMenuItem
    Friend WithEvents mncatalogos As ToolStripMenuItem
    Friend WithEvents MNCATPROD As ToolStripMenuItem
    Friend WithEvents mncobranza As ToolStripMenuItem
    Friend WithEvents mncxc As ToolStripMenuItem
    Friend WithEvents mnreportes As ToolStripMenuItem
    Friend WithEvents mncingresos As ToolStripMenuItem
    Friend WithEvents mnventas As ToolStripMenuItem
    Friend WithEvents CONFIGURACIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBMNCABINAS As ToolStripMenuItem
    Friend WithEvents SUBMNALMACENES As ToolStripMenuItem
    Friend WithEvents SUBMNMARCA As ToolStripMenuItem
    Friend WithEvents mntools As ToolStripMenuItem
    Friend WithEvents SUBMNPRIINVENT As ToolStripMenuItem
    Friend WithEvents MNCATSERV As ToolStripMenuItem
    Friend WithEvents TIPOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROSPECTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COLABORADORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PUESTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mngastos As ToolStripMenuItem
    Friend WithEvents submnpartida As ToolStripMenuItem
    Friend WithEvents submnproveedor As ToolStripMenuItem
    Friend WithEvents submnegresos As ToolStripMenuItem
    Friend WithEvents tconsulta As Timer
    Friend WithEvents pimpresion As Panel
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents mncinventarios As ToolStripMenuItem
    Friend WithEvents mncventadet As ToolStripMenuItem
    Friend WithEvents mncventadetpago As ToolStripMenuItem
    Friend WithEvents mnhistorial As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnabrircaja As ToolStripMenuItem
    Friend WithEvents mngastocaja As ToolStripMenuItem
    Friend WithEvents mnreportecaja As ToolStripMenuItem
    Friend WithEvents mnretirocaja As ToolStripMenuItem
    Friend WithEvents mnctickets As ToolStripMenuItem
    Friend WithEvents mnccumple As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
