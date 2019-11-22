Public Class AC12_Ajouter
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.ConnectionString = connString
        End If
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
        myCommand.Connection = myConnection

        'Recupération des noms des chauffeurs
        Dim queryCHF As String = "SELECT CHFID,CHFNOM FROM CHAUFFEUR"
        myCommand.CommandText = queryCHF
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeChauffeurs.Items.Add(myReader.GetString(1).Trim)
        End While
        myReader.Close()

        'Recupération des immatriculations des vehicules
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        myCommand.CommandText = queryVEH
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeVehicules.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        'Recupération des identifiants des remorques
        Dim queryREM As String = "SELECT IDREMORQUE FROM REMORQUE"
        myCommand.CommandText = queryREM
        myReader = myCommand.ExecuteReader

        ListeRemorques.Items.Add("Pas de remorques")

        While myReader.Read
            ListeRemorques.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        ListeRemorques.SelectedIndex = 0
    End Sub

    Private Sub ListeChauffeurs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeChauffeurs.SelectedIndexChanged
        'Dim Verif As String = "SELECT PERMIS FROM CHAUFFEUR WHERE CHFID =" & ListeChauffeurs.SelectedValue

        MessageBox.Show(ListeChauffeurs.SelectedValue)
    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        Me.Close()
        AC11.Show()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

    End Sub
End Class