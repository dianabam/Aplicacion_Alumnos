Imports System.Data
Imports System.Data.OleDb


Module ConexionAccess
    Public Ruta As String = Application.StartupPath
    Public Conexion As New OleDbConnection

    Sub Enlace()
        Try
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Ruta + "\Base_de_datos\Base principal.accdb"
            Conexion.Open()


        Catch ex As Exception

            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------

        End Try
    End Sub
End Module
