Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class SQLConexion

    Private conexion As SqlConnection

    Private Sub Conectar(ByVal strSIGEconexion As String)

        Try
            conexion = New SqlConnection(strSIGEconexion)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetConeccion(ByVal strSIGEConexion As String) As SqlConnection
        Conectar(strSIGEConexion)
        Return conexion
    End Function

End Class
