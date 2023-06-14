'******************************************************'
'Se importan librerías y códigos necesarios'
'******************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class Iniciar_Sesion
    'Dim Micorreo As String''Variable privada solose usa en el formulario'
    Public Correo As String 'Variable publica'
    Public Facultad As String
    Public Apellido As String


    Private Sub Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonOcultarC.Visible = False
        Me.Opacity = 0
        TimerAbrir.Start()
        TxtClave.Text = "123"
        Enlace()
        CargarUsuarios()
    End Sub
    '***************************************************'
    'Proceso para cargar usuarios en el comboboX'
    '***************************************************'
    Private Sub CargarUsuarios()
        Try
            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "SELECT Nombre FROM Usuarios"
            Dim adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)
            adaptador.Fill(Tabla)

            Cbo_Usuarios.DataSource = Tabla
            Cbo_Usuarios.DisplayMember = "Nombre"

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
    '*********************************************************
    '***Proceso para cargar datos del usuario seleccionado ***
    '*********************************************************
    Private Sub Cargar_Datos_De_Usuario()

        Try

            Dim ConsultaSql As String
            Dim Lista As Long
            Dim Registro As DataSet
            Dim adaptador As OleDbDataAdapter

            ConsultaSql = "SELECT Apellido, Correo, Facultad FROM Usuarios WHERE Nombre = '" & Cbo_Usuarios.Text & "'"
            adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)
            Registro = New DataSet

            adaptador.Fill(Registro, "Usuarios")
            Lista = Registro.Tables("Usuarios").Rows.Count

            If Lista <> 0 Then
                Apellido = Registro.Tables("Usuarios").Rows(0).Item("Apellido")
                Correo = Registro.Tables("Usuarios").Rows(0).Item("Correo")
                Facultad = Registro.Tables("Usuarios").Rows(0).Item("Facultad")

            End If
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

    End Sub



    '***************************************************'
    'Boton minimizar y cerrar (Evento clicl)'
    '***************************************************'
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '**************************************************************
    'Librearias y eventos para poder mover de lugar el formulario
    '**************************************************************
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

    '**************************************************'
    'Boton aceptar y cerrar (Evento click)'
    '**************************************************'
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Try

            Dim ConsultaSql As String
            Dim Lector As OleDb.OleDbDataReader
            Dim Comando As OleDb.OleDbCommand


            ConsultaSql = "SELECT * FROM Usuarios WHERE Nombre = '" & Cbo_Usuarios.Text & "' AND Clave= '" & TxtClave.Text & "'"
            Comando = New OleDb.OleDbCommand(ConsultaSql, Conexion)
            Lector = Comando.ExecuteReader

            If Lector.Read = True Then
                TimerCerrar.Start()
            Else
                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("Contraseña Incorrecta, intenta nuevamente", MsgBoxStyle.Critical)
                '------------------------------------------------------------------------
            End If
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical, "Iniciando Sesion")
            '------------------------------------------------------------------------

        End Try

    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles ButtonOcultarC.Click
        'Cuando selecciono cambia de un boton a otro'
        ButtonOcultarC.Visible = False
        ButtonVerC.Visible = True
        TxtClave.PasswordChar = "*" 'ESTO OCULTA LA CONTRASEÑA'
    End Sub
    Private Sub ButtonVerC_Click(sender As Object, e As EventArgs) Handles ButtonVerC.Click
        ButtonOcultarC.Visible = True
        ButtonVerC.Visible = False
        TxtClave.PasswordChar = ""
    End Sub
    Private Sub Cbo_Usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbo_Usuarios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Cbo_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Usuarios.SelectedIndexChanged

        Cargar_Datos_De_Usuario()

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
            Me.Hide()
            Bienvenida.ShowDialog()
        End If
    End Sub

    Private Sub LabelTitulo_Click(sender As Object, e As EventArgs) Handles LabelTitulo.Click

    End Sub

    Private Sub LinkLabelRecuperar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRecuperar.LinkClicked
        Me.Hide()
        Recuperar.ShowDialog()
    End Sub

    Private Sub TxtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAceptar.PerformClick()
        End If
    End Sub
End Class