Imports System.Data.Odbc
Public Class Menu_Utama

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_jam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Menu_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        Timer1.Start()
        Timer2.Start()
        link_kriteria.Enabled = False
        link_alternatif.Enabled = False
        link_bobot_alternatif.Enabled = False
        link_preferensi.Enabled = False
    End Sub

    Private Sub link_logout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_logout.LinkClicked
        End
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lbl_tanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub link_judul_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_judul.LinkClicked
        Judul_Penilaian.Show()
        Me.Enabled = False
    End Sub

    Private Sub link_kriteria_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_kriteria.LinkClicked
        Kriteria.Show()
    End Sub

    Private Sub link_alternatif_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_alternatif.LinkClicked
        Alternatif.Show()
    End Sub

    Private Sub link_bobot_alternatif_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_bobot_alternatif.LinkClicked
        Kriteria_Alternatif.Show()
    End Sub

    Private Sub link_preferensi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_preferensi.LinkClicked
        Bobot_Preferensi.Show()
    End Sub

    Private Sub pct_chart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_chart.Click
        Process.Start("http://jurnal.stkipalmaksum.ac.id/index.php/Sintaksis/article/view/100/109")
    End Sub

    Private Sub pct_information_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_information.Click
        Process.Start("https://www.youtube.com/channel/UC2mJuudgYSTN24BndE88YWA")
    End Sub

    Public Sub tbl_Alternatif()
        cmd = New OdbcCommand("TRUNCATE TABLE alternatif", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Alter_Kriteria()
        cmd = New OdbcCommand("TRUNCATE TABLE alter_kriteria", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Bobot_Kriteria()
        cmd = New OdbcCommand("TRUNCATE TABLE bobot_kriteria", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Bobot_Preferensi()
        cmd = New OdbcCommand("TRUNCATE TABLE bobot_preferensi", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Judul()
        cmd = New OdbcCommand("TRUNCATE TABLE judul_penilaian", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Matriks_Normalisasi()
        cmd = New OdbcCommand("TRUNCATE TABLE matriks_normalisasi", conn)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub tbl_Nilai_Pembanding()
        cmd = New OdbcCommand("TRUNCATE TABLE nilai_pembanding", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub lbl_reset_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_reset_data.Click
        Dim Reset As String
        Reset = MessageBox.Show("Reset Data?", "APLIKASI SPK - SAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Reset = vbYes Then
            tbl_Alternatif()
            tbl_Alter_Kriteria()
            tbl_Bobot_Kriteria()
            tbl_Bobot_Preferensi()
            tbl_Judul()
            tbl_Matriks_Normalisasi()
            tbl_Nilai_Pembanding()
            MsgBox("Keseluruhan Data Telah Di Riset", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "APLIKASI SPK - SAW")
        End If
    End Sub

End Class