<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpago))
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GEFECTIVO = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tcambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpago = New System.Windows.Forms.TextBox()
        Me.GMONTO = New System.Windows.Forms.GroupBox()
        Me.LLETRAS1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmonto = New System.Windows.Forms.TextBox()
        Me.GPAGO = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmetodo = New System.Windows.Forms.ComboBox()
        Me.cfact = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tsaldo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GEFECTIVO.SuspendLayout()
        Me.GMONTO.SuspendLayout()
        Me.GPAGO.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tfolio
        '
        Me.tfolio.Location = New System.Drawing.Point(60, 96)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(115, 20)
        Me.tfolio.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "FOLIO:"
        '
        'GEFECTIVO
        '
        Me.GEFECTIVO.Controls.Add(Me.Label12)
        Me.GEFECTIVO.Controls.Add(Me.tcambio)
        Me.GEFECTIVO.Controls.Add(Me.Label11)
        Me.GEFECTIVO.Controls.Add(Me.tpago)
        Me.GEFECTIVO.Location = New System.Drawing.Point(10, 403)
        Me.GEFECTIVO.Name = "GEFECTIVO"
        Me.GEFECTIVO.Size = New System.Drawing.Size(400, 105)
        Me.GEFECTIVO.TabIndex = 117
        Me.GEFECTIVO.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 32)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "CAMBIO"
        '
        'tcambio
        '
        Me.tcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.tcambio.Location = New System.Drawing.Point(227, 54)
        Me.tcambio.Name = "tcambio"
        Me.tcambio.Size = New System.Drawing.Size(158, 35)
        Me.tcambio.TabIndex = 78
        Me.tcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(9, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 32)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "PAGO RECIBIDO"
        '
        'tpago
        '
        Me.tpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.tpago.Location = New System.Drawing.Point(227, 13)
        Me.tpago.Name = "tpago"
        Me.tpago.Size = New System.Drawing.Size(158, 35)
        Me.tpago.TabIndex = 76
        Me.tpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GMONTO
        '
        Me.GMONTO.Controls.Add(Me.LLETRAS1)
        Me.GMONTO.Controls.Add(Me.Label4)
        Me.GMONTO.Controls.Add(Me.tmonto)
        Me.GMONTO.Location = New System.Drawing.Point(10, 307)
        Me.GMONTO.Name = "GMONTO"
        Me.GMONTO.Size = New System.Drawing.Size(400, 90)
        Me.GMONTO.TabIndex = 118
        Me.GMONTO.TabStop = False
        '
        'LLETRAS1
        '
        Me.LLETRAS1.AutoSize = True
        Me.LLETRAS1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLETRAS1.Location = New System.Drawing.Point(12, 60)
        Me.LLETRAS1.Name = "LLETRAS1"
        Me.LLETRAS1.Size = New System.Drawing.Size(52, 13)
        Me.LLETRAS1.TabIndex = 81
        Me.LLETRAS1.Text = "LLETRAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 32)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "MONTO A PAGAR"
        '
        'tmonto
        '
        Me.tmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.tmonto.Location = New System.Drawing.Point(227, 16)
        Me.tmonto.Name = "tmonto"
        Me.tmonto.Size = New System.Drawing.Size(158, 35)
        Me.tmonto.TabIndex = 76
        Me.tmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GPAGO
        '
        Me.GPAGO.Controls.Add(Me.Label2)
        Me.GPAGO.Controls.Add(Me.ccol)
        Me.GPAGO.Controls.Add(Me.Label3)
        Me.GPAGO.Controls.Add(Me.cmetodo)
        Me.GPAGO.Controls.Add(Me.cfact)
        Me.GPAGO.Controls.Add(Me.Label9)
        Me.GPAGO.Controls.Add(Me.tsaldo)
        Me.GPAGO.Location = New System.Drawing.Point(10, 116)
        Me.GPAGO.Name = "GPAGO"
        Me.GPAGO.Size = New System.Drawing.Size(400, 185)
        Me.GPAGO.TabIndex = 116
        Me.GPAGO.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "COBRADOR"
        '
        'ccol
        '
        Me.ccol.FormattingEnabled = True
        Me.ccol.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE DEBITO", "TARJETA DE CREDITO"})
        Me.ccol.Location = New System.Drawing.Point(14, 147)
        Me.ccol.Name = "ccol"
        Me.ccol.Size = New System.Drawing.Size(371, 21)
        Me.ccol.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "METODO DE PAGO"
        '
        'cmetodo
        '
        Me.cmetodo.FormattingEnabled = True
        Me.cmetodo.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE DEBITO", "TARJETA DE CREDITO"})
        Me.cmetodo.Location = New System.Drawing.Point(14, 101)
        Me.cmetodo.Name = "cmetodo"
        Me.cmetodo.Size = New System.Drawing.Size(371, 21)
        Me.cmetodo.TabIndex = 72
        '
        'cfact
        '
        Me.cfact.AutoSize = True
        Me.cfact.Location = New System.Drawing.Point(15, 51)
        Me.cfact.Name = "cfact"
        Me.cfact.Size = New System.Drawing.Size(76, 17)
        Me.cfact.TabIndex = 67
        Me.cfact.Text = "FACTURA"
        Me.cfact.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 32)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "SALDO"
        '
        'tsaldo
        '
        Me.tsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.tsaldo.Location = New System.Drawing.Point(233, 19)
        Me.tsaldo.Name = "tsaldo"
        Me.tsaldo.Size = New System.Drawing.Size(158, 35)
        Me.tsaldo.TabIndex = 65
        Me.tsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(425, 48)
        Me.ToolStrip1.TabIndex = 121
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
        Me.bcancelar.Size = New System.Drawing.Size(66, 45)
        Me.bcancelar.Text = "REGRESAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bcancelar.ToolTipText = "REGRESAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 43)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "PAGOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'tfecha
        '
        Me.tfecha.CustomFormat = "yyyy-MM-dd"
        Me.tfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tfecha.Location = New System.Drawing.Point(288, 96)
        Me.tfecha.Name = "tfecha"
        Me.tfecha.Size = New System.Drawing.Size(107, 20)
        Me.tfecha.TabIndex = 161
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "FECHA:"
        '
        'frmpago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 516)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tfecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tfolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GEFECTIVO)
        Me.Controls.Add(Me.GMONTO)
        Me.Controls.Add(Me.GPAGO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpago"
        Me.Text = "frmpago"
        Me.GEFECTIVO.ResumeLayout(False)
        Me.GEFECTIVO.PerformLayout()
        Me.GMONTO.ResumeLayout(False)
        Me.GMONTO.PerformLayout()
        Me.GPAGO.ResumeLayout(False)
        Me.GPAGO.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GEFECTIVO As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tcambio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tpago As TextBox
    Friend WithEvents GMONTO As GroupBox
    Friend WithEvents LLETRAS1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tmonto As TextBox
    Friend WithEvents GPAGO As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmetodo As ComboBox
    Friend WithEvents cfact As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tsaldo As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ccol As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tfecha As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
