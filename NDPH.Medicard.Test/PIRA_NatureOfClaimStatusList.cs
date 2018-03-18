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
    public class PIRA_NatureOfClaimStatusList
    {
        [TestMethod]
        public void NatureOfClaimStatusList_Assign()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOCSL"];
            string sheetName = ConfigurationManager.AppSettings["NOCSL_Assign"];
            string path = ConfigurationManager.AppSettings["NOCSL_Path"];
            string subPath = ConfigurationManager.AppSettings["NOCSL_Path_Assign"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void NatureOfClaimStatusList_Reorder()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOCSL"];
            string sheetName = ConfigurationManager.AppSettings["NOCSL_Reorder"];
            string path = ConfigurationManager.AppSettings["NOCSL_Path"];
            string subPath = ConfigurationManager.AppSettings["NOCSL_Path_Reorder"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void NatureOfClaimStatusList_Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOCSL"];
            string sheetName = ConfigurationManager.AppSettings["NOCSL_Delete"];
            string path = ConfigurationManager.AppSettings["NOCSL_Path"];
            string subPath = ConfigurationManager.AppSettings["NOCSL_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        
    }
}