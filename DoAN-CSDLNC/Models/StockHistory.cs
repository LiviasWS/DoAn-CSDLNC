using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DoAN_CSDLNC
{
    public class StockHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("productId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }      // Id của NguyenLieu

        [BsonElement("sku")]
        public string SKU { get; set; }            // tiện filter nhanh

        [BsonElement("name")]
        public string Name { get; set; }           // tên NL (snapshot)

        [BsonElement("action")]
        public string Action { get; set; }         // IN | OUT | TRANSFER | COUNT | ADJUST ...

        [BsonElement("qty")]
        public int Qty { get; set; }               // số lượng thay đổi (+/-)

        [BsonElement("beforeQty")]
        public int BeforeQty { get; set; }         // tồn trước khi thao tác

        [BsonElement("afterQty")]
        public int AfterQty { get; set; }          // tồn sau khi thao tác

        [BsonElement("warehouse")]
        public string Warehouse { get; set; }      // kho tác động (nếu có)

        [BsonElement("batchId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BatchId { get; set; }        // nếu có quản lý lô

        [BsonElement("refNo")]
        public string RefNo { get; set; }          // số chứng từ (nếu có)

        [BsonElement("username")]
        public string Username { get; set; }       // ai thực hiện

        [BsonElement("note")]
        public string Note { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
