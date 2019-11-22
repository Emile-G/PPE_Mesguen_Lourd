Module ModuleGlobal
    Public myConnection As New Odbc.OdbcConnection
    Public myCommande As New Odbc.OdbcCommand
    Public myReader As Odbc.OdbcDataReader
    Public myAdapter As New Odbc.OdbcDataAdapter
    Public myBuilder As New Odbc.OdbcCommandBuilder
    Public connString As String
    Public trnnum As Integer
    Public etpid As Integer
End Module
