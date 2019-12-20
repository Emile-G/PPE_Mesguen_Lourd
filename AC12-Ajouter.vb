Public Class AC12_Ajouter
    Dim donnee As DataTable

    Private Sub AC12_Modifier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myCommande.Connection = myConnection
        InitChauff()
        InitVehicule()

    End Sub

    Private Sub ListeChauffeurs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeChauffeurs.SelectedIndexChanged
    End Sub

    'RETOUR A LA LISTE DES TOURNEES
    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC11.Show()
        Me.Close()
    End Sub

    'INSERTION DE LA TOURNEE
    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click
        Dim Veh As String = ListeVehicules.Text.ToString
        Dim Comm As String = TextBox1.Text.ToString
        Dim PEC As String = "NULL"

        Try
            Dim InsertTournee As String = "INSERT INTO TOURNEE(VEHIMMAT,CHFID,TRNCOMMENTAIRE,TRNDTE) VALUES('" & Veh & "','" & ListeChauffeurs.SelectedValue & "','" & Comm & "',TO_DATE('" & TRNDTE.Text & "', 'dd/MM/yy'));"
            myCommande = New Odbc.OdbcCommand(InsertTournee, myConnection)
            myCommande.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        AC11.Show()
        Me.Close()
    End Sub


    'FONCTIONS

    'REMPLIT LA LISTE DES CHAUFFEURS GRACE AU DICTIONNAIRE DE DONNEES
    Public Sub InitChauff()
        Dim queryCHF As String = "SELECT CHFID, CHFNOM FROM CHAUFFEUR ORDER BY CHFID ASC;"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(queryCHF, myConnection)
        myAdapter.Fill(donnee)

        ListeChauffeurs.DataSource = donnee
        ListeChauffeurs.DisplayMember = "CHFNOM"
        ListeChauffeurs.ValueMember = "CHFID"
    End Sub

    'REMPLIT LA LISTE DES VEHICULES
    Public Sub InitVehicule()
        Dim queryVEH As String = "SELECT VEHIMMAT FROM VEHICULE"
        myCommande.CommandText = queryVEH
        myReader = myCommande.ExecuteReader

        While myReader.Read
            ListeVehicules.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        ListeVehicules.SelectedIndex = 0
    End Sub
    
End Class