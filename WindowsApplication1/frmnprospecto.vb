Imports MySql.Data.MySqlClient



Public Class frmnprospecto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_bdprospecto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub mostrar(ByVal registro As c_bdprospecto)
        datos = registro
        tid.Text = datos.Id

        tnombre.Text = datos.Nombre
        tcalle.Text = datos.Calle
        tnum.Text = datos.Num
        tcol.Text = datos.Col
        tcp.Text = datos.Cdp
        tmun.Text = datos.Mun
        tedo.Text = datos.Edo
        tcel.Text = datos.Cel
        ttel.Text = datos.Tel
        If datos.Fecha IsNot Nothing Then
            tnac.Text = Strings.Left(datos.Fecha, 10)
        Else
            tnac.Text = ""
        End If

        temail.Text = datos.Correo
        tpiel.Text = datos.Fototipo
        cgenero.Text = datos.Genero
        consulta()
    End Sub
    Public Sub consulta()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from sesiones where id='" & tid.Text & "' order by id")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID SES"
        grdatos.Columns(1).HeaderText = "ID"
        grdatos.Columns(2).HeaderText = "TRATAMIENTO"
        grdatos.Columns(3).HeaderText = "ZONA"
        grdatos.Columns(4).HeaderText = "# SESION"
        grdatos.Columns(5).HeaderText = "FECHA"
        grdatos.Columns(6).HeaderText = "ATENDIO"


        grdatos.AutoResizeColumns()



    End Sub
    Private Sub frmnprospecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class