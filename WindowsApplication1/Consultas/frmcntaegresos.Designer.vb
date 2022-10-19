<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntaegresos
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.mncNUEVO = New System.Windows.Forms.ToolStripButton()
        Me.mncEDITAR = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtFin = New System.Windows.Forms.DateTimePicker()
        Me.DtInicio = New System.Windows.Forms.DateTimePicker()
        Me.grdetalle = New System.Windows.Forms.DataGridView()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.menuclientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuclientes
        '
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncNUEVO, Me.mncEDITAR, Me.mncSALIR, Me.mncIMPRIMIR})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuclientes.Size = New System.Drawing.Size(1075, 48)
        Me.menuclientes.TabIndex = 171
        Me.menuclientes.Text = "ToolStrip1"
        '
        'mncNUEVO
        '
        Me.mncNUEVO.BackColor = System.Drawing.Color.White
        Me.mncNUEVO.Image = Global.Bombonela.My.Resources.Resources.add_new_26
        Me.mncNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncNUEVO.Name = "mncNUEVO"
        Me.mncNUEVO.Size = New System.Drawing.Size(50, 45)
        Me.mncNUEVO.Text = "NUEVO"
        Me.mncNUEVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncEDITAR
        '
        Me.mncEDITAR.BackColor = System.Drawing.Color.White
        Me.mncEDITAR.Image = Global.Bombonela.My.Resources.Resources.edit_file_26
        Me.mncEDITAR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncEDITAR.Name = "mncEDITAR"
        Me.mncEDITAR.Size = New System.Drawing.Size(48, 45)
        Me.mncEDITAR.Text = "EDITAR"
        Me.mncEDITAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncSALIR
        '
        Me.mncSALIR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mncSALIR.BackColor = System.Drawing.Color.White
        Me.mncSALIR.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.mncSALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncSALIR.Name = "mncSALIR"
        Me.mncSALIR.Size = New System.Drawing.Size(41, 45)
        Me.mncSALIR.Text = "SALIR"
        Me.mncSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.PictureBox1.Location = New System.Drawing.Point(700, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(350, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "DESDE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(362, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 43)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "CONSULTA DE EGRESOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(517, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "HASTA:"
        '
        'DtFin
        '
        Me.DtFin.CustomFormat = "yyyy-MM-dd"
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFin.Location = New System.Drawing.Point(571, 118)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(107, 20)
        Me.DtFin.TabIndex = 165
        '
        'DtInicio
        '
        Me.DtInicio.CustomFormat = "yyyy-MM-dd"
        Me.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtInicio.Location = New System.Drawing.Point(404, 118)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(107, 20)
        Me.DtInicio.TabIndex = 164
        '
        'grdetalle
        '
        Me.grdetalle.AllowUserToAddRows = False
        Me.grdetalle.AllowUserToDeleteRows = False
        Me.grdetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.grdetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdetalle.BackgroundColor = System.Drawing.Color.White
        Me.grdetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdetalle.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdetalle.EnableHeadersVisualStyles = False
        Me.grdetalle.GridColor = System.Drawing.Color.White
        Me.grdetalle.Location = New System.Drawing.Point(12, 145)
        Me.grdetalle.MultiSelect = False
        Me.grdetalle.Name = "grdetalle"
        Me.grdetalle.ReadOnly = True
        Me.grdetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdetalle.Size = New System.Drawing.Size(1051, 423)
        Me.grdetalle.TabIndex = 172
        Me.grdetalle.VirtualMode = True
        '
        'mncIMPRIMIR
        '
        Me.mncIMPRIMIR.BackColor = System.Drawing.Color.White
        Me.mncIMPRIMIR.Image = Global.Bombonela.My.Resources.Resources.PRINT26
        Me.mncIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncIMPRIMIR.Name = "mncIMPRIMIR"
        Me.mncIMPRIMIR.Size = New System.Drawing.Size(63, 45)
        Me.mncIMPRIMIR.Text = "IMPRIMIR"
        Me.mncIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmcntaegresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 580)
        Me.Controls.Add(Me.grdetalle)
        Me.Controls.Add(Me.menuclientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtFin)
        Me.Controls.Add(Me.DtInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmcntaegresos"
        Me.Text = "frmcntaegresos"
        Me.menuclientes.ResumeLayout(False)
        Me.menuclientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuclientes As ToolStrip
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtFin As DateTimePicker
    Friend WithEvents DtInicio As DateTimePicker
    Friend WithEvents grdetalle As DataGridView
    Friend WithEvents mncEDITAR As ToolStripButton
    Friend WithEvents mncNUEVO As ToolStripButton
    Friend WithEvents mncIMPRIMIR As ToolStripButton
End Class
