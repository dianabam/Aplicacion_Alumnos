<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Materias
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
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.LabelMaestro = New System.Windows.Forms.Label()
        Me.TxtMaestro = New System.Windows.Forms.TextBox()
        Me.LabelClave = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.DataGridMaterias = New System.Windows.Forms.DataGridView()
        Me.Labeltotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.ContextMenuEliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.ContextMenuEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboSemestre
        '
        Me.CboSemestre.BackColor = System.Drawing.Color.White
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CboSemestre.Location = New System.Drawing.Point(535, 170)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(220, 24)
        Me.CboSemestre.TabIndex = 73
        '
        'LabelSemestre
        '
        Me.LabelSemestre.AutoSize = True
        Me.LabelSemestre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSemestre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSemestre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSemestre.Location = New System.Drawing.Point(535, 150)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(76, 15)
        Me.LabelSemestre.TabIndex = 72
        Me.LabelSemestre.Text = "Semestre"
        '
        'LabelMaestro
        '
        Me.LabelMaestro.AutoSize = True
        Me.LabelMaestro.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelMaestro.ForeColor = System.Drawing.Color.DimGray
        Me.LabelMaestro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelMaestro.Location = New System.Drawing.Point(290, 200)
        Me.LabelMaestro.Name = "LabelMaestro"
        Me.LabelMaestro.Size = New System.Drawing.Size(196, 15)
        Me.LabelMaestro.TabIndex = 68
        Me.LabelMaestro.Text = "Nombre Maestro Asignado"
        '
        'TxtMaestro
        '
        Me.TxtMaestro.BackColor = System.Drawing.Color.White
        Me.TxtMaestro.Location = New System.Drawing.Point(290, 220)
        Me.TxtMaestro.Name = "TxtMaestro"
        Me.TxtMaestro.Size = New System.Drawing.Size(220, 22)
        Me.TxtMaestro.TabIndex = 66
        Me.TxtMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelClave
        '
        Me.LabelClave.AutoSize = True
        Me.LabelClave.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelClave.ForeColor = System.Drawing.Color.DimGray
        Me.LabelClave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelClave.Location = New System.Drawing.Point(45, 150)
        Me.LabelClave.Name = "LabelClave"
        Me.LabelClave.Size = New System.Drawing.Size(129, 15)
        Me.LabelClave.TabIndex = 64
        Me.LabelClave.Text = "Clave de materia"
        '
        'TxtClave
        '
        Me.TxtClave.BackColor = System.Drawing.Color.White
        Me.TxtClave.Location = New System.Drawing.Point(45, 170)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(220, 22)
        Me.TxtClave.TabIndex = 63
        Me.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCorreo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCorreo.Location = New System.Drawing.Point(535, 200)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(188, 15)
        Me.LabelCorreo.TabIndex = 62
        Me.LabelCorreo.Text = "Nombre Correo Asignado"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(290, 150)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 60
        Me.LabelNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(290, 170)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(220, 22)
        Me.TxtNombre.TabIndex = 58
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridMaterias
        '
        Me.DataGridMaterias.AllowDrop = True
        Me.DataGridMaterias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridMaterias.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMaterias.Location = New System.Drawing.Point(115, 319)
        Me.DataGridMaterias.Name = "DataGridMaterias"
        Me.DataGridMaterias.ReadOnly = True
        Me.DataGridMaterias.RowHeadersWidth = 51
        Me.DataGridMaterias.RowTemplate.Height = 24
        Me.DataGridMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMaterias.Size = New System.Drawing.Size(600, 120)
        Me.DataGridMaterias.TabIndex = 57
        '
        'Labeltotal
        '
        Me.Labeltotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Labeltotal.AutoSize = True
        Me.Labeltotal.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Labeltotal.ForeColor = System.Drawing.Color.DimGray
        Me.Labeltotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Labeltotal.Location = New System.Drawing.Point(45, 90)
        Me.Labeltotal.Name = "Labeltotal"
        Me.Labeltotal.Size = New System.Drawing.Size(111, 15)
        Me.Labeltotal.TabIndex = 56
        Me.Labeltotal.Text = "Total Materias"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(45, 110)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(70, 22)
        Me.TxtTotal.TabIndex = 55
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelInferior
        '
        Me.PanelInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInferior.Controls.Add(Me.ButtonLimpiar)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Location = New System.Drawing.Point(0, 480)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 70)
        Me.PanelInferior.TabIndex = 54
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiar.Location = New System.Drawing.Point(518, 21)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonLimpiar.TabIndex = 2
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
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.LabelTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitulo.Location = New System.Drawing.Point(95, 30)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(610, 30)
        Me.LabelTitulo.TabIndex = 53
        Me.LabelTitulo.Text = "REGISTRO DE MATERIAS DESDE UNA DBA"
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDescripcion.ForeColor = System.Drawing.Color.DimGray
        Me.LabelDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDescripcion.Location = New System.Drawing.Point(45, 200)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(93, 15)
        Me.LabelDescripcion.TabIndex = 75
        Me.LabelDescripcion.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.White
        Me.TxtDescripcion.Location = New System.Drawing.Point(45, 220)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(220, 22)
        Me.TxtDescripcion.TabIndex = 74
        Me.TxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.Color.White
        Me.TxtCorreo.Location = New System.Drawing.Point(535, 220)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(220, 22)
        Me.TxtCorreo.TabIndex = 76
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuEliminar
        '
        Me.ContextMenuEliminar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuEliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.EliminarRegistroToolStripMenuItem, Me.ActualizarRegistrosToolStripMenuItem})
        Me.ContextMenuEliminar.Name = "ContextMenuEliminar"
        Me.ContextMenuEliminar.Size = New System.Drawing.Size(206, 76)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.EliminarRegistroToolStripMenuItem.Text = "Eliminar registro"
        '
        'ActualizarRegistrosToolStripMenuItem
        '
        Me.ActualizarRegistrosToolStripMenuItem.Name = "ActualizarRegistrosToolStripMenuItem"
        Me.ActualizarRegistrosToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.ActualizarRegistrosToolStripMenuItem.Text = "Actualizar registros"
        '
        'Registro_Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.ContextMenuStrip = Me.ContextMenuEliminar
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
        Me.Controls.Add(Me.DataGridMaterias)
        Me.Controls.Add(Me.Labeltotal)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Materias"
        Me.Text = "Registro_Materias"
        CType(Me.DataGridMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ContextMenuEliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboSemestre As ComboBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents LabelMaestro As Label
    Friend WithEvents TxtMaestro As TextBox
    Friend WithEvents LabelClave As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents DataGridMaterias As DataGridView
    Friend WithEvents Labeltotal As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents ContextMenuEliminar As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarRegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents ButtonLimpiar As Button
End Class
