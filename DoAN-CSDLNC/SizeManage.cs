using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class SizeManage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("product_id")]
        public string ProductId { get; set; }

        [BsonElement("size")]
        public string Size { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }
    }
}
