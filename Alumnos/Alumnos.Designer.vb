<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.DataGridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.TxtExp = New System.Windows.Forms.TextBox()
        Me.CboGenero = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
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
        Me.LabelTitulo.Location = New System.Drawing.Point(255, 50)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(359, 30)
        Me.LabelTitulo.TabIndex = 9
        Me.LabelTitulo.Text = "REGISTRO DE ALUMNOS"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(45, 165)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 22)
        Me.TxtNombre.TabIndex = 10
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.White
        Me.TxtApellido.Location = New System.Drawing.Point(45, 215)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 22)
        Me.TxtApellido.TabIndex = 11
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(45, 145)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 13
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelApellido.ForeColor = System.Drawing.Color.DimGray
        Me.LabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelApellido.Location = New System.Drawing.Point(45, 195)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(63, 15)
        Me.LabelApellido.TabIndex = 14
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGenero.ForeColor = System.Drawing.Color.DimGray
        Me.LabelGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelGenero.Location = New System.Drawing.Point(45, 245)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(60, 15)
        Me.LabelGenero.TabIndex = 15
        Me.LabelGenero.Text = "Genero"
        '
        'DataGridAlumnos
        '
        Me.DataGridAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DataGridAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Exp, Me.Nombre, Me.Apellido, Me.Genero})
        Me.DataGridAlumnos.Location = New System.Drawing.Point(101, 360)
        Me.DataGridAlumnos.Name = "DataGridAlumnos"
        Me.DataGridAlumnos.RowHeadersWidth = 51
        Me.DataGridAlumnos.RowTemplate.Height = 24
        Me.DataGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAlumnos.Size = New System.Drawing.Size(600, 117)
        Me.DataGridAlumnos.TabIndex = 17
        '
        'Exp
        '
        Me.Exp.HeaderText = "Exp"
        Me.Exp.MinimumWidth = 6
        Me.Exp.Name = "Exp"
        Me.Exp.Width = 125
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 6
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 125
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.MinimumWidth = 6
        Me.Genero.Name = "Genero"
        Me.Genero.Width = 125
        '
        'PanelInferior
        '
        Me.PanelInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Location = New System.Drawing.Point(0, 480)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 70)
        Me.PanelInferior.TabIndex = 18
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
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelExp.ForeColor = System.Drawing.Color.DimGray
        Me.LabelExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelExp.Location = New System.Drawing.Point(45, 95)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.Size = New System.Drawing.Size(86, 15)
        Me.LabelExp.TabIndex = 20
        Me.LabelExp.Text = "Expediente"
        '
        'TxtExp
        '
        Me.TxtExp.BackColor = System.Drawing.Color.White
        Me.TxtExp.Location = New System.Drawing.Point(45, 115)
        Me.TxtExp.Name = "TxtExp"
        Me.TxtExp.Size = New System.Drawing.Size(218, 22)
        Me.TxtExp.TabIndex = 19
        Me.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboGenero
        '
        Me.CboGenero.BackColor = System.Drawing.Color.White
        Me.CboGenero.FormattingEnabled = True
        Me.CboGenero.Items.AddRange(New Object() {"Mujer", "Hombre"})
        Me.CboGenero.Location = New System.Drawing.Point(45, 265)
        Me.CboGenero.Name = "CboGenero"
        Me.CboGenero.Size = New System.Drawing.Size(220, 24)
        Me.CboGenero.TabIndex = 21
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.CboGenero)
        Me.Controls.Add(Me.LabelExp)
        Me.Controls.Add(Me.TxtExp)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.DataGridAlumnos)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Alumnos"
        Me.Text = "Prueba1"
        CType(Me.DataGridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelGenero As Label
    Friend WithEvents DataGridAlumnos As DataGridView
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents Exp As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents LabelExp As Label
    Friend WithEvents TxtExp As TextBox
    Friend WithEvents CboGenero As ComboBox
End Class
