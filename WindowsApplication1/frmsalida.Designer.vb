<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalida
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bnuevo = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbuscar = New System.Windows.Forms.TextBox()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccabina = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnuevo, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 48)
        Me.ToolStrip1.TabIndex = 144
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.White
        Me.bnuevo.Image = Global.Bombonela.My.Resources.Resources.salir24
        Me.bnuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(50, 45)
        Me.bnuevo.Text = "SALIDA"
        Me.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bnuevo.ToolTipText = "DAR SALIDA AL VISITANTE"
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.BackColor = System.Drawing.Color.White
        Me.bcancelar.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.bcancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(41, 45)
        Me.bcancelar.Text = "SALIR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bcancelar.ToolTipText = "REGRESAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(409, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "VISITANTE"
        '
        'tbuscar
        '
        Me.tbuscar.Location = New System.Drawing.Point(412, 127)
        Me.tbuscar.Name = "tbuscar"
        Me.tbuscar.Size = New System.Drawing.Size(329, 20)
        Me.tbuscar.TabIndex = 142
        '
        'grdatos
        '
        Me.grdatos.AllowUserToAddRows = False
        Me.grdatos.AllowUserToDeleteRows = False
        Me.grdatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdatos.BackgroundColor = System.Drawing.Color.White
        Me.grdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdatos.EnableHeadersVisualStyles = False
        Me.grdatos.GridColor = System.Drawing.Color.White
        Me.grdatos.Location = New System.Drawing.Point(19, 163)
        Me.grdatos.MultiSelect = False
        Me.grdatos.Name = "grdatos"
        Me.grdatos.ReadOnly = True
        Me.grdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdatos.Size = New System.Drawing.Size(767, 325)
        Me.grdatos.TabIndex = 141
        Me.grdatos.VirtualMode = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "AREA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(67, 127)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(109, 20)
        Me.dtfecha.TabIndex = 138
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "AREA"
        '
        'ccabina
        '
        Me.ccabina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccabina.FormattingEnabled = True
        Me.ccabina.Location = New System.Drawing.Point(185, 125)
        Me.ccabina.Name = "ccabina"
        Me.ccabina.Size = New System.Drawing.Size(211, 21)
        Me.ccabina.TabIndex = 136
        Me.ccabina.Text = "TODOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 43)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "SERVICIOS ACTIVOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.UseCompatibleTextRendering = True
        '
        'frmsalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 513)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbuscar)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ccabina)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmsalida"
        Me.Text = "frmsalida"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bnuevo As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents tbuscar As TextBox
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ccabina As ComboBox
    Friend WithEvents Label3 As Label
End Class
