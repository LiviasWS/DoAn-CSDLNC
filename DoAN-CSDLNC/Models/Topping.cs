using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_CSDLNC.Models
{
    public class Topping
    {
        [BsonElement("product")]
        public Product Product { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}
