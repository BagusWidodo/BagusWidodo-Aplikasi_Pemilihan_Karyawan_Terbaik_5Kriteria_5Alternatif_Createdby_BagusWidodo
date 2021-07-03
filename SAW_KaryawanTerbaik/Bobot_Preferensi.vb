Imports System.Data.Odbc
Public Class Bobot_Preferensi

    Sub Header_Matriks()
        With ListView1.Columns
            .Add("Nama", 100)
            .Add("Kriteria 1", 70)
            .Add("Kriteria 2", 75)
            .Add("Kriteria 3", 75)
            .Add("Kriteria 4", 75)
            .Add("Kriteria 5", 75)
        End With
    End Sub

    Public Sub List_Matriks()
        Dim a As Integer
        Try
            da = New OdbcDataAdapter("SELECT alternatif.id_alternatif, nama_alternatif, matriks_c1, matriks_c2, matriks_c3, matriks_c4, matriks_c5 FROM matriks_normalisasi JOIN alternatif USING(id_alternatif)", conn)
            ds = New DataSet
            da.Fill(ds)
            ListView1.Items.Clear()
            For a = 0 To ds.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(ds.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(6))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.Gainsboro
                    Else
                        .Items(a).BackColor = Color.White
                    End If

                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub Header_Preferensi()
        With ListView2.Columns
            .Add("Nama", 100)
            .Add("Nilai", 70)
        End With
    End Sub

    Public Sub List_Preferensi()
        Dim b As Integer
        Try
            da = New OdbcDataAdapter("SELECT alternatif.id_alternatif, nama_alternatif, nilai FROM bobot_preferensi JOIN alternatif USING(id_alternatif) ORDER BY nilai DESC", conn)
            ds = New DataSet
            da.Fill(ds)
            ListView2.Items.Clear()
            For b = 0 To ds.Tables(0).Rows.Count - 1
                With ListView2
                    .Items.Add(ds.Tables(0).Rows(b).Item(1))
                    .Items(b).SubItems.Add(ds.Tables(0).Rows(b).Item(2))
                    If (b Mod 2 = 0) Then
                        .Items(b).BackColor = Color.Gainsboro
                    Else
                        .Items(b).BackColor = Color.White
                    End If

                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub Header_Karyawan()
        With ListView3.Columns
            .Add("Nama", 100)
            .Add("Nilai", 50)
        End With
    End Sub

    Public Sub List_Karyawan()
        Dim a As Integer
        Try
            da = New OdbcDataAdapter("SELECT alternatif.nama_alternatif, nilai FROM bobot_preferensi JOIN alternatif USING(id_alternatif) ORDER BY nilai DESC LIMIT 1", conn)
            ds = New DataSet
            da.Fill(ds)
            ListView3.Items.Clear()
            For a = 0 To ds.Tables(0).Rows.Count - 1
                With ListView3
                    .Items.Add(ds.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(ds.Tables(0).Rows(a).Item(1))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.Gainsboro
                    Else
                        .Items(a).BackColor = Color.White
                    End If

                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bobot_Preferensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        Header_Matriks()
        List_Matriks()
        Header_Preferensi()
        List_Preferensi()
        Header_Karyawan()
        List_Karyawan()
    End Sub

    Private Sub btn_finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finish.Click
        Menu_Utama.Enabled = True
        Menu_Utama.panel_preferensi.BackColor = Color.DimGray
        Menu_Utama.panel_judul.BackColor = Color.Red
        Menu_Utama.link_kriteria.Enabled = True
        Menu_Utama.link_alternatif.Enabled = True
        Menu_Utama.link_bobot_alternatif.Enabled = True
        Menu_Utama.link_preferensi.Enabled = True
        Me.Close()

    End Sub

    Private Sub lbl_designer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_designer.Click
        Process.Start("https://www.facebook.com/venny.octavia.733")
    End Sub

    Private Sub lbl_database_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_database.Click
        Process.Start("https://www.facebook.com/nadia.e.junita")
    End Sub

    Private Sub lbl_programmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_programmer.Click
        Process.Start("https://www.facebook.com/izay.panjaitan")
    End Sub
End Class