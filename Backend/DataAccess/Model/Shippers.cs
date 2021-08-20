using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Shippers
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Shipper_id { get; set; }
        public string Company_name { get; set; }
        public string phone { get; set; }
    }
}
