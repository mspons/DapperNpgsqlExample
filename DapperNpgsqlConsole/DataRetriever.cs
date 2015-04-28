﻿using System;
using System.Collections.Generic;
using System.Data;

using Dapper;
using Npgsql;

namespace DapperNpgsqlConsole
{
    public class DataRetriever : IDisposable
    {
        private readonly IDbConnection dbConnection;

        public DataRetriever(string connectionString)
        {
            dbConnection = new NpgsqlConnection(connectionString);
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
