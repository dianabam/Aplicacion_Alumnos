'******************************************************'
'Se importan librerías y códigos necesarios'
'******************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class ActualizarMaterias
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
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

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TxtNombre.Text = Nothing Or
                TxtDescripcion.Text = Nothing Or
                TxtMaestro.Text = Nothing Or
                TxtCorreo.Text = Nothing Or
                CboSemestre.Text = Nothing Or
                CboSemestre.Text = "Selecciona semestre" Then
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Llenar informacion faltante " & MsgBoxStyle.Critical, "Actualizar Materia")
            '------------------------------------------------------------------------
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro " & TxtClave.Text & " ¿Desea continuar?", "Actualizar Materia", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Actualizar_Materia()
            ElseIf Respuesta = DialogResult.No Then

            End If

        End If
    End Sub

    Private Sub Actualizar_Materia()
        Try
            Dim cmdUpdate As New OleDbCommand
            Dim Formulario As Registro_Materias = CType(Owner, Registro_Materias) ' va a ser del tipo que pertenece a Registro materias

            Dim Clave As Double
            Clave = TxtClave.Text

            'SET que encabezados actualizar
            cmdUpdate.Connection = Conexion

            cmdUpdate.CommandText = "UPDATE Materias SET Nombre_Materia = '" & TxtNombre.Text &
            "', Semestre = '" & CboSemestre.Text &
            "', Descripcion = '" & TxtDescripcion.Text &
            "', Maestro = '" & TxtMaestro.Text &
            "', Correo = '" & TxtCorreo.Text &
            "' Where Clave = " & Clave

            cmdUpdate.ExecuteNonQuery() 'ejecutar'
            Me.Close()
            Formulario.Mostrar_Materias()

        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
End Class