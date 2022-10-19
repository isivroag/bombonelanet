<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxhorario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmauxhorario))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chora = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chora2 = New System.Windows.Forms.ComboBox()
        Me.cdia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(404, 48)
        Me.ToolStrip1.TabIndex = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ENTRADA"
        '
        'chora
        '
        Me.chora.FormattingEnabled = True
        Me.chora.Location = New System.Drawing.Point(167, 114)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(106, 21)
        Me.chora.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(276, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "SALIDA"
        '
        'chora2
        '
        Me.chora2.FormattingEnabled = True
        Me.chora2.Location = New System.Drawing.Point(279, 114)
        Me.chora2.Name = "chora2"
        Me.chora2.Size = New System.Drawing.Size(106, 21)
        Me.chora2.TabIndex = 6
        '
        'cdia
        '
        Me.cdia.FormattingEnabled = True
        Me.cdia.Location = New System.Drawing.Point(19, 114)
        Me.cdia.Name = "cdia"
        Me.cdia.Size = New System.Drawing.Size(142, 21)
        Me.cdia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DIA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 43)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "HORARIO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'frmauxhorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 153)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cdia)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.chora2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chora)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmauxhorario"
        Me.Text = "frmauxhorario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents chora As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents chora2 As ComboBox
    Friend WithEvents cdia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
