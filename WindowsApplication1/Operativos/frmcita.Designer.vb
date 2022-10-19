<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcita))
        Me.tclie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid_clie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tserv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tid_serv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ccol = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.chora2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chora = New System.Windows.Forms.ComboBox()
        Me.ccabina = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bbservicio = New System.Windows.Forms.Button()
        Me.Panelc = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ttipop = New System.Windows.Forms.TextBox()
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bbprospecto = New System.Windows.Forms.Button()
        Me.bbcliente = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.Panelc.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tclie
        '
        Me.tclie.Location = New System.Drawing.Point(128, 27)
        Me.tclie.Name = "tclie"
        Me.tclie.Size = New System.Drawing.Size(338, 20)
        Me.tclie.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'tid_clie
        '
        Me.tid_clie.Enabled = False
        Me.tid_clie.Location = New System.Drawing.Point(18, 27)
        Me.tid_clie.Name = "tid_clie"
        Me.tid_clie.Size = New System.Drawing.Size(104, 20)
        Me.tid_clie.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "VISITANTE"
        '
        'tserv
        '
        Me.tserv.Location = New System.Drawing.Point(129, 29)
        Me.tserv.Name = "tserv"
        Me.tserv.Size = New System.Drawing.Size(383, 20)
        Me.tserv.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID SERVICIO"
        '
        'tid_serv
        '
        Me.tid_serv.Enabled = False
        Me.tid_serv.Location = New System.Drawing.Point(19, 29)
        Me.tid_serv.Name = "tid_serv"
        Me.tid_serv.Size = New System.Drawing.Size(104, 20)
        Me.tid_serv.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SERVICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "COLABORADOR"
        '
        'ccol
        '
        Me.ccol.FormattingEnabled = True
        Me.ccol.Location = New System.Drawing.Point(18, 129)
        Me.ccol.Name = "ccol"
        Me.ccol.Size = New System.Drawing.Size(495, 21)
        Me.ccol.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(527, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 11)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "BUSCAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 11)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "PROSPECTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(474, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 11)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "VISITANTE"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Label17)
        Me.Panel.Controls.Add(Me.Label16)
        Me.Panel.Controls.Add(Me.tobs)
        Me.Panel.Controls.Add(Me.chora2)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.dtfecha)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.chora)
        Me.Panel.Controls.Add(Me.ccabina)
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.Label11)
        Me.Panel.Controls.Add(Me.Label8)
        Me.Panel.Controls.Add(Me.bbservicio)
        Me.Panel.Controls.Add(Me.ccol)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.tid_serv)
        Me.Panel.Controls.Add(Me.tserv)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Location = New System.Drawing.Point(16, 216)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(580, 253)
        Me.Panel.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "NOTAS/OBSERVACIONES"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(236, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "FINAL"
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(19, 171)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(494, 69)
        Me.tobs.TabIndex = 15
        '
        'chora2
        '
        Me.chora2.Enabled = False
        Me.chora2.FormattingEnabled = True
        Me.chora2.Location = New System.Drawing.Point(239, 70)
        Me.chora2.Name = "chora2"
        Me.chora2.Size = New System.Drawing.Size(106, 21)
        Me.chora2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(17, 70)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(104, 20)
        Me.dtfecha.TabIndex = 9
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INICIO"
        '
        'chora
        '
        Me.chora.FormattingEnabled = True
        Me.chora.Location = New System.Drawing.Point(127, 69)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(106, 21)
        Me.chora.TabIndex = 10
        '
        'ccabina
        '
        Me.ccabina.FormattingEnabled = True
        Me.ccabina.Location = New System.Drawing.Point(359, 69)
        Me.ccabina.Name = "ccabina"
        Me.ccabina.Size = New System.Drawing.Size(153, 21)
        Me.ccabina.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "AREA DE SERVICIO"
        '
        'bbservicio
        '
        Me.bbservicio.AutoSize = True
        Me.bbservicio.BackColor = System.Drawing.Color.White
        Me.bbservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbservicio.ForeColor = System.Drawing.Color.Black
        Me.bbservicio.Image = Global.Bombonela.My.Resources.Resources.servicios32
        Me.bbservicio.Location = New System.Drawing.Point(523, 21)
        Me.bbservicio.Name = "bbservicio"
        Me.bbservicio.Size = New System.Drawing.Size(45, 40)
        Me.bbservicio.TabIndex = 5
        Me.bbservicio.UseVisualStyleBackColor = False
        '
        'Panelc
        '
        Me.Panelc.Controls.Add(Me.Label18)
        Me.Panelc.Controls.Add(Me.Label15)
        Me.Panelc.Controls.Add(Me.ttipop)
        Me.Panelc.Controls.Add(Me.ttel)
        Me.Panelc.Controls.Add(Me.tcel)
        Me.Panelc.Controls.Add(Me.Label12)
        Me.Panelc.Controls.Add(Me.Label13)
        Me.Panelc.Controls.Add(Me.Label2)
        Me.Panelc.Controls.Add(Me.Label5)
        Me.Panelc.Controls.Add(Me.Label9)
        Me.Panelc.Controls.Add(Me.tid_clie)
        Me.Panelc.Controls.Add(Me.Label10)
        Me.Panelc.Controls.Add(Me.tclie)
        Me.Panelc.Controls.Add(Me.bbprospecto)
        Me.Panelc.Controls.Add(Me.bbcliente)
        Me.Panelc.Location = New System.Drawing.Point(16, 94)
        Me.Panelc.Name = "Panelc"
        Me.Panelc.Size = New System.Drawing.Size(580, 116)
        Me.Panelc.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(502, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 11)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "BUSCAR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(338, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "TIPO DE VISITANTE"
        '
        'ttipop
        '
        Me.ttipop.Enabled = False
        Me.ttipop.Location = New System.Drawing.Point(341, 83)
        Me.ttipop.Name = "ttipop"
        Me.ttipop.Size = New System.Drawing.Size(127, 20)
        Me.ttipop.TabIndex = 13
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(19, 83)
        Me.ttel.Mask = "(999)0000000"
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(155, 20)
        Me.ttel.TabIndex = 11
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(180, 83)
        Me.tcel.Mask = "(999)0000000"
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(155, 20)
        Me.tcel.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(177, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "CELULAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "TELEFONO"
        '
        'bbprospecto
        '
        Me.bbprospecto.AutoSize = True
        Me.bbprospecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbprospecto.ForeColor = System.Drawing.Color.Black
        Me.bbprospecto.Image = Global.Bombonela.My.Resources.Resources.PROSPECTO32
        Me.bbprospecto.Location = New System.Drawing.Point(523, 31)
        Me.bbprospecto.Name = "bbprospecto"
        Me.bbprospecto.Size = New System.Drawing.Size(45, 40)
        Me.bbprospecto.TabIndex = 7
        Me.bbprospecto.UseVisualStyleBackColor = True
        '
        'bbcliente
        '
        Me.bbcliente.AutoSize = True
        Me.bbcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbcliente.ForeColor = System.Drawing.Color.Black
        Me.bbcliente.Image = Global.Bombonela.My.Resources.Resources.woman32
        Me.bbcliente.Location = New System.Drawing.Point(472, 31)
        Me.bbcliente.Name = "bbcliente"
        Me.bbcliente.Size = New System.Drawing.Size(45, 40)
        Me.bbcliente.TabIndex = 6
        Me.bbcliente.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(609, 48)
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(153, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(314, 43)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "CALENDARIO DE CITAS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label14.UseCompatibleTextRendering = True
        '
        'frmcita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 485)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panelc)
        Me.Controls.Add(Me.Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcita"
        Me.Text = "BOMBONELA: CITAS"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panelc.ResumeLayout(False)
        Me.Panelc.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tclie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid_clie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tserv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tid_serv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bbservicio As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ccol As ComboBox
    Friend WithEvents bbcliente As Button
    Friend WithEvents bbprospecto As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Panelc As Panel
    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ttipop As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents chora As ComboBox
    Friend WithEvents ccabina As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents chora2 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label18 As Label
End Class
