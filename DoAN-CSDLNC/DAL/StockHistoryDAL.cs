using DoAN_CSDLNC.Data;
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

        public List<StockHistory> Find(string sku = null, string action = null, string username = null,
                                       DateTime? from = null, DateTime? to = null, int limit = 1000)
        {
            var fb = Builders<StockHistory>.Filter;
            var f = fb.Empty;

            if (!string.IsNullOrWhiteSpace(sku)) f &= fb.Eq(x => x.SKU, sku);
            if (!string.IsNullOrWhiteSpace(action)) f &= fb.Eq(x => x.Action, action);
            if (!string.IsNullOrWhiteSpace(username)) f &= fb.Eq(x => x.Username, username);
            if (from.HasValue) f &= fb.Gte(x => x.CreatedAt, from.Value);
            if (to.HasValue) f &= fb.Lte(x => x.CreatedAt, to.Value);

            return _hist.Find(f).SortByDescending(x => x.CreatedAt).Limit(limit).ToList();
        }
    }
}
