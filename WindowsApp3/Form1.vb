Public Class Form1
    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        Dim dtp = CType(sender, DateTimePicker)
        Console.WriteLine(dtp.Name & " " & dtp.Value.ToString())
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctrl As Control = GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is DateTimePicker Then
                Dim dtp = CType(ctrl, DateTimePicker)
                AddHandler dtp.ValueChanged, AddressOf DateTimePicker_ValueChanged
                If dtp.CustomFormat = "" Then
                    dtp.CustomFormat = "dd-MM-yyyy"
                End If
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) _
        Handles CustomersBindingNavigatorSaveItem.Click

        Validate()
        CustomersBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.NorthWindAzure1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomersTableAdapter.Fill(Me.NorthWindAzure1DataSet.Customers)
        CustomerNameColumn.Tag = "Karen"
    End Sub


End Class
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
        For Each child As Control In control.Controls
            Dim childOfT As T = TryCast(child, T)
            If childOfT IsNot Nothing Then
                Yield CType(childOfT, T)
            End If
            If child.HasChildren Then
                For Each descendant As T In child.Descendants(Of T)()
                    Yield descendant
                Next
            End If
        Next
    End Function
End Module