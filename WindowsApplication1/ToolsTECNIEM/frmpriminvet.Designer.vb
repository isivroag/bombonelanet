<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpriminvet
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bbar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PROCESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bbar
        '
        Me.bbar.Location = New System.Drawing.Point(21, 48)
        Me.bbar.Name = "bbar"
        Me.bbar.Size = New System.Drawing.Size(399, 38)
        Me.bbar.TabIndex = 1
        '
        'frmpriminvet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 179)
        Me.Controls.Add(Me.bbar)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmpriminvet"
        Me.Text = "frmpriminvet"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents bbar As ProgressBar
End Class
