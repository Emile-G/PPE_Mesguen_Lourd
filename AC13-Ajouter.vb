Public Class AC13_Ajouter
    Dim donnee As DataTable

    Dim ComboSource As New Dictionary(Of String, String)()
    Dim key As String
    Dim Value As String

    Dim MAXETPID As String


    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myCommande.Connection = myConnection
        InitLieux()
    End Sub

    Private Sub ListeLieux_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeLieux.SelectedIndexChanged
        key = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Key
        Value = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        AC12_Modifier.Show()
        Me.Close()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click

        Dim queryETPID As String = "SELECT MAX(ETPID) FROM ETAPE WHERE TRNNUM = " & trnnum & ";"
        myCommande = New Odbc.OdbcCommand(queryETPID, myConnection)

        Try
            MAXETPID = myCommande.ExecuteScalar()
        Catch ex As Exception
            If (ex Is DBNull.Value) Then
                MAXETPID = myCommande.ExecuteNonQuery()
            End If
        End Try

        If (MAXETPID = -1) Then
            MAXETPID = MAXETPID + 2
        Else
            MAXETPID = MAXETPID + 1
        End If
        Dim Commentaire As String = TextBox2.Text.ToString
        Dim PEC As String = "Null"

        Dim InsertETP As String = "INSERT INTO etape (TRNNUM, ETPID, LIEUID, ETPHREMIN, ETPHREMAX, ETPHREDEBUT, ETPCOMMENTAIRE) VALUES (" & trnnum & ",'" & MAXETPID.ToString & "' ,'" & key & "' ,TO_DATE('" & DateTimePicker1.Text.ToString & "','dd/MM/yy HH24:MI'), TO_DATE('" & DateTimePicker2.Text.ToString & "','dd/MM/yy HH24:MI')," & PEC & ",'" & Commentaire & "');"
        myCommande = New Odbc.OdbcCommand(InsertETP, myConnection)
        myCommande.ExecuteNonQuery()

        AC12_Modifier.Show()
        Me.Close()
    End Sub

    'REMPLIT LA LISTE DES LIEUX GRACE AU DICTIONNAIRE DE DONNEES
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
    End Sub

End Class