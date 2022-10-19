<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcobranza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcobranza))
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid_clie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tletras = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bnuevo = New System.Windows.Forms.ToolStripButton()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bpagar = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tfecha = New System.Windows.Forms.DateTimePicker()
        Me.chdescuento = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tdescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tsubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tconcepto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ccol = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdatos
        '
        Me.grdatos.AllowUserToAddRows = False
        Me.grdatos.AllowUserToDeleteRows = False
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
        Me.grdatos.Location = New System.Drawing.Point(15, 188)
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
        Me.grdatos.Size = New System.Drawing.Size(616, 295)
        Me.grdatos.TabIndex = 8
        Me.grdatos.VirtualMode = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FOLIO"
        '
        'tfolio
        '
        Me.tfolio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfolio.Location = New System.Drawing.Point(15, 36)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(100, 22)
        Me.tfolio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FECHA"
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.Location = New System.Drawing.Point(121, 77)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(510, 22)
        Me.tnombre.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CLIENTE"
        '
        'tid_clie
        '
        Me.tid_clie.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tid_clie.Location = New System.Drawing.Point(15, 77)
        Me.tid_clie.Name = "tid_clie"
        Me.tid_clie.Size = New System.Drawing.Size(100, 22)
        Me.tid_clie.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(489, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TOTAL"
        '
        'ttotal
        '
        Me.ttotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(492, 502)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(139, 22)
        Me.ttotal.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 536)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TOTAL CON LETRA"
        '
        'tletras
        '
        Me.tletras.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tletras.Location = New System.Drawing.Point(15, 552)
        Me.tletras.Name = "tletras"
        Me.tletras.Size = New System.Drawing.Size(616, 22)
        Me.tletras.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnuevo, Me.bguardar, Me.bpagar, Me.bsalir, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 48)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.White
        Me.bnuevo.Image = Global.Bombonela.My.Resources.Resources.add_new_261
        Me.bnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(50, 45)
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.bguardar.Visible = False
        '
        'bpagar
        '
        Me.bpagar.BackColor = System.Drawing.Color.White
        Me.bpagar.Image = Global.Bombonela.My.Resources.Resources.PAGO26
        Me.bpagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bpagar.Name = "bpagar"
        Me.bpagar.Size = New System.Drawing.Size(48, 45)
        Me.bpagar.Text = "PAGAR"
        Me.bpagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bpagar.Visible = False
        '
        'bsalir
        '
        Me.bsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bsalir.BackColor = System.Drawing.Color.White
        Me.bsalir.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.bsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(41, 45)
        Me.bsalir.Text = "SALIR"
        Me.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bsalir.ToolTipText = "REGRESAR"
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.BackColor = System.Drawing.Color.White
        Me.bcancelar.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(71, 45)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bcancelar.ToolTipText = "CANCELAR"
        Me.bcancelar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tfecha)
        Me.Panel1.Controls.Add(Me.chdescuento)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tdescuento)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tsubtotal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tconcepto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ccol)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tletras)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ttotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tfolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid_clie)
        Me.Panel1.Controls.Add(Me.grdatos)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(9, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 596)
        Me.Panel1.TabIndex = 158
        '
        'tfecha
        '
        Me.tfecha.CustomFormat = "yyyy-MM-dd"
        Me.tfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tfecha.Location = New System.Drawing.Point(524, 36)
        Me.tfecha.Name = "tfecha"
        Me.tfecha.Size = New System.Drawing.Size(107, 20)
        Me.tfecha.TabIndex = 168
        '
        'chdescuento
        '
        Me.chdescuento.AutoSize = True
        Me.chdescuento.BackColor = System.Drawing.Color.Transparent
        Me.chdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdescuento.Location = New System.Drawing.Point(253, 485)
        Me.chdescuento.Name = "chdescuento"
        Me.chdescuento.Size = New System.Drawing.Size(35, 17)
        Me.chdescuento.TabIndex = 167
        Me.chdescuento.Text = "%"
        Me.chdescuento.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 166
        Me.Label10.Text = "DESCUENTO"
        '
        'tdescuento
        '
        Me.tdescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tdescuento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdescuento.Location = New System.Drawing.Point(254, 502)
        Me.tdescuento.Name = "tdescuento"
        Me.tdescuento.Size = New System.Drawing.Size(139, 22)
        Me.tdescuento.TabIndex = 165
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 486)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "SUBTOTAL"
        '
        'tsubtotal
        '
        Me.tsubtotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsubtotal.Location = New System.Drawing.Point(15, 502)
        Me.tsubtotal.Name = "tsubtotal"
        Me.tsubtotal.Size = New System.Drawing.Size(139, 22)
        Me.tsubtotal.TabIndex = 163
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 13)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "CONCEPTO / DESCRIPCIÓN"
        '
        'tconcepto
        '
        Me.tconcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tconcepto.Location = New System.Drawing.Point(15, 118)
        Me.tconcepto.Name = "tconcepto"
        Me.tconcepto.Size = New System.Drawing.Size(616, 22)
        Me.tconcepto.TabIndex = 161
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "COBRADOR"
        '
        'ccol
        '
        Me.ccol.FormattingEnabled = True
        Me.ccol.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE DEBITO", "TARJETA DE CREDITO"})
        Me.ccol.Location = New System.Drawing.Point(15, 161)
        Me.ccol.Name = "ccol"
        Me.ccol.Size = New System.Drawing.Size(616, 21)
        Me.ccol.TabIndex = 158
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(637, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Bombonela.My.Resources.Resources.minus26_2
        Me.Button1.Location = New System.Drawing.Point(637, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button
        '
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Image = Global.Bombonela.My.Resources.Resources.add_new_26
        Me.Button.Location = New System.Drawing.Point(637, 188)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(39, 32)
        Me.Button.TabIndex = 9
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(297, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 43)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "VENTAS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'frmcobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 706)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcobranza"
        Me.Text = "frmcobranza"
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdatos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid_clie As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ttotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tletras As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bnuevo As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents Button As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ccol As ComboBox
    Friend WithEvents bpagar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents tdescuento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tsubtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tconcepto As TextBox
    Friend WithEvents chdescuento As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tfecha As DateTimePicker
End Class
