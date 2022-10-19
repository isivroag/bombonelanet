<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabrircaja
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tinicial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(307, 48)
        Me.ToolStrip1.TabIndex = 6
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 43)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "APERTURA DE CAJA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "MONTO INICIAL"
        '
        'tinicial
        '
        Me.tinicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tinicial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tinicial.Location = New System.Drawing.Point(55, 153)
        Me.tinicial.Name = "tinicial"
        Me.tinicial.Size = New System.Drawing.Size(197, 22)
        Me.tinicial.TabIndex = 26
        Me.tinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "FECHA"
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(99, 114)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtFecha.TabIndex = 181
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
        'frmabrircaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(307, 206)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tinicial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmabrircaja"
        Me.Text = "frmabrircaja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tinicial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents bcancelar As ToolStripButton
End Class
