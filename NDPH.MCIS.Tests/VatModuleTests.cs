using System;
using System.Linq;
using NUnit.Framework;
using NDPH.MCIS.Tests;
using NDPH.SeleniumWrapper;
using NDPH.AutomatedTestFramework;
using NDPH.AutomatedTestFramework.ScenarioReader;
namespace NDPH.MCIS.Tests
{
    [TestFixture]
    public class VatModuleTests
    {
        private static object[] testCaseSource = TestDataSource.ScenarioSource;
        [Test]
        [TestCaseSource("testCaseSource")]
        public void CreateVat_CreateValidVAT_ShouldPass(string url, string fileName, string sheetName)
        {

            Boolean bResult = false;
            //try
            //{
     
            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME,null,"",null);

            string excelFile = @"../../TestData/PIRA_VAT.xlsx"; //string.Concat(@"../",fileName);
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
       

            var scenarios = reader.Read(sheetName);
            //scenarios = scenarios.Where(s => s.Name == scenarioName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);
        }
    }
}
