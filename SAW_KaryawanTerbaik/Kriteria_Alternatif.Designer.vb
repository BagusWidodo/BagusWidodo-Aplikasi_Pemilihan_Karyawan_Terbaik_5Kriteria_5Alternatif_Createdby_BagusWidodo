<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kriteria_Alternatif
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.txt_alternatif = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_count_alternatif = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id_alternatif = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_c1 = New System.Windows.Forms.TextBox()
        Me.txt_c2 = New System.Windows.Forms.TextBox()
        Me.txt_c3 = New System.Windows.Forms.TextBox()
        Me.txt_c4 = New System.Windows.Forms.TextBox()
        Me.txt_c5 = New System.Windows.Forms.TextBox()
        Me.lbl_c5 = New System.Windows.Forms.Label()
        Me.lbl_c4 = New System.Windows.Forms.Label()
        Me.lbl_c3 = New System.Windows.Forms.Label()
        Me.lbl_c2 = New System.Windows.Forms.Label()
        Me.lbl_c1 = New System.Windows.Forms.Label()
        Me.lbl_nama_alternatif = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_penilaian = New System.Windows.Forms.ComboBox()
        Me.DGV3 = New System.Windows.Forms.DataGridView()
        Me.btn_caripembanding = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.lbl_nilai_c1 = New System.Windows.Forms.Label()
        Me.lbl_nilai_c2 = New System.Windows.Forms.Label()
        Me.lbl_nilai_c3 = New System.Windows.Forms.Label()
        Me.lbl_nilai_c4 = New System.Windows.Forms.Label()
        Me.lbl_nilai_c5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV2
        '
        Me.DGV2.BackgroundColor = System.Drawing.Color.White
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(22, 321)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(569, 162)
        Me.DGV2.TabIndex = 8
        Me.DGV2.Visible = False
        '
        'txt_alternatif
        '
        Me.txt_alternatif.Location = New System.Drawing.Point(147, 45)
        Me.txt_alternatif.Name = "txt_alternatif"
        Me.txt_alternatif.Size = New System.Drawing.Size(141, 23)
        Me.txt_alternatif.TabIndex = 4
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.Color.White
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(349, 84)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(242, 190)
        Me.DGV1.TabIndex = 9
        Me.DGV1.Visible = False
        '
        'btn_hitung
        '
        Me.btn_hitung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hitung.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hitung.Location = New System.Drawing.Point(208, 286)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(91, 26)
        Me.btn_hitung.TabIndex = 7
        Me.btn_hitung.Text = "HITUNG"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_keluar.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(223, 111)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(65, 28)
        Me.btn_keluar.TabIndex = 2
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_alternatif)
        Me.GroupBox1.Controls.Add(Me.lbl_count_alternatif)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_id_alternatif)
        Me.GroupBox1.Controls.Add(Me.btn_keluar)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.txt_c1)
        Me.GroupBox1.Controls.Add(Me.txt_c2)
        Me.GroupBox1.Controls.Add(Me.txt_c3)
        Me.GroupBox1.Controls.Add(Me.txt_c4)
        Me.GroupBox1.Controls.Add(Me.txt_c5)
        Me.GroupBox1.Controls.Add(Me.lbl_c5)
        Me.GroupBox1.Controls.Add(Me.lbl_c4)
        Me.GroupBox1.Controls.Add(Me.lbl_c3)
        Me.GroupBox1.Controls.Add(Me.lbl_c2)
        Me.GroupBox1.Controls.Add(Me.lbl_c1)
        Me.GroupBox1.Controls.Add(Me.lbl_nama_alternatif)
        Me.GroupBox1.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 250)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KRITERIA - ALTERNATIF"
        '
        'lbl_count_alternatif
        '
        Me.lbl_count_alternatif.AutoSize = True
        Me.lbl_count_alternatif.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count_alternatif.Location = New System.Drawing.Point(273, 19)
        Me.lbl_count_alternatif.Name = "lbl_count_alternatif"
        Me.lbl_count_alternatif.Size = New System.Drawing.Size(15, 17)
        Me.lbl_count_alternatif.TabIndex = 0
        Me.lbl_count_alternatif.Text = "0"
        Me.lbl_count_alternatif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alternatif = "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_id_alternatif
        '
        Me.lbl_id_alternatif.AutoSize = True
        Me.lbl_id_alternatif.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_alternatif.Location = New System.Drawing.Point(30, 23)
        Me.lbl_id_alternatif.Name = "lbl_id_alternatif"
        Me.lbl_id_alternatif.Size = New System.Drawing.Size(0, 17)
        Me.lbl_id_alternatif.TabIndex = 0
        Me.lbl_id_alternatif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_id_alternatif.Visible = False
        '
        'btn_simpan
        '
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(223, 76)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(65, 28)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_c1
        '
        Me.txt_c1.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c1.Location = New System.Drawing.Point(147, 78)
        Me.txt_c1.Name = "txt_c1"
        Me.txt_c1.Size = New System.Drawing.Size(66, 23)
        Me.txt_c1.TabIndex = 1
        '
        'txt_c2
        '
        Me.txt_c2.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c2.Location = New System.Drawing.Point(147, 111)
        Me.txt_c2.Name = "txt_c2"
        Me.txt_c2.Size = New System.Drawing.Size(66, 23)
        Me.txt_c2.TabIndex = 1
        '
        'txt_c3
        '
        Me.txt_c3.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c3.Location = New System.Drawing.Point(147, 144)
        Me.txt_c3.Name = "txt_c3"
        Me.txt_c3.Size = New System.Drawing.Size(66, 23)
        Me.txt_c3.TabIndex = 1
        '
        'txt_c4
        '
        Me.txt_c4.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c4.Location = New System.Drawing.Point(147, 178)
        Me.txt_c4.Name = "txt_c4"
        Me.txt_c4.Size = New System.Drawing.Size(66, 23)
        Me.txt_c4.TabIndex = 1
        '
        'txt_c5
        '
        Me.txt_c5.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c5.Location = New System.Drawing.Point(147, 212)
        Me.txt_c5.Name = "txt_c5"
        Me.txt_c5.Size = New System.Drawing.Size(66, 23)
        Me.txt_c5.TabIndex = 1
        '
        'lbl_c5
        '
        Me.lbl_c5.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_c5.Location = New System.Drawing.Point(30, 212)
        Me.lbl_c5.Name = "lbl_c5"
        Me.lbl_c5.Size = New System.Drawing.Size(111, 23)
        Me.lbl_c5.TabIndex = 0
        Me.lbl_c5.Text = "Bobot C5"
        Me.lbl_c5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_c4
        '
        Me.lbl_c4.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_c4.Location = New System.Drawing.Point(30, 178)
        Me.lbl_c4.Name = "lbl_c4"
        Me.lbl_c4.Size = New System.Drawing.Size(111, 23)
        Me.lbl_c4.TabIndex = 0
        Me.lbl_c4.Text = "Bobot C4"
        Me.lbl_c4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_c3
        '
        Me.lbl_c3.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_c3.Location = New System.Drawing.Point(30, 144)
        Me.lbl_c3.Name = "lbl_c3"
        Me.lbl_c3.Size = New System.Drawing.Size(111, 23)
        Me.lbl_c3.TabIndex = 0
        Me.lbl_c3.Text = "Bobot C3"
        Me.lbl_c3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_c2
        '
        Me.lbl_c2.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_c2.Location = New System.Drawing.Point(30, 111)
        Me.lbl_c2.Name = "lbl_c2"
        Me.lbl_c2.Size = New System.Drawing.Size(111, 23)
        Me.lbl_c2.TabIndex = 0
        Me.lbl_c2.Text = "Bobot C2"
        Me.lbl_c2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_c1
        '
        Me.lbl_c1.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_c1.Location = New System.Drawing.Point(30, 78)
        Me.lbl_c1.Name = "lbl_c1"
        Me.lbl_c1.Size = New System.Drawing.Size(111, 23)
        Me.lbl_c1.TabIndex = 0
        Me.lbl_c1.Text = "Bobot C1"
        Me.lbl_c1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nama_alternatif
        '
        Me.lbl_nama_alternatif.AutoSize = True
        Me.lbl_nama_alternatif.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_alternatif.Location = New System.Drawing.Point(30, 48)
        Me.lbl_nama_alternatif.Name = "lbl_nama_alternatif"
        Me.lbl_nama_alternatif.Size = New System.Drawing.Size(96, 17)
        Me.lbl_nama_alternatif.TabIndex = 0
        Me.lbl_nama_alternatif.Text = "Nama Alternatif"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_penilaian)
        Me.GroupBox2.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(349, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 54)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JENIS PENILAIAN"
        '
        'cb_penilaian
        '
        Me.cb_penilaian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_penilaian.FormattingEnabled = True
        Me.cb_penilaian.Location = New System.Drawing.Point(6, 20)
        Me.cb_penilaian.Name = "cb_penilaian"
        Me.cb_penilaian.Size = New System.Drawing.Size(230, 25)
        Me.cb_penilaian.TabIndex = 11
        '
        'DGV3
        '
        Me.DGV3.BackgroundColor = System.Drawing.Color.White
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.Location = New System.Drawing.Point(22, 491)
        Me.DGV3.Name = "DGV3"
        Me.DGV3.Size = New System.Drawing.Size(569, 82)
        Me.DGV3.TabIndex = 8
        Me.DGV3.Visible = False
        '
        'btn_caripembanding
        '
        Me.btn_caripembanding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_caripembanding.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_caripembanding.Location = New System.Drawing.Point(22, 286)
        Me.btn_caripembanding.Name = "btn_caripembanding"
        Me.btn_caripembanding.Size = New System.Drawing.Size(180, 26)
        Me.btn_caripembanding.TabIndex = 7
        Me.btn_caripembanding.Text = "CARI NILAI PEMBANDING"
        Me.btn_caripembanding.UseVisualStyleBackColor = True
        Me.btn_caripembanding.Visible = False
        '
        'btn_next
        '
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(305, 286)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(91, 26)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "NEXT"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'lbl_nilai_c1
        '
        Me.lbl_nilai_c1.AutoSize = True
        Me.lbl_nilai_c1.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nilai_c1.Location = New System.Drawing.Point(1003, 447)
        Me.lbl_nilai_c1.Name = "lbl_nilai_c1"
        Me.lbl_nilai_c1.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nilai_c1.TabIndex = 0
        Me.lbl_nilai_c1.Text = "Bobot C1"
        Me.lbl_nilai_c1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nilai_c1.Visible = False
        '
        'lbl_nilai_c2
        '
        Me.lbl_nilai_c2.AutoSize = True
        Me.lbl_nilai_c2.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nilai_c2.Location = New System.Drawing.Point(1003, 477)
        Me.lbl_nilai_c2.Name = "lbl_nilai_c2"
        Me.lbl_nilai_c2.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nilai_c2.TabIndex = 0
        Me.lbl_nilai_c2.Text = "Bobot C2"
        Me.lbl_nilai_c2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nilai_c2.Visible = False
        '
        'lbl_nilai_c3
        '
        Me.lbl_nilai_c3.AutoSize = True
        Me.lbl_nilai_c3.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nilai_c3.Location = New System.Drawing.Point(1003, 502)
        Me.lbl_nilai_c3.Name = "lbl_nilai_c3"
        Me.lbl_nilai_c3.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nilai_c3.TabIndex = 0
        Me.lbl_nilai_c3.Text = "Bobot C3"
        Me.lbl_nilai_c3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nilai_c3.Visible = False
        '
        'lbl_nilai_c4
        '
        Me.lbl_nilai_c4.AutoSize = True
        Me.lbl_nilai_c4.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nilai_c4.Location = New System.Drawing.Point(1003, 528)
        Me.lbl_nilai_c4.Name = "lbl_nilai_c4"
        Me.lbl_nilai_c4.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nilai_c4.TabIndex = 0
        Me.lbl_nilai_c4.Text = "Bobot C4"
        Me.lbl_nilai_c4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nilai_c4.Visible = False
        '
        'lbl_nilai_c5
        '
        Me.lbl_nilai_c5.AutoSize = True
        Me.lbl_nilai_c5.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nilai_c5.Location = New System.Drawing.Point(1003, 556)
        Me.lbl_nilai_c5.Name = "lbl_nilai_c5"
        Me.lbl_nilai_c5.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nilai_c5.TabIndex = 0
        Me.lbl_nilai_c5.Text = "Bobot C5"
        Me.lbl_nilai_c5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nilai_c5.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(402, 287)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(189, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Timer1
        '
        '
        'Kriteria_Alternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 592)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_caripembanding)
        Me.Controls.Add(Me.DGV3)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_nilai_c5)
        Me.Controls.Add(Me.lbl_nilai_c4)
        Me.Controls.Add(Me.lbl_nilai_c3)
        Me.Controls.Add(Me.lbl_nilai_c2)
        Me.Controls.Add(Me.lbl_nilai_c1)
        Me.Name = "Kriteria_Alternatif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kriteria_Alternatif"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_alternatif As System.Windows.Forms.TextBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_c1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_c2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_c3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_c4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_c5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_c5 As System.Windows.Forms.Label
    Friend WithEvents lbl_c4 As System.Windows.Forms.Label
    Friend WithEvents lbl_c3 As System.Windows.Forms.Label
    Friend WithEvents lbl_c2 As System.Windows.Forms.Label
    Friend WithEvents lbl_c1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nama_alternatif As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_penilaian As System.Windows.Forms.ComboBox
    Friend WithEvents DGV3 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_caripembanding As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents lbl_nilai_c1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nilai_c2 As System.Windows.Forms.Label
    Friend WithEvents lbl_nilai_c3 As System.Windows.Forms.Label
    Friend WithEvents lbl_nilai_c4 As System.Windows.Forms.Label
    Friend WithEvents lbl_nilai_c5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_count_alternatif As System.Windows.Forms.Label
    Friend WithEvents lbl_id_alternatif As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
