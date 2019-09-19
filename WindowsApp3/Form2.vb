Public Class Form2
    Private mainForm As Form1
    Public Sub New(pForm As Form1)
        InitializeComponent()
        mainForm = pForm
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(mainForm.CustomerNameColumn.Tag.ToString())
    End Sub
End Class