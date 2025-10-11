using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DoAN_CSDLNC.DAL
{
    public class StockHistoryDAL
    {
        private readonly IMongoCollection<StockHistory> _hist;

        public StockHistoryDAL()
        {
            var db = new DBConnection();
            _hist = db.GetCollection<StockHistory>("StockHistory");

            // Index gợi ý cho truy vấn nhanh
            var keys = Builders<StockHistory>.IndexKeys
                .Descending(x => x.CreatedAt)
                .Ascending(x => x.SKU)
                .Ascending(x => x.Username)
                .Ascending(x => x.Action);
            _hist.Indexes.CreateOne(new CreateIndexModel<StockHistory>(keys));
        }

        public void Insert(StockHistory h) => _hist.InsertOne(h);

        public List<StockHistory> GetAll(int limit = 1000) =>
            _hist.Find(FilterDefinition<StockHistory>.Empty)
                 .SortByDescending(x => x.CreatedAt)
                 .Limit(limit)
                 .ToList();

        public List<StockHistory> Filter(string sku, string user, string action,
                                 DateTime? fromUtc, DateTime? toUtc)
        {
            var f = Builders<StockHistory>.Filter;
            var filter = f.Empty;

            if (!string.IsNullOrWhiteSpace(sku))
                filter &= f.Regex(x => x.SKU, new MongoDB.Bson.BsonRegularExpression(sku.Trim(), "i"));

            if (!string.IsNullOrWhiteSpace(user))
                filter &= f.Regex(x => x.Username, new MongoDB.Bson.BsonRegularExpression(user.Trim(), "i"));

            if (!string.IsNullOrWhiteSpace(action))
                filter &= f.Eq(x => x.Action, action);

            if (fromUtc.HasValue)
                filter &= f.Gte(x => x.CreatedAt, fromUtc.Value);

            if (toUtc.HasValue)
                filter &= f.Lte(x => x.CreatedAt, toUtc.Value);

            return _hist.Find(filter).SortByDescending(x => x.CreatedAt).ToList();
        }

    }
}
