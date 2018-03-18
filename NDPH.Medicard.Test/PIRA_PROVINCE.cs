using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDPH.SeleniumWrapper;
using NDPH.AutomatedTestFramework;
using NDPH.AutomatedTestFramework.ScenarioReader;
using System.Xml;
using System.Configuration;

namespace NDPH.Medicard.Test
{
    [TestClass]
    public class PIRA_PROVINCE
    {
        [TestMethod]
        public void NewsFeeds_01Create()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME,null,null,null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Create";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }

        [TestMethod]
        public void NewsFeeds_02Delete()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME, null,"",null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Delete";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }

        [TestMethod]
        public void NewsFeeds_03Edit()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME, null,"",null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Edit";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }

        [TestMethod]
        public void NewsFeeds_04EditEV()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME, null,"",null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Create_EV";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }

        [TestMethod]
        public void NewsFeeds_05CreateEmptyFields()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME, null,"",null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Create_EV";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }

        [TestMethod]
        public void NewsFeeds_06CreateDuplicate()
        {
            XmlDocument webXml = new XmlDocument();
            webXml.Load(@"../../Web.xml");
            String url = Convert.ToString(webXml.SelectSingleNode("param").InnerText);

            Boolean bResult = false;

            IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME, null,"",null);

            string excelFile = @"../../TestData/BASE_R2S5-NewsFeeds.xlsx";
            IScenarioReader reader = new ExcelScenarioReader(excelFile);
            string sheetName = "Create_Duplicate";

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);

        }
    }
}