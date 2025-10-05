using Hethongbancafe.CafeManagement.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAN_CSDLNC.Data;

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

        // Create
        public async Task AddNguyenLieuAsync(NguyenLieu nl)
        {
            await _nguyenLieus.InsertOneAsync(nl);
        }

        // Read all
        public async Task<List<NguyenLieu>> GetAllNguyenLieusAsync()
        {
            return await _nguyenLieus.Find(new BsonDocument()).ToListAsync();
        }

        // Read by Id
        public async Task<NguyenLieu> GetNguyenLieuByIdAsync(string id)
        {
            return await _nguyenLieus.Find(n => n.Id == id).FirstOrDefaultAsync();
        }

        // Update
        public async Task UpdateNguyenLieuAsync(string id, NguyenLieu updated)
        {
            await _nguyenLieus.ReplaceOneAsync(n => n.Id == id, updated);
        }

        // Delete
        public async Task DeleteNguyenLieuAsync(string id)
        {
            await _nguyenLieus.DeleteOneAsync(n => n.Id == id);
        }
    }
}
