Imports System.Data.Odbc
Public Class Alternatif

    Public Sub Batas_Alternatif()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT COUNT(*) FROM alternatif", conn)
            Dim batas As Integer
            batas = cmd.ExecuteScalar
            lbl_count.Text = batas
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Sub Batas_Simpan()
        If lbl_count.Text = 5 Then
            btn_simpan.Enabled = False
            btn_next.Enabled = True
            btn_keluar.Enabled = True
            txt_namaalternatif.Enabled = False
        End If
    End Sub

    Sub Alternatif_False()
        btn_next.Enabled = False
        btn_keluar.Enabled = False
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If txt_namaalternatif.Text = "" Then
            MsgBox("Silahkan Lengkapi Data Alternatif !!!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "APLIKASI SPK - SAW")
        Else
            Try
                Call Koneksi()
                Dim Simpan As String
                Simpan = "INSERT INTO alternatif (nama_alternatif) VALUES ('" & txt_namaalternatif.Text & "')"
                Dim dc As New OdbcCommand(Simpan, conn)
                dc.ExecuteNonQuery()
                MsgBox("Data ALternatif Telah Disimpan", vbOK + vbInformation, "APLIKASI SPK - SAW")
                txt_namaalternatif.Text = ""
                txt_namaalternatif.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            End Try
        End If

    End Sub

    Private Sub Alternatif_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Batas_Alternatif()
        Batas_Simpan()
    End Sub

    Private Sub Alternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Alternatif_False()
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Dim Question As String
        Question = MessageBox.Show("Anda Ingin Keluar?" + Environment.NewLine + "Jika Anda Keluar, seluruh data Alternatif yang telah di input akan terhapus", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Question = vbYes Then
            Try
                Call Koneksi()
                cmd = New OdbcCommand("TRUNCATE TABLE alternatif", conn)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            End Try
        End If
        End
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Dim Question As String
        Question = MessageBox.Show("Apakah Data Sudah Betul?" + Environment.NewLine + "Jika Iya, Tekan Tombol Next", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Question = vbYes Then
            Kriteria_Alternatif.Show()
            Menu_Utama.panel_alternatif.BackColor = Color.DimGray
            Menu_Utama.panel_bobot_alternatif.BackColor = Color.Red
            'Menu_Utama.BOBOTALTERNATIF_Menu.Enabled = True
            'Kriteria_Alternatif.cb_penilaian.Text = lbl_judul.Text
            Me.Hide()

        End If
    End Sub

End Class