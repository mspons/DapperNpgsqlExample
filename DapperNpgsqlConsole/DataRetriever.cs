using System;
using System.Collections.Generic;
using System.Data;

using Dapper;
using Npgsql;

namespace DapperNpgsqlConsole
{
    public class DataRetriever : IDisposable
    {
        private readonly IDbConnection dbConnection;

        public DataRetriever()
        {
            dbConnection = new NpgsqlConnection("Server=192.168.2.4;Port=5432;User Id=beer_tracker_dev;Password=btdev;Database=beer_tracker_dev;");
            dbConnection.Open();
        }

        public IEnumerable<Beer> GetBeers()
        {
            return dbConnection.Query<Beer>("select * from beers");
        }

        public IEnumerable<Style> GetStyles()
        {
            return dbConnection.Query<Style>("select * from styles");
        }

        public void Dispose()
        {
            dbConnection.Close();
        }
    }
}
