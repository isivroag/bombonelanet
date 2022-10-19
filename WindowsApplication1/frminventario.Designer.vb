<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminventario
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmin = New System.Windows.Forms.TextBox()
        Me.lmedida = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcant = New System.Windows.Forms.TextBox()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.mncmov = New System.Windows.Forms.ToolStripButton()
        Me.mncNUEVO = New System.Windows.Forms.ToolStripButton()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.mncTransferir = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.ID_ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.menuclientes.SuspendLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PRECIO"
        '
        'tprecio
        '
        Me.tprecio.Location = New System.Drawing.Point(387, 124)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(100, 20)
        Me.tprecio.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MINIMO"
        '
        'tmin
        '
        Me.tmin.Location = New System.Drawing.Point(230, 124)
        Me.tmin.Name = "tmin"
        Me.tmin.Size = New System.Drawing.Size(100, 20)
        Me.tmin.TabIndex = 11
        '
        'lmedida
        '
        Me.lmedida.AutoSize = True
        Me.lmedida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmedida.Location = New System.Drawing.Point(165, 129)
        Me.lmedida.Name = "lmedida"
        Me.lmedida.Size = New System.Drawing.Size(54, 15)
        Me.lmedida.TabIndex = 10
        Me.lmedida.Text = "MEDIDA"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(387, 40)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "EXISTENCIAS"
        '
        'tcant
        '
        Me.tcant.Location = New System.Drawing.Point(59, 124)
        Me.tcant.Name = "tcant"
        Me.tcant.Size = New System.Drawing.Size(100, 20)
        Me.tcant.TabIndex = 9
        '
        'menuclientes
        '
        Me.menuclientes.AutoSize = False
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncmov, Me.mncNUEVO, Me.mncIMPRIMIR, Me.mncSALIR, Me.mncTransferir})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.Size = New System.Drawing.Size(562, 48)
        Me.menuclientes.TabIndex = 4
        Me.menuclientes.Text = "ToolStrip1"
        '
        'mncmov
        '
        Me.mncmov.BackColor = System.Drawing.Color.White
        Me.mncmov.Image = Global.Bombonela.My.Resources.Resources.trans24
        Me.mncmov.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncmov.Name = "mncmov"
        Me.mncmov.Size = New System.Drawing.Size(84, 45)
        Me.mncmov.Text = "MOVIMIENTO"
        Me.mncmov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncNUEVO
        '
        Me.mncNUEVO.BackColor = System.Drawing.Color.White
        Me.mncNUEVO.Image = Global.Bombonela.My.Resources.Resources.MOV
        Me.mncNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncNUEVO.Name = "mncNUEVO"
        Me.mncNUEVO.Size = New System.Drawing.Size(54, 45)
        Me.mncNUEVO.Text = "KARDEX"
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
        'mncTransferir
        '
        Me.mncTransferir.BackColor = System.Drawing.Color.White
        Me.mncTransferir.Image = Global.Bombonela.My.Resources.Resources.MOVIMIENTO
        Me.mncTransferir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncTransferir.Name = "mncTransferir"
        Me.mncTransferir.Size = New System.Drawing.Size(56, 45)
        Me.mncTransferir.Text = "TRANSF."
        Me.mncTransferir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DETALLE DE ALMACENES"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(59, 81)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(428, 20)
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
        'grdatos
        '
        Me.grdatos.AllowUserToAddRows = False
        Me.grdatos.AllowUserToDeleteRows = False
        Me.grdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(254, Byte), Integer))
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
        Me.grdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ALMACEN, Me.ALMACEN, Me.CANTIDAD, Me.UNIDAD})
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
        Me.grdatos.Location = New System.Drawing.Point(16, 279)
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
        Me.grdatos.Size = New System.Drawing.Size(530, 205)
        Me.grdatos.TabIndex = 7
        Me.grdatos.VirtualMode = True
        '
        'ID_ALMACEN
        '
        Me.ID_ALMACEN.HeaderText = "ID ALMACEN"
        Me.ID_ALMACEN.Name = "ID_ALMACEN"
        Me.ID_ALMACEN.ReadOnly = True
        Me.ID_ALMACEN.Visible = False
        '
        'ALMACEN
        '
        Me.ALMACEN.HeaderText = "ALMACEN"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'UNIDAD
        '
        Me.UNIDAD.HeaderText = "UNIDAD"
        Me.UNIDAD.Name = "UNIDAD"
        Me.UNIDAD.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tprecio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tmin)
        Me.GroupBox1.Controls.Add(Me.lmedida)
        Me.GroupBox1.Controls.Add(Me.tid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tcant)
        Me.GroupBox1.Controls.Add(Me.tnombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tclave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 164)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(493, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(195, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 43)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "INVENTARIO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label8.UseCompatibleTextRendering = True
        '
        'frminventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 507)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.menuclientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminventario"
        Me.Text = "frminventario"
        Me.menuclientes.ResumeLayout(False)
        Me.menuclientes.PerformLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents tprecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tmin As TextBox
    Friend WithEvents lmedida As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tcant As TextBox
    Friend WithEvents menuclientes As ToolStrip
    Friend WithEvents mncNUEVO As ToolStripButton
    Friend WithEvents mncIMPRIMIR As ToolStripButton
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tclave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ID_ALMACEN As DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents UNIDAD As DataGridViewTextBoxColumn
    Friend WithEvents mncmov As ToolStripButton
    Friend WithEvents mncTransferir As ToolStripButton
End Class
