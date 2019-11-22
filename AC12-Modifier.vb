Public Class AC12_Modifier
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
        myCommand.Connection = myConnection

        'Recupération des noms des chauffeurs
        Dim queryCHF As String = "SELECT CHFNOM FROM CHAUFFEUR"
        myCommand.CommandText = queryCHF
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeChauffeurs.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()

        'Recupération des immatriculations des vehicules
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        myCommand.CommandText = queryVEH
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeVehicules.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()

        'Recupération des identifiants des remorques
        Dim queryREM As String = "SELECT IDREMORQUE FROM REMORQUE"
        myCommand.CommandText = queryREM
        myReader = myCommand.ExecuteReader

        ListeRemorques.Items.Add("Pas de remorques")

        While myReader.Read
            ListeRemorques.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()

        ListeRemorques.SelectedIndex = 0
    End Sub

    Private Sub ListeChauffeurs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeChauffeurs.SelectedIndexChanged

    End Sub
End Class