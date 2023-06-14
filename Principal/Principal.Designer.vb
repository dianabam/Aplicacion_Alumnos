<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.ButtonRestaurar = New System.Windows.Forms.Button()
        Me.ButtonMaximizar = New System.Windows.Forms.Button()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonMaterias = New System.Windows.Forms.Button()
        Me.ButtonPromedio = New System.Windows.Forms.Button()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.ButtonAlumnos = New System.Windows.Forms.Button()
        Me.PaneLogo = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonRMaterias = New System.Windows.Forms.Button()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraDeTitulo.SuspendLayout()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenido.SuspendLayout()
        Me.PaneLogo.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraDeTitulo
        '
        Me.PanelBarraDeTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonRestaurar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonMaximizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.PictureBoxIcono)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonSalir)
        resources.ApplyResources(Me.PanelBarraDeTitulo, "PanelBarraDeTitulo")
        Me.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo"
        '
        'ButtonRestaurar
        '
        resources.ApplyResources(Me.ButtonRestaurar, "ButtonRestaurar")
        Me.ButtonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRestaurar.FlatAppearance.BorderSize = 0
        Me.ButtonRestaurar.Name = "ButtonRestaurar"
        Me.ButtonRestaurar.UseVisualStyleBackColor = True
        '
        'ButtonMaximizar
        '
        resources.ApplyResources(Me.ButtonMaximizar, "ButtonMaximizar")
        Me.ButtonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMaximizar.FlatAppearance.BorderSize = 0
        Me.ButtonMaximizar.Name = "ButtonMaximizar"
        Me.ButtonMaximizar.UseVisualStyleBackColor = True
        '
        'PictureBoxIcono
        '
        resources.ApplyResources(Me.PictureBoxIcono, "PictureBoxIcono")
        Me.PictureBoxIcono.Name = "PictureBoxIcono"
        Me.PictureBoxIcono.TabStop = False
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ButtonMinimizar, "ButtonMinimizar")
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        resources.ApplyResources(Me.ButtonSalir, "ButtonSalir")
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelContenido
        '
        Me.PanelContenido.Controls.Add(Me.LabelFecha)
        Me.PanelContenido.Controls.Add(Me.LabelHora)
        resources.ApplyResources(Me.PanelContenido, "PanelContenido")
        Me.PanelContenido.Name = "PanelContenido"
        '
        'LabelFecha
        '
        resources.ApplyResources(Me.LabelFecha, "LabelFecha")
        Me.LabelFecha.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelFecha.Name = "LabelFecha"
        '
        'LabelHora
        '
        resources.ApplyResources(Me.LabelHora, "LabelHora")
        Me.LabelHora.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelHora.Name = "LabelHora"
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 50
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 50
        '
        'ButtonInicio
        '
        resources.ApplyResources(Me.ButtonInicio, "ButtonInicio")
        Me.ButtonInicio.BackColor = System.Drawing.Color.Transparent
        Me.ButtonInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInicio.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonInicio.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.UseVisualStyleBackColor = False
        '
        'ButtonMaterias
        '
        resources.ApplyResources(Me.ButtonMaterias, "ButtonMaterias")
        Me.ButtonMaterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMaterias.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonMaterias.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonMaterias.Name = "ButtonMaterias"
        Me.ButtonMaterias.UseVisualStyleBackColor = True
        '
        'ButtonPromedio
        '
        resources.ApplyResources(Me.ButtonPromedio, "ButtonPromedio")
        Me.ButtonPromedio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPromedio.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonPromedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonPromedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonPromedio.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonPromedio.Name = "ButtonPromedio"
        Me.ButtonPromedio.UseVisualStyleBackColor = True
        '
        'LabelFacultad
        '
        resources.ApplyResources(Me.LabelFacultad, "LabelFacultad")
        Me.LabelFacultad.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFacultad.Name = "LabelFacultad"
        '
        'LabelCorreo
        '
        resources.ApplyResources(Me.LabelCorreo, "LabelCorreo")
        Me.LabelCorreo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCorreo.Name = "LabelCorreo"
        '
        'ButtonAlumnos
        '
        resources.ApplyResources(Me.ButtonAlumnos, "ButtonAlumnos")
        Me.ButtonAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonAlumnos.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonAlumnos.Name = "ButtonAlumnos"
        Me.ButtonAlumnos.UseVisualStyleBackColor = True
        '
        'PaneLogo
        '
        Me.PaneLogo.Controls.Add(Me.PictureBoxLogo)
        resources.ApplyResources(Me.PaneLogo, "PaneLogo")
        Me.PaneLogo.Name = "PaneLogo"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBoxLogo, "PictureBoxLogo")
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelMenu.Controls.Add(Me.ButtonRMaterias)
        Me.PanelMenu.Controls.Add(Me.PaneLogo)
        Me.PanelMenu.Controls.Add(Me.ButtonAlumnos)
        Me.PanelMenu.Controls.Add(Me.LabelUsuario)
        Me.PanelMenu.Controls.Add(Me.LabelCorreo)
        Me.PanelMenu.Controls.Add(Me.LabelFacultad)
        Me.PanelMenu.Controls.Add(Me.ButtonPromedio)
        Me.PanelMenu.Controls.Add(Me.ButtonMaterias)
        Me.PanelMenu.Controls.Add(Me.ButtonInicio)
        resources.ApplyResources(Me.PanelMenu, "PanelMenu")
        Me.PanelMenu.Name = "PanelMenu"
        '
        'ButtonRMaterias
        '
        resources.ApplyResources(Me.ButtonRMaterias, "ButtonRMaterias")
        Me.ButtonRMaterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRMaterias.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonRMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonRMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonRMaterias.ForeColor = System.Drawing.Color.DimGray
        Me.ButtonRMaterias.Name = "ButtonRMaterias"
        Me.ButtonRMaterias.UseVisualStyleBackColor = True
        '
        'LabelUsuario
        '
        resources.ApplyResources(Me.LabelUsuario, "LabelUsuario")
        Me.LabelUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.LabelUsuario.Name = "LabelUsuario"
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'Principal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        Me.PaneLogo.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents PictureBoxIcono As PictureBox
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents ButtonRestaurar As Button
    Friend WithEvents ButtonMaximizar As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents ButtonMaterias As Button
    Friend WithEvents ButtonPromedio As Button
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents ButtonAlumnos As Button
    Friend WithEvents PaneLogo As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents TimerHora As Timer
    Friend WithEvents ButtonRMaterias As Button
End Class
