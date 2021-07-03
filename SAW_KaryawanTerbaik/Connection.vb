Imports System.Data.Odbc
Module Connection

    Public conn As OdbcConnection
    Public cmd As New OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public ds As New DataSet
    Public dt As DataTable
    Public lokasi As String

    Public Sub Koneksi()
        Try
            Dim lokasi As String
            lokasi = "Driver={MySQL ODBC 3.51 Driver};Database=saw_karyawanterbaik;server=localhost;uid=root;"
            conn = New OdbcConnection(lokasi)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

End Module
