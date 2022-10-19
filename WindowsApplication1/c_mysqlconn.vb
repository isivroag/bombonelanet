Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

'CLASE QUE CONTIENE LOS DATOS DE CONEXION Y LAS FUNCIONES DE MANIPULACION DE DATOS
Public Class c_mysqlconn
    Public _sql As String
    Public _conexion As New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private ta As New DataTable


    Public dtsdatos As New DataSet
    Public dtvdatos As New DataView
    Private Sub conexion()
        _sql = "server=" & My.Settings.server & "; Uid=" & My.Settings.user & "; Pwd=" & My.Settings.pwd & ";database=" & My.Settings.db & ""
        _conexion = New MySqlConnection(_sql)
    End Sub

    Public Function entrar(ByVal sql As String) As Boolean
        Dim estado As Boolean
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sql, _conexion)
            adaptador.Fill(dtsdatos, "registro")
            If dtsdatos.Tables("registro").Rows.Count <> 0 Then
                estado = True
            Else
                estado = False
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado



    End Function
    Public Function consulta(ByVal Tabla As DataGridView, ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try
            Tabla.DataSource = Nothing

            conexion()
            ta.Clear()

            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)
            Tabla.DataSource = ta
        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return ta
    End Function

    Public Function consultadinamica(ByVal Tabla As DataGridView, ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try
            Tabla.DataSource = Nothing

            conexion()
            ta.Clear()

            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)
            Tabla.DataSource = ta
        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return ta
    End Function
    Public Function consulta(ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try

            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try

        Return ta
    End Function

    Public Sub desconectar()
        _conexion.Close()

    End Sub

    Public Function Obtener_dato(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("dato")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("dato"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function
    Public Function Obtener_ID(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("max_id")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("max_id"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function Obtener_primero(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("min_id")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("min_id"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    'cliente
    Public Function insertarnuevo(ByVal datos As c_cliente) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into cliente (rfc_clie,nom_clie,calle_clie,num_clie,col_clie,mun_clie,edo_clie," &
                                                       "cp_clie,tel_clie,cel_clie,correo_clie,nac_clie,doc_clie,docid_clie,alta_clie,ojos_clie,pelo_clie,piel_clie," &
                                                       "gen_clie,ecivil_clie,aniv_clie,hijos_clie,fb_clie,tw_clie,insta_clie,niv_clie,ocupacion_clie) " &
                                                       "values(@rfc_clie,@nom_clie,@calle_clie,@num_clie,@col_clie,@mun_clie,@edo_clie," &
                                                       "@cp_clie,@tel_clie,@cel_clie,@correo_clie,@nac_clie,@doc_clie,@docid_clie,@alta_clie,@ojos_clie,@pelo_clie,@piel_clie," &
                                                       "@gen_clie,@ecivil_clie,@aniv_clie,@hijos_clie,@fb_clie,@tw_clie,@insta_clie,@niv_clie,@ocupacion_clie)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar).Value = datos.Rfc_clie
            adaptador.InsertCommand.Parameters.Add("@nom_clie", MySqlDbType.VarChar).Value = datos.Nom_clie
            adaptador.InsertCommand.Parameters.Add("@calle_clie", MySqlDbType.VarChar).Value = datos.Calle_clie
            adaptador.InsertCommand.Parameters.Add("@num_clie", MySqlDbType.VarChar).Value = datos.Num_clie
            adaptador.InsertCommand.Parameters.Add("@col_clie", MySqlDbType.VarChar).Value = datos.Col_clie
            adaptador.InsertCommand.Parameters.Add("@mun_clie", MySqlDbType.VarChar).Value = datos.Mun_clie
            adaptador.InsertCommand.Parameters.Add("@edo_clie", MySqlDbType.VarChar).Value = datos.Edo_clie
            adaptador.InsertCommand.Parameters.Add("@cp_clie", MySqlDbType.VarChar).Value = datos.Cp_clie
            adaptador.InsertCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar).Value = datos.Tel_clie
            adaptador.InsertCommand.Parameters.Add("@cel_clie", MySqlDbType.VarChar).Value = datos.Cel_clie
            adaptador.InsertCommand.Parameters.Add("@correo_clie", MySqlDbType.VarChar).Value = datos.Correo_clie
            adaptador.InsertCommand.Parameters.Add("@nac_clie", MySqlDbType.Date).Value = datos.Nac_clie
            adaptador.InsertCommand.Parameters.Add("@doc_clie", MySqlDbType.VarChar).Value = datos.Doc_clie
            adaptador.InsertCommand.Parameters.Add("@docid_clie", MySqlDbType.VarChar).Value = datos.Docid_clie
            adaptador.InsertCommand.Parameters.Add("@ojos_clie", MySqlDbType.VarChar).Value = datos.Ojos_clie
            adaptador.InsertCommand.Parameters.Add("@pelo_clie", MySqlDbType.VarChar).Value = datos.Pelo_clie
            adaptador.InsertCommand.Parameters.Add("@piel_clie", MySqlDbType.VarChar).Value = datos.Piel_clie
            adaptador.InsertCommand.Parameters.Add("@alta_clie", MySqlDbType.Date).Value = datos.Alta_clie

            adaptador.InsertCommand.Parameters.Add("@gen_clie", MySqlDbType.VarChar).Value = datos.Gen_clie
            adaptador.InsertCommand.Parameters.Add("@ecivil_clie", MySqlDbType.VarChar).Value = datos.Ecivil_clie
            adaptador.InsertCommand.Parameters.Add("@aniv_clie", MySqlDbType.Date).Value = datos.Aniv_clie
            adaptador.InsertCommand.Parameters.Add("@hijos_clie", MySqlDbType.VarChar).Value = datos.Hijos_clie
            adaptador.InsertCommand.Parameters.Add("@fb_clie", MySqlDbType.VarChar).Value = datos.Fb_clie
            adaptador.InsertCommand.Parameters.Add("@tw_clie", MySqlDbType.VarChar).Value = datos.Tw_clie
            adaptador.InsertCommand.Parameters.Add("@insta_clie", MySqlDbType.VarChar).Value = datos.Insta_clie
            adaptador.InsertCommand.Parameters.Add("@niv_clie", MySqlDbType.VarChar).Value = datos.Niv_clie
            adaptador.InsertCommand.Parameters.Add("@ocupacion_clie", MySqlDbType.VarChar).Value = datos.Ocupacion_clie
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'cliente
    Public Function modificar(ByVal datos As c_cliente, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("UPDATE cliente SET rfc_clie=@rfc_clie,nom_clie=@nom_clie,calle_clie=@calle_clie," &
                                                       "num_clie=@num_clie,col_clie=@col_clie,mun_clie=@mun_clie,edo_clie=@edo_clie,cp_clie=@cp_clie,tel_clie=@tel_clie," &
                                                       "cel_clie=@cel_clie,correo_clie=@correo_clie,nac_clie=@nac_clie,doc_clie=@doc_clie,docid_clie=@docid_clie," &
                                                       "ojos_clie=@ojos_clie,pelo_clie=@pelo_clie,piel_clie=@piel_clie," &
                                                       "gen_clie=@gen_clie,ecivil_clie=@ecivil_clie,aniv_clie=@aniv_clie,hijos_clie=@hijos_clie,fb_clie=@fb_clie,tw_clie=@tw_clie,insta_clie=@insta_clie,niv_clie=@niv_clie,ocupacion_clie=@ocupacion_clie" &
                                                       " WHERE id_clie=@clave", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.String).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar).Value = datos.Rfc_clie
            adaptador.UpdateCommand.Parameters.Add("@nom_clie", MySqlDbType.VarChar).Value = datos.Nom_clie
            adaptador.UpdateCommand.Parameters.Add("@calle_clie", MySqlDbType.VarChar).Value = datos.Calle_clie
            adaptador.UpdateCommand.Parameters.Add("@num_clie", MySqlDbType.VarChar).Value = datos.Num_clie
            adaptador.UpdateCommand.Parameters.Add("@col_clie", MySqlDbType.VarChar).Value = datos.Col_clie
            adaptador.UpdateCommand.Parameters.Add("@mun_clie", MySqlDbType.VarChar).Value = datos.Mun_clie
            adaptador.UpdateCommand.Parameters.Add("@edo_clie", MySqlDbType.VarChar).Value = datos.Edo_clie
            adaptador.UpdateCommand.Parameters.Add("@cp_clie", MySqlDbType.VarChar).Value = datos.Cp_clie
            adaptador.UpdateCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar).Value = datos.Tel_clie
            adaptador.UpdateCommand.Parameters.Add("@cel_clie", MySqlDbType.VarChar).Value = datos.Cel_clie
            adaptador.UpdateCommand.Parameters.Add("@correo_clie", MySqlDbType.VarChar).Value = datos.Correo_clie
            adaptador.UpdateCommand.Parameters.Add("@nac_clie", MySqlDbType.Date).Value = datos.Nac_clie
            adaptador.UpdateCommand.Parameters.Add("@doc_clie", MySqlDbType.VarChar).Value = datos.Doc_clie
            adaptador.UpdateCommand.Parameters.Add("@docid_clie", MySqlDbType.VarChar).Value = datos.Docid_clie
            adaptador.UpdateCommand.Parameters.Add("@ojos_clie", MySqlDbType.VarChar).Value = datos.Ojos_clie
            adaptador.UpdateCommand.Parameters.Add("@pelo_clie", MySqlDbType.VarChar).Value = datos.Pelo_clie
            adaptador.UpdateCommand.Parameters.Add("@piel_clie", MySqlDbType.VarChar).Value = datos.Piel_clie
            adaptador.UpdateCommand.Parameters.Add("@alta_clie", MySqlDbType.Date).Value = datos.Alta_clie

            adaptador.UpdateCommand.Parameters.Add("@gen_clie", MySqlDbType.VarChar).Value = datos.Gen_clie
            adaptador.UpdateCommand.Parameters.Add("@ecivil_clie", MySqlDbType.VarChar).Value = datos.Ecivil_clie
            adaptador.UpdateCommand.Parameters.Add("@aniv_clie", MySqlDbType.Date).Value = datos.Aniv_clie
            adaptador.UpdateCommand.Parameters.Add("@hijos_clie", MySqlDbType.VarChar).Value = datos.Hijos_clie
            adaptador.UpdateCommand.Parameters.Add("@fb_clie", MySqlDbType.VarChar).Value = datos.Fb_clie
            adaptador.UpdateCommand.Parameters.Add("@tw_clie", MySqlDbType.VarChar).Value = datos.Tw_clie
            adaptador.UpdateCommand.Parameters.Add("@insta_clie", MySqlDbType.VarChar).Value = datos.Insta_clie
            adaptador.UpdateCommand.Parameters.Add("@niv_clie", MySqlDbType.VarChar).Value = datos.Niv_clie
            adaptador.UpdateCommand.Parameters.Add("@ocupacion_clie", MySqlDbType.VarChar).Value = datos.Ocupacion_clie

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function insertarnuevo(ByVal datos As c_puesto) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into puesto(nom_puesto) values (@nom_puesto)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_puesto", MySqlDbType.VarChar).Value = datos.Nom_puesto
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_puesto, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update puesto Set nom_puesto=@nom_puesto where id_puesto=@id_puesto", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_puesto", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_puesto", MySqlDbType.VarChar).Value = datos.Nom_puesto

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#Region "COLABORADOR"


    Public Function insertarnuevo(ByVal datos As c_colaborador) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into colaborador(nom_col,dir_col,tel_col,cel_col,correo_col,id_puesto,alta_col) " &
                                                       "values (@nom_col,@dir_col,@tel_col,@cel_col,@correo_col,@id_puesto,@alta_col)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_col", MySqlDbType.VarChar).Value = datos.Nom_col
            adaptador.InsertCommand.Parameters.Add("@dir_col", MySqlDbType.VarChar).Value = datos.Dir_col
            adaptador.InsertCommand.Parameters.Add("@tel_col", MySqlDbType.VarChar).Value = datos.Tel_col
            adaptador.InsertCommand.Parameters.Add("@cel_col", MySqlDbType.VarChar).Value = datos.Cel_col
            adaptador.InsertCommand.Parameters.Add("@correo_col", MySqlDbType.VarChar).Value = datos.Correo_col
            adaptador.InsertCommand.Parameters.Add("@id_puesto", MySqlDbType.Int64).Value = datos.Id_puesto
            adaptador.InsertCommand.Parameters.Add("@alta_col", MySqlDbType.Date).Value = datos.Alta_col

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_colaborador, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update colaborador Set nom_col=@nom_col,dir_col=@dir_col,tel_col=@tel_col,cel_col=@cel_col" &
                                                       ",correo_col=@correo_col,id_puesto=@id_puesto where id_col=@id_col", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_col", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_col", MySqlDbType.VarChar).Value = datos.Nom_col
            adaptador.UpdateCommand.Parameters.Add("@dir_col", MySqlDbType.VarChar).Value = datos.Dir_col
            adaptador.UpdateCommand.Parameters.Add("@tel_col", MySqlDbType.VarChar).Value = datos.Tel_col
            adaptador.UpdateCommand.Parameters.Add("@cel_col", MySqlDbType.VarChar).Value = datos.Cel_col
            adaptador.UpdateCommand.Parameters.Add("@correo_col", MySqlDbType.VarChar).Value = datos.Correo_col
            adaptador.UpdateCommand.Parameters.Add("@id_puesto", MySqlDbType.Int64).Value = datos.Id_puesto

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region
    Public Function insertarnuevo(ByVal datos As c_tipo) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into tipo_servicio (nom_tipo) values (@nom_tipo)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_tipo", MySqlDbType.VarChar).Value = datos.Nom_tipo
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_tipo, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update tipo_servicio Set nom_tipo=@nom_tipo where id_tipo=@id_tipo", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_tipo", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_tipo", MySqlDbType.VarChar).Value = datos.Nom_tipo

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As c_partida) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into partida (nom_partida) values (@nom_partida)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_partida", MySqlDbType.VarChar).Value = datos.Nom_partida
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_partida, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update partida Set nom_partida=@nom_partida where id_partida=@id_partida", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_partida", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_partida", MySqlDbType.VarChar).Value = datos.Nom_partida

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function insertarnuevo(ByVal datos As c_subpartida) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into subpartida (id_partida,nom_subpartida) values (@id_partida,@nom_subpartida)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_partida", MySqlDbType.Int64).Value = datos.Id_partida
            adaptador.InsertCommand.Parameters.Add("@nom_subpartida", MySqlDbType.VarChar).Value = datos.Nom_subpartida
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_subpartida, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update subpartida Set nom_subpartida=@nom_subpartida where id_subpartida=@id_subpartida", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_subpartida", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_subpartida", MySqlDbType.VarChar).Value = datos.Nom_subpartida

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As c_cabina) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into cabina (nom_cabina) values (@nom_cabina)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_cabina", MySqlDbType.VarChar).Value = datos.Nom_cabina
            adaptador.InsertCommand.Parameters.Add("@color_cabina", MySqlDbType.VarChar).Value = datos.Color_cabina
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_cabina, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cabina Set nom_cabina=@nom_cabina,color_cabina=@color_cabina where id_cabina=@id_cabina", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_cabina", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@color_cabina", MySqlDbType.VarChar).Value = datos.Color_cabina
            adaptador.UpdateCommand.Parameters.Add("@nom_cabina", MySqlDbType.VarChar).Value = datos.Nom_cabina

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As c_servicio) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into servicio(nom_serv,desc_serv,id_tipo,dur_serv) " &
                                                       "values (@nom_serv,@desc_serv,@id_tipo,@dur_serv)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_serv", MySqlDbType.VarChar).Value = datos.Nom_serv
            adaptador.InsertCommand.Parameters.Add("@desc_serv", MySqlDbType.VarChar).Value = datos.Desc_serv

            adaptador.InsertCommand.Parameters.Add("@id_tipo", MySqlDbType.Int64).Value = datos.Id_tipo
            adaptador.InsertCommand.Parameters.Add("@dur_serv", MySqlDbType.Double).Value = datos.Duracion


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_servicio, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update servicio Set nom_serv=@nom_serv,desc_serv=@desc_serv,id_tipo=@id_tipo,dur_serv=@dur_serv where id_serv=@id_serv", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_serv", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_serv", MySqlDbType.VarChar).Value = datos.Nom_serv
            adaptador.UpdateCommand.Parameters.Add("@desc_serv", MySqlDbType.VarChar).Value = datos.Desc_serv
            adaptador.UpdateCommand.Parameters.Add("@id_tipo", MySqlDbType.Int64).Value = datos.Id_tipo
            adaptador.UpdateCommand.Parameters.Add("@dur_serv", MySqlDbType.Double).Value = datos.Duracion


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As c_paquete) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into paquete(id_serv,clave_pqt,desc_pqt,sesiones_pqt,precio_pqt) " &
                                                       "values (@id_serv,@clave_pqt,@desc_pqt,@sesiones_pqt,@precio_pqt)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_serv", MySqlDbType.Int64).Value = datos.Id_serv
            adaptador.InsertCommand.Parameters.Add("@clave_pqt", MySqlDbType.VarChar).Value = datos.Clave_pqt
            adaptador.InsertCommand.Parameters.Add("@desc_pqt", MySqlDbType.VarChar).Value = datos.Desc_pqt
            adaptador.InsertCommand.Parameters.Add("@sesiones_pqt", MySqlDbType.Int64).Value = datos.Sesiones_pqt
            adaptador.InsertCommand.Parameters.Add("@precio_pqt", MySqlDbType.Double).Value = datos.Precio_pqt




            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_paquete, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update paquete Set clave_pqt=@clave_pqt,desc_pqt=@desc_pqt,sesiones_pqt=@sesiones_pqt,precio_pqt=@precio_pqt where id_serv=@id_serv and id_pqt=@id_pqt", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_pqt", MySqlDbType.Int64).Value = clave

            adaptador.UpdateCommand.Parameters.Add("@id_serv", MySqlDbType.Int64).Value = datos.Id_serv
            adaptador.UpdateCommand.Parameters.Add("@clave_pqt", MySqlDbType.VarChar).Value = datos.Clave_pqt
            adaptador.UpdateCommand.Parameters.Add("@desc_pqt", MySqlDbType.VarChar).Value = datos.Desc_pqt
            adaptador.UpdateCommand.Parameters.Add("@sesiones_pqt", MySqlDbType.Int64).Value = datos.Sesiones_pqt
            adaptador.UpdateCommand.Parameters.Add("@precio_pqt", MySqlDbType.Double).Value = datos.Precio_pqt


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function



    Public Function insertarnuevo(ByVal datos As c_prospecto) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into prospecto(nom_pros,tel_pros,cel_pros,correo_pros,alta_pros) " &
                                                       "values (@nom_pros,@tel_pros,@cel_pros,@correo_pros,@alta_pros)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_pros", MySqlDbType.VarChar).Value = datos.Nom_pros
            adaptador.InsertCommand.Parameters.Add("@tel_pros", MySqlDbType.VarChar).Value = datos.Tel_pros

            adaptador.InsertCommand.Parameters.Add("@cel_pros", MySqlDbType.VarChar).Value = datos.Cel_pros
            adaptador.InsertCommand.Parameters.Add("@correo_pros", MySqlDbType.VarChar).Value = datos.Correo_pros

            adaptador.InsertCommand.Parameters.Add("@alta_pros", MySqlDbType.Date).Value = datos.Alta_pros

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function



    Public Function modificar(ByVal datos As c_prospecto, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update colaborador Set nom_pros=@nom_pros,tel_pros=@tel_pros,cel_pros=@cel_pros" &
                                                       ",correo_pros=@correo_pros where id_pros=@id_pros", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_pros", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_pros", MySqlDbType.VarChar).Value = datos.Nom_pros

            adaptador.UpdateCommand.Parameters.Add("@tel_pros", MySqlDbType.VarChar).Value = datos.Tel_pros
            adaptador.UpdateCommand.Parameters.Add("@cel_pros", MySqlDbType.VarChar).Value = datos.Cel_pros
            adaptador.UpdateCommand.Parameters.Add("@correo_pros", MySqlDbType.VarChar).Value = datos.Correo_pros


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function agregardetalle(ByVal clave As Integer, ByVal tipo As String, ByVal opc As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()

            Select Case opc
                Case 1
                    adaptador.InsertCommand = New MySqlCommand("insert into det_cabina (id_cabina,id_tipo) values (@id,@id_tipo)", _conexion)
                Case 2
                    adaptador.InsertCommand = New MySqlCommand("insert into det_col (id_col,id_tipo) values (@id,@id_tipo)", _conexion)
            End Select


            adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = clave
            adaptador.InsertCommand.Parameters.Add("@id_tipo", MySqlDbType.Int64).Value = Convert.ToInt64(tipo)



            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminardetalle(ByVal clave As Integer, ByVal opc As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            Select Case opc
                Case 1
                    adaptador.DeleteCommand = New MySqlCommand("delete from det_cabina where id_cabina=@id", _conexion)
                Case 2
                    adaptador.DeleteCommand = New MySqlCommand("delete from det_col where id_col=@id", _conexion)
            End Select

            adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = clave




            _conexion.Open()
            adaptador.DeleteCommand.Connection = _conexion
            adaptador.DeleteCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As c_cita) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into cita (id_persona,tipo_persona,nombre,fecha,id_cabina,fecha_final,duracion,id_serv,id_col,obs,cel,tel) " &
                                                       "values(@id_persona,@tipo_persona,@nombre,@fecha,@id_cabina,@fecha_final,@duracion,@id_serv,@id_col,@obs,@cel,@tel)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_persona", MySqlDbType.VarChar).Value = datos.Id_persona
            adaptador.InsertCommand.Parameters.Add("@tipo_persona", MySqlDbType.VarChar).Value = datos.Tipo_persona
            adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = datos.Nombre
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = Format(datos.Fecha, "yyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@id_cabina", MySqlDbType.VarChar).Value = datos.Id_cabina
            adaptador.InsertCommand.Parameters.Add("@fecha_final", MySqlDbType.DateTime).Value = Format(datos.Fecha_final, "yyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@duracion", MySqlDbType.Double).Value = datos.Duracion
            adaptador.InsertCommand.Parameters.Add("@id_serv", MySqlDbType.Int32).Value = datos.Id_serv
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int32).Value = datos.Id_col
            adaptador.InsertCommand.Parameters.Add("@obs", MySqlDbType.VarChar).Value = datos.Obs
            adaptador.InsertCommand.Parameters.Add("@cel", MySqlDbType.VarChar).Value = datos.Cel
            adaptador.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar).Value = datos.Tel

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificarcita(ByVal datos As c_cita, ByVal clave As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cita set fecha=@fecha,id_cabina=@id_cabina,fecha_final=@fecha_final,id_col=@id_col where folio=@folio", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.Int64).Value = clave

            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = Format(datos.Fecha, "yyy-MM-dd HH:mm:ss")
            adaptador.UpdateCommand.Parameters.Add("@id_cabina", MySqlDbType.VarChar).Value = datos.Id_cabina
            adaptador.UpdateCommand.Parameters.Add("@fecha_final", MySqlDbType.DateTime).Value = Format(datos.Fecha_final, "yyy-MM-dd HH:mm:ss")

            adaptador.UpdateCommand.Parameters.Add("@id_col", MySqlDbType.Int32).Value = datos.Id_col


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminarcita(ByVal clave As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cita set estado=0 where folio=@folio", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.VarChar).Value = clave


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function citavisita(ByVal clave As Integer, ByVal foliovis As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cita set estado=0,folio_vis=@folio_vis where folio=@folio", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.VarChar).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@folio_vis", MySqlDbType.VarChar).Value = foliovis

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarvisita(ByVal datos As c_visita) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into visita (id_clie,nombre,fecha,id_cabina,fecha_final,id_serv,id_col,obs,folio_cita,entrada) " &
                                                       "values(@id_clie,@nombre,@fecha,@id_cabina,@fecha_final,@id_serv,@id_col,@obs,@folio_cita,@entrada)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_clie", MySqlDbType.VarChar).Value = datos.Id_clie

            adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = datos.Nombre
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = Format(datos.Fecha, "yyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@id_cabina", MySqlDbType.VarChar).Value = datos.Id_cabina
            adaptador.InsertCommand.Parameters.Add("@fecha_final", MySqlDbType.DateTime).Value = Format(datos.Fecha_final, "yyy-MM-dd HH:mm:ss")

            adaptador.InsertCommand.Parameters.Add("@id_serv", MySqlDbType.Int32).Value = datos.Id_serv
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int32).Value = datos.Id_col
            adaptador.InsertCommand.Parameters.Add("@obs", MySqlDbType.VarChar).Value = datos.Obs
            adaptador.InsertCommand.Parameters.Add("@folio_cita", MySqlDbType.VarChar).Value = datos.Folio_cita
            adaptador.InsertCommand.Parameters.Add("@entrada", MySqlDbType.VarChar).Value = Format(datos.Entrada, "yyy-MM-dd HH:mm:ss")

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificarvisita(ByVal datos As c_visita, ByVal clave As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cita set fecha=@fecha,id_cabina=@id_cabina,fecha_final=@fecha_final,id_col=@id_col where folio=@folio", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.Int64).Value = clave

            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = Format(datos.Fecha, "yyy-MM-dd HH:mm:ss")
            adaptador.UpdateCommand.Parameters.Add("@id_cabina", MySqlDbType.VarChar).Value = datos.Id_cabina
            adaptador.UpdateCommand.Parameters.Add("@fecha_final", MySqlDbType.DateTime).Value = Format(datos.Fecha_final, "yyy-MM-dd HH:mm:ss")

            adaptador.UpdateCommand.Parameters.Add("@id_col", MySqlDbType.Int32).Value = datos.Id_col


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As c_horariocol) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into horariocol (id_dia,id_col,dia,entrada,salida) " &
                                                       "values (@id_dia,@id_col,@dia,@entrada,@salida)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_dia", MySqlDbType.Int64).Value = datos.Id_dia
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int64).Value = datos.Id_col

            adaptador.InsertCommand.Parameters.Add("@dia", MySqlDbType.VarChar).Value = datos.Dia
            adaptador.InsertCommand.Parameters.Add("@entrada", MySqlDbType.Time).Value = datos.Entrada

            adaptador.InsertCommand.Parameters.Add("@salida", MySqlDbType.Time).Value = datos.Salida

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function



    Public Function modificar(ByVal datos As c_horariocol, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update horariocol Set id_dia=@id_dia,dia=@dia" &
                                                       ",entrada=@entrada,salida=@salida where id_reg=@id_reg", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_reg", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_dia", MySqlDbType.Int64).Value = datos.Id_dia

            adaptador.UpdateCommand.Parameters.Add("@dia", MySqlDbType.VarChar).Value = datos.Dia
            adaptador.UpdateCommand.Parameters.Add("@entrada", MySqlDbType.Time).Value = datos.Entrada
            adaptador.UpdateCommand.Parameters.Add("@salida", MySqlDbType.Time).Value = datos.Salida


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As c_historia) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into historia (id_clie,fecha_his,atendio_his,emb_his,lact_his,dep_his,metdep_his,bron_his,metbron_his," &
                                                       "queloides_his,hormonas_his,cutaneas_his,descutaneas_his,vello_his,desvello_his,epilepsia_his,tatuajes_his,zonatatu_his," &
                                                       "sangre_his,dessangre_his,herpes_his,zovirax_his,alergias_his,desalergias_his,dispositivos_his,desdispositivos_his,medicacion_his) " &
                                                       "values(@id_clie,@fecha_his,@atendio_his,@emb_his,@lact_his,@dep_his,@metdep_his,@bron_his,@metbron_his," &
                                                       "@queloides_his,@hormonas_his,@cutaneas_his,@descutaneas_his,@vello_his,@desvello_his,@epilepsia_his,@tatuajes_his,@zonatatu_his," &
                                                       "@sangre_his,@dessangre_his,@herpes_his,@zovirax_his,@alergias_his,@desalergias_his,@dispositivos_his,@desdispositivos_his,@medicacion_his)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_clie", MySqlDbType.Int64).Value = datos.Id_clie
            adaptador.InsertCommand.Parameters.Add("@fecha_his", MySqlDbType.Date).Value = Format(datos.Fecha_his, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@atendio_his", MySqlDbType.VarChar).Value = datos.Atendio_his
            adaptador.InsertCommand.Parameters.Add("@emb_his", MySqlDbType.VarChar).Value = datos.Emb_his
            adaptador.InsertCommand.Parameters.Add("@lact_his", MySqlDbType.VarChar).Value = datos.Lact_his
            adaptador.InsertCommand.Parameters.Add("@dep_his", MySqlDbType.VarChar).Value = datos.Dep_his
            adaptador.InsertCommand.Parameters.Add("@metdep_his", MySqlDbType.VarChar).Value = datos.Metdep_his
            adaptador.InsertCommand.Parameters.Add("@bron_his", MySqlDbType.VarChar).Value = datos.Bron_his
            adaptador.InsertCommand.Parameters.Add("@metbron_his", MySqlDbType.VarChar).Value = datos.Metbron_his
            adaptador.InsertCommand.Parameters.Add("@queloides_his", MySqlDbType.Int16).Value = datos.Queloides_his
            adaptador.InsertCommand.Parameters.Add("@hormonas_his", MySqlDbType.Int16).Value = datos.Hormonas_his
            adaptador.InsertCommand.Parameters.Add("@cutaneas_his", MySqlDbType.Int16).Value = datos.Cutaneas_his
            adaptador.InsertCommand.Parameters.Add("@descutaneas_his", MySqlDbType.VarChar).Value = datos.Descuetaneas_his
            adaptador.InsertCommand.Parameters.Add("@vello_his", MySqlDbType.Int16).Value = datos.Vello_his
            adaptador.InsertCommand.Parameters.Add("@desvello_his", MySqlDbType.VarChar).Value = datos.Desvello
            adaptador.InsertCommand.Parameters.Add("@epilepsia_his", MySqlDbType.Int16).Value = datos.Epilepsia_his
            adaptador.InsertCommand.Parameters.Add("@tatuajes_his", MySqlDbType.Int16).Value = datos.Tatuajes_his
            adaptador.InsertCommand.Parameters.Add("@zonatatu_his", MySqlDbType.VarChar).Value = datos.Zonatatu_his

            adaptador.InsertCommand.Parameters.Add("@sangre_his", MySqlDbType.Int16).Value = datos.sangre_his
            adaptador.InsertCommand.Parameters.Add("@dessangre_his", MySqlDbType.VarChar).Value = datos.dessangre_his
            adaptador.InsertCommand.Parameters.Add("@herpes_his", MySqlDbType.Int16).Value = datos.Herpes_his
            adaptador.InsertCommand.Parameters.Add("@zovirax_his", MySqlDbType.VarChar).Value = datos.Zovirax_his
            adaptador.InsertCommand.Parameters.Add("@alergias_his", MySqlDbType.Int16).Value = datos.Alergias_his
            adaptador.InsertCommand.Parameters.Add("@desalergias_his", MySqlDbType.VarChar).Value = datos.Desalergias_his
            adaptador.InsertCommand.Parameters.Add("@dispositivos_his", MySqlDbType.Int16).Value = datos.Dispositivo_his
            adaptador.InsertCommand.Parameters.Add("@desdispositivos_his", MySqlDbType.VarChar).Value = datos.Desdispositivo_his
            adaptador.InsertCommand.Parameters.Add("@medicacion_his", MySqlDbType.VarChar).Value = datos.Medicacion_his
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function insertarnuevo(ByVal datos As c_producto) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into producto (clave_prod,nom_prod,precio_prod,min_prod,unidad_prod,vendible_prod,costo_prod,nom_marca) " &
                                                       "values (@clave_prod,@nom_prod,@precio_prod,@min_prod,@unidad_prod,@vendible_prod,@costo_prod,@nom_marca)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@clave_prod", MySqlDbType.String).Value = datos.Clave_prod
            adaptador.InsertCommand.Parameters.Add("@nom_prod", MySqlDbType.String).Value = datos.Nom_prod
            adaptador.InsertCommand.Parameters.Add("@nom_marca", MySqlDbType.String).Value = datos.Nom_marca

            adaptador.InsertCommand.Parameters.Add("@precio_prod", MySqlDbType.Double).Value = datos.Precio_prod
            adaptador.InsertCommand.Parameters.Add("@min_prod", MySqlDbType.Double).Value = datos.Min_prod

            adaptador.InsertCommand.Parameters.Add("@unidad_prod", MySqlDbType.String).Value = datos.Unidad_prod
            adaptador.InsertCommand.Parameters.Add("@vendible_prod", MySqlDbType.Bit).Value = datos.Vendible_prod
            adaptador.InsertCommand.Parameters.Add("@costo_prod", MySqlDbType.Double).Value = datos.Costo_prod

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function



    Public Function modificar(ByVal datos As c_producto, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update producto Set clave_prod=@clave_prod,nom_prod=@nom_prod,nom_marca=@nom_marca" &
                                                       ",precio_prod=@precio_prod,min_prod=@min_prod,unidad_prod=@unidad_prod,vendible_prod=@vendible_prod,costo_prod=@costo_prod where id_prod=@id_prod", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.String).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@clave_prod", MySqlDbType.String).Value = datos.Clave_prod
            adaptador.UpdateCommand.Parameters.Add("@nom_prod", MySqlDbType.String).Value = datos.Nom_prod
            adaptador.UpdateCommand.Parameters.Add("@nom_marca", MySqlDbType.String).Value = datos.Nom_marca

            adaptador.UpdateCommand.Parameters.Add("@precio_prod", MySqlDbType.Double).Value = datos.Precio_prod
            adaptador.UpdateCommand.Parameters.Add("@min_prod", MySqlDbType.Double).Value = datos.Min_prod

            adaptador.UpdateCommand.Parameters.Add("@unidad_prod", MySqlDbType.String).Value = datos.Unidad_prod
            adaptador.UpdateCommand.Parameters.Add("@vendible_prod", MySqlDbType.Bit).Value = datos.Vendible_prod
            adaptador.UpdateCommand.Parameters.Add("@costo_prod", MySqlDbType.Double).Value = datos.Costo_prod

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminarprod(ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update producto Set estado_prod=0 where id_prod=@id_prod", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.String).Value = clave
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

#Region "INVENTARIO"

    Public Function insertarmov(ByVal datos As c_movimiento) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into movimiento (id_prod,id_tipomov,fecha_mov,ini_mov,cant_mov,unidad_mov,fin_mov,obs_mov,id_almacen) values (@id_prod,@tipo_mov,@fecha_mov,@ini_mov,@cant_mov,@unidad_mov,@fin_mov,@obs_mov,@id_almacen)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = datos.Id_producto
            adaptador.InsertCommand.Parameters.Add("@tipo_mov", MySqlDbType.Int32).Value = datos.Tipo_mov
            adaptador.InsertCommand.Parameters.Add("@fecha_mov", MySqlDbType.Date).Value = Format(datos.Fecha_mov, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@ini_mov", MySqlDbType.Double).Value = datos.Ini_mov
            adaptador.InsertCommand.Parameters.Add("@cant_mov", MySqlDbType.Double).Value = datos.Cant_mov
            adaptador.InsertCommand.Parameters.Add("@unidad_mov", MySqlDbType.String).Value = datos.Unidad_mov
            adaptador.InsertCommand.Parameters.Add("@fin_mov", MySqlDbType.Double).Value = datos.Fin_mov
            adaptador.InsertCommand.Parameters.Add("@obs_mov", MySqlDbType.String).Value = datos.Obs_mov
            adaptador.InsertCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = datos.Id_almacen
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function actualizarproducto(ByVal clave As String, ByVal final As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update producto set cant_prod=@final where id_prod=@id_prod", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.Int32).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double).Value = final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function aumentarsaldo(ByVal clave As String, ByVal monto As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cxc set saldo_cxc=saldo_cxc + @monto where folio_cxc=@folio_cxc", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_cxc", MySqlDbType.Int32).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = monto

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function cancelar(ByVal clave As String, ByVal tipo As String, ByVal fecha As Date, ByVal responsable As String, ByVal usuario As String, ByVal motivo As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()

            Select Case tipo
                Case 1
                    adaptador.UpdateCommand = New MySqlCommand("update cxc Set estado_cxc=0,fecha_can=@fecha,usuario_can=@usuario,col_can=@colaborador,motivo_can=@motivo where folio_cxc=@folio", _conexion)
                Case 2
                    adaptador.UpdateCommand = New MySqlCommand("update pago set estado_pago=0,fecha_can=@fecha,usuario_can=@usuario,col_can=@colaborador,motivo_can=@motivo where folio_pago=@folio", _conexion)


            End Select

            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.String).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = fecha
            adaptador.UpdateCommand.Parameters.Add("@colaborador", MySqlDbType.String).Value = responsable
            adaptador.UpdateCommand.Parameters.Add("@motivo", MySqlDbType.String).Value = motivo
            adaptador.UpdateCommand.Parameters.Add("@usuario", MySqlDbType.String).Value = usuario
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function primerinv(ByVal clave As String, ByVal almacen As String, ByVal cantidad As Double, ByVal unidad As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into inventario (id_almacen,id_prod,cant_prod,nom_unidad) values (@id_almacen,@id_prod,@cant_prod,@nom_unidad)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = clave
            adaptador.InsertCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = almacen
            adaptador.InsertCommand.Parameters.Add("@cant_prod", MySqlDbType.Double).Value = cantidad
            adaptador.InsertCommand.Parameters.Add("@nom_unidad", MySqlDbType.String).Value = unidad

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function actualizarinv(ByVal clave As String, ByVal almacen As String, ByVal final As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update inventario set cant_prod=@final where id_prod=@id_prod and id_almacen=@id_almacen", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = almacen
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double).Value = final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region
    Public Function darsalida(ByVal clave As String, ByVal folio As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update visita set salida=@salida,id_cont=@folio,estado=0 where folio_vis=@folio_vis", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_vis", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.Int64).Value = folio
            adaptador.UpdateCommand.Parameters.Add("@salida", MySqlDbType.DateTime).Value = Format(Now, "yyyy-MM-dd HH:mm:ss")

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As c_cxc) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into cxc(id_clie,fecha_cxc,total_cxc,saldo_cxc,id_col,nom_col,concepto_cxc,subtotal_cxc,descuento_cxc) values (@id_clie,@fecha_cxc,@total_cxc,@saldo_cxc,@id_col,@nom_col,@concepto_cxc,@subtotal_cxc,@descuento_cxc)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_clie", MySqlDbType.Int64).Value = datos.Id_clie
            adaptador.InsertCommand.Parameters.Add("@fecha_cxc", MySqlDbType.DateTime).Value = Format(datos.Fecha_cxc, "yyyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@total_cxc", MySqlDbType.Double).Value = datos.Total_cxc
            adaptador.InsertCommand.Parameters.Add("@saldo_cxc", MySqlDbType.Double).Value = datos.Saldo_cxc
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int64).Value = datos.Id_col
            adaptador.InsertCommand.Parameters.Add("@nom_col", MySqlDbType.String).Value = datos.Nom_col
            adaptador.InsertCommand.Parameters.Add("@concepto_cxc", MySqlDbType.String).Value = datos.Concepto_cxc
            adaptador.InsertCommand.Parameters.Add("@subtotal_cxc", MySqlDbType.Double).Value = datos.Subtotal_cxc
            adaptador.InsertCommand.Parameters.Add("@descuento_cxc", MySqlDbType.Double).Value = datos.Descuento_cxc

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertardet(ByVal datos As c_det_cxc) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into det_cxc(folio_cxc,id_item,id_pqt,clave,concepto,cantidad,precio,subtotal,tipo_item) values (@folio_cxc,@id_item,@id_pqt,@clave,@concepto,@cantidad,@precio,@subtotal,@tipo_item)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@folio_cxc", MySqlDbType.Int64).Value = datos.Folio_cxc
            adaptador.InsertCommand.Parameters.Add("@id_item", MySqlDbType.Int64).Value = datos.Id_item
            adaptador.InsertCommand.Parameters.Add("@id_pqt", MySqlDbType.Int64).Value = datos.Id_pqt
            adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datos.Clave
            adaptador.InsertCommand.Parameters.Add("@concepto", MySqlDbType.String).Value = datos.Concepto
            adaptador.InsertCommand.Parameters.Add("@cantidad", MySqlDbType.Double).Value = datos.Cantidad
            adaptador.InsertCommand.Parameters.Add("@precio", MySqlDbType.Double).Value = datos.Precio
            adaptador.InsertCommand.Parameters.Add("@subtotal", MySqlDbType.Double).Value = datos.Subtotal
            adaptador.InsertCommand.Parameters.Add("@tipo_item", MySqlDbType.String).Value = datos.Tipo_item

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function nuevopago(ByVal datos As c_pago) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into pago(folio_cxc,folio_fis,fecha_pago,importe_pago,id_metodo,nom_metodo,dinero_pago,cambio_pago,id_col,nom_col,tipo_pago,saldoini_cxc,saldofin_cxc,letra_pago)" &
                                                       " values (@folio_cxc,@folio_fis,@fecha_pago,@importe_pago,@id_metodo,@nom_metodo,@dinero_pago,@cambio_pago,@id_col,@nom_col,@tipo_pago,@saldoini_cxc,@saldofin_cxc,@letra_pago)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@folio_cxc", MySqlDbType.Int64).Value = datos.Folio_cxc
            adaptador.InsertCommand.Parameters.Add("@folio_fis", MySqlDbType.Int64).Value = datos.Folio_fis
            adaptador.InsertCommand.Parameters.Add("@fecha_pago", MySqlDbType.DateTime).Value = Format(datos.Fecha_pago, "yyyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@importe_pago", MySqlDbType.Double).Value = datos.Importe_pago
            adaptador.InsertCommand.Parameters.Add("@id_metodo", MySqlDbType.String).Value = datos.Id_metodo
            adaptador.InsertCommand.Parameters.Add("@nom_metodo", MySqlDbType.String).Value = datos.Nom_metodo
            adaptador.InsertCommand.Parameters.Add("@dinero_pago", MySqlDbType.Double).Value = datos.Dinero_pago
            adaptador.InsertCommand.Parameters.Add("@cambio_pago", MySqlDbType.Double).Value = datos.Cambio_pago
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int64).Value = datos.Id_col
            adaptador.InsertCommand.Parameters.Add("@nom_col", MySqlDbType.String).Value = datos.Nom_col
            adaptador.InsertCommand.Parameters.Add("@tipo_pago", MySqlDbType.Int16).Value = datos.Tipo_pago
            adaptador.InsertCommand.Parameters.Add("@saldoini_cxc", MySqlDbType.Double).Value = datos.Saldoini_cxc
            adaptador.InsertCommand.Parameters.Add("@saldofin_cxc", MySqlDbType.Double).Value = datos.Saldofin_cxc
            adaptador.InsertCommand.Parameters.Add("@letra_pago", MySqlDbType.String).Value = datos.Letra_pago
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function actualizar_saldo(ByVal clave As Integer, ByVal monto As Decimal, ByVal operacion As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            Select Case operacion
                Case 1
                    adaptador.UpdateCommand = New MySqlCommand("update cxc Set saldo_cxc= saldo_cxc- @monto where folio_cxc=@folio_cxc", _conexion)
                Case 2

                Case 3

            End Select




            adaptador.UpdateCommand.Parameters.Add("@folio_cxc", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = monto

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function asignar_foliofiscal(ByVal folio_pago As Int64, ByVal folio As Int64) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update pago set folio_fis=@folio_fis where folio_cxc=@folio_cxc", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_fis", MySqlDbType.Int32, 11).Value = folio + 1
            adaptador.UpdateCommand.Parameters.Add("@folio_cxc", MySqlDbType.Double, 22).Value = folio_pago
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function actualizarprospecto(ByVal clave As Int64) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update prospecto set estado_pros='0' where id_pros=@id_pros", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_pros", MySqlDbType.Int64, 11).Value = clave
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function Obtener_Inicial(ByVal sqlcons As String) As String
        Try
            conexion()
            Dim val As Integer = 0
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                Return Convert.ToString(ta.Rows(0).Item("cant_prod"))
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            Return 0
        Finally
            desconectar()

        End Try
    End Function

    Public Function nuevocontrato(ByVal datos As c_paquete_cont) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into paquete_cont(id_clie,id_serv,id_pqt,numero_s,restante_s,fecha_ini,fecha_max,id_col,nom_col,precio,saldo,pagado,estado_serv)" &
                                                       " values (@id_clie,@id_serv,@id_pqt,@numero_s,@restante_s,@fecha_ini,@fecha_max,@id_col,@nom_col,@precio,@saldo,@pagado,@estado_serv)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_clie", MySqlDbType.Int64).Value = datos.Id_clie
            adaptador.InsertCommand.Parameters.Add("@id_serv", MySqlDbType.Int64).Value = datos.Id_serv
            adaptador.InsertCommand.Parameters.Add("@id_pqt", MySqlDbType.Int64).Value = datos.Id_pqt
            adaptador.InsertCommand.Parameters.Add("@numero_s", MySqlDbType.Double).Value = datos.Numero_s
            adaptador.InsertCommand.Parameters.Add("@restante_s", MySqlDbType.Double).Value = datos.Restante_s
            adaptador.InsertCommand.Parameters.Add("@fecha_ini", MySqlDbType.Date).Value = Format(datos.Fecha_ini, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@fecha_max", MySqlDbType.Date).Value = Format(datos.Fecha_max, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@id_col", MySqlDbType.Int64).Value = datos.Id_col
            adaptador.InsertCommand.Parameters.Add("@nom_col", MySqlDbType.String).Value = datos.Nom_col
            adaptador.InsertCommand.Parameters.Add("@precio", MySqlDbType.Double).Value = datos.Precio
            adaptador.InsertCommand.Parameters.Add("@saldo", MySqlDbType.Double).Value = datos.Saldo
            adaptador.InsertCommand.Parameters.Add("@pagado", MySqlDbType.Double).Value = datos.Pagado
            adaptador.InsertCommand.Parameters.Add("@estado_serv", MySqlDbType.String).Value = datos.Estado_serv
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function pagocontrato(ByVal clave As Int64, ByVal pago As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update paquete_cont set saldo=saldo-@pago,pagado=pagado+@pago where id_cont=@clave", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@pago", MySqlDbType.Double).Value = pago

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function visitacontrato(ByVal clave As Int64) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update paquete_cont set restante_s=restante_s-1 where id_cont=@clave", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.Int64).Value = clave


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function paqueteventa(ByVal clave As String, ByVal folio As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cxc set id_cont=@folio where folio_cxc=@clave", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@folio", MySqlDbType.Int64).Value = folio


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

#Region "ALMACEN"
    Public Function insertarnuevo(ByVal datos As c_almacen) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into almacen(nom_almacen) values (@nom_almacen)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_almacen", MySqlDbType.VarChar).Value = datos.Nom_almacen


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function modificar(ByVal datos As c_almacen, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update almacen Set nom_almacen=@nom_almacen where id_almacen=@id_almacen", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_almacen", MySqlDbType.VarChar).Value = datos.Nom_almacen



            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "ELIMINAR"
    Public Function eliminar(ByVal clave As String, ByVal indice As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            Select Case indice
                Case 1
                   ' adaptador.UpdateCommand = New MySqlCommand("update mesa Set estado_mesa=0 where id_mesa=@id", _conexion)
                Case 2
                    adaptador.UpdateCommand = New MySqlCommand("update unidad Set estado_unidad=0 where id_unidad=@id", _conexion)
                Case 3
                    adaptador.UpdateCommand = New MySqlCommand("update cajero Set estado_cajero=0 where id_cajero=@id", _conexion)
                Case 4
                    adaptador.UpdateCommand = New MySqlCommand("update insumo SET estado_insumo=0 where id_insumo=@id", _conexion)
                Case 5
                    adaptador.UpdateCommand = New MySqlCommand("update almacen Set estado_almacen=0 where id_almacen=@id", _conexion)
                Case 6
                   ' adaptador.UpdateCommand = New MySqlCommand("update alimento Set estado_ali=0 where id_ali=@id", _conexion)
                Case 7
                  '  adaptador.UpdateCommand = New MySqlCommand("update guarnicion Set estado_guar=0 where id_guar=@id", _conexion)
                Case 8
                  '  adaptador.UpdateCommand = New MySqlCommand("update det_guar Set estado_det=0 where id_det=@id", _conexion)


                    'eliminacion anidada de tipo


                Case 9
                  '  adaptador.UpdateCommand = New MySqlCommand("update alimento Set estado_ali=0 where id_subtipo=@id", _conexion)
                Case 10
                 '   adaptador.UpdateCommand = New MySqlCommand("update guarnicion Set estado_guar=0 where id_subtipo=@id", _conexion)
                Case 11
                 '   adaptador.UpdateCommand = New MySqlCommand("update det_guar Set estado_det=0 where id_subtipo=@id", _conexion)

                Case 12
                    '   adaptador.UpdateCommand = New MySqlCommand("update subtipo Set estado_subtipo=0 where id_tipo=@id", _conexion)


            End Select

            adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = clave


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "MARCA"
    Public Function insertarnuevo(ByVal datos As c_marca) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into marca (nom_marca) values (@nom_marca)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_marca", MySqlDbType.VarChar).Value = datos.Nom_marca
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'puesto
    Public Function modificar(ByVal datos As c_marca, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update marca Set nom_marca=@nom_marca where id_marca=@id_marca", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_marca", MySqlDbType.VarChar).Value = datos.Nom_marca

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "PROVEEDOR"
    Public Function insertarnuevo(ByVal datos As c_proveedor) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into proveedor(nom_prov,direccion,tel,cel,correo,rfc) " &
                                                       "values (@nom_prov,@dir_prov,@tel_prov,@cel_prov,@correo_prov,@rfc_prov)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_prov", MySqlDbType.VarChar).Value = datos.Nom_prov
            adaptador.InsertCommand.Parameters.Add("@dir_prov", MySqlDbType.VarChar).Value = datos.Direccion
            adaptador.InsertCommand.Parameters.Add("@tel_prov", MySqlDbType.VarChar).Value = datos.Tel
            adaptador.InsertCommand.Parameters.Add("@cel_prov", MySqlDbType.VarChar).Value = datos.Cel
            adaptador.InsertCommand.Parameters.Add("@correo_prov", MySqlDbType.VarChar).Value = datos.Correo
            adaptador.InsertCommand.Parameters.Add("@rfc_prov", MySqlDbType.VarChar).Value = datos.Rfc


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_proveedor, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update proveedor Set nom_prov=@nom_prov,direccion=@dir_prov,tel=@tel_prov,cel=@cel_prov" &
                                                       ",correo=@correo_prov,rfc=@rfc_prov where id_prov=@id_prov", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prov", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_prov", MySqlDbType.VarChar).Value = datos.Nom_prov
            adaptador.UpdateCommand.Parameters.Add("@dir_prov", MySqlDbType.VarChar).Value = datos.Direccion
            adaptador.UpdateCommand.Parameters.Add("@tel_prov", MySqlDbType.VarChar).Value = datos.Tel
            adaptador.UpdateCommand.Parameters.Add("@cel_prov", MySqlDbType.VarChar).Value = datos.Cel
            adaptador.UpdateCommand.Parameters.Add("@correo_prov", MySqlDbType.VarChar).Value = datos.Correo
            adaptador.UpdateCommand.Parameters.Add("@rfc_prov", MySqlDbType.VarChar).Value = datos.Rfc

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "EGRESOS"
    Public Function insertarnuevo(ByVal datos As c_egreso) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into egresos(fecha_egr,facturado,ref_egr,id_prov,id_partida,id_subpartida,concepto_egr,metodo_egr,total_egr) " &
                                                       "values (@fecha_egr,@facturado,@ref_egr,@id_prov,@id_partida,@id_subpartida,@concepto_egr,@metodo_egr,@total_egr)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@fecha_egr", MySqlDbType.Date).Value = Format(datos.Fecha_egr, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@facturado", MySqlDbType.Int16).Value = datos.Facturado
            adaptador.InsertCommand.Parameters.Add("@ref_egr", MySqlDbType.VarChar).Value = datos.Ref_egr
            adaptador.InsertCommand.Parameters.Add("@id_prov", MySqlDbType.VarChar).Value = datos.Id_prov
            adaptador.InsertCommand.Parameters.Add("@id_partida", MySqlDbType.VarChar).Value = datos.Id_partida
            adaptador.InsertCommand.Parameters.Add("@id_subpartida", MySqlDbType.VarChar).Value = datos.Id_subpartida
            adaptador.InsertCommand.Parameters.Add("@concepto_egr", MySqlDbType.VarChar).Value = datos.Concepto_egr
            adaptador.InsertCommand.Parameters.Add("@metodo_egr", MySqlDbType.VarChar).Value = datos.Metodo_egr
            adaptador.InsertCommand.Parameters.Add("@total_egr", MySqlDbType.Decimal).Value = datos.Total_egr


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_egreso, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update egresos Set fecha_egr=@fecha_egr,facturado=@facturado,ref_egr=@ref_egr,id_prov=@id_prov,id_partida=@id_partida,id_subpartida=@id_subpartida,concepto_egr=@concepto_egr,metodo_egr=@metodo_egr,total_egr=@total_egr" &
                                                       " where id_egr=@id_egr", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_egr", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@fecha_egr", MySqlDbType.Date).Value = Format(datos.Fecha_egr, "yyyy-MM-dd")
            adaptador.UpdateCommand.Parameters.Add("@facturado", MySqlDbType.Int16).Value = datos.Facturado
            adaptador.UpdateCommand.Parameters.Add("@ref_egr", MySqlDbType.VarChar).Value = datos.Ref_egr
            adaptador.UpdateCommand.Parameters.Add("@id_prov", MySqlDbType.VarChar).Value = datos.Id_prov
            adaptador.UpdateCommand.Parameters.Add("@id_partida", MySqlDbType.VarChar).Value = datos.Id_partida
            adaptador.UpdateCommand.Parameters.Add("@id_subpartida", MySqlDbType.VarChar).Value = datos.Id_subpartida
            adaptador.UpdateCommand.Parameters.Add("@concepto_egr", MySqlDbType.VarChar).Value = datos.Concepto_egr
            adaptador.UpdateCommand.Parameters.Add("@metodo_egr", MySqlDbType.VarChar).Value = datos.Metodo_egr
            adaptador.UpdateCommand.Parameters.Add("@total_egr", MySqlDbType.Double).Value = datos.Total_egr
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "IMPRESION"
    Public Function actualizarimpresion(ByVal folio As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update pago set impreso=1 where folio_pago=@folio_pago", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_pago", MySqlDbType.Int64).Value = folio


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "W CLIENTE"
    'cliente
    Public Function insertarnuevo(ByVal datos As c_wcliente) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into wcliente (curp_clie,rfc_clie,nom_clie,dir_clie," &
                                                       "tel_clie,ws_clie,correo_clie,nac_clie," &
                                                       "gen_clie,ecivil_clie,niv_clie,ocupacion_clie,medio_clie) " &
                                                       "values(@curp_clie,@rfc_clie,@nom_clie,@dir_clie," &
                                                       "tel_clie,@ws_clie,@correo_clie,@nac_clie," &
                                                       "@gen_clie,@ecivil_clie,@niv_clie,@ocupacion_clie,@medio_clie)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@curp_clie", MySqlDbType.VarChar).Value = datos.Curp_clie
            adaptador.InsertCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar).Value = datos.Rfc_clie
            adaptador.InsertCommand.Parameters.Add("@nom_clie", MySqlDbType.VarChar).Value = datos.Nom_clie
            adaptador.InsertCommand.Parameters.Add("@dir_clie", MySqlDbType.VarChar).Value = datos.Dir_clie

            adaptador.InsertCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar).Value = datos.Tel_clie
            adaptador.InsertCommand.Parameters.Add("@ws_clie", MySqlDbType.VarChar).Value = datos.Ws_clie
            adaptador.InsertCommand.Parameters.Add("@correo_clie", MySqlDbType.VarChar).Value = datos.Correo_clie
            adaptador.InsertCommand.Parameters.Add("@nac_clie", MySqlDbType.Date).Value = datos.Nac_clie



            adaptador.InsertCommand.Parameters.Add("@gen_clie", MySqlDbType.VarChar).Value = datos.Gen_clie
            adaptador.InsertCommand.Parameters.Add("@ecivil_clie", MySqlDbType.VarChar).Value = datos.Ecivil_clie


            adaptador.InsertCommand.Parameters.Add("@niv_clie", MySqlDbType.VarChar).Value = datos.Niv_clie
            adaptador.InsertCommand.Parameters.Add("@ocupacion_clie", MySqlDbType.VarChar).Value = datos.Ocupacion_clie
            adaptador.InsertCommand.Parameters.Add("@medio_clie", MySqlDbType.VarChar).Value = datos.Medio_clie
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    'cliente
    Public Function modificar(ByVal datos As c_wcliente, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("UPDATE wcliente SET rfc_clie=@rfc_clie,curp_clie=@curp_clie,nom_clie=@nom_clie,dir_clie=@dir_clie," &
                                                       "tel_clie=@tel_clie," &
                                                       "ws_clie=@ws_clie,correo_clie=@correo_clie,nac_clie=@nac_clie,medio_clie=@medio_clie," &
                                                       "gen_clie=@gen_clie,ecivil_clie=@ecivil_clie,niv_clie=@niv_clie,ocupacion_clie=@ocupacion_clie" &
                                                       " WHERE id_clie=@clave", _conexion)

            adaptador.UpdateCommand.Parameters.Add("@clave", MySqlDbType.String).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@curp_clie", MySqlDbType.VarChar).Value = datos.Curp_clie
            adaptador.UpdateCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar).Value = datos.Rfc_clie
            adaptador.UpdateCommand.Parameters.Add("@nom_clie", MySqlDbType.VarChar).Value = datos.Nom_clie
            adaptador.UpdateCommand.Parameters.Add("@dir_clie", MySqlDbType.VarChar).Value = datos.Dir_clie

            adaptador.UpdateCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar).Value = datos.Tel_clie
            adaptador.UpdateCommand.Parameters.Add("@ws_clie", MySqlDbType.VarChar).Value = datos.Ws_clie
            adaptador.UpdateCommand.Parameters.Add("@correo_clie", MySqlDbType.VarChar).Value = datos.Correo_clie
            adaptador.UpdateCommand.Parameters.Add("@nac_clie", MySqlDbType.Date).Value = datos.Nac_clie

            adaptador.UpdateCommand.Parameters.Add("@alta_clie", MySqlDbType.Date).Value = datos.Alta_clie

            adaptador.UpdateCommand.Parameters.Add("@gen_clie", MySqlDbType.VarChar).Value = datos.Gen_clie
            adaptador.UpdateCommand.Parameters.Add("@ecivil_clie", MySqlDbType.VarChar).Value = datos.Ecivil_clie

            adaptador.UpdateCommand.Parameters.Add("@niv_clie", MySqlDbType.VarChar).Value = datos.Niv_clie
            adaptador.UpdateCommand.Parameters.Add("@ocupacion_clie", MySqlDbType.VarChar).Value = datos.Ocupacion_clie
            adaptador.UpdateCommand.Parameters.Add("@medio_clie", MySqlDbType.VarChar).Value = datos.Medio_clie

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region


#Region "CAJA"
    Public Function insertarnuevo(ByVal datos As c_caja) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into caja (fecha,inicial) values (@fecha,@inicial)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = Format(datos.Fecha, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@inicial", MySqlDbType.Double).Value = datos.Inicial
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function modificarapertura(ByVal monto As Double, ByVal fecha As Date) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update caja Set inicial=@monto,fecha=@fecha where fecha=@fecha", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = monto
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = fecha
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function actualizarcaja(ByVal datos As c_caja) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update caja Set inicial=@monto,fecha=@fecha,efectivo=@efectivo,depositos=@deposito,transferencias=@transferencias,tdebito=@tdebito,tcredito=@tcredito,amex=@amex,otros=@otros,gastos=@gastos,retiros=@retiros,final=@final where id_caja=@id_caja", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_caja", MySqlDbType.Int64).Value = datos.Id_caja
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = datos.Fecha
            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = datos.Inicial
            adaptador.UpdateCommand.Parameters.Add("@efectivo", MySqlDbType.Double).Value = datos.Efectivo

            adaptador.UpdateCommand.Parameters.Add("@deposito", MySqlDbType.Double).Value = datos.Deposito
            adaptador.UpdateCommand.Parameters.Add("@transferencias", MySqlDbType.Double).Value = datos.Transferencia
            adaptador.UpdateCommand.Parameters.Add("@tdebito", MySqlDbType.Double).Value = datos.Tdebito
            adaptador.UpdateCommand.Parameters.Add("@tcredito", MySqlDbType.Double).Value = datos.Tcredito
            adaptador.UpdateCommand.Parameters.Add("@amex", MySqlDbType.Double).Value = datos.Amex

            adaptador.UpdateCommand.Parameters.Add("@otros", MySqlDbType.Double).Value = datos.Otros
            adaptador.UpdateCommand.Parameters.Add("@gastos", MySqlDbType.Double).Value = datos.Gastos
            adaptador.UpdateCommand.Parameters.Add("@retiros", MySqlDbType.Double).Value = datos.Retiros
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double).Value = datos.Final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As c_gasto) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into gasto (fecha,facturado,referencia,concepto,monto) values (@fecha,@facturado,@referencia,@concepto,@monto)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = Format(datos.Fecha, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@facturado", MySqlDbType.Bit).Value = datos.Facturado
            adaptador.InsertCommand.Parameters.Add("@referencia", MySqlDbType.String).Value = datos.Referencia
            adaptador.InsertCommand.Parameters.Add("@concepto", MySqlDbType.String).Value = datos.Concepto
            adaptador.InsertCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = datos.Monto

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As c_gasto, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update gasto Set fecha=@fecha,facturado=@facturado,referencia=@referencia,concepto=@concepto,monto=@monto" &
                                                       " where id_gasto=@id_gasto", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_gasto", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = Format(datos.Fecha, "yyyy-MM-dd")
            adaptador.UpdateCommand.Parameters.Add("@facturado", MySqlDbType.Int16).Value = datos.Facturado
            adaptador.UpdateCommand.Parameters.Add("@referencia", MySqlDbType.VarChar).Value = datos.Referencia

            adaptador.UpdateCommand.Parameters.Add("@concepto", MySqlDbType.VarChar).Value = datos.Concepto

            adaptador.UpdateCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = datos.Monto
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As c_retiro) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into retiro (fecha,monto) values (@fecha,@monto)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date).Value = Format(datos.Fecha, "yyyy-MM-dd")

            adaptador.InsertCommand.Parameters.Add("@monto", MySqlDbType.Double).Value = datos.Monto

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

#End Region

End Class