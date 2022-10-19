<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmelegirconcepto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmelegirconcepto))
        Me.bproducto = New System.Windows.Forms.Button()
        Me.bservicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bproducto
        '
        Me.bproducto.BackgroundImage = Global.Bombonela.My.Resources.Resources.PRODUCTO26
        Me.bproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bproducto.Location = New System.Drawing.Point(27, 12)
        Me.bproducto.Name = "bproducto"
        Me.bproducto.Size = New System.Drawing.Size(140, 36)
        Me.bproducto.TabIndex = 1
        Me.bproducto.Text = "PRODUCTOS"
        Me.bproducto.UseVisualStyleBackColor = True
        '
        'bservicio
        '
        Me.bservicio.BackgroundImage = Global.Bombonela.My.Resources.Resources.SPA26
        Me.bservicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bservicio.Location = New System.Drawing.Point(173, 12)
        Me.bservicio.Name = "bservicio"
        Me.bservicio.Size = New System.Drawing.Size(140, 36)
        Me.bservicio.TabIndex = 0
        Me.bservicio.Text = "SERVICIOS"
        Me.bservicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bservicio.UseVisualStyleBackColor = True
        '
        'frmelegirconcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(342, 68)
        Me.Controls.Add(Me.bproducto)
        Me.Controls.Add(Me.bservicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmelegirconcepto"
        Me.Text = "frmelegirconcepto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bservicio As Button
    Friend WithEvents bproducto As Button
End Class
