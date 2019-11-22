Public Class AC13_Ajouter
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Dim TRNNUM As Integer = 1164392

    Dim ComboSource As New Dictionary(Of String, String)()
    Dim key As String
    Dim Value As String

    Dim MAXETPID As Integer

    
    Private Sub AC13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        connString = "DSN=CNXORA_Mesguen;Uid=u_mesguen;Pwd=estran;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
        myCommand.Connection = myConnection

        'Recupération de la liste Lieu
        Dim queryLieu As String = "SELECT LIEUID, LIEUNOM  FROM LIEU ORDER BY LIEUID ASC;"
        myCommand.CommandText = queryLieu
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ComboSource.Add(myReader.GetString(0).Trim.ToString, myReader.GetString(1).Trim.ToString)
        End While
        myReader.Close()
        ListeLieux.DataSource = New BindingSource(ComboSource, Nothing)
        ListeLieux.DisplayMember = "Value"

        
    End Sub

    Private Sub ListeLieux_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListeLieux.SelectedIndexChanged
        key = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Key
        Value = DirectCast(ListeLieux.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Retour_Click(sender As System.Object, e As System.EventArgs) Handles Retour.Click
        'AC12_Modifier.Show()
        Me.Close()
    End Sub

    Private Sub Valider_Click(sender As System.Object, e As System.EventArgs) Handles Valider.Click


        Dim queryETPID As String = "SELECT MAX(ETPID) FROM etape WHERE TRNNUM = " & TRNNUM & ";"
        myCommand = New Odbc.OdbcCommand(queryETPID, myConnection)
        MAXETPID = myCommand.ExecuteNonQuery()

        If (MAXETPID = -1) Then
            MAXETPID = 1
        Else
            MAXETPID = MAXETPID + 1
        End If

        Dim Commentaire As String = TextBox2.Text.ToString
        Dim PEC As String = "Null"

        Dim InsertETP As String = "INSERT INTO etape (TRNNUM, ETPID, LIEUID, ETPHREMIN, ETPHREMAX, ETPHREDEBUT, ETPCOMMENTAIRE) VALUES (" & TRNNUM & ",'" & MAXETPID.ToString & "' ,'" & key & "' ,TO_DATE('" & DateTimePicker1.Text.ToString & "','dd/MM/yy HH24:MI'), TO_DATE('" & DateTimePicker2.Text.ToString & "','dd/MM/yy HH24:MI')," & PEC & ",'" & Commentaire & "');"
        myCommand = New Odbc.OdbcCommand(InsertETP, myConnection)
        myCommand.ExecuteNonQuery()

        'AC12_Modifier.Show()
        'Me.Close()
    End Sub

    
End Class