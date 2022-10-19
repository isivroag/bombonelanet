<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcalendario
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
        Dim CalendarHighlightRange1 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange2 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange3 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange4 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange5 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange6 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Dim CalendarHighlightRange7 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ccabina = New System.Windows.Forms.ComboBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chora2 = New System.Windows.Forms.ComboBox()
        Me.ttel = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tcel = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tcabina = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tserv = New System.Windows.Forms.TextBox()
        Me.chora = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.tclie = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.bmodificar = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.LMES = New System.Windows.Forms.Label()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Calendar1 = New System.Windows.Forms.Calendar.Calendar()
        Me.vmes = New System.Windows.Forms.Calendar.MonthView()
        Me.GroupBox.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "AREA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "CALENDARIO"
        '
        'ccabina
        '
        Me.ccabina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccabina.FormattingEnabled = True
        Me.ccabina.Location = New System.Drawing.Point(57, 99)
        Me.ccabina.Name = "ccabina"
        Me.ccabina.Size = New System.Drawing.Size(211, 21)
        Me.ccabina.TabIndex = 96
        Me.ccabina.Text = "TODOS"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.chora2)
        Me.GroupBox.Controls.Add(Me.ttel)
        Me.GroupBox.Controls.Add(Me.Label13)
        Me.GroupBox.Controls.Add(Me.tcel)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.tfolio)
        Me.GroupBox.Controls.Add(Me.Label12)
        Me.GroupBox.Controls.Add(Me.tcabina)
        Me.GroupBox.Controls.Add(Me.Label11)
        Me.GroupBox.Controls.Add(Me.tcol)
        Me.GroupBox.Controls.Add(Me.Label10)
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.tserv)
        Me.GroupBox.Controls.Add(Me.chora)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.dtfecha)
        Me.GroupBox.Controls.Add(Me.tclie)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(10, 321)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(348, 326)
        Me.GroupBox.TabIndex = 102
        Me.GroupBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "SALIDA"
        '
        'chora2
        '
        Me.chora2.FormattingEnabled = True
        Me.chora2.Location = New System.Drawing.Point(255, 75)
        Me.chora2.Name = "chora2"
        Me.chora2.Size = New System.Drawing.Size(87, 21)
        Me.chora2.TabIndex = 137
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(13, 162)
        Me.ttel.Mask = "(999)0000000"
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(155, 20)
        Me.ttel.TabIndex = 136
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 15)
        Me.Label13.TabIndex = 135
        Me.Label13.Text = "TELEFONO"
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(187, 159)
        Me.tcel.Mask = "(999)0000000"
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(155, 20)
        Me.tcel.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "CELULAR"
        '
        'tfolio
        '
        Me.tfolio.Location = New System.Drawing.Point(10, 34)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(109, 20)
        Me.tfolio.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "FOLIO"
        '
        'tcabina
        '
        Me.tcabina.Location = New System.Drawing.Point(13, 285)
        Me.tcabina.Name = "tcabina"
        Me.tcabina.Size = New System.Drawing.Size(329, 20)
        Me.tcabina.TabIndex = 130
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 15)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "AREA"
        '
        'tcol
        '
        Me.tcol.Location = New System.Drawing.Point(13, 244)
        Me.tcol.Name = "tcol"
        Me.tcol.Size = New System.Drawing.Size(329, 20)
        Me.tcol.TabIndex = 128
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "COLABORADOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "SERVICIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "VISITANTE"
        '
        'tserv
        '
        Me.tserv.Location = New System.Drawing.Point(13, 203)
        Me.tserv.Name = "tserv"
        Me.tserv.Size = New System.Drawing.Size(329, 20)
        Me.tserv.TabIndex = 124
        '
        'chora
        '
        Me.chora.FormattingEnabled = True
        Me.chora.Location = New System.Drawing.Point(162, 75)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(87, 21)
        Me.chora.TabIndex = 123
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "ENTRADA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "FECHA"
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(13, 76)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(109, 20)
        Me.dtfecha.TabIndex = 120
        Me.dtfecha.Value = New Date(2019, 3, 10, 21, 3, 6, 0)
        '
        'tclie
        '
        Me.tclie.Location = New System.Drawing.Point(13, 121)
        Me.tclie.Name = "tclie"
        Me.tclie.Size = New System.Drawing.Size(329, 20)
        Me.tclie.TabIndex = 119
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel.Controls.Add(Me.bmodificar)
        Me.Panel.Controls.Add(Me.beliminar)
        Me.Panel.Controls.Add(Me.LMES)
        Me.Panel.Controls.Add(Me.bnuevo)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1351, 78)
        Me.Panel.TabIndex = 103
        '
        'bmodificar
        '
        Me.bmodificar.AutoSize = True
        Me.bmodificar.BackColor = System.Drawing.Color.White
        Me.bmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmodificar.ForeColor = System.Drawing.Color.Black
        Me.bmodificar.Image = Global.Bombonela.My.Resources.Resources.reagendar
        Me.bmodificar.Location = New System.Drawing.Point(78, 12)
        Me.bmodificar.Name = "bmodificar"
        Me.bmodificar.Size = New System.Drawing.Size(58, 51)
        Me.bmodificar.TabIndex = 113
        Me.bmodificar.Text = "CAMBIAR"
        Me.bmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bmodificar.UseVisualStyleBackColor = False
        '
        'beliminar
        '
        Me.beliminar.AutoSize = True
        Me.beliminar.BackColor = System.Drawing.Color.White
        Me.beliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.beliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beliminar.ForeColor = System.Drawing.Color.Black
        Me.beliminar.Image = Global.Bombonela.My.Resources.Resources.calendardel32
        Me.beliminar.Location = New System.Drawing.Point(142, 12)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(60, 51)
        Me.beliminar.TabIndex = 111
        Me.beliminar.Text = "ELIMINAR"
        Me.beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.beliminar.UseVisualStyleBackColor = False
        '
        'LMES
        '
        Me.LMES.AutoSize = True
        Me.LMES.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMES.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LMES.Location = New System.Drawing.Point(433, 47)
        Me.LMES.Name = "LMES"
        Me.LMES.Size = New System.Drawing.Size(485, 31)
        Me.LMES.TabIndex = 110
        Me.LMES.Text = "DEL 01 DE AGOSTO DE 2019 AL 7 DE AGOSTO DE 2019"
        Me.LMES.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LMES.UseCompatibleTextRendering = True
        '
        'bnuevo
        '
        Me.bnuevo.AutoSize = True
        Me.bnuevo.BackColor = System.Drawing.Color.White
        Me.bnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnuevo.ForeColor = System.Drawing.Color.Black
        Me.bnuevo.Image = Global.Bombonela.My.Resources.Resources.calendaradd32
        Me.bnuevo.Location = New System.Drawing.Point(10, 12)
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(62, 51)
        Me.bnuevo.TabIndex = 107
        Me.bnuevo.Text = "AGREGAR"
        Me.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bnuevo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(529, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 38)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "CALENDARIO DE CITAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 15)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "RESUMEN DE CITA"
        '
        'Calendar1
        '
        Me.Calendar1.AllowItemEdit = False
        Me.Calendar1.AllowItemResize = False
        Me.Calendar1.AllowNew = False
        Me.Calendar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CalendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday
        CalendarHighlightRange1.EndTime = System.TimeSpan.Parse("20:00:00")
        CalendarHighlightRange1.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday
        CalendarHighlightRange2.EndTime = System.TimeSpan.Parse("20:00:00")
        CalendarHighlightRange2.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday
        CalendarHighlightRange3.EndTime = System.TimeSpan.Parse("20:00:00")
        CalendarHighlightRange3.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday
        CalendarHighlightRange4.EndTime = System.TimeSpan.Parse("20:00:00")
        CalendarHighlightRange4.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday
        CalendarHighlightRange5.EndTime = System.TimeSpan.Parse("20:00:00")
        CalendarHighlightRange5.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange6.DayOfWeek = System.DayOfWeek.Saturday
        CalendarHighlightRange6.EndTime = System.TimeSpan.Parse("19:00:00")
        CalendarHighlightRange6.StartTime = System.TimeSpan.Parse("09:00:00")
        CalendarHighlightRange7.DayOfWeek = System.DayOfWeek.Sunday
        CalendarHighlightRange7.EndTime = System.TimeSpan.Parse("15:00:00")
        CalendarHighlightRange7.StartTime = System.TimeSpan.Parse("09:00:00")
        Me.Calendar1.HighlightRanges = New System.Windows.Forms.Calendar.CalendarHighlightRange() {CalendarHighlightRange1, CalendarHighlightRange2, CalendarHighlightRange3, CalendarHighlightRange4, CalendarHighlightRange5, CalendarHighlightRange6, CalendarHighlightRange7}
        Me.Calendar1.Location = New System.Drawing.Point(364, 82)
        Me.Calendar1.MaximumFullDays = 7
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Size = New System.Drawing.Size(981, 565)
        Me.Calendar1.TabIndex = 101
        Me.Calendar1.Text = "Calendar1"
        Me.Calendar1.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.FifteenMinutes
        '
        'vmes
        '
        Me.vmes.ArrowsColor = System.Drawing.SystemColors.Window
        Me.vmes.ArrowsSelectedColor = System.Drawing.Color.Gold
        Me.vmes.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.vmes.DayBackgroundColor = System.Drawing.Color.Empty
        Me.vmes.DayGrayedText = System.Drawing.SystemColors.GrayText
        Me.vmes.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight
        Me.vmes.DaySelectedColor = System.Drawing.SystemColors.WindowText
        Me.vmes.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText
        Me.vmes.ItemPadding = New System.Windows.Forms.Padding(2)
        Me.vmes.Location = New System.Drawing.Point(57, 141)
        Me.vmes.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption
        Me.vmes.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption
        Me.vmes.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vmes.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText
        Me.vmes.Name = "vmes"
        Me.vmes.Size = New System.Drawing.Size(229, 159)
        Me.vmes.TabIndex = 95
        Me.vmes.Text = "MonthView1"
        Me.vmes.TodayBorderColor = System.Drawing.Color.Maroon
        '
        'frmcalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1351, 695)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Calendar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vmes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ccabina)
        Me.Name = "frmcalendario"
        Me.Text = " BOMBONELA: CALENDARIO DE CITAS"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents vmes As Calendar.MonthView
    Friend WithEvents Label1 As Label
    Friend WithEvents ccabina As ComboBox
    Friend WithEvents Calendar1 As Calendar.Calendar
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tcabina As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tcol As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tserv As TextBox
    Friend WithEvents chora As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents tclie As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents bmodificar As Button
    Friend WithEvents beliminar As Button
    Friend WithEvents LMES As Label
    Friend WithEvents bnuevo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tcel As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ttel As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chora2 As ComboBox
End Class
