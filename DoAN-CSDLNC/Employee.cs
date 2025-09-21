using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("role")]
        public string Role { get; set; } // cashier, waiter, barista, security

        [BsonElement("isActive")]
        public bool IsActive { get; set; } = true;

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("id_number")]
        public string IdNumber { get; set; }

        [BsonElement("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
