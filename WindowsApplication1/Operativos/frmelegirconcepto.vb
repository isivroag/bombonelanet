Public Class frmelegirconcepto
    Private Sub bproducto_Click(sender As Object, e As EventArgs) Handles bproducto.Click
        frmcntaproducto.flag = 3
        frmcntaproducto.Show()
        frmcntaproducto.BringToFront()

        Dispose()
    End Sub

    Private Sub bservicio_Click(sender As Object, e As EventArgs) Handles bservicio.Click
        frmcntaservicios.Show()
        frmcntaservicios.BringToFront()
        frmcntaservicios.flag = 3
        Dispose()
    End Sub

    Private Sub frmelegirconcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "SELECIONAR CONCEPTO")
    End Sub
End Class