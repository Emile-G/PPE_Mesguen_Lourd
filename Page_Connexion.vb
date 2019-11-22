Public Class Page_Connexion
    Dim AC11 As New AC11()

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    End Sub

    Private Sub Connexion_Click(sender As System.Object, e As System.EventArgs) Handles Connexion.Click
        connString = "DSN=CNXORA_Mesguen;Uid=" & Login.Text & ";Pwd=" & Password.Text & ";"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
            'MessageBox.Show("Connexion Oracle Réussie")
            AC11.Show()
            Me.Close()
        Catch ex As Odbc.OdbcException
            ErreurCo.Text = ("Login ou mot de passe incorrecte" + ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
