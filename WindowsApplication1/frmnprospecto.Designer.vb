<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnprospecto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cgenero = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tpiel = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tcp = New System.Windows.Forms.MaskedTextBox()
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tcol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tcalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tedo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnac = New System.Windows.Forms.TextBox()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.tnac)
        Me.Panel1.Controls.Add(Me.cgenero)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.tpiel)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.tcp)
        Me.Panel1.Controls.Add(Me.ttel)
        Me.Panel1.Controls.Add(Me.tcel)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.tnum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.temail)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tcol)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tcalle)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tedo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tmun)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 230)
        Me.Panel1.TabIndex = 5
        '
        'cgenero
        '
        Me.cgenero.FormattingEnabled = True
        Me.cgenero.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cgenero.Location = New System.Drawing.Point(486, 70)
        Me.cgenero.Name = "cgenero"
        Me.cgenero.Size = New System.Drawing.Size(125, 21)
        Me.cgenero.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(472, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "GENERO"
        '
        'tpiel
        '
        Me.tpiel.FormattingEnabled = True
        Me.tpiel.Items.AddRange(New Object() {"TIPO I", "TIPO II", "TIPO III", "TIPO IV", "TIPO V", "TIPO VI"})
        Me.tpiel.Location = New System.Drawing.Point(187, 24)
        Me.tpiel.Name = "tpiel"
        Me.tpiel.Size = New System.Drawing.Size(116, 21)
        Me.tpiel.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(168, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "TIPO DE PIEL"
        '
        'tcp
        '
        Me.tcp.Location = New System.Drawing.Point(634, 112)
        Me.tcp.Mask = "99999"
        Me.tcp.Name = "tcp"
        Me.tcp.Size = New System.Drawing.Size(125, 20)
        Me.tcp.TabIndex = 19
        Me.tcp.ValidatingType = GetType(Integer)
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(271, 193)
        Me.ttel.Mask = "(999)0000000"
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(186, 20)
        Me.ttel.TabIndex = 29
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(52, 193)
        Me.tcel.Mask = "(999)0000000"
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(189, 20)
        Me.tcel.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(620, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "FECHA NAC."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(472, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "NUMERO"
        '
        'tnum
        '
        Me.tnum.Location = New System.Drawing.Point(486, 112)
        Me.tnum.Name = "tnum"
        Me.tnum.Size = New System.Drawing.Size(124, 20)
        Me.tnum.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(472, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CORREO ELECTRONICO"
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(486, 193)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(273, 20)
        Me.temail.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(253, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "TEL FIJO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*TEL MOVIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "COLONIA"
        '
        'tcol
        '
        Me.tcol.Location = New System.Drawing.Point(50, 152)
        Me.tcol.Name = "tcol"
        Me.tcol.Size = New System.Drawing.Size(190, 20)
        Me.tcol.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CALLE"
        '
        'tcalle
        '
        Me.tcalle.Location = New System.Drawing.Point(52, 112)
        Me.tcalle.Name = "tcalle"
        Me.tcalle.Size = New System.Drawing.Size(407, 20)
        Me.tcalle.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(472, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ESTADO"
        '
        'tedo
        '
        Me.tedo.Location = New System.Drawing.Point(486, 152)
        Me.tedo.Name = "tedo"
        Me.tedo.Size = New System.Drawing.Size(273, 20)
        Me.tedo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "MUNICIPIO"
        '
        'tmun
        '
        Me.tmun.Location = New System.Drawing.Point(271, 152)
        Me.tmun.Name = "tmun"
        Me.tmun.Size = New System.Drawing.Size(188, 20)
        Me.tmun.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "*NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(52, 70)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(407, 20)
        Me.tnombre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLAVE "
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(52, 25)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROSPECTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'tnac
        '
        Me.tnac.Location = New System.Drawing.Point(634, 71)
        Me.tnac.Name = "tnac"
        Me.tnac.Size = New System.Drawing.Size(124, 20)
        Me.tnac.TabIndex = 38
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
        Me.grdatos.Location = New System.Drawing.Point(12, 338)
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
        Me.grdatos.Size = New System.Drawing.Size(797, 241)
        Me.grdatos.TabIndex = 18
        Me.grdatos.VirtualMode = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(202, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(419, 43)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "HISTORIAL DE TRATAMIENTOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseCompatibleTextRendering = True
        '
        'frmnprospecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 591)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmnprospecto"
        Me.Text = "frmnprospecto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tnac As TextBox
    Friend WithEvents cgenero As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tpiel As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tcp As MaskedTextBox
    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tnum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents temail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tcol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tcalle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tedo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tmun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grdatos As DataGridView
    Friend WithEvents Label4 As Label
End Class
