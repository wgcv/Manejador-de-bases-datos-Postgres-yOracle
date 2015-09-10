Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class Form1
    Public conexion As New Odbc.OdbcConnection
    Dim base As New Integer
    Dim user As New usuario
    Public Function conectarse()

        Dim Login As New Login
        Login.ShowDialog()
        user = Login.coneccion()
        conexion.ConnectionString = user.cadena

        base = Login.base()
        Login = Nothing
        'Un cambio de estado para decir q esta conectado
        '      If MyCon.State = ConnectionState.Open Then
        ' MsgBox("sdf", MsgBoxStyle.MsgBoxSetForeground)
        ' End If
        If (base = 2) Then
            txtUsuario.Visible = True
        Else
            txtUsuario.Visible = False
        End If
        cargarbases()
    End Function
    Public Function grvselect(Tabla As String)
        Dim adpt As OdbcDataAdapter

        conexion.Open()
        Dim query = "select * from """ + Tabla + """"
        Dim ds As DataSet
        adpt = New OdbcDataAdapter(query, conexion)
        ds = New DataSet
        Try
            adpt.Fill(ds, "prueba")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "prueba"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        conexion.Close()
    End Function

    Public Function gencodigo2(obj As String)
        Dim Command As OdbcCommand

        Command = New OdbcCommand("Select Text from user_views where view_NAME = '" + obj + "'", conexion)


        conexion.Open()
        TextBox1.Text = ""
        Try
            Dim Reader As OdbcDataReader = Command.ExecuteReader()
            While Reader.Read()
                TextBox1.Text += Reader(0) & vbCrLf
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()
    End Function
    Public Function gencodigo(obj As String)
        Dim Command As OdbcCommand

        Command = New OdbcCommand("SELECT TEXT FROM all_source where NAME = '" + obj + "' ORDER BY Line", conexion)


        conexion.Open()
        TextBox1.Text = ""
        Try
            Dim Reader As OdbcDataReader = Command.ExecuteReader()
            While Reader.Read()
                TextBox1.Text += Reader(0) & vbCrLf
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conexion.Close()
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectarse()
    End Sub

    Public Function AgregarListbox(sql As String, obj As ListBox)
        Dim Command As OdbcCommand
        Command = New OdbcCommand(sql, conexion)
        If Command IsNot Nothing Then

            conexion.Open()

            Dim Reader As OdbcDataReader = Command.ExecuteReader()
            obj.Items.Clear()
            While Reader.Read()
                obj.Items.Add(Reader(0))
            End While
            conexion.Close()
        End If

    End Function
    Public Function AgregarListbox2(sql As String, obj As ListBox)
        Dim Command As OdbcCommand
        Command = New OdbcCommand(sql, conexion)
        Try


            If Command IsNot Nothing Then

                conexion.Open()

                Dim Reader As OdbcDataReader = Command.ExecuteReader()
                obj.Items.Clear()
                While Reader.Read()
                    obj.Items.Add(Reader(0) + " - " + Reader(1))
                End While
                conexion.Close()
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function cargarbases()

        Dim Command As OdbcCommand
        If (base = 1) Then
            Command = New OdbcCommand("Select datname FROM pg_database;”, conexion)


            conexion.Open()

            Dim Reader As OdbcDataReader = Command.ExecuteReader()
            Bases.Items.Clear()
            While Reader.Read()
                Bases.Items.Add(Reader(0))
            End While
            conexion.Close()
        End If
    End Function

    Private Sub TiposObjetos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TiposObjetos.SelectedIndexChanged
        If (TiposObjetos.SelectedIndex = 0) Then
            If (base = 1) Then
                AgregarListbox("Select datname FROM pg_database;”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("Select username from ALL_USERS”, Objetos)

            End If

        End If
        If (TiposObjetos.SelectedIndex = 1) Then
            If (base = 1) Then
                AgregarListbox("Select table_name FROM information_schema.tables ”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("Select  table_name  FROM user_tables”, Objetos)

            End If
        End If

        If (TiposObjetos.SelectedIndex = 2) Then
            If (base = 1) Then
                AgregarListbox("Select table_name FROM information_schema.views”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("Select  view_name  FROM user_views”, Objetos)

            End If
        End If
        If (TiposObjetos.SelectedIndex = 3) Then
            If (base = 1) Then
                AgregarListbox("Select DISTINCT trigger_name FROM information_schema.triggers”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("SELECT object_NAME FROM user_PROCEDURES where object_type = 'TRIGGER'”, Objetos)

            End If

        End If
        If (TiposObjetos.SelectedIndex = 4) Then
            If (base = 1) Then
                AgregarListbox("Select routine_name FROM information_schema.routines where type_udt_name='void'”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("SELECT object_NAME FROM user_PROCEDURES where object_type = 'PROCEDURE'”, Objetos)

            End If
        End If
        If (TiposObjetos.SelectedIndex = 5) Then
            If (base = 1) Then
                AgregarListbox("SELECT routine_name FROM information_schema.routines where type_udt_name NOT IN('void')”, Objetos)

            End If
            If (base = 2) Then

                AgregarListbox("SELECT object_NAME FROM user_PROCEDURES where object_type = 'FUNCTION'”, Objetos)

            End If
        End If
        If (TiposObjetos.SelectedIndex = 6) Then
            If (base = 1) Then
                AgregarListbox("SELECT usename FROM pg_user;”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("select username from ALL_USERS”, Objetos)

            End If
        End If
        If (TiposObjetos.SelectedIndex = 7) Then
            If (base = 1) Then
                AgregarListbox("SELECT rolname FROM pg_roles;”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("select DISTINCT role from ROLE_SYS_PRIVS”, Objetos)

            End If
        End If
        If (TiposObjetos.SelectedIndex = 8) Then
            If (base = 1) Then
                AgregarListbox("SELECT relname FROM pg_class WHERE relkind = 'S' AND relnamespace IN ( SELECT oid FROM pg_namespace );”, Objetos)

            End If
            If (base = 2) Then
                AgregarListbox("SELECT * FROM  user_SEQUENCES”, Objetos)

            End If
        End If
        ObjetosDetalle.Visible = False
        DataGridView1.Visible = False
        TextBox1.Visible = False

    End Sub

    Private Sub Objetos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Objetos.SelectedIndexChanged

        Try


            If (TiposObjetos.SelectedIndex = 0) Then
                If (base = 1) Then
                    AgregarListbox("SELECT relname FROM pg_class ”, ObjetosDetalle)
                    ObjetosDetalle.Visible = True

                End If
                If (base = 2) Then
                    AgregarListbox("Select object_name From all_OBJECTS Where Owner ='" + Objetos.SelectedItem.ToString + "'", ObjetosDetalle)
                    ObjetosDetalle.Visible = True


                End If



            End If
            If (TiposObjetos.SelectedIndex = 1) Then
                If (base = 1) Then
                    AgregarListbox2("SELECT udt_name, column_name FROM information_schema.columns WHERE table_name = '” + Objetos.SelectedItem.ToString + "';", ObjetosDetalle)

                End If
                If (base = 2) Then
                    AgregarListbox2("SELECT DATA_TYPE, column_name FROM ALL_TAB_COLUMNS where table_name = '” + Objetos.SelectedItem.ToString + "'", ObjetosDetalle)

                End If
                grvselect(Objetos.SelectedItem.ToString)
                ObjetosDetalle.Visible = True
                DataGridView1.Visible = True


            End If
            If (TiposObjetos.SelectedIndex = 2) Then
                Try


                    If (base = 1) Then
                        AgregarListbox2("SELECT udt_name, column_name FROM information_schema.columns WHERE table_name = '” + Objetos.SelectedItem.ToString + "';", ObjetosDetalle)

                    End If
                    If (base = 2) Then

                        AgregarListbox2("SELECT DATA_TYPE, column_name FROM ALL_TAB_COLUMNS where table_name = '” + Objetos.SelectedItem.ToString + "'", ObjetosDetalle)

                    End If
                Catch ex As Exception

                End Try

                DataGridView1.Visible = False
                grvselect(Objetos.SelectedItem.ToString)
                ObjetosDetalle.Visible = True

                gencodigo2(Objetos.SelectedItem.ToString)

                TextBox1.Visible = True

            End If
            If (TiposObjetos.SelectedIndex = 4 Or TiposObjetos.SelectedIndex = 5) Then

                If (base = 2) Then
                    '''  AgregarListbox2("SELECT DATA_TYPE, column_name FROM ALL_TAB_COLUMNS where table_name = '” + Objetos.SelectedItem.ToString + "'", ObjetosDetalle)
                    gencodigo(Objetos.SelectedItem.ToString)
                    TextBox1.Visible = True
                End If



            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Bases.SelectedIndexChanged
        user.base = Bases.SelectedItem.ToString
        conexion.ConnectionString = user.cadena


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ObjetosDetalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjetosDetalle.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub SQL_Click(sender As Object, e As EventArgs) Handles SQL.Click
        TextBox1.Visible = True
        TextBox1.Text = ""
        exec.Visible = True
        Button2.Visible = True
        DataGridView1.Visible = False




    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adpt As OdbcDataAdapter

        conexion.Open()
        Dim query = TextBox1.Text
        Dim ds As DataSet
        adpt = New OdbcDataAdapter(query, conexion)
        ds = New DataSet
        Try
            adpt.Fill(ds, "prueba")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "prueba"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBox1.Visible = False
        exec.Visible = False
        Button2.Visible = False
        DataGridView1.Visible = True

        conexion.Close()
    End Sub

    Private Sub exec_Click(sender As Object, e As EventArgs) Handles exec.Click
        conexion.Open()

        Try


            Dim cmd As New OdbcCommand(TextBox1.Text, conexion)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Se modificaron " & i & " columnas")
            TextBox1.Visible = False
            exec.Visible = False
            Button2.Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        Usr.conexion = conexion
        Usr.Show()
    End Sub
End Class
