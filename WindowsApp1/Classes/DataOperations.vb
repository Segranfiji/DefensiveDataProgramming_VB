Imports System.Data.SqlClient
Imports WindowsApp1.Classes

Public Class DataItem
    Public Property CustomerIdentifier() As Integer
    Public Property CompanyName() As String
    Public Property ContactName() As String
    Public Property ContactTitle() As String

    Public Overrides Function ToString() As String
        Return $"{CustomerIdentifier} - {CompanyName} - {ContactName} - {ContactTitle}"
    End Function
End Class
Public Class DataOperations
    Inherits BaseSqlServerConnections
    Public Sub SetConnectionString(
        ByVal pDatabaseServer As String,
        ByVal pDefaultCatalog As String)

        DatabaseServer = pDatabaseServer
        DefaultCatalog = pDefaultCatalog

    End Sub
    Public Sub SetCatalog(ByVal pDefaultCatalog As String)
        DefaultCatalog = pDefaultCatalog
    End Sub
    Public Function ColumnNames() As List(Of String)
        Return New List(Of String) From
            {"CustomerIdentifier", "CompanyName", "ContactName", "ContactTitle"}
    End Function
    Public Function CustomerView() As DataTable
        mHasException = False
        mHasSqlException = False

        DefaultCatalog = "NorthWindDemo"
        Dim dt As New DataTable
        Dim selectStatement As String = $"SELECT {String.Join(",", ColumnNames.ToArray)} " &
            "FROM Customers"

        Console.WriteLine(selectStatement)
        Try
            Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
                Console.WriteLine(cn.ConnectionString)
                Using cmd = New SqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.CommandText = selectStatement
                    cn.Open()
                    dt.Load(cmd.ExecuteReader)
                End Using
            End Using

        Catch sex As SqlException
            mHasSqlException = True
            mSqlException = sex
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return dt
    End Function
End Class
