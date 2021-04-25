Imports System.IO
Imports Microsoft.Extensions.Configuration

''' <summary>
''' Responsible for reading appsettings.json properties
''' </summary>
Public Class Helper
    Private Shared _fileName As String = "appsettings.json"

    ''' <summary>
    ''' Connection string for application database stored in appsettings.json
    ''' Another option would be to have the full connection string in the json file.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function ConnectionString() As String

        InitConfiguration()

        Dim applicationSettings = InitOptions(Of DatabaseSettings)("database")
        Return $"Data Source={applicationSettings.DatabaseServer};" & $"Initial Catalog={applicationSettings.Catalog};" & "Integrated Security=True"
    End Function
    ''' <summary>
    ''' Log options
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function LoggingDestination() As LoggingDestination
        InitConfiguration()
        Return InitOptions(Of DatabaseSettings)("database").LoggingDestination
    End Function
    ''' <summary>
    ''' Log file name
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function LogFileName() As String
        InitConfiguration()
        Return InitOptions(Of DatabaseSettings)("database").LogFileName
    End Function
    ''' <summary>
    ''' Initialize ConfigurationBuilder
    ''' </summary>
    ''' <returns>IConfigurationRoot</returns>
    Private Shared Function InitConfiguration() As IConfigurationRoot

        Dim builder = (New ConfigurationBuilder()).SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(_fileName)
        Return builder.Build()

    End Function
    ''' <summary>
    ''' Generic method to read a section from the json configuration file.
    ''' </summary>
    ''' <typeparam name="T">Class type</typeparam>
    ''' <param name="section">Section to read</param>
    ''' <returns>Instance of T</returns>
    Public Shared Function InitOptions(Of T As New)(ByVal section As String) As T

        Dim config = InitConfiguration()
        Return config.GetSection(section).Get(Of T)()

    End Function
End Class