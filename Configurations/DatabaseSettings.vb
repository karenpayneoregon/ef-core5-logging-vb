
''' <summary>
''' Properties for setting up a connection string
''' </summary>
Public Class DatabaseSettings
    ''' <summary>
    ''' SQL-Server server
    ''' </summary>
    Public Property DatabaseServer() As String
    ''' <summary>
    ''' Default catalog
    ''' </summary>
    Public Property Catalog() As String
    ''' <summary>
    ''' User Integrated security
    ''' </summary>
    Public Property IntegratedSecurity() As Boolean
    ''' <summary>
    ''' Where to log for Entity Framework Core
    ''' </summary>
    Public Property LoggingDestination() As LoggingDestination
    ''' <summary>
    ''' Name of Entity Framework Core log file
    ''' </summary>
    Public Property LogFileName() As String
    ''' <summary>
    ''' SQL-Server connection string for Entity Framework Core
    ''' </summary>
    Public ReadOnly Property ConnectionString() As String
        Get
            Return $"Data Source={DatabaseServer};" & $"Initial Catalog={Catalog};" & $"Integrated Security={IntegratedSecurity}"
        End Get
    End Property

End Class