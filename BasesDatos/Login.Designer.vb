<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BaseDatos = New System.Windows.Forms.ComboBox()
        Me.contrasena = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtport = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(281, 200)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(283, 77)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(121, 20)
        Me.direccion.TabIndex = 23
        Me.direccion.Text = "localhost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Direccion"
        '
        'BaseDatos
        '
        Me.BaseDatos.FormattingEnabled = True
        Me.BaseDatos.Items.AddRange(New Object() {"Oracle", "PostgreSQL"})
        Me.BaseDatos.Location = New System.Drawing.Point(281, 156)
        Me.BaseDatos.Name = "BaseDatos"
        Me.BaseDatos.Size = New System.Drawing.Size(121, 21)
        Me.BaseDatos.TabIndex = 26
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(283, 50)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contrasena.Size = New System.Drawing.Size(121, 20)
        Me.contrasena.TabIndex = 22
        Me.contrasena.Text = "wg2344319cv!"
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(283, 22)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(121, 20)
        Me.usuario.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Motor de Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Base de Datos"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(281, 129)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(121, 20)
        Me.txtBase.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BasesDatos.My.Resources.Resources.locked59
        Me.PictureBox1.Location = New System.Drawing.Point(34, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Puerto"
        '
        'txtport
        '
        Me.txtport.Location = New System.Drawing.Point(283, 103)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(119, 20)
        Me.txtport.TabIndex = 31
        '
        'Login
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(439, 241)
        Me.Controls.Add(Me.txtport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BaseDatos)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BaseDatos As ComboBox
    Friend WithEvents contrasena As TextBox
    Friend WithEvents usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtport As TextBox
End Class
