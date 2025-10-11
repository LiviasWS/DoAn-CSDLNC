using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DoAN_CSDLNC.Models
{
    public class StockHistory
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("productId")]
        public string ProductId { get; set; }

        [BsonElement("sku")]
        public string SKU { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        // IN | OUT | TRANSFER | COUNT | ADJUST (tùy bạn dùng)
        [BsonElement("action")]
        public string Action { get; set; }

        // Số lượng thay đổi (+ nhập, - xuất, 0 nếu chuyển kho/không chênh lệch)
        [BsonElement("qty")]
        public int Qty { get; set; }

        [BsonElement("beforeQty")]
        public int BeforeQty { get; set; }

        [BsonElement("afterQty")]
        public int AfterQty { get; set; }

        [BsonElement("warehouse")]
        public string Warehouse { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("note")]
        public string Note { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; } // lưu UTC
    }
}
