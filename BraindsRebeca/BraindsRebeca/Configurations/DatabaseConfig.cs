using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BraindsRebeca.API.Configurations
{
    public class DatabaseConfig : IDataBaseConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
