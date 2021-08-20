using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Customers
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Customer_id { get; set; }
        public string Company_name { get; set; }
        public string Contact_name { get; set; }
        public string Contact_title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal_code { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string fax { get; set; }
    }
}
