Public Class AC13_Modifier
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNXORA_Mesguen;Uid=u_mesguen;PWd=estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myCommand.Connection = myConnection

        'Récupération de la liste lieu
        Dim queryCHF As String = "SELECT LIEUNOM FROM LIEU"
        myCommand.CommandText = queryCHF
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeLieux.Items.Add(myReader.GetString(0))
        End While
        myReader.Close()


        'Affichage de la date + Heure d'aujourd'hui
        TextBox1.Text = Date.Now
    End Sub

    Private Sub ListeLieux_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeLieux.SelectedIndexChanged

    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        Me.Hide()
        AC12_Modifier.Show()
        Me.Close()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

        myCommand.Connection = myConnection
        myCommand.CommandText = "UPDATE etape SET LIEUID, ETPHREMIN, ETPHREMAX, ETPHREDEBUT, ETPCOMMENTAIRE) VALUES ('' , @Lieu, @HeureMin, @HeureMax, @HeureDebut, @Commentaire)"
        Try
            AC12_Modifier.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class