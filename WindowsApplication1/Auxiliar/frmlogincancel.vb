Imports MySql.Data.MySqlClient
Public Class frmlogincancel
    Dim conn As New c_mysqlconn
    Dim usuario As String
    Dim contraseña As String
    Dim consulta As String

    Dim tabla As New DataTable
    Dim username As String
    Dim rol As Integer

    Public folio As Int64
    Public tipo As Int32


    Private Sub frmlogincancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        consulta = "select * from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "' and (rol_usuario =2 or rol_usuario=3)"
        conn = New c_mysqlconn

        If conn.entrar(consulta) = True Then
            conn = New c_mysqlconn

            username = conn.Obtener_dato("select nombre as dato from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'")

            MsgBox("ACCESO CORRECTO", vbOKOnly + vbInformation, "ACCESO CANCELACIÓN")
            'MessageBox.Show("BIENVENIDO", "INGRESO SISTEMA BOMBONELA", MessageBoxButtons.O, MessageBoxIcon.Information)
            If tipo = 1 Then
                frmcancelar.Show()
                frmcancelar.username = username
                frmcancelar.tfolio.Text = folio
                frmcancelar.ttipo.Text = "1 VENTA"
                frmcancelar.tfecha.Value = Now
                frmcancelar.ltitulo.Text = "CANCELAR VENTA"
            ElseIf tipo = 2 Then
                frmcancelar.Show()
                frmcancelar.username = username
                frmcancelar.tfolio.Text = folio
                frmcancelar.ttipo.Text = "2 PAGO"
                frmcancelar.tfecha.Value = Now
                frmcancelar.ltitulo.Text = "CANCELAR PAGO"
            End If
            Dispose()

        Else
            MsgBox("ACCESO DENEGADO", vbOKOnly + vbCritical, "ACCESO CANCELACIÓN")
        End If
    End Sub
End Class