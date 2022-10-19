<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkardex
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkardex))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.ID_TIPOMOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.calmacen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lmedida = New System.Windows.Forms.Label()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.mncNUEVO = New System.Windows.Forms.ToolStripButton()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.tcant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuclientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(296, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 43)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "KARDEX"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MOVIMIENTOS"
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
        Me.grdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_TIPOMOV, Me.TIPO, Me.FECHA, Me.INI, Me.CANT, Me.UNIDAD, Me.FIN, Me.OBS})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdatos.EnableHeadersVisualStyles = False
        Me.grdatos.GridColor = System.Drawing.Color.White
        Me.grdatos.Location = New System.Drawing.Point(15, 290)
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
        Me.grdatos.Size = New System.Drawing.Size(676, 205)
        Me.grdatos.TabIndex = 16
        Me.grdatos.VirtualMode = True
        '
        'ID_TIPOMOV
        '
        Me.ID_TIPOMOV.HeaderText = "ID TIPOMOV"
        Me.ID_TIPOMOV.Name = "ID_TIPOMOV"
        Me.ID_TIPOMOV.ReadOnly = True
        Me.ID_TIPOMOV.Visible = False
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'INI
        '
        Me.INI.HeaderText = "INV INI"
        Me.INI.Name = "INI"
        Me.INI.ReadOnly = True
        '
        'CANT
        '
        Me.CANT.HeaderText = "CANTIDAD"
        Me.CANT.Name = "CANT"
        Me.CANT.ReadOnly = True
        Me.CANT.Visible = False
        '
        'UNIDAD
        '
        Me.UNIDAD.HeaderText = "UNIDAD"
        Me.UNIDAD.Name = "UNIDAD"
        Me.UNIDAD.ReadOnly = True
        '
        'FIN
        '
        Me.FIN.HeaderText = "INV FIN"
        Me.FIN.Name = "FIN"
        Me.FIN.ReadOnly = True
        '
        'OBS
        '
        Me.OBS.HeaderText = "OBSERVACIONES"
        Me.OBS.Name = "OBS"
        Me.OBS.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.calmacen)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tnombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tclave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 164)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'calmacen
        '
        Me.calmacen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacen.FormattingEnabled = True
        Me.calmacen.Location = New System.Drawing.Point(59, 123)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(581, 21)
        Me.calmacen.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "ALMACEN"
        '
        'tid
        '
        Me.tid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tid.Location = New System.Drawing.Point(540, 40)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.Location = New System.Drawing.Point(59, 81)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(581, 20)
        Me.tnombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DESCRIPCION"
        '
        'tclave
        '
        Me.tclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tclave.Location = New System.Drawing.Point(59, 40)
        Me.tclave.Name = "tclave"
        Me.tclave.Size = New System.Drawing.Size(100, 20)
        Me.tclave.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLAVE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(646, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lmedida
        '
        Me.lmedida.AutoSize = True
        Me.lmedida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmedida.Location = New System.Drawing.Point(632, 522)
        Me.lmedida.Name = "lmedida"
        Me.lmedida.Size = New System.Drawing.Size(54, 15)
        Me.lmedida.TabIndex = 10
        Me.lmedida.Text = "MEDIDA"
        '
        'menuclientes
        '
        Me.menuclientes.AutoSize = False
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncNUEVO, Me.mncIMPRIMIR, Me.mncSALIR})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.Size = New System.Drawing.Size(706, 48)
        Me.menuclientes.TabIndex = 18
        Me.menuclientes.Text = "ToolStrip1"
        '
        'mncNUEVO
        '
        Me.mncNUEVO.BackColor = System.Drawing.Color.White
        Me.mncNUEVO.Image = Global.Bombonela.My.Resources.Resources.MOVIMIENTO
        Me.mncNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncNUEVO.Name = "mncNUEVO"
        Me.mncNUEVO.Size = New System.Drawing.Size(84, 45)
        Me.mncNUEVO.Text = "MOVIMIENTO"
        Me.mncNUEVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncIMPRIMIR
        '
        Me.mncIMPRIMIR.BackColor = System.Drawing.Color.White
        Me.mncIMPRIMIR.Image = Global.Bombonela.My.Resources.Resources.PRINT26
        Me.mncIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncIMPRIMIR.Name = "mncIMPRIMIR"
        Me.mncIMPRIMIR.Size = New System.Drawing.Size(63, 45)
        Me.mncIMPRIMIR.Text = "IMPRIMIR"
        Me.mncIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncSALIR
        '
        Me.mncSALIR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mncSALIR.BackColor = System.Drawing.Color.White
        Me.mncSALIR.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.mncSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncSALIR.Name = "mncSALIR"
        Me.mncSALIR.Size = New System.Drawing.Size(41, 45)
        Me.mncSALIR.Text = "SALIR"
        Me.mncSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tcant
        '
        Me.tcant.Location = New System.Drawing.Point(526, 522)
        Me.tcant.Name = "tcant"
        Me.tcant.Size = New System.Drawing.Size(100, 20)
        Me.tcant.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(478, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "EXISTENCIAS"
        '
        'frmkardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 554)
        Me.Controls.Add(Me.menuclientes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.lmedida)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tcant)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmkardex"
        Me.Text = "frmkardex"
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuclientes.ResumeLayout(False)
        Me.menuclientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lmedida As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tclave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menuclientes As ToolStrip
    Friend WithEvents mncNUEVO As ToolStripButton
    Friend WithEvents mncIMPRIMIR As ToolStripButton
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents tcant As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents calmacen As ComboBox
    Friend WithEvents ID_TIPOMOV As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents INI As DataGridViewTextBoxColumn
    Friend WithEvents CANT As DataGridViewTextBoxColumn
    Friend WithEvents UNIDAD As DataGridViewTextBoxColumn
    Friend WithEvents FIN As DataGridViewTextBoxColumn
    Friend WithEvents OBS As DataGridViewTextBoxColumn
End Class
