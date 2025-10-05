using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class Payment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("customer_id")]
        public string CustomerId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("employee_id")]
        public string EmployeeId { get; set; }

        [BsonElement("method")]
        public string Method { get; set; }

        [BsonElement("total_cost")]
        public int TotalCost { get; set; }

        [BsonElement("date_create")]
        public DateTime DateCreate { get; set; }
    }
}
