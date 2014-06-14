<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.dataGridPribadi = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDataPribadiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEditRiwayatPenyakit = New System.Windows.Forms.Button()
        Me.btnEditDataPunishment = New System.Windows.Forms.Button()
        Me.btnEditDataPenghargaan = New System.Windows.Forms.Button()
        Me.btnEditDataKarier = New System.Windows.Forms.Button()
        Me.btnEditPengalamanKerja = New System.Windows.Forms.Button()
        Me.btnEditPendidikanNonFormal = New System.Windows.Forms.Button()
        Me.btnEditPendidikanFormal = New System.Windows.Forms.Button()
        Me.btnEditDataKeluarga = New System.Windows.Forms.Button()
        Me.btnEditDataPribadi = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dataGridPribadi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 42)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "+Data Baru"
        '
        'dataGridPribadi
        '
        Me.dataGridPribadi.AllowUserToAddRows = False
        Me.dataGridPribadi.AllowUserToDeleteRows = False
        Me.dataGridPribadi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridPribadi.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridPribadi.Location = New System.Drawing.Point(21, 67)
        Me.dataGridPribadi.Name = "dataGridPribadi"
        Me.dataGridPribadi.ReadOnly = True
        Me.dataGridPribadi.Size = New System.Drawing.Size(1112, 630)
        Me.dataGridPribadi.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1058, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(860, 35)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(192, 20)
        Me.tbSearch.TabIndex = 4
        '
        'lblNIK
        '
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIK.Location = New System.Drawing.Point(1150, 133)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(0, 20)
        Me.lblNIK.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1150, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "NIK"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(1150, 88)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(0, 20)
        Me.lblNama.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1150, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDetail)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(1149, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 81)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnDetail
        '
        Me.btnDetail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDetail.Location = New System.Drawing.Point(6, 50)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(135, 23)
        Me.btnDetail.TabIndex = 15
        Me.btnDetail.Text = "Detail"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHapus.Location = New System.Drawing.Point(6, 21)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(135, 23)
        Me.btnHapus.TabIndex = 14
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1340, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDataPribadiToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditDataPribadiToolStripMenuItem
        '
        Me.EditDataPribadiToolStripMenuItem.Name = "EditDataPribadiToolStripMenuItem"
        Me.EditDataPribadiToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EditDataPribadiToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisVersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'AboutThisVersionToolStripMenuItem
        '
        Me.AboutThisVersionToolStripMenuItem.Name = "AboutThisVersionToolStripMenuItem"
        Me.AboutThisVersionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AboutThisVersionToolStripMenuItem.Text = "About This Version"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ContactUsToolStripMenuItem.Text = "&Contact Us"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEditRiwayatPenyakit)
        Me.GroupBox2.Controls.Add(Me.btnEditDataPunishment)
        Me.GroupBox2.Controls.Add(Me.btnEditDataPenghargaan)
        Me.GroupBox2.Controls.Add(Me.btnEditDataKarier)
        Me.GroupBox2.Controls.Add(Me.btnEditPengalamanKerja)
        Me.GroupBox2.Controls.Add(Me.btnEditPendidikanNonFormal)
        Me.GroupBox2.Controls.Add(Me.btnEditPendidikanFormal)
        Me.GroupBox2.Controls.Add(Me.btnEditDataKeluarga)
        Me.GroupBox2.Controls.Add(Me.btnEditDataPribadi)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(1149, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 285)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit"
        '
        'btnEditRiwayatPenyakit
        '
        Me.btnEditRiwayatPenyakit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRiwayatPenyakit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditRiwayatPenyakit.Location = New System.Drawing.Point(6, 253)
        Me.btnEditRiwayatPenyakit.Name = "btnEditRiwayatPenyakit"
        Me.btnEditRiwayatPenyakit.Size = New System.Drawing.Size(135, 23)
        Me.btnEditRiwayatPenyakit.TabIndex = 22
        Me.btnEditRiwayatPenyakit.Text = "Riwayat Penyakit"
        Me.btnEditRiwayatPenyakit.UseVisualStyleBackColor = True
        '
        'btnEditDataPunishment
        '
        Me.btnEditDataPunishment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDataPunishment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditDataPunishment.Location = New System.Drawing.Point(5, 224)
        Me.btnEditDataPunishment.Name = "btnEditDataPunishment"
        Me.btnEditDataPunishment.Size = New System.Drawing.Size(135, 23)
        Me.btnEditDataPunishment.TabIndex = 21
        Me.btnEditDataPunishment.Text = "Data Punishment"
        Me.btnEditDataPunishment.UseVisualStyleBackColor = True
        '
        'btnEditDataPenghargaan
        '
        Me.btnEditDataPenghargaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDataPenghargaan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditDataPenghargaan.Location = New System.Drawing.Point(5, 195)
        Me.btnEditDataPenghargaan.Name = "btnEditDataPenghargaan"
        Me.btnEditDataPenghargaan.Size = New System.Drawing.Size(135, 23)
        Me.btnEditDataPenghargaan.TabIndex = 20
        Me.btnEditDataPenghargaan.Text = "Data Penghargaan"
        Me.btnEditDataPenghargaan.UseVisualStyleBackColor = True
        '
        'btnEditDataKarier
        '
        Me.btnEditDataKarier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDataKarier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditDataKarier.Location = New System.Drawing.Point(6, 166)
        Me.btnEditDataKarier.Name = "btnEditDataKarier"
        Me.btnEditDataKarier.Size = New System.Drawing.Size(135, 23)
        Me.btnEditDataKarier.TabIndex = 19
        Me.btnEditDataKarier.Text = "Data Karier"
        Me.btnEditDataKarier.UseVisualStyleBackColor = True
        '
        'btnEditPengalamanKerja
        '
        Me.btnEditPengalamanKerja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPengalamanKerja.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditPengalamanKerja.Location = New System.Drawing.Point(6, 137)
        Me.btnEditPengalamanKerja.Name = "btnEditPengalamanKerja"
        Me.btnEditPengalamanKerja.Size = New System.Drawing.Size(135, 23)
        Me.btnEditPengalamanKerja.TabIndex = 18
        Me.btnEditPengalamanKerja.Text = "Pengalaman Kerja"
        Me.btnEditPengalamanKerja.UseVisualStyleBackColor = True
        '
        'btnEditPendidikanNonFormal
        '
        Me.btnEditPendidikanNonFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPendidikanNonFormal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditPendidikanNonFormal.Location = New System.Drawing.Point(6, 108)
        Me.btnEditPendidikanNonFormal.Name = "btnEditPendidikanNonFormal"
        Me.btnEditPendidikanNonFormal.Size = New System.Drawing.Size(135, 23)
        Me.btnEditPendidikanNonFormal.TabIndex = 17
        Me.btnEditPendidikanNonFormal.Text = "Pendidikan non-Formal"
        Me.btnEditPendidikanNonFormal.UseVisualStyleBackColor = True
        '
        'btnEditPendidikanFormal
        '
        Me.btnEditPendidikanFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPendidikanFormal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditPendidikanFormal.Location = New System.Drawing.Point(6, 79)
        Me.btnEditPendidikanFormal.Name = "btnEditPendidikanFormal"
        Me.btnEditPendidikanFormal.Size = New System.Drawing.Size(135, 23)
        Me.btnEditPendidikanFormal.TabIndex = 16
        Me.btnEditPendidikanFormal.Text = "Pendidikan Formal"
        Me.btnEditPendidikanFormal.UseVisualStyleBackColor = True
        '
        'btnEditDataKeluarga
        '
        Me.btnEditDataKeluarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDataKeluarga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditDataKeluarga.Location = New System.Drawing.Point(6, 50)
        Me.btnEditDataKeluarga.Name = "btnEditDataKeluarga"
        Me.btnEditDataKeluarga.Size = New System.Drawing.Size(135, 23)
        Me.btnEditDataKeluarga.TabIndex = 15
        Me.btnEditDataKeluarga.Text = "Data Keluarga"
        Me.btnEditDataKeluarga.UseVisualStyleBackColor = True
        '
        'btnEditDataPribadi
        '
        Me.btnEditDataPribadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDataPribadi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditDataPribadi.Location = New System.Drawing.Point(6, 21)
        Me.btnEditDataPribadi.Name = "btnEditDataPribadi"
        Me.btnEditDataPribadi.Size = New System.Drawing.Size(135, 23)
        Me.btnEditDataPribadi.TabIndex = 14
        Me.btnEditDataPribadi.Text = "Data Pribadi"
        Me.btnEditDataPribadi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1154, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Refresh Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1350, 710)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblNIK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.dataGridPribadi)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Text = "Sistem Informasi Data Karyawan TTN v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataGridPribadi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents dataGridPribadi As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblNIK As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDataPribadiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutThisVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditDataKeluarga As System.Windows.Forms.Button
    Friend WithEvents btnEditDataPribadi As System.Windows.Forms.Button
    Friend WithEvents btnEditRiwayatPenyakit As System.Windows.Forms.Button
    Friend WithEvents btnEditDataPunishment As System.Windows.Forms.Button
    Friend WithEvents btnEditDataPenghargaan As System.Windows.Forms.Button
    Friend WithEvents btnEditDataKarier As System.Windows.Forms.Button
    Friend WithEvents btnEditPengalamanKerja As System.Windows.Forms.Button
    Friend WithEvents btnEditPendidikanNonFormal As System.Windows.Forms.Button
    Friend WithEvents btnEditPendidikanFormal As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
