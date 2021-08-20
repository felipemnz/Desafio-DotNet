using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Employees
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Employee_id { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public string Title { get; set; }
        public string Title_of_courtesy { get; set; }
        public DateTime Birth_date { get; set; }
        public DateTime hire_date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal_code { get; set; }
        public string Country { get; set; }
        public string Home_phone { get; set; }
        public string Extension { get; set; }
        public string Photo { get; set; }
        public long Reports_to { get; set; }
        public string Photo_path { get; set; }
    }
}
