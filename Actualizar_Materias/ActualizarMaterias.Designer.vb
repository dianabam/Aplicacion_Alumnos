<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarMaterias))
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.LabelMaestro = New System.Windows.Forms.Label()
        Me.TxtMaestro = New System.Windows.Forms.TextBox()
        Me.LabelClave = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBarraDeTitulo.SuspendLayout()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.PanelBarraDeTitulo.Size = New System.Drawing.Size(590, 35)
        Me.PanelBarraDeTitulo.TabIndex = 3
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
        'PanelInferior
        '
        Me.PanelInferior.Controls.Add(Me.ButtonActualizar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 315)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(590, 60)
        Me.PanelInferior.TabIndex = 4
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
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.Color.White
        Me.TxtCorreo.Location = New System.Drawing.Point(304, 229)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(218, 22)
        Me.TxtCorreo.TabIndex = 89
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDescripcion.ForeColor = System.Drawing.Color.DimGray
        Me.LabelDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDescripcion.Location = New System.Drawing.Point(304, 153)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(93, 15)
        Me.LabelDescripcion.TabIndex = 88
        Me.LabelDescripcion.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.White
        Me.TxtDescripcion.Location = New System.Drawing.Point(304, 173)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(218, 22)
        Me.TxtDescripcion.TabIndex = 87
        Me.TxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboSemestre
        '
        Me.CboSemestre.BackColor = System.Drawing.Color.White
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CboSemestre.Location = New System.Drawing.Point(63, 171)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(220, 24)
        Me.CboSemestre.TabIndex = 86
        '
        'LabelSemestre
        '
        Me.LabelSemestre.AutoSize = True
        Me.LabelSemestre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemestre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSemestre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSemestre.Location = New System.Drawing.Point(63, 151)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(76, 15)
        Me.LabelSemestre.TabIndex = 85
        Me.LabelSemestre.Text = "Semestre"
        '
        'LabelMaestro
        '
        Me.LabelMaestro.AutoSize = True
        Me.LabelMaestro.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelMaestro.ForeColor = System.Drawing.Color.DimGray
        Me.LabelMaestro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelMaestro.Location = New System.Drawing.Point(58, 209)
        Me.LabelMaestro.Name = "LabelMaestro"
        Me.LabelMaestro.Size = New System.Drawing.Size(196, 15)
        Me.LabelMaestro.TabIndex = 84
        Me.LabelMaestro.Text = "Nombre Maestro Asignado"
        '
        'TxtMaestro
        '
        Me.TxtMaestro.BackColor = System.Drawing.Color.White
        Me.TxtMaestro.Location = New System.Drawing.Point(58, 229)
        Me.TxtMaestro.Name = "TxtMaestro"
        Me.TxtMaestro.Size = New System.Drawing.Size(218, 22)
        Me.TxtMaestro.TabIndex = 83
        Me.TxtMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelClave
        '
        Me.LabelClave.AutoSize = True
        Me.LabelClave.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelClave.ForeColor = System.Drawing.Color.DimGray
        Me.LabelClave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelClave.Location = New System.Drawing.Point(63, 98)
        Me.LabelClave.Name = "LabelClave"
        Me.LabelClave.Size = New System.Drawing.Size(129, 15)
        Me.LabelClave.TabIndex = 82
        Me.LabelClave.Text = "Clave de materia"
        '
        'TxtClave
        '
        Me.TxtClave.BackColor = System.Drawing.Color.White
        Me.TxtClave.Location = New System.Drawing.Point(63, 118)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.ReadOnly = True
        Me.TxtClave.Size = New System.Drawing.Size(218, 22)
        Me.TxtClave.TabIndex = 81
        Me.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCorreo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCorreo.Location = New System.Drawing.Point(304, 207)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(188, 15)
        Me.LabelCorreo.TabIndex = 80
        Me.LabelCorreo.Text = "Nombre Correo Asignado"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(304, 98)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 79
        Me.LabelNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(304, 118)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 22)
        Me.TxtNombre.TabIndex = 78
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitulo.Location = New System.Drawing.Point(185, 38)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(260, 30)
        Me.LabelTitulo.TabIndex = 90
        Me.LabelTitulo.Text = "Actualizar registro"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ActualizarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 76)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ActualizarMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(590, 375)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CboSemestre)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.LabelMaestro)
        Me.Controls.Add(Me.TxtMaestro)
        Me.Controls.Add(Me.LabelClave)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizarMaterias"
        Me.Text = "Actualizar"
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents PictureBoxIcono As PictureBox
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CboSemestre As ComboBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents LabelMaestro As Label
    Friend WithEvents TxtMaestro As TextBox
    Friend WithEvents LabelClave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
End Class
