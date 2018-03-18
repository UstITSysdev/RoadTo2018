using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPH.AutomatedTestFramework
{
    public interface IScenarioReader
    {
        IEnumerable<Scenario> Read(string sheetName);
    }
}
