<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.ProgressBarCargando = New System.Windows.Forms.ProgressBar()
        Me.LabelCargando = New System.Windows.Forms.Label()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("Oswald", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelTitulo.Location = New System.Drawing.Point(262, 127)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(188, 49)
        Me.LabelTitulo.TabIndex = 1
        Me.LabelTitulo.Text = "¡Bienvenido!"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCorreo.Location = New System.Drawing.Point(295, 240)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(47, 22)
        Me.LabelCorreo.TabIndex = 4
        Me.LabelCorreo.Text = "Correr"
        Me.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBarCargando
        '
        Me.ProgressBarCargando.ForeColor = System.Drawing.Color.Gray
        Me.ProgressBarCargando.Location = New System.Drawing.Point(202, 189)
        Me.ProgressBarCargando.Name = "ProgressBarCargando"
        Me.ProgressBarCargando.Size = New System.Drawing.Size(300, 15)
        Me.ProgressBarCargando.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarCargando.TabIndex = 5
        Me.ProgressBarCargando.Value = 50
        '
        'LabelCargando
        '
        Me.LabelCargando.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCargando.AutoSize = True
        Me.LabelCargando.Font = New System.Drawing.Font("Oswald", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCargando.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelCargando.Location = New System.Drawing.Point(469, 188)
        Me.LabelCargando.Name = "LabelCargando"
        Me.LabelCargando.Size = New System.Drawing.Size(18, 21)
        Me.LabelCargando.TabIndex = 6
        Me.LabelCargando.Text = "C"
        Me.LabelCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 30
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 30
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.Location = New System.Drawing.Point(295, 212)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(56, 22)
        Me.LabelNombre.TabIndex = 12
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelCargando)
        Me.Controls.Add(Me.ProgressBarCargando)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents ProgressBarCargando As ProgressBar
    Friend WithEvents LabelCargando As Label
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents LabelNombre As Label
End Class
