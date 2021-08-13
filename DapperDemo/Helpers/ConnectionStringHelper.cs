using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public static class ConnectionStringHelper
    {
        public static string GetConnectionString(string key) => ConfigurationManager.ConnectionStrings[key].ConnectionString;
    }
}
