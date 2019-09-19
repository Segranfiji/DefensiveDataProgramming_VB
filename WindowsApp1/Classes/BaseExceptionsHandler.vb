Imports System.Data.SqlClient

Public Class BaseExceptionsHandler

    Protected mHasException As Boolean
    Public ReadOnly Property HasException() As Boolean
        Get
            Return mHasException
        End Get
    End Property
    Protected mHasSqlException As Boolean
    Public ReadOnly Property HasSqlException() As Boolean
        Get
            Return mHasSqlException
        End Get
    End Property
    Protected mSqlException As SqlException
    Public ReadOnly Property LastSqlException() As SqlException
        Get
            Return mSqlException
        End Get
    End Property
    Protected mLastException As Exception
    Public ReadOnly Property LastException() As Exception
        Get
            Return mLastException
        End Get
    End Property
    Public ReadOnly Property LastExceptionMessage As String
        Get
            Return mLastException.Message
        End Get
    End Property
    Public ReadOnly Property IsSuccessFul As Boolean
        Get
            Return Not mHasException OrElse Not mHasSqlException
        End Get
    End Property
End Class
