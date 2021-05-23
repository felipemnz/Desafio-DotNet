using System;
using util;

namespace dbConn
{
    public abstract class Conn
    {
        public static string ConnString { get; private set; }

        public Conn()
        {
            var config = new JsonUtil().ReadTokensAppsettings();
            ConnString = config.GetSection("Conn:DB").Value;
        }
    }
}
