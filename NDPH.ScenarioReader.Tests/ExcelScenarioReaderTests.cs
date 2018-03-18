using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDPH.AutomatedTestFramework.ScenarioReader;
using NDPH.AutomatedTestFramework;
namespace NDPH.ScenarioReader.Tests
{
    [TestClass]
    public class ExcelScenarioReaderTests
    {
        [TestMethod]
        public void Read_MultiStepScenario_ShouldReturnAsScenarioList()
        {
            string excelFile = @"../../TestData/TestData.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "MultiStepScenario";
            //string scenarioName = "SampleScenario";

            var scenarios = reader.Read(sheetName); 

            Assert.IsInstanceOfType(scenarios, typeof(IEnumerable<Scenario>));
        }
    }
}
