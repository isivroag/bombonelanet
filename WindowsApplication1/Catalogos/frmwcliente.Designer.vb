<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwcliente
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
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmedio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tcurp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tocupacion = New System.Windows.Forms.TextBox()
        Me.cnivel = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cestado = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cgenero = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.trfc = New System.Windows.Forms.TextBox()
        Me.tnac = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(541, 48)
        Me.ToolStrip1.TabIndex = 3
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
        Me.bcancelar.Size = New System.Drawing.Size(71, 45)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmedio)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tcurp)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.tocupacion)
        Me.Panel1.Controls.Add(Me.cnivel)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.cestado)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.cgenero)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.ttel)
        Me.Panel1.Controls.Add(Me.tcel)
        Me.Panel1.Controls.Add(Me.trfc)
        Me.Panel1.Controls.Add(Me.tnac)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.temail)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tdir)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid)
        Me.Panel1.Location = New System.Drawing.Point(12, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 315)
        Me.Panel1.TabIndex = 5
        '
        'cmedio
        '
        Me.cmedio.FormattingEnabled = True
        Me.cmedio.Items.AddRange(New Object() {"SOLTERA(O)", "CASADA(O)", "DIVORCIADA(O)", "VIUDA(O)", "OTRO"})
        Me.cmedio.Location = New System.Drawing.Point(375, 25)
        Me.cmedio.Name = "cmedio"
        Me.cmedio.Size = New System.Drawing.Size(126, 21)
        Me.cmedio.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(372, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "NOS CONOCIO POR"
        '
        'tcurp
        '
        Me.tcurp.Location = New System.Drawing.Point(149, 109)
        Me.tcurp.Name = "tcurp"
        Me.tcurp.Size = New System.Drawing.Size(122, 20)
        Me.tcurp.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "CURP"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(0, 253)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "OCUPACION"
        '
        'tocupacion
        '
        Me.tocupacion.Location = New System.Drawing.Point(3, 269)
        Me.tocupacion.Name = "tocupacion"
        Me.tocupacion.Size = New System.Drawing.Size(227, 20)
        Me.tocupacion.TabIndex = 39
        '
        'cnivel
        '
        Me.cnivel.FormattingEnabled = True
        Me.cnivel.Items.AddRange(New Object() {"PRIMARIA", "SECUNDARIA", "PREPARATORIA", "LICENCIATURA", "POSTGRADO", "OTRO"})
        Me.cnivel.Location = New System.Drawing.Point(236, 269)
        Me.cnivel.Name = "cnivel"
        Me.cnivel.Size = New System.Drawing.Size(123, 21)
        Me.cnivel.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(236, 253)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "NIVEL DE ESTUDIOS"
        '
        'cestado
        '
        Me.cestado.FormattingEnabled = True
        Me.cestado.Items.AddRange(New Object() {"SOLTERA(O)", "CASADA(O)", "DIVORCIADA(O)", "VIUDA(O)", "OTRO"})
        Me.cestado.Location = New System.Drawing.Point(375, 269)
        Me.cestado.Name = "cestado"
        Me.cestado.Size = New System.Drawing.Size(126, 21)
        Me.cestado.TabIndex = 51
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(372, 251)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "ESTADO CIVIL"
        '
        'cgenero
        '
        Me.cgenero.FormattingEnabled = True
        Me.cgenero.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cgenero.Location = New System.Drawing.Point(3, 109)
        Me.cgenero.Name = "cgenero"
        Me.cgenero.Size = New System.Drawing.Size(141, 21)
        Me.cgenero.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "GENERO"
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(236, 228)
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(126, 20)
        Me.ttel.TabIndex = 29
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(375, 228)
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(126, 20)
        Me.tcel.TabIndex = 30
        '
        'trfc
        '
        Me.trfc.Location = New System.Drawing.Point(277, 110)
        Me.trfc.Name = "trfc"
        Me.trfc.Size = New System.Drawing.Size(122, 20)
        Me.trfc.TabIndex = 5
        '
        'tnac
        '
        Me.tnac.CustomFormat = "yyyy-MM-dd"
        Me.tnac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tnac.Location = New System.Drawing.Point(405, 110)
        Me.tnac.Name = "tnac"
        Me.tnac.Size = New System.Drawing.Size(96, 20)
        Me.tnac.TabIndex = 13
        Me.tnac.Value = New Date(2019, 2, 13, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RFC"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(402, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "FECHA NAC."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CORREO ELECTRONICO"
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(3, 228)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(227, 20)
        Me.temail.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(236, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "TELEFONO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(372, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*WHATSAPP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DIRECCIÓN"
        '
        'tdir
        '
        Me.tdir.Location = New System.Drawing.Point(3, 149)
        Me.tdir.Multiline = True
        Me.tdir.Name = "tdir"
        Me.tdir.Size = New System.Drawing.Size(498, 60)
        Me.tdir.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "*NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(3, 70)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(498, 20)
        Me.tnombre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLAVE DE CLIENTE"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(3, 25)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(109, 20)
        Me.tid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'frmwcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(541, 415)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmwcliente"
        Me.Text = "clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents tocupacion As TextBox
    Friend WithEvents cnivel As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cestado As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cgenero As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents trfc As TextBox
    Friend WithEvents tnac As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents temail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tdir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tcurp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmedio As ComboBox
    Friend WithEvents Label7 As Label
End Class
