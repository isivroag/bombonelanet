<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvisita
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.tcabina = New System.Windows.Forms.ComboBox()
        Me.tcol = New System.Windows.Forms.ComboBox()
        Me.BBSERVICIO = New System.Windows.Forms.Button()
        Me.bbcliente = New System.Windows.Forms.Button()
        Me.tvis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid_clie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chora2 = New System.Windows.Forms.ComboBox()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tserv = New System.Windows.Forms.TextBox()
        Me.chora = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.tclie = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bentrar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.tcabina)
        Me.GroupBox.Controls.Add(Me.tcol)
        Me.GroupBox.Controls.Add(Me.BBSERVICIO)
        Me.GroupBox.Controls.Add(Me.bbcliente)
        Me.GroupBox.Controls.Add(Me.tvis)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.tobs)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.tid_clie)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.chora2)
        Me.GroupBox.Controls.Add(Me.tfolio)
        Me.GroupBox.Controls.Add(Me.Label12)
        Me.GroupBox.Controls.Add(Me.Label11)
        Me.GroupBox.Controls.Add(Me.Label10)
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.tserv)
        Me.GroupBox.Controls.Add(Me.chora)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.dtfecha)
        Me.GroupBox.Controls.Add(Me.tclie)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(539, 399)
        Me.GroupBox.TabIndex = 105
        Me.GroupBox.TabStop = False
        '
        'tcabina
        '
        Me.tcabina.FormattingEnabled = True
        Me.tcabina.Location = New System.Drawing.Point(16, 216)
        Me.tcabina.Name = "tcabina"
        Me.tcabina.Size = New System.Drawing.Size(508, 21)
        Me.tcabina.TabIndex = 148
        '
        'tcol
        '
        Me.tcol.FormattingEnabled = True
        Me.tcol.Location = New System.Drawing.Point(14, 258)
        Me.tcol.Name = "tcol"
        Me.tcol.Size = New System.Drawing.Size(511, 21)
        Me.tcol.TabIndex = 149
        '
        'BBSERVICIO
        '
        Me.BBSERVICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBSERVICIO.ForeColor = System.Drawing.Color.Black
        Me.BBSERVICIO.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.BBSERVICIO.Location = New System.Drawing.Point(499, 129)
        Me.BBSERVICIO.Name = "BBSERVICIO"
        Me.BBSERVICIO.Size = New System.Drawing.Size(24, 24)
        Me.BBSERVICIO.TabIndex = 147
        Me.BBSERVICIO.UseVisualStyleBackColor = True
        '
        'bbcliente
        '
        Me.bbcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbcliente.ForeColor = System.Drawing.Color.Black
        Me.bbcliente.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.bbcliente.Location = New System.Drawing.Point(500, 81)
        Me.bbcliente.Name = "bbcliente"
        Me.bbcliente.Size = New System.Drawing.Size(24, 24)
        Me.bbcliente.TabIndex = 146
        Me.bbcliente.UseVisualStyleBackColor = True
        '
        'tvis
        '
        Me.tvis.Location = New System.Drawing.Point(13, 33)
        Me.tvis.Name = "tvis"
        Me.tvis.Size = New System.Drawing.Size(109, 20)
        Me.tvis.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "FOLIO VISITA"
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(10, 314)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(515, 63)
        Me.tobs.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "OBSERVACIONES"
        '
        'tid_clie
        '
        Me.tid_clie.Location = New System.Drawing.Point(13, 85)
        Me.tid_clie.Name = "tid_clie"
        Me.tid_clie.Size = New System.Drawing.Size(109, 20)
        Me.tid_clie.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "ID VISITANTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "SALIDA"
        '
        'chora2
        '
        Me.chora2.FormattingEnabled = True
        Me.chora2.Location = New System.Drawing.Point(402, 173)
        Me.chora2.Name = "chora2"
        Me.chora2.Size = New System.Drawing.Size(121, 21)
        Me.chora2.TabIndex = 137
        '
        'tfolio
        '
        Me.tfolio.Location = New System.Drawing.Point(128, 33)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(99, 20)
        Me.tfolio.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 15)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "CITA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "AREA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "COLABORADOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "SERVICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "VISITANTE"
        '
        'tserv
        '
        Me.tserv.Location = New System.Drawing.Point(15, 133)
        Me.tserv.Name = "tserv"
        Me.tserv.Size = New System.Drawing.Size(476, 20)
        Me.tserv.TabIndex = 124
        '
        'chora
        '
        Me.chora.FormattingEnabled = True
        Me.chora.Location = New System.Drawing.Point(247, 173)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(122, 21)
        Me.chora.TabIndex = 123
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "ENTRADA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Enabled = False
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(17, 174)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(105, 20)
        Me.dtfecha.TabIndex = 120
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'tclie
        '
        Me.tclie.Location = New System.Drawing.Point(128, 85)
        Me.tclie.Name = "tclie"
        Me.tclie.Size = New System.Drawing.Size(363, 20)
        Me.tclie.TabIndex = 119
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bentrar, Me.bcancelar, Me.bsalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(567, 48)
        Me.ToolStrip1.TabIndex = 135
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bentrar
        '
        Me.bentrar.BackColor = System.Drawing.Color.White
        Me.bentrar.Image = Global.Bombonela.My.Resources.Resources.ENTRAR24
        Me.bentrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bentrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bentrar.Name = "bentrar"
        Me.bentrar.Size = New System.Drawing.Size(64, 45)
        Me.bentrar.Text = "ENTRADA"
        Me.bentrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bentrar.Visible = False
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.BackColor = System.Drawing.Color.White
        Me.bcancelar.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.bcancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(41, 45)
        Me.bcancelar.Text = "SALIR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bcancelar.ToolTipText = "REGRESAR"
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.White
        Me.bsalir.Image = Global.Bombonela.My.Resources.Resources.salir24
        Me.bsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(50, 45)
        Me.bsalir.Text = "SALIDA"
        Me.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bsalir.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(97, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 43)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "INFORMACIÓN DE SERVICIO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseCompatibleTextRendering = True
        '
        'frmvisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(567, 517)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "frmvisita"
        Me.Text = "frmvisita"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chora2 As ComboBox
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tserv As TextBox
    Friend WithEvents chora As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents tclie As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bentrar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents tid_clie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tvis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bbcliente As Button
    Friend WithEvents BBSERVICIO As Button
    Friend WithEvents tcabina As ComboBox
    Friend WithEvents tcol As ComboBox
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents Label4 As Label
End Class
