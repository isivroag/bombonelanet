<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cunidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tclave = New System.Windows.Forms.TextBox()
        Me.tcosto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cvend = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmarca = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 43)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "PRODUCTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(450, 45)
        Me.ToolStrip1.TabIndex = 38
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bguardar
        '
        Me.bguardar.BackColor = System.Drawing.Color.White
        Me.bguardar.Image = Global.Bombonela.My.Resources.Resources.save_26
        Me.bguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(65, 42)
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
        Me.bcancelar.Size = New System.Drawing.Size(66, 42)
        Me.bcancelar.Text = "REGRESAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "UNIDAD"
        '
        'cunidad
        '
        Me.cunidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cunidad.FormattingEnabled = True
        Me.cunidad.Items.AddRange(New Object() {"PIEZA", "BOLSA", "BOTELLA"})
        Me.cunidad.Location = New System.Drawing.Point(187, 186)
        Me.cunidad.Name = "cunidad"
        Me.cunidad.Size = New System.Drawing.Size(129, 21)
        Me.cunidad.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "NOMBRE PRODUCTO"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(50, 144)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(381, 20)
        Me.tnombre.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ID PRODUCTO"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(50, 103)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(109, 20)
        Me.tid.TabIndex = 31
        '
        'tprecio
        '
        Me.tprecio.Location = New System.Drawing.Point(53, 235)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(162, 20)
        Me.tprecio.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "PRECIO PUBLICO"
        '
        'tmin
        '
        Me.tmin.Location = New System.Drawing.Point(347, 186)
        Me.tmin.Name = "tmin"
        Me.tmin.Size = New System.Drawing.Size(84, 20)
        Me.tmin.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "MIN EN INVENT."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CLAVE PRODUCTO"
        '
        'tclave
        '
        Me.tclave.Location = New System.Drawing.Point(289, 103)
        Me.tclave.Name = "tclave"
        Me.tclave.Size = New System.Drawing.Size(142, 20)
        Me.tclave.TabIndex = 45
        '
        'tcosto
        '
        Me.tcosto.Location = New System.Drawing.Point(276, 235)
        Me.tcosto.Name = "tcosto"
        Me.tcosto.Size = New System.Drawing.Size(162, 20)
        Me.tcosto.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "COSTO"
        '
        'cvend
        '
        Me.cvend.AutoSize = True
        Me.cvend.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvend.Location = New System.Drawing.Point(17, 272)
        Me.cvend.Name = "cvend"
        Me.cvend.Size = New System.Drawing.Size(82, 19)
        Me.cvend.TabIndex = 68
        Me.cvend.Text = "VENDIBLE"
        Me.cvend.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "MARCA"
        '
        'cmarca
        '
        Me.cmarca.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmarca.FormattingEnabled = True
        Me.cmarca.Items.AddRange(New Object() {"PIEZA", "BOLSA", "BOTELLA"})
        Me.cmarca.Location = New System.Drawing.Point(50, 186)
        Me.cmarca.Name = "cmarca"
        Me.cmarca.Size = New System.Drawing.Size(129, 21)
        Me.cmarca.TabIndex = 70
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 312)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmarca)
        Me.Controls.Add(Me.cvend)
        Me.Controls.Add(Me.tcosto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tclave)
        Me.Controls.Add(Me.tmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cunidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.tprecio)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmproducto"
        Me.Text = "frmproducto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cunidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents tprecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tmin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tclave As TextBox
    Friend WithEvents tcosto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cvend As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmarca As ComboBox
End Class
