Public Class Page_Connexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myCommand2 As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myReader2 As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myAdapter2 As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim myBuilder2 As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim AC11 As New AC11()

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    End Sub


    Private Sub Connexion_Click_1(sender As System.Object, e As System.EventArgs) Handles Connexion.Click
        connString = "DSN=CNXORA_Mesguen;Uid=" & Login.Text & ";Pwd=" & Password.Text & ";"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
            'MessageBox.Show("Connexion Oracle Réussie")
            Me.Hide()
            AC11.Show()
            Me.Close()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
