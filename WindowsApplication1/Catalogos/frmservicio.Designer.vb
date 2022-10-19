<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmservicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmservicio))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ctipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tdur = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "TIPO DE PRODUCTO/SERVICIO"
        '
        'ctipo
        '
        Me.ctipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipo.FormattingEnabled = True
        Me.ctipo.Location = New System.Drawing.Point(50, 275)
        Me.ctipo.Name = "ctipo"
        Me.ctipo.Size = New System.Drawing.Size(162, 21)
        Me.ctipo.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "DESCRIPCION"
        '
        'tdesc
        '
        Me.tdesc.Location = New System.Drawing.Point(50, 194)
        Me.tdesc.Multiline = True
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(381, 61)
        Me.tdesc.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "NOMBRE SERVICIO (DESC. CORTA)"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(50, 152)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(381, 20)
        Me.tnombre.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID SERVICIO"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(50, 111)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(109, 20)
        Me.tid.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 43)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "SERVICIO"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(450, 48)
        Me.ToolStrip1.TabIndex = 26
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "DURACION PROMEDIO (MIN)"
        '
        'tdur
        '
        Me.tdur.Location = New System.Drawing.Point(283, 276)
        Me.tdur.Name = "tdur"
        Me.tdur.Size = New System.Drawing.Size(148, 20)
        Me.tdur.TabIndex = 29
        '
        'frmservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 325)
        Me.Controls.Add(Me.tdur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ctipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmservicio"
        Me.Text = "frmservicio"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents ctipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tdesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents tdur As TextBox
End Class
