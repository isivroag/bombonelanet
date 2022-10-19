<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecepcion
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccabina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbuscar = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bnuevo = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(61, 134)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(109, 20)
        Me.dtfecha.TabIndex = 126
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "AREA"
        '
        'ccabina
        '
        Me.ccabina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccabina.FormattingEnabled = True
        Me.ccabina.Location = New System.Drawing.Point(179, 132)
        Me.ccabina.Name = "ccabina"
        Me.ccabina.Size = New System.Drawing.Size(211, 21)
        Me.ccabina.TabIndex = 124
        Me.ccabina.Text = "TODOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "AREA"
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
        Me.grdatos.Location = New System.Drawing.Point(12, 220)
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
        Me.grdatos.TabIndex = 131
        Me.grdatos.VirtualMode = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "VISITANTE"
        '
        'tbuscar
        '
        Me.tbuscar.Location = New System.Drawing.Point(406, 134)
        Me.tbuscar.Name = "tbuscar"
        Me.tbuscar.Size = New System.Drawing.Size(329, 20)
        Me.tbuscar.TabIndex = 132
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnuevo, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(793, 48)
        Me.ToolStrip1.TabIndex = 134
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.White
        Me.bnuevo.Image = Global.Bombonela.My.Resources.Resources.ENTRAR24
        Me.bnuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(64, 45)
        Me.bnuevo.Text = "ENTRADA"
        Me.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bnuevo.ToolTipText = "DAR ENTRADA AL VISITANTE"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(356, 43)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "RECEPCION DE VISITANTES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 43)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "CITAS CALENDARIZADAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseCompatibleTextRendering = True
        '
        'frmrecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(793, 557)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbuscar)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ccabina)
        Me.Name = "frmrecepcion"
        Me.Text = "frmrecepcion"
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ccabina As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents tbuscar As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents bnuevo As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
