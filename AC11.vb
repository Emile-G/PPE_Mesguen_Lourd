Public Class AC11
    Dim myCommand As New Odbc.OdbcCommand

    Private Sub AC11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataSet1.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        
    End Sub

    Private Sub Supprimer_Click(sender As System.Object, e As System.EventArgs) Handles Supprimer.Click
        Dim ans As String
        trnnum = Convert.ToString(ListeTournees.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Vous les vous confirmer la suppression de la tournée N° " & trnnum & " ?", vbYesNo)
        If ans = vbYes Then
            myCommand = New Odbc.OdbcCommand("DELETE FROM ETAPE WHERE TRNNUM = " & trnnum & ";", myConnection)
            myCommand.ExecuteNonQuery()
            myCommand = New Odbc.OdbcCommand("DELETE FROM TOURNEE WHERE TRNNUM = " & trnnum & ";", myConnection)
            myCommand.ExecuteNonQuery()
            Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        End If
    End Sub

    Private Sub Modifier_Click(sender As System.Object, e As System.EventArgs) Handles Modifier.Click
        Dim ans As String
        trnnum = Convert.ToString(ListeTournees.CurrentRow.Cells.Item(0).Value)
        ans = MsgBox("Voulez vous modifier la tournée N° " & trnnum & " ?", vbYesNo)
        If ans = vbYes Then
            TestModifer.Show()
        End If
    End Sub
End Class