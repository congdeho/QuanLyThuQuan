using MySql.Data.MySqlClient;
using System;
using System.Data;

public static class Database
{
    private static readonly string connectionString = "Server=localhost;Port=3306;Database=quanlythuquan;User ID=root;Password=13376655" +";";
    private static readonly MySqlConnection connection = new MySqlConnection(connectionString);

    public static MySqlConnection Connection
    {
        get
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                connection.Open();
            return connection;
        }
    }

    public static void Close()
    {
        if (connection.State == ConnectionState.Open)
            connection.Close();
    }
}
