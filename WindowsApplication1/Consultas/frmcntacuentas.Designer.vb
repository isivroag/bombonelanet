<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntacuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcntacuentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.ccampo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mncpagar = New System.Windows.Forms.ToolStripButton()
        Me.mncdetalle = New System.Windows.Forms.ToolStripButton()
        Me.mnver = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.mncancelar = New System.Windows.Forms.ToolStripButton()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.l3 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.DtFin = New System.Windows.Forms.DateTimePicker()
        Me.DtInicio = New System.Windows.Forms.DateTimePicker()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuclientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(306, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 43)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONSULTA DE VENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
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
        Me.grdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdatos.EnableHeadersVisualStyles = False
        Me.grdatos.GridColor = System.Drawing.Color.White
        Me.grdatos.Location = New System.Drawing.Point(12, 157)
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
        Me.grdatos.Size = New System.Drawing.Size(892, 410)
        Me.grdatos.TabIndex = 14
        Me.grdatos.VirtualMode = True
        '
        'menuclientes
        '
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncpagar, Me.mncdetalle, Me.mnver, Me.mncSALIR, Me.mncancelar, Me.mncIMPRIMIR})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuclientes.Size = New System.Drawing.Size(916, 48)
        Me.menuclientes.TabIndex = 12
        Me.menuclientes.Text = "ToolStrip1"
        '
        'ccampo
        '
        Me.ccampo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccampo.FormattingEnabled = True
        Me.ccampo.Items.AddRange(New Object() {"FECHA", "FOLIO VENTA", "CLIENTE"})
        Me.ccampo.Location = New System.Drawing.Point(538, 122)
        Me.ccampo.Name = "ccampo"
        Me.ccampo.Size = New System.Drawing.Size(109, 25)
        Me.ccampo.TabIndex = 168
        Me.ccampo.Text = "FECHA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(653, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'mncpagar
        '
        Me.mncpagar.BackColor = System.Drawing.Color.White
        Me.mncpagar.Image = Global.Bombonela.My.Resources.Resources.PAGO26
        Me.mncpagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncpagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncpagar.Name = "mncpagar"
        Me.mncpagar.Size = New System.Drawing.Size(48, 45)
        Me.mncpagar.Text = "PAGAR"
        Me.mncpagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncdetalle
        '
        Me.mncdetalle.BackColor = System.Drawing.Color.White
        Me.mncdetalle.Image = Global.Bombonela.My.Resources.Resources.detalle26
        Me.mncdetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncdetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncdetalle.Name = "mncdetalle"
        Me.mncdetalle.Size = New System.Drawing.Size(56, 45)
        Me.mncdetalle.Text = "DETALLE"
        Me.mncdetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnver
        '
        Me.mnver.BackColor = System.Drawing.Color.White
        Me.mnver.Image = Global.Bombonela.My.Resources.Resources.VERPAGOS26
        Me.mnver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnver.Name = "mnver"
        Me.mnver.Size = New System.Drawing.Size(71, 45)
        Me.mnver.Text = "VER PAGOS"
        Me.mnver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncSALIR
        '
        Me.mncSALIR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mncSALIR.BackColor = System.Drawing.Color.White
        Me.mncSALIR.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.mncSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncSALIR.Name = "mncSALIR"
        Me.mncSALIR.Size = New System.Drawing.Size(41, 45)
        Me.mncSALIR.Text = "SALIR"
        Me.mncSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncancelar
        '
        Me.mncancelar.BackColor = System.Drawing.Color.White
        Me.mncancelar.Image = Global.Bombonela.My.Resources.Resources.cancelarb26
        Me.mncancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncancelar.Name = "mncancelar"
        Me.mncancelar.Size = New System.Drawing.Size(71, 45)
        Me.mncancelar.Text = "CANCELAR"
        Me.mncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncIMPRIMIR
        '
        Me.mncIMPRIMIR.BackColor = System.Drawing.Color.White
        Me.mncIMPRIMIR.Image = Global.Bombonela.My.Resources.Resources.PRINT26
        Me.mncIMPRIMIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncIMPRIMIR.Name = "mncIMPRIMIR"
        Me.mncIMPRIMIR.Size = New System.Drawing.Size(63, 45)
        Me.mncIMPRIMIR.Text = "IMPRIMIR"
        Me.mncIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.Black
        Me.l3.Location = New System.Drawing.Point(217, 104)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(198, 15)
        Me.l3.TabIndex = 216
        Me.l3.Text = "INTRODUZCA EL DATO A BUSCAR:"
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.ForeColor = System.Drawing.Color.Black
        Me.tnombre.Location = New System.Drawing.Point(230, 122)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(293, 25)
        Me.tnombre.TabIndex = 215
        Me.tnombre.Visible = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Black
        Me.l1.Location = New System.Drawing.Point(206, 127)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(47, 15)
        Me.l1.TabIndex = 214
        Me.l1.Text = "DESDE:"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Black
        Me.l2.Location = New System.Drawing.Point(373, 127)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(48, 15)
        Me.l2.TabIndex = 213
        Me.l2.Text = "HASTA:"
        '
        'DtFin
        '
        Me.DtFin.CustomFormat = "yyyy-MM-dd"
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFin.Location = New System.Drawing.Point(427, 127)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(107, 20)
        Me.DtFin.TabIndex = 212
        '
        'DtInicio
        '
        Me.DtInicio.CustomFormat = "yyyy-MM-dd"
        Me.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtInicio.Location = New System.Drawing.Point(260, 127)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(107, 20)
        Me.DtInicio.TabIndex = 211
        '
        'frmcntacuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(916, 579)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.DtFin)
        Me.Controls.Add(Me.DtInicio)
        Me.Controls.Add(Me.ccampo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.menuclientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcntacuentas"
        Me.Text = "CONSULTA DE CUENTAS"
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuclientes.ResumeLayout(False)
        Me.menuclientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents menuclientes As ToolStrip
    Friend WithEvents mncpagar As ToolStripButton
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents mncdetalle As ToolStripButton
    Friend WithEvents mnver As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mncancelar As ToolStripButton
    Friend WithEvents ccampo As ComboBox
    Friend WithEvents mncIMPRIMIR As ToolStripButton
    Friend WithEvents l3 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents DtFin As DateTimePicker
    Friend WithEvents DtInicio As DateTimePicker
End Class
