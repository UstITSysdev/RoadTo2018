using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Dapper;

namespace NDPH.AutomatedTestFramework.ScenarioReader

{

    public class ExcelScenarioReader : IScenarioReader
    {
        private string connectionString;

        public ExcelScenarioReader(string excelFilePath)
        {
            this.connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", excelFilePath);
        }

        public IEnumerable<Scenario> Read(string sheetName)
        {
            List<Scenario> scenarios = new List<Scenario>();
            string query;
            using (var connection = new OleDbConnection(this.connectionString))
            {
                connection.Open();
                query = string.Format("select * from [{0}$]", sheetName);
                var queryResult = connection.Query(query);
                                
                foreach (var row in queryResult)
                {
                    Scenario currentScenario = scenarios.Where(s => s.Name == row.ScenarioName).FirstOrDefault();
                    if (row.ScenarioName == null) {
                        break;
                    }
                    if (currentScenario == null)
                    {
                        currentScenario = new Scenario();
                        currentScenario.Name = row.ScenarioName;
                        scenarios.Add(currentScenario);
                    }

                    
                    Step newStep = new Step();
                    newStep.ScenarioName = sheetName + "-" + row.ScenarioName;
                    newStep.StepNumber = Convert.ToInt32(row.StepNumber);
                    newStep.ActionName = row.ActionName;
                    newStep.WaitingTime = (int)row.WaitingTime;
                    newStep.XpathExpression = row.XpathExpression;
                    newStep.ElementInformation = new ElementInfo
                    {
                         ElementType = row.ElementType,
                         ElementName = row.ElementName,
                         ElementValue = row.ElementValue
                         
                    };
                    newStep.FrameId = row.FrameId;
                    newStep.FilePath = row.FilePath;
                    currentScenario.Steps.Add(newStep);
                }
                return scenarios;
            }
        }
    }

}

