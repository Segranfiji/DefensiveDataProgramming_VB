Namespace Classes
    Public Class BaseSqlServerConnections
        Inherits BaseExceptionsHandler

        Protected DatabaseServer As String = "KARENS-PC"
        Protected DefaultCatalog As String = ""
        Public ReadOnly Property ConnectionString As String
            Get
                Return $"Data Source={DatabaseServer};" &
                       $"Initial Catalog={DefaultCatalog};Integrated Security=True"
            End Get
        End Property
    End Class
End Namespace