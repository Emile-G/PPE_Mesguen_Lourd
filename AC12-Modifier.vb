Public Class AC12_Modifier

    'Table de données contenant les ETPID et les LIEUNOM associées à la tournée
    Dim donneeETP As DataTable
    Dim donneeCHF As DataTable
    Dim donneeVEH As DataTable

    Private Sub AC12_Modifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myCommande.Connection = myConnection
        InitChauffeur()
        InitVehicules()
        InitComm()
        AfficherEtapes()
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
            Dim UpdateTournee As String = "UPDATE TOURNEE SET TRNDTE = TO_DATE('" & TRNDTE.Text & "', 'dd/MM/yy'), CHFID = '" & ListeChauffeurs.SelectedValue & "', VEHIMMAT = '" & Veh & "', TRNCOMMENTAIRE = '" & Comm & "' WHERE TRNNUM = " & trnnum & ";"

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
        Dim ans As String
        etpid = Convert.ToString(GrilleEtapes.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Voulez vous modifier l'étape N° " & etpid & " ?", vbYesNo)
        If ans = vbYes Then
            AC13_Modifier.Show()
            Me.Close()
        End If
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

        donneeETP = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(Etapes, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)

        myAdapter.Fill(donneeETP)
        GrilleEtapes.DataSource = donneeETP

    End Sub

    'REMPLIT LA LISTE CHAUFFEUR GRACE AU DICTIONNAIRE DE DONNEES ET SELECTIONNE LE CHAUFFEUR ASSOCIE A LA TOURNEE PAR DEFAUT
    Public Sub InitChauffeur()
        'Recupération des noms des chauffeurs
        Dim queryCHF As String = "SELECT CHFID, CHFNOM FROM CHAUFFEUR ORDER BY CHFID ASC;"
        donneeCHF = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(queryCHF, myConnection)
        myAdapter.Fill(donneeCHF)

        ListeChauffeurs.DataSource = donneeCHF
        ListeChauffeurs.DisplayMember = "CHFNOM"
        ListeChauffeurs.ValueMember = "CHFID"

        'Récupération du CHFID s'occupant de la tournée
        Dim queryCHFTournee As String = "SELECT CHFID FROM TOURNEE WHERE TRNNUM =" & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryCHFTournee, myConnection)
        Dim CHFIDvoulu As String = myCommande.ExecuteScalar()

        ListeChauffeurs.SelectedValue = CHFIDvoulu
    End Sub

    'REMPLIT LA LISTE VEHICULES ET SELECTIONNE LE VEHICULE ASSOCIE A LA TOURNEE PAR DEFAUT
    Public Sub InitVehicules()
        'Recupération des immatriculations des vehicules
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        donneeVEH = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(queryVEH, myConnection)
        myAdapter.Fill(donneeVEH)

        ListeVehicules.DataSource = donneeVEH
        ListeVehicules.DisplayMember = "VEHIMMAT"
        ListeVehicules.ValueMember = "VEHIMMAT"

        'Récupération de l'immatriculation du véhicule s'occupant de la tournée
        Dim queryImmatTournee As String = "SELECT VEHIMMAT FROM TOURNEE WHERE TRNNUM =" & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryImmatTournee, myConnection)
        Dim Immatvoulu As String = myCommande.ExecuteScalar()

        ListeVehicules.SelectedValue = Immatvoulu
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