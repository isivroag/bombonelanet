<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxcita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmauxcita))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chora2n = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfechan = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.choran = New System.Windows.Forms.ComboBox()
        Me.ccabinan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ccoln = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Panelc = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chora2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.ccol = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chora = New System.Windows.Forms.ComboBox()
        Me.ccabina = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tid_clie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid_serv = New System.Windows.Forms.TextBox()
        Me.tserv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tclie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panelc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Label16)
        Me.Panel.Controls.Add(Me.chora2n)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.dtfechan)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.choran)
        Me.Panel.Controls.Add(Me.ccabinan)
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.Label8)
        Me.Panel.Controls.Add(Me.ccoln)
        Me.Panel.Location = New System.Drawing.Point(12, 308)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(527, 123)
        Me.Panel.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(238, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "FINAL"
        '
        'chora2n
        '
        Me.chora2n.Enabled = False
        Me.chora2n.FormattingEnabled = True
        Me.chora2n.Location = New System.Drawing.Point(241, 40)
        Me.chora2n.Name = "chora2n"
        Me.chora2n.Size = New System.Drawing.Size(106, 21)
        Me.chora2n.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FECHA"
        '
        'dtfechan
        '
        Me.dtfechan.CustomFormat = "yyyy-MM-dd"
        Me.dtfechan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechan.Location = New System.Drawing.Point(19, 40)
        Me.dtfechan.Name = "dtfechan"
        Me.dtfechan.Size = New System.Drawing.Size(104, 20)
        Me.dtfechan.TabIndex = 9
        Me.dtfechan.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INICIO"
        '
        'choran
        '
        Me.choran.FormattingEnabled = True
        Me.choran.Location = New System.Drawing.Point(129, 39)
        Me.choran.Name = "choran"
        Me.choran.Size = New System.Drawing.Size(106, 21)
        Me.choran.TabIndex = 10
        '
        'ccabinan
        '
        Me.ccabinan.FormattingEnabled = True
        Me.ccabinan.Location = New System.Drawing.Point(361, 39)
        Me.ccabinan.Name = "ccabinan"
        Me.ccabinan.Size = New System.Drawing.Size(153, 21)
        Me.ccabinan.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "AREA DE SERVICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "COLABORADOR"
        '
        'ccoln
        '
        Me.ccoln.FormattingEnabled = True
        Me.ccoln.Location = New System.Drawing.Point(18, 81)
        Me.ccoln.Name = "ccoln"
        Me.ccoln.Size = New System.Drawing.Size(495, 21)
        Me.ccoln.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(42, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(468, 43)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "RECALENDARAZICACION DE CITAS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label14.UseCompatibleTextRendering = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(553, 48)
        Me.ToolStrip1.TabIndex = 5
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
        'Panelc
        '
        Me.Panelc.Controls.Add(Me.Label4)
        Me.Panelc.Controls.Add(Me.chora2)
        Me.Panelc.Controls.Add(Me.Label6)
        Me.Panelc.Controls.Add(Me.dtfecha)
        Me.Panelc.Controls.Add(Me.ccol)
        Me.Panelc.Controls.Add(Me.Label10)
        Me.Panelc.Controls.Add(Me.chora)
        Me.Panelc.Controls.Add(Me.ccabina)
        Me.Panelc.Controls.Add(Me.Label11)
        Me.Panelc.Controls.Add(Me.Label12)
        Me.Panelc.Controls.Add(Me.tid_clie)
        Me.Panelc.Controls.Add(Me.Label2)
        Me.Panelc.Controls.Add(Me.tid_serv)
        Me.Panelc.Controls.Add(Me.tserv)
        Me.Panelc.Controls.Add(Me.Label5)
        Me.Panelc.Controls.Add(Me.tclie)
        Me.Panelc.Enabled = False
        Me.Panelc.Location = New System.Drawing.Point(12, 94)
        Me.Panelc.Name = "Panelc"
        Me.Panelc.Size = New System.Drawing.Size(527, 189)
        Me.Panelc.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "FINAL"
        '
        'chora2
        '
        Me.chora2.Enabled = False
        Me.chora2.FormattingEnabled = True
        Me.chora2.Location = New System.Drawing.Point(240, 115)
        Me.chora2.Name = "chora2"
        Me.chora2.Size = New System.Drawing.Size(106, 21)
        Me.chora2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(18, 115)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(104, 20)
        Me.dtfecha.TabIndex = 19
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'ccol
        '
        Me.ccol.FormattingEnabled = True
        Me.ccol.Location = New System.Drawing.Point(19, 156)
        Me.ccol.Name = "ccol"
        Me.ccol.Size = New System.Drawing.Size(495, 21)
        Me.ccol.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "INICIO"
        '
        'chora
        '
        Me.chora.FormattingEnabled = True
        Me.chora.Location = New System.Drawing.Point(128, 114)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(106, 21)
        Me.chora.TabIndex = 20
        '
        'ccabina
        '
        Me.ccabina.FormattingEnabled = True
        Me.ccabina.Location = New System.Drawing.Point(360, 114)
        Me.ccabina.Name = "ccabina"
        Me.ccabina.Size = New System.Drawing.Size(153, 21)
        Me.ccabina.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(357, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "AREA DE SERVICIO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "COLABORADOR"
        '
        'tid_clie
        '
        Me.tid_clie.Enabled = False
        Me.tid_clie.Location = New System.Drawing.Point(18, 33)
        Me.tid_clie.Name = "tid_clie"
        Me.tid_clie.Size = New System.Drawing.Size(104, 20)
        Me.tid_clie.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SERVICIO"
        '
        'tid_serv
        '
        Me.tid_serv.Enabled = False
        Me.tid_serv.Location = New System.Drawing.Point(18, 74)
        Me.tid_serv.Name = "tid_serv"
        Me.tid_serv.Size = New System.Drawing.Size(104, 20)
        Me.tid_serv.TabIndex = 8
        '
        'tserv
        '
        Me.tserv.Location = New System.Drawing.Point(128, 74)
        Me.tserv.Name = "tserv"
        Me.tserv.Size = New System.Drawing.Size(383, 20)
        Me.tserv.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "VISITANTE"
        '
        'tclie
        '
        Me.tclie.Location = New System.Drawing.Point(127, 33)
        Me.tclie.Name = "tclie"
        Me.tclie.Size = New System.Drawing.Size(383, 20)
        Me.tclie.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "NUEVA FECHA"
        '
        'frmauxcita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panelc)
        Me.Controls.Add(Me.Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmauxcita"
        Me.Text = "frmauxcita"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panelc.ResumeLayout(False)
        Me.Panelc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents chora2n As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtfechan As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents choran As ComboBox
    Friend WithEvents ccabinan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ccoln As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Panelc As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tid_serv As TextBox
    Friend WithEvents tserv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tclie As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chora2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents ccol As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chora As ComboBox
    Friend WithEvents ccabina As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tid_clie As TextBox
    Friend WithEvents Label9 As Label
End Class
