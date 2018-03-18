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
    public class Test_Method
    {
        public void executeTest(String url, String excelFile, String sheetName,string path,string finalSubPath)
        {

            Boolean bResult = false;

            string root = ConfigurationManager.AppSettings["Root_Path"];

            string finalPath = System.IO.Path.Combine(root,path);

            string subPath = System.IO.Path.Combine(finalPath,finalSubPath);

            string timeStamp = System.IO.Path.Combine(subPath, DateTime.Now.ToString("yyyy-MM-dd-HH"));
            
           IBrowserAutomator browser = new SeleniumBrowserAutomator(DriverType.CHROME,finalPath,subPath,timeStamp);

            IScenarioReader reader = new ExcelScenarioReader(excelFile);

            var scenarios = reader.Read(sheetName);

            AutomatedTestProcedure Add = new AutomatedTestProcedure(url, browser, scenarios);
            bResult = Add.BeginTesting();
            Assert.IsTrue(bResult);
        }
    }
}
