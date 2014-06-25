﻿Public Class FormMain

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

    Private Sub btnEditDataPribadi_Click(sender As Object, e As EventArgs) Handles btnEditDataPribadi.Click
        Model.Database.EditDataPribadi()
    End Sub

    Private Sub btnEditDataKeluarga_Click(sender As Object, e As EventArgs) Handles btnEditDataKeluarga.Click
        Model.Database.EditDataKeluarga()
    End Sub

    Private Sub btnEditPendidikanFormal_Click(sender As Object, e As EventArgs) Handles btnEditPendidikanFormal.Click
        Model.Database.EditPendidikanFormal()
    End Sub

    Private Sub btnEditPendidikanNonFormal_Click(sender As Object, e As EventArgs) Handles btnEditPendidikanNonFormal.Click
        Model.Database.EditPendidikanNonFormal()
    End Sub

    Private Sub btnEditPengalamanKerja_Click(sender As Object, e As EventArgs) Handles btnEditPengalamanKerja.Click
        Model.Database.EditPengalamanKerja()
    End Sub

    Private Sub btnEditDataKarier_Click(sender As Object, e As EventArgs) Handles btnEditDataKarier.Click
        Model.Database.EditKarier()
    End Sub

    Private Sub btnEditDataPenghargaan_Click(sender As Object, e As EventArgs) Handles btnEditDataPenghargaan.Click
        Model.Database.EditPenghargaan()
    End Sub

    Private Sub btnEditDataPunishment_Click(sender As Object, e As EventArgs) Handles btnEditDataPunishment.Click
        Model.Database.EditPunishment()
    End Sub

    Private Sub btnEditRiwayatPenyakit_Click(sender As Object, e As EventArgs) Handles btnEditRiwayatPenyakit.Click
        Model.Database.EditRiwayatPenyakit()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim NIK As String = dataGridPribadi.SelectedCells(0).Value
        Model.Database.HapusDataPribadi(NIK)
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim nama As String = txtSearch.Text
        Model.Database.SearchData(nama)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then txtSearch.Text = vbNullString
    End Sub
End Class