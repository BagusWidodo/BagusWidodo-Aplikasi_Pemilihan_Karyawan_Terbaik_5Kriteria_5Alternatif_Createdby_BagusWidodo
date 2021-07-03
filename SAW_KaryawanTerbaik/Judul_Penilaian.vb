Imports System.Data.Odbc
Public Class Judul_Penilaian

    Public Sub Batas_Kriteria()
        Try
            Call Koneksi()
            cmd = New OdbcCommand("SELECT COUNT(*) FROM judul_penilaian", conn)
            Dim batas As Integer
            batas = cmd.ExecuteScalar
            lbl_count.Text = batas
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Sub Batas_Setting()
        If lbl_count.Text = 1 Then
            txt_c1.Enabled = False
            txt_c2.Enabled = False
            txt_c3.Enabled = False
            txt_c4.Enabled = False
            txt_c5.Enabled = False
            btn_next.Visible = True
            link_ganti.Enabled = True
        ElseIf lbl_count.Text = 0 Then
            txt_c1.Enabled = True
            txt_c2.Enabled = True
            txt_c3.Enabled = True
            txt_c4.Enabled = True
            txt_c5.Enabled = True
            btn_next.Visible = False
            btn_setting.Visible = True
        End If
    End Sub

    Sub Clear()
        txt_judul.Text = ""
        txt_c1.Text = ""
        txt_c2.Text = ""
        txt_c3.Text = ""
        txt_c4.Text = ""
        txt_c5.Text = ""
    End Sub

    Private Sub Judul_Penilaian_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Batas_Kriteria()
        Batas_Setting()
    End Sub

    Private Sub btn_setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_setting.Click
        Try
            Call Koneksi()
            cmd = New OdbcCommand("INSERT INTO judul_penilaian (judul_penilaian, c1, c2, c3, c4, c5) VALUES ('" & txt_judul.Text & "','" & txt_c1.Text & "','" & txt_c2.Text & "','" & txt_c3.Text & "','" & txt_c4.Text & "','" & txt_c5.Text & "') ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Judul Penelitian & Kriteria Telah Disimpan", MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            btn_next.Visible = True
            btn_setting.Visible = False
            Clear()
        Catch ex As Exception
            MsgBox("Judul Telah Disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "APLIKASI SPK - SAW")
        End Try
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Kriteria.Show()
        Menu_Utama.panel_kriteria.BackColor = Color.Red
        Menu_Utama.panel_judul.BackColor = Color.DimGray
        Menu_Utama.panel_kriteria.Enabled = True
        Me.Hide()
    End Sub

    Private Sub link_ganti_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_ganti.LinkClicked
        Dim pilihan As String
        pilihan = MessageBox.Show("Ingin Menghapus Judul dan Kriteria?", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If pilihan = vbYes Then
            Try
                Call Koneksi()
                cmd = New OdbcCommand("TRUNCATE TABLE judul_penilaian", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil !!! Silahkan Isi Judul dan Kriteria", MsgBoxStyle.Information, "APLIKASI SPK - SAW")
                Batas_Setting()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "APLIKASI SPK - SAW")
            End Try
        End If
    End Sub

End Class