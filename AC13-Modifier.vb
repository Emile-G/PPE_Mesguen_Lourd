Public Class AC13_Modifier

    Dim ComboSource As New Dictionary(Of String, String)()
    Dim key As String
    Dim Value As String

    Dim CommEtape As String
    Dim PHOURL As String
    Dim PHOTIME As Date


    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myCommande.Connection = myConnection
        InitLieux()
        InitDate()
        InitComm()

        Try
            CachePhotos()
            InitPhotosID()
            AffichePhoto()
            AfficheHeurePhoto()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListeLieux_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeLieux.SelectedIndexChanged
        key = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Key
        Value = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    Private Sub ListePhotos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListePhotos.SelectedIndexChanged
        AffichePhoto()
        AfficheHeurePhoto()
    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC12_Modifier.Show()
        Me.Close()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

        Dim UpdateETP As String = "UPDATE etape SET LIEUID = '" & key & "', ETPHREMIN = TO_DATE('" & DateTimePicker1.Text.ToString & "','dd/MM/yy HH24:MI') , ETPHREMAX = TO_DATE('" & DateTimePicker2.Text.ToString & "','dd/MM/yy HH24:MI'), ETPHREDEBUT = NULL, ETPCOMMENTAIRE = '" & TextBox2.Text.ToString & "' WHERE TRNNUM =" & trnnum & " AND ETPID = '" & etpid.ToString & "';"
        myCommande = New Odbc.OdbcCommand(UpdateETP, myConnection)
        myCommande.ExecuteNonQuery()
        AC12_Modifier.Show()
        Me.Close()

    End Sub

    'FONCTIONS

    'Recupération de la liste Lieu
    Public Sub InitLieux()
        Dim queryLieu As String = "SELECT LIEUID, LIEUNOM  FROM LIEU ORDER BY LIEUID ASC;"
        myCommande.CommandText = queryLieu
        myReader = myCommande.ExecuteReader

        While myReader.Read
            ComboSource.Add(myReader.GetString(0).Trim.ToString, myReader.GetString(1).Trim.ToString)
        End While
        myReader.Close()
        ListeLieux.DataSource = New BindingSource(ComboSource, Nothing)
        ListeLieux.DisplayMember = "Value"

        'Récupération du 1er LieuID de la table Lieu dans l'ordre alphabétique
        Dim queryLIEUID1 As String = "SELECT LieuID FROM LIEU WHERE ROWNUM <= 1 ORDER BY LIEUID ASC;"
        myCommande = New Odbc.OdbcCommand(queryLIEUID1, myConnection)
        Dim premierLIEUID As String = myCommande.ExecuteScalar()

        'Récupération du LieuID s'occupant de la tournée
        Dim queryLIEUETP As String = "SELECT LIEUID FROM ETAPE WHERE TRNNUM =" & trnnum & " AND ETPID = '" & etpid.ToString & "';"
        myCommande = New Odbc.OdbcCommand(queryLIEUETP, myConnection)
        Dim LIEUIDvoulu As String = myCommande.ExecuteScalar()


        'Récupération de l'index du lieu
        Dim queryIndexLIEU As String = "SELECT COUNT(*) FROM LIEU WHERE LIEUID BETWEEN '" & premierLIEUID & "' AND '" & LIEUIDvoulu & "' ;"
        myCommande = New Odbc.OdbcCommand(queryIndexLIEU, myConnection)
        Dim IndexLIEU As Integer = myCommande.ExecuteScalar()

        ListeLieux.SelectedIndex = IndexLIEU - 1
    End Sub

    'Pour afficher le bon format
    Public Sub InitDate()
        Dim queryFormat As String = "ALTER SESSION SET nls_date_format = 'dd/MM/YYYY HH24:mi';"
        myCommande = New Odbc.OdbcCommand(queryFormat, myConnection)
        myCommande.ExecuteNonQuery()

        'Recupération de l' heure mini
        Dim queryHREMIN As String = "SELECT ETPHREMIN FROM ETAPE WHERE TRNNUM =" & trnnum & " AND ETPID = '" & etpid.ToString & "';"
        myCommande = New Odbc.OdbcCommand(queryHREMIN, myConnection)
        Dim ETPHREMIN As Date = myCommande.ExecuteScalar()

        DateTimePicker1.Text = ETPHREMIN.ToString

        'Recupération de l' heure max
        Dim queryHREMAX As String = "SELECT ETPHREMAX FROM ETAPE WHERE TRNNUM =" & trnnum & " AND ETPID = '" & etpid.ToString & "';"
        myCommande = New Odbc.OdbcCommand(queryHREMAX, myConnection)
        Dim ETPHREMAX As Date = myCommande.ExecuteScalar()

        DateTimePicker2.Text = ETPHREMAX.ToString
    End Sub

    'Récupération du commentaire
    Public Sub InitComm()
        Dim queryCommEtape As String = "SELECT ETPCOMMENTAIRE FROM ETAPE WHERE TRNNUM = " & trnnum & " AND ETPID = '" & etpid & "';"
        myCommande = New Odbc.OdbcCommand(queryCommEtape, myConnection)

        Try
            CommEtape = myCommande.ExecuteScalar()
        Catch ex As Exception
            If (ex Is DBNull.Value) Then
                CommEtape = myCommande.ExecuteNonQuery()
            End If
        End Try

        TextBox2.Text = CommEtape
    End Sub

    'Affichage Photo
    Public Sub AffichePhoto()
        Dim queryPhoto As String = "SELECT PHOURL FROM TSPHOTO WHERE PHOID = " & ListePhotos.SelectedItem & ";"
        myCommande = New Odbc.OdbcCommand(queryPhoto, myConnection)

        Try
            PHOURL = myCommande.ExecuteScalar()
        Catch ex As Exception
            If (ex Is DBNull.Value) Then
                PHOURL = myCommande.ExecuteNonQuery()
            End If
        End Try

        Photo1.ImageLocation = PHOURL
    End Sub

    'Affichage de l'heure de la photo
    Public Sub AfficheHeurePhoto()
        Dim queryPhotoTime As String = "SELECT TO_DATE(PHOTIME, 'dd/MM/yy HH24:mi') FROM TSPHOTO WHERE PHOID = " & ListePhotos.SelectedItem & ";"
        myCommande = New Odbc.OdbcCommand(queryPhotoTime, myConnection)

        Try
            PHOTIME = myCommande.ExecuteScalar()
        Catch ex As Exception
            If (ex Is DBNull.Value) Then
                MessageBox.Show(ex.Message)
            End If
        End Try

        LabelHeurePhoto.Text = PHOTIME.ToString.Substring(0, PHOTIME.ToString.Length - 3)
    End Sub

    'Récupérations des id des photos afin de les insérer dans la combobox
    Public Sub InitPhotosID()
        Dim queryPHOID As String = "SELECT PHOID FROM TSPHOTO WHERE TRNNUM = " & trnnum & " AND ETPID = '" & etpid & "';"
        myCommande.CommandText = queryPHOID
        myReader = myCommande.ExecuteReader

        While myReader.Read
            ListePhotos.Items.Add(myReader.GetString(0).Trim)
        End While
        myReader.Close()

        ListePhotos.SelectedIndex = 0
    End Sub

    'Cacher le groupbox photos ou non 
    Public Sub CachePhotos()
        Dim CachePhotos = "SELECT PHOID FROM TSPHOTO WHERE TRNNUM = " & trnnum & " AND ETPID = '" & etpid & "';"
        myCommande.CommandText = CachePhotos
        myReader = myCommande.ExecuteReader

        If (myReader.HasRows) Then
            Photos.Visible = True
            myReader.Close()
        Else
            Photos.Visible = False
            PasdePhotos.Visible = True
            myReader.Close()
        End If

    End Sub

    Private Sub PasdePhotos_Click(sender As System.Object, e As System.EventArgs) Handles PasdePhotos.Click

    End Sub
End Class

