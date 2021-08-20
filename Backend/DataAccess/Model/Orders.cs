using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Orders
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Order_id { get; set; }
        public string Employee_id { get; set; }
        public string Customer_id { get; set; }
        public string Shipper_id { get; set; }
        public DateTime Order_date { get; set; }
        public DateTime Required_date { get; set; }
        public DateTime Shipped_date { get; set; }
        public long Ship_via { get; set; }
        public long Freight { get; set; }
        public string Ship_name { get; set; }
        public string Ship_address { get; set; }
        public string Ship_city { get; set; }
        public string Ship_region { get; set; }
        public string Ship_postal_code { get; set; }
        public string Ship_country { get; set; }
    }
}
