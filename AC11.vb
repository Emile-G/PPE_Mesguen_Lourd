Public Class AC11

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet11.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.DataSet11.DataTable2)
    End Sub
End Class