// Models/StockHistory.cs
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Hethongbancafe.CafeManagement.Models
{
    public class StockHistory
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("sku")]
        public string SKU { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }      // tiện xem

        [BsonElement("action")]
        public string Action { get; set; }    // IN | OUT | TRANSFER | CREATE | UPDATE | DELETE

        [BsonElement("quantity")]
        public int Quantity { get; set; }     // với TRANSFER thì ghi số lượng tác động (tuỳ bạn)

        [BsonElement("fromWarehouse")]
        public string FromWarehouse { get; set; }

        [BsonElement("toWarehouse")]
        public string ToWarehouse { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }  // <== ai thao tác

        [BsonElement("note")]
        public string Note { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
