using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class NorthwindDataBaseSettings : INorthwindDataBaseSettings
    {
        public string NorthwindCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }

    public interface INorthwindDataBaseSettings
    {
        string NorthwindCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}
