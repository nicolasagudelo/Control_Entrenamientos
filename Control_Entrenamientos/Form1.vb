'Programador: Nicolas Alberto Agudelo Herrera

Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports ZKFPEngXControl

Public Class Form1
    Dim conn As New MySqlConnection
    Private Sub BtnFiltrarFechas_Click(sender As Object, e As EventArgs) Handles BtnFiltrarFechas.Click

        Dim reader As MySqlDataReader
        If CmbBxCodigoEntrenamiento.SelectedValue = "" Then

            If FechaInicio.Value > FechaFin.Value Then
                MsgBox("La fecha inicial no puede estar despues de la fecha final")
                Exit Sub
            End If
            Dim numero_entrenamientos As String
            Dim fecha_inicial As String = FechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim fecha_final As String = FechaFin.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("select count(*) as c
                                                               from rel_prueba_usuarios 
                                                               where Fecha_realizada between '" & fecha_inicial & "' and '" & fecha_final & "';"), conn)
                numero_entrenamientos = Convert.ToString(cmd.ExecuteScalar())
                LblNEntrenamientos.Text = numero_entrenamientos
                LblNumeroEntrenamientos.Visible = True
                LblNEntrenamientos.Visible = True
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            Try
                Dim cmd As New MySqlCommand("Select Pruebas.PruebaID as 'Codigo Prueba', Pruebas.Nombre as 'Prueba', u1.Nombre as 'Nombre', Fecha_Realizada as 'Fecha Realizada', fecha_Siguiente 'Proxima Fecha', Entrenador
                                        from usuarios as u1 inner join rel_prueba_usuarios on u1.UsuarioID = rel_prueba_usuarios.UsuarioID
                                        inner join pruebas on pruebas.pruebaId = rel_prueba_usuarios.PruebaID
                                        where (Fecha_Realizada between '" & fecha_inicial & "' and '" & fecha_final & "')
                                        Order By pruebas.nombre, u1.nombre", conn)
                conn.Open()
                Console.WriteLine("Entrenamientos entre fechas")

                reader = cmd.ExecuteReader()

                Dim table As New DataTable
                table.Load(reader)
                DGVEntrenamientos.DataSource = table
                DGVEntrenamientos.ReadOnly = True
                DGVEntrenamientos.AllowUserToResizeColumns = True
                DGVEntrenamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                conn.Close()
            End Try

        Else

            If FechaInicio.Value > FechaFin.Value Then
                MsgBox("La fecha inicial no puede estar despues de la fecha final")
                Exit Sub
            End If
            Dim numero_entrenamientos As String
            Dim fecha_inicial As String = FechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim fecha_final As String = FechaFin.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("select count(*) as c
                                                               from rel_prueba_usuarios 
                                                               where PruebaID = '" & CmbBxCodigoEntrenamiento.SelectedValue.ToString & "' and Fecha_realizada between '" & fecha_inicial & "' and '" & fecha_final & "';"), conn)
                numero_entrenamientos = Convert.ToString(cmd.ExecuteScalar())
                LblNEntrenamientos.Text = numero_entrenamientos
                LblNumeroEntrenamientos.Visible = True
                LblNEntrenamientos.Visible = True
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            Try
                Dim cmd As New MySqlCommand("Select Pruebas.Nombre as 'Prueba', u1.Nombre as 'Nombre', Fecha_Realizada, fecha_Siguiente, entrenador
                                            from usuarios as u1 inner join rel_prueba_usuarios on u1.UsuarioID = rel_prueba_usuarios.UsuarioID
                                            inner join pruebas on pruebas.pruebaId = rel_prueba_usuarios.PruebaID
                                            where pruebas.pruebaid = '" & CmbBxCodigoEntrenamiento.SelectedValue.ToString & "' and Fecha_realizada between'" & fecha_inicial & "' and '" & fecha_final & "'
                                            order by pruebas.nombre, u1.nombre;;", conn)
                conn.Open()
                Console.WriteLine("Entrenamientos entre fechas")

                reader = cmd.ExecuteReader()

                Dim table As New DataTable
                table.Load(reader)
                DGVEntrenamientos.DataSource = table
                DGVEntrenamientos.ReadOnly = True
                DGVEntrenamientos.AllowUserToResizeColumns = True
                DGVEntrenamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                reader.Close()
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                conn.Close()
            End Try

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        FechaInicio.Format = DateTimePickerFormat.Custom
        FechaInicio.CustomFormat = "yyyy-MM-dd"
        FechaInicio.Value = FechaInicio.MinDate
        FechaFin.Format = DateTimePickerFormat.Custom
        FechaFin.CustomFormat = "yyyy-MM-dd"
        Cargar_Codigos_Entrenamientos()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(String.Format("SELECT NOW();"), conn)
            Dim fecha_servidor As DateTime = cmd.ExecuteScalar()
            FechaFin.MaxDate = fecha_servidor.ToString("yyyy-MM-dd HH:mm:ss")
            FechaInicio.MaxDate = FechaFin.MaxDate
            FechaFin.Value = FechaFin.MaxDate
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, False, "No se puede obtener la fecha de la base de datos se tomara la hora local")
            conn.Close()
            FechaFin.MaxDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            FechaInicio.MaxDate = FechaFin.MaxDate
            FechaFin.Value = FechaFin.MaxDate
            Exit Sub
        End Try

    End Sub

    Private Sub Cargar_Codigos_Entrenamientos()
        CmbBxCodigoEntrenamiento.Items.Clear()
        CmbBxCodigoEntrenamiento.Enabled = True
        Dim query As String = " Select PruebaID from Pruebas
                                where activa = 1;"
        Dim cmd As New MySqlCommand(query, conn)
        Dim sqlAdap As New MySqlDataAdapter(cmd)
        Dim dtRecord As New DataTable
        sqlAdap.Fill(dtRecord)
        CmbBxCodigoEntrenamiento.DataSource = dtRecord
        CmbBxCodigoEntrenamiento.DisplayMember = "PruebaID"
        CmbBxCodigoEntrenamiento.ValueMember = "PruebaID"
        CmbBxCodigoEntrenamiento.Text = ""
        CmbBxCodigoEntrenamiento.SelectedValue = 0

    End Sub

    Public Sub Connect()
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("cs").ConnectionString
        Try
            conn.Open()
            Console.WriteLine("conectandose a la base de datos")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        CmbBxTablas.Items.Add("Usuarios")
        CmbBxTablas.Items.Add("Entrenamientos")
        CmbBxTablas.Items.Add("Cargos")
        CmbBxTablas.Items.Add("Entrenamientos por Cargo")
        CmbBxTablas.Items.Add("Cargos del usuario")
        CmbBxTablas.Items.Add("Tipos de Entrenamiento")
        CmbBxTablas.Items.Add("Historial de Entrenamientos")

        CmbBxTablas.SelectedItem = "Usuarios"

    End Sub

    Private Sub CmbBxTablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBxTablas.SelectedIndexChanged
        PanelAdmin.Visible = False
        CargarDGVAdmin()
    End Sub

    Public Sub CargarDGVAdmin()
        Dim nombre_tabla As String = CmbBxTablas.Text.ToString
        Dim query As String

        If nombre_tabla = "Usuarios" Then
            query = "Select UsuarioID, Nombre FROM usuarios
                    where Activo = 1
                    Order by Nombre;"
        ElseIf nombre_tabla = "Entrenamientos" Then
            query = "Select PruebaID, Nombre, Frecuencia from pruebas
                    where Activa = 1
                    order by pruebaID;"
        ElseIf nombre_tabla = "Cargos" Then
            query = "Select * from Cargos;"
        ElseIf nombre_tabla = "Entrenamientos por Cargo" Then
            query = "Select rel_cargos_pruebas.PruebaID , Cargos.Nombre as 'Cargo' , rel_cargos_pruebas.CargoNo
                    from rel_cargos_pruebas inner join Cargos on rel_cargos_pruebas.CargoNo = Cargos.CargoNo
                    Order by PruebaID;"
        ElseIf nombre_tabla = "Cargos del usuario" Then
            query = "Select Usuarios.Nombre as 'Usuario', Cargos.Nombre as 'Cargo',rel_cargos_usuarios.CargoNo,rel_cargos_usuarios.UsuarioID
                    from rel_cargos_usuarios inner join Usuarios on rel_cargos_usuarios.UsuarioID = usuarios.UsuarioID
                    inner join Cargos on rel_cargos_usuarios.CargoNo = Cargos.CargoNo
                    Order by Usuario;"
        ElseIf nombre_tabla = "Tipos de Entrenamiento" Then
            query = "SELECT * FROM tipo_pruebas;"
        ElseIf nombre_tabla = "Historial de Entrenamientos" Then
            query = "Select Pruebas.PruebaID as 'Codigo Prueba', Pruebas.Nombre as 'Prueba', u1.Nombre as 'Nombre', Fecha_Realizada as 'Fecha Realizada', fecha_Siguiente 'Proxima Fecha', Entrenador
                    from usuarios as u1 inner join rel_prueba_usuarios on u1.UsuarioID = rel_prueba_usuarios.UsuarioID
                    inner join pruebas on pruebas.pruebaId = rel_prueba_usuarios.PruebaID
                    Order By pruebas.nombre, u1.nombre"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader

        Try

            conn.Open()
            Console.WriteLine("conectandose a la base de datos")

            reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DGVAdmin.DataSource = table
            DGVAdmin.ReadOnly = True
            DGVAdmin.AllowUserToResizeColumns = True
            DGVAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conn.Close()
        End Try

        If nombre_tabla = "Usuarios" Then
            DGVAdmin.Columns(0).Visible = False
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Usuario"
            BtnModificarRegistro.Text = "Modificar Usuario"
            BtnEliminarRegistro.Text = "Desactivar Usuario"
            BtnNuevoRegistro.Enabled = True
            BtnModificarRegistro.Enabled = True
            BtnEliminarRegistro.Enabled = True
            BtnNuevoRegistro.Visible = True
            BtnModificarRegistro.Visible = True
            BtnEliminarRegistro.Visible = True
        ElseIf nombre_tabla = "Entrenamientos" Then
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Entrenamiento"
            BtnEliminarRegistro.Text = "Desactivar Entrenamiento"
            BtnNuevoRegistro.Enabled = True
            BtnModificarRegistro.Visible = False
            BtnEliminarRegistro.Visible = True
            BtnEliminarRegistro.Visible = True
        ElseIf nombre_tabla = "Cargos" Then
            DGVAdmin.Columns(0).Visible = False
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Cargo"
            BtnNuevoRegistro.Visible = True
            BtnModificarRegistro.Visible = False
            BtnEliminarRegistro.Visible = False
        ElseIf nombre_tabla = "Entrenamientos por Cargo" Then
            DGVAdmin.Columns(2).Visible = False
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Registro"
            BtnModificarRegistro.Text = "Modificar Registro"
            BtnEliminarRegistro.Text = "Eliminar Registro"
            BtnNuevoRegistro.Visible = True
            BtnModificarRegistro.Visible = False
            BtnEliminarRegistro.Visible = True
        ElseIf nombre_tabla = "Cargos del usuario" Then
            DGVAdmin.Columns(2).Visible = False
            DGVAdmin.Columns(3).Visible = False
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Registro"
            BtnModificarRegistro.Text = "Modificar Registro"
            BtnEliminarRegistro.Text = "Eliminar Registro"
            BtnNuevoRegistro.Visible = True
            BtnModificarRegistro.Visible = False
            BtnEliminarRegistro.Visible = True
        ElseIf nombre_tabla = "Tipos de Entrenamiento" Then
            GroupBoxControlesTablas.Visible = True
            BtnNuevoRegistro.Text = "Agregar Registro"
            BtnNuevoRegistro.Visible = True
            BtnModificarRegistro.Visible = False
            BtnEliminarRegistro.Visible = False
            BtnNuevoRegistro.Text = "Agregar Registro"
        ElseIf nombre_tabla = "Historial de Entrenamientos" Then
            GroupBoxControlesTablas.Visible = False
        End If

    End Sub

    Private Sub BtnNuevoRegistro_Click(sender As Object, e As EventArgs) Handles BtnNuevoRegistro.Click
        Dim nombre_tabla As String = CmbBxTablas.Text

        If nombre_tabla = "Usuarios" Then

        ElseIf nombre_tabla = "Entrenamientos" Then
            Label1.Text = "Codigo"
            Label2.Text = "Tipo de Entrenamiento"
            Label3.Text = "Frecuencia"
            Label4.Text = "Nombre"
            LlenarCmbBxTipoEntrenamiento()
            LlenarCmbBxFrecuencia()
            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            RichTextBox1.Visible = True
            CmbBxCargos.Visible = False
            CmbBxFrecuencia.Visible = True
            TxtBxCodigoEntrenamiento.Visible = True
            CmbBxPruebas.Visible = False
            CmbBxTipoEntrenamiento.Visible = True
            PanelAdmin.Visible = True
        ElseIf nombre_tabla = "Cargos" Then
            Label1.Text = "Nombre del Cargo"
            Label1.Visible = True
            TxtBxCodigoEntrenamiento.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            RichTextBox1.Visible = False
            CmbBxCargos.Visible = False
            CmbBxFrecuencia.Visible = False
            CmbBxPruebas.Visible = False
            CmbBxTipoEntrenamiento.Visible = False
            PanelAdmin.Visible = True

        ElseIf nombre_tabla = "Entrenamientos por Cargo" Then
            Label1.Text = "Entrenamiento"
            Label3.Text = "Cargo"
            CmbBxPruebas.Visible = True
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = True
            Label4.Visible = False
            Label5.Visible = False
            RichTextBox1.Visible = False
            CmbBxCargos.Visible = True
            CmbBxFrecuencia.Visible = False
            CmbBxTipoEntrenamiento.Visible = False
            TxtBxCodigoEntrenamiento.Visible = False
            LlenarCmbBxPruebas()
            LlenarCmbBxCargos()
            PanelAdmin.Visible = True
        ElseIf nombre_tabla = "Cargos del usuario" Then
            Label1.Text = "Usuario"
            Label3.Text = "Cargo"
            CmbBxPruebas.Visible = True
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = True
            Label4.Visible = False
            Label5.Visible = False
            RichTextBox1.Visible = False
            CmbBxCargos.Visible = True
            CmbBxFrecuencia.Visible = False
            CmbBxTipoEntrenamiento.Visible = False
            TxtBxCodigoEntrenamiento.Visible = False
            LlenarCmbBxUsuarios()
            LlenarCmbBxCargos()
            PanelAdmin.Visible = True
        ElseIf nombre_tabla = "Tipos de Entrenamiento" Then
            Label1.Text = "Nuevo Tipo de Entrenamiento"
            Label1.Visible = True
            TxtBxCodigoEntrenamiento.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            RichTextBox1.Visible = False
            CmbBxCargos.Visible = False
            CmbBxFrecuencia.Visible = False
            CmbBxPruebas.Visible = False
            CmbBxTipoEntrenamiento.Visible = False
            PanelAdmin.Visible = True
        End If
    End Sub

    Public Sub LlenarCmbBxUsuarios()
        CmbBxPruebas.Items.Clear()
        CmbBxPruebas.Enabled = True
        Dim query As String = " Select UsuarioID, Nombre from Usuarios
                                where activo = 1;"
        Dim cmd As New MySqlCommand(query, conn)
        Dim sqlAdap As New MySqlDataAdapter(cmd)
        Dim dtRecord As New DataTable
        sqlAdap.Fill(dtRecord)
        CmbBxPruebas.DataSource = dtRecord
        CmbBxPruebas.DisplayMember = "Nombre"
        CmbBxPruebas.ValueMember = "UsuarioID"
        CmbBxPruebas.Text = ""
        CmbBxPruebas.SelectedValue = 0
    End Sub

    Public Sub LlenarCmbBxPruebas()
        CmbBxPruebas.Items.Clear()
        CmbBxPruebas.Enabled = True
        Dim query As String = " Select PruebaID from Pruebas
                                where activa = 1;"
        Dim cmd As New MySqlCommand(query, conn)
        Dim sqlAdap As New MySqlDataAdapter(cmd)
        Dim dtRecord As New DataTable
        sqlAdap.Fill(dtRecord)
        CmbBxPruebas.DataSource = dtRecord
        CmbBxPruebas.DisplayMember = "PruebaID"
        CmbBxPruebas.ValueMember = "PruebaID"
        CmbBxPruebas.Text = ""
        CmbBxPruebas.SelectedValue = 0
    End Sub

    Public Sub LlenarCmbBxCargos()
        CmbBxCargos.Items.Clear()
        CmbBxCargos.Enabled = True
        Dim query As String = " Select CargoNo, Nombre from Cargos;"
        Dim cmd As New MySqlCommand(query, conn)
        Dim sqlAdap As New MySqlDataAdapter(cmd)
        Dim dtRecord As New DataTable
        sqlAdap.Fill(dtRecord)
        CmbBxCargos.DataSource = dtRecord
        CmbBxCargos.DisplayMember = "Nombre"
        CmbBxCargos.ValueMember = "CargoNo"
        CmbBxCargos.Text = ""
        CmbBxCargos.SelectedValue = 0
    End Sub

    Public Sub LlenarCmbBxTipoEntrenamiento()
        CmbBxTipoEntrenamiento.Items.Clear()
        CmbBxTipoEntrenamiento.Enabled = True
        Dim query As String = " Select TipoPruebaID, Nombre from tipo_pruebas;"
        Dim cmd As New MySqlCommand(query, conn)
        Dim sqlAdap As New MySqlDataAdapter(cmd)
        Dim dtRecord As New DataTable
        sqlAdap.Fill(dtRecord)
        CmbBxTipoEntrenamiento.DataSource = dtRecord
        CmbBxTipoEntrenamiento.DisplayMember = "Nombre"
        CmbBxTipoEntrenamiento.ValueMember = "TipoPruebaID"
    End Sub

    Public Sub LlenarCmbBxFrecuencia()
        CmbBxFrecuencia.Items.Add("1 YEAR")
        CmbBxFrecuencia.Items.Add("2 YEAR")
        CmbBxFrecuencia.Items.Add("3 YEAR")
        CmbBxFrecuencia.Items.Add("4 YEAR")
        CmbBxFrecuencia.SelectedIndex = 0
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim nombre_tabla As String = CmbBxTablas.Text

        If nombre_tabla = "Usuarios" Then

        ElseIf nombre_tabla = "Entrenamientos" Then
            Dim codigo_entrenamiento As String = TxtBxCodigoEntrenamiento.Text
            Dim tipo_entrenamiento As String = CmbBxTipoEntrenamiento.SelectedValue
            Dim frecuencia As String = CmbBxFrecuencia.Text
            Dim Nombre As String = RichTextBox1.Text

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO pruebas (`PruebaID`, `TipoPruebaID`, `Nombre`, `Descripcion`, `Frecuencia`, `Activa`) VALUES ('" & codigo_entrenamiento & "', '" & tipo_entrenamiento & "', '" & Nombre & "', '" & Nombre & "', '" & frecuencia & "', '1');"), conn)
                cmd.ExecuteNonQuery()
                MsgBox("Entrenamiento Agregado Satisfactoriamente", False, "Entrenamiento Creado")
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            CargarDGVAdmin()

        ElseIf nombre_tabla = "Cargos" Then
            Dim llave As String
            Dim Cargo As String = TxtBxCodigoEntrenamiento.Text

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT MAX(CargoNo)+1 FROM Cargos;"), conn)
                llave = Convert.ToString(cmd.ExecuteScalar())
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO Cargos VALUES ('" & llave & "', '" & Cargo & "');"), conn)
                cmd.ExecuteNonQuery()
                MsgBox("Cargo Agregado Satisfactoriamente", False, "Cargo Creado")
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            CargarDGVAdmin()


        ElseIf nombre_tabla = "Entrenamientos por Cargo" Then

            Dim pruebaID As String = CmbBxPruebas.SelectedValue.ToString
            Dim Cargo As String = CmbBxCargos.SelectedValue.ToString

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO rel_cargos_pruebas VALUES ('" & pruebaID & "', '" & Cargo & "');"), conn)
                Console.WriteLine(cmd)
                cmd.ExecuteNonQuery()
                MsgBox("Registro Agregado Satisfactoriamente", False, "Registro Agregado")
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            CargarDGVAdmin()

        ElseIf nombre_tabla = "Tipos de Entrenamiento" Then

            Dim llave As String
            Dim TEntrenamiento As String = TxtBxCodigoEntrenamiento.Text

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT MAX(TipoPruebaID)+1 FROM tipo_pruebas;"), conn)
                llave = Convert.ToString(cmd.ExecuteScalar())
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO tipo_pruebas VALUES ('" & llave & "', '" & TEntrenamiento & "');"), conn)
                cmd.ExecuteNonQuery()
                MsgBox("Tipo de Entrenamiento Agregado Satisfactoriamente", False, "Tipo de Entrenamiento Creado")
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            CargarDGVAdmin()

        ElseIf nombre_tabla = "Cargos del usuario" Then
            Dim UsuarioID As String = CmbBxPruebas.SelectedValue.ToString
            Dim Cargo As String = CmbBxCargos.SelectedValue.ToString

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO rel_cargos_usuarios VALUES ('" & Cargo & "', '" & UsuarioID & "');"), conn)
                Console.WriteLine(cmd)
                cmd.ExecuteNonQuery()
                MsgBox("Registro Agregado Satisfactoriamente", False, "Registro Agregado")
            Catch ex As MySqlException
                MsgBox(ex.Message, False, "Error")
                conn.Close()
                Exit Sub
            End Try
            conn.Close()
            CargarDGVAdmin()
        End If
    End Sub

    Private Sub BtnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles BtnEliminarRegistro.Click
        If MessageBox.Show("Desea eliminar/deshabilitar el registro seleccionado ?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim reader As MySqlDataReader
            Dim Fila_actual_obj As Object = (DGVAdmin.CurrentRow)
            If IsNothing(Fila_actual_obj) Then
                MsgBox("Seleccione una fila a eliminar")
                Exit Sub
            End If

            Dim nombre_tabla As String = CmbBxTablas.Text

            If nombre_tabla = "Usuarios" Then
                Dim fila_actual As Integer = DGVAdmin.CurrentRow.Index
                Dim llave As String = DGVAdmin(0, (fila_actual)).Value
                Try
                    conn.Open()
                    Dim query As String = "UPDATE usuarios SET Activo = '0' WHERE UsuarioID ='" & llave & "';"
                    Dim cmd As New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    MsgBox("El usuario ha sido deshabilitado", False, "Usuario Deshabilitado")
                    conn.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            ElseIf nombre_tabla = "Entrenamientos" Then
                Dim fila_actual As Integer = DGVAdmin.CurrentRow.Index
                Dim llave As String = DGVAdmin(0, (fila_actual)).Value
                Try
                    conn.Open()
                    Dim query As String = "UPDATE pruebas SET Activa = '0' WHERE PruebaID ='" & llave & "';"
                    Dim cmd As New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    MsgBox("El entrenamiento ha sido deshabilitado", False, "entrenamiento Deshabilitado")
                    conn.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            ElseIf nombre_tabla = "Entrenamientos por Cargo" Then
                Dim fila_actual As Integer = DGVAdmin.CurrentRow.Index
                Dim llave As String = DGVAdmin(0, (fila_actual)).Value
                Dim llave2 As String = DGVAdmin(2, (fila_actual)).Value
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM `bd_entrenamiento`.`rel_cargos_pruebas` WHERE `PruebaID`='" & llave & "' and`CargoNo`='" & llave2 & "';;"
                    Dim cmd As New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    MsgBox("Registro Eliminado", False, "Registro Eliminado")
                    conn.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            ElseIf nombre_tabla = "Cargos del usuario" Then
                Dim fila_actual As Integer = DGVAdmin.CurrentRow.Index
                Dim llave As String = DGVAdmin(2, (fila_actual)).Value 'cargo
                Dim llave2 As String = DGVAdmin(3, (fila_actual)).Value 'usuario
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM `bd_entrenamiento`.`rel_cargos_usuarios` WHERE `UsuarioID`='" & llave2 & "' and`CargoNo`='" & llave & "';;"
                    Dim cmd As New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    MsgBox("Registro Eliminado", False, "Registro Eliminado")
                    conn.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
            End If
            CargarDGVAdmin()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim i As Integer = RichTextBox1.Text.Length
        Label5.Text = i.ToString + "/150"
        If i > 130 Then
            Label5.ForeColor = Color.Red
        Else
            Label5.ForeColor = Color.Black
        End If
    End Sub
End Class
