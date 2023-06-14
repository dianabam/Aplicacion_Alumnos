<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recuperar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar))
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.Cbo_Usuarios = New System.Windows.Forms.ComboBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraDeTitulo.SuspendLayout()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraDeTitulo
        '
        Me.PanelBarraDeTitulo.Controls.Add(Me.PictureBoxIcono)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonSalir)
        Me.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraDeTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo"
        Me.PanelBarraDeTitulo.Size = New System.Drawing.Size(340, 35)
        Me.PanelBarraDeTitulo.TabIndex = 3
        '
        'PictureBoxIcono
        '
        Me.PictureBoxIcono.BackgroundImage = CType(resources.GetObject("PictureBoxIcono.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxIcono.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxIcono.Name = "PictureBoxIcono"
        Me.PictureBoxIcono.Size = New System.Drawing.Size(40, 35)
        Me.PictureBoxIcono.TabIndex = 5
        Me.PictureBoxIcono.TabStop = False
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.Location = New System.Drawing.Point(260, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 35)
        Me.ButtonMinimizar.TabIndex = 4
        Me.ButtonMinimizar.Text = "-"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Location = New System.Drawing.Point(300, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(40, 35)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelUsuarios.Location = New System.Drawing.Point(60, 264)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(61, 22)
        Me.LabelUsuarios.TabIndex = 7
        Me.LabelUsuarios.Text = "Usuarios"
        Me.LabelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo_Usuarios
        '
        Me.Cbo_Usuarios.BackColor = System.Drawing.Color.White
        Me.Cbo_Usuarios.FormattingEnabled = True
        Me.Cbo_Usuarios.Items.AddRange(New Object() {"Diana Gabriela", "Aria Grace", "Alondra"})
        Me.Cbo_Usuarios.Location = New System.Drawing.Point(60, 292)
        Me.Cbo_Usuarios.Name = "Cbo_Usuarios"
        Me.Cbo_Usuarios.Size = New System.Drawing.Size(220, 24)
        Me.Cbo_Usuarios.TabIndex = 6
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(60, 355)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.ReadOnly = True
        Me.TextBoxCorreo.Size = New System.Drawing.Size(220, 22)
        Me.TextBoxCorreo.TabIndex = 9
        Me.TextBoxCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelCorreo.Location = New System.Drawing.Point(60, 327)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(113, 22)
        Me.LabelCorreo.TabIndex = 10
        Me.LabelCorreo.Text = "Correo registrado"
        Me.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxLogo.Location = New System.Drawing.Point(95, 61)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(150, 130)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 11
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.Location = New System.Drawing.Point(80, 193)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(180, 25)
        Me.LabelTitulo.TabIndex = 12
        Me.LabelTitulo.Text = "Recuperar Contraseña"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 530)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(340, 60)
        Me.PanelInferior.TabIndex = 13
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Location = New System.Drawing.Point(210, 18)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonAceptar.TabIndex = 0
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 30
        '
        'Recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 590)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.Cbo_Usuarios)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recuperar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar_Cont"
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents PictureBoxIcono As PictureBox
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents Cbo_Usuarios As ComboBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents TimerAbrir As Timer
End Class
