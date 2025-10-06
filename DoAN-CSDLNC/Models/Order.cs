using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("table_id")]
        public string TableId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("customer_id")]
        public string CustomerId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("employee_id")]
        public string EmployeeId { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("total_amount")]
        public decimal TotalAmount { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonIgnore]
        public string PaymentMethod { get; set; }
    }
}
