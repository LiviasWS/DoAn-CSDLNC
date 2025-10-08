using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class TableReserve
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("table")]
        public Table Table { get; set; }

        [BsonElement("customer")]
        public Customer Customer { get; set; }

        [BsonElement("start")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Start { get; set; }

        [BsonElement("end")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime End { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("date_create")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DateCreate { get; set; }
    }
}
