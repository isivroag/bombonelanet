<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxcobranza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmauxcobranza))
        Me.tconcepto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.tpreciol = New System.Windows.Forms.TextBox()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsesiones = New System.Windows.Forms.Label()
        Me.tsesiones = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.chdescuento = New System.Windows.Forms.CheckBox()
        Me.chcortesia = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tconcepto
        '
        Me.tconcepto.Enabled = False
        Me.tconcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tconcepto.Location = New System.Drawing.Point(21, 145)
        Me.tconcepto.Name = "tconcepto"
        Me.tconcepto.Size = New System.Drawing.Size(428, 22)
        Me.tconcepto.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CLAVE"
        '
        'tclave
        '
        Me.tclave.Enabled = False
        Me.tclave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tclave.Location = New System.Drawing.Point(21, 104)
        Me.tclave.Name = "tclave"
        Me.tclave.Size = New System.Drawing.Size(100, 22)
        Me.tclave.TabIndex = 11
        '
        'tpreciol
        '
        Me.tpreciol.BackColor = System.Drawing.SystemColors.Window
        Me.tpreciol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpreciol.Location = New System.Drawing.Point(21, 192)
        Me.tpreciol.Name = "tpreciol"
        Me.tpreciol.Size = New System.Drawing.Size(100, 22)
        Me.tpreciol.TabIndex = 13
        Me.tpreciol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tcantidad
        '
        Me.tcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tcantidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcantidad.Location = New System.Drawing.Point(349, 192)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(100, 22)
        Me.tcantidad.TabIndex = 14
        Me.tcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ttotal
        '
        Me.ttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ttotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(457, 192)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(100, 22)
        Me.ttotal.TabIndex = 15
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PRECIO LISTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CANTIDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(454, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "CONCEPTO"
        '
        'lsesiones
        '
        Me.lsesiones.AutoSize = True
        Me.lsesiones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsesiones.Location = New System.Drawing.Point(452, 129)
        Me.lsesiones.Name = "lsesiones"
        Me.lsesiones.Size = New System.Drawing.Size(57, 13)
        Me.lsesiones.TabIndex = 22
        Me.lsesiones.Text = "SESIONES"
        '
        'tsesiones
        '
        Me.tsesiones.Enabled = False
        Me.tsesiones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsesiones.Location = New System.Drawing.Point(455, 145)
        Me.tsesiones.Name = "tsesiones"
        Me.tsesiones.Size = New System.Drawing.Size(100, 22)
        Me.tsesiones.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(569, 48)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bguardar
        '
        Me.bguardar.BackColor = System.Drawing.Color.White
        Me.bguardar.Image = Global.Bombonela.My.Resources.Resources.OK26
        Me.bguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(60, 45)
        Me.bguardar.Text = "ACEPTAR"
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
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(421, 43)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "AGREGAR PRODUCTO/SERVICIO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(236, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "PRECIO FINAL"
        '
        'tdesc
        '
        Me.tdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tdesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdesc.Location = New System.Drawing.Point(127, 192)
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(100, 22)
        Me.tdesc.TabIndex = 25
        Me.tdesc.Text = "0"
        Me.tdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "DESCUENTO"
        '
        'tprecio
        '
        Me.tprecio.BackColor = System.Drawing.SystemColors.Window
        Me.tprecio.Enabled = False
        Me.tprecio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tprecio.Location = New System.Drawing.Point(233, 192)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(100, 22)
        Me.tprecio.TabIndex = 27
        Me.tprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chdescuento
        '
        Me.chdescuento.AutoSize = True
        Me.chdescuento.BackColor = System.Drawing.Color.Transparent
        Me.chdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdescuento.Location = New System.Drawing.Point(127, 173)
        Me.chdescuento.Name = "chdescuento"
        Me.chdescuento.Size = New System.Drawing.Size(35, 17)
        Me.chdescuento.TabIndex = 29
        Me.chdescuento.Text = "%"
        Me.chdescuento.UseVisualStyleBackColor = False
        '
        'chcortesia
        '
        Me.chcortesia.AutoSize = True
        Me.chcortesia.BackColor = System.Drawing.Color.Transparent
        Me.chcortesia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcortesia.Location = New System.Drawing.Point(469, 104)
        Me.chcortesia.Name = "chcortesia"
        Me.chcortesia.Size = New System.Drawing.Size(88, 17)
        Me.chcortesia.TabIndex = 30
        Me.chcortesia.Text = "CORTESÍA"
        Me.chcortesia.UseVisualStyleBackColor = False
        '
        'frmauxcobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 236)
        Me.Controls.Add(Me.chcortesia)
        Me.Controls.Add(Me.chdescuento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tprecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tdesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsesiones)
        Me.Controls.Add(Me.tsesiones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.tcantidad)
        Me.Controls.Add(Me.tpreciol)
        Me.Controls.Add(Me.tconcepto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tclave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmauxcobranza"
        Me.Text = "Agregar Concepto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tconcepto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tclave As TextBox
    Friend WithEvents tpreciol As TextBox
    Friend WithEvents tcantidad As TextBox
    Friend WithEvents ttotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lsesiones As Label
    Friend WithEvents tsesiones As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tdesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tprecio As TextBox
    Friend WithEvents chdescuento As CheckBox
    Friend WithEvents chcortesia As CheckBox
End Class
