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
    public class PIRA_Region
    {
        [TestMethod]
        public void Region_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Region"];
            string sheetName = ConfigurationManager.AppSettings["Region_Create"];
            string path = ConfigurationManager.AppSettings["Region_Path"];
            string subPath = ConfigurationManager.AppSettings["Region_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Region_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Region"];
            string sheetName = ConfigurationManager.AppSettings["Region_Edit"];
            string path = ConfigurationManager.AppSettings["Region_Path"];
            string subPath = ConfigurationManager.AppSettings["Region_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Region_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Region"];
            string sheetName = ConfigurationManager.AppSettings["Region_Toggle"];
            string path = ConfigurationManager.AppSettings["Region_Path"];
            string subPath = ConfigurationManager.AppSettings["Region_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Region_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Region"];
            string sheetName = ConfigurationManager.AppSettings["Region_Delete"];
            string path = ConfigurationManager.AppSettings["Region_Path"];
            string subPath = ConfigurationManager.AppSettings["Region_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

    }
}