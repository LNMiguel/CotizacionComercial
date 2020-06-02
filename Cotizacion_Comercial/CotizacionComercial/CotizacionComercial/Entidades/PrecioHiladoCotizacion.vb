Imports System.Data
Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PrecioHiladoCotizacion
    Dim SIGEConexion As String
    Dim Valores() As String

    Public Sub New(ByVal strSIGEconexion As String)
        MyBase.New
        Me.SIGEConexion = strSIGEconexion
    End Sub

    'Public Sub PrecioHiladoCotizacion(strSIGEconexion As String)
    '    SIGEConexion = strSIGEconexion
    'End Sub

    Public Function CargaCombos(ByVal Parametros() As Object) As DataTable
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

    Public Function RegistraPrecio_Hilado(ByVal Parametros() As Object) As Boolean
        Dim result As Boolean = False
        Try
            Dim command As SqlCommand = New SqlCommand
            command.Connection = New SQLConexion().GetConeccion(SIGEConexion)
            command.CommandTimeout = 900000
            command.CommandText = Parametros(0).ToString
            command.CommandType = System.Data.CommandType.StoredProcedure
            command.Connection.Open()
            SqlCommandBuilder.DeriveParameters(command)
            Dim i As Integer = 1
            Do While (i < Parametros.Length)
                command.Parameters(i).Value = Parametros(i)
                i = (i + 1)
            Loop

            command.ExecuteNonQuery()
            'Valores = New String((1) - 1) {}
            'Valores(0) = command.Parameters("@P_MSJ").Value.ToString
            result = True
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'throw;
        End Try

        Return result
    End Function

    Public Function MuestraDetallePrecios(ByVal Parametros() As Object) As DataTable
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

End Class
