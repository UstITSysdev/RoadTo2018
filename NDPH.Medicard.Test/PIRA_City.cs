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
    public class PIRA_City
    {
        [TestMethod]
        public void City_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["City"];
            string sheetName = ConfigurationManager.AppSettings["City_Create"];
            string path = ConfigurationManager.AppSettings["City_Path"];
            string subPath = ConfigurationManager.AppSettings["City_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }

        [TestMethod]
        public void City_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["City"];
            string sheetName = ConfigurationManager.AppSettings["City_Update"];
            string path = ConfigurationManager.AppSettings["City_Path"];
            string subPath = ConfigurationManager.AppSettings["City_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }

        [TestMethod]
        public void City_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["City"];
            string sheetName = ConfigurationManager.AppSettings["City_Toggle"];
            string path = ConfigurationManager.AppSettings["City_Path"];
            string subPath = ConfigurationManager.AppSettings["City_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }

        [TestMethod]
        public void City_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["City"];
            string sheetName = ConfigurationManager.AppSettings["City_Delete"];
            string path = ConfigurationManager.AppSettings["City_Path"];
            string subPath = ConfigurationManager.AppSettings["City_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }

        [TestCleanup]
        public void CleanTest()
        {


        }
    }
    
}
