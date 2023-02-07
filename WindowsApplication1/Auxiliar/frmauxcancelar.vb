Imports MySql.Data.MySqlClient

Public Class frmauxcancelar
    Public folio As Integer
    Public tipo As Integer
    Dim conn As c_mysqlconn
    Dim fecha As DateTime
    Public sql As String


    Private Sub frmauxcancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If (Len(tmotivo.Text) > 0) Then
            If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then


                conn = New c_mysqlconn
                If conn.cancelar(folio, tipo, globalusuario, tmotivo.Text) = True Then

                    MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
                    Select Case tipo
                        Case 1
                            frmcntagasto.consulta()
                        Case 2
                            frmcntaretiros.consulta()
                    End Select
                    Dispose()

                End If

            End If
        End If
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub
End Class