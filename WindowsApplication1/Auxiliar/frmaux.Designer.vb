<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaux
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
        Me.bbar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bbar
        '
        Me.bbar.Location = New System.Drawing.Point(12, 59)
        Me.bbar.Name = "bbar"
        Me.bbar.Size = New System.Drawing.Size(478, 38)
        Me.bbar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 43)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "PROCESANDO..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'frmaux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 109)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmaux"
        Me.Text = "frmaux"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bbar As ProgressBar
    Friend WithEvents Label1 As Label
End Class
