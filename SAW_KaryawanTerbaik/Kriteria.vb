Imports System.Data.Odbc
Public Class Kriteria

    Public Sub Judul_Penilaian()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT judul_penilaian FROM judul_penilaian", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    cb_judul.Items.Add(dr("judul_penilaian"))
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
        txt_bobot_c1.Enabled = True
        txt_bobot_c2.Enabled = True
        txt_bobot_c3.Enabled = True
        txt_bobot_c4.Enabled = True
        txt_bobot_c5.Enabled = True
    End Sub

    Sub Clear()
        txt_bobot_c1.Text = ""
        txt_bobot_c2.Text = ""
        txt_bobot_c3.Text = ""
        txt_bobot_c4.Text = ""
        txt_bobot_c5.Text = ""
    End Sub

    Sub KriteriaFalse()
        txt_bobot_c1.Enabled = False
        txt_bobot_c2.Enabled = False
        txt_bobot_c3.Enabled = False
        txt_bobot_c4.Enabled = False
        txt_bobot_c5.Enabled = False
        btn_simpan.Enabled = False
        btn_keluar.Enabled = False
        btn_next.Enabled = False
    End Sub

    Public Sub Batas_Bobot()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT COUNT(*) FROM bobot_kriteria", conn)
            Dim batas As Integer
            batas = cmd.ExecuteScalar
            If batas = 5 Then
                btn_next.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Public Sub Tampil_Kriteria()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT nama_kriteria, bobot FROM bobot_kriteria", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV.DataSource = dt
    End Sub

    Public Sub SimpanC1()
        cmd = New OdbcCommand("INSERT INTO bobot_kriteria (nama_kriteria, bobot) VALUES ('" & lbl_kriteria_1.Text & "','" & txt_bobot_c1.Text & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SimpanC2()
        cmd = New OdbcCommand("INSERT INTO bobot_kriteria (nama_kriteria, bobot) VALUES ('" & lbl_kriteria_2.Text & "','" & txt_bobot_c2.Text & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SimpanC3()
        cmd = New OdbcCommand("INSERT INTO bobot_kriteria (nama_kriteria, bobot) VALUES ('" & lbl_kriteria_3.Text & "','" & txt_bobot_c3.Text & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SimpanC4()
        cmd = New OdbcCommand("INSERT INTO bobot_kriteria (nama_kriteria, bobot) VALUES ('" & lbl_kriteria_4.Text & "','" & txt_bobot_c4.Text & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SimpanC5()
        cmd = New OdbcCommand("INSERT INTO bobot_kriteria (nama_kriteria, bobot) VALUES ('" & lbl_kriteria_5.Text & "','" & txt_bobot_c5.Text & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Kriteria()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM judul_penilaian WHERE judul_penilaian = '" & cb_judul.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lbl_kriteria_1.Text = dr.Item("c1")
            lbl_kriteria_2.Text = dr.Item("c2")
            lbl_kriteria_3.Text = dr.Item("c3")
            lbl_kriteria_4.Text = dr.Item("c4")
            lbl_kriteria_5.Text = dr.Item("c5")
        End If
        txt_bobot_c1.Enabled = True
        txt_bobot_c2.Enabled = True
        txt_bobot_c3.Enabled = True
        txt_bobot_c4.Enabled = True
        txt_bobot_c5.Enabled = True
        btn_simpan.Enabled = True
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_bobot_c1.Text = "" Or txt_bobot_c2.Text = "" Or txt_bobot_c3.Text = "" Or txt_bobot_c4.Text = "" Or txt_bobot_c5.Text = "" Then
            MsgBox("Silahkan Isi Bobot Nilai !!!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "APLIKASI SPK - SAW")
        ElseIf lbl_total_bobot.Text < 0 Or lbl_total_bobot.Text > 0 Then
            MsgBox("Nilai Bobot Tidak Sesuai", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "APLIKASI SPK - SAW")
        Else
            Try
                Call Koneksi()
                SimpanC1()
                SimpanC2()
                SimpanC3()
                SimpanC4()
                SimpanC5()
                MsgBox("Data Bobot Kriteria Telah Disimpan !!!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "APLIKASI SPK - SAW")
                Clear()
                btn_next.Enabled = True
                btn_keluar.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            End Try
        End If
    End Sub

    Private Sub cb_judul_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_judul.SelectedIndexChanged
        Kriteria()
    End Sub

    Private Sub Kriteria_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Tampil_Kriteria()
    End Sub

    Private Sub txt_bobot_c1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bobot_c1.TextChanged
        lbl_total_bobot.Text = 1 - (Val(txt_bobot_c1.Text) + Val(txt_bobot_c2.Text) + Val(txt_bobot_c3.Text) + Val(txt_bobot_c4.Text) + Val(txt_bobot_c5.Text))
    End Sub

    Private Sub txt_bobot_c2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bobot_c2.TextChanged
        lbl_total_bobot.Text = 1 - (Val(txt_bobot_c1.Text) + Val(txt_bobot_c2.Text) + Val(txt_bobot_c3.Text) + Val(txt_bobot_c4.Text) + Val(txt_bobot_c5.Text))
    End Sub

    Private Sub txt_bobot_c3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bobot_c3.TextChanged
        lbl_total_bobot.Text = 1 - (Val(txt_bobot_c1.Text) + Val(txt_bobot_c2.Text) + Val(txt_bobot_c3.Text) + Val(txt_bobot_c4.Text) + Val(txt_bobot_c5.Text))
    End Sub

    Private Sub txt_bobot_c4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bobot_c4.TextChanged
        lbl_total_bobot.Text = 1 - (Val(txt_bobot_c1.Text) + Val(txt_bobot_c2.Text) + Val(txt_bobot_c3.Text) + Val(txt_bobot_c4.Text) + Val(txt_bobot_c5.Text))
    End Sub

    Private Sub txt_bobot_c5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bobot_c5.TextChanged
        lbl_total_bobot.Text = 1 - (Val(txt_bobot_c1.Text) + Val(txt_bobot_c2.Text) + Val(txt_bobot_c3.Text) + Val(txt_bobot_c4.Text) + Val(txt_bobot_c5.Text))
    End Sub

    Private Sub Kriteria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Judul_Penilaian()
        KriteriaFalse()
        Batas_Bobot()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Dim Question As String
        Question = MessageBox.Show("Apakah Data Sudah Betul?" + Environment.NewLine + "Jika Iya, Tekan Tombol Next", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Question = vbYes Then
            Alternatif.Show()
            Menu_Utama.panel_kriteria.BackColor = Color.DimGray
            Menu_Utama.panel_alternatif.BackColor = Color.Red
            Alternatif.lbl_judul.Text = cb_judul.Text
            Me.Hide()

        End If
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Dim Question As String
        Question = MessageBox.Show("Anda Ingin Keluar?" + Environment.NewLine + "Jika Anda Keluar, seluruh data yang telah di input akan terhapus", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Question = vbYes Then
            Try
                Call Koneksi()
                cmd = New OdbcCommand("TRUNCATE TABLE bobot_kriteria", conn)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            End Try
        End If
        End
    End Sub

End Class
