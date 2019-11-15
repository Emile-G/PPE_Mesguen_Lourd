Public Class AC11

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.TOURNEE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TOURNEETableAdapter.Fill(Me.DataSet1.TOURNEE)
    End Sub

    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        Try
            Me.Hide()
            AC12_Ajouter.Show()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class