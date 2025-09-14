using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Data
{
    public class DBConnection
    {
        private readonly IMongoDatabase _database;
        private readonly MongoClient _client;
        private readonly string _connectionString = "";
        private readonly string _databaseName = "";

        public DBConnection()
        {
            _client = new MongoClient(_connectionString);
            _database = _client.GetDatabase(_databaseName);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
