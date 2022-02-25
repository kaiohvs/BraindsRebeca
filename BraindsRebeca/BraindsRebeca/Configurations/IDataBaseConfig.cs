using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BraindsRebeca.API.Configurations
{
    public interface IDataBaseConfig
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
