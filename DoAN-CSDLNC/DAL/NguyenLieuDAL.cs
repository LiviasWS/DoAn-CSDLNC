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
    }
}
