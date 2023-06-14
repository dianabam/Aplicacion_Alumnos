Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class Registro_Materias
    Private Sub Registro_Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Materias()
        Limpiar()


    End Sub

    Sub Mostrar_Materias()
        Try
            Dim Paquete As New DataSet
            Dim ConsultaSQL As String
            Dim Adaptador As New OleDbDataAdapter


            ConsultaSQL = "SELECT * FROM Materias ORDER BY Nombre_Materia Asc"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, Conexion)
            Paquete.Tables.Add("Materias")
            Adaptador.Fill(Paquete.Tables("Materias"))

            DataGridMaterias.DataSource = Paquete.Tables("Materias")
            DataGridMaterias.AllowUserToAddRows = False


            '//Conteo de registros 
            TxtTotal.Text = DataGridMaterias.Rows.Count
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub

    '//PROCESO PARA AGREGAR UN NUEVA MATERIA A LA DBA

    Dim Comandos As New OleDb.OleDbCommand



    Private Sub Registro_De_Materias()
        Try
            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Materias(Clave, Nombre_Materia, Semestre, Descripcion, Maestro, Correo)" & Chr(13) &
                                              "VALUES (Clave, Nombre_Materia, Semestre, Descripcion, Maestro, Correo)", Conexion)

            Comandos.Parameters.AddWithValue("@Clave", TxtClave.Text)
            Comandos.Parameters.AddWithValue("@Nombre_Materia", TxtNombre.Text)
            Comandos.Parameters.AddWithValue("@Semestre", CboSemestre.Text)
            Comandos.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            Comandos.Parameters.AddWithValue("@Maestro", TxtMaestro.Text)
            Comandos.Parameters.AddWithValue("@Correo", TxtCorreo.Text)


            Comandos.ExecuteNonQuery() 'ejecuta la sentencia de instrucciones
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try

            If TxtClave.Text = Nothing Or
               TxtNombre.Text = Nothing Or
               TxtDescripcion.Text = Nothing Or
               TxtMaestro.Text = Nothing Or
               TxtCorreo.Text = Nothing Or
               CboSemestre.Text = Nothing Then

                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("Faltan espacios por rellenar", MsgBoxStyle.Critical, "Registro de alumnos")
                '------------------------------------------------------------------------

            Else
                Dim Respuesta As DialogResult = MessageBox.Show("Desea continuar con el registro", "Registro de materias", MessageBoxButtons.YesNo)
                If Respuesta = DialogResult.Yes Then
                    Registro_De_Materias()
                    Mostrar_Materias()
                    Limpiar()
                ElseIf Respuesta = DialogResult.No Then
                    '//// No se hace nada solo cierra la vantena

                End If


            End If

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

    End Sub


    Private Sub Buscar_Clave()
        Try
            Dim Adaptador As New OleDbDataAdapter 'conecta como un adaptador de luz
            Dim Paquete As New DataSet
            Dim ConsultaSql As String
            Dim Registro As Long 'Long porque no se sabe el numero de encabezados de la tabla

            ConsultaSql = "SELECT * FROM Materias WHERE Clave = " & TxtClave.Text
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion) 'PONER CONEXION
            Paquete = New DataSet

            Adaptador.Fill(Paquete, "Materias") 'llenar informacion de la tabla alumnos
            Registro = Paquete.Tables("Materias").Rows.Count

            If Registro <> 0 Then

                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("El registro de Clave ya existe ", MsgBoxStyle.Critical, "Agregar Clave")
                '------------------------------------------------------------------------
                TxtClave.Focus() 'Manda mensaje de erro y coloca en el expediente para que modifique elexpediente por uno nuevo

            End If

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub


    Private Sub Limpiar()
        Try
            TxtClave.Clear()
            TxtNombre.Clear()
            TxtDescripcion.Clear()
            TxtMaestro.Clear()
            TxtCorreo.Clear()
            CboSemestre.Text = "Selecciona Semestre"
            DataGridMaterias.ClearSelection()

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub

    Private Sub TxtClave_Leave(sender As Object, e As EventArgs) Handles TxtClave.Leave
        Buscar_Clave()
    End Sub


    Private Sub Eliminar_registro()

        Dim cmdDelete As New OleDbCommand
        For Each row As DataGridViewRow In DataGridMaterias.SelectedRows
            Dim clave As Double = row.Cells("Clave").Value
            cmdDelete.Connection = Conexion
            cmdDelete.CommandText = "DELETE FROM Materias WHERE Clave =" & clave

            cmdDelete.ExecuteNonQuery()
        Next
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub EliminarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroToolStripMenuItem.Click

        If DataGridMaterias.SelectedRows.Count = 0 Then

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("No hay registros para eliminar", MsgBoxStyle.Critical, "Eliminar registro")
            '------------------------------------------------------------------------
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se eliminara el resgistro", "Eliminar registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Eliminar_registro()
                Mostrar_Materias()
                Limpiar()
                TxtTotal.Text = DataGridMaterias.Rows.Count
            ElseIf Respuesta = DialogResult.No Then
                'noo hace nada'
            End If
        End If

    End Sub

    Private Sub ActualizarRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarRegistrosToolStripMenuItem.Click

        If DataGridMaterias.SelectedRows.Count = 0 Then

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Seleccione registro para actualizar", MsgBoxStyle.Critical, "Actualizar")
            '------------------------------------------------------------------------

        Else
            Dim Actualizar As New ActualizarMaterias
            AddOwnedForm(Actualizar)

            Actualizar.TxtClave.Text = DataGridMaterias.CurrentRow.Cells(0).Value
            Actualizar.TxtNombre.Text = DataGridMaterias.CurrentRow.Cells(1).Value
            Actualizar.CboSemestre.Text = DataGridMaterias.CurrentRow.Cells(2).Value
            Actualizar.TxtDescripcion.Text = DataGridMaterias.CurrentRow.Cells(3).Value
            Actualizar.TxtMaestro.Text = DataGridMaterias.CurrentRow.Cells(4).Value
            Actualizar.TxtCorreo.Text = DataGridMaterias.CurrentRow.Cells(5).Value

            Actualizar.ShowDialog()
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CboSemestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboSemestre.KeyPress
        e.KeyChar = ""
    End Sub
End Class