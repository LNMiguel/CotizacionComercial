Imports System.Data
Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Busqueda
    Dim SIGEConexion As String
    Dim Valores() As String

    Public Sub New(ByVal strSIGEconexion As String)
        MyBase.New
        Me.SIGEConexion = strSIGEconexion
    End Sub

    Public Function MuestraDatos(ByVal Parametros() As Object) As DataTable
        Dim result As DataTable = New DataTable
        Try
            Dim command As SqlCommand = New SqlCommand
            command.Connection = New SQLConexion().GetConeccion(SIGEConexion)
            command.CommandText = Parametros(0).ToString
            command.CommandType = System.Data.CommandType.StoredProcedure
            command.Connection.Open()
            SqlCommandBuilder.DeriveParameters(command)
            Dim i As Integer = 1
            Do While (i < Parametros.Length)
                command.Parameters(i).Value = Parametros(i)
                i = (i + 1)
            Loop

            Dim dataReader As SqlDataReader = command.ExecuteReader
            result.Load(dataReader)
            dataReader.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return result
    End Function

    Public Function ObtenerDataTable(ByVal comandoSQL As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim da As SqlDataAdapter = Nothing
        Try
            dt = New DataTable
            'Conectar
            da = New SqlDataAdapter
            da.SelectCommand = New SqlCommand(comandoSQL)
            da.SelectCommand.Connection = New SQLConexion().GetConeccion(SIGEConexion)
            da.SelectCommand.CommandType = System.Data.CommandType.Text
            da.Fill(dt)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

End Class
