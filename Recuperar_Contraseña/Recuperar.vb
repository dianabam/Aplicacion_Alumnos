Public Class Recuperar
    Private Sub Recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cbo_Usuarios.SelectedIndex = 0
        TextBoxCorreo.Text = "diana@gmail.com"
        Me.Opacity = 0
        TimerAbrir.Start()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Hide()
        Iniciar_Sesion.Show()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        '-----------------mensaje de confirmacion-------------------'
        MsgBox("Se envió correo del usuario a: " & Iniciar_Sesion.Correo, MsgBoxStyle.OkOnly, "Enviado")
        '-----------------mensaje de confirmacion-------------------'
    End Sub

    Private Sub Cbo_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Usuarios.SelectedIndexChanged
        If Cbo_Usuarios.Text = "Diana Gabriela" Then
            Iniciar_Sesion.Correo = "diana@gmail.com"
            TextBoxCorreo.Text = Iniciar_Sesion.Correo
        End If
        If Cbo_Usuarios.Text = "Aria Grace" Then
            Iniciar_Sesion.Correo = "grace@gmail.com"
            TextBoxCorreo.Text = Iniciar_Sesion.Correo
        End If
        If Cbo_Usuarios.Text = "Alondra" Then
            Iniciar_Sesion.Correo = "alondra@gmail.com"
            TextBoxCorreo.Text = Iniciar_Sesion.Correo
        End If
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        End If
        If Me.Opacity = 1 Then
            TimerAbrir.Stop()
        End If
    End Sub
    'y la variable correo destino porque debe ser uno real
    'moficar en credentials entre comillas dobles el correo real, la contraseña real entre comillas dobles
    ' modificar wn ehit correo . from el correo real 
    'y la variable correo destino porque debe ser uno rela
    ' y todo se mandaa llamar desde el boton

End Class