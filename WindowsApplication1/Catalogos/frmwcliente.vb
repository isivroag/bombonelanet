Imports MySql.Data.MySqlClient

Public Class frmwcliente
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_wcliente
    Dim oldcliente As New c_cliente
    Dim tabla As New DataTable
    Public flag As Integer
    Public prospecto As String


    Private Sub combos()

        cmedio.Items.Clear()

        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from wmedios order by id_medio")
        For Each row As DataRow In tabla.Rows
            cmedio.Items.Add(row("nom_medio"))

        Next



        tabla = New DataTable
        conn = New c_mysqlconn

        cnivel.Items.Clear()

        tabla = conn.consulta("select * from wnivele order by id_nivele")
        For Each row As DataRow In tabla.Rows
            cnivel.Items.Add(row("nom_nivele"))
        Next

        tabla = New DataTable
        conn = New c_mysqlconn

        cestado.Items.Clear()

        tabla = conn.consulta("select * from westadoc order by id_estadoc")
        For Each row As DataRow In tabla.Rows
            cestado.Items.Add(row("nom_estadoc"))
        Next

    End Sub
    Public Sub buscarprospecto()
        conn = New c_mysqlconn
        tabla = New DataTable
        tabla = conn.consulta("select * from prospecto where id_pros='" & prospecto & "'")
        If tabla.Rows.Count > 0 Then
            tnombre.Text = tabla.Rows(0).Item("nom_pros")
            tcel.Text = tabla.Rows(0).Item("cel_pros")
            ttel.Text = tabla.Rows(0).Item("tel_pros")
            temail.Text = tabla.Rows(0).Item("correo_pros")
        End If

    End Sub
    Public Sub mostrar(ByVal registro As c_wcliente)
        datos = registro
        tid.Text = datos.Id_clie
        trfc.Text = datos.Rfc_clie
        tcurp.Text = datos.Curp_clie
        tnombre.Text = datos.Nom_clie
        tdir.Text = datos.Dir_clie

        tcel.Text = datos.Ws_clie
        ttel.Text = datos.Tel_clie
        tnac.Text = datos.Nac_clie

        temail.Text = datos.Correo_clie

        cgenero.Text = datos.Gen_clie
        cnivel.Text = datos.Niv_clie
        tocupacion.Text = datos.Ocupacion_clie

        cestado.Text = datos.Ecivil_clie
        cmedio.Text = datos.Medio_clie

    End Sub
    Private Sub limpiar()
        tid.Text = ""
        trfc.Text = ""
        tnombre.Text = ""
        tdir.Text = ""

        tnac.Value = Format(Now, "yyyy-MM-dd")

        tcel.Text = ""
        ttel.Text = ""
        temail.Text = ""

        cgenero.Text = ""
        cnivel.Text = ""
        tocupacion.Text = ""

        cestado.Text = ""



    End Sub
    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CATALOGO DE VISITANTES")
        limpiar()
        combos()
    End Sub
    Private Sub bcancelar_Click_1(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tcel.Text) > 0 And Strings.Len(tnac.Text) Then

            datos.Rfc_clie = trfc.Text
            datos.Curp_clie = tcurp.Text
            datos.Nom_clie = tnombre.Text
            datos.Dir_clie = tdir.Text
            datos.Ws_clie = tcel.Text
            datos.Tel_clie = ttel.Text
            datos.Correo_clie = temail.Text
            datos.Nac_clie = Format(tnac.Value, "yyyy-MM-dd")
            datos.Gen_clie = cgenero.Text
            datos.Niv_clie = cnivel.Text
            datos.Ocupacion_clie = tocupacion.Text
            datos.Ecivil_clie = cestado.Text
            datos.Medio_clie = cmedio.Text


            oldcliente.Id_clie = datos.Id_clie
            oldcliente.Rfc_clie = trfc.Text
            oldcliente.Nom_clie = tnombre.Text
            oldcliente.Calle_clie = ""
            oldcliente.Num_clie = ""
            oldcliente.Col_clie = ""
            oldcliente.Cp_clie = ""
            oldcliente.Mun_clie = ""
            oldcliente.Edo_clie = ""
            oldcliente.Cel_clie = tcel.Text
            oldcliente.Tel_clie = ttel.Text
            oldcliente.Correo_clie = temail.Text
            oldcliente.Docid_clie = ""
            oldcliente.Doc_clie = ""
            oldcliente.Nac_clie = Format(tnac.Value, "yyyy-MM-dd")
            oldcliente.Piel_clie = ""
            oldcliente.Ojos_clie = ""
            oldcliente.Pelo_clie = ""


            oldcliente.Gen_clie = cgenero.Text
            oldcliente.Niv_clie = cnivel.Text
            oldcliente.Ocupacion_clie = tocupacion.Text

            oldcliente.Ecivil_clie = cestado.Text
            oldcliente.Aniv_clie = Format(Now, "yyyy-MM-dd")
            oldcliente.Hijos_clie = ""

            oldcliente.Fb_clie = ""
            oldcliente.Tw_clie = ""
            oldcliente.Insta_clie = ""



            If flag = 1 Or flag = 3 Then
                conn = New c_mysqlconn
                datos.Alta_clie = Format(Now, "yyyy-MM-dd")
                If conn.insertarnuevo(datos) Then
                    conn = New c_mysqlconn
                    conn.insertarnuevo(oldcliente)
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If flag = 1 Then
                        frmcntawcliente.consulta()
                        Me.Dispose()
                    Else
                        conn = New c_mysqlconn
                        Dim clave As String
                        clave = conn.Obtener_ID("select max(id_clie) as max_id from wcliente")
                        frmvisita.tid_clie.Text = clave

                        frmvisita.idpersona = clave
                        frmvisita.tipo = 1
                        Dispose()

                    End If

                    If prospecto <> 0 Then
                        conn = New c_mysqlconn
                        conn.actualizarprospecto(prospecto)

                    End If

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_clie.ToString) Then
                    conn = New c_mysqlconn
                    conn.modificar(oldcliente, oldcliente.Id_clie.ToString)
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntacliente.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub



    Private Sub sinfoco(sender As Object, e As EventArgs) Handles trfc.LostFocus, tnombre.LostFocus, tdir.LostFocus, tocupacion.LostFocus
        mayus(sender)
    End Sub

End Class