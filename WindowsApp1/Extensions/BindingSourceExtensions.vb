Public Module BindingSourceExtensions
    <Runtime.CompilerServices.Extension>
    Public Function Reposition(
        ByVal pBindingSource As BindingSource,
        ByVal pColumnName As String,
        ByVal pValue As Object) As Boolean

        Dim index As Integer = pBindingSource.Find(pColumnName, pValue)

        If index > -1 Then
            pBindingSource.Position = index
            Return True
        Else
            Return False
        End If

    End Function
End Module
