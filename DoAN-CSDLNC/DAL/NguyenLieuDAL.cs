using DoAN_CSDLNC.Data;
using Hethongbancafe.CafeManagement.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.DAL
{
    public class NguyenLieuDAL
    {
        private readonly IMongoCollection<NguyenLieu> _nguyenLieus;

        public NguyenLieuDAL()
        {
            var db = new DBConnection();
            _nguyenLieus = db.GetCollection<NguyenLieu>("Nguyenlieu");
        }

        public void AddNguyenLieu(NguyenLieu nl)
        {
            _nguyenLieus.InsertOne(nl);
        }

        public List<NguyenLieu> GetAllNguyenLieus()
        {
            return _nguyenLieus.Find(new BsonDocument()).ToList();
        }

        public NguyenLieu GetNguyenLieuById(string id)
        {
            return _nguyenLieus.Find(n => n.Id == id).FirstOrDefault();
        }

        public void UpdateNguyenLieu(string id, NguyenLieu updated)
        {
            _nguyenLieus.ReplaceOne(n => n.Id == id, updated);
        }

        public void DeleteNguyenLieu(string id)
        {
            _nguyenLieus.DeleteOne(n => n.Id == id);
        }
        public class InventoryDAL
        {
            private readonly IMongoCollection<Inventory> _inventory;

            public InventoryDAL()
            {
                var db = new DBConnection();
                _inventory = db.GetCollection<Inventory>("Inventory");
            }

            public async Task<long> GetTotalQtyByProductAsync(string productId)
            {
                var filter = Builders<Inventory>.Filter.Eq(x => x.ProductId, productId);
                var list = await _inventory.Find(filter).ToListAsync();
                return list.Sum(x => x.Quantity);
            }

            public async Task<List<(string BatchId, long Quantity)>> GetQtyPerBatchAsync(string productId)
            {
                var filter = Builders<Inventory>.Filter.Eq(x => x.ProductId, productId);
                var list = await _inventory.Find(filter).ToListAsync();
                return list.GroupBy(x => x.BatchId)
                           .Select(g => (g.Key, g.Sum(z => z.Quantity)))
                           .ToList();
            }
        }
    }
}
