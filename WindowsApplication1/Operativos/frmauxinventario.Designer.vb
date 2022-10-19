<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxinventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmauxinventario))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texistencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.calmacen = New System.Windows.Forms.ComboBox()
        Me.ctipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(407, 48)
        Me.ToolStrip1.TabIndex = 9
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
        Me.bcancelar.Size = New System.Drawing.Size(71, 45)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(16, 113)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(345, 71)
        Me.tobs.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 43)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "MOVIMIENTO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.UseCompatibleTextRendering = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.tnombre)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.tid)
        Me.GroupBox.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(378, 69)
        Me.GroupBox.TabIndex = 81
        Me.GroupBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(87, 31)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(274, 20)
        Me.tnombre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(11, 31)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(70, 20)
        Me.tid.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.texistencia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tcantidad)
        Me.GroupBox1.Controls.Add(Me.tobs)
        Me.GroupBox1.Controls.Add(Me.calmacen)
        Me.GroupBox1.Controls.Add(Me.ctipo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 202)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(239, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "EXISENCIAS EN ALM."
        '
        'texistencia
        '
        Me.texistencia.BackColor = System.Drawing.Color.White
        Me.texistencia.Location = New System.Drawing.Point(259, 29)
        Me.texistencia.Name = "texistencia"
        Me.texistencia.ReadOnly = True
        Me.texistencia.Size = New System.Drawing.Size(102, 20)
        Me.texistencia.TabIndex = 148
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "OBSERVACIONES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "CANTIDAD"
        '
        'tcantidad
        '
        Me.tcantidad.BackColor = System.Drawing.Color.Yellow
        Me.tcantidad.Location = New System.Drawing.Point(16, 72)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(96, 20)
        Me.tcantidad.TabIndex = 144
        '
        'calmacen
        '
        Me.calmacen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacen.FormattingEnabled = True
        Me.calmacen.Items.AddRange(New Object() {"PIEZA"})
        Me.calmacen.Location = New System.Drawing.Point(16, 29)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(214, 21)
        Me.calmacen.TabIndex = 20
        '
        'ctipo
        '
        Me.ctipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipo.FormattingEnabled = True
        Me.ctipo.Location = New System.Drawing.Point(118, 72)
        Me.ctipo.Name = "ctipo"
        Me.ctipo.Size = New System.Drawing.Size(243, 21)
        Me.ctipo.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "ALMACEN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(115, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "TIPO DE MOVIMIENTO"
        '
        'frmauxinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(407, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmauxinventario"
        Me.Text = "frmauxinventario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents texistencia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tcantidad As TextBox
    Friend WithEvents calmacen As ComboBox
    Friend WithEvents ctipo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
