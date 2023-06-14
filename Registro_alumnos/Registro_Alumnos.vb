Imports System.Data.OleDb
Imports System.Runtime.InteropServices


Public Class Registro_Alumnos
    Private Sub Registro_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Alumnos()
        Limpiar()

    End Sub

    '//********Proceso para mostrar informacion de la tabla en el datagrid
    Sub Mostrar_Alumnos()
        Try
            Dim Paquete As New DataSet
            Dim ConsultaSQL As String
            Dim Adaptador As New OleDbDataAdapter


            ConsultaSQL = "SELECT * FROM Alumnos ORDER BY Apellido Asc"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, Conexion)
            Paquete.Tables.Add("Alumnos")
            Adaptador.Fill(Paquete.Tables("Alumnos"))

            DataGridAlumnos.DataSource = Paquete.Tables("Alumnos")
            DataGridAlumnos.AllowUserToAddRows = False


            '//Conteo de registros de alumnos
            TxtTotal.Text = DataGridAlumnos.Rows.Count

            '//Tamaño de columnas de un datagrid
            DataGridAlumnos.Columns("Nombre").Width = 150
            DataGridAlumnos.Columns("Direccion").Width = 200

            '//Ocultar columnas en un data grid
            DataGridAlumnos.Columns("Genero").Visible = False
            DataGridAlumnos.Columns("Direccion").Visible = False

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub

    '//PROCESO PARA AGREGAR UN NUEVO USARIO A LA DBA
    Dim Comandos As New OleDb.OleDbCommand


    Private Sub Registro_De_Alumnos()
        Try
            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Alumnos(Expediente, Nombre, Apellido, Genero, Fecha_Nacimiento, Direccion, Facultad, Semestre)" & Chr(13) &
                                              "VALUES (Expediente, Nombre, Apellido, Genero, Fecha_Nacimiento, Direccion, Facultad, Semestre)", Conexion)

            Comandos.Parameters.AddWithValue("@Expediente", TxtExp.Text)
            Comandos.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            Comandos.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            Comandos.Parameters.AddWithValue("@Gnero", CboGenero.Text)
            Comandos.Parameters.AddWithValue("@Fecha_Nacimiento", TxtFecha.Text)
            Comandos.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
            Comandos.Parameters.AddWithValue("@Facultad", CboFacultad.Text)
            Comandos.Parameters.AddWithValue("@Semestre", CboSemestre.Text)

            Comandos.ExecuteNonQuery() 'ejecuta la sentencia de instrucciones
        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try

            If TxtNombre.Text = Nothing Or
               TxtApellido.Text = Nothing Or
               TxtExp.Text = Nothing Or
               TxtFecha.Text = Nothing Or
               TxtDireccion.Text = Nothing Or
               CboFacultad.Text = Nothing Or
               CboGenero.Text = Nothing Or
               CboSemestre.Text = Nothing Then

                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("Faltan espacios por rellenar", MsgBoxStyle.Critical, "Registro de alumnos")
                '------------------------------------------------------------------------

            Else
                Dim Respuesta As DialogResult = MessageBox.Show("Desea continuar con el registro", "Registro de alumnos", MessageBoxButtons.YesNo)
                If Respuesta = DialogResult.Yes Then
                    Registro_De_Alumnos()
                    Mostrar_Alumnos()
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


    Private Sub Buscar_Expediente()
        Try
            Dim Adaptador As New OleDbDataAdapter 'conecta como un adaptador de luz
            Dim Paquete As New DataSet
            Dim ConsultaSql As String
            Dim Registro As Long 'Long porque no se sabe el numero de encabezados de la tabla

            ConsultaSql = "SELECT * FROM Alumnos WHERE Expediente = " & TxtExp.Text
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion) 'PONER CONEXION
            Paquete = New DataSet

            Adaptador.Fill(Paquete, "Alumnos") 'llenar informacion de la tabla alumnos
            Registro = Paquete.Tables("Alumnos").Rows.Count

            If Registro <> 0 Then

                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("El registro de Expediente ya existe ", MsgBoxStyle.Critical, "Agregar Expediente")
                '------------------------------------------------------------------------
                TxtExp.Focus() 'Manda mensaje de erro y coloca en el expediente para que modifique elexpediente por uno nuevo

            End If

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub



    Private Sub Limpiar()
        Try
            TxtExp.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtFecha.Clear()
            TxtDireccion.Clear()
            CboGenero.Text = "Selecciona genero"
            CboFacultad.Text = "Selecciona Facultad"
            CboSemestre.Text = "Selecciona Semestre"
            DataGridAlumnos.ClearSelection()

        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub

    Private Sub TxtExp_Leave(sender As Object, e As EventArgs) Handles TxtExp.Leave
        Buscar_Expediente()
    End Sub

    Private Sub Eliminar_registro()

        Dim cmdDelete As New OleDbCommand
        For Each row As DataGridViewRow In DataGridAlumnos.SelectedRows
            Dim expediente As Double = row.Cells("Expediente").Value
            cmdDelete.Connection = Conexion
            cmdDelete.CommandText = "DELETE FROM Alumnos WHERE Expediente =" & expediente

            cmdDelete.ExecuteNonQuery()
        Next
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub EliminarRegistroAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroAlumnoToolStripMenuItem.Click

        If DataGridAlumnos.SelectedRows.Count = 0 Then

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("No hay registros para eliminar", MsgBoxStyle.Critical, "Eliminar registro")
            '------------------------------------------------------------------------
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se eliminara el resgistro", "Eliminar registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Eliminar_registro()
                Mostrar_Alumnos()
                Limpiar()
                TxtTotal.Text = DataGridAlumnos.Rows.Count
            ElseIf Respuesta = DialogResult.No Then
                'np hace nada'
            End If
        End If
    End Sub

    Private Sub ActualizarAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarAlumnoToolStripMenuItem.Click

        If DataGridAlumnos.SelectedRows.Count = 0 Then

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Seleccione registro para actualizar", MsgBoxStyle.Critical, "Actualizar")
            '------------------------------------------------------------------------

        Else
            Dim Actualizar As New ActualizarAlumnos
            AddOwnedForm(Actualizar)

            Actualizar.TxtExp.Text = DataGridAlumnos.CurrentRow.Cells(0).Value
            Actualizar.TxtNombre.Text = DataGridAlumnos.CurrentRow.Cells(1).Value
            Actualizar.TxtApellido.Text = DataGridAlumnos.CurrentRow.Cells(2).Value
            Actualizar.CboGenero.Text = DataGridAlumnos.CurrentRow.Cells(3).Value
            Actualizar.TxtFecha.Text = DataGridAlumnos.CurrentRow.Cells(4).Value
            Actualizar.TxtDireccion.Text = DataGridAlumnos.CurrentRow.Cells(5).Value
            Actualizar.CboFacultad.Text = DataGridAlumnos.CurrentRow.Cells(6).Value
            Actualizar.CboSemestre.Text = DataGridAlumnos.CurrentRow.Cells(7).Value

            Actualizar.ShowDialog()
        End If
    End Sub


    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtExp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExp.KeyPress
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

    Private Sub CboGenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboSemestre.KeyPress, CboGenero.KeyPress, CboFacultad.KeyPress
        e.KeyChar = ""
    End Sub
End Class