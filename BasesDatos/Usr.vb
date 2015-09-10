Imports System.Data.Odbc

Public Class Usr
    Public conexion As New Odbc.OdbcConnection

    Private Sub btn_crear_user_Click(sender As Object, e As EventArgs) Handles btn_crear_user.Click
        conexion.Open()
        Dim Sql = "create user  " + txt_nombre_user.Text + " identified by " + txt_contraseña.Text + ""

        Try


            Dim cmd As New OdbcCommand(Sql, conexion)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Se creo usuario")


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub

    Private Sub Usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim Command As OdbcCommand
            ''''select role as name from dba_roles union all select username from dba_users where username not in('QS_CB','PERFSTAT','QS_ADM','PM','SH','HR','OE','ODM_MTR','WKPROXY','ANONYMOUS','OWNER','SYS','SYSTEM','SCOTT','SYSMAN','XDB','DBSNMP','EXFSYS','OLAPSYS','MDSYS','WMSYS','WKSYS','DMSYS','ODM','EXFSYS','CTXSYS','LBACSYS','ORDPLUGINS','SQLTXPLAIN','OUTLN','TSMSYS','XS$NULL','TOAD','STREAM','SPATIAL_CSW_ADMIN','SPATIAL_WFS_ADMIN','SI_INFORMTN_SCHEMA','QS','QS_CBADM','QS_CS','QS_ES','QS_OS','QS_WS','PA_AWR_USER','OWBSYS_AUDIT','OWBSYS','ORDSYS','ORDDATA','ORACLE_OCM','MGMT_VIEW','MDDATA','FLOWS_FILES','FLASHBACK','AWRUSER','APPQOSSYS','APEX_PUBLIC_USER','APEX_030200')");


            Command = New OdbcCommand("select username from dba_users where username not in('QS_CB','PERFSTAT','QS_ADM','PM','SH','HR','OE','ODM_MTR','WKPROXY','ANONYMOUS','OWNER','SYS','SYSTEM','SCOTT','SYSMAN','XDB','DBSNMP','EXFSYS','OLAPSYS','MDSYS','WMSYS','WKSYS','DMSYS','ODM','EXFSYS','CTXSYS','LBACSYS','ORDPLUGINS','SQLTXPLAIN','OUTLN','TSMSYS','XS$NULL','TOAD','STREAM','SPATIAL_CSW_ADMIN','SPATIAL_WFS_ADMIN','SI_INFORMTN_SCHEMA','QS','QS_CBADM','QS_CS','QS_ES','QS_OS','QS_WS','PA_AWR_USER','OWBSYS_AUDIT','OWBSYS','ORDSYS','ORDDATA','ORACLE_OCM','MGMT_VIEW','MDDATA','FLOWS_FILES','FLASHBACK','AWRUSER','APPQOSSYS','APEX_PUBLIC_USER','APEX_030200')”, conexion)


            conexion.Open()

            Dim Reader1 As OdbcDataReader = Command.ExecuteReader()
            cbx_solo_user.Items.Clear()
            While Reader1.Read()
                cbx_solo_user.Items.Add(Reader1(0))
            End While
            conexion.Close()
            Command = New OdbcCommand("select role from dba_roles”, conexion)


            conexion.Open()

            Dim Reader = Command.ExecuteReader()
            cbx_rol.Items.Clear()
            While Reader.Read()
                cbx_rol.Items.Add(Reader(0))
            End While
            conexion.Close()

            Command = New OdbcCommand("select username from dba_users where username not in('QS_CB','PERFSTAT','QS_ADM','PM','SH','HR','OE','ODM_MTR','WKPROXY','ANONYMOUS','OWNER','SYS','SYSTEM','SCOTT','SYSMAN','XDB','DBSNMP','EXFSYS','OLAPSYS','MDSYS','WMSYS','WKSYS','DMSYS','ODM','EXFSYS','CTXSYS','LBACSYS','ORDPLUGINS','SQLTXPLAIN','OUTLN','TSMSYS','XS$NULL','TOAD','STREAM','SPATIAL_CSW_ADMIN','SPATIAL_WFS_ADMIN','SI_INFORMTN_SCHEMA','QS','QS_CBADM','QS_CS','QS_ES','QS_OS','QS_WS','PA_AWR_USER','OWBSYS_AUDIT','OWBSYS','ORDSYS','ORDDATA','ORACLE_OCM','MGMT_VIEW','MDDATA','FLOWS_FILES','FLASHBACK','AWRUSER','APPQOSSYS','APEX_PUBLIC_USER','APEX_030200')”, conexion)


            conexion.Open()

            Dim Reader2 = Command.ExecuteReader()
            cbx_rol.Items.Clear()
            While Reader2.Read()
                cbx_usuarios_rol.Items.Add(Reader2(0))
            End While
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_crear_rol_Click(sender As Object, e As EventArgs) Handles btn_crear_rol.Click
        Dim Sql = "create role " + txt_nombre_rol.Text
        conexion.Open()

        Try


            Dim cmd As New OdbcCommand(Sql, conexion)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Se creo rol")


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub

    Private Sub panel4_Paint(sender As Object, e As PaintEventArgs) Handles panel4.Paint

    End Sub

    Private Sub btn_asigna_rol_Click(sender As Object, e As EventArgs) Handles btn_asigna_rol.Click
        Dim Sql = "grant " + cbx_rol.SelectedItem.ToString() + " to " + cbx_solo_user.SelectedItem.ToString()
        conexion.Open()

        Try


            Dim cmd As New OdbcCommand(Sql, conexion)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Se creo se asigno roll")


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub

    Private Sub btn_asignar_Click(sender As Object, e As EventArgs) Handles btn_asignar.Click
        Dim selecte = " grant select on " + txt_tabla.Text + " to " + cbx_usuarios_rol.SelectedItem.ToString()
        Dim insert = " grant insert on " + txt_tabla.Text + " to " + cbx_usuarios_rol.SelectedItem.ToString()
        Dim Update = " grant update on " + txt_tabla.Text + " to " + cbx_usuarios_rol.SelectedItem.ToString()
        Dim delete = " grant delete on " + txt_tabla.Text + " to " + cbx_usuarios_rol.SelectedItem.ToString()
        Dim crear_tabla = " grant create table to " + cbx_usuarios_rol.SelectedItem.ToString()
        Dim crear_synonym = " grant create synonym to " + cbx_usuarios_rol.SelectedItem.ToString()
        If (ck_lectura.Checked = False) Then selecte = ""
        If (ck_inserta.Checked = False) Then insert = ""
        If (ck_actualiza.Checked = False) Then Update = ""
        If (ck_elimina.Checked = False) Then delete = ""
        If (ck_crea_tabla.Checked = False) Then crear_tabla = ""
        If (ck_crea_sinonimo.Checked = False) Then crear_synonym = ""
        Dim Sql = selecte + insert + Update + delete + crear_tabla + crear_synonym
        conexion.Open()

        Try

            If (selecte IsNot "") Then
                Dim cmd As New OdbcCommand(selecte, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            If (insert IsNot "") Then
                Dim cmd As New OdbcCommand(insert, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            If (Update IsNot "") Then
                Dim cmd As New OdbcCommand(Update, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            If (delete IsNot "") Then
                Dim cmd As New OdbcCommand(delete, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            If (crear_tabla IsNot "") Then
                Dim cmd As New OdbcCommand(crear_tabla, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            If (crear_synonym IsNot "") Then
                Dim cmd As New OdbcCommand(crear_synonym, conexion)
                Dim i As Integer = cmd.ExecuteNonQuery()
            End If
            MsgBox("Se dio permisos")


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conexion.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class