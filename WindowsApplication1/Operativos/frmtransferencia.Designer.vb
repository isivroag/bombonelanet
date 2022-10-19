<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtransferencia))
        Me.tcant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.texistenciad = New System.Windows.Forms.TextBox()
        Me.calmacend = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texistenciao = New System.Windows.Forms.TextBox()
        Me.calmaceno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcant
        '
        Me.tcant.BackColor = System.Drawing.Color.Yellow
        Me.tcant.Location = New System.Drawing.Point(291, 345)
        Me.tcant.Name = "tcant"
        Me.tcant.Size = New System.Drawing.Size(102, 20)
        Me.tcant.TabIndex = 158
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "CANTIDAD"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.texistenciad)
        Me.GroupBox2.Controls.Add(Me.calmacend)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 76)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DESTINO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "EXISENCIAS EN ALM."
        '
        'texistenciad
        '
        Me.texistenciad.BackColor = System.Drawing.Color.White
        Me.texistenciad.Location = New System.Drawing.Point(259, 42)
        Me.texistenciad.Name = "texistenciad"
        Me.texistenciad.ReadOnly = True
        Me.texistenciad.Size = New System.Drawing.Size(102, 20)
        Me.texistenciad.TabIndex = 148
        '
        'calmacend
        '
        Me.calmacend.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacend.FormattingEnabled = True
        Me.calmacend.Items.AddRange(New Object() {"PIEZA"})
        Me.calmacend.Location = New System.Drawing.Point(16, 42)
        Me.calmacend.Name = "calmacend"
        Me.calmacend.Size = New System.Drawing.Size(214, 21)
        Me.calmacend.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "ALMACEN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(102, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 43)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "TRANSFERENCIAS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.UseCompatibleTextRendering = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.texistenciao)
        Me.GroupBox1.Controls.Add(Me.calmaceno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 76)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORIGEN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(239, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "EXISENCIAS EN ALM."
        '
        'texistenciao
        '
        Me.texistenciao.BackColor = System.Drawing.Color.White
        Me.texistenciao.Location = New System.Drawing.Point(259, 42)
        Me.texistenciao.Name = "texistenciao"
        Me.texistenciao.ReadOnly = True
        Me.texistenciao.Size = New System.Drawing.Size(102, 20)
        Me.texistenciao.TabIndex = 148
        '
        'calmaceno
        '
        Me.calmaceno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmaceno.FormattingEnabled = True
        Me.calmaceno.Items.AddRange(New Object() {"PIEZA"})
        Me.calmaceno.Location = New System.Drawing.Point(16, 42)
        Me.calmaceno.Name = "calmaceno"
        Me.calmaceno.Size = New System.Drawing.Size(214, 21)
        Me.calmaceno.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ALMACEN"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.tnombre)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.tid)
        Me.GroupBox.Location = New System.Drawing.Point(32, 90)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(378, 69)
        Me.GroupBox.TabIndex = 153
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(11, 31)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(70, 20)
        Me.tid.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 48)
        Me.ToolStrip1.TabIndex = 159
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
        'frmtransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 379)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tcant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmtransferencia"
        Me.Text = "frmtransferencia"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tcant As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents texistenciad As TextBox
    Friend WithEvents calmacend As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents texistenciao As TextBox
    Friend WithEvents calmaceno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
End Class
