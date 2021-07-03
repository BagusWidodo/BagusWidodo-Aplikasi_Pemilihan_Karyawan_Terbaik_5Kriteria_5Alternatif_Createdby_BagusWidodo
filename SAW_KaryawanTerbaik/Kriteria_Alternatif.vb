Imports System.Data.Odbc
Public Class Kriteria_Alternatif

    Public Sub TampilAlternatif()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM alternatif", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV1.DataSource = dt
    End Sub

    Public Sub Judul_Penilaian()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT judul_penilaian FROM judul_penilaian", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    cb_penilaian.Items.Add(dr("judul_penilaian"))
                Loop
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Public Sub Kriteria()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM judul_penilaian WHERE judul_penilaian = '" & cb_penilaian.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lbl_c1.Text = dr.Item("c1")
            lbl_c2.Text = dr.Item("c2")
            lbl_c3.Text = dr.Item("c3")
            lbl_c4.Text = dr.Item("c4")
            lbl_c5.Text = dr.Item("c5")
        End If
    End Sub

    Public Sub Alternatif_Kriteria()
        Call Koneksi()
        'mysql> SELECT nama_matkul,jumlah_SKS,nama_dosen FROM mata_kuliah INNER JOIN daftar_dosen ON NIP_dosen=NIP;
        da = New OdbcDataAdapter("SELECT alternatif.id_alternatif, nama_alternatif, c1, c2, c3, c4, c5 FROM alternatif JOIN alter_kriteria USING(id_alternatif)", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV2.DataSource = dt

        DGV2.Columns(0).Width = 70
        DGV2.Columns(1).Width = 150
        DGV2.Columns(2).Width = 60
        DGV2.Columns(3).Width = 60
        DGV2.Columns(4).Width = 60
        DGV2.Columns(5).Width = 60
        DGV2.Columns(6).Width = 60
    End Sub

    Sub Bersih()
        txt_alternatif.Text = ""
        txt_c1.Text = ""
        txt_c2.Text = ""
        txt_c3.Text = ""
        txt_c4.Text = ""
        txt_c5.Text = ""
        txt_alternatif.Focus()
    End Sub

    Public Sub Tampil_Pembanding()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT c1, c2, c3, c4, c5 FROM nilai_pembanding", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV3.DataSource = dt
    End Sub

    Public Sub Batas_Alternatif()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT COUNT(*) FROM alter_kriteria", conn)
            Dim batas As Integer
            batas = cmd.ExecuteScalar
            lbl_count_alternatif.Text = batas
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Sub Batas_Simpan()
        If lbl_count_alternatif.Text = 5 Then
            txt_alternatif.Enabled = False
            txt_c1.Enabled = False
            txt_c2.Enabled = False
            txt_c3.Enabled = False
            txt_c4.Enabled = False
            txt_c5.Enabled = False
            btn_simpan.Enabled = False
        End If
    End Sub

    Private Sub Kriteria_Alternatif_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TampilAlternatif()
        Tampil_Pembanding()
        Alternatif_Kriteria()

        Kriteria()
        Batas_Alternatif()
        Batas_Simpan()

        btn_hitung.Visible = False
        btn_next.Visible = False

        lbl_id_alternatif.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub Kriteria_Alternatif_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Judul_Penilaian()
    End Sub

    Sub Nilai_Pembanding()
        Dim c1, c2, c3, c4, c5 As Integer
        c1 = (From row As DataGridViewRow In DGV2.Rows
                  Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToInt32(row.Cells(3).FormattedValue)
                  ).Max().ToString()

        c2 = (From row As DataGridViewRow In DGV2.Rows
                  Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToInt32(row.Cells(3).FormattedValue)
                  ).Max().ToString()

        c3 = (From row As DataGridViewRow In DGV2.Rows
                  Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToInt32(row.Cells(3).FormattedValue)
                  ).Max().ToString()

        c4 = (From row As DataGridViewRow In DGV2.Rows
                  Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToInt32(row.Cells(3).FormattedValue)
                  ).Max().ToString()

        c5 = (From row As DataGridViewRow In DGV2.Rows
                  Where row.Cells(3).FormattedValue.ToString() <> String.Empty
                  Select Convert.ToInt32(row.Cells(3).FormattedValue)
                  ).Max().ToString()

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO nilai_pembanding (c1, c2, c3, c4, c5) VALUES('" & c1 & "','" & c2 & "','" & c3 & "','" & c4 & "','" & c5 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try

    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellClick

        Dim klik As Integer
        klik = DGV1.CurrentRow.Index
        On Error Resume Next
        txt_alternatif.Text = DGV1.Item(1, klik).Value
        lbl_id_alternatif.Text = DGV1.Item(0, klik).Value

    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_alternatif.Text = "" Or txt_c1.Text = "" Or txt_c2.Text = "" Or txt_c3.Text = "" Or txt_c4.Text = "" Or txt_c5.Text = "" Then
            MsgBox("Lengkapi Nilai Terlebih Dahulu", MsgBoxStyle.OkOnly + vbInformation, "APLIKASI SPK - SAW")
            DGV1.Visible = True
            DGV2.Visible = True
        Else
            Call Koneksi()
            cmd = New OdbcCommand("SELECT * FROM alter_kriteria WHERE id_alternatif = '" & lbl_id_alternatif.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("ID Alternatif Sudah Ada !!!", MsgBoxStyle.OkOnly + vbInformation, "APLIKASI SPK - SAW")
                DGV1.Visible = True
                DGV2.Visible = True
                Bersih()
            Else
                Try
                    Call Koneksi()
                    cmd = New OdbcCommand("INSERT INTO alter_kriteria (id_alternatif, c1, c2, c3, c4, c5) VALUES ('" & lbl_id_alternatif.Text & "','" & txt_c1.Text & "','" & txt_c2.Text & "','" & txt_c3.Text & "','" & txt_c4.Text & "','" & txt_c5.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Alternatif Kriteria Berhasil Disimpan", "ALTERNATIF KRITERIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Bersih()
                    DGV1.Visible = True
                    DGV2.Visible = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
                End Try
            End If
        End If

    End Sub

    Private Sub cb_penilaian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_penilaian.SelectedIndexChanged
        Kriteria()
        Batas_Pembanding()
        btn_caripembanding.Visible = True
        DGV1.Visible = True
        DGV2.Visible = True
        DGV3.Visible = True

    End Sub

    Private Sub btn_caripembanding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_caripembanding.Click
        Nilai_Pembanding()
        Tampil_Pembanding()
        DGV3.Visible = True
        btn_hitung.Visible = True
    End Sub

    Public Sub A1()
        Dim A1_C1, A1_C2, A1_C3, A1_C4, A1_C5 As Double
        A1_C1 = (DGV2.Rows(0).Cells(2).Value) / (DGV3.Rows(0).Cells(0).Value)
        A1_C2 = (DGV2.Rows(0).Cells(3).Value) / (DGV3.Rows(0).Cells(1).Value)
        A1_C3 = (DGV2.Rows(0).Cells(4).Value) / (DGV3.Rows(0).Cells(2).Value)
        A1_C4 = (DGV2.Rows(0).Cells(5).Value) / (DGV3.Rows(0).Cells(3).Value)
        A1_C5 = (DGV2.Rows(0).Cells(6).Value) / (DGV3.Rows(0).Cells(4).Value)

        '============================ KODING BOBOT KRITERIA ==========================='
        Call Koneksi()
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c1 As Double
            bobot_c1 = dr.Item("bobot")
            lbl_nilai_c1.Text = bobot_c1
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c2 As Double
            bobot_c2 = dr.Item("bobot")
            lbl_nilai_c2.Text = bobot_c2
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c3 As Double
            bobot_c3 = dr.Item("bobot")
            lbl_nilai_c3.Text = bobot_c3
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c4.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c4 As Double
            bobot_c4 = dr.Item("bobot")
            lbl_nilai_c4.Text = bobot_c4
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c5.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c5 As Double
            bobot_c5 = dr.Item("bobot")
            lbl_nilai_c5.Text = bobot_c5
        End If
        ' ======================= BATAS KODING BOBOT KRITERIA ========================='

        ' ======================= KODING MENCARI BOBOT PREFERENSI Alterantif 1 ======================='
        Dim Nilai_A1 As Double
        Nilai_A1 = (A1_C1 * Val(lbl_nilai_c1.Text)) + (A1_C2 * Val(lbl_nilai_c2.Text)) + (A1_C3 * Val(lbl_nilai_c3.Text)) + (A1_C4 * Val(lbl_nilai_c4.Text)) + (A1_C5 * Val(lbl_nilai_c5.Text))
        ' ======================= BATAS KODING MENCARI BOBOT PREFERENSI Alterantif 1 ======================='

        Dim id_A1 As String
        id_A1 = (DGV2.Rows(0).Cells(0).Value)

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO matriks_normalisasi (id_alternatif, matriks_c1,matriks_c2,matriks_c3,matriks_c4,matriks_c5) VALUES ('" & id_A1 & "','" & A1_C1 & "','" & A1_C2 & "','" & A1_C3 & "','" & A1_C4 & "','" & A1_C5 & "') ", conn)
            cmd.ExecuteNonQuery()

            cmd = New OdbcCommand("INSERT INTO bobot_preferensi (id_alternatif, nilai) VALUES ('" & id_A1 & "','" & Nilai_A1 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Sub A2()
        Dim A2_C1, A2_C2, A2_C3, A2_C4, A2_C5 As Double
        A2_C1 = (DGV2.Rows(1).Cells(2).Value) / (DGV3.Rows(0).Cells(0).Value)
        A2_C2 = (DGV2.Rows(1).Cells(3).Value) / (DGV3.Rows(0).Cells(1).Value)
        A2_C3 = (DGV2.Rows(1).Cells(4).Value) / (DGV3.Rows(0).Cells(2).Value)
        A2_C4 = (DGV2.Rows(1).Cells(5).Value) / (DGV3.Rows(0).Cells(3).Value)
        A2_C5 = (DGV2.Rows(1).Cells(6).Value) / (DGV3.Rows(0).Cells(4).Value)

        '============================ KODING BOBOT KRITERIA ==========================='
        Call Koneksi()
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c1 As Double
            bobot_c1 = dr.Item("bobot")
            lbl_nilai_c1.Text = bobot_c1
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c2 As Double
            bobot_c2 = dr.Item("bobot")
            lbl_nilai_c2.Text = bobot_c2
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c3 As Double
            bobot_c3 = dr.Item("bobot")
            lbl_nilai_c3.Text = bobot_c3
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c4.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c4 As Double
            bobot_c4 = dr.Item("bobot")
            lbl_nilai_c4.Text = bobot_c4
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c5.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c5 As Double
            bobot_c5 = dr.Item("bobot")
            lbl_nilai_c5.Text = bobot_c5
        End If
        ' ======================= BATAS KODING BOBOT KRITERIA ========================='

        ' ======================= KODING MENCARI BOBOT PREFERENSI Alterantif 2 ======================='
        Dim Nilai_A2 As Double
        Nilai_A2 = (A2_C1 * Val(lbl_nilai_c1.Text)) + (A2_C2 * Val(lbl_nilai_c2.Text)) + (A2_C3 * Val(lbl_nilai_c3.Text)) + (A2_C4 * Val(lbl_nilai_c4.Text)) + (A2_C5 * Val(lbl_nilai_c5.Text))
        ' ======================= BATAS KODING MENCARI BOBOT PREFERENSI Alterantif 2 ======================='

        Dim id_A2 As String
        id_A2 = (DGV2.Rows(1).Cells(0).Value)

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO matriks_normalisasi (id_alternatif, matriks_c1,matriks_c2,matriks_c3,matriks_c4,matriks_c5) VALUES ('" & id_A2 & "','" & A2_C1 & "','" & A2_C2 & "','" & A2_C3 & "','" & A2_C4 & "','" & A2_C5 & "') ", conn)
            cmd.ExecuteNonQuery()
        
            cmd = New OdbcCommand("INSERT INTO bobot_preferensi (id_alternatif, nilai) VALUES ('" & id_A2 & "','" & Nilai_A2 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Sub A3()
        Dim A3_C1, A3_C2, A3_C3, A3_C4, A3_C5 As Double
        A3_C1 = (DGV2.Rows(2).Cells(2).Value) / (DGV3.Rows(0).Cells(0).Value)
        A3_C2 = (DGV2.Rows(2).Cells(3).Value) / (DGV3.Rows(0).Cells(1).Value)
        A3_C3 = (DGV2.Rows(2).Cells(4).Value) / (DGV3.Rows(0).Cells(2).Value)
        A3_C4 = (DGV2.Rows(2).Cells(5).Value) / (DGV3.Rows(0).Cells(3).Value)
        A3_C5 = (DGV2.Rows(2).Cells(6).Value) / (DGV3.Rows(0).Cells(4).Value)

        '============================ KODING BOBOT KRITERIA ==========================='
        Call Koneksi()
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c1 As Double
            bobot_c1 = dr.Item("bobot")
            lbl_nilai_c1.Text = bobot_c1
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c2 As Double
            bobot_c2 = dr.Item("bobot")
            lbl_nilai_c2.Text = bobot_c2
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c3 As Double
            bobot_c3 = dr.Item("bobot")
            lbl_nilai_c3.Text = bobot_c3
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c4.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c4 As Double
            bobot_c4 = dr.Item("bobot")
            lbl_nilai_c4.Text = bobot_c4
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c5.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c5 As Double
            bobot_c5 = dr.Item("bobot")
            lbl_nilai_c5.Text = bobot_c5
        End If
        ' ======================= BATAS KODING BOBOT KRITERIA ========================='

        ' ======================= KODING MENCARI BOBOT PREFERENSI Alterantif 3 ======================='
        Dim Nilai_A3 As Double
        Nilai_A3 = (A3_C1 * Val(lbl_nilai_c1.Text)) + (A3_C2 * Val(lbl_nilai_c2.Text)) + (A3_C3 * Val(lbl_nilai_c3.Text)) + (A3_C4 * Val(lbl_nilai_c4.Text)) + (A3_C5 * Val(lbl_nilai_c5.Text))
        ' ======================= BATAS KODING MENCARI BOBOT PREFERENSI Alterantif 3 ======================='

        Dim id_A3 As String
        id_A3 = (DGV2.Rows(2).Cells(0).Value)

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO matriks_normalisasi (id_alternatif, matriks_c1,matriks_c2,matriks_c3,matriks_c4,matriks_c5) VALUES ('" & id_A3 & "','" & A3_C1 & "','" & A3_C2 & "','" & A3_C3 & "','" & A3_C4 & "','" & A3_C5 & "') ", conn)
            cmd.ExecuteNonQuery()
       
            cmd = New OdbcCommand("INSERT INTO bobot_preferensi (id_alternatif, nilai) VALUES ('" & id_A3 & "','" & Nilai_A3 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Sub A4()
        Dim A4_C1, A4_C2, A4_C3, A4_C4, A4_C5 As Double
        A4_C1 = (DGV2.Rows(3).Cells(2).Value) / (DGV3.Rows(0).Cells(0).Value)
        A4_C2 = (DGV2.Rows(3).Cells(3).Value) / (DGV3.Rows(0).Cells(1).Value)
        A4_C3 = (DGV2.Rows(3).Cells(4).Value) / (DGV3.Rows(0).Cells(2).Value)
        A4_C4 = (DGV2.Rows(3).Cells(5).Value) / (DGV3.Rows(0).Cells(3).Value)
        A4_C5 = (DGV2.Rows(3).Cells(6).Value) / (DGV3.Rows(0).Cells(4).Value)

        '============================ KODING BOBOT KRITERIA ==========================='
        Call Koneksi()
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c1 As Double
            bobot_c1 = dr.Item("bobot")
            lbl_nilai_c1.Text = bobot_c1
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c2 As Double
            bobot_c2 = dr.Item("bobot")
            lbl_nilai_c2.Text = bobot_c2
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c3 As Double
            bobot_c3 = dr.Item("bobot")
            lbl_nilai_c3.Text = bobot_c3
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c4.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c4 As Double
            bobot_c4 = dr.Item("bobot")
            lbl_nilai_c4.Text = bobot_c4
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c5.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c5 As Double
            bobot_c5 = dr.Item("bobot")
            lbl_nilai_c5.Text = bobot_c5
        End If
        ' ======================= BATAS KODING BOBOT KRITERIA ========================='

        ' ======================= KODING MENCARI BOBOT PREFERENSI Alterantif 4 ======================='
        Dim Nilai_A4 As Double
        Nilai_A4 = (A4_C1 * Val(lbl_nilai_c1.Text)) + (A4_C2 * Val(lbl_nilai_c2.Text)) + (A4_C3 * Val(lbl_nilai_c3.Text)) + (A4_C4 * Val(lbl_nilai_c4.Text)) + (A4_C5 * Val(lbl_nilai_c5.Text))
        ' ======================= BATAS KODING MENCARI BOBOT PREFERENSI Alterantif 4 ======================='

        Dim id_A4 As String
        id_A4 = (DGV2.Rows(3).Cells(0).Value)

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO matriks_normalisasi (id_alternatif, matriks_c1,matriks_c2,matriks_c3,matriks_c4,matriks_c5) VALUES ('" & id_A4 & "','" & A4_C1 & "','" & A4_C2 & "','" & A4_C3 & "','" & A4_C4 & "','" & A4_C5 & "') ", conn)
            cmd.ExecuteNonQuery()
        
            cmd = New OdbcCommand("INSERT INTO bobot_preferensi (id_alternatif, nilai) VALUES ('" & id_A4 & "','" & Nilai_A4 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Sub A5()
        Dim A5_C1, A5_C2, A5_C3, A5_C4, A5_C5 As Double
        A5_C1 = (DGV2.Rows(4).Cells(2).Value) / (DGV3.Rows(0).Cells(0).Value)
        A5_C2 = (DGV2.Rows(4).Cells(3).Value) / (DGV3.Rows(0).Cells(1).Value)
        A5_C3 = (DGV2.Rows(4).Cells(4).Value) / (DGV3.Rows(0).Cells(2).Value)
        A5_C4 = (DGV2.Rows(4).Cells(5).Value) / (DGV3.Rows(0).Cells(3).Value)
        A5_C5 = (DGV2.Rows(4).Cells(6).Value) / (DGV3.Rows(0).Cells(4).Value)

        '============================ KODING BOBOT KRITERIA ==========================='
        Call Koneksi()
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c1 As Double
            bobot_c1 = dr.Item("bobot")
            lbl_nilai_c1.Text = bobot_c1
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c2 As Double
            bobot_c2 = dr.Item("bobot")
            lbl_nilai_c2.Text = bobot_c2
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c3.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c3 As Double
            bobot_c3 = dr.Item("bobot")
            lbl_nilai_c3.Text = bobot_c3
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c4.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c4 As Double
            bobot_c4 = dr.Item("bobot")
            lbl_nilai_c4.Text = bobot_c4
        End If
        cmd = New OdbcCommand("SELECT bobot FROM bobot_kriteria WHERE nama_kriteria = '" & lbl_c5.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim bobot_c5 As Double
            bobot_c5 = dr.Item("bobot")
            lbl_nilai_c5.Text = bobot_c5
        End If
        ' ======================= BATAS KODING BOBOT KRITERIA ========================='

        ' ======================= KODING MENCARI BOBOT PREFERENSI Alterantif 5 ======================='
        Dim Nilai_A5 As Double
        Nilai_A5 = (A5_C1 * Val(lbl_nilai_c1.Text)) + (A5_C2 * Val(lbl_nilai_c2.Text)) + (A5_C3 * Val(lbl_nilai_c3.Text)) + (A5_C4 * Val(lbl_nilai_c4.Text)) + (A5_C5 * Val(lbl_nilai_c5.Text))
        ' ======================= BATAS KODING MENCARI BOBOT PREFERENSI Alterantif 5 ======================='

        Dim id_A5 As String
        id_A5 = (DGV2.Rows(4).Cells(0).Value)

        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO matriks_normalisasi (id_alternatif, matriks_c1,matriks_c2,matriks_c3,matriks_c4,matriks_c5) VALUES ('" & id_A5 & "','" & A5_C1 & "','" & A5_C2 & "','" & A5_C3 & "','" & A5_C4 & "','" & A5_C5 & "') ", conn)
            cmd.ExecuteNonQuery()
        
            cmd = New OdbcCommand("INSERT INTO bobot_preferensi (id_alternatif, nilai) VALUES ('" & id_A5 & "','" & Nilai_A5 & "')", conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Batas_Pembanding()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT COUNT(*) FROM nilai_pembanding", conn)
            Dim batas As Integer
            batas = cmd.ExecuteScalar
            If batas = 1 Then
                btn_caripembanding.Enabled = False
                btn_hitung.Visible = True
                btn_hitung.Enabled = False
                btn_next.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            btn_next.Visible = True
        End If
    End Sub

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        ProgressBar1.Visible = True
        Timer1.Start()
        A1()
        A2()
        A3()
        A4()
        A5()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        'Menu_Utama.BOBOTPREFERENSI_Menu.Enabled = True
        Bobot_Preferensi.Show()
        Menu_Utama.panel_bobot_alternatif.BackColor = Color.DimGray
        Menu_Utama.panel_preferensi.BackColor = Color.Red
        Me.Hide()
    End Sub

End Class