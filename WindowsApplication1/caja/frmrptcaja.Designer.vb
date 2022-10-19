<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptcaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrptcaja))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bretiro = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tinicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tefectivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totros = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tingresos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tflujobruto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tgastos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tretiros = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tflujoneto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ttransfer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ttdebito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tamex = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tdeposito = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ttcredito = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bretiro, Me.bcancelar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(285, 48)
        Me.ToolStrip1.TabIndex = 7
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
        'bretiro
        '
        Me.bretiro.BackColor = System.Drawing.Color.White
        Me.bretiro.Image = Global.Bombonela.My.Resources.Resources.RETIRO
        Me.bretiro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bretiro.Name = "bretiro"
        Me.bretiro.Size = New System.Drawing.Size(49, 45)
        Me.bretiro.Text = "RETIRO"
        Me.bretiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Bombonela.My.Resources.Resources.PRINT26
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 45)
        Me.ToolStripButton1.Text = "IMPRIMIR"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "REIMPRIMIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "FECHA"
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(88, 111)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtFecha.TabIndex = 186
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "MONTO INICIAL"
        '
        'tinicial
        '
        Me.tinicial.BackColor = System.Drawing.Color.White
        Me.tinicial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tinicial.Location = New System.Drawing.Point(55, 150)
        Me.tinicial.Name = "tinicial"
        Me.tinicial.Size = New System.Drawing.Size(197, 23)
        Me.tinicial.TabIndex = 184
        Me.tinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 43)
        Me.Label6.TabIndex = 183
        Me.Label6.Text = "CAJA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "INGRESOS EN EFECTIVO"
        '
        'tefectivo
        '
        Me.tefectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tefectivo.Location = New System.Drawing.Point(55, 194)
        Me.tefectivo.Name = "tefectivo"
        Me.tefectivo.Size = New System.Drawing.Size(197, 23)
        Me.tefectivo.TabIndex = 189
        Me.tefectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "OTROS (SR PAGO)"
        '
        'totros
        '
        Me.totros.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totros.Location = New System.Drawing.Point(55, 446)
        Me.totros.Name = "totros"
        Me.totros.Size = New System.Drawing.Size(197, 23)
        Me.totros.TabIndex = 191
        Me.totros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "TOTAL DE INGRESOS"
        '
        'tingresos
        '
        Me.tingresos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tingresos.Location = New System.Drawing.Point(55, 487)
        Me.tingresos.Name = "tingresos"
        Me.tingresos.Size = New System.Drawing.Size(197, 23)
        Me.tingresos.TabIndex = 193
        Me.tingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 13)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "EFECTIVO + MONTO INICIAL"
        '
        'tflujobruto
        '
        Me.tflujobruto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tflujobruto.Location = New System.Drawing.Point(55, 528)
        Me.tflujobruto.Name = "tflujobruto"
        Me.tflujobruto.Size = New System.Drawing.Size(197, 23)
        Me.tflujobruto.TabIndex = 195
        Me.tflujobruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 553)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "GASTOS"
        '
        'tgastos
        '
        Me.tgastos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgastos.Location = New System.Drawing.Point(55, 569)
        Me.tgastos.Name = "tgastos"
        Me.tgastos.Size = New System.Drawing.Size(197, 23)
        Me.tgastos.TabIndex = 197
        Me.tgastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 594)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "RETIROS"
        '
        'tretiros
        '
        Me.tretiros.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tretiros.Location = New System.Drawing.Point(55, 610)
        Me.tretiros.Name = "tretiros"
        Me.tretiros.Size = New System.Drawing.Size(197, 23)
        Me.tretiros.TabIndex = 199
        Me.tretiros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 635)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "EFECTIVO AL CIERRE"
        '
        'tflujoneto
        '
        Me.tflujoneto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tflujoneto.Location = New System.Drawing.Point(55, 651)
        Me.tflujoneto.Name = "tflujoneto"
        Me.tflujoneto.Size = New System.Drawing.Size(197, 23)
        Me.tflujoneto.TabIndex = 201
        Me.tflujoneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "TRANSFERENCIAS"
        '
        'ttransfer
        '
        Me.ttransfer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttransfer.Location = New System.Drawing.Point(55, 278)
        Me.ttransfer.Name = "ttransfer"
        Me.ttransfer.Size = New System.Drawing.Size(197, 23)
        Me.ttransfer.TabIndex = 203
        Me.ttransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "TARJETA DEBITO"
        '
        'ttdebito
        '
        Me.ttdebito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttdebito.Location = New System.Drawing.Point(55, 362)
        Me.ttdebito.Name = "ttdebito"
        Me.ttdebito.Size = New System.Drawing.Size(197, 23)
        Me.ttdebito.TabIndex = 205
        Me.ttdebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 206
        Me.Label13.Text = "AMEX"
        '
        'tamex
        '
        Me.tamex.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tamex.Location = New System.Drawing.Point(55, 404)
        Me.tamex.Name = "tamex"
        Me.tamex.Size = New System.Drawing.Size(197, 23)
        Me.tamex.TabIndex = 207
        Me.tamex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "DEPOSITOS"
        '
        'tdeposito
        '
        Me.tdeposito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdeposito.Location = New System.Drawing.Point(55, 236)
        Me.tdeposito.Name = "tdeposito"
        Me.tdeposito.Size = New System.Drawing.Size(197, 23)
        Me.tdeposito.TabIndex = 209
        Me.tdeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 210
        Me.Label15.Text = "TARJETA CREDITO"
        '
        'ttcredito
        '
        Me.ttcredito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttcredito.Location = New System.Drawing.Point(55, 320)
        Me.ttcredito.Name = "ttcredito"
        Me.ttcredito.Size = New System.Drawing.Size(197, 23)
        Me.ttcredito.TabIndex = 211
        Me.ttcredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmrptcaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(285, 683)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ttcredito)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tdeposito)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tamex)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ttdebito)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ttransfer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tflujoneto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tretiros)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tgastos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tflujobruto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tingresos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totros)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tefectivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tinicial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrptcaja"
        Me.Text = "frmrptcaja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bretiro As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents tinicial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tefectivo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents totros As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tingresos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tflujobruto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tgastos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tretiros As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tflujoneto As TextBox
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents ttransfer As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ttdebito As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tamex As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tdeposito As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ttcredito As TextBox
End Class
