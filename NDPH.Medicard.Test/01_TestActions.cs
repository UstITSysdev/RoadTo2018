using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDPH.SeleniumWrapper;
using NDPH.AutomatedTestFramework;
using NDPH.AutomatedTestFramework.ScenarioReader;
using System.Xml;

namespace NDPH.Medicard.Test
{
    [TestClass]
    public class TestActions
    {
       

        [TestMethod]
        public void _Filter()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;
            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME,url,null,null);

            string excelFile = @"../../TestData/TestActions.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Filter";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);
        }


        [TestCleanup]
        public void CleanTest()
        {


        }
    }
    
}
