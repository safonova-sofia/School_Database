Imports System.Data.OleDb

Module DBConnection

    Public Function strconnection() As OleDbConnection
        Return New OleDbConnection("Provider=SQLOLEDB;Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True")

    End Function
    Public strcon As OleDbConnection = strconnection()

End Module
