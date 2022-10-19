<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaquete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpaquete))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "SERVICIO"
        '
        'tnombre
        '
        Me.tnombre.Enabled = False
        Me.tnombre.Location = New System.Drawing.Point(156, 125)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(381, 20)
        Me.tnombre.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 43)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PRECIOS Y PAQUETES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(578, 48)
        Me.ToolStrip1.TabIndex = 28
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
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(51, 125)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(99, 20)
        Me.tid.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "DESCRIPCION PAQUETE"
        '
        'tdesc
        '
        Me.tdesc.Location = New System.Drawing.Point(51, 207)
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(486, 20)
        Me.tdesc.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "CANTIDAD (UNIDADES/SESIONES)"
        '
        'tcantidad
        '
        Me.tcantidad.Location = New System.Drawing.Point(51, 248)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(158, 20)
        Me.tcantidad.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "PRECIO"
        '
        'tprecio
        '
        Me.tprecio.Location = New System.Drawing.Point(379, 247)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(158, 20)
        Me.tprecio.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "CLAVE"
        '
        'tclave
        '
        Me.tclave.Location = New System.Drawing.Point(51, 166)
        Me.tclave.Name = "tclave"
        Me.tclave.Size = New System.Drawing.Size(158, 20)
        Me.tclave.TabIndex = 39
        '
        'frmpaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 294)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tclave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tprecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdesc)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tnombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpaquete"
        Me.Text = "frmpaquete"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents tid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tdesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tcantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tprecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tclave As TextBox
End Class
