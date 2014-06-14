Public Class FormDataPribadi

    Friend Sub ResetFormPribadi()
        Me.txtNIK.Text = vbNullString
        Me.txtNamaLengkap.Text = vbNullString
        Me.txtTempatLahir.Text = vbNullString
        Me.dateTanggalLahir.Value = New Date(1990, 1, 1)
        Me.txtSuku.Text = vbNullString
        Me.comboAgama.Text = vbNullString
        Me.comboJK.Text = vbNullString
        Me.comboKawin.Text = vbNullString
        Me.txtAlamat.Text = vbNullString
        Me.txtStatusRumah.Text = vbNullString
        Me.txtHP.Text = vbNullString
        Me.txtNoIdentitas.Text = vbNullString
        Me.txtJabatan.Text = vbNullString
        Me.datePengangkatan.Value = New Date(2000, 1, 1)
        Me.comboStatusPegawai.Text = vbNullString
        Me.comboDepartemen.Text = vbNullString
        Me.txtSubDepartemen.Text = vbNullString
        Me.txtMutasi.Text = vbNullString
        Me.txtAlasanMutasi.Text = vbNullString
        Me.comboDarah.Text = vbNullString
        Me.pictKTP.ImageLocation = vbNullString
        Me.lblFilename.Text = vbNullString
    End Sub

    'set properties untuk OpenFIleDialog
    Friend Sub SetOFD()
        ofd.Title = "Browse file KTP"
        ofd.Filter = "Type(*.jpg, *.jpeg, *.bmp, *.png)|*.jpg; *.jpeg; *.bmp; *.png"
        ofd.Multiselect = False
        ofd.FileName = vbNullString
    End Sub

    Private Sub FormDataPribadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFormPribadi()
        SetOFD()
        Koneksi.Hubungkan()
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Menampilkan gambar ke dalam picture box
            pictKTP.ImageLocation = ofd.FileName
            lblFilename.Text = ofd.FileName
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnTest_Click(sender As Object, e As EventArgs)
        Koneksi.Hubungkan()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFormPribadi()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim NIK As String = txtNIK.Text
        Dim namaLengkap As String = txtNamaLengkap.Text
        Dim tempatLahir As String = txtTempatLahir.Text
        Dim tglLahir As Date = dateTanggalLahir.Value
        Dim agama As String = comboAgama.Text
        Dim suku As String = txtSuku.Text

        Dim jenisKelamin As String = vbNullString
        If (comboJK.Text = "Laki-Laki") Then
            jenisKelamin = "L"
        ElseIf (comboJK.Text = "Perempuan") Then
            jenisKelamin = "P"
        End If

        Dim statusKawin As Byte = 0
        If (comboKawin.Text = "Kawin") Then
            statusKawin = 0
        ElseIf (comboKawin.Text = "Belum Kawin") Then
            statusKawin = 1
        End If

        Dim alamat As String = txtAlamat.Text
        Dim statusRumah As String = txtStatusRumah.Text
        Dim telepon As String = txtHP.Text
        Dim identitas As String = txtNoIdentitas.Text
        Dim jabatan As String = txtJabatan.Text
        Dim pengangkatan As Date = datePengangkatan.Value
        Dim statusPegawai As String = comboStatusPegawai.Text
        Dim departemen As String = comboDepartemen.Text
        Dim subDepartemen As String = txtSubDepartemen.Text
        Dim mutasi As String = txtMutasi.Text
        Dim alasanMutasi As String = txtAlasanMutasi.Text
        Dim golDarah As String = comboDarah.Text
        Dim pathKTP As String = lblFilename.Text
        Model.Database.InsertDataPribadi(NIK, namaLengkap, tempatLahir, tglLahir.ToString("yyyy-MM-dd"), agama, suku, alamat, statusRumah, telepon, identitas, jenisKelamin, statusKawin, jabatan, pengangkatan.ToString("yyyy-MM-dd"), statusPegawai, departemen, subDepartemen, mutasi, alasanMutasi, golDarah, pathKTP)
    End Sub
End Class