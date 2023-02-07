Public Class frmcntamovbodega
    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmmovalmacenp.Show()
        frmmovalmacenp.BringToFront()
        frmmovalmacenp.flag = 1

    End Sub

    Private Sub frmcntamovbodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub
End Class