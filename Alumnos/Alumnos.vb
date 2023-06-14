Public Class Alumnos

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar_Txt()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try

            If TxtExp.Text = Nothing Or
                    TxtNombre.Text = Nothing Or
                    TxtApellido.Text = Nothing Or
                    CboGenero.Text = "Selecciona genero" Then

                '-----------------MENSAJE DE ERROR---------------------------------------
                MsgBox("Existe información sin registrar, ingresa datos necesarios ", MsgBoxStyle.Critical, "Registro Alumnos")
                '------------------------------------------------------------------------
            Else
                '------------------------------------------------------------------------'
                '-----------------------Aviso de confirmación----------------------------'
                '------------------------------------------------------------------------'
                Dim Respuesta As DialogResult = MessageBox.Show("Se registrara nuevo alumno en la Dase de datos, ¿Deseas Continuar?", "Alumnos", MessageBoxButtons.YesNo)

                If Respuesta = DialogResult.Yes Then

                    DataGridAlumnos.Rows.Add(TxtExp.Text, TxtNombre.Text, TxtApellido.Text, CboGenero.Text)
                    Limpiar_Txt()
                ElseIf Respuesta = DialogResult.No Then


                End If

            End If


        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try

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



    Private Sub Limpiar_Txt()
        TxtExp.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        CboGenero.Text = "Selecciona genero"
    End Sub

    Private Sub CboGenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboGenero.KeyPress
        e.KeyChar = ""
    End Sub
End Class