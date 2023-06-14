'*******************************************'
'Se importan librerías y códigos necesarios'
'*******************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUsuario.Text = Iniciar_Sesion.Cbo_Usuarios.Text
        LabelCorreo.Text = Iniciar_Sesion.Correo
        LabelFacultad.Text = Iniciar_Sesion.Facultad
        Me.Opacity = 0
        TimerAbrir.Start()
        ButtonRestaurar.Visible = False
        Maximizar()
        ButtonInicio.PerformClick()

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        TimerCerrar.Start()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '//**************************************************************
    '// Librearias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraDeTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraDeTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelContenido_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelContenido.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxLogo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        End If
        If Me.Opacity = 1 Then
            TimerAbrir.Stop()
        End If
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerCerrar.Stop()
            Application.Exit()
        End If
    End Sub


    '--------VARIABLES L=Location S=Size---------'
    Dim Lx, Ly As Integer
    Dim Sw, Sh As Integer
    '----------Proceso para maximizar tamade la ventana------------'
    Private Sub Maximizar()
        Try
            Lx = Me.Location.X
            Ly = Me.Location.Y
            Sw = Me.Size.Width
            Sh = Me.Size.Height


            'Tomar el tamañana de la pantala principal que usamos en caso de tener mas monitores'
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location


            ButtonRestaurar.Visible = True
            ButtonMaximizar.Visible = False


        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

    End Sub



    Private Sub ButtonRestaurar_Click(sender As Object, e As EventArgs) Handles ButtonRestaurar.Click
        Try
            Me.Size = New Size(Sw, Sh)
            Me.Location = New Point(Lx, Ly)

            ButtonRestaurar.Visible = False
            ButtonMaximizar.Visible = True
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

    End Sub
    Private Sub ButtonMaximizar_Click(sender As Object, e As EventArgs) Handles ButtonMaximizar.Click
        Maximizar()

    End Sub

    '--------PARA ABRIR FORMULARIOS HIJOS---------'

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        Try
            If (Not (FormularioActivo) Is Nothing) Then  'cierra formularios abiertos antes para solo tener 1'
                FormularioActivo.Close()
                RegresarColores()
            End If

            RegresarColores()
            ButtonInicio.FlatAppearance.BorderColor = Color.Turquoise 'cambia color cuandoesta seleccionado el boton
            'ButtonInicio.FlatAppearance.BorderColor = Color.FromArgb(24,24,24)
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

    End Sub


    Private Sub ButtonAlumnos_Click(sender As Object, e As EventArgs) Handles ButtonAlumnos.Click
        RegresarColores()
        AbrirFormularioContenedor(New Alumnos)
        ButtonAlumnos.FlatAppearance.BorderColor = Color.Turquoise
    End Sub

    Private Sub ButtonPromedio_Click(sender As Object, e As EventArgs) Handles ButtonPromedio.Click
        RegresarColores()
        AbrirFormularioContenedor(New Promedio)
        ButtonPromedio.FlatAppearance.BorderColor = Color.Turquoise
    End Sub


    Private Sub ButtonMaterias_Click(sender As Object, e As EventArgs) Handles ButtonMaterias.Click
        RegresarColores()
        AbrirFormularioContenedor(New Registro_Alumnos)
        ButtonMaterias.FlatAppearance.BorderColor = Color.Turquoise

    End Sub
    Private Sub ButtonRMaterias_Click(sender As Object, e As EventArgs) Handles ButtonRMaterias.Click
        RegresarColores()
        AbrirFormularioContenedor(New Registro_Materias)
        ButtonRMaterias.FlatAppearance.BorderColor = Color.Turquoise

    End Sub



    Dim FormularioActivo As Form = Nothing

    Private Sub AbrirFormularioContenedor(ByVal FormularioHijo As Form)
        Try

            If (Not (FormularioActivo) Is Nothing) Then  'cierra formularios abiertos antes para solo tener 1'
                FormularioActivo.Close()

            End If

            FormularioActivo = FormularioHijo
            FormularioHijo.TopLevel = False

            FormularioHijo.FormBorderStyle = FormBorderStyle.None  'quita el estilo del formulario'
            FormularioHijo.Dock = DockStyle.Fill  'el formulario toma el tamaño el panel'

            PanelContenido.Controls.Add(FormularioHijo)   'El panel abre cualquier formulario
            PanelContenido.Tag = FormularioHijo 'Intercala entre formularios para abrir y cerrar formularios en tiempo real
            FormularioHijo.BringToFront() 'pasar el formulario seleccionado al frente'
            FormularioHijo.Show()

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try


    End Sub

    Private Sub PanelContenido_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenido.Paint

    End Sub




    '---------cambia color cuando esta seleccionado el boton-----------'
    Private Sub RegresarColores()
        ButtonInicio.FlatAppearance.BorderColor = Color.WhiteSmoke
        ButtonMaterias.FlatAppearance.BorderColor = Color.WhiteSmoke
        ButtonPromedio.FlatAppearance.BorderColor = Color.WhiteSmoke
        ButtonAlumnos.FlatAppearance.BorderColor = Color.WhiteSmoke
        ButtonRMaterias.FlatAppearance.BorderColor = Color.WhiteSmoke

    End Sub

    '---------PROCESO CREAR LA HORA Y FECHA-----------'
    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        Try
            LabelHora.Text = DateTime.Now.ToString("hh:mm:ss") 'H e para 24hrs y h para 12
            LabelFecha.Text = DateTime.Now.ToLongDateString

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
End Class