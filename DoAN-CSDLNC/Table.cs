using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class Table
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("table_number")]
        public int TableNumber { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
    }
}
