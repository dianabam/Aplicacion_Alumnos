Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Promedio
    Private Sub Promedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub ButtonPromedio_Click(sender As Object, e As EventArgs) Handles ButtonPromedio.Click
        Try

            If TxtP1.Text = Nothing Or
               TxtP2.Text = Nothing Or
               TxtP3.Text = Nothing Or
               TxtP4.Text = Nothing Or
               TxtP1.Text = 0 Or
               TxtP2.Text = 0 Or
               TxtP3.Text = 0 Or
               TxtP3.Text = 0 Then

                '----------------------------------------------------MENSAJE DE ERROR-------------------------------------------------------'
                MsgBox("Existe información sin registrar o cantidades en 0, Ingresa la necesaria ", MsgBoxStyle.Critical, "Registro Alumnos")
            Else
                Dim PUno As Double
                Dim PDos As Double
                Dim PTres As Double
                Dim PCuatro As Double
                Dim Promedio As Double

                PUno = TxtP1.Text
                PDos = TxtP2.Text
                PTres = TxtP3.Text
                PCuatro = TxtP4.Text

                Promedio = (PUno + PDos + PTres + PCuatro) / 4

                TxtPromedio.Text = Promedio

                If Promedio >= 6 Then
                    '---------------------------------------- MENSAJE DE CONFIRMACIÓN -------------------------------------------------------
                    MsgBox("El alumno: " & TxtNombre.Text & " , De facultad: " & CboFacultad.Text & " , Del semestre: " & CboSemestre.Text & " , Con promedio: " & Promedio & " Esta Aprobado ", MsgBoxStyle.OkOnly, "Promedio")
                    '------------------------------------------------------------------------------------------------------------------------
                Else
                    If Promedio >= 1 Then
                        '---------------------------------------- MENSAJE DE CONFIRMACIÓN -------------------------------------------------------
                        MsgBox("El alumno: " & TxtNombre.Text & " , De facultad: " & CboFacultad.Text & " , Del semestre: " & CboSemestre.Text & " , Con promedio: " & Promedio & " Esta Reprobado ", MsgBoxStyle.OkOnly, "Promedio")
                        '------------------------------------------------------------------------------------------------------------------------
                    Else
                        '---------------------------------------- MENSAJE DE CONFIRMACIÓN -------------------------------------------------------
                        MsgBox("Número invalido ingresa información correcta", MsgBoxStyle.OkOnly, "Promedio")
                        '------------------------------------------------------------------------------------------------------------------------
                    End If

                End If
            End If



        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub


    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub




    Private Sub Limpiar()
        CboFacultad.Text = "Selecciona Facultad"
        TxtNombre.Clear()
        CboSemestre.Text = "Selecciona Semestre"
        TxtP1.Clear()
        TxtP2.Clear()
        TxtP3.Clear()
        TxtP4.Clear()
        TxtPromedio.Clear()
    End Sub

    Private Sub CboFacultad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboSemestre.KeyPress, CboFacultad.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TxtP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtP4.KeyPress, TxtP3.KeyPress, TxtP2.KeyPress, TxtP1.KeyPress, TxtExp.KeyPress, MyBase.KeyPress
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
End Class