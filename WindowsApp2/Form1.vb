Imports System.Data.SqlClient
Imports DataConnections

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ops As New Operations
        CheckBox1.Checked = ops.GetItem(34)
    End Sub
End Class
Public Class Operations
    Inherits BaseSqlServerConnections

    Public Sub New()
        DefaultCatalog = "NorthWindAzure2"
    End Sub
    Public Function GetItem(pIdentifier As Integer) As Boolean
        mHasException = False
        mHasSqlException = False

        Dim dt As New DataTable
        Dim selectStatement As String = $"SELECT InUse FROM dbo.Customers WHERE CustomerIdentifier = @Id "
        Try
            Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
                Using cmd = New SqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.CommandText = selectStatement
                    cmd.Parameters.AddWithValue("@Id", pIdentifier)
                    cn.Open()
                    Return CBool(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            mHasException = True
            mLastException = ex

        End Try

        Return IsSuccessFul

    End Function
End Class


