using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Hethongbancafe.CafeManagement.Models
{
    public class Inventory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("productId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        [BsonElement("batchId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BatchId { get; set; }

        [BsonElement("quantity")]
        public long Quantity { get; set; }

        [BsonElement("lastUpdatedAt")]
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("note")]
        public string Note { get; set; }
    }
}
