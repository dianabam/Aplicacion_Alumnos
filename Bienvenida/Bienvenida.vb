'*******************************************'
'Se importan librerías y códigos necesarios'
'*******************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class Bienvenida
    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Iniciar_Sesion.Cbo_Usuarios.Text
        LabelCorreo.Text = Iniciar_Sesion.Correo
        ProgressBarCargando.Value = 0
        Me.Opacity = 0
        TimerAbrir.Start()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs)
        TimerCerrar.Start()
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

    Private Sub PanelBarraDeTitulo_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    '*******************************************'
    'Temporizador para abrir y cerrar formulario'
    '*******************************************'
    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        ProgressBarCargando.Value += 2
        LabelCargando.Text = CLng((ProgressBarCargando.Value * 100) / ProgressBarCargando.Maximum) & "%"


        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        End If
        If ProgressBarCargando.Value = 100 Then
            TimerAbrir.Stop()
            TimerCerrar.Start()

        End If
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerCerrar.Stop()
            Me.Hide()
            Principal.ShowDialog()
        End If
    End Sub


End Class