<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntacuentasclie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcntacuentasclie))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.mncpagar = New System.Windows.Forms.ToolStripButton()
        Me.mncdetalle = New System.Windows.Forms.ToolStripButton()
        Me.MNVER = New System.Windows.Forms.ToolStripButton()
        Me.mncancelar = New System.Windows.Forms.ToolStripButton()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid_clie = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(336, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 43)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CONSULTA DE CUENTAS"
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
        Me.grdatos.Location = New System.Drawing.Point(7, 131)
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
        Me.grdatos.Size = New System.Drawing.Size(969, 407)
        Me.grdatos.TabIndex = 17
        Me.grdatos.VirtualMode = True
        '
        'menuclientes
        '
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncpagar, Me.mncdetalle, Me.MNVER, Me.mncancelar, Me.mncIMPRIMIR, Me.mncSALIR})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuclientes.Size = New System.Drawing.Size(988, 48)
        Me.menuclientes.TabIndex = 15
        Me.menuclientes.Text = "ToolStrip1"
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
        'MNVER
        '
        Me.MNVER.BackColor = System.Drawing.Color.White
        Me.MNVER.Image = Global.Bombonela.My.Resources.Resources.VERPAGOS26
        Me.MNVER.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MNVER.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MNVER.Name = "MNVER"
        Me.MNVER.Size = New System.Drawing.Size(71, 45)
        Me.MNVER.Text = "VER PAGOS"
        Me.MNVER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.mncIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncIMPRIMIR.Name = "mncIMPRIMIR"
        Me.mncIMPRIMIR.Size = New System.Drawing.Size(63, 45)
        Me.mncIMPRIMIR.Text = "IMPRIMIR"
        Me.mncIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mncIMPRIMIR.Visible = False
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
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(780, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 161
        Me.PictureBox1.TabStop = False
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.Location = New System.Drawing.Point(294, 103)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(477, 22)
        Me.tnombre.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "CLIENTE"
        '
        'tid_clie
        '
        Me.tid_clie.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tid_clie.Location = New System.Drawing.Point(188, 103)
        Me.tid_clie.Name = "tid_clie"
        Me.tid_clie.Size = New System.Drawing.Size(100, 22)
        Me.tid_clie.TabIndex = 159
        '
        'frmcntacuentasclie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tid_clie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.menuclientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcntacuentasclie"
        Me.Text = "fmcntacuentasclie"
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
    Friend WithEvents mncdetalle As ToolStripButton
    Friend WithEvents MNVER As ToolStripButton
    Friend WithEvents mncIMPRIMIR As ToolStripButton
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid_clie As TextBox
    Friend WithEvents mncancelar As ToolStripButton
End Class
