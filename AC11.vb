Public Class AC11
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        connString = "DSN=CNXORA_Mesguen;Uid=U_Mesguen;Pwd=estran;"
        myConnection.ConnectionString = connString
        myConnection.Open()

    End Sub

    Private Sub Supprimer_Click(sender As System.Object, e As System.EventArgs) Handles Supprimer.Click

    End Sub
End Class