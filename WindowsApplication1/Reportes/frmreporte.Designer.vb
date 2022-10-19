<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreporte))
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportViewer.DisplayBackgroundEdge = False
        Me.ReportViewer.DisplayStatusBar = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ShowCopyButton = False
        Me.ReportViewer.ShowExportButton = False
        Me.ReportViewer.ShowGotoPageButton = False
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.ShowLogo = False
        Me.ReportViewer.ShowPageNavigateButtons = False
        Me.ReportViewer.ShowParameterPanelButton = False
        Me.ReportViewer.ShowTextSearchButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(395, 554)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmreporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 554)
        Me.Controls.Add(Me.ReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreporte"
        Me.Text = "frmreporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
