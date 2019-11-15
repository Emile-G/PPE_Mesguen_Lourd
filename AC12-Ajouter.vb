Public Class AC12_Ajouter
    Dim myCommande As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder

    Dim comboSource As New Dictionary(Of String, String)()

    Dim key As String
    Dim value As String

    Private Sub AC12_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.ConnectionString = connString
            Try
                myConnection.Open()
            Catch ex As Odbc.OdbcException
                MessageBox.Show(ex.Message)
            End Try
        End If
        myCommande.Connection = myConnection

        'Recupération des noms des chauffeurs
        Dim queryCHF As String = "SELECT CHFID, CHFNOM FROM CHAUFFEUR ORDER BY CHFID ASC;"
        myCommande.CommandText = queryCHF
        myReader = myCommande.ExecuteReader

        While myReader.Read
            comboSource.Add(myReader.GetString(0).Trim.ToString, myReader.GetString(1).Trim.ToString)
        End While
        myReader.Close()

        ListeChauffeurs.DataSource = New BindingSource(comboSource, Nothing)
        ListeChauffeurs.DisplayMember = "Value"

        'Recupération des immatriculations des vehicules
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        myCommande.CommandText = queryVEH
        myReader = myCommande.ExecuteReader

        While myReader.Read
            ListeVehicules.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        ListeVehicules.SelectedIndex = 0
    End Sub

    Private Sub ListeChauffeurs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeChauffeurs.SelectedIndexChanged
        key = DirectCast(ListeChauffeurs.SelectedItem, KeyValuePair(Of String, String)).Key
        value = DirectCast(ListeChauffeurs.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC11.Show()
        Me.Close()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click
        'Insertion de la tournée

        Dim Veh As String = ListeVehicules.Text.ToString
        Dim Comm As String = TextBox1.Text.ToString
        Dim PEC As String = "NULL"

        Try
            Dim InsertTournee As String = "INSERT INTO TOURNEE(VEHIMMAT,CHFID,TRNCOMMENTAIRE,TRNDTE) VALUES('" & Veh & "','" & key & "','" & Comm & "',TO_DATE('" & TRNDTE.Text & "', 'dd/MM/yy'));"
            myCommande = New Odbc.OdbcCommand(InsertTournee, myConnection)
            myCommande.ExecuteNonQuery()

            MessageBox.Show("Insertion réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AC11.Show()
        Me.Close()
    End Sub
End Class