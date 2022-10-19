<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproveedor
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
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tcorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdir = New System.Windows.Forms.TextBox()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.trfc = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(51, 305)
        Me.ttel.Mask = "(999)0000000"
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(155, 20)
        Me.ttel.TabIndex = 39
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(277, 305)
        Me.tcel.Mask = "(999)0000000"
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(155, 20)
        Me.tcel.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "CORREO"
        '
        'tcorreo
        '
        Me.tcorreo.Location = New System.Drawing.Point(51, 346)
        Me.tcorreo.Name = "tcorreo"
        Me.tcorreo.Size = New System.Drawing.Size(381, 20)
        Me.tcorreo.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "CELULAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DIRECCION"
        '
        'tdir
        '
        Me.tdir.Location = New System.Drawing.Point(51, 223)
        Me.tdir.Multiline = True
        Me.tdir.Name = "tdir"
        Me.tdir.Size = New System.Drawing.Size(381, 61)
        Me.tdir.TabIndex = 31
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
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(51, 181)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(381, 20)
        Me.tnombre.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID PROVEEDOR"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(51, 140)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(109, 20)
        Me.tid.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 43)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "PROVEEDOR"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(447, 48)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "NOMBRE O RAZÓN SOCIAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 15)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "RFC"
        '
        'trfc
        '
        Me.trfc.Location = New System.Drawing.Point(277, 140)
        Me.trfc.Name = "trfc"
        Me.trfc.Size = New System.Drawing.Size(155, 20)
        Me.trfc.TabIndex = 41
        '
        'frmproveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 395)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.trfc)
        Me.Controls.Add(Me.ttel)
        Me.Controls.Add(Me.tcel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tcorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdir)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmproveedor"
        Me.Text = "frmproveedor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tcorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tdir As TextBox
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents trfc As TextBox
End Class
