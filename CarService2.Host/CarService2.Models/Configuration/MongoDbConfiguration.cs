using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService3.Models.Configuration
{
    public class MongoDbConfiguration
    {

        public string ConectionString { get; set; } = string.Empty;

        public string DatabaseName { get; set; } = string.Empty;
        
    }
}
