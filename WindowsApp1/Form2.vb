Public Class Form2
    Private Property DataItem() As DataItem
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(pDataItem As DataItem)
        InitializeComponent()
        DataItem = pDataItem
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(DataItem.ToString())
    End Sub
End Class