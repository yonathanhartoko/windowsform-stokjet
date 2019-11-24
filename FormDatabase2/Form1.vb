Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        AddDataKamar()
    End Sub

    Sub Connection()
        conn = New MySqlConnection
        conn.ConnectionString = "server='localhost';user='user';password='password';database='stokjet'"
        conn.Open()
    End Sub

    Sub AddDataKamar()
        Dim command As MySqlCommand
        If namajet.Text = "" Or jumlah.Value = "0" Or harga.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong!")
        Else
            Dim varnamajet As String = namajet.Text
            Dim vartipejet As Integer = 1
            If ag.Checked = True Then
                vartipejet = 2
            ElseIf hybrid.Checked = True Then
                vartipejet = 3
            End If
            Dim varjumlah As Integer = jumlah.Value
            Dim varharga As String = harga.Text
            Call Connection()
            Dim save As String = "insert into datajet(`namajet`,`tipejet`,`jumlah`,`harga`) values('" & varnamajet & "','" & vartipejet & "','" & varjumlah & "','" & varharga & "')"
            command = New MySqlCommand(save, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput")
            Call Display()

        End If
    End Sub

    Sub Display()
        Dim dataadapter As MySqlDataAdapter
        Dim dataset As New DataSet
        Call Connection()
        dataadapter = New MySqlDataAdapter("select * from datajet", conn)
        dataset = New DataSet
        dataadapter.Fill(dataset, "datajet")
        viewbox.DataSource = dataset.Tables("datajet")
        viewbox.ReadOnly = True
    End Sub

    Sub EmptyForm()
        namajet.Text = ""
        aa.Checked = False
        ag.Checked = False
        hybrid.Checked = False
        jumlah.Value = 0
        harga.Text = ""
    End Sub

End Class
