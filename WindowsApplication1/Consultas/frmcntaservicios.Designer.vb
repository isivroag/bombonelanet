﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntaservicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcntaservicios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.menuclientes = New System.Windows.Forms.ToolStrip()
        Me.mncNUEVO = New System.Windows.Forms.ToolStripButton()
        Me.mncEDITAR = New System.Windows.Forms.ToolStripButton()
        Me.mncpaquetes = New System.Windows.Forms.ToolStripButton()
        Me.mncELIMINAR = New System.Windows.Forms.ToolStripButton()
        Me.mncIMPRIMIR = New System.Windows.Forms.ToolStripButton()
        Me.mncSALIR = New System.Windows.Forms.ToolStripButton()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.tnombre = New System.Windows.Forms.TextBox()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuclientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(285, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 43)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "LISTADO DE SERVICIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
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
        Me.grdatos.Location = New System.Drawing.Point(12, 155)
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
        Me.grdatos.Size = New System.Drawing.Size(851, 279)
        Me.grdatos.TabIndex = 14
        Me.grdatos.VirtualMode = True
        '
        'menuclientes
        '
        Me.menuclientes.AutoSize = False
        Me.menuclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.menuclientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuclientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncNUEVO, Me.mncEDITAR, Me.mncpaquetes, Me.mncELIMINAR, Me.mncIMPRIMIR, Me.mncSALIR})
        Me.menuclientes.Location = New System.Drawing.Point(0, 0)
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.Size = New System.Drawing.Size(875, 48)
        Me.menuclientes.TabIndex = 12
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
        'mncpaquetes
        '
        Me.mncpaquetes.BackColor = System.Drawing.Color.White
        Me.mncpaquetes.Image = Global.Bombonela.My.Resources.Resources.PAGO26
        Me.mncpaquetes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncpaquetes.Name = "mncpaquetes"
        Me.mncpaquetes.Size = New System.Drawing.Size(57, 45)
        Me.mncpaquetes.Text = "PRECIOS"
        Me.mncpaquetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mncELIMINAR
        '
        Me.mncELIMINAR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncELIMINAR.Name = "mncELIMINAR"
        Me.mncELIMINAR.Size = New System.Drawing.Size(64, 45)
        Me.mncELIMINAR.Text = "ELIMINAR"
        Me.mncELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mncELIMINAR.Visible = False
        '
        'mncIMPRIMIR
        '
        Me.mncIMPRIMIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncIMPRIMIR.Name = "mncIMPRIMIR"
        Me.mncIMPRIMIR.Size = New System.Drawing.Size(63, 45)
        Me.mncIMPRIMIR.Text = "IMPRIMIR"
        Me.mncIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mncIMPRIMIR.Visible = False
        '
        'mncSALIR
        '
        Me.mncSALIR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mncSALIR.BackColor = System.Drawing.Color.White
        Me.mncSALIR.Image = Global.Bombonela.My.Resources.Resources.exit_26
        Me.mncSALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncSALIR.Name = "mncSALIR"
        Me.mncSALIR.Size = New System.Drawing.Size(41, 45)
        Me.mncSALIR.Text = "SALIR"
        Me.mncSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.White
        Me.bbuscar.BackgroundImage = Global.Bombonela.My.Resources.Resources.BUSCAR24
        Me.bbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.bbuscar.FlatAppearance.BorderSize = 2
        Me.bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bbuscar.Location = New System.Drawing.Point(577, 111)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(109, 28)
        Me.bbuscar.TabIndex = 167
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'tnombre
        '
        Me.tnombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombre.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.tnombre.Location = New System.Drawing.Point(189, 113)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(382, 25)
        Me.tnombre.TabIndex = 166
        Me.tnombre.Text = "INTRODUZCA EL VALOR BUSCADO"
        '
        'frmcntaservicios
        '
        Me.AcceptButton = Me.bbuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 446)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.menuclientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcntaservicios"
        Me.Text = "frmcntaservicios"
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuclientes.ResumeLayout(False)
        Me.menuclientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents menuclientes As ToolStrip
    Friend WithEvents mncNUEVO As ToolStripButton
    Friend WithEvents mncEDITAR As ToolStripButton
    Friend WithEvents mncELIMINAR As ToolStripButton
    Friend WithEvents mncIMPRIMIR As ToolStripButton
    Friend WithEvents mncSALIR As ToolStripButton
    Friend WithEvents mncpaquetes As ToolStripButton
    Friend WithEvents bbuscar As Button
    Friend WithEvents tnombre As TextBox
End Class
