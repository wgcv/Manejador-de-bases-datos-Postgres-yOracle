Imports System.Data.Odbc
Imports System.Windows.Forms

Public Class Login
    Dim MyCon As New Odbc.OdbcConnection
    Dim cadena As Integer = 0
    Dim user As New usuario

    Public Function coneccion() As usuario
        Return user
    End Function
    Public Function base() As Integer
        Return cadena
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If (BaseDatos.SelectedIndex = 1) Then
            user.usuario(usuario.Text, contrasena.Text, direccion.Text, txtBase.Text, 1, txtport.Text)
            MyCon.ConnectionString = user.cadena
            '''database=wgcv;
            Try
                MyCon.Open()
                cadena = 1

            Catch ex As OdbcException
                MsgBox("Error al conectarse:  " + ex.Message, MsgBoxStyle.MsgBoxSetForeground)

            End Try
            If MyCon.State = ConnectionState.Open Then
                Me.Hide()
            End If
            MyCon.Close()

        End If

        If (BaseDatos.SelectedIndex = 0) Then
            user.usuario(usuario.Text, contrasena.Text, direccion.Text, txtBase.Text, 2, txtport.Text)
            MyCon.ConnectionString = user.cadena
            '''database=wgcv;
            Try
                MyCon.Open()
                cadena = 2

            Catch ex As Exception
                MsgBox("Error al conectarse: " + ex.Message, MsgBoxStyle.MsgBoxSetForeground)

            End Try
            If MyCon.State = ConnectionState.Open Then
                Me.Hide()
            End If
            MyCon.Close()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseDatos.SelectedIndex = 1
    End Sub

    Private Sub BaseDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaseDatos.SelectedIndexChanged
        If (BaseDatos.SelectedIndex = 0) Then
            txtBase.Text = "ORCL"
            txtport.Text = "1521"
        End If
        If (BaseDatos.SelectedIndex = 1) Then
            txtBase.Text = "postgres"
            txtport.Text = "5432"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtport.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
