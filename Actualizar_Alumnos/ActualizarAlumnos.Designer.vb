<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizarAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarAlumnos))
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.CboFacultad = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.CboGenero = New System.Windows.Forms.ComboBox()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.TxtExp = New System.Windows.Forms.TextBox()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.PanelInferior.SuspendLayout()
        Me.PanelBarraDeTitulo.SuspendLayout()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.ButtonActualizar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 315)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(590, 60)
        Me.PanelInferior.TabIndex = 6
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Location = New System.Drawing.Point(432, 18)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonActualizar.TabIndex = 0
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'PanelBarraDeTitulo
        '
        Me.PanelBarraDeTitulo.Controls.Add(Me.PictureBoxIcono)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.ButtonSalir)
        Me.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraDeTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo"
        Me.PanelBarraDeTitulo.Size = New System.Drawing.Size(590, 35)
        Me.PanelBarraDeTitulo.TabIndex = 5
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(510, 0)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(550, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(40, 35)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitulo.Location = New System.Drawing.Point(101, 54)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(383, 30)
        Me.LabelTitulo.TabIndex = 103
        Me.LabelTitulo.Text = "Actualizar registro Alumnos"
        '
        'CboSemestre
        '
        Me.CboSemestre.BackColor = System.Drawing.Color.White
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CboSemestre.Location = New System.Drawing.Point(316, 277)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(220, 24)
        Me.CboSemestre.TabIndex = 119
        '
        'LabelSemestre
        '
        Me.LabelSemestre.AutoSize = True
        Me.LabelSemestre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemestre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSemestre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSemestre.Location = New System.Drawing.Point(316, 257)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(76, 15)
        Me.LabelSemestre.TabIndex = 118
        Me.LabelSemestre.Text = "Semestre"
        '
        'CboFacultad
        '
        Me.CboFacultad.BackColor = System.Drawing.Color.White
        Me.CboFacultad.FormattingEnabled = True
        Me.CboFacultad.Items.AddRange(New Object() {"Informatica", "Ingenieria", "Contabilidad", "Ciencias Naturales", "Derecho"})
        Me.CboFacultad.Location = New System.Drawing.Point(316, 227)
        Me.CboFacultad.Name = "CboFacultad"
        Me.CboFacultad.Size = New System.Drawing.Size(220, 24)
        Me.CboFacultad.TabIndex = 117
        '
        'LabelFacultad
        '
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFacultad.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFacultad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFacultad.Location = New System.Drawing.Point(316, 207)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(68, 15)
        Me.LabelFacultad.TabIndex = 116
        Me.LabelFacultad.Text = "Facultad"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDireccion.ForeColor = System.Drawing.Color.DimGray
        Me.LabelDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDireccion.Location = New System.Drawing.Point(318, 157)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(77, 15)
        Me.LabelDireccion.TabIndex = 115
        Me.LabelDireccion.Text = "Direccion"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFecha.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFecha.Location = New System.Drawing.Point(61, 207)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(136, 15)
        Me.LabelFecha.TabIndex = 114
        Me.LabelFecha.Text = "Fecha nacimiento"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.White
        Me.TxtDireccion.Location = New System.Drawing.Point(318, 177)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(218, 22)
        Me.TxtDireccion.TabIndex = 113
        Me.TxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFecha
        '
        Me.TxtFecha.BackColor = System.Drawing.Color.White
        Me.TxtFecha.Location = New System.Drawing.Point(61, 227)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(218, 22)
        Me.TxtFecha.TabIndex = 112
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboGenero
        '
        Me.CboGenero.BackColor = System.Drawing.Color.White
        Me.CboGenero.FormattingEnabled = True
        Me.CboGenero.Items.AddRange(New Object() {"Mujer", "Hombre"})
        Me.CboGenero.Location = New System.Drawing.Point(59, 277)
        Me.CboGenero.Name = "CboGenero"
        Me.CboGenero.Size = New System.Drawing.Size(220, 24)
        Me.CboGenero.TabIndex = 111
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelExp.ForeColor = System.Drawing.Color.DimGray
        Me.LabelExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelExp.Location = New System.Drawing.Point(61, 105)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.Size = New System.Drawing.Size(86, 15)
        Me.LabelExp.TabIndex = 110
        Me.LabelExp.Text = "Expediente"
        '
        'TxtExp
        '
        Me.TxtExp.BackColor = System.Drawing.Color.White
        Me.TxtExp.Location = New System.Drawing.Point(61, 125)
        Me.TxtExp.Name = "TxtExp"
        Me.TxtExp.ReadOnly = True
        Me.TxtExp.Size = New System.Drawing.Size(218, 22)
        Me.TxtExp.TabIndex = 109
        Me.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGenero.ForeColor = System.Drawing.Color.DimGray
        Me.LabelGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelGenero.Location = New System.Drawing.Point(59, 257)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(60, 15)
        Me.LabelGenero.TabIndex = 108
        Me.LabelGenero.Text = "Genero"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelApellido.ForeColor = System.Drawing.Color.DimGray
        Me.LabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelApellido.Location = New System.Drawing.Point(318, 105)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(63, 15)
        Me.LabelApellido.TabIndex = 107
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(61, 155)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 106
        Me.LabelNombre.Text = "Nombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.White
        Me.TxtApellido.Location = New System.Drawing.Point(318, 125)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 22)
        Me.TxtApellido.TabIndex = 105
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(61, 175)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 22)
        Me.TxtNombre.TabIndex = 104
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActualizarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 375)
        Me.Controls.Add(Me.CboSemestre)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.CboFacultad)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.CboGenero)
        Me.Controls.Add(Me.LabelExp)
        Me.Controls.Add(Me.TxtExp)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarAlumnos"
        Me.Text = "ActualizarAlumnos"
        Me.PanelInferior.ResumeLayout(False)
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents PictureBoxIcono As PictureBox
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents CboSemestre As ComboBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents CboFacultad As ComboBox
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents CboGenero As ComboBox
    Friend WithEvents LabelExp As Label
    Friend WithEvents TxtExp As TextBox
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
End Class
