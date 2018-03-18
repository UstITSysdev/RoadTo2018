using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NDPH.AutomatedTestFramework
{
    public class AutomatedTestProcedure
    {


            
        public AutomatedTestProcedure(string url, IBrowserAutomator automator, IEnumerable<Scenario> scenarios)
        {
            this.url = url;
            this.automator = automator;
            this.scenarios = scenarios;
        }

        private IBrowserAutomator automator;
        private IEnumerable<Scenario> scenarios;
        private string url;

        public Boolean BeginTesting()
        {
            bool testResult = true;
            bool failedStep = false;
            try
            {
                automator.StartBrowser(url);

                foreach (var scenario in scenarios)
                {
                    foreach (var step in scenario.Steps.OrderBy(x => x.StepNumber))
                    {
                        testResult = automator.ExecuteStep(step);

                        if (testResult == false)
                        {

                            Console.WriteLine("\n" + scenario.Name + ": " + step.StepNumber + " - " + step.ActionName + "\n");
                            break;
                        }
                    }
                    if (testResult == false)
                    {
                        failedStep = true;
                    }
                }
                automator.CloseBrowser();
                if (failedStep == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                automator.CloseBrowser();
                Console.WriteLine("BeginTesting Error: " + ex.ToString());
                return false;
            }
        }
    }
}
