using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class CustomerDemographics
    {
        public ObjectId Customer_type_id { get; set; }
        public string Customer_desc { get; set; }
    }
}
