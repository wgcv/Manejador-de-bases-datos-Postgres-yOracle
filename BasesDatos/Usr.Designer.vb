<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.lbl_mensaje_asigna_rol = New System.Windows.Forms.Label()
        Me.btn_asigna_rol = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cbx_solo_user = New System.Windows.Forms.ComboBox()
        Me.cbx_rol = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.lbl_mensaje_rol = New System.Windows.Forms.Label()
        Me.btn_crear_rol = New System.Windows.Forms.Button()
        Me.txt_nombre_rol = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lbl_mensaje_crea_usuario = New System.Windows.Forms.Label()
        Me.btn_crear_user = New System.Windows.Forms.Button()
        Me.txt_nombre_user = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lbl_mensaje_permisos = New System.Windows.Forms.Label()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.cbx_usuarios_rol = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ck_crea_tabla = New System.Windows.Forms.CheckBox()
        Me.ck_crea_sinonimo = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tabla = New System.Windows.Forms.Label()
        Me.txt_tabla = New System.Windows.Forms.TextBox()
        Me.ck_lectura = New System.Windows.Forms.CheckBox()
        Me.ck_inserta = New System.Windows.Forms.CheckBox()
        Me.ck_actualiza = New System.Windows.Forms.CheckBox()
        Me.ck_elimina = New System.Windows.Forms.CheckBox()
        Me.panel4.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.Label8)
        Me.panel4.Controls.Add(Me.lbl_mensaje_asigna_rol)
        Me.panel4.Controls.Add(Me.btn_asigna_rol)
        Me.panel4.Controls.Add(Me.label9)
        Me.panel4.Controls.Add(Me.cbx_solo_user)
        Me.panel4.Controls.Add(Me.cbx_rol)
        Me.panel4.Controls.Add(Me.label7)
        Me.panel4.Location = New System.Drawing.Point(274, 182)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(403, 96)
        Me.panel4.TabIndex = 27
        '
        'lbl_mensaje_asigna_rol
        '
        Me.lbl_mensaje_asigna_rol.AutoSize = True
        Me.lbl_mensaje_asigna_rol.Location = New System.Drawing.Point(18, 59)
        Me.lbl_mensaje_asigna_rol.Name = "lbl_mensaje_asigna_rol"
        Me.lbl_mensaje_asigna_rol.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje_asigna_rol.TabIndex = 17
        '
        'btn_asigna_rol
        '
        Me.btn_asigna_rol.Location = New System.Drawing.Point(254, 59)
        Me.btn_asigna_rol.Name = "btn_asigna_rol"
        Me.btn_asigna_rol.Size = New System.Drawing.Size(75, 23)
        Me.btn_asigna_rol.TabIndex = 16
        Me.btn_asigna_rol.Text = "Asignar"
        Me.btn_asigna_rol.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(29, 53)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(43, 13)
        Me.label9.TabIndex = 15
        Me.label9.Text = "Usuario"
        '
        'cbx_solo_user
        '
        Me.cbx_solo_user.FormattingEnabled = True
        Me.cbx_solo_user.Location = New System.Drawing.Point(32, 29)
        Me.cbx_solo_user.Name = "cbx_solo_user"
        Me.cbx_solo_user.Size = New System.Drawing.Size(121, 21)
        Me.cbx_solo_user.TabIndex = 14
        '
        'cbx_rol
        '
        Me.cbx_rol.FormattingEnabled = True
        Me.cbx_rol.Location = New System.Drawing.Point(167, 27)
        Me.cbx_rol.Name = "cbx_rol"
        Me.cbx_rol.Size = New System.Drawing.Size(97, 21)
        Me.cbx_rol.TabIndex = 13
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(164, 53)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(23, 13)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Rol"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.lbl_mensaje_rol)
        Me.panel3.Controls.Add(Me.btn_crear_rol)
        Me.panel3.Controls.Add(Me.txt_nombre_rol)
        Me.panel3.Controls.Add(Me.label6)
        Me.panel3.Controls.Add(Me.label5)
        Me.panel3.Location = New System.Drawing.Point(12, 178)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(227, 100)
        Me.panel3.TabIndex = 26
        '
        'lbl_mensaje_rol
        '
        Me.lbl_mensaje_rol.AutoSize = True
        Me.lbl_mensaje_rol.Location = New System.Drawing.Point(99, 86)
        Me.lbl_mensaje_rol.Name = "lbl_mensaje_rol"
        Me.lbl_mensaje_rol.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje_rol.TabIndex = 4
        '
        'btn_crear_rol
        '
        Me.btn_crear_rol.Location = New System.Drawing.Point(105, 55)
        Me.btn_crear_rol.Name = "btn_crear_rol"
        Me.btn_crear_rol.Size = New System.Drawing.Size(95, 23)
        Me.btn_crear_rol.TabIndex = 3
        Me.btn_crear_rol.Text = "Crear"
        Me.btn_crear_rol.UseVisualStyleBackColor = True
        '
        'txt_nombre_rol
        '
        Me.txt_nombre_rol.Location = New System.Drawing.Point(97, 29)
        Me.txt_nombre_rol.Name = "txt_nombre_rol"
        Me.txt_nombre_rol.Size = New System.Drawing.Size(103, 20)
        Me.txt_nombre_rol.TabIndex = 2
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(18, 33)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(44, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "Nombre"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(115, 4)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(84, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Crear nuevo Rol"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.lbl_mensaje_crea_usuario)
        Me.panel2.Controls.Add(Me.btn_crear_user)
        Me.panel2.Controls.Add(Me.txt_nombre_user)
        Me.panel2.Controls.Add(Me.txt_contraseña)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Location = New System.Drawing.Point(12, 12)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(227, 164)
        Me.panel2.TabIndex = 25
        '
        'lbl_mensaje_crea_usuario
        '
        Me.lbl_mensaje_crea_usuario.AutoSize = True
        Me.lbl_mensaje_crea_usuario.Location = New System.Drawing.Point(99, 93)
        Me.lbl_mensaje_crea_usuario.Name = "lbl_mensaje_crea_usuario"
        Me.lbl_mensaje_crea_usuario.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje_crea_usuario.TabIndex = 18
        '
        'btn_crear_user
        '
        Me.btn_crear_user.Location = New System.Drawing.Point(105, 93)
        Me.btn_crear_user.Name = "btn_crear_user"
        Me.btn_crear_user.Size = New System.Drawing.Size(95, 23)
        Me.btn_crear_user.TabIndex = 17
        Me.btn_crear_user.Text = "Crear_usuario"
        Me.btn_crear_user.UseVisualStyleBackColor = True
        '
        'txt_nombre_user
        '
        Me.txt_nombre_user.Location = New System.Drawing.Point(97, 40)
        Me.txt_nombre_user.Name = "txt_nombre_user"
        Me.txt_nombre_user.Size = New System.Drawing.Size(103, 20)
        Me.txt_nombre_user.TabIndex = 16
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(97, 66)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(103, 20)
        Me.txt_contraseña.TabIndex = 13
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 69)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Contraseña"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(96, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Crear Usuario"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.GroupBox1)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.lbl_mensaje_permisos)
        Me.panel1.Controls.Add(Me.btn_asignar)
        Me.panel1.Controls.Add(Me.cbx_usuarios_rol)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.ck_crea_tabla)
        Me.panel1.Controls.Add(Me.ck_crea_sinonimo)
        Me.panel1.Location = New System.Drawing.Point(274, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(403, 164)
        Me.panel1.TabIndex = 24
        '
        'lbl_mensaje_permisos
        '
        Me.lbl_mensaje_permisos.AutoSize = True
        Me.lbl_mensaje_permisos.Location = New System.Drawing.Point(18, 47)
        Me.lbl_mensaje_permisos.Name = "lbl_mensaje_permisos"
        Me.lbl_mensaje_permisos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje_permisos.TabIndex = 17
        '
        'btn_asignar
        '
        Me.btn_asignar.Location = New System.Drawing.Point(126, 138)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(121, 23)
        Me.btn_asignar.TabIndex = 14
        Me.btn_asignar.Text = "Asignar"
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'cbx_usuarios_rol
        '
        Me.cbx_usuarios_rol.FormattingEnabled = True
        Me.cbx_usuarios_rol.Location = New System.Drawing.Point(49, 30)
        Me.cbx_usuarios_rol.Name = "cbx_usuarios_rol"
        Me.cbx_usuarios_rol.Size = New System.Drawing.Size(121, 21)
        Me.cbx_usuarios_rol.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(123, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Asignar permisos"
        '
        'ck_crea_tabla
        '
        Me.ck_crea_tabla.AutoSize = True
        Me.ck_crea_tabla.Location = New System.Drawing.Point(21, 65)
        Me.ck_crea_tabla.Name = "ck_crea_tabla"
        Me.ck_crea_tabla.Size = New System.Drawing.Size(86, 17)
        Me.ck_crea_tabla.TabIndex = 8
        Me.ck_crea_tabla.Text = "Crear Tablas"
        Me.ck_crea_tabla.UseVisualStyleBackColor = True
        '
        'ck_crea_sinonimo
        '
        Me.ck_crea_sinonimo.AutoSize = True
        Me.ck_crea_sinonimo.Location = New System.Drawing.Point(21, 93)
        Me.ck_crea_sinonimo.Name = "ck_crea_sinonimo"
        Me.ck_crea_sinonimo.Size = New System.Drawing.Size(102, 17)
        Me.ck_crea_sinonimo.TabIndex = 9
        Me.ck_crea_sinonimo.Text = "Crear Sinonimos"
        Me.ck_crea_sinonimo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Asignar Roles"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tabla)
        Me.GroupBox1.Controls.Add(Me.txt_tabla)
        Me.GroupBox1.Controls.Add(Me.ck_lectura)
        Me.GroupBox1.Controls.Add(Me.ck_inserta)
        Me.GroupBox1.Controls.Add(Me.ck_actualiza)
        Me.GroupBox1.Controls.Add(Me.ck_elimina)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permisos de Tabla"
        '
        'Tabla
        '
        Me.Tabla.AutoSize = True
        Me.Tabla.Location = New System.Drawing.Point(27, 20)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(34, 13)
        Me.Tabla.TabIndex = 22
        Me.Tabla.Text = "Tabla"
        '
        'txt_tabla
        '
        Me.txt_tabla.Location = New System.Drawing.Point(67, 17)
        Me.txt_tabla.Name = "txt_tabla"
        Me.txt_tabla.Size = New System.Drawing.Size(100, 20)
        Me.txt_tabla.TabIndex = 21
        '
        'ck_lectura
        '
        Me.ck_lectura.AutoSize = True
        Me.ck_lectura.Location = New System.Drawing.Point(15, 52)
        Me.ck_lectura.Name = "ck_lectura"
        Me.ck_lectura.Size = New System.Drawing.Size(62, 17)
        Me.ck_lectura.TabIndex = 17
        Me.ck_lectura.Text = "Lectura"
        Me.ck_lectura.UseVisualStyleBackColor = True
        '
        'ck_inserta
        '
        Me.ck_inserta.AutoSize = True
        Me.ck_inserta.Location = New System.Drawing.Point(15, 76)
        Me.ck_inserta.Name = "ck_inserta"
        Me.ck_inserta.Size = New System.Drawing.Size(69, 17)
        Me.ck_inserta.TabIndex = 18
        Me.ck_inserta.Text = "Insercion"
        Me.ck_inserta.UseVisualStyleBackColor = True
        '
        'ck_actualiza
        '
        Me.ck_actualiza.AutoSize = True
        Me.ck_actualiza.Location = New System.Drawing.Point(97, 52)
        Me.ck_actualiza.Name = "ck_actualiza"
        Me.ck_actualiza.Size = New System.Drawing.Size(89, 17)
        Me.ck_actualiza.TabIndex = 19
        Me.ck_actualiza.Text = "Actualizacion"
        Me.ck_actualiza.UseVisualStyleBackColor = True
        '
        'ck_elimina
        '
        Me.ck_elimina.AutoSize = True
        Me.ck_elimina.Location = New System.Drawing.Point(97, 75)
        Me.ck_elimina.Name = "ck_elimina"
        Me.ck_elimina.Size = New System.Drawing.Size(62, 17)
        Me.ck_elimina.TabIndex = 20
        Me.ck_elimina.Text = "Eliminar"
        Me.ck_elimina.UseVisualStyleBackColor = True
        '
        'Usr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 307)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Usr"
        Me.Text = "Control de usuarios"
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel4 As Panel
    Private WithEvents lbl_mensaje_asigna_rol As Label
    Private WithEvents btn_asigna_rol As Button
    Private WithEvents label9 As Label
    Private WithEvents cbx_solo_user As ComboBox
    Private WithEvents cbx_rol As ComboBox
    Private WithEvents label7 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents lbl_mensaje_rol As Label
    Private WithEvents btn_crear_rol As Button
    Private WithEvents txt_nombre_rol As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents lbl_mensaje_crea_usuario As Label
    Private WithEvents btn_crear_user As Button
    Private WithEvents txt_nombre_user As TextBox
    Private WithEvents txt_contraseña As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents lbl_mensaje_permisos As Label
    Private WithEvents btn_asignar As Button
    Private WithEvents cbx_usuarios_rol As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents ck_crea_tabla As CheckBox
    Private WithEvents ck_crea_sinonimo As CheckBox
    Private WithEvents Label8 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Tabla As Label
    Private WithEvents txt_tabla As TextBox
    Private WithEvents ck_lectura As CheckBox
    Private WithEvents ck_inserta As CheckBox
    Private WithEvents ck_actualiza As CheckBox
    Private WithEvents ck_elimina As CheckBox
End Class
