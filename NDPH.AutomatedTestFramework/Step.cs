using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPH.AutomatedTestFramework
{
    public class Step
    {
        public String ScenarioName { get; set; }
        public int StepNumber { get; set; }
        public string ActionName { get; set; }
        public ElementInfo ElementInformation { get; set; }
        public int WaitingTime { get; set; }
        public string XpathExpression { get; set; }
        public string FrameId { get; set; }
        public string FilePath { get; set; }
    }
}
