<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promedio
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
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelP1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtP1 = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelP2 = New System.Windows.Forms.Label()
        Me.TxtP2 = New System.Windows.Forms.TextBox()
        Me.LabelP3 = New System.Windows.Forms.Label()
        Me.TxtP3 = New System.Windows.Forms.TextBox()
        Me.LabelPromedio = New System.Windows.Forms.Label()
        Me.TxtPromedio = New System.Windows.Forms.TextBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonPromedio = New System.Windows.Forms.Button()
        Me.LabelP4 = New System.Windows.Forms.Label()
        Me.TxtP4 = New System.Windows.Forms.TextBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.CboFacultad = New System.Windows.Forms.ComboBox()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.TxtExp = New System.Windows.Forms.TextBox()
        Me.CboSemestre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.LabelTitulo.Location = New System.Drawing.Point(251, 33)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(298, 30)
        Me.LabelTitulo.TabIndex = 10
        Me.LabelTitulo.Text = "PROMEDIO ALUMNO"
        '
        'LabelP1
        '
        Me.LabelP1.AutoSize = True
        Me.LabelP1.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelP1.ForeColor = System.Drawing.Color.DimGray
        Me.LabelP1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelP1.Location = New System.Drawing.Point(35, 242)
        Me.LabelP1.Name = "LabelP1"
        Me.LabelP1.Size = New System.Drawing.Size(71, 15)
        Me.LabelP1.TabIndex = 25
        Me.LabelP1.Text = "Parcial 1"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNombre.ForeColor = System.Drawing.Color.DimGray
        Me.LabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelNombre.Location = New System.Drawing.Point(431, 82)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(62, 15)
        Me.LabelNombre.TabIndex = 24
        Me.LabelNombre.Text = "Nombre"
        '
        'TxtP1
        '
        Me.TxtP1.BackColor = System.Drawing.Color.White
        Me.TxtP1.Location = New System.Drawing.Point(35, 260)
        Me.TxtP1.Name = "TxtP1"
        Me.TxtP1.Size = New System.Drawing.Size(218, 22)
        Me.TxtP1.TabIndex = 23
        Me.TxtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(431, 102)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 22)
        Me.TxtNombre.TabIndex = 22
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelP2
        '
        Me.LabelP2.AutoSize = True
        Me.LabelP2.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelP2.ForeColor = System.Drawing.Color.DimGray
        Me.LabelP2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelP2.Location = New System.Drawing.Point(35, 293)
        Me.LabelP2.Name = "LabelP2"
        Me.LabelP2.Size = New System.Drawing.Size(71, 15)
        Me.LabelP2.TabIndex = 30
        Me.LabelP2.Text = "Parcial 2"
        '
        'TxtP2
        '
        Me.TxtP2.BackColor = System.Drawing.Color.White
        Me.TxtP2.Location = New System.Drawing.Point(35, 313)
        Me.TxtP2.Name = "TxtP2"
        Me.TxtP2.Size = New System.Drawing.Size(218, 22)
        Me.TxtP2.TabIndex = 29
        Me.TxtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelP3
        '
        Me.LabelP3.AutoSize = True
        Me.LabelP3.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelP3.ForeColor = System.Drawing.Color.DimGray
        Me.LabelP3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelP3.Location = New System.Drawing.Point(35, 354)
        Me.LabelP3.Name = "LabelP3"
        Me.LabelP3.Size = New System.Drawing.Size(71, 15)
        Me.LabelP3.TabIndex = 32
        Me.LabelP3.Text = "Parcial 3"
        '
        'TxtP3
        '
        Me.TxtP3.BackColor = System.Drawing.Color.White
        Me.TxtP3.Location = New System.Drawing.Point(35, 374)
        Me.TxtP3.Name = "TxtP3"
        Me.TxtP3.Size = New System.Drawing.Size(218, 22)
        Me.TxtP3.TabIndex = 31
        Me.TxtP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPromedio
        '
        Me.LabelPromedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPromedio.AutoSize = True
        Me.LabelPromedio.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPromedio.ForeColor = System.Drawing.Color.DimGray
        Me.LabelPromedio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelPromedio.Location = New System.Drawing.Point(510, 433)
        Me.LabelPromedio.Name = "LabelPromedio"
        Me.LabelPromedio.Size = New System.Drawing.Size(74, 15)
        Me.LabelPromedio.TabIndex = 34
        Me.LabelPromedio.Text = "Promedio"
        '
        'TxtPromedio
        '
        Me.TxtPromedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPromedio.BackColor = System.Drawing.Color.White
        Me.TxtPromedio.Location = New System.Drawing.Point(513, 451)
        Me.TxtPromedio.Name = "TxtPromedio"
        Me.TxtPromedio.ReadOnly = True
        Me.TxtPromedio.Size = New System.Drawing.Size(218, 22)
        Me.TxtPromedio.TabIndex = 33
        Me.TxtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelInferior
        '
        Me.PanelInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInferior.Controls.Add(Me.ButtonLimpiar)
        Me.PanelInferior.Controls.Add(Me.ButtonPromedio)
        Me.PanelInferior.Location = New System.Drawing.Point(0, 480)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 70)
        Me.PanelInferior.TabIndex = 35
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiar.Location = New System.Drawing.Point(513, 21)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(90, 30)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "Limpar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonPromedio
        '
        Me.ButtonPromedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPromedio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPromedio.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.ButtonPromedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonPromedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPromedio.Location = New System.Drawing.Point(635, 21)
        Me.ButtonPromedio.Name = "ButtonPromedio"
        Me.ButtonPromedio.Size = New System.Drawing.Size(90, 30)
        Me.ButtonPromedio.TabIndex = 0
        Me.ButtonPromedio.Text = "Calcular"
        Me.ButtonPromedio.UseVisualStyleBackColor = True
        '
        'LabelP4
        '
        Me.LabelP4.AutoSize = True
        Me.LabelP4.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelP4.ForeColor = System.Drawing.Color.DimGray
        Me.LabelP4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelP4.Location = New System.Drawing.Point(35, 412)
        Me.LabelP4.Name = "LabelP4"
        Me.LabelP4.Size = New System.Drawing.Size(71, 15)
        Me.LabelP4.TabIndex = 37
        Me.LabelP4.Text = "Parcial 4"
        '
        'TxtP4
        '
        Me.TxtP4.BackColor = System.Drawing.Color.White
        Me.TxtP4.Location = New System.Drawing.Point(35, 432)
        Me.TxtP4.Name = "TxtP4"
        Me.TxtP4.Size = New System.Drawing.Size(218, 22)
        Me.TxtP4.TabIndex = 36
        Me.TxtP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelFacultad
        '
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFacultad.ForeColor = System.Drawing.Color.DimGray
        Me.LabelFacultad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFacultad.Location = New System.Drawing.Point(126, 133)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(68, 15)
        Me.LabelFacultad.TabIndex = 28
        Me.LabelFacultad.Text = "Facultad"
        '
        'CboFacultad
        '
        Me.CboFacultad.BackColor = System.Drawing.Color.White
        Me.CboFacultad.FormattingEnabled = True
        Me.CboFacultad.Items.AddRange(New Object() {"Informatica", "Ingenieria", "Contabilidad", "Ciencias Naturales", "Derecho"})
        Me.CboFacultad.Location = New System.Drawing.Point(129, 153)
        Me.CboFacultad.Name = "CboFacultad"
        Me.CboFacultad.Size = New System.Drawing.Size(220, 24)
        Me.CboFacultad.TabIndex = 51
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelExp.ForeColor = System.Drawing.Color.DimGray
        Me.LabelExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelExp.Location = New System.Drawing.Point(131, 82)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.Size = New System.Drawing.Size(86, 15)
        Me.LabelExp.TabIndex = 53
        Me.LabelExp.Text = "Expediente"
        '
        'TxtExp
        '
        Me.TxtExp.BackColor = System.Drawing.Color.White
        Me.TxtExp.Location = New System.Drawing.Point(131, 102)
        Me.TxtExp.Name = "TxtExp"
        Me.TxtExp.Size = New System.Drawing.Size(218, 22)
        Me.TxtExp.TabIndex = 52
        Me.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboSemestre
        '
        Me.CboSemestre.BackColor = System.Drawing.Color.White
        Me.CboSemestre.FormattingEnabled = True
        Me.CboSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CboSemestre.Location = New System.Drawing.Point(429, 153)
        Me.CboSemestre.Name = "CboSemestre"
        Me.CboSemestre.Size = New System.Drawing.Size(220, 24)
        Me.CboSemestre.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(429, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Semestre"
        '
        'Promedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.CboSemestre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelExp)
        Me.Controls.Add(Me.TxtExp)
        Me.Controls.Add(Me.CboFacultad)
        Me.Controls.Add(Me.LabelP4)
        Me.Controls.Add(Me.TxtP4)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelPromedio)
        Me.Controls.Add(Me.TxtPromedio)
        Me.Controls.Add(Me.LabelP3)
        Me.Controls.Add(Me.TxtP3)
        Me.Controls.Add(Me.LabelP2)
        Me.Controls.Add(Me.TxtP2)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelP1)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtP1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Promedio"
        Me.Text = "Promedio"
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelP1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtP1 As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelP2 As Label
    Friend WithEvents TxtP2 As TextBox
    Friend WithEvents LabelP3 As Label
    Friend WithEvents TxtP3 As TextBox
    Friend WithEvents LabelPromedio As Label
    Friend WithEvents TxtPromedio As TextBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonPromedio As Button
    Friend WithEvents LabelP4 As Label
    Friend WithEvents TxtP4 As TextBox
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents CboFacultad As ComboBox
    Friend WithEvents LabelExp As Label
    Friend WithEvents TxtExp As TextBox
    Friend WithEvents CboSemestre As ComboBox
    Friend WithEvents Label1 As Label
End Class
