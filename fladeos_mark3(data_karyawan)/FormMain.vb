Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Model.Database.BrowseDataPribadi()
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        FormDataPribadi.Visible = True
    End Sub

    Private Sub dataGridPribadi_DoubleClick(sender As Object, e As EventArgs) Handles dataGridPribadi.DoubleClick
        Model.Database.GetNama()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Model.Database.BrowseDataPribadi()
    End Sub
End Class