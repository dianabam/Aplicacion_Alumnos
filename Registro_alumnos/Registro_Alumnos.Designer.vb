<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Alumnos
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
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Labeltotal = New System.Windows.Forms.Label()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.CboGenero = New System.Windows.Forms.ComboBox()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.TxtExp = New System.Windows.Forms.TextBox()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.CboFacultad = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelInferior.SuspendLayout()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitulo.Location = New System.Drawing.Point(132, 44)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(604, 30)
        Me.LabelTitulo.TabIndex = 10
        Me.LabelTitulo.Text = "REGISTRO DE ALUMNOS DESDE UNA DBA"
        '
        'PanelInferior
        '
        Me.PanelInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInferior.Controls.Add(Me.ButtonLimpiar)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Location = New System.Drawing.Point(0, 481)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 70)
        Me.PanelInferior.TabIndex = 19
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiar.Location = New System.Drawing.Point(519, 21)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistrar.Location = New System.Drawing.Point(635, 21)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonRegistrar.TabIndex = 0
        Me.ButtonRegistrar.Text = "Registrar"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(355, 111)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(218, 22)
        Me.TxtTotal.TabIndex = 34
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Labeltotal
        '
        Me.Labeltotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Labeltotal.AutoSize = True
        Me.Labeltotal.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Labeltotal.ForeColor = System.Drawing.Color.DimGray
        Me.Labeltotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Labeltotal.Location = New System.Drawing.Point(189, 114)
        Me.Labeltotal.Name = "Labeltotal"
        Me.Labeltotal.Size = New System.Drawing.Size(114, 15)
        Me.Labeltotal.TabIndex = 35
        Me.Labeltotal.Text = "Total registros"
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Location = New System.Drawing.Point(110, 343)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.ReadOnly = True
        Me.DataGridAlumnos.RowHeadersWidth = 51
        Me.DataGridAlumnos.RowTemplate.Height = 24
        Me.DataGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAlumnos.Size = New System.Drawing.Size(600, 117)
        Me.DataGridAlumnos.TabIndex = 36
        '
        'CboGenero
        '
        Me.CboGenero.BackColor = System.Drawing.Color.White
        Me.CboGenero.FormattingEnabled = True
        Me.CboGenero.Items.AddRange(New Object() {"Mujer", "Hombre"})
        Me.CboGenero.Location = New System.Drawing.Point(282, 184)
        Me.CboGenero.Name = "CboGenero"
        Me.CboGenero.Size = New System.Drawing.Size(220, 24)
        Me.CboGenero.TabIndex = 44
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelExp.ForeColor = System.Drawing.Color.DimGray
        Me.LabelExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelExp.Location = New System.Drawing.Point(45, 164)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.Size = New System.Drawing.Size(86, 15)
        Me.LabelExp.TabIndex = 43
        Me.LabelExp.Text = "Expediente"
        '
        'TxtExp
        '
        Me.TxtExp.BackColor = System.Drawing.Color.White
        Me.TxtExp.Location = New System.Drawing.Point(45, 184)
        Me.TxtExp.Name = "TxtExp"
        Me.TxtExp.Size = New System.Drawing.Size(218, 22)
        Me.TxtExp.TabIndex = 42
        Me.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGenero.ForeColor = System.Drawing.Color.DimGray
        Me.LabelGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelGenero.Location = New System.Drawing.Point(282, 164)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(60, 15)
        Me.LabelGenero.TabIndex = 41
        Me.LabelGenero.Text = "Genero"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelApellido.ForeColor = System.Drawing.Color.DimGray
        Me.LabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelApellido.Location = New System.Drawing.Point(279, 214)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(63, 15)
        Me.LabelApellido.TabIndex = 40
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(45, 214)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 39
        Me.LabelNombre.Text = "Nombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.White
        Me.TxtApellido.Location = New System.Drawing.Point(279, 234)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 22)
        Me.TxtApellido.TabIndex = 38
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(45, 234)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 22)
        Me.TxtNombre.TabIndex = 37
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDireccion.ForeColor = System.Drawing.Color.DimGray
        Me.LabelDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDireccion.Location = New System.Drawing.Point(279, 266)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(77, 15)
        Me.LabelDireccion.TabIndex = 48
        Me.LabelDireccion.Text = "Direccion"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFecha.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFecha.Location = New System.Drawing.Point(45, 266)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(136, 15)
        Me.LabelFecha.TabIndex = 47
        Me.LabelFecha.Text = "Fecha nacimiento"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.White
        Me.TxtDireccion.Location = New System.Drawing.Point(279, 286)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(218, 22)
        Me.TxtDireccion.TabIndex = 46
        Me.TxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFecha
        '
        Me.TxtFecha.BackColor = System.Drawing.Color.White
        Me.TxtFecha.Location = New System.Drawing.Point(45, 286)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(218, 22)
        Me.TxtFecha.TabIndex = 45
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboFacultad
        '
        Me.CboFacultad.BackColor = System.Drawing.Color.White
        Me.CboFacultad.FormattingEnabled = True
        Me.CboFacultad.Items.AddRange(New Object() {"Informatica", "Ingenieria", "Contabilidad", "Ciencias Naturales", "Derecho"})
        Me.CboFacultad.Location = New System.Drawing.Point(529, 184)
        Me.CboFacultad.Name = "CboFacultad"
        Me.CboFacultad.Size = New System.Drawing.Size(220, 24)
        Me.CboFacultad.TabIndex = 50
        '
        'LabelFacultad
        '
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFacultad.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFacultad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFacultad.Location = New System.Drawing.Point(529, 164)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(68, 15)
        Me.LabelFacultad.TabIndex = 49
        Me.LabelFacultad.Text = "Facultad"
        '
        'CboSemestre
        '
        Me.CboSemestre.BackColor = System.Drawing.Color.White
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CboSemestre.Location = New System.Drawing.Point(529, 234)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(220, 24)
        Me.CboSemestre.TabIndex = 52
        '
        'LabelSemestre
        '
        Me.LabelSemestre.AutoSize = True
        Me.LabelSemestre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemestre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSemestre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSemestre.Location = New System.Drawing.Point(529, 214)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(76, 15)
        Me.LabelSemestre.TabIndex = 51
        Me.LabelSemestre.Text = "Semestre"
        '
        'ContextMenu
        '
        Me.ContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.EliminarRegistroAlumnoToolStripMenuItem, Me.ActualizarAlumnoToolStripMenuItem})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(242, 76)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EliminarRegistroAlumnoToolStripMenuItem
        '
        Me.EliminarRegistroAlumnoToolStripMenuItem.Name = "EliminarRegistroAlumnoToolStripMenuItem"
        Me.EliminarRegistroAlumnoToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.EliminarRegistroAlumnoToolStripMenuItem.Text = "Eliminar registro alumno"
        '
        'ActualizarAlumnoToolStripMenuItem
        '
        Me.ActualizarAlumnoToolStripMenuItem.Name = "ActualizarAlumnoToolStripMenuItem"
        Me.ActualizarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.ActualizarAlumnoToolStripMenuItem.Text = "Actualizar alumno"
        '
        'Registro_Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.ContextMenuStrip = Me.ContextMenu
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
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.Labeltotal)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Alumnos"
        Me.Text = "Registro_Alumnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Labeltotal As Label
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents CboGenero As ComboBox
    Friend WithEvents LabelExp As Label
    Friend WithEvents TxtExp As TextBox
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents CboFacultad As ComboBox
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents CboSemestre As ComboBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRegistroAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarAlumnoToolStripMenuItem As ToolStripMenuItem
End Class
