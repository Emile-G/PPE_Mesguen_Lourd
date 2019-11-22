Public Class AC12_Modifier
    'Dictionnaire de données liant les noms des chauffeurs à leur CHFID
    Dim comboSource As New Dictionary(Of String, String)()
    Dim key As String
    Dim value As String

    'Table de données contenant les ETPID et les LIEUNOM associées à la tournée
    Dim donnee As DataTable

    Private Sub AC12_Modifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myCommande.Connection = myConnection
        InitChauffeur()
        InitVehicules()
        InitComm()
        AfficherEtapes()
    End Sub


    Private Sub ListeChauffeurs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeChauffeurs.SelectedIndexChanged
        key = DirectCast(ListeChauffeurs.SelectedItem, KeyValuePair(Of String, String)).Key
        value = DirectCast(ListeChauffeurs.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    'RETOUR VERS LISTE DES TOURNEES    
    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC11.Show()
        Me.Close()
    End Sub

    'MISE A JOUR DE LA TOURNEE
    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click
        'Mise à jour de la tournée

        Dim Veh As String = ListeVehicules.Text.ToString
        Dim Comm As String = TextBox1.Text.ToString
        Dim PEC As String = "NULL"

        Try
            Dim UpdateTournee As String = "UPDATE TOURNEE SET TRNDTE = TO_DATE('" & TRNDTE.Text & "', 'dd/MM/yy'), CHFID = '" & key & "', VEHIMMAT = '" & Veh & "', TRNCOMMENTAIRE = '" & Comm & "' WHERE TRNNUM = " & trnnum & ";"

            myCommande = New Odbc.OdbcCommand(UpdateTournee, myConnection)
            myCommande.ExecuteNonQuery()

            MessageBox.Show("Mise à jour réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AC11.Show()
        Me.Close()
    End Sub

    'REDIRECTION VERS AJOUT D'ETAPE
    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        AC13_Ajouter.Show()
        Me.Close()
    End Sub

    'REDIRECTION VERS MODIFICATION D'ETAPE
    Private Sub Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifier.Click
        'AC13-Modifier.Show()
        Me.Hide()
    End Sub

    'SUPPRIMER UNE ETAPE
    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Dim etpid As Integer
        etpid = GrilleEtapes.CurrentRow.Cells.Item(0).Value
        Try
            myCommande = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE ETPID = " & etpid & " AND TRNNUM = " & trnnum & ";", myConnection)
            myCommande.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        AfficherEtapes()
    End Sub



    'FONCTIONS

    'REMPLIT LA GRILLEETAPES AVEC LES ETPID ET LES LIEUNOM ASSOCIES A LA TOURNEE
    Public Sub AfficherEtapes()

        Dim Etapes = "SELECT ETPID, LIEUNOM  FROM ETAPE, LIEU WHERE ETAPE.LIEUID = LIEU.LIEUID AND ETAPE.TRNNUM = " & trnnum & ";"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(Etapes, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

        myAdapter.Fill(donnee)
        GrilleEtapes.DataSource = donnee

    End Sub

    'REMPLIT LA LISTE CHAUFFEUR GRACE AU DICTIONNAIRE DE DONNEES ET SELECTIONNE LE CHAUFFEUR ASSOCIE A LA TOURNEE PAR DEFAUT
    Public Sub InitChauffeur()
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

        'Récupération du 1er CHFID de la table CHAUFFEUR dans l'ordre alphabétique
        Dim queryCHFID1 As String = "SELECT CHFID FROM CHAUFFEUR WHERE ROWNUM <= 1 ORDER BY CHFID ASC;"
        myCommande = New Odbc.OdbcCommand(queryCHFID1, myConnection)
        Dim premierCHFID As String = myCommande.ExecuteScalar()

        'Récupération du CHFID s'occupant de la tournée
        Dim queryCHFTournee As String = "SELECT CHFID FROM TOURNEE WHERE TRNNUM =" & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryCHFTournee, myConnection)
        Dim CHFIDvoulu As String = myCommande.ExecuteScalar()


        'Récupération de l'index du chauffeur
        Dim queryIndexCHF As String = "SELECT COUNT(*) FROM CHAUFFEUR WHERE CHFID BETWEEN '" & premierCHFID & "' AND '" & CHFIDvoulu & "' ;"
        myCommande = New Odbc.OdbcCommand(queryIndexCHF, myConnection)
        Dim IndexCHF As Integer = myCommande.ExecuteScalar()

        ListeChauffeurs.SelectedIndex = IndexCHF - 1
    End Sub

    'REMPLIT LA LISTE VEHICULES ET SELECTIONNE LE VEHICULE ASSOCIE A LA TOURNEE PAR DEFAUT
    Public Sub InitVehicules()
        'Recupération des immatriculations des vehicules
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        myCommande.CommandText = queryVEH
        myReader = myCommande.ExecuteReader

        While myReader.Read
            ListeVehicules.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        'Récupération de la première immatriculation dans l'ordre
        Dim queryImmat1 As String = "SELECT VEHIMMAT FROM VEHICULE WHERE ROWNUM <= 1 ORDER BY VEHIMMAT ASC;"
        myCommande = New Odbc.OdbcCommand(queryImmat1, myConnection)
        Dim premierImmat As String = myCommande.ExecuteScalar()

        'Récupération de l'immatriculation du véhicule s'occupant de la tournée
        Dim queryImmatTournee As String = "SELECT VEHIMMAT FROM TOURNEE WHERE TRNNUM =" & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryImmatTournee, myConnection)
        Dim Immatvoulu As String = myCommande.ExecuteScalar()


        'Récupération de l'index du véhicule
        Dim queryIndexVEHIMMAT As String = "SELECT COUNT(*) FROM VEHICULE WHERE VEHIMMAT BETWEEN '" & premierImmat & "' AND '" & Immatvoulu & "' ;"
        myCommande = New Odbc.OdbcCommand(queryIndexVEHIMMAT, myConnection)
        Dim IndexVEHIMMAT As Integer = myCommande.ExecuteScalar()

        ListeVehicules.SelectedIndex = IndexVEHIMMAT - 1
    End Sub

    'REMPLIT LA TEXTBOX COMMENTAIRE PAR LE COMMENTAIRE ASSOCIE A LA TOURNEE
    Public Sub InitComm()
        'Récupération du commentaire de la tournée
        Dim queryCommTournee As String = "SELECT TRNCOMMENTAIRE FROM TOURNEE WHERE TRNNUM = " & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryCommTournee, myConnection)
        Dim CommTournee As String = myCommande.ExecuteScalar()

        TextBox1.Text = CommTournee
    End Sub

End Class