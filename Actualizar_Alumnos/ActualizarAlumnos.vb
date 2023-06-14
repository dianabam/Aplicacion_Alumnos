Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class ActualizarAlumnos
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
            TxtApellido.Text = Nothing Or
            TxtDireccion.Text = Nothing Or
            TxtFecha.Text = Nothing Or
            CboFacultad.Text = Nothing Or
            CboGenero.Text = Nothing Or
            CboSemestre.Text = Nothing Then
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Llenar informacion faltante " & MsgBoxStyle.Critical, "Actualizar Materia")
            '------------------------------------------------------------------------
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro " & TxtExp.Text & " ¿Desea continuar?", "Actualizar Materia", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Actualizar_Alumno()
            ElseIf Respuesta = DialogResult.No Then

            End If

        End If
    End Sub
    Private Sub Actualizar_Alumno()
        Try
            Dim cmdUpdate As New OleDbCommand
            Dim Formulario As Registro_Alumnos = CType(Owner, Registro_Alumnos) ' va a ser del tipo que pertenece a Registro materias

            Dim Expediente As Double
            Expediente = TxtExp.Text

            'SET que encabezados actualizar
            cmdUpdate.Connection = Conexion

            cmdUpdate.CommandText = "UPDATE Alumnos SET Nombre = '" & TxtNombre.Text &
            "', Apellido = '" & TxtApellido.Text &
            "', Genero = '" & CboGenero.Text &
            "', Fecha_Nacimiento = '" & TxtFecha.Text &
            "', Direccion = '" & TxtDireccion.Text &
            "', Facultad = '" & CboFacultad.Text &
            "', Semestre = '" & CboSemestre.Text &
            "' Where Expediente = " & Expediente

            cmdUpdate.ExecuteNonQuery() 'ejecutar'
            Me.Close()
            Formulario.Mostrar_Alumnos()

        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub

End Class