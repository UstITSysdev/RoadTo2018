using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPH.AutomatedTestFramework
{
    public class Scenario
    {
        public Scenario()
        {
            this.Steps = new List<Step>();
        }
        public string Name { get; set; }
        public IList<Step> Steps { get; set; }
        
    }
}
