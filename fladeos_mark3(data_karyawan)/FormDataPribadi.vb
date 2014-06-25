Public Class FormDataPribadi

    Public _NIK As String
    Public _nama As String

    'Function untuk reset data form pribadi
    Friend Sub ResetFormPribadi()
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
        Me.txtFileName.Text = vbNullString
    End Sub

    'set properties untuk OpenFIleDialog
    Friend Sub SetOFD()
        ofd.Title = "Browse file KTP"
        ofd.Filter = "Type(*.jpg, *.jpeg, *.bmp, *.png)|*.jpg; *.jpeg; *.bmp; *.png"
        ofd.Multiselect = False
        ofd.FileName = vbNullString
    End Sub

    'Function ketika formdatapribadi di Load
    Private Sub FormDataPribadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFormPribadi()
        SetOFD()
        Koneksi.Hubungkan()
        Me.btnUpdate.Enabled = False
    End Sub

    'Function untuk tampilkan Open File Dialog
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Menampilkan gambar ke dalam picture box
            pictKTP.ImageLocation = ofd.FileName
            txtFileName.Text = ofd.FileName
        End If
    End Sub

    'Function untuk tombol Reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFormPribadi()
    End Sub

    'Function ketika tombol submit di klik
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

        Dim pathKTP = System.IO.Path.GetFullPath(txtFileName.Text)

        If (txtNIK.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi NIK!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtNamaLengkap.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Nama Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboJK.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Jenis Kelamin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboKawin.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Status Perkawinan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtNoIdentitas.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Nomor Identitas!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtJabatan.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Jabatan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (datePengangkatan.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Tanggal Pengangkatan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboStatusPegawai.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Status Pegawai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboDepartemen.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Departemen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Model.Database.InsertDataPribadi(NIK, namaLengkap, tempatLahir, tglLahir.ToString("yyyy-MM-dd"), agama, suku, alamat, statusRumah, telepon, identitas, jenisKelamin, statusKawin, jabatan, pengangkatan.ToString("yyyy-MM-dd"), statusPegawai, departemen, subDepartemen, mutasi, alasanMutasi, golDarah, pathKTP)
        End If
    End Sub

    'Function untuk tombol Update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        
        Dim pathKTP = System.IO.Path.GetFullPath(txtFileName.Text)

        If (txtNIK.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi NIK!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtNamaLengkap.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Nama Lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboJK.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Jenis Kelamin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboKawin.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Status Perkawinan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtNoIdentitas.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Nomor Identitas!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtJabatan.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Jabatan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (datePengangkatan.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Tanggal Pengangkatan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboStatusPegawai.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Status Pegawai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (comboDepartemen.Text = vbNullString) Then
            MessageBox.Show("Silahkan isi Departemen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Model.Database.UpdateDataPribadi(NIK, namaLengkap, tempatLahir, tglLahir.ToString("yyyy-MM-dd"), agama, suku, alamat, statusRumah, telepon, identitas, jenisKelamin, statusKawin, jabatan, pengangkatan.ToString("yyyy-MM-dd"), statusPegawai, departemen, subDepartemen, mutasi, alasanMutasi, golDarah, pathKTP)
        End If
        Model.Database.BrowseDataPribadi()
    End Sub

End Class