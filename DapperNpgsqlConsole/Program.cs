using System;
using System.Data;

using Dapper;
using Npgsql;

namespace DapperNpgsqlConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Test : IDisposable
    {
        private readonly IDbConnection dbConnection;

        public Test()
        {
            dbConnection = new NpgsqlConnection("Server=192.168.2.4;Port=5432;User Id=beer_tracker_dev;Password=btdev;Database=beer_tracker_dev;");
            dbConnection.Open();
        }

        public void TestQuery()
        {
            //var rows = dbConnection.Query("select * from beers");

            var beer = dbConnection.Query<Beer>("select * from beers");
        }

        public void Dispose()
        {
            dbConnection.Close();
        }
    }

    public class Beer
    {
        public int Beer_Id { get; set; }
        public string Name { get; set; }
        public decimal Abv { get; set; }
        public int Style_Id { get; set; }

    }  
}
