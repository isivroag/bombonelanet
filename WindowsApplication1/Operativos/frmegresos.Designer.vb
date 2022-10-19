<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmegresos
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tid_prov = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tfecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cpartida = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmetodo = New System.Windows.Forms.ComboBox()
        Me.cfact = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tfact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.csubpartida = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(271, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 43)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "EGRESOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(671, 48)
        Me.ToolStrip1.TabIndex = 160
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tid_prov
        '
        Me.tid_prov.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tid_prov.Location = New System.Drawing.Point(15, 77)
        Me.tid_prov.Name = "tid_prov"
        Me.tid_prov.Size = New System.Drawing.Size(100, 22)
        Me.tid_prov.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PROVEEDOR"
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.Location = New System.Drawing.Point(121, 77)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(477, 22)
        Me.tnombre.TabIndex = 7
        '
        'tfecha
        '
        Me.tfecha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfecha.Location = New System.Drawing.Point(531, 36)
        Me.tfecha.Name = "tfecha"
        Me.tfecha.Size = New System.Drawing.Size(100, 22)
        Me.tfecha.TabIndex = 4
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
        'tfolio
        '
        Me.tfolio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfolio.Location = New System.Drawing.Point(15, 36)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(100, 22)
        Me.tfolio.TabIndex = 3
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
        'ttotal
        '
        Me.ttotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(507, 249)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(124, 22)
        Me.ttotal.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(504, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TOTAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(607, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'cpartida
        '
        Me.cpartida.FormattingEnabled = True
        Me.cpartida.Location = New System.Drawing.Point(15, 120)
        Me.cpartida.Name = "cpartida"
        Me.cpartida.Size = New System.Drawing.Size(217, 21)
        Me.cpartida.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "PARTIDA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmetodo)
        Me.Panel1.Controls.Add(Me.cfact)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tfact)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tdesc)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.csubpartida)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cpartida)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ttotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tfolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tfecha)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid_prov)
        Me.Panel1.Location = New System.Drawing.Point(9, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 288)
        Me.Panel1.TabIndex = 161
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "METODO DE PAGO"
        '
        'cmetodo
        '
        Me.cmetodo.FormattingEnabled = True
        Me.cmetodo.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE DEBITO", "TARJETA DE CREDITO", "TRANSFERENCIA", "CHEQUE", "OTRO"})
        Me.cmetodo.Location = New System.Drawing.Point(15, 249)
        Me.cmetodo.Name = "cmetodo"
        Me.cmetodo.Size = New System.Drawing.Size(177, 21)
        Me.cmetodo.TabIndex = 167
        '
        'cfact
        '
        Me.cfact.AutoSize = True
        Me.cfact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cfact.Location = New System.Drawing.Point(249, 36)
        Me.cfact.Name = "cfact"
        Me.cfact.Size = New System.Drawing.Size(96, 19)
        Me.cfact.TabIndex = 166
        Me.cfact.Text = "FACTURADO"
        Me.cfact.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(353, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "FACTURA O REF"
        '
        'tfact
        '
        Me.tfact.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfact.Location = New System.Drawing.Point(356, 36)
        Me.tfact.Name = "tfact"
        Me.tfact.Size = New System.Drawing.Size(169, 22)
        Me.tfact.TabIndex = 164
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "CONCEPTO"
        '
        'tdesc
        '
        Me.tdesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdesc.Location = New System.Drawing.Point(15, 162)
        Me.tdesc.Multiline = True
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(616, 66)
        Me.tdesc.TabIndex = 162
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "SUBPARTIDA"
        '
        'csubpartida
        '
        Me.csubpartida.FormattingEnabled = True
        Me.csubpartida.Location = New System.Drawing.Point(414, 120)
        Me.csubpartida.Name = "csubpartida"
        Me.csubpartida.Size = New System.Drawing.Size(217, 21)
        Me.csubpartida.TabIndex = 160
        '
        'frmegresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(671, 395)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmegresos"
        Me.Text = "frmegresos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tid_prov As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents tfecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ttotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cpartida As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents tfact As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tdesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents csubpartida As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmetodo As ComboBox
    Friend WithEvents cfact As CheckBox
End Class
