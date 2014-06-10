Public Class FormDataPribadi

    Friend Sub ResetForm()
        pictKTP.Image = Nothing
    End Sub

    'set properties untuk OpenFIleDialog
    Friend Sub SetOFD()
        ofd.Title = "Browse file KTP"
        ofd.Filter = "Type(*.jpg, *.jpeg, *.bmp, *.png)|*.jpg; *.jpeg; *.bmp; *.png"
        ofd.Multiselect = False
    End Sub

    Private Sub FormDataPribadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        SetOFD()
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


End Class