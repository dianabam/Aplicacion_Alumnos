<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciar_Sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iniciar_Sesion))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Cbo_Usuarios = New System.Windows.Forms.ComboBox()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.LabelClave = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.ButtonOcultarC = New System.Windows.Forms.Button()
        Me.ButtonVerC = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabelRecuperar = New System.Windows.Forms.LinkLabel()
        Me.PanelBarraDeTitulo.SuspendLayout()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Oswald", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.Location = New System.Drawing.Point(80, 173)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(181, 41)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "Iniciar Sesion"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.ForeColor = System.Drawing.Color.Gray
        Me.LabelFacultad.Location = New System.Drawing.Point(31, 505)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(149, 22)
        Me.LabelFacultad.TabIndex = 1
        Me.LabelFacultad.Text = "Facultad de Informática"
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
        Me.PanelBarraDeTitulo.TabIndex = 2
        '
        'PictureBoxIcono
        '
        Me.PictureBoxIcono.BackgroundImage = CType(resources.GetObject("PictureBoxIcono.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxIcono.Location = New System.Drawing.Point(12, 5)
        Me.PictureBoxIcono.Name = "PictureBoxIcono"
        Me.PictureBoxIcono.Size = New System.Drawing.Size(20, 25)
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
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 530)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(340, 60)
        Me.PanelInferior.TabIndex = 3
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
        'Cbo_Usuarios
        '
        Me.Cbo_Usuarios.BackColor = System.Drawing.Color.White
        Me.Cbo_Usuarios.FormattingEnabled = True
        Me.Cbo_Usuarios.Items.AddRange(New Object() {"Diana Gabriela", "Aria Grace", "Alondra"})
        Me.Cbo_Usuarios.Location = New System.Drawing.Point(60, 281)
        Me.Cbo_Usuarios.Name = "Cbo_Usuarios"
        Me.Cbo_Usuarios.Size = New System.Drawing.Size(220, 24)
        Me.Cbo_Usuarios.TabIndex = 4
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelUsuarios.Location = New System.Drawing.Point(60, 253)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(70, 25)
        Me.LabelUsuarios.TabIndex = 5
        Me.LabelUsuarios.Text = "Usuarios"
        Me.LabelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClave
        '
        Me.LabelClave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClave.AutoSize = True
        Me.LabelClave.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClave.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelClave.Location = New System.Drawing.Point(60, 335)
        Me.LabelClave.Name = "LabelClave"
        Me.LabelClave.Size = New System.Drawing.Size(88, 25)
        Me.LabelClave.TabIndex = 6
        Me.LabelClave.Text = "Contraseña"
        Me.LabelClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtClave
        '
        Me.TxtClave.BackColor = System.Drawing.Color.White
        Me.TxtClave.Location = New System.Drawing.Point(60, 363)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(220, 22)
        Me.TxtClave.TabIndex = 7
        Me.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonOcultarC
        '
        Me.ButtonOcultarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOcultarC.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonOcultarC.FlatAppearance.BorderSize = 0
        Me.ButtonOcultarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonOcultarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonOcultarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOcultarC.Image = CType(resources.GetObject("ButtonOcultarC.Image"), System.Drawing.Image)
        Me.ButtonOcultarC.Location = New System.Drawing.Point(252, 363)
        Me.ButtonOcultarC.Name = "ButtonOcultarC"
        Me.ButtonOcultarC.Size = New System.Drawing.Size(28, 22)
        Me.ButtonOcultarC.TabIndex = 1
        Me.ButtonOcultarC.UseVisualStyleBackColor = True
        '
        'ButtonVerC
        '
        Me.ButtonVerC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVerC.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonVerC.FlatAppearance.BorderSize = 0
        Me.ButtonVerC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonVerC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonVerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVerC.Image = CType(resources.GetObject("ButtonVerC.Image"), System.Drawing.Image)
        Me.ButtonVerC.Location = New System.Drawing.Point(252, 363)
        Me.ButtonVerC.Name = "ButtonVerC"
        Me.ButtonVerC.Size = New System.Drawing.Size(28, 22)
        Me.ButtonVerC.TabIndex = 8
        Me.ButtonVerC.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(112, 82)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(115, 90)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 10
        Me.PictureBoxLogo.TabStop = False
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 30
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 30
        '
        'LinkLabelRecuperar
        '
        Me.LinkLabelRecuperar.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabelRecuperar.AutoSize = True
        Me.LinkLabelRecuperar.Font = New System.Drawing.Font("MS PGothic", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelRecuperar.LinkColor = System.Drawing.Color.DarkMagenta
        Me.LinkLabelRecuperar.Location = New System.Drawing.Point(85, 400)
        Me.LinkLabelRecuperar.Name = "LinkLabelRecuperar"
        Me.LinkLabelRecuperar.Size = New System.Drawing.Size(153, 14)
        Me.LinkLabelRecuperar.TabIndex = 11
        Me.LinkLabelRecuperar.TabStop = True
        Me.LinkLabelRecuperar.Text = "Olvidaste tu contraseña?"
        '
        'Iniciar_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(340, 590)
        Me.Controls.Add(Me.LinkLabelRecuperar)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.ButtonVerC)
        Me.Controls.Add(Me.ButtonOcultarC)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.LabelClave)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.Cbo_Usuarios)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Iniciar_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Cbo_Usuarios As ComboBox
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents LabelClave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents ButtonOcultarC As Button
    Friend WithEvents ButtonVerC As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PictureBoxIcono As PictureBox
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents LinkLabelRecuperar As LinkLabel
End Class
