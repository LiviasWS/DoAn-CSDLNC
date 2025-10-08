using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class OrderItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("order_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OrderId { get; set; }

        [BsonElement("product_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        [BsonElement("size")]
        public string Size { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("toppings")]
        public List<Topping> Toppings { get; set; }
    }
}
