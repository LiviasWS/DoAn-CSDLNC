using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;

namespace DoAN_CSDLNC.Models
{
    [BsonIgnoreExtraElements] // tránh vỡ nếu DB dư field
    public class NguyenLieu
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("sku")] public string SKU { get; set; }
        [BsonElement("name")] public string Name { get; set; }
        [BsonElement("group")] public string Group { get; set; }
        [BsonElement("supplier")] public string Supplier { get; set; }
        [BsonElement("warehouse")] public string Warehouse { get; set; }
        [BsonElement("uomBase")] public string UomBase { get; set; }
        [BsonElement("uomAlt")] public string UomAlt { get; set; }

        // nullable
        [BsonElement("conversionRate")]
        [BsonIgnoreIfNull]
        public int? ConversionRate { get; set; }

        [BsonElement("priceIn")]
        [BsonIgnoreIfNull]
        public decimal? PriceIn { get; set; }

        [BsonElement("minStock")]
        [BsonIgnoreIfNull]
        public int? MinStock { get; set; }

        [BsonElement("maxStock")]
        [BsonIgnoreIfNull]
        public int? MaxStock { get; set; }

        [BsonElement("batch")] public string Batch { get; set; }
        [BsonElement("mfgDate")] public DateTime? MfgDate { get; set; }
        [BsonElement("expDate")] public DateTime? ExpDate { get; set; }

        [BsonElement("fefo")]
        [BsonIgnoreIfNull]
        public bool? Fefo { get; set; }

        [BsonElement("lossPercent")]
        [BsonIgnoreIfNull]
        public double? LossPercent { get; set; }

        [BsonElement("note")] public string Note { get; set; }
    }
}
