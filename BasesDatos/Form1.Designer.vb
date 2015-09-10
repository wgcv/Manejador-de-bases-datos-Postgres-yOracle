<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TiposObjetos = New System.Windows.Forms.ListBox()
        Me.Objetos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.Button()
        Me.exec = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SQL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bases = New System.Windows.Forms.ComboBox()
        Me.ObjetosDetalle = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TiposObjetos
        '
        Me.TiposObjetos.FormattingEnabled = True
        Me.TiposObjetos.Items.AddRange(New Object() {"Bases Datos", "Tablas", "Vistas", "Disparadores", "Procedimientos", "Funciones", "Usuarios", "Roles", "Secuencia"})
        Me.TiposObjetos.Location = New System.Drawing.Point(12, 79)
        Me.TiposObjetos.Name = "TiposObjetos"
        Me.TiposObjetos.Size = New System.Drawing.Size(352, 147)
        Me.TiposObjetos.TabIndex = 0
        '
        'Objetos
        '
        Me.Objetos.FormattingEnabled = True
        Me.Objetos.Location = New System.Drawing.Point(370, 79)
        Me.Objetos.Name = "Objetos"
        Me.Objetos.Size = New System.Drawing.Size(352, 147)
        Me.Objetos.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Conectarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.exec)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.SQL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Bases)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 61)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barra Herramientas"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(168, 19)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(75, 23)
        Me.txtUsuario.TabIndex = 11
        Me.txtUsuario.Text = "Usuarios"
        Me.txtUsuario.UseVisualStyleBackColor = True
        '
        'exec
        '
        Me.exec.Location = New System.Drawing.Point(249, 19)
        Me.exec.Name = "exec"
        Me.exec.Size = New System.Drawing.Size(75, 23)
        Me.exec.TabIndex = 10
        Me.exec.Text = "Ejecutar"
        Me.exec.UseVisualStyleBackColor = True
        Me.exec.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'SQL
        '
        Me.SQL.Location = New System.Drawing.Point(87, 19)
        Me.SQL.Name = "SQL"
        Me.SQL.Size = New System.Drawing.Size(75, 23)
        Me.SQL.TabIndex = 5
        Me.SQL.Text = "SQL"
        Me.SQL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base de Datos"
        '
        'Bases
        '
        Me.Bases.FormattingEnabled = True
        Me.Bases.Location = New System.Drawing.Point(509, 19)
        Me.Bases.Name = "Bases"
        Me.Bases.Size = New System.Drawing.Size(121, 21)
        Me.Bases.TabIndex = 3
        '
        'ObjetosDetalle
        '
        Me.ObjetosDetalle.FormattingEnabled = True
        Me.ObjetosDetalle.Location = New System.Drawing.Point(728, 79)
        Me.ObjetosDetalle.Name = "ObjetosDetalle"
        Me.ObjetosDetalle.Size = New System.Drawing.Size(352, 147)
        Me.ObjetosDetalle.TabIndex = 5
        Me.ObjetosDetalle.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 239)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1068, 417)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1068, 405)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1096, 656)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ObjetosDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Objetos)
        Me.Controls.Add(Me.TiposObjetos)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Manejador de Base de Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TiposObjetos As ListBox
    Friend WithEvents Objetos As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ObjetosDetalle As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Bases As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SQL As Button
    Friend WithEvents exec As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtUsuario As Button
End Class
