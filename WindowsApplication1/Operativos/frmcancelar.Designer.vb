<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcancelar))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ltitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ccol = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ttipo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tmotivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(511, 48)
        Me.ToolStrip1.TabIndex = 24
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
        'ltitulo
        '
        Me.ltitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltitulo.Location = New System.Drawing.Point(0, 48)
        Me.ltitulo.Name = "ltitulo"
        Me.ltitulo.Size = New System.Drawing.Size(511, 43)
        Me.ltitulo.TabIndex = 25
        Me.ltitulo.Text = "CANCELAR"
        Me.ltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ltitulo.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.tfecha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ccol)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ttipo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tmotivo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tfolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 207)
        Me.Panel1.TabIndex = 162
        '
        'tfecha
        '
        Me.tfecha.CustomFormat = "yyyy-MM-dd"
        Me.tfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tfecha.Location = New System.Drawing.Point(359, 34)
        Me.tfecha.Name = "tfecha"
        Me.tfecha.Size = New System.Drawing.Size(107, 20)
        Me.tfecha.TabIndex = 169
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "RESPONSABLE"
        '
        'ccol
        '
        Me.ccol.FormattingEnabled = True
        Me.ccol.Location = New System.Drawing.Point(15, 166)
        Me.ccol.Name = "ccol"
        Me.ccol.Size = New System.Drawing.Size(451, 21)
        Me.ccol.TabIndex = 166
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(161, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "TIPO"
        '
        'ttipo
        '
        Me.ttipo.Enabled = False
        Me.ttipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttipo.Location = New System.Drawing.Point(164, 34)
        Me.ttipo.Name = "ttipo"
        Me.ttipo.Size = New System.Drawing.Size(169, 22)
        Me.ttipo.TabIndex = 164
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "MOTIVO DE CANCELACION"
        '
        'tmotivo
        '
        Me.tmotivo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmotivo.Location = New System.Drawing.Point(15, 79)
        Me.tmotivo.Multiline = True
        Me.tmotivo.Name = "tmotivo"
        Me.tmotivo.Size = New System.Drawing.Size(451, 66)
        Me.tmotivo.TabIndex = 162
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
        'tfolio
        '
        Me.tfolio.Enabled = False
        Me.tfolio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfolio.Location = New System.Drawing.Point(15, 36)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(100, 22)
        Me.tfolio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FECHA"
        '
        'frmcancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ltitulo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcancelar"
        Me.Text = "frmcancelar"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents ltitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents ttipo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tmotivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ccol As ComboBox
    Friend WithEvents tfecha As DateTimePicker
End Class
