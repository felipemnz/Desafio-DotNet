using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Product_id { get; set; }
        public string Product_name { get; set; }
        public string Supplier_id { get; set; }
        public string Category_id { get; set; }
        public float Quantity_per_unit { get; set; }
        public float Unit_prince { get; set; }
        public long Units_in_stock { get; set; }
        public long Units_on_order { get; set; }
        public long Reorder_level { get; set; }
        public long Discontinued { get; set; }
    }
}
