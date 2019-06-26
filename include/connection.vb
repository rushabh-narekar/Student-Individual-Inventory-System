Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=127.0.0.1;user id=root;Password=;database=dbstudentindividualinventory;sslMode=none")
    End Function
    Public con As MySqlConnection = mysqldb()

End Module
