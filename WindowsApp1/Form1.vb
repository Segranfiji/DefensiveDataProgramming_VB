Public Class Form1
    Private bsCustomers As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(txtFieldName.Text) Then
            bsCustomers.Reposition(cboColumnNames.Text, txtFieldName.Text)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ops As New DataOperations

        bsCustomers.DataSource = ops.CustomerView
        If ops.IsSuccessFul Then
            DataGridView1.DataSource = bsCustomers
            cboColumnNames.DataSource = ops.ColumnNames
        Else
            Button1.Enabled = False
        End If

        Dim columnNames() As String = CType(bsCustomers.DataSource, DataTable).
                Columns.Cast(Of DataColumn).
                Select(Function(c) c.ColumnName).ToArray()

        For Each col As String In columnNames
            Console.WriteLine(col)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataRow = CType(bsCustomers.Current, DataRowView).Row
        Dim dItem = New DataItem _
                With
                {
                    .CustomerIdentifier = row.Field(Of Integer)("CustomerIdentifier"),
                    .CompanyName = row.Field(Of String)("CompanyName"),
                    .ContactName = row.Field(Of String)("ContactName"),
                    .ContactTitle = row.Field(Of String)("ContactTitle")
                }

        Dim f As New Form2(dItem)
        Try
            f.ShowDialog()
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
